using System;
using TapjoyUnity;
using UnityEngine;
using UnityEngine.UI;

public class TimeCont : MonoBehaviour
{
	public static int OneMonth;

	public static int Grade;

	public static int Rebirth;

	public static int OneSemes;

	public Transform T_Month;

	public Transform T_Grade;

	public Transform T_Rebirth;

	public Transform EventTimer;

	public Transform T_Semes;

	public static int Heart_N;

	public GameObject[] Heart_Img;

	public ReportCont _ReportCont;

	public TextUP _TextUP;

	public static int Heart_N_Q;

	public static int Minutes;

	public static int L_Minutes;

	public static int Seconds;

	public static int L_Seconds;

	public static int Nowminute;

	public static int L_Nowminute;

	public int SavedMin;

	public int L_SavedMin;

	public int SavedSec;

	public int L_SavedSec;

	public static int Vacation_int;

	public GameObject VacaImageGameobject;

	public GameObject VacaImage_obj;

	public Sprite[] VacaImage_Sprites;

	public Transform VacaText;

	public GameObject Timeicon;

	public Sprite[] Timeicon_sprite;

	public Text Love_T;

	public static int GPGS_Playhour;

	public GameObject PLSGraudate;

	public GameObject Getmoney;

	public GameObject Getmoney_T;

	public GameObject Lover_notice;

	public GameObject Lover_char_notice;

	public GameObject Lover_char_btn;

	public static int Stop;

	public GameObject HeartAds;

	public int passedtotalsec;

	public int L_passedtotalsec;

	public int passedtotalmin;

	public int L_passedtotalmin;

	public int passedmin;

	public int L_passedmin;

	public int passedsec;

	public int L_passedsec;

	public Transform Heart_T;

	private int beforeMin;

	private int beforeSec;

	public GameObject LoveBtn;

	private int HeartAlarm;

	private GameObject _backbtn;

	public GameObject ReallyQuite;

	public GameObject Time_0_0;

	public GameObject Timer_obj;

	public GameObject WhiteObj;

	public GameObject MonthReport;

	public FeeCont _FeeCont;

	public GameObject StudyBtn;

	public static int VACAOK;

	public GameObject Suddendeath;

	public GameObject GoABroad;

	public GameObject GoAbroad_Win;

	public GraduateCont _GraduateCont;

	public GameObject FinalReport;

	public GameObject suddenRebith_obj;

	private GameObject suddenRebith_obj_;

	public void TestPlusGrade()
	{
		Grade++;
		PlayerPrefs.SetInt("Grade", Grade);
		SetTimeText();
	}

	public void Start()
	{
		_backbtn = GameObject.Find("BackBtn");
		GC.Collect();
		GPGS_Playhour = PlayerPrefs.GetInt("GPGS_Playhour");
		GoAbroadCont.bool_Goabroad = PlayerPrefs.GetInt("bool_Goabroad");
		Vacation_int = PlayerPrefs.GetInt("Vacation");
		Heart_N_Q = PlayerPrefs.GetInt("Heart_N_Q");
		GraduateCont.GraduEnd_OK = PlayerPrefs.GetInt("GraduEnd_OK");
		OneMonth = PlayerPrefs.GetInt("OneMonth");
		Grade = PlayerPrefs.GetInt("Grade");
		Rebirth = PlayerPrefs.GetInt("Rebirth");
		OneSemes = PlayerPrefs.GetInt("OneSemes");
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		BarCont.st = PlayerPrefs.GetFloat("st");
		scene_controll_2.Testcomplete = PlayerPrefs.GetInt("Testcomplete");
		if (OneMonth == 6 || OneMonth == 12)
		{
			if (scene_controll_2.Testcomplete == 1)
			{
				if (Grade == 4 && OneMonth == 12 && BarCont.st <= 0f)
				{
					_GraduateCont.SetGraduEnding();
				}
				else
				{
					_FeeCont.MonthReport_();
					MonthReport.SetActive(true);
				}
			}
		}
		else if (BarCont.st <= 0f)
		{
			_FeeCont.MonthReport_();
			MonthReport.SetActive(true);
		}
		if (Grade == 4 && OneSemes == 2 && GraduateCont.GraduEnd_OK == 1 && OneMonth == 12)
		{
			_GraduateCont.SetGraduEnding();
			Debug.Log("timecont_gradu" + GraduateCont.GraduEnd_OK);
		}
		VACAOK = PlayerPrefs.GetInt("VACAOK");
		SetTimeText();
		if (scene_controll_2.Testcomplete == 1 && BarCont.st <= 0.1f)
		{
			Month();
		}
		if (Grade > 4)
		{
		}
		if (Heart_N_Q > 3)
		{
			Heart_N_Q = 3;
			Heart_N = Heart_N_Q;
		}
		Heart_N = Heart_N_Q;
		Heart_T.GetComponent<Text>().text = string.Format("{0}", Heart_N);
		PassedTimeCheck();
		LovertimeStart();
		if (Heart_N < 3)
		{
			MinusSeconds();
		}
		if (OneMonth == 7 || OneMonth == 8 || OneMonth == 1 || OneMonth == 2)
		{
			Vacation();
		}
		else
		{
			if (OneMonth == 6 && BarCont.st <= 0.1f)
			{
				Vacation();
			}
			if (OneMonth == 12 && BarCont.st <= 0.1f)
			{
				Vacation();
			}
		}
		if (Seconds < 0)
		{
			Seconds = 0;
		}
		if (L_Seconds < 0)
		{
			L_Seconds = 0;
		}
		SaveTime();
		SetTimeText();
		Tapjoy_DMS.Tapjoybnt_click = PlayerPrefs.GetInt("Tapjoybnt_click");
		if (Tapjoy_DMS.Tapjoybnt_click == 1)
		{
			Tapjoy_Getmoney();
		}
	}

