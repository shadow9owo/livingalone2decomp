using UnityEngine;
using UnityEngine.UI;

public class FeeCont : MonoBehaviour
{
	public Transform YearNSemes_T;

	public Transform EduFee_T;

	public static int EduFee;

	public static int Now_Janghak_money;

	public static int TotalFee_int;

	public GameObject WhiteImg;

	public Transform Nickname;

	public GameObject MoneyBar;

	public GameObject Nogem;

	public GameObject MonthReport;

	public Transform MonthHouse_T;

	public Transform MonthTotal_T;

	public Transform Month_T;

	public static int MonthHouse;

	public static float bonussale;

	public static int MonthTOtal;

	public static float SaleMonthLife_M;

	public static float SaleMonthLife_W;

	public SuddenDeathCont _SuddenDeahtCont;

	public static float HousePrice;

	public GameObject HousePrice_T;

	public TimeCont _TimeCont;

	public ReportCont _ReportCont;

	public GameObject _SuddenDeathCont;

	private int MomHelp;

	public Lovercont _Lovercont;

	public TextUP _TextUP;

	public void Start()
	{
		Char.Sex = PlayerPrefs.GetInt("Sex");
		SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
		SaleMonthLife_M = PlayerPrefs.GetFloat("SaleMonthLife_M");
		_SuddenDeathCont = GameObject.Find("SuddenDeathCont");
		FeeReport();
		MonthReport_();
		bonussale = PlayerPrefs.GetFloat("bonussale");
		PlayerPrefs.SetFloat("bonussale", bonussale);
		MomHelp = PlayerPrefs.GetInt("MomHelp");
	}

	public void FeeReport()
	{
		Nickname.GetComponent<Text>().text = string.Format("Name {0}", TalkingText.Name);
		YearNSemes_T.GetComponent<Text>().text = string.Format("{0}grade{1}Sem", TimeCont.Grade, TimeCont.OneSemes);
		if (TimeCont.OneSemes == 1)
		{
			YearNSemes_T.GetComponent<Text>().text = string.Format("{0}grade 1st Sem", TimeCont.Grade);
		}
		if (TimeCont.OneSemes == 2)
		{
			YearNSemes_T.GetComponent<Text>().text = string.Format("{0}grade 2nd Sem", TimeCont.Grade);
		}
		EduFee = 4500000;
		TotalFee_int = EduFee;
		if (TotalFee_int <= 0)
		{
			TotalFee_int = 0;
		}
	}

