using UnityEngine;

public class SoundEffect_newone : MonoBehaviour
{
	public AudioClip Button_1;

	public AudioClip Furn_Button;

	public AudioClip Coin_Sound;

	public AudioClip StudyIncrease;

	public AudioClip Success_sound;

	public AudioClip Fail_sound;

	public AudioClip Chaching_sound;

	private void Start()
	{
		TimeBuff.Buffer_N = PlayerPrefs.GetInt("Buffer_N");
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<AudioSource>().clip = Button_1;
			GetComponent<AudioSource>().Play();
		}
	}

	public void ButtonSound_1()
	{
		GetComponent<AudioSource>().clip = Button_1;
		GetComponent<AudioSource>().Play();
	}

	public void CoinSound()
	{
		GetComponent<AudioSource>().clip = Coin_Sound;
		GetComponent<AudioSource>().Play();
	}

	public void Study()
	{
		GetComponent<AudioSource>().clip = StudyIncrease;
		if (TimeBuff.Buffer_N == 0)
		{
			GetComponent<AudioSource>().pitch = 0.5f;
			GetComponent<AudioSource>().loop = true;
			Invoke("pitchReset", 24f);
			Invoke("loopReset", 20f);
		}
		if (TimeBuff.Buffer_N == 1)
		{
			GetComponent<AudioSource>().pitch = 0.4f;
			Invoke("pitchReset", 8f);
		}
		GetComponent<AudioSource>().Play();
	}

	public void FurnitureButton()
	{
		GetComponent<AudioSource>().clip = Furn_Button;
		GetComponent<AudioSource>().Play();
	}

	public void Success()
	{
		GetComponent<AudioSource>().clip = Success_sound;
		GetComponent<AudioSource>().Play();
	}

	public void Fail()
	{
		GetComponent<AudioSource>().clip = Fail_sound;
		GetComponent<AudioSource>().Play();
	}

	public void GoAbroad()
	{
		GetComponent<AudioSource>().clip = StudyIncrease;
		GetComponent<AudioSource>().loop = true;
		GetComponent<AudioSource>().Play();
		Invoke("loopReset", 5f);
	}

	public void Chaching()
	{
		GetComponent<AudioSource>().clip = Chaching_sound;
		GetComponent<AudioSource>().Play();
	}

	public void pitchReset()
	{
		GetComponent<AudioSource>().pitch = 1f;
	}

	public void loopReset()
	{
		GetComponent<AudioSource>().loop = false;
	}
}
