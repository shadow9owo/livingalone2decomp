using UnityEngine;

public class suddenSound : MonoBehaviour
{
	public AudioClip SuddenDeath_sound;

	public void SuddenDeath_()
	{
		GetComponent<AudioSource>().clip = SuddenDeath_sound;
		GetComponent<AudioSource>().Play();
	}
}
