using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.SceneManagement;

// Port QA: only runs when the player is started with -smoketest (never in normal play).
// Loads every scene in build order, lets each run for a few seconds, records every error and
// exception (deduplicated, with stack trace), writes smoketest.txt next to Player.log, and quits.
public class SmokeTest : MonoBehaviour
{
    const float SecondsPerScene = 8f;
    readonly Dictionary<string, int> seen = new Dictionary<string, int>();
    readonly StringBuilder report = new StringBuilder();
    string currentScene = "?";

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void Boot()
    {
        if (System.Array.IndexOf(System.Environment.GetCommandLineArgs(), "-smoketest") < 0)
            return;
        var go = new GameObject("SmokeTest");
        DontDestroyOnLoad(go);
        go.AddComponent<SmokeTest>();
    }

    void Awake()
    {
        Application.logMessageReceived += OnLog;
    }

    void OnLog(string msg, string stack, LogType type)
    {
        if (type != LogType.Exception && type != LogType.Error && type != LogType.Assert)
            return;
        string key = currentScene + "|" + msg;
        if (seen.ContainsKey(key)) { seen[key]++; return; }
        seen[key] = 1;
        report.AppendLine($"[{currentScene}] {type}: {msg}");
        foreach (var line in stack.Split('\n'))
            if (line.Trim().Length > 0) report.AppendLine("      " + line.Trim());
    }

    IEnumerator Start()
    {
        int count = SceneManager.sceneCountInBuildSettings;
        for (int i = 0; i < count; i++)
        {
            string path = SceneUtility.GetScenePathByBuildIndex(i);
            currentScene = Path.GetFileNameWithoutExtension(path);
            report.AppendLine($"=== loading {currentScene}");
            SceneManager.LoadScene(i);
            yield return new WaitForSecondsRealtime(SecondsPerScene);
        }
        currentScene = "done";
        int total = 0;
        foreach (var v in seen.Values) total += v;
        report.AppendLine($"=== SMOKETEST DONE: {seen.Count} distinct errors, {total} total, {count} scenes");
        string outPath = Path.Combine(Application.persistentDataPath, "smoketest.txt");
        File.WriteAllText(outPath, report.ToString());
        Debug.Log("SMOKETEST written to " + outPath);
        Application.Quit(0);
    }
}
