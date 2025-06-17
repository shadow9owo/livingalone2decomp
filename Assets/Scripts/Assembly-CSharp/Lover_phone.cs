using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lover_phone : MonoBehaviour
{
	public Text T_talkyou;

	public Text T_talkme;

	public Text T_answer1;

	public Text T_answer2;

	public Text T_answer3;

	public Text T_answer4;

	public GameObject Answer1;

	public GameObject Answer2;

	public GameObject Answer3;

	public GameObject Answer4;

	private Vector3 A1;

	private Vector3 A2;

	private Vector3 A3;

	public GameObject Talkbox_me;

	public GameObject Smart_Answer;

	public GameObject YouProfile;

	public GameObject MyProfile;

	public GameObject MakeNameWin;

	public GameObject LoveUp;

	public Sprite[] Boyhair;

	public Sprite[] Girlhair;

	private string S_talkyou;

	private string S_answer1;

	private string S_answer2;

	private string S_answer3;

	private string S_answer4;

	private int ran;

	public static int Newlover;

	public Text T_Yourname;

	public static int Ran_talkyou;

	private string S_Myanswer;

	public Text Lover_T;

	private void Start()
	{
		LoverHead.L_Hair_N = PlayerPrefs.GetInt("L_Hair_N");
		LoverClothes.L_Clothes_N = PlayerPrefs.GetInt("L_Clothes_N");
		Newlover = PlayerPrefs.GetInt("Newlover");
		if (Newlover == 0)
		{
			MakeNameWin.SetActive(true);
		}
		Lovercont.Lovername = PlayerPrefs.GetString("Lovername");
		T_Yourname.text = string.Format(Lovercont.Lovername);
		LoverChar.L_Sex = PlayerPrefs.GetInt("L_Sex");
		Lovercont.Phone = PlayerPrefs.GetInt("Phone");
		if (Lovercont.Phone == 0)
		{
			if (Char.Sex == 0)
			{
				PlayerPrefs.SetInt("L_Sex", 1);
			}
			if (Char.Sex == 1)
			{
				PlayerPrefs.SetInt("L_Sex", 0);
			}
		}
		if (LoverChar.L_Sex == 0)
		{
			YouProfile.GetComponent<Image>().sprite = Boyhair[LoverHead.L_Hair_N];
		}
		if (LoverChar.L_Sex == 1)
		{
			YouProfile.GetComponent<Image>().sprite = Girlhair[LoverHead.L_Hair_N];
		}
		if (Char.Sex == 0)
		{
			MyProfile.GetComponent<Image>().sprite = Boyhair[Head.Hair_N];
		}
		if (Char.Sex == 1)
		{
			MyProfile.GetComponent<Image>().sprite = Girlhair[Head.Hair_N];
		}
		SetText();
		Talkbox_me.SetActive(false);
		ran = Random.Range(1, 7);
		if (Lovercont.Phone == 0)
		{
			A1 = new Vector3(-3f, -113f, 0f);
			A2 = new Vector3(-4f, -228f, 0f);
			A3 = new Vector3(-4f, -345f, 0f);
		}
		if (Lovercont.Phone == 1)
		{
			A1 = new Vector3(2f, -67f, 0f);
			A2 = new Vector3(2f, -167f, 0f);
			A3 = new Vector3(2f, -266f, 0f);
		}
		if (ran == 1)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A1;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A2;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A3;
		}
		if (ran == 2)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A3;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A1;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A2;
		}
		if (ran == 3)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A3;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A2;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A1;
		}
		if (ran == 4)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A2;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A3;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A1;
		}
		if (ran == 5)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A1;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A3;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A2;
		}
		if (ran == 6)
		{
			Answer1.GetComponent<RectTransform>().anchoredPosition = A2;
			Answer2.GetComponent<RectTransform>().anchoredPosition = A1;
			Answer3.GetComponent<RectTransform>().anchoredPosition = A3;
		}
		Smart_Answer.SetActive(true);
	}

	public void SetText()
	{
		List<Dictionary<string, object>> list = CSVReader.Read("Lover_talk");
		Ran_talkyou = Random.Range(0, list.Count);
		S_talkyou = (string)list[Ran_talkyou]["Talkyou"];
		T_talkyou.text = string.Format("{0}", S_talkyou);
		S_answer1 = (string)list[Ran_talkyou]["Answer1"];
		T_answer1.text = string.Format("{0}", S_answer1);
		S_answer2 = (string)list[Ran_talkyou]["Answer2"];
		T_answer2.text = string.Format("{0}", S_answer2);
		S_answer3 = (string)list[Ran_talkyou]["Answer3"];
		T_answer3.text = string.Format("{0}", S_answer3);
		S_answer4 = (string)list[Ran_talkyou]["Answer4"];
		T_answer4.text = string.Format("{0}", S_answer4);
	}

	public void Answer1_btn()
	{
		Lovercont.favor++;
		PlayerPrefs.SetInt("favor", Lovercont.favor);
		S_Myanswer = S_answer1;
		SetTalkbox();
		LoveUp.GetComponent<Text>().text = string.Format("+1");
		GameObject gameObject = Object.Instantiate(LoveUp);
		GameObject gameObject2 = base.gameObject;
		gameObject.transform.SetParent(gameObject2.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Answer1.transform.localPosition;
		gameObject.transform.localScale = LoveUp.transform.localScale;
	}

	public void Answer2_btn()
	{
		Lovercont.favor += 3;
		PlayerPrefs.SetInt("favor", Lovercont.favor);
		S_Myanswer = S_answer2;
		SetTalkbox();
		LoveUp.GetComponent<Text>().text = string.Format("+3");
		GameObject gameObject = Object.Instantiate(LoveUp);
		GameObject gameObject2 = base.gameObject;
		gameObject.transform.SetParent(gameObject2.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Answer2.transform.localPosition;
		gameObject.transform.localScale = LoveUp.transform.localScale;
	}

	public void Answer3_btn()
	{
		Lovercont.favor += 5;
		PlayerPrefs.SetInt("favor", Lovercont.favor);
		S_Myanswer = S_answer3;
		SetTalkbox();
		LoveUp.GetComponent<Text>().text = string.Format("+5");
		GameObject gameObject = Object.Instantiate(LoveUp);
		GameObject gameObject2 = base.gameObject;
		gameObject.transform.SetParent(gameObject2.transform);
		gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Answer3.transform.localPosition;
		gameObject.transform.localScale = LoveUp.transform.localScale;
	}

	public void Answer4_btn()
	{
		if (scene_controll.gem >= 3)
		{
			scene_controll.gem -= 3;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			Lovercont.favor += 10;
			PlayerPrefs.SetInt("favor", Lovercont.favor);
			S_Myanswer = S_answer4;
			SetTalkbox();
			LoveUp.GetComponent<Text>().text = string.Format("+10");
			GameObject gameObject = Object.Instantiate(LoveUp);
			GameObject gameObject2 = base.gameObject;
			gameObject.transform.SetParent(gameObject2.transform);
			gameObject.transform.GetComponent<RectTransform>().anchoredPosition = Answer4.transform.localPosition;
			gameObject.transform.localScale = LoveUp.transform.localScale;
		}
		else
		{
			GameObject gameObject3 = (GameObject)Resources.Load("No_gem_notice");
			GameObject gameObject4 = (GameObject)Object.Instantiate(Resources.Load("No_gem_notice"));
			GameObject gameObject5 = GameObject.Find("Lover_window");
			gameObject4.transform.SetParent(gameObject5.transform);
			gameObject4.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject4.transform.localScale = gameObject3.transform.localScale;
			Invoke("deletegemalert", 1.5f);
		}
	}

	public void deletegemalert()
	{
		Object.Destroy(GameObject.Find("No_gem_notice(Clone)"));
	}

	public void SetTalkbox()
	{
		PlayerPrefs.SetInt("favor", Lovercont.favor);
		Lovercont.favor = PlayerPrefs.GetInt("favor");
		GameObject.Find("Lover_window").GetComponent<Lovercont>().SetLovebar();
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		T_talkme.text = string.Format("{0}", S_Myanswer);
		Talkbox_me.SetActive(true);
		Smart_Answer.SetActive(false);
		TimeCont.L_Minutes = 2;
		TimeCont.L_Seconds = 60;
		PlayerPrefs.SetInt("Stop", 0);
		TimeCont.Stop = PlayerPrefs.GetInt("Stop");
		GameObject.Find("TimeController").GetComponent<TimeCont>().L_MinusSeconds();
		PlayerPrefs.SetInt("Firsttime", 1);
		Lovercont.Firsttime = PlayerPrefs.GetInt("Firsttime");
		if (Lovercont.Phone == 1)
		{
			Lovercont.LoverLv = PlayerPrefs.GetInt("LoverLv");
			Lovercont.favor = PlayerPrefs.GetInt("favor");
			Lovercont.LoverMaxExp = PlayerPrefs.GetInt("LoverMaxExp");
			if (Lovercont.favor >= Lovercont.LoverMaxExp)
			{
				Lovercont.LoverLv++;
				PlayerPrefs.SetInt("LoverLv", Lovercont.LoverLv);
				Lovercont.LoverLv = PlayerPrefs.GetInt("LoverLv");
				PlayerPrefs.SetInt("favor", 0);
				Lovercont.favor = PlayerPrefs.GetInt("favor");
				Lovercont.LoverMaxExp += Lovercont.LoverLv * 10;
				PlayerPrefs.SetInt("LoverMaxExp", Lovercont.LoverMaxExp);
				Lovercont.LoverMaxExp = PlayerPrefs.GetInt("LoverMaxExp");
			}
		}
	}

	public void MakeNewLover_btn()
	{
		Confrim_notice.notice_S = string.Format("Do you want to name your partner as {0}?", Lover_T.text);
		GameObject gameObject = (GameObject)Resources.Load("Confrim_notice");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Confrim_notice"));
		GameObject gameObject3 = GameObject.Find("Smartphone(Clone)");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void MakeNewLover()
	{
		PlayerPrefs.SetInt("Newlover", 1);
		Newlover = PlayerPrefs.GetInt("Newlover");
		PlayerPrefs.SetString("Lovername", Lover_T.text);
		Lovercont.Lovername = PlayerPrefs.GetString("Lovername");
		T_Yourname.text = string.Format(Lovercont.Lovername);
		MakeNameWin.SetActive(false);
	}

	public void Reset()
	{
		GameObject.Find("Lover_window").GetComponent<Lovercont>().ReallyReset();
	}
}
