using UnityEngine;

public class Char_Select_boss : MonoBehaviour
{
	public GameObject Window;

	private void Start()
	{
	}

	private void Update()
	{
		if ((Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space)) && Window != null)
		{
			Window.SetActive(false);
			Window = null;
		}
	}
}
