using System;
using UnityEngine;

public class EventTimer : MonoBehaviour
{
	public void Start()
	{
		string text = PlayerPrefs.GetString("LastTime", string.Empty);
		DateTime result;
		if (!string.IsNullOrEmpty(text) && !DateTime.TryParse(text, out result))
		{
		}
	}

	public void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
		{
			WhenGameQuit();
		}
	}

	public void WhenGameQuit()
	{
		PlayerPrefs.SetString("LastTime", DateTime.Now.ToString());
	}
}
