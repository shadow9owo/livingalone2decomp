using UnityEngine;

public class Talking : MonoBehaviour
{
	public GameObject[] Head_Sex;

	public GameObject[] Clothes_Sex;

	public void Start()
	{
		Select_Head();
		Select_Clothes();
	}

	public void Select_Head()
	{
		if (Char.Sex == 0)
		{
			Head_Sex[0].SetActive(true);
			Head_Sex[1].SetActive(false);
		}
		if (Char.Sex == 1)
		{
			Head_Sex[0].SetActive(false);
			Head_Sex[1].SetActive(true);
		}
	}

	public void Select_Clothes()
	{
		if (Char.Sex == 0)
		{
			Clothes_Sex[0].SetActive(true);
			Clothes_Sex[1].SetActive(false);
		}
		if (Char.Sex == 1)
		{
			Clothes_Sex[0].SetActive(false);
			Clothes_Sex[1].SetActive(true);
		}
	}
}
