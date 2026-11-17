// Build pipeline for the Living Alone 2 port (Unity 2022.3).
// Run headless:  Unity -batchmode -quit -projectPath <proj> -executeMethod PortBuild.All
//   PortBuild.Windows  -> Builds/Windows/LivingAlone2.exe   (x64, Mono)
//   PortBuild.Android  -> Builds/Android/LivingAlone2.apk   (IL2CPP, ARMv7 + ARM64)
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEditor.Build.Reporting;
using UnityEngine;

public static class PortBuild
{
    const string Product = "Living Alone 2";
    const string Company = "doomgamez";
    // Separate id so the port installs next to the original instead of replacing it.
    const string PackageId = "cc.doomgames.livingalone2port";
    // Original Play Store release was 1.0.1; the port continues from there.
    const string Version = "1.0.2";
    const int AndroidVersionCode = 102;

    // Start must be first: it is the boot scene. The rest load by name.
    static readonly string[] SceneOrder =
    {
        "Assets/Scene/Start.unity",
        "Assets/Scene/char_select.unity",
        "Assets/Scene/newone.unity",
        "Assets/Scene/newone2.unity",
        "Assets/Scene/ptj.unity",
        "Assets/Scene/Cashshop.unity",
        "Assets/Scene/Rebirth.unity",
        "Assets/Scene/ending.unity",
    };

    static string OutRoot => Path.GetFullPath(Path.Combine(Application.dataPath, "..", "Builds"));

    [MenuItem("Port/Build All")]
    public static void All()
    {
        Windows();
        Android();
    }

    static void Common()
    {
        foreach (var s in SceneOrder)
            if (!File.Exists(s)) throw new FileNotFoundException("Scene missing: " + s);
        EditorBuildSettings.scenes = SceneOrder.Select(s => new EditorBuildSettingsScene(s, true)).ToArray();

        PlayerSettings.productName = Product;
        PlayerSettings.companyName = Company;
        PlayerSettings.bundleVersion = Version;
        PlayerSettings.Android.bundleVersionCode = AndroidVersionCode;
        PlayerSettings.defaultInterfaceOrientation = UIOrientation.Portrait;
        PlayerSettings.allowedAutorotateToLandscapeLeft = false;
        PlayerSettings.allowedAutorotateToLandscapeRight = false;
        PlayerSettings.allowedAutorotateToPortraitUpsideDown = false;
        PlayerSettings.runInBackground = false;
        ApplyIcon();
    }

    // Original launcher icon, taken from the 1.0.1 APK (res/drawable-xxxhdpi-v4/app_icon.png, 192px).
    const string IconPath = "Assets/Icon/app_icon.png";

    static void ApplyIcon()
    {
        var imp = (TextureImporter)AssetImporter.GetAtPath(IconPath);
        if (imp == null) throw new FileNotFoundException("Icon missing: " + IconPath);
        if (imp.textureType != TextureImporterType.Default || imp.mipmapEnabled || !imp.isReadable ||
            imp.textureCompression != TextureImporterCompression.Uncompressed)
        {
            imp.textureType = TextureImporterType.Default;
            imp.mipmapEnabled = false;
            imp.isReadable = true;
            imp.filterMode = FilterMode.Point;
            imp.textureCompression = TextureImporterCompression.Uncompressed;
            imp.SaveAndReimport();
        }
        var icon = AssetDatabase.LoadAssetAtPath<Texture2D>(IconPath);

        // Default (all platforms, incl. the Windows exe and window)
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Unknown, new[] { icon });
        PlayerSettings.SetIconsForTargetGroup(BuildTargetGroup.Standalone,
            Enumerable.Repeat(icon, PlayerSettings.GetIconSizesForTargetGroup(BuildTargetGroup.Standalone).Length).ToArray());

        // Android legacy + round launcher icons, every density
        foreach (var kind in new[] { UnityEditor.Android.AndroidPlatformIconKind.Legacy, UnityEditor.Android.AndroidPlatformIconKind.Round })
        {
            var icons = PlayerSettings.GetPlatformIcons(UnityEditor.Build.NamedBuildTarget.Android, kind);
            foreach (var pi in icons) pi.SetTexture(icon);
            PlayerSettings.SetPlatformIcons(UnityEditor.Build.NamedBuildTarget.Android, kind, icons);
        }
    }

    [MenuItem("Port/Build Windows")]
    public static void Windows()
    {
        Common();
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.Mono2x);
        PlayerSettings.fullScreenMode = FullScreenMode.Windowed;
        PlayerSettings.defaultScreenWidth = 540;
        PlayerSettings.defaultScreenHeight = 960;
        PlayerSettings.resizableWindow = true;
        Run(BuildTarget.StandaloneWindows64, Path.Combine(OutRoot, "Windows", "LivingAlone2.exe"));
    }

    // QA build: same game under a different product name, so its PlayerPrefs (the save) are
    // separate from the real game's. Run with -smoketest to load every scene and log errors.
    [MenuItem("Port/Build Smoke Test")]
    public static void Smoke()
    {
        Common();
        PlayerSettings.productName = Product + " SmokeTest";
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Standalone, ScriptingImplementation.Mono2x);
        PlayerSettings.fullScreenMode = FullScreenMode.Windowed;
        PlayerSettings.defaultScreenWidth = 540;
        PlayerSettings.defaultScreenHeight = 960;
        Run(BuildTarget.StandaloneWindows64, Path.Combine(OutRoot, "SmokeTest", "LivingAlone2SmokeTest.exe"));
        PlayerSettings.productName = Product;
    }

    [MenuItem("Port/Build Android")]
    public static void Android()
    {
        Common();
        PlayerSettings.SetApplicationIdentifier(BuildTargetGroup.Android, PackageId);
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARMv7 | AndroidArchitecture.ARM64;
        PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel24;
        PlayerSettings.Android.targetSdkVersion = AndroidSdkVersions.AndroidApiLevelAuto;
        EditorUserBuildSettings.buildAppBundle = false;
        Run(BuildTarget.Android, Path.Combine(OutRoot, "Android", "LivingAlone2.apk"));
    }

    static void Run(BuildTarget target, string path)
    {
        Directory.CreateDirectory(Path.GetDirectoryName(path));
        var report = BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = SceneOrder,
            locationPathName = path,
            target = target,
            options = BuildOptions.None,
        });
        var s = report.summary;
        Debug.Log($"[PortBuild] {target}: {s.result}, {s.totalErrors} errors, {s.totalSize / (1024 * 1024)} MB -> {path}");
        if (s.result != BuildResult.Succeeded && Application.isBatchMode)
            EditorApplication.Exit(1);
    }
}
