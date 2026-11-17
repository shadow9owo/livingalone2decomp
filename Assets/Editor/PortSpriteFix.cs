// Restores the 13 index-loaded spritesheets to the original game's slicing.
// Data: Assets/Editor/orig_sprites.tsv, extracted from the original 1.0.1 APK
// (texturePath, spriteName, x, y, width, height, pixelsPerUnit), in original LoadAll order.
//
// 1. Rewrites each sheet's sprite list (names, order, rects, centered pivot, original PPU).
// 2. Moves the loose <sheet>_<n>.asset sprites AssetRipper left in Resources to
//    Assets/RippedSprites (GUIDs kept, so scene/prefab references survive). In the original
//    game none of them were Resources entries; leaving them caused path collisions
//    (e.g. Clothes_man_2.asset vs the Clothes_man_2 sheet) that shifted LoadAll indices.
//
// Run: Unity -batchmode -quit -projectPath <proj> -executeMethod PortSpriteFix.Run
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

public static class PortSpriteFix
{
    const string Tsv = "Assets/Editor/orig_sprites.tsv";
    const string LooseDir = "Assets/RippedSprites";

    [MenuItem("Port/Restore Original Spritesheets")]
    public static void Run()
    {
        var rows = File.ReadAllLines(Tsv).Where(l => l.Length > 0).Select(l => l.Split('\t')).ToList();
        var bySheet = rows.GroupBy(r => r[0]).ToList();
        var spriteNames = new HashSet<string>(rows.Select(r => r[1]));

        AssetDatabase.StartAssetEditing();
        try
        {
            foreach (var sheet in bySheet)
            {
                var importer = (TextureImporter)AssetImporter.GetAtPath(sheet.Key);
                if (importer == null) { Debug.LogError("[PortSpriteFix] no importer: " + sheet.Key); continue; }
                float ppu = float.Parse(sheet.First()[6], System.Globalization.CultureInfo.InvariantCulture);
                importer.textureType = TextureImporterType.Sprite;
                importer.spriteImportMode = SpriteImportMode.Multiple;
                importer.spritePixelsPerUnit = ppu;
                importer.mipmapEnabled = false;
                importer.filterMode = FilterMode.Point;
                importer.textureCompression = TextureImporterCompression.Uncompressed;
                importer.maxTextureSize = 8192;
#pragma warning disable 618
                importer.spritesheet = sheet.Select(r => new SpriteMetaData
                {
                    name = r[1],
                    rect = new Rect(F(r[2]), F(r[3]), F(r[4]), F(r[5])),
                    alignment = (int)SpriteAlignment.Center,
                    pivot = new Vector2(0.5f, 0.5f),
                    border = Vector4.zero,
                }).ToArray();
#pragma warning restore 618
                EditorUtility.SetDirty(importer);
                importer.SaveAndReimport();
                Debug.Log($"[PortSpriteFix] {sheet.Key}: {sheet.Count()} sprites, ppu {ppu}");
            }
        }
        finally
        {
            AssetDatabase.StopAssetEditing();
        }

        if (!AssetDatabase.IsValidFolder(LooseDir))
            AssetDatabase.CreateFolder("Assets", "RippedSprites");
        int moved = 0;
        foreach (var guid in AssetDatabase.FindAssets("t:Sprite", new[] { "Assets/Resources" }))
        {
            var path = AssetDatabase.GUIDToAssetPath(guid);
            if (!path.EndsWith(".asset")) continue;
            var name = Path.GetFileNameWithoutExtension(path);
            if (!spriteNames.Contains(name)) continue;
            var err = AssetDatabase.MoveAsset(path, LooseDir + "/" + Path.GetFileName(path));
            if (string.IsNullOrEmpty(err)) moved++;
            else Debug.LogError($"[PortSpriteFix] move {path}: {err}");
        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();
        Debug.Log($"[PortSpriteFix] done: {bySheet.Count} sheets restored, {moved} loose sprites moved to {LooseDir}");
    }

    static float F(string s) => float.Parse(s, System.Globalization.CultureInfo.InvariantCulture);
}
