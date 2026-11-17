using UnityEngine;
using UnityEngine.SceneManagement;

// Port fix: GameObject.Find ignores inactive objects. The parking lot hides ROOM_pet_man (and the
// furniture under room_BG/Room), so an activity that finished while the player was in the parking
// lot could not find its furniture to re-enable it: the Find returned null, the finish function threw,
// and the furniture button stayed disabled ("still doing the dishes"). Same bug in the original game.
// SceneFind.Find behaves like GameObject.Find, then falls back to searching inactive objects.
public static class SceneFind
{
    public static GameObject Find(string name)
    {
        var go = GameObject.Find(name);
        if (go != null || string.IsNullOrEmpty(name))
            return go;

        string first = name, rest = null;
        int slash = name.IndexOf('/');
        if (slash >= 0)
        {
            first = name.Substring(0, slash);
            rest = name.Substring(slash + 1);
        }

        for (int s = 0; s < SceneManager.sceneCount; s++)
        {
            var scene = SceneManager.GetSceneAt(s);
            if (!scene.isLoaded) continue;
            foreach (var root in scene.GetRootGameObjects())
            {
                foreach (var t in root.GetComponentsInChildren<Transform>(true))
                {
                    if (t.name != first) continue;
                    if (rest == null) return t.gameObject;
                    var child = t.Find(rest);
                    if (child != null) return child.gameObject;
                }
            }
        }
        return null;
    }
}
