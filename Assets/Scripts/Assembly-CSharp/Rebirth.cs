using UnityEngine;

public class Rebirth : MonoBehaviour
{
	private int Ending_N;

	public GameObject SelectItem;

	public GameObject OK_btn;

	public GameObject Adsbtn;

	public GameObject ResultParent;

	public GameObject Backbtn;

	public GameObject title;

	public GameObject tip;

	public static int NewLife;

	private GameObject fanfare;

	private void Start()
	{
		PetPosition.bonuspercent = PlayerPrefs.GetFloat("bonuspercent");
		FeeCont.bonussale = PlayerPrefs.GetFloat("bonussale");
		RbirthItem.bonusmoney = PlayerPrefs.GetInt("bonusmoney");
		S2_4.Buff_pluspay = PlayerPrefs.GetFloat("Buff_pluspay");
		FurnBtn.Buff_minustime = PlayerPrefs.GetFloat("Buff_minustime");
		title.SetActive(true);
		OK_btn.SetActive(false);
		Ending_N = PlayerPrefs.GetInt("Ending_N");
		GameObject gameObject = GameObject.Find("canvas");
		GameObject gameObject2 = Object.Instantiate(ResultParent);
		gameObject2.transform.SetParent(gameObject.transform);
		gameObject2.transform.localPosition = ResultParent.transform.position;
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		fanfare = GameObject.Find("bbangbbare (Clone)");
	}

	public void FixedUpdate()
	{
		GameObject gameObject = GameObject.Find("panel(Clone)");
		if (gameObject == null)
		{
			OK_btn.SetActive(false);
			Adsbtn.SetActive(false);
		}
		else
		{
			OK_btn.SetActive(true);
			Adsbtn.SetActive(true);
		}
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
		{
			OKbtn();
		}
	}

	public void OKbtn()
	{
		GameObject.Find("ResultImgParent(Clone)").SetActive(false);
		SelectItem.SetActive(false);
		title.SetActive(false);
		tip.SetActive(true);
		Invoke("ReBirth", 8f);
	}

	public void Reset()
	{
		TimeCont.Rebirth++;
		PlayerPrefs.SetInt("Rebirth", TimeCont.Rebirth);
		GraduateCont.GraduEnd_OK = 0;
		PlayerPrefs.SetInt("GraduEnd_OK", GraduateCont.GraduEnd_OK);
		ReportCont.EveryPoint = 0;
		PlayerPrefs.SetInt("EveryPoint", ReportCont.EveryPoint);
		PlayerPrefs.SetInt("s1_1", 0);
		SuddenDeathCont.Rebirth_OK = 2;
		PlayerPrefs.SetInt("Rebirth_OK", 2);
		PlayerPrefs.SetInt("GraduBonus", 0);
		GraduateCont.GraduBonus = PlayerPrefs.GetInt("GraduBonus");
		PlayerPrefs.DeleteKey("EveryPoint");
		BarCont.hp = BarCont.hp_Maxpoint;
		BarCont.mp = BarCont.mp_Maxpoint;
		BarCont.st = 100f;
		BarCont._int = BarCont.hp_Maxpoint;
		BarCont.happy = BarCont.happy_Maxpoint;
		PlayerPrefs.SetFloat("hp", BarCont.hp);
		PlayerPrefs.SetFloat("mp", BarCont.mp);
		PlayerPrefs.SetFloat("st", BarCont.st);
		PlayerPrefs.SetFloat("int", BarCont._int);
		PlayerPrefs.SetFloat("happy", BarCont.happy);
		BarCont.point = 0f;
		PlayerPrefs.SetFloat("point", BarCont.point);
		PlayerPrefs.SetInt("Clothes_N", 0);
		PlayerPrefs.SetInt("Hair_N", 0);
		if (RbirthItem.Item_N == 1)
		{
			PlayerPrefs.SetInt("Item_N_1", 1);
			PlayerPrefs.SetFloat("bonuspercent", PetPosition.bonuspercent);
		}
		if (RbirthItem.Item_N == 2)
		{
			PlayerPrefs.SetInt("Item_N_2", 1);
			PlayerPrefs.SetFloat("Buff_pluspay", S2_4.Buff_pluspay);
		}
		if (RbirthItem.Item_N == 3)
		{
			PlayerPrefs.SetInt("Item_N_3", 1);
			PlayerPrefs.SetFloat("bonussale", FeeCont.bonussale);
		}
		if (RbirthItem.Item_N == 4)
		{
			PlayerPrefs.SetInt("Item_N_4", 1);
			PlayerPrefs.SetFloat("Buff_minustime", FurnBtn.Buff_minustime);
		}
		if (RbirthItem.Item_N == 5)
		{
			PlayerPrefs.SetInt("Item_N_5", 1);
			PlayerPrefs.SetInt("bonusmoney", RbirthItem.bonusmoney);
			scene_controll.money += RbirthItem.bonusmoney;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
		}
		PlayerPrefs.SetFloat("minushairpoint_W", 0f);
		PlayerPrefs.SetInt("score1-1", 0);
		PlayerPrefs.SetInt("score1-2", 0);
		PlayerPrefs.SetInt("score2-1", 0);
		PlayerPrefs.SetInt("score2-2", 0);
		PlayerPrefs.SetInt("score3-1", 0);
		PlayerPrefs.SetInt("score3-2", 0);
		PlayerPrefs.SetInt("score4-1", 0);
		PlayerPrefs.SetInt("score4-2", 0);
		PlayerPrefs.SetInt("OneMonth", 3);
		PlayerPrefs.SetInt("OneSemes", 1);
		PlayerPrefs.SetInt("Grade", 1);
		PlayerPrefs.SetInt("S_class", 0);
		PlayerPrefs.SetInt("Y_class", 0);
		PlayerPrefs.SetInt("M_class", 0);
		PlayerPrefs.SetInt("E_class", 0);
		S2_4.E_class = PlayerPrefs.GetInt("E_class");
		S2_4.M_class = PlayerPrefs.GetInt("M_class");
		S2_4.Y_class = PlayerPrefs.GetInt("Y_class");
		S2_4.S_class = PlayerPrefs.GetInt("S_class");
		PlayerPrefs.DeleteKey("SaleMonthLife");
		PlayerPrefs.SetInt("Testcomplete", 0);
		ReportCont.Grade_N = 0;
	}

	public void ReBirth()
	{
		Application.LoadLevel("char_select");
	}
}
