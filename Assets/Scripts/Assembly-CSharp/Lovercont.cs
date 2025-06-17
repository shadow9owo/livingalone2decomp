using UnityEngine;
using UnityEngine.UI;

public class Lovercont : MonoBehaviour
{
	public GameObject eventbar;

	public GameObject Loverbar_obj;

	public Image eventbar_img;

	public GameObject[] gem_img;

	public static int favor;

	public static int Phone;

	public static int Firsttime;

	public GameObject Smart_phone;

	public GameObject Smart_phone_1;

	public GameObject Love_getgem;

	public GameObject PhoneBtn;

	public GameObject Btn_notice;

	public GameObject Lover_Char;

	public static string Lovername;

	public string Reportcont__;

	public Text Lovername_T;

	public Text LoverLv_T;

	public Text Lover_Buff_T;

	public Image Lover_exp_bar;

	public static int LoverLv;

	public static int LoverMaxExp;

	public Image Head;

	public Image Clothes;

	public Sprite[] M_Head;

	public Sprite[] M_Clothes;

	public Sprite[] W_Head;

	public Sprite[] W_Clothes;

	public GameObject Notyet;

	private int f_200;

	private int f_400;

	private int f_600;

	private int f_800;

	private int f_1000;

	public GameObject NewLover;

	private void Start()
	{
		Firsttime = PlayerPrefs.GetInt("Firsttime");
		if (Firsttime == 0)
		{
			PlayerPrefs.SetInt("LoverLv", 1);
			LoverLv = PlayerPrefs.GetInt("LoverLv");
			PlayerPrefs.SetInt("LoverMaxExp", 50);
			LoverMaxExp = PlayerPrefs.GetInt("LoverMaxExp");
			PlayerPrefs.SetInt("favor", 0);
			favor = PlayerPrefs.GetInt("favor");
			LoverClothes.L_Clothes_N = Random.Range(0, 42);
			LoverHead.L_Hair_N = Random.Range(0, 34);
			PlayerPrefs.SetInt("L_Clothes_N", LoverClothes.L_Clothes_N);
			PlayerPrefs.SetInt("L_Hair_N", LoverHead.L_Hair_N);
			LoverClothes.L_Clothes_N = PlayerPrefs.GetInt("L_Clothes_N");
			LoverHead.L_Hair_N = PlayerPrefs.GetInt("L_Hair_N");
		}
		Phone = PlayerPrefs.GetInt("Phone");
		if (Phone == 0 && favor >= 500)
		{
			PlayerPrefs.SetInt("Phone", 1);
			Phone = PlayerPrefs.GetInt("Phone");
			PlayerPrefs.SetInt("favor", 0);
			favor = PlayerPrefs.GetInt("favor");
			GameObject.Find("Lover_window").GetComponent<Lovercont>().SetPhonebtn();
			GameObject.Find("TimeController").GetComponent<TimeCont>().SetLover();
		}
		SetPhonebtn();
		favor = PlayerPrefs.GetInt("favor");
		Lovername = PlayerPrefs.GetString("Lovername");
		LoverLv = PlayerPrefs.GetInt("LoverLv");
		LoverMaxExp = PlayerPrefs.GetInt("LoverMaxExp");
		f_200 = PlayerPrefs.GetInt("f_200");
		f_400 = PlayerPrefs.GetInt("f_400");
		f_600 = PlayerPrefs.GetInt("f_600");
		f_800 = PlayerPrefs.GetInt("f_800");
		f_1000 = PlayerPrefs.GetInt("f_1000");
		Setgem_img();
		SetLovebar();
	}

