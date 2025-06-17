using UnityEngine;

public class nonsleep : MonoBehaviour
{
	public void Awake()
	{
	}

	private void Start()
	{
		Screen.sleepTimeout = -1;
	}
}
