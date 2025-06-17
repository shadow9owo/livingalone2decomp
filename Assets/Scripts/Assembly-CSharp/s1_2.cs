using UnityEngine;

public class s1_2 : MonoBehaviour
{
	public GameObject man;

	public GameObject woman;

	public GameObject ss1_5;

	public GameObject ss1_2;

	private void Start()
	{
		if (Char.Sex == 0)
		{
			man.SetActive(true);
			woman.SetActive(false);
		}
		if (Char.Sex == 1)
		{
			man.SetActive(false);
			woman.SetActive(true);
		}
		Invoke("s1_5", 24f);
	}

	private void Update()
	{
	}

	public void btn_go_1_5()
	{
		ss1_2.SetActive(false);
		ss1_5.SetActive(true);
	}

	public void s1_5()
	{
		ss1_2.SetActive(false);
		ss1_5.SetActive(true);
	}
}
