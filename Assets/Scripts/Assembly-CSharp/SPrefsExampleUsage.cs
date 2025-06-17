using UnityEngine;

public class SPrefsExampleUsage : MonoBehaviour
{
	private int playerProgress;

	private void Start()
	{
		if (SPrefs.HasKey("PlayerProgress"))
		{
			playerProgress = SPrefs.GetInt("PlayerProgress");
			Debug.Log("Player progress on this device: " + playerProgress);
		}
		else
		{
			playerProgress = 0;
			Debug.Log("No player progress found. Start application again, please!");
		}
		MakeProgress();
	}

	private void MakeProgress()
	{
		playerProgress++;
		SPrefs.SetInt("PlayerProgress", playerProgress);
		SPrefs.Save();
		Debug.Log("Progress saved!");
	}
}
