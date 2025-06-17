using UnityEngine;

public class AudioCont : MonoBehaviour
{
	public GameObject Sounds;

	public GameObject SuddenDeathSound;

	public static int Mute_b;

	public void Awake()
	{
		Mute_b = PlayerPrefs.GetInt("Mute_b");
	}

	public void Start()
	{
		if (Mute_b == 1)
		{
			_mute();
		}
		if (Mute_b == 2)
		{
			Un_mute();
		}
	}

	public void _mute()
	{
		PlayerPrefs.SetInt("Mute_b", 1);
		Mute_b = PlayerPrefs.GetInt("Mute_b");
		GetComponent<AudioSource>().mute = true;
		Sounds.GetComponent<AudioSource>().mute = true;
		SuddenDeathSound.GetComponent<AudioSource>().mute = true;
		AudioListener.volume = 0f;
		Debug.Log("_mute" + AudioListener.volume);
	}

	public void Un_mute()
	{
		PlayerPrefs.SetInt("Mute_b", 2);
		Mute_b = PlayerPrefs.GetInt("Mute_b");
		GetComponent<AudioSource>().mute = false;
		Sounds.GetComponent<AudioSource>().mute = false;
		SuddenDeathSound.GetComponent<AudioSource>().mute = false;
		AudioListener.volume = 1f;
	}

	public void Quite()
	{
		PlayerPrefs.SetInt("Mute_b", 1);
		Mute_b = PlayerPrefs.GetInt("Mute_b");
	}

	public void Play()
	{
		PlayerPrefs.SetInt("Mute_b", 2);
		Mute_b = PlayerPrefs.GetInt("Mute_b");
	}

	public void QuiteSuddenDeath()
	{
		GetComponent<AudioSource>().Stop();
	}

	public void Playagain()
	{
		GetComponent<AudioSource>().Play();
	}
}