	public void Tapjoy_Getmoney()
	{
		Tapjoy.GetCurrencyBalance();
		Invoke("Plusmoney", 0.5f);
	}

	public void Plusmoney()
	{
		if (Tapjoy_DMS.tapjoy_plusmoney > 0)
		{
			scene_controll.money += Tapjoy_DMS.tapjoy_plusmoney;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			Getmoney_T.GetComponent<Text>().text = string.Format("{0:n0}G", Tapjoy_DMS.tapjoy_plusmoney);
			Getmoney.SetActive(true);
			GraduateCont.GraduEnd_OK = 0;
			PlayerPrefs.SetInt("GraduEnd_OK", GraduateCont.GraduEnd_OK);
			PlayerPrefs.SetInt("bool_Goabroad", 0);
			S2_4.Q_AlbaN++;
			PlayerPrefs.SetInt("Q_AlbaN", S2_4.Q_AlbaN);
			PlayerPrefs.Save();
			EventCont.Plus_MONEY = Tapjoy_DMS.tapjoy_plusmoney;
			_TextUP.PlusMONEY();
			Tapjoy.SpendCurrency(Tapjoy_DMS.tapjoy_plusmoney);
			Tapjoy_DMS.tapjoy_plusmoney = 0;
			Tapjoy.GetCurrencyBalance();
			PlayerPrefs.SetInt("Tapjoybnt_click", 0);
			Start();
		}
	}

	private void OnEnable()
	{
		Tapjoy.OnSpendCurrencyResponse += HandleSpendCurrencyResponse;
		Tapjoy.OnSpendCurrencyResponseFailure += HandleSpendCurrencyResponseFailure;
	}

	private void OnDisable()
	{
		Tapjoy.OnSpendCurrencyResponse -= HandleSpendCurrencyResponse;
		Tapjoy.OnSpendCurrencyResponseFailure -= HandleSpendCurrencyResponseFailure;
	}

	public void HandleSpendCurrencyResponse(string currencyName, int balance)
	{
		Debug.Log("C#: HandleSpendCurrencyResponse: currencyName: " + currencyName + ", balance: " + balance);
	}

	public void HandleSpendCurrencyResponseFailure(string error)
	{
		Debug.Log("C#: HandleSpendCurrencyResponseFailure: " + error);
	}

	public void LovertimeStart()
	{
		Lovercont.Firsttime = PlayerPrefs.GetInt("Firsttime");
		if (TutorialCont.Tutorial_Int == 1)
		{
			if (Lovercont.Firsttime == 0)
			{
				LoveBtn.GetComponent<Button>().interactable = true;
				Lover_notice.SetActive(true);
			}
			else
			{
				L_PassedTimeCheck();
			}
		}
	}

	public void PlsGradu_()
	{
		GameObject.Find("PlsGraduate").SetActive(false);
		_GraduateCont.SetGraduEnding();
		Debug.Log("plsgrau");
	}

	public void Delay()
	{
		SaveTime();
	}

	public void SaveTime()
	{
		PlayerPrefs.SetString("LastTime", DateTime.Now.ToString());
		PlayerPrefs.SetInt("SavedMinute", Minutes);
		PlayerPrefs.SetInt("L_SavedMinute", L_Minutes);
		PlayerPrefs.SetInt("SavedSecon", Seconds);
		PlayerPrefs.SetInt("L_SavedSecon", L_Seconds);
		GPGS_Playhour++;
		PlayerPrefs.SetInt("GPGS_Playhour", GPGS_Playhour);
		Invoke("Delay", 1f);
	}