	public void MonthReport_()
	{
		if (TimeCont.OneMonth == 1)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof January");
		}
		if (TimeCont.OneMonth == 2)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof February");
		}
		if (TimeCont.OneMonth == 3)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof March");
		}
		if (TimeCont.OneMonth == 4)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof April");
		}
		if (TimeCont.OneMonth == 5)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof May");
		}
		if (TimeCont.OneMonth == 6)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof June");
		}
		if (TimeCont.OneMonth == 7)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof July");
		}
		if (TimeCont.OneMonth == 8)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof August");
		}
		if (TimeCont.OneMonth == 9)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof September");
		}
		if (TimeCont.OneMonth == 10)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof October");
		}
		if (TimeCont.OneMonth == 11)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof November");
		}
		if (TimeCont.OneMonth == 12)
		{
			Month_T.GetComponent<Text>().text = string.Format("Monthly Payments\nof December");
		}
		if (Char.Sex == 0)
		{
			if (RoomCont.Room_N == 1)
			{
				MonthHouse = 200000;
			}
			if (RoomCont.Room_N == 2)
			{
				HousePrice = 350000f;
				MonthHouse = 350000;
			}
			if (RoomCont.Room_N == 3)
			{
				HousePrice = 400000f;
				MonthHouse = 400000;
			}
			if (RoomCont.Room_N == 4)
			{
				HousePrice = 500000f;
				MonthHouse = 500000;
			}
			if (RoomCont.Room_N == 5)
			{
				HousePrice = 550000f;
				MonthHouse = 550000;
			}
			if (RoomCont.Room_N == 6)
			{
				HousePrice = 600000f;
				MonthHouse = 600000;
			}
			if (RoomCont.Room_N == 7)
			{
				HousePrice = 700000f;
				MonthHouse = 700000;
			}
			if (RoomCont.Room_N == 8)
			{
				HousePrice = 1000000f;
				MonthHouse = 1000000;
			}
			if (RoomCont.Room_N == 9)
			{
				HousePrice = 2000000f;
				MonthHouse = 2000000;
			}
			if (RoomCont.Room_N == 10)
			{
				HousePrice = 3000000f;
				MonthHouse = 3000000;
			}
			if (RoomCont.Room_N == 11)
			{
				HousePrice = 5000000f;
				MonthHouse = 5000000;
			}
			if (RoomCont.Room_N == 12)
			{
				HousePrice = 8000000f;
				MonthHouse = 8000000;
			}
			if (RoomCont.Room_N == 13)
			{
				HousePrice = 15000000f;
				MonthHouse = 15000000;
			}
			if (RoomCont.Room_N == 14)
			{
				HousePrice = 25000000f;
				MonthHouse = 25000000;
			}
			if (RoomCont.Room_N == 15)
			{
				HousePrice = 50000000f;
				MonthHouse = 50000000;
			}
			if (RoomCont.Room_N == 16)
			{
				HousePrice = 100000000f;
				MonthHouse = 100000000;
			}
			if (RoomCont.Room_N == 17)
			{
				HousePrice = 200000000f;
				MonthHouse = 200000000;
			}
		}
		if (Char.Sex == 1)
		{
			if (RoomCont.Room_N == 1)
			{
				HousePrice = 200000f;
				MonthHouse = 200000;
			}
			if (RoomCont.Room_N == 2)
			{
				HousePrice = 350000f;
				MonthHouse = 350000;
			}
			if (RoomCont.Room_N == 3)
			{
				HousePrice = 400000f;
				MonthHouse = 400000;
			}
			if (RoomCont.Room_N == 4)
			{
				HousePrice = 500000f;
				MonthHouse = 500000;
			}
			if (RoomCont.Room_N == 5)
			{
				HousePrice = 550000f;
				MonthHouse = 550000;
			}
			if (RoomCont.Room_N == 6)
			{
				HousePrice = 600000f;
				MonthHouse = 600000;
			}
			if (RoomCont.Room_N == 7)
			{
				HousePrice = 700000f;
				MonthHouse = 700000;
			}
			if (RoomCont.Room_N == 8)
			{
				HousePrice = 1000000f;
				MonthHouse = 1000000;
			}
			if (RoomCont.Room_N == 9)
			{
				HousePrice = 2000000f;
				MonthHouse = 2000000;
			}
			if (RoomCont.Room_N == 10)
			{
				HousePrice = 3000000f;
				MonthHouse = 3000000;
			}
			if (RoomCont.Room_N == 11)
			{
				HousePrice = 5000000f;
				MonthHouse = 5000000;
			}
			if (RoomCont.Room_N == 12)
			{
				HousePrice = 8000000f;
				MonthHouse = 8000000;
			}
			if (RoomCont.Room_N == 13)
			{
				HousePrice = 15000000f;
				MonthHouse = 15000000;
			}
			if (RoomCont.Room_N == 14)
			{
				HousePrice = 25000000f;
				MonthHouse = 25000000;
			}
			if (RoomCont.Room_N == 15)
			{
				HousePrice = 50000000f;
				MonthHouse = 50000000;
			}
			if (RoomCont.Room_N == 16)
			{
				HousePrice = 100000000f;
				MonthHouse = 100000000;
			}
			if (RoomCont.Room_N == 17)
			{
				HousePrice = 200000000f;
				MonthHouse = 200000000;
			}
		}
		PlayerPrefs.SetInt("MonthHouse", MonthHouse);
		MonthHouse = PlayerPrefs.GetInt("MonthHouse");
		if (RoomCont.Room_N == 1)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 200000);
		}
		if (RoomCont.Room_N == 2)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 350000);
		}
		if (RoomCont.Room_N == 3)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 400000);
		}
		if (RoomCont.Room_N == 4)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 500000);
		}
		if (RoomCont.Room_N == 5)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 550000);
		}
		if (RoomCont.Room_N == 6)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 600000);
		}
		if (RoomCont.Room_N == 7)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 700000);
		}
		if (RoomCont.Room_N == 8)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 1000000);
		}
		if (RoomCont.Room_N == 9)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 2000000);
		}
		if (RoomCont.Room_N == 10)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 3000000);
		}
		if (RoomCont.Room_N == 11)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 5000000);
		}
		if (RoomCont.Room_N == 12)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 8000000);
		}
		if (RoomCont.Room_N == 13)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 15000000);
		}
		if (RoomCont.Room_N == 14)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 25000000);
		}
		if (RoomCont.Room_N == 15)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 50000000);
		}
		if (RoomCont.Room_N == 16)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 100000000);
		}
		if (RoomCont.Room_N == 17)
		{
			MonthHouse_T.GetComponent<Text>().text = string.Format("{0:n0}G", 200000000);
		}
		HousePrice_T.GetComponent<Text>().text = string.Format("-{0:n0}G", HousePrice);
		if (TimeCont.OneMonth != 6 && TimeCont.OneMonth != 12)
		{
			MonthTOtal = MonthHouse;
		}
		if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
		{
			MonthTOtal = MonthHouse + EduFee - ReportCont.Janghak_money_;
			Debug.Log("ddd");
		}
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		MonthTotal_T.GetComponent<Text>().text = string.Format("{0:n0}G", MonthTOtal);
	}

	public void FeeDeath()
	{
		SuddenDeathCont.Death_8F = PlayerPrefs.GetInt("Death_8");
		Debug.Log("scene_controll.money" + scene_controll.money);
		Debug.Log("MonthTOtal" + MonthTOtal);
		if (scene_controll.money <= MonthTOtal)
		{
			if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
			{
				PlayerPrefs.SetFloat("point", 0f);
				BarCont.point = PlayerPrefs.GetFloat("point");
				PlayerPrefs.SetInt("Testcomplete", 0);
				scene_controll_2.Testcomplete = PlayerPrefs.GetInt("Testcomplete");
				Debug.Log("Testcomplete" + scene_controll_2.Testcomplete);
			}
			if (MomHelp == 0)
			{
				if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
				{
					scene_controll.money += MonthTOtal;
					scene_controll.money_Text = scene_controll.money.ToString();
					SPrefs.SetString("final_money2", scene_controll.money_Text);
					Debug.Log("momhelp");
					PlayerPrefs.SetInt("MomHelp", 1);
					MomHelp = PlayerPrefs.GetInt("MomHelp");
					GameObject gameObject = GameObject.Find("1_2");
					GameObject gameObject2 = (GameObject)Resources.Load("Momshelp");
					GameObject gameObject3 = (GameObject)Object.Instantiate(Resources.Load("Momshelp"));
					gameObject3.transform.SetParent(gameObject.transform);
					gameObject3.transform.localPosition = gameObject2.transform.localPosition;
					gameObject3.transform.localScale = gameObject2.transform.localScale;
					return;
				}
				scene_controll.money -= MonthTOtal;
				EventCont.Plus_MONEY = -MonthTOtal;
				scene_controll.money_Text = scene_controll.money.ToString();
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				_TextUP.PlusMONEY();
			}
			else
			{
				scene_controll.money -= MonthTOtal;
				EventCont.Plus_MONEY = -MonthTOtal;
				scene_controll.money_Text = scene_controll.money.ToString();
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				_TextUP.PlusMONEY();
			}
		}
		if (scene_controll.money <= MonthTOtal)
		{
			return;
		}
		if (ReportCont.Grade_N == 1)
		{
			if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1)
			{
				SuddenDeathCont.Death_14F = 0;
			}
			if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
			{
				ReportCont.Grade_N = 0;
			}
		}
		else
		{
			MonthReport.SetActive(false);
			if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
			{
				PlayerPrefs.SetFloat("point", 0f);
				BarCont.point = PlayerPrefs.GetFloat("point");
				PlayerPrefs.SetInt("Testcomplete", 0);
				scene_controll_2.Testcomplete = PlayerPrefs.GetInt("Testcomplete");
				Debug.Log("Testcomplete" + scene_controll_2.Testcomplete);
			}
			_TimeCont.GetComponent<TimeCont>().SetTimeText();
			TimeCont.OneMonth++;
			if (TimeCont.OneMonth >= 13)
			{
				TimeCont.OneMonth = 1;
			}
			PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
			TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
			_TextUP.PlusMONTH();
			_TimeCont.SetTimeText();
			if (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 9)
			{
				_TimeCont.Semester();
			}
			PlayerPrefs.SetInt("VACAOK", 0);
			TimeCont.VACAOK = PlayerPrefs.GetInt("VACAOK");
			if (TimeCont.OneMonth == 7)
			{
				_TimeCont.ShowVacaSignImage();
			}
			if (TimeCont.OneMonth == 1 && TimeCont.Grade < 4)
			{
				_TimeCont.ShowVacaSignImage();
			}
			PlayerPrefs.SetFloat("st", 100f);
			BarCont.st = PlayerPrefs.GetFloat("st");
			if (Lovercont.Phone == 2 && (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 5 || TimeCont.OneMonth == 9 || TimeCont.OneMonth == 11))
			{
				_Lovercont.NewLoverOpen();
			}
		}
		scene_controll.money -= MonthTOtal;
		EventCont.Plus_MONEY = -MonthTOtal;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		_TextUP.PlusMONEY();
	}

	public void death23_closemonth()
	{
		if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
		{
			PlayerPrefs.SetFloat("point", 0f);
			BarCont.point = PlayerPrefs.GetFloat("point");
			PlayerPrefs.SetInt("Testcomplete", 0);
			scene_controll_2.Testcomplete = PlayerPrefs.GetInt("Testcomplete");
			Debug.Log("Testcomplete" + scene_controll_2.Testcomplete);
		}
		MonthReport.SetActive(false);
		TimeCont.OneMonth++;
		if (TimeCont.OneMonth >= 13)
		{
			TimeCont.OneMonth = 1;
		}
		PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
		TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
		if (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 9)
		{
			_TimeCont.Semester();
		}
		PlayerPrefs.SetInt("VACAOK", 0);
		TimeCont.VACAOK = PlayerPrefs.GetInt("VACAOK");
		if (TimeCont.OneMonth == 7)
		{
			_TimeCont.ShowVacaSignImage();
		}
		if (TimeCont.OneMonth == 1 && TimeCont.Grade < 4)
		{
			_TimeCont.ShowVacaSignImage();
		}
		EventCont.Plus_MONEY = SuddenDeathCont.SuddenDeahtPlusmoney;
		_TimeCont.SetTimeText();
		_TextUP.PlusMONTH();
		_TextUP.PlusMONEY();
	}

	public void Closemonth()
	{
		MonthReport.SetActive(false);
	}
}
