using UnityEngine;
using UnityEngine.UI;

public class ReportCont : MonoBehaviour
{
	public Transform T_Grade;

	public string[] Grade;

	public Transform Money;

	public Transform deunglokgem;

	public static int Janghak_money_;

	public Transform Scroe1_1;

	public Transform Scroe1_2;

	public Transform Scroe2_1;

	public Transform Scroe2_2;

	public Transform Scroe3_1;

	public Transform Scroe3_2;

	public Transform Scroe4_1;

	public Transform Scroe4_2;

	public Transform E_T;

	public Transform M_T;

	public Transform Y_T;

	public Transform S_T;

	public Transform monthlyFee;

	public Transform roomprice_T;

	public Transform Salemoney;

	public Transform haireffect;

	public SoundEffect_newone _SoundEffect_newone;

	public TimeCont _timmcont;

	public Transform Nickname;

	public GameObject NowGrade;

	public GameObject Sungjeokpyo;

	private GameObject _backbtn;

	private GameObject _Timecont;

	private GameObject _FeeCont;

	public int roomprice;

	public static int Grade_N;

	public static int EveryPoint;

	public SuddenDeathCont _SuddenDeathCont;

	private int I_PlusPoint;

	public TextUP _TextUP;

	public static int Score1_1;

	public static int Score1_2;

	public static int Score2_1;

	public static int Score2_2;

	public static int Score3_1;

	public static int Score3_2;

	public static int Score4_1;

	public static int Score4_2;

	public GameObject AllScoreScreen;

	public GameObject Adopt;

	public GameObject Pet;

