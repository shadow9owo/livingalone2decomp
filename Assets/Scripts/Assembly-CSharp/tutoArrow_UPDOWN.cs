using UnityEngine;

public class tutoArrow_UPDOWN : MonoBehaviour
{
	private bool UpDown;

	private void Start()
	{
		UpDown = false;
		Invoke("delay", 0.7f);
	}

	private void delay()
	{
		UpDown = true;
		Invoke("Start", 0.7f);
	}

	public void Update()
	{
		if (!UpDown)
		{
			base.gameObject.transform.Translate(Vector3.down * Time.deltaTime * 0.4f);
		}
		if (UpDown)
		{
			base.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 0.4f);
		}
	}
}
