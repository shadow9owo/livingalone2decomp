using System.Linq;
using UnityEngine;

// Port fix: the game indexes spritesheets by number (e.g. change_hair_3[103]).
// The original Unity 5.3 build returned each sheet as <sheet>_0 .. <sheet>_N.
// Newer Unity does not promise that order for sub-assets, so sort by the numeric
// suffix to keep every hard-coded index pointing at the same sprite as the original.
public static class SheetOrder
{
    public static Sprite[] LoadAll(string path)
    {
        return Resources.LoadAll<Sprite>(path).OrderBy(Suffix).ThenBy(s => s.name).ToArray();
    }

    static int Suffix(Sprite s)
    {
        int i = s.name.LastIndexOf('_');
        return i >= 0 && int.TryParse(s.name.Substring(i + 1), out int n) ? n : int.MaxValue;
    }
}
