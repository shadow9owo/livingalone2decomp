using UnityEngine;

// Port fix: the original only set 60 FPS in Char.Start(), so every scene before that ran at the
// platform default (30 FPS on Android), and the regenerated project defaults to the "Ultra"
// quality level (vsync + MSAA). The original 5.3 build shipped on "Simple": no vsync, no MSAA.
// Apply that before the first scene loads. 60 is kept as the cap because some Update() logic
// is frame-based; FixedUpdate-driven logic (text effects, timers) is unaffected either way.
public static class FrameRateBoot
{
    public const int TargetFps = 60;

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Apply()
    {
        int medium = System.Array.IndexOf(QualitySettings.names, "Medium");
        if (medium >= 0)
            QualitySettings.SetQualityLevel(medium, true);
        QualitySettings.vSyncCount = 0;
        QualitySettings.antiAliasing = 0;
        Application.targetFrameRate = TargetFps;
    }
}