	public void ReallyReset()
	{
		Confrim_notice.notice_S = string.Format("Do you really want to break up?\nAll lover's information will disappear.");
		GameObject gameObject = (GameObject)Resources.Load("Confrim_notice");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Confrim_notice"));
		GameObject gameObject3 = base.gameObject;
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void Resetlover()
	{
		if (scene_controll.gem >= 100)
		{
			PlayerPrefs.SetInt("LoverLv", 1);
			LoverLv = PlayerPrefs.GetInt("LoverLv");
			PlayerPrefs.SetInt("LoverMaxExp", 50);
			LoverMaxExp = PlayerPrefs.GetInt("LoverMaxExp");
			PlayerPrefs.SetInt("favor", 0);
			favor = PlayerPrefs.GetInt("favor");
			PhoneBtn.SetActive(false);
			SetLovebar();
			if (Phone == 0)
			{
				Object.Destroy(GameObject.Find("Smartphone(Clone)"));
				Loverbar_obj.SetActive(false);
				Notyet.SetActive(true);
				GameObject.Find("BackBtn_Child").GetComponent<Button>().onClick.Invoke();
			}
			if (Phone == 1)
			{
				Object.Destroy(GameObject.Find("Smartphone_1(Clone)"));
				Lover_Char.SetActive(false);
				Notyet.SetActive(true);
			}
			PlayerPrefs.SetInt("Phone", 2);
			Phone = PlayerPrefs.GetInt("Phone");
			PlayerPrefs.SetInt("f_200", 0);
			f_200 = PlayerPrefs.GetInt("f_200");
			PlayerPrefs.SetInt("f_400", 0);
			f_400 = PlayerPrefs.GetInt("f_400");
			PlayerPrefs.SetInt("f_600", 0);
			f_600 = PlayerPrefs.GetInt("f_600");
			PlayerPrefs.SetInt("f_800", 0);
			f_800 = PlayerPrefs.GetInt("f_800");
			PlayerPrefs.SetInt("f_1000", 0);
			f_1000 = PlayerPrefs.GetInt("f_1000");
			scene_controll.gem -= 100;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
		else
		{
			No_gem_notice();
		}
	}

	public void Reallychange()
	{
		Confrim_notice.notice_S = string.Format("Do you really change gender of lover?");
		GameObject gameObject = (GameObject)Resources.Load("Confrim_notice");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Confrim_notice"));
		GameObject gameObject3 = base.gameObject;
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void ChangeloverSex()
	{
		if (scene_controll.gem >= 100)
		{
			LoverChar.L_Sex = PlayerPrefs.GetInt("L_Sex");
			if (LoverChar.L_Sex == 0)
			{
				PlayerPrefs.SetInt("L_Sex", 1);
			}
			if (LoverChar.L_Sex == 1)
			{
				PlayerPrefs.SetInt("L_Sex", 0);
			}
			LoverChar.L_Sex = PlayerPrefs.GetInt("L_Sex");
			GameObject.Find("L_Clothes").GetComponent<LoverClothes>().Start();
			GameObject.Find("L_Head").GetComponent<LoverHead>().Start();
			SetReport();
			scene_controll.gem -= 100;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
		else
		{
			No_gem_notice();
		}
	}

	public void No_gem_notice()
	{
		GameObject gameObject = (GameObject)Resources.Load("No_gem_notice");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("No_gem_notice"));
		GameObject gameObject3 = GameObject.Find("1_2");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
		Object.Destroy(GameObject.Find("No_gem_notice(Clone)"), 1.5f);
	}

	public void SetReport()
	{
		if (Phone == 1)
		{
			Lovername_T.text = string.Format(Lovername);
			LoverLv_T.text = string.Format("{0}", LoverLv);
			Lover_exp_bar.fillAmount = (float)favor / (float)LoverMaxExp;
			Lover_Buff_T.text = string.Format("{0}", LoverLv + 10);
			if (LoverChar.L_Sex == 0)
			{
				Head.sprite = M_Head[LoverHead.L_Hair_N];
				Clothes.sprite = M_Clothes[LoverClothes.L_Clothes_N];
			}
			if (LoverChar.L_Sex == 1)
			{
				Head.sprite = W_Head[LoverHead.L_Hair_N];
				Clothes.sprite = W_Clothes[LoverClothes.L_Clothes_N];
			}
		}
	}

	public void SetPhonebtn()
	{
		Phone = PlayerPrefs.GetInt("Phone");
		if (Phone == 0)
		{
			PhoneBtn.SetActive(true);
			Loverbar_obj.SetActive(true);
			Lover_Char.SetActive(false);
			Notyet.SetActive(true);
		}
		if (Phone == 1)
		{
			PhoneBtn.SetActive(false);
			Loverbar_obj.SetActive(false);
			Lover_Char.SetActive(true);
			Notyet.SetActive(false);
		}
		if (Phone == 2)
		{
			PhoneBtn.SetActive(false);
			Loverbar_obj.SetActive(false);
			Lover_Char.SetActive(false);
			Notyet.SetActive(true);
		}
	}

	public void NewLoverSet()
	{
		PhoneBtn.SetActive(true);
		Loverbar_obj.SetActive(true);
		Lover_Char.SetActive(false);
		Notyet.SetActive(true);
		PhoneBtn.GetComponent<Button>().interactable = true;
		Btn_notice.SetActive(true);
	}

	public void Setgem_img()
	{
		if (favor < 100)
		{
			gem_img[0].SetActive(true);
			gem_img[1].SetActive(false);
			gem_img[2].SetActive(false);
			gem_img[3].SetActive(false);
		}
		if (favor >= 100 && favor < 200)
		{
			gem_img[0].SetActive(false);
			gem_img[1].SetActive(true);
			gem_img[2].SetActive(false);
			gem_img[3].SetActive(false);
		}
		if (favor >= 200 && favor < 300)
		{
			gem_img[0].SetActive(false);
			gem_img[1].SetActive(false);
			gem_img[2].SetActive(true);
			gem_img[3].SetActive(false);
		}
		if (favor >= 300 && favor < 400)
		{
			gem_img[0].SetActive(false);
			gem_img[1].SetActive(false);
			gem_img[2].SetActive(false);
			gem_img[3].SetActive(true);
		}
		if (favor >= 400)
		{
			gem_img[0].SetActive(false);
			gem_img[1].SetActive(false);
			gem_img[2].SetActive(false);
			gem_img[3].SetActive(false);
		}
	}

	public void SetLovebar()
	{
		f_200 = PlayerPrefs.GetInt("f_200");
		f_400 = PlayerPrefs.GetInt("f_400");
		f_600 = PlayerPrefs.GetInt("f_600");
		f_800 = PlayerPrefs.GetInt("f_800");
		f_1000 = PlayerPrefs.GetInt("f_1000");
		if (Phone == 0)
		{
			eventbar_img.fillAmount = (float)favor / 500f;
			Setgem_img();
			if (favor >= 100 && favor < 200 && f_200 == 0)
			{
				scene_controll.gem += 5;
				SPrefs.SetInt("gem2", scene_controll.gem);
				Showgetgem();
				PlayerPrefs.SetInt("f_200", 1);
				f_200 = PlayerPrefs.GetInt("f_200");
			}
			if (favor >= 200 && favor < 300 && f_400 == 0)
			{
				scene_controll.gem += 10;
				SPrefs.SetInt("gem2", scene_controll.gem);
				Showgetgem();
				PlayerPrefs.SetInt("f_400", 1);
				f_400 = PlayerPrefs.GetInt("f_400");
			}
			if (favor >= 300 && favor < 400 && f_600 == 0)
			{
				scene_controll.gem += 30;
				SPrefs.SetInt("gem2", scene_controll.gem);
				Showgetgem();
				PlayerPrefs.SetInt("f_600", 1);
				f_600 = PlayerPrefs.GetInt("f_600");
			}
			if (favor >= 400 && favor < 500 && f_800 == 0)
			{
				scene_controll.gem += 100;
				SPrefs.SetInt("gem2", scene_controll.gem);
				Showgetgem();
				PlayerPrefs.SetInt("f_800", 1);
				f_800 = PlayerPrefs.GetInt("f_800");
			}
			if (favor >= 500 && f_1000 == 0)
			{
				Showgetgem();
				PlayerPrefs.SetInt("f_1000", 1);
				f_1000 = PlayerPrefs.GetInt("f_1000");
			}
		}
	}

	public void Showgetgem()
	{
		scene_controll.gem = SPrefs.GetInt("gem2");
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		GameObject gameObject = Object.Instantiate(Love_getgem);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject.transform.localScale = Smart_phone.transform.localScale;
	}

	public void Openwindow()
	{
		GameObject gameObject = Object.Instantiate(Smart_phone);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Smart_phone.transform.localPosition;
		gameObject.transform.localScale = Smart_phone.transform.localScale;
	}

	public void TalkLover()
	{
		GameObject gameObject = Object.Instantiate(Smart_phone_1);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Smart_phone_1.transform.localPosition;
		gameObject.transform.localScale = Smart_phone_1.transform.localScale;
	}

	public void NewLoverOpen()
	{
		GameObject gameObject = Object.Instantiate(NewLover);
		gameObject.transform.SetParent(base.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject.transform.localScale = NewLover.transform.localScale;
		SetPhonebtn();
	}
}
