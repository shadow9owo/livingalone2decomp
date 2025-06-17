using UnityEngine;
using UnityEngine.UI;

public class Lover_getgem : MonoBehaviour
{
	public Text T_title;

	public Text T_info;

	public GameObject Mypic;

	public GameObject Yourpic;

	public Sprite[] Boyhair;

	public Sprite[] Girlhair;

	private void Start()
	{
		LoverHead.L_Hair_N = PlayerPrefs.GetInt("L_Hair_N");
		LoverClothes.L_Clothes_N = PlayerPrefs.GetInt("L_Clothes_N");
		if (Char.Sex == 0)
		{
			Mypic.GetComponent<Image>().sprite = Boyhair[Head.Hair_N];
		}
		if (Char.Sex == 1)
		{
			Mypic.GetComponent<Image>().sprite = Girlhair[Head.Hair_N];
		}
		if (LoverChar.L_Sex == 0)
		{
			Yourpic.GetComponent<Image>().sprite = Boyhair[LoverHead.L_Hair_N];
		}
		if (LoverChar.L_Sex == 1)
		{
			Yourpic.GetComponent<Image>().sprite = Girlhair[LoverHead.L_Hair_N];
		}
		if (Lovercont.favor >= 100 && Lovercont.favor < 200)
		{
			T_title.text = string.Format("Achieved 100 love point!");
			T_info.text = string.Format("You won 5 gems!");
		}
		if (Lovercont.favor >= 200 && Lovercont.favor < 300)
		{
			T_title.text = string.Format("Achieved 200 love point!");
			T_info.text = string.Format("You won 10 gems!");
		}
		if (Lovercont.favor >= 300 && Lovercont.favor < 400)
		{
			T_title.text = string.Format("Achieved 300 love point!");
			T_info.text = string.Format("You won 30 gems!");
		}
		if (Lovercont.favor >= 500 && Lovercont.favor < 500)
		{
			T_title.text = string.Format("Achieved 400 love point!");
			T_info.text = string.Format("You won 100 gems!");
		}
		if (Lovercont.favor >= 500)
		{
			T_title.text = string.Format("Achieved 500 love point!");
			T_info.text = string.Format("Your lover got home!");
			PlayerPrefs.SetInt("Phone", 1);
			Lovercont.Phone = PlayerPrefs.GetInt("Phone");
			PlayerPrefs.SetInt("favor", 0);
			Lovercont.favor = PlayerPrefs.GetInt("favor");
			GameObject.Find("Lover_window").GetComponent<Lovercont>().SetPhonebtn();
			GameObject.Find("TimeController").GetComponent<TimeCont>().SetLover();
		}
	}

	public void destroy()
	{
		GameObject.Find("BackBtn").GetComponent<BackBtn>().backbtnclick();
	}
}
