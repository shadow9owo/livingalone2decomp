using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Checkversion : MonoBehaviour
{
	private static Checkversion instance;

	public GameObject btn;

	public Text VersionText;

	private int softwareVersion;

	public static Checkversion GetInstance()
	{
		if (!instance)
		{
			instance = Object.FindObjectOfType<Checkversion>();
			if (!instance)
			{
				Debug.LogWarning("There needs to be one active CVersionCheckMgr script on a VersionCheckManager in your scene.");
			}
		}
		return instance;
	}

	[HideInInspector]
	private void Start()
	{
		VersionText.text = "v" + Application.version;
		StartCoroutine(PlayStoreVersionCheck());
	}

	public void Gotopage()
	{
		Application.OpenURL("https://doomgamescc.itch.io/");
	}

	public void CloseNotice()
	{
		btn.SetActive(false);
	}

	public void Nowversion()
	{
		Debug.Log(Application.version);
	}

	private IEnumerator PlayStoreVersionCheck()
	{
		yield return null;
        VersionText.text = Application.version + "shadowdevs port";
    }
}