	public void SetTimeText()
	{
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
		T_Grade.GetComponent<Text>().text = string.Format("{0}Grade", Grade);
		T_Rebirth.GetComponent<Text>().text = string.Format("{0}", Rebirth);
		if (OneMonth == 3 || OneMonth == 4 || OneMonth == 5 || OneMonth == 6)
		{
			T_Semes.GetComponent<Text>().text = string.Format("1st Sem");
			T_Semes.GetComponent<Text>().color = new Color(0.9411765f, 0.5803922f, 40f / 51f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[0];
		}
		if (OneMonth == 9 || OneMonth == 10 || OneMonth == 11 || OneMonth == 12)
		{
			T_Semes.GetComponent<Text>().text = string.Format("2n Sem");
			T_Semes.GetComponent<Text>().color = new Color(58f / 85f, 0.4862745f, 0.05490196f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[1];
		}
		if (OneMonth == 7 || OneMonth == 8)
		{
			T_Semes.GetComponent<Text>().text = string.Format("Summer vac.");
			T_Semes.GetComponent<Text>().color = new Color(0.101960786f, 52f / 85f, 0.08627451f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[2];
		}
		if (OneMonth == 1 || OneMonth == 2)
		{
			T_Semes.GetComponent<Text>().text = string.Format("Winter vac.");
			T_Semes.GetComponent<Text>().color = new Color(0.47058824f, 0.7137255f, 0.8f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[3];
		}
	}

	public void Wait()
	{
		Invoke("CountDown", 1f);
	}

	public void L_Wait()
	{
		if (Stop == 0)
		{
			Invoke("L_CountDown", 1f);
			return;
		}
		SetLover();
		L_StopTimer();
	}

	public void CountDown()
	{
		if (Minutes > 0 && Seconds >= 1)
		{
			MinusSeconds();
		}
		if (Minutes == 0)
		{
			if (Seconds > 1)
			{
				MinusSeconds();
			}
			if (Seconds == 1)
			{
				StartAgain();
			}
		}
	}

	public void SetLover()
	{
		if (Lovercont.Phone == 0)
		{
			Lover_notice.SetActive(true);
			LoveBtn.GetComponent<Button>().interactable = true;
		}
		if (Lovercont.Phone == 1)
		{
			Lover_char_notice.SetActive(true);
			Lover_char_btn.GetComponent<Button>().interactable = true;
		}
		L_StopTimer();
		PlayerPrefs.SetInt("Stop", 1);
		Stop = PlayerPrefs.GetInt("Stop");
	}

	public void L_CountDown()
	{
		if (L_Minutes > 0)
		{
			if (L_Seconds >= 1)
			{
				L_MinusSeconds();
			}
			if (Lovercont.Phone == 0)
			{
				LoveBtn.GetComponent<Button>().interactable = false;
				Lover_notice.SetActive(false);
			}
			if (Lovercont.Phone == 1)
			{
				Lover_char_notice.SetActive(false);
				Lover_char_btn.GetComponent<Button>().interactable = false;
			}
		}
		else
		{
			if (L_Minutes != 0)
			{
				return;
			}
			if (L_Seconds > 1)
			{
				L_MinusSeconds();
				if (Lovercont.Phone == 0)
				{
					LoveBtn.GetComponent<Button>().interactable = false;
					Lover_notice.SetActive(false);
				}
				if (Lovercont.Phone == 1)
				{
					Lover_char_notice.SetActive(false);
					Lover_char_btn.GetComponent<Button>().interactable = false;
				}
			}
			if (L_Seconds == 1)
			{
				if (Lovercont.Phone == 0)
				{
					LoveBtn.GetComponent<Button>().interactable = true;
					Lover_notice.SetActive(true);
				}
				if (Lovercont.Phone == 1)
				{
					Lover_char_notice.SetActive(true);
					Lover_char_btn.GetComponent<Button>().interactable = true;
				}
				L_StopTimer();
			}
		}
	}

	public void TimeTest()
	{
		Minutes--;
		L_Minutes--;
	}

	public void StartAgain()
	{
		if (Heart_N < 3)
		{
			Heart_N++;
			Minutes = 14;
			Seconds = 60;
			SetHeart();
		}
		if (Heart_N >= 3)
		{
			StopTimer();
		}
	}

	public void L_StartAgain()
	{
		L_StopTimer();
		L_Minutes = 2;
		L_Seconds = 60;
	}

	public void MinusSeconds()
	{
		Seconds--;
		if (Seconds <= 0)
		{
			MinusMinute();
			Seconds = 60;
		}
		if (Heart_N == 0 && Seconds == 0)
		{
			MinusMinute();
		}
		Wait();
	}

	public void L_MinusSeconds()
	{
		L_Seconds--;
		if (L_Seconds <= 0)
		{
			L_MinusMinute();
			L_Seconds = 60;
		}
		L_Wait();
	}

	public void L_MinusMinute()
	{
		if (L_Minutes >= 1)
		{
			L_Minutes--;
		}
		else
		{
			L_Minutes = 0;
		}
	}

	public void MinusMinute()
	{
		if (Minutes <= 0)
		{
			Minutes = 0;
		}
		else
		{
			Minutes--;
		}
	}

	public void StopTimer()
	{
		Seconds = 0;
		Minutes = 0;
	}

	public void L_StopTimer()
	{
		L_Seconds = 0;
		L_Minutes = 0;
	}

	public void PlusHeart()
	{
		Heart_N++;
		SetHeart();
	}

	public void PassedTimeCheck()
	{
		string text = PlayerPrefs.GetString("LastTime", string.Empty);
		DateTime result;
		if (!string.IsNullOrEmpty(text) && DateTime.TryParse(text, out result))
		{
			TimeSpan timeSpan = DateTime.Now - result;
			passedtotalsec = Convert.ToInt32(timeSpan.TotalSeconds);
			passedtotalmin = Convert.ToInt32(timeSpan.TotalMinutes);
			L_passedtotalsec = Convert.ToInt32(timeSpan.TotalSeconds);
			L_passedtotalmin = Convert.ToInt32(timeSpan.TotalMinutes);
			Nowminute = DateTime.Now.Minute;
		}
		passedmin = passedtotalsec / 60;
		passedsec = passedtotalsec - passedmin * 60;
		SavedSec = PlayerPrefs.GetInt("SavedSecon");
		SavedMin = PlayerPrefs.GetInt("SavedMinute");
		Minutes = SavedMin - passedmin;
		Seconds = SavedSec - passedsec;
		if (Minutes > 14)
		{
			Minutes = 14;
		}
		if (Seconds <= 0)
		{
			if (SavedMin <= 0)
			{
				if (Heart_N < 3)
				{
					Minutes = 14;
					Seconds = 60;
					Heart_N++;
				}
				else
				{
					Minutes = 0;
					Seconds = 0;
				}
				SetHeart();
				return;
			}
			Minutes--;
			Seconds = 60 - (passedsec - SavedSec);
		}
		if (Minutes < 0)
		{
			if (passedmin > 15)
			{
				Heart_N += passedmin / 15;
			}
			else
			{
				Heart_N++;
			}
		}
		SetHeart();
		Debug.Log("haae" + Heart_N);
	}

	public void L_PassedTimeCheck()
	{
		L_passedmin = L_passedtotalsec / 60;
		L_passedsec = L_passedtotalsec - L_passedmin * 60;
		L_SavedSec = PlayerPrefs.GetInt("L_SavedSecon");
		L_SavedMin = PlayerPrefs.GetInt("L_SavedMinute");
		L_Minutes = L_SavedMin - L_passedmin;
		L_Seconds = L_SavedSec - L_passedsec;
		if (L_Seconds <= 0)
		{
			if (L_SavedMin <= 0)
			{
				L_Minutes = 0;
				L_Seconds = 0;
				if (Lovercont.Phone == 0)
				{
					LoveBtn.GetComponent<Button>().interactable = true;
					Lover_notice.SetActive(true);
				}
				if (Lovercont.Phone == 1)
				{
					Lover_char_notice.SetActive(true);
					Lover_char_btn.GetComponent<Button>().interactable = true;
				}
				return;
			}
			L_Minutes--;
			L_Seconds = 60 - (L_passedsec - L_SavedSec);
		}
		if (L_Minutes <= 0)
		{
			if (L_passedmin >= 3)
			{
				L_Minutes = 0;
				L_Seconds = 0;
				if (Lovercont.Phone == 0)
				{
					LoveBtn.GetComponent<Button>().interactable = true;
					Lover_notice.SetActive(true);
				}
				if (Lovercont.Phone == 1)
				{
					Lover_char_notice.SetActive(true);
					Lover_char_btn.GetComponent<Button>().interactable = true;
				}
			}
			else
			{
				if (Lovercont.Phone == 0)
				{
					LoveBtn.GetComponent<Button>().interactable = false;
					Lover_notice.SetActive(false);
				}
				if (Lovercont.Phone == 1)
				{
					Lover_char_notice.SetActive(false);
					Lover_char_btn.GetComponent<Button>().interactable = false;
				}
				L_MinusSeconds();
				Debug.Log("L_PassedTimeCheck");
			}
		}
		else
		{
			L_MinusSeconds();
		}
		if (L_Minutes > 2)
		{
			L_Minutes = 2;
		}
	}

	public void YesQUite()
	{
		Application.Quit();
	}

	public void NoPlaymore()
	{
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		ReallyQuite.SetActive(false);
	}

	public void FixedUpdate()
	{
		if (Heart_N >= 3)
		{
			HeartAds.GetComponent<Button>().interactable = false;
		}
		else
		{
			HeartAds.GetComponent<Button>().interactable = true;
		}
		if (ReallyQuite.activeInHierarchy)
		{
		}
		if (Minutes <= 0)
		{
			Minutes = 0;
		}
		if (L_Minutes <= 0)
		{
			L_Minutes = 0;
		}
		if (Minutes < 10)
		{
			EventTimer.GetComponent<Text>().text = string.Format("0{0}:{1:N0}", Mathf.Floor(Minutes), Seconds);
			if (Seconds < 10)
			{
				EventTimer.GetComponent<Text>().text = string.Format("0{0}:0{1:N0}", Mathf.Floor(Minutes), Seconds);
			}
		}
		else if (Seconds < 10)
		{
			EventTimer.GetComponent<Text>().text = string.Format("{0}:0{1:N0}", Mathf.Floor(Minutes), Seconds);
		}
		else
		{
			EventTimer.GetComponent<Text>().text = string.Format("{0}:{1:N0}", Mathf.Floor(Minutes), Seconds);
		}
		if (Heart_N > 3 || Heart_N_Q > 3)
		{
			Heart_N = 3;
			Heart_N_Q = 3;
			Heart_N = Heart_N_Q;
		}
		Heart_T.GetComponent<Text>().text = string.Format("{0}", Heart_N);
		if (Heart_N <= 0)
		{
			Heart_N = 0;
		}
		Heart_N = Heart_N_Q;
		if (BarCont.st <= 0.1f)
		{
		}
		if (L_Minutes < 10)
		{
			Love_T.text = string.Format("0{0}:{1:N0}", Mathf.Floor(L_Minutes), L_Seconds);
			if (L_Seconds < 10)
			{
				Love_T.text = string.Format("0{0}:0{1:N0}", Mathf.Floor(L_Minutes), L_Seconds);
			}
		}
		else if (L_Seconds < 10)
		{
			Love_T.text = string.Format("{0}:0{1:N0}", Mathf.Floor(L_Minutes), L_Seconds);
		}
		else
		{
			Love_T.text = string.Format("{0}:{1:N0}", Mathf.Floor(L_Minutes), L_Seconds);
		}
	}

	public void ToeicEventbutton()
	{
		if (Heart_N > 0)
		{
			Heart_N--;
		}
		SetHeart();
		CountGo_();
	}

	public void ContestEventbutton()
	{
		if (Heart_N > 0)
		{
			Heart_N--;
		}
		SetHeart();
		CountGo_();
	}

	public void CountGo_()
	{
		if (Minutes == 0 && Seconds == 0)
		{
			Minutes = 14;
			Seconds = 60;
			CountDown();
		}
	}

	public void SetHeart()
	{
		Heart_T.GetComponent<Text>().text = string.Format("{0}", Heart_N);
		if (Heart_N > 3)
		{
			Heart_N = 3;
		}
		if (Heart_N == 0)
		{
			Heart_N = 0;
			Heart_Img[1].SetActive(false);
			Heart_Img[2].SetActive(false);
			Heart_Img[3].SetActive(false);
			PlayerPrefs.SetInt("Heart_N_Q", Heart_N);
		}
		if (Heart_N == 1)
		{
			Heart_N = 1;
			Heart_Img[1].SetActive(true);
			Heart_Img[2].SetActive(false);
			Heart_Img[3].SetActive(false);
			PlayerPrefs.SetInt("Heart_N_Q", 1);
		}
		if (Heart_N == 2)
		{
			Heart_N = 2;
			Heart_Img[1].SetActive(true);
			Heart_Img[2].SetActive(true);
			Heart_Img[3].SetActive(false);
			PlayerPrefs.SetInt("Heart_N_Q", 2);
		}
		if (Heart_N >= 3)
		{
			Heart_N = 3;
			Heart_Img[1].SetActive(true);
			Heart_Img[2].SetActive(true);
			Heart_Img[3].SetActive(true);
			PlayerPrefs.SetInt("Heart_N_Q", 3);
			Heart_N = 3;
			Seconds = 0;
			Minutes = 0;
			Timer_obj.SetActive(false);
			Time_0_0.SetActive(true);
		}
		if (Heart_N < 3)
		{
			Timer_obj.SetActive(true);
			Time_0_0.SetActive(false);
		}
		Heart_N_Q = PlayerPrefs.GetInt("Heart_N_Q");
	}

	public void Week()
	{
		PlayerPrefs.SetInt("GraduEnd_OK", 0);
		GraduateCont.GraduEnd_OK = PlayerPrefs.GetInt("GraduEnd_OK");
		if (BarCont.st <= 0.1f)
		{
			Month();
		}
	}

	public void MonthlyReport()
	{
		MonthReport.SetActive(true);
		WhiteObj.SetActive(false);
	}

	public void Month()
	{
		Debug.Log("Monthscene_controll_2.Testcomplete" + scene_controll_2.Testcomplete);
		if (BarCont.st <= 0.1f)
		{
			PlayerPrefs.SetInt("gojiseo_OK", 0);
			if (OneMonth == 6 || OneMonth == 12)
			{
				Debug.Log("dd" + Grade + OneMonth);
				if (scene_controll_2.Testcomplete == 1)
				{
					PlayerPrefs.SetInt("FeeConfirm", 0);
					if (Grade < 4)
					{
						_FeeCont.MonthReport_();
						_ReportCont.report();
						WhiteObj.SetActive(true);
						Invoke("MonthlyReport", 1f);
						if (OneMonth == 1)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jan");
						}
						if (OneMonth == 2)
						{
							T_Month.GetComponent<Text>().text = string.Format("Feb");
						}
						if (OneMonth == 3)
						{
							T_Month.GetComponent<Text>().text = string.Format("Mar");
						}
						if (OneMonth == 4)
						{
							T_Month.GetComponent<Text>().text = string.Format("Apr");
						}
						if (OneMonth == 5)
						{
							T_Month.GetComponent<Text>().text = string.Format("May");
						}
						if (OneMonth == 6)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jun");
						}
						if (OneMonth == 7)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jul");
						}
						if (OneMonth == 8)
						{
							T_Month.GetComponent<Text>().text = string.Format("Aug");
						}
						if (OneMonth == 9)
						{
							T_Month.GetComponent<Text>().text = string.Format("Sep");
						}
						if (OneMonth == 10)
						{
							T_Month.GetComponent<Text>().text = string.Format("Oct");
						}
						if (OneMonth == 11)
						{
							T_Month.GetComponent<Text>().text = string.Format("Nov");
						}
						if (OneMonth == 12)
						{
							T_Month.GetComponent<Text>().text = string.Format("Dec");
						}
						SetTimeText();
					}
					if (Grade == 4 && OneMonth == 6)
					{
						_FeeCont.MonthReport_();
						_ReportCont.report();
						WhiteObj.SetActive(true);
						Invoke("MonthlyReport", 1f);
						if (OneMonth == 1)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jan");
						}
						if (OneMonth == 2)
						{
							T_Month.GetComponent<Text>().text = string.Format("Feb");
						}
						if (OneMonth == 3)
						{
							T_Month.GetComponent<Text>().text = string.Format("Mar");
						}
						if (OneMonth == 4)
						{
							T_Month.GetComponent<Text>().text = string.Format("Apr");
						}
						if (OneMonth == 5)
						{
							T_Month.GetComponent<Text>().text = string.Format("May");
						}
						if (OneMonth == 6)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jun");
						}
						if (OneMonth == 7)
						{
							T_Month.GetComponent<Text>().text = string.Format("Jul");
						}
						if (OneMonth == 8)
						{
							T_Month.GetComponent<Text>().text = string.Format("Aug");
						}
						if (OneMonth == 9)
						{
							T_Month.GetComponent<Text>().text = string.Format("Sep");
						}
						if (OneMonth == 10)
						{
							T_Month.GetComponent<Text>().text = string.Format("Oct");
						}
						if (OneMonth == 11)
						{
							T_Month.GetComponent<Text>().text = string.Format("Nov");
						}
						if (OneMonth == 12)
						{
							T_Month.GetComponent<Text>().text = string.Format("Dec");
						}
						SetTimeText();
					}
				}
			}
			else
			{
				_FeeCont.MonthReport_();
				_ReportCont.report();
				WhiteObj.SetActive(true);
				Invoke("MonthlyReport", 1f);
				if (OneMonth == 1)
				{
					T_Month.GetComponent<Text>().text = string.Format("Jan");
				}
				if (OneMonth == 2)
				{
					T_Month.GetComponent<Text>().text = string.Format("Feb");
				}
				if (OneMonth == 3)
				{
					T_Month.GetComponent<Text>().text = string.Format("Mar");
				}
				if (OneMonth == 4)
				{
					T_Month.GetComponent<Text>().text = string.Format("Apr");
				}
				if (OneMonth == 5)
				{
					T_Month.GetComponent<Text>().text = string.Format("May");
				}
				if (OneMonth == 6)
				{
					T_Month.GetComponent<Text>().text = string.Format("Jun");
				}
				if (OneMonth == 7)
				{
					T_Month.GetComponent<Text>().text = string.Format("Jul");
				}
				if (OneMonth == 8)
				{
					T_Month.GetComponent<Text>().text = string.Format("Aug");
				}
				if (OneMonth == 9)
				{
					T_Month.GetComponent<Text>().text = string.Format("Sep");
				}
				if (OneMonth == 10)
				{
					T_Month.GetComponent<Text>().text = string.Format("Oct");
				}
				if (OneMonth == 11)
				{
					T_Month.GetComponent<Text>().text = string.Format("Nov");
				}
				if (OneMonth == 12)
				{
					T_Month.GetComponent<Text>().text = string.Format("Dec");
				}
				if (OneMonth == 3 || OneMonth == 9)
				{
					Semester();
					Debug.Log("으에에");
				}
				if (OneMonth == 7 || OneMonth == 12)
				{
					Vacation();
				}
				SetTimeText();
			}
		}
		if (OneMonth == 7 || OneMonth == 8 || OneMonth == 1 || OneMonth == 2)
		{
			Vacation();
		}
		PlayerPrefs.SetInt("bool_Goabroad", 0);
		GoAbroadCont.bool_Goabroad = PlayerPrefs.GetInt("bool_Goabroad");
		PlayerPrefs.SetInt("GraduEnd_OK", 0);
		GraduateCont.GraduEnd_OK = PlayerPrefs.GetInt("GraduEnd_OK");
	}

	public void NextYearMonth()
	{
		if (ReportCont.Score1_2 > 0 && ReportCont.Score2_2 == 0)
		{
			Grade = 2;
		}
		if (ReportCont.Score2_2 > 0 && ReportCont.Score3_2 == 0)
		{
			Grade = 3;
		}
		if (ReportCont.Score3_2 > 0 && ReportCont.Score4_2 == 0)
		{
			Grade = 4;
		}
		PlayerPrefs.SetInt("Grade", Grade);
		T_Grade.GetComponent<Text>().text = string.Format("{0}Grade", Grade);
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		OneMonth = PlayerPrefs.GetInt("OneMonth");
		Debug.Log("Timecont_NextyearMonth/grade=" + Grade);
	}

	public void Semester()
	{
		ReportCont.Score1_1 = PlayerPrefs.GetInt("score1-1");
		ReportCont.Score1_2 = PlayerPrefs.GetInt("score1-2");
		ReportCont.Score2_1 = PlayerPrefs.GetInt("score2-1");
		ReportCont.Score2_2 = PlayerPrefs.GetInt("score2-2");
		ReportCont.Score3_1 = PlayerPrefs.GetInt("score3-1");
		ReportCont.Score3_2 = PlayerPrefs.GetInt("score3-2");
		ReportCont.Score4_1 = PlayerPrefs.GetInt("score4-1");
		ReportCont.Score4_2 = PlayerPrefs.GetInt("score4-2");
		if (ReportCont.Score1_2 > 0)
		{
			if (OneMonth == 3)
			{
				PlayerPrefs.SetInt("OneSemes", 1);
				OneSemes = PlayerPrefs.GetInt("OneSemes");
				_FeeCont.FeeReport();
				NextYearMonth();
				PlayerPrefs.SetInt("Grade", Grade);
				PlayerPrefs.SetInt("Vacation", 0);
				PlayerPrefs.SetInt("VACAOK", 0);
				VACAOK = PlayerPrefs.GetInt("VACAOK");
				Debug.Log("oneseme" + OneSemes);
			}
			Debug.Log("oneseme" + OneSemes);
		}
		if (OneMonth == 9)
		{
			PlayerPrefs.SetInt("OneSemes", 2);
			OneSemes = PlayerPrefs.GetInt("OneSemes");
			_FeeCont.FeeReport();
			PlayerPrefs.SetInt("Vacation", 0);
			PlayerPrefs.SetInt("VACAOK", 0);
			VACAOK = PlayerPrefs.GetInt("VACAOK");
			Debug.Log("OneMonth == 1");
		}
		if (OneSemes == 1)
		{
			T_Semes.GetComponent<Text>().text = string.Format("1st Sem");
			T_Semes.GetComponent<Text>().color = new Color(0.9411765f, 0.5803922f, 40f / 51f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[0];
		}
		if (OneSemes == 2)
		{
			T_Semes.GetComponent<Text>().text = string.Format("2nd Sem");
			T_Semes.GetComponent<Text>().color = new Color(58f / 85f, 0.4862745f, 0.05490196f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[1];
		}
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
		PlayerPrefs.SetInt("OneSemes", OneSemes);
	}

	public void AbroadPhil()
	{
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
	}

	public void AbroadNewYork()
	{
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
		PlayerPrefs.SetInt("OneMonth", OneMonth);
	}

	public void Vacation()
	{
		VACAOK = PlayerPrefs.GetInt("VACAOK");
		if (OneMonth == 7 || OneMonth == 8)
		{
			T_Semes.GetComponent<Text>().text = string.Format("Summer vac.");
			T_Semes.GetComponent<Text>().color = new Color(0.101960786f, 52f / 85f, 0.08627451f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[2];
		}
		if (OneMonth == 1 || OneMonth == 2)
		{
			T_Semes.GetComponent<Text>().text = string.Format("Winter vac.");
			T_Semes.GetComponent<Text>().color = new Color(0.47058824f, 0.7137255f, 0.8f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[3];
		}
		PlayerPrefs.SetInt("Vacation", 1);
	}

	public void ShowVacaSignImage()
	{
		if (OneMonth == 7 && VACAOK == 0)
		{
			Debug.Log("ShowVacaSignImage");
			VacaImageGameobject.SetActive(true);
			VacaImage_obj.GetComponent<Image>().sprite = VacaImage_Sprites[0];
			VacaText.GetComponent<Text>().text = string.Format("Summer Vacation Start!!");
			PlayerPrefs.SetInt("VACAOK", 1);
			VACAOK = PlayerPrefs.GetInt("VACAOK");
			T_Semes.GetComponent<Text>().text = string.Format("Summer vac.");
			T_Semes.GetComponent<Text>().color = new Color(0.101960786f, 52f / 85f, 0.08627451f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[2];
		}
		if (OneMonth == 1)
		{
			Debug.Log("VACAOK" + VACAOK);
			if (VACAOK == 0)
			{
				VacaImageGameobject.SetActive(true);
				VacaImage_obj.GetComponent<Image>().sprite = VacaImage_Sprites[1];
				VacaText.GetComponent<Text>().text = string.Format("Winter Vacation Start!!");
				PlayerPrefs.SetInt("VACAOK", 1);
				VACAOK = PlayerPrefs.GetInt("VACAOK");
				T_Semes.GetComponent<Text>().text = string.Format("Winter vac.");
				T_Semes.GetComponent<Text>().color = new Color(0.47058824f, 0.7137255f, 0.8f);
				Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[3];
			}
		}
		Invoke("VacaImageFalse", 2f);
	}

	public void VacaImageFalse()
	{
		if (AudioCont.Mute_b == 1)
		{
			GoAbroad_Win.GetComponent<AudioSource>().mute = true;
		}
		if (AudioCont.Mute_b == 2)
		{
			GoAbroad_Win.GetComponent<AudioSource>().mute = false;
		}
		if (GoAbroadCont.bool_Goabroad == 0)
		{
			if (OneMonth == 7)
			{
				GoABroad.SetActive(true);
				GoAbroad_Win.SetActive(true);
			}
			if (OneMonth == 1)
			{
				GoABroad.SetActive(true);
				GoAbroad_Win.SetActive(true);
			}
		}
		if (GoAbroadCont.bool_Goabroad == 1)
		{
		}
		VacaImageGameobject.SetActive(false);
	}

	public void GraduateEnding()
	{
		if (GraduateCont.GraduEnd_OK == 0 && Grade == 4 && OneMonth == 12)
		{
			_GraduateCont.SetGraduEnding();
			Debug.Log("GraduateEnding" + GraduateCont.GraduEnd_OK);
		}
		Debug.Log("GraduateCont.GraduEnd_OK" + GraduateCont.GraduEnd_OK);
		PlayerPrefs.SetInt("Grade", Grade);
	}

	public void SuddenRebirth()
	{
		Rebirth++;
		T_Rebirth.GetComponent<Text>().text = string.Format("{0}", Rebirth);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.DeleteKey("EveryPoint");
		BarCont.hp = 50f;
		BarCont.mp = 50f;
		BarCont._int = 50f;
		BarCont.happy = 50f;
		BarCont.st = 100f;
		PlayerPrefs.SetFloat("hp", BarCont.hp);
		PlayerPrefs.SetFloat("mp", BarCont.mp);
		PlayerPrefs.SetFloat("st", BarCont.st);
		PlayerPrefs.SetFloat("int", BarCont._int);
		PlayerPrefs.SetFloat("happy", BarCont.happy);
		OneMonth = 3;
		OneSemes = 1;
		Grade = 1;
		BarCont.point = 0f;
		PlayerPrefs.SetFloat("point", BarCont.point);
		PlayerPrefs.SetInt("score1-1", 0);
		PlayerPrefs.SetInt("score1-2", 0);
		PlayerPrefs.SetInt("score2-1", 0);
		PlayerPrefs.SetInt("score2-2", 0);
		PlayerPrefs.SetInt("score3-1", 0);
		PlayerPrefs.SetInt("score3-2", 0);
		PlayerPrefs.SetInt("score4-1", 0);
		PlayerPrefs.SetInt("score4-2", 0);
		PlayerPrefs.SetInt("S_class", 0);
		PlayerPrefs.SetInt("Y_class", 0);
		PlayerPrefs.SetInt("M_class", 0);
		PlayerPrefs.SetInt("E_class", 0);
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Testcomplete", 0);
		if (OneMonth == 1)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jan");
		}
		if (OneMonth == 2)
		{
			T_Month.GetComponent<Text>().text = string.Format("Feb");
		}
		if (OneMonth == 3)
		{
			T_Month.GetComponent<Text>().text = string.Format("Mar");
		}
		if (OneMonth == 4)
		{
			T_Month.GetComponent<Text>().text = string.Format("Apr");
		}
		if (OneMonth == 5)
		{
			T_Month.GetComponent<Text>().text = string.Format("May");
		}
		if (OneMonth == 6)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jun");
		}
		if (OneMonth == 7)
		{
			T_Month.GetComponent<Text>().text = string.Format("Jul");
		}
		if (OneMonth == 8)
		{
			T_Month.GetComponent<Text>().text = string.Format("Aug");
		}
		if (OneMonth == 9)
		{
			T_Month.GetComponent<Text>().text = string.Format("Sep");
		}
		if (OneMonth == 10)
		{
			T_Month.GetComponent<Text>().text = string.Format("Oct");
		}
		if (OneMonth == 11)
		{
			T_Month.GetComponent<Text>().text = string.Format("Nov");
		}
		if (OneMonth == 12)
		{
			T_Month.GetComponent<Text>().text = string.Format("Dec");
		}
		if (OneSemes == 1)
		{
			T_Semes.GetComponent<Text>().text = string.Format("1st sem");
			T_Semes.GetComponent<Text>().color = new Color(0.9411765f, 0.5803922f, 40f / 51f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[0];
		}
		if (OneSemes == 2)
		{
			T_Semes.GetComponent<Text>().text = string.Format("2nd sem");
			T_Semes.GetComponent<Text>().color = new Color(58f / 85f, 0.4862745f, 0.05490196f);
			Timeicon.GetComponent<Image>().sprite = Timeicon_sprite[1];
		}
		T_Grade.GetComponent<Text>().text = string.Format("{0}Grade", Grade);
		ReportCont.Grade_N = 0;
		GameObject gameObject = GameObject.Find("1_2");
		suddenRebith_obj_ = UnityEngine.Object.Instantiate(suddenRebith_obj);
		suddenRebith_obj_.transform.SetParent(gameObject.transform);
		suddenRebith_obj_.transform.localPosition = suddenRebith_obj.transform.localPosition;
		suddenRebith_obj_.transform.localScale = new Vector3(1f, 1f, 1f);
		Invoke("suddenRebithfalse", 4f);
	}

	public void suddenRebithfalse()
	{
		UnityEngine.Object.Destroy(suddenRebith_obj_);
		if (GameObject.Find("BackBtn_Child").activeInHierarchy)
		{
			GameObject.Find("BackBtn_Child").SetActive(false);
		}
	}

	public void grade1()
	{
		Grade = 1;
		OneMonth = 3;
		OneSemes = 1;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		PlayerPrefs.SetFloat("st", 10f);
		BarCont.st = PlayerPrefs.GetFloat("st");
		Start();
	}

	public void grade2()
	{
		Grade = 2;
		OneMonth = 3;
		OneSemes = 1;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		Start();
	}

	public void grade3()
	{
		Grade = 3;
		OneMonth = 3;
		OneSemes = 1;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		Start();
	}

	public void grade4()
	{
		Grade = 4;
		OneMonth = 11;
		OneSemes = 2;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		Start();
	}

	public void month7()
	{
		OneMonth = 7;
		OneSemes = 1;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		Start();
	}

	public void month1()
	{
		OneMonth = 1;
		OneSemes = 2;
		PlayerPrefs.SetInt("OneMonth", OneMonth);
		PlayerPrefs.SetInt("Grade", Grade);
		PlayerPrefs.SetInt("Rebirth", Rebirth);
		PlayerPrefs.SetInt("OneSemes", OneSemes);
		Start();
	}

	public void graduate()
	{
		_GraduateCont.SetGraduEnding();
	}

	public void Minustime()
	{
		PlayerPrefs.SetFloat("st", BarCont.st - 50f);
		BarCont.st = PlayerPrefs.GetFloat("st");
		Month();
	}

	public void graducountplus()
	{
		GraduateCont.EndingCount++;
		PlayerPrefs.SetInt("EndingCount", GraduateCont.EndingCount);
		GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount");
	}
}
