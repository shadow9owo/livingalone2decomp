using UnityEngine;
using UnityEngine.UI;

public class Talk_m : MonoBehaviour
{
	public Sprite[] Head_m;

	public Sprite[] man_Clothes;

	public Sprite[] Clothes_m;

	public Sprite[] woman_Clothes;

	public GameObject hairObj_m;

	public GameObject clotheObj_m;

	public GameObject hairObj_w;

	public GameObject clotheObj_w;

	public int FrontHead;

	private int head_number;

	private void Start()
	{
	}

	public void Update()
	{
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		if (head_number == 0)
		{
			head_number = 0;
		}
		else
		{
			head_number = Head.Hair_N - 1;
		}
		if (Char.Sex == 0)
		{
			Image component = hairObj_m.GetComponent<Image>();
			component.sprite = Head_m[head_number];
		}
		if (Char.Sex == 1)
		{
			Image component2 = hairObj_w.GetComponent<Image>();
			component2.sprite = Clothes_m[head_number];
		}
		if (Char.Sex == 0)
		{
			Image component3 = clotheObj_m.GetComponent<Image>();
			component3.sprite = man_Clothes[Clothes.Clothes_N];
		}
		if (Char.Sex == 1)
		{
			Image component4 = clotheObj_w.GetComponent<Image>();
			component4.sprite = woman_Clothes[Clothes.Clothes_N];
		}
	}
}
