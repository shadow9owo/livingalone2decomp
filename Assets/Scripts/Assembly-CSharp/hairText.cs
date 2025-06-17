using UnityEngine;
using UnityEngine.UI;

public class hairText : MonoBehaviour
{
	public Transform[] hairmoney_T;

	public Transform[] w_hairmoney_T;

	private int HairPrice;

	private void Start()
	{
		Char.Sex = PlayerPrefs.GetInt("Sex");
		if (Char.Sex == 0)
		{
			Man();
		}
		if (Char.Sex == 1)
		{
			Woman();
		}
	}

	public void Man()
	{
		HairPrice = 50000;
		for (int i = 0; i < hairmoney_T.Length; i++)
		{
			hairmoney_T[i].GetComponent<Text>().text = string.Format("{0:n0}", HairPrice);
		}
	}

	public void Woman()
	{
		HairPrice = 100000;
		for (int i = 0; i < w_hairmoney_T.Length; i++)
		{
			w_hairmoney_T[i].GetComponent<Text>().text = string.Format("{0:n0}", HairPrice);
		}
	}
}