	private void Start()
	{
		_FeeCont = GameObject.Find("FeeCont");
		Score1_2 = PlayerPrefs.GetInt("score1-2");
		Char.Sex = PlayerPrefs.GetInt("Sex");
		_backbtn = GameObject.Find("BackBtn");
		EveryPoint = PlayerPrefs.GetInt("EveryPoint");
		FeeCont.MonthHouse = PlayerPrefs.GetInt("MonthHouse");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		if (Head.Hair_N == 0)
		{
			PlayerPrefs.SetFloat("minushairpoint_W", 0.01f);
		}
		s3_7.minushairpoint_W = PlayerPrefs.GetFloat("minushairpoint_W");
		if (Char.Sex == 0)
		{
			FeeCont.SaleMonthLife_M = PlayerPrefs.GetFloat("SaleMonthLife_M");
		}
		if (Char.Sex == 1)
		{
			FeeCont.SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
		}
		Nickname.GetComponent<Text>().text = string.Format("{0}", TalkingText.Name);
		Score1_1 = PlayerPrefs.GetInt("score1-1");
		Scroe1_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score1_1]);
		Score1_2 = PlayerPrefs.GetInt("score1-2");
		Scroe1_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score1_2]);
		Score2_1 = PlayerPrefs.GetInt("score2-1");
		Scroe2_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score2_1]);
		Score2_2 = PlayerPrefs.GetInt("score2-2");
		Scroe2_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score2_2]);
		Score3_1 = PlayerPrefs.GetInt("score3-1");
		Scroe3_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score3_1]);
		Score3_2 = PlayerPrefs.GetInt("score3-2");
		Scroe3_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score3_2]);
		Score4_1 = PlayerPrefs.GetInt("score4-1");
		Scroe4_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score4_1]);
		Score4_2 = PlayerPrefs.GetInt("score4-2");
		Scroe4_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score4_2]);
		setadopt();
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		FeeCont.HousePrice = PlayerPrefs.GetFloat("HousePrice");
		FeeCont.MonthHouse = PlayerPrefs.GetInt("MonthHouse");
		FeeCont.bonussale = PlayerPrefs.GetFloat("bonussale");
		_Timecont = GameObject.Find("TimeController");
		if (RoomCont.Room_N == 0)
		{
			RoomCont.Room_N = 1;
		}
		if (RoomCont.Room_N == 1)
		{
			roomprice = 200000;
		}
		if (RoomCont.Room_N == 2)
		{
			roomprice = 350000;
		}
		if (RoomCont.Room_N == 3)
		{
			roomprice = 400000;
		}
		if (RoomCont.Room_N == 4)
		{
			roomprice = 500000;
		}
		if (RoomCont.Room_N == 5)
		{
			roomprice = 550000;
		}
		if (RoomCont.Room_N == 6)
		{
			roomprice = 600000;
		}
		if (RoomCont.Room_N == 7)
		{
			roomprice = 700000;
		}
		if (RoomCont.Room_N == 8)
		{
			roomprice = 1000000;
		}
		if (RoomCont.Room_N == 9)
		{
			roomprice = 2000000;
		}
		if (RoomCont.Room_N == 10)
		{
			roomprice = 3000000;
		}
		if (RoomCont.Room_N == 11)
		{
			roomprice = 5000000;
		}
		if (RoomCont.Room_N == 12)
		{
			roomprice = 8000000;
		}
		if (RoomCont.Room_N == 13)
		{
			roomprice = 15000000;
		}
		if (RoomCont.Room_N == 14)
		{
			roomprice = 25000000;
		}
		if (RoomCont.Room_N == 15)
		{
			roomprice = 50000000;
		}
		if (RoomCont.Room_N == 16)
		{
			roomprice = 100000000;
		}
		if (RoomCont.Room_N == 17)
		{
			roomprice = 200000000;
		}
		S2_4.E_class = PlayerPrefs.GetInt("E_class");
		S2_4.M_class = PlayerPrefs.GetInt("M_class");
		S2_4.Y_class = PlayerPrefs.GetInt("Y_class");
		S2_4.S_class = PlayerPrefs.GetInt("S_class");
		if (TimeCont.OneMonth != 6 && TimeCont.OneMonth != 12)
		{
			Sungjeokpyo.GetComponent<Image>().color = new Color(0.4627451f, 0.4627451f, 0.4627451f);
			Money.GetComponent<Text>().text = string.Format("-");
			T_Grade.GetComponent<Text>().text = string.Format("-");
			deunglokgem.GetComponent<Text>().text = string.Format("-");
		}
	}

	public void report()
	{
		if (TimeCont.OneMonth != 6 && TimeCont.OneMonth != 12)
		{
			Sungjeokpyo.GetComponent<Image>().color = new Color(0.4627451f, 0.4627451f, 0.4627451f);
			Money.GetComponent<Text>().text = string.Format("-");
			T_Grade.GetComponent<Text>().text = string.Format("-");
			deunglokgem.GetComponent<Text>().text = string.Format("-");
		}
		if (TimeCont.OneMonth == 6 && BarCont.st < 0.1f)
		{
			OneSemester();
			Sungjeokpyo.GetComponent<Image>().color = Color.white;
		}
		if (TimeCont.Grade <= 5 && Score1_1 != 0 && TimeCont.OneMonth == 12 && BarCont.st < 0.1f)
		{
			OneSemester();
			Sungjeokpyo.GetComponent<Image>().color = Color.white;
		}
		if (TimeCont.OneMonth == 12 && Score1_1 == 0)
		{
			Sungjeokpyo.GetComponent<Image>().color = new Color(0.4627451f, 0.4627451f, 0.4627451f);
			Money.GetComponent<Text>().text = string.Format("-");
			T_Grade.GetComponent<Text>().text = string.Format("-");
			deunglokgem.GetComponent<Text>().text = string.Format("-");
		}
	}

	public void OneSemester()
	{
		deunglokgem.GetComponent<Text>().text = string.Format("4,500,000G");
		if (BarCont.point > 80f)
		{
			I_PlusPoint = 100;
			Grade_N = 12;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 4000000;
			EveryPoint += 12;
		}
		if (BarCont.point == 80f)
		{
			I_PlusPoint = 90;
			Grade_N = 11;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 3000000;
			EveryPoint += 11;
		}
		if (BarCont.point < 80f && BarCont.point > 70f)
		{
			I_PlusPoint = 85;
			Grade_N = 10;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 2000000;
			EveryPoint += 10;
		}
		if (BarCont.point <= 70f && BarCont.point > 60f)
		{
			I_PlusPoint = 80;
			Grade_N = 9;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 1000000;
			EveryPoint += 9;
		}
		if (BarCont.point == 60f)
		{
			I_PlusPoint = 70;
			Grade_N = 8;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 500000;
			EveryPoint += 8;
		}
		if (BarCont.point < 60f && BarCont.point > 50f)
		{
			I_PlusPoint = 60;
			Grade_N = 7;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 100000;
			EveryPoint += 7;
		}
		if (BarCont.point <= 50f && BarCont.point > 40f)
		{
			I_PlusPoint = 50;
			Grade_N = 6;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint += 6;
		}
		if (BarCont.point == 40f)
		{
			I_PlusPoint = 40;
			Grade_N = 5;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint += 5;
		}
		if (BarCont.point < 40f && BarCont.point > 30f)
		{
			I_PlusPoint = 30;
			Grade_N = 4;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint += 4;
		}
		if (BarCont.point <= 30f && BarCont.point > 20f)
		{
			I_PlusPoint = -15;
			Grade_N = 3;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint += 3;
		}
		if (BarCont.point == 20f)
		{
			I_PlusPoint = -20;
			Grade_N = 2;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint += 2;
		}
		if (BarCont.point < 20f)
		{
			I_PlusPoint = -25;
			Grade_N = 1;
			T_Grade.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
			Janghak_money_ = 0;
			EveryPoint++;
		}
		PlayerPrefs.SetInt("EveryPoint", EveryPoint);
		Money.GetComponent<Text>().text = string.Format("{0:n0}G", Janghak_money_);
		_FeeCont.GetComponent<FeeCont>().MonthReport_();
		reportScreen();
	}

	public void reportScreen()
	{
		if (TimeCont.Grade == 1)
		{
			Debug.Log("1학년");
			if (TimeCont.OneMonth == 6)
			{
				Debug.Log("7");
				Scroe1_1.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score1-1", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("1grade 1sem");
			}
			if (TimeCont.OneMonth == 12)
			{
				Scroe1_2.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score1-2", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("1grade 2sem");
				Debug.Log("score1 - 2");
			}
		}
		if (TimeCont.Grade == 2)
		{
			if (TimeCont.OneMonth == 6)
			{
				Scroe2_1.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score2-1", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("2grade sem");
			}
			if (TimeCont.OneMonth == 12)
			{
				Scroe2_2.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score2-2", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("2grade 2sem");
			}
		}
		if (TimeCont.Grade == 3)
		{
			if (TimeCont.OneMonth == 6)
			{
				Scroe3_1.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score3-1", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("3grade 1sem");
			}
			if (TimeCont.OneMonth == 12)
			{
				Scroe3_2.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score3-2", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("3grade 2sem");
				Debug.Log("4학년 1학기 4월");
			}
		}
		if (TimeCont.Grade == 4)
		{
			if (TimeCont.OneMonth == 6)
			{
				Scroe4_1.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score4-1", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("4grade 1sem");
			}
			if (TimeCont.OneMonth == 12)
			{
				Scroe4_2.GetComponent<Text>().text = string.Format("{0}", Grade[Grade_N]);
				PlayerPrefs.SetInt("score4-2", Grade_N);
				NowGrade.GetComponent<Text>().text = string.Format("4grade 2sem");
				Debug.Log("4학년 2학기 4월");
			}
		}
	}

	public void ScoreExit()
	{
		Debug.Log("ScoreExit");
		if (Grade_N == 1)
		{
			if (TimeCont.Grade == 4 && TimeCont.OneMonth == 12 && TimeCont.OneSemes == 2)
			{
				SuddenDeathCont.Death_14F = 0;
			}
			else
			{
				_SuddenDeathCont.OtherSuddenDeath();
				Debug.Log("F");
			}
		}
		else
		{
			_Timecont.GetComponent<TimeCont>().Start();
			Debug.Log("timecont.start");
		}
		PlayerPrefs.SetFloat("point", 0f);
		BarCont.point = PlayerPrefs.GetFloat("point");
	}

	public void GetScoreData()
	{
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_1(Clone)").GetComponent<Tuto_1>().NEXT();
		}
		FeeCont.MonthTOtal = PlayerPrefs.GetInt("MonthTOtal");
		Score1_1 = PlayerPrefs.GetInt("score1-1");
		Scroe1_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score1_1]);
		Score1_2 = PlayerPrefs.GetInt("score1-2");
		Scroe1_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score1_2]);
		Score2_1 = PlayerPrefs.GetInt("score2-1");
		Scroe2_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score2_1]);
		Score2_2 = PlayerPrefs.GetInt("score2-2");
		Scroe2_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score2_2]);
		Score3_1 = PlayerPrefs.GetInt("score3-1");
		Scroe3_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score3_1]);
		Score3_2 = PlayerPrefs.GetInt("score3-2");
		Scroe3_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score3_2]);
		Score4_1 = PlayerPrefs.GetInt("score4-1");
		Scroe4_1.GetComponent<Text>().text = string.Format("{0}", Grade[Score4_1]);
		Score4_2 = PlayerPrefs.GetInt("score4-2");
		Scroe4_2.GetComponent<Text>().text = string.Format("{0}", Grade[Score4_2]);
		S2_4.E_class = PlayerPrefs.GetInt("E_class");
		S2_4.M_class = PlayerPrefs.GetInt("M_class");
		S2_4.Y_class = PlayerPrefs.GetInt("Y_class");
		S2_4.S_class = PlayerPrefs.GetInt("S_class");
		E_T.GetComponent<Text>().text = string.Format("{0}", S2_4.E_class);
		M_T.GetComponent<Text>().text = string.Format("{0}", S2_4.M_class);
		Y_T.GetComponent<Text>().text = string.Format("{0}", S2_4.Y_class);
		S_T.GetComponent<Text>().text = string.Format("{0}", S2_4.S_class);
		FeeCont.MonthHouse = PlayerPrefs.GetInt("MonthHouse");
		monthlyFee.GetComponent<Text>().text = string.Format("{0:n0}G", FeeCont.MonthHouse);
		roomprice_T.GetComponent<Text>().text = string.Format("{0:n0}G", roomprice);
		if (Char.Sex == 0)
		{
			Salemoney.GetComponent<Text>().text = string.Format("-{0:n0}G", FeeCont.HousePrice);
		}
		if (Char.Sex == 1)
		{
			Salemoney.GetComponent<Text>().text = string.Format("-{0:n0}G", FeeCont.HousePrice);
		}
		Debug.Log("HousePrice" + FeeCont.HousePrice);
		AllScoreScreen.SetActive(true);
		haireffect.GetComponent<Text>().text = string.Format("{0}%", s3_7.minushairpoint_W * 100f);
		Pet.GetComponent<PetPosition>().SetPetInfor();
	}

	public void setadopt()
	{
		if (s3_7.PetBuyOK == 0)
		{
			Adopt.SetActive(true);
		}
		if (s3_7.PetBuyOK == 1)
		{
			Adopt.SetActive(false);
		}
	}

	public void AdoptSetfalse()
	{
		Adopt.SetActive(false);
	}

	public void AllscreenExit()
	{
		Invoke("AllScreenFalse", 0.1f);
	}

	public void AllScreenFalse()
	{
		AllScoreScreen.SetActive(false);
	}
}
