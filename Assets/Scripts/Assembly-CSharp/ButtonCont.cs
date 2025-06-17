using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonCont : MonoBehaviour
{
	public GameObject EventScreen;

	public GameObject AudioMute;

	public GameObject AudioPlay;

	public GameObject ToeicBtn;

	public GameObject SpectUpPanel;

	public GameObject SpecUPResultPanel;

	public GameObject ContestBtn;

	public GameObject StudyBtn;

	public GameObject AlbaBtn;

	public GameObject specupBtn;

	public GameObject ShoppingBtn;

	public GameObject UnistreetBtn;

	public RuntimeAnimatorController StudyAnim;

	public GameObject IlsangBtn;

	public static int GPGS_Click;

	private GameObject _bossbackbtn;

	public GameObject SuccessPrefs;

	public Transform TEXT_T;

	private GameObject _GraduateCont;

	private GameObject _backbtn;

	public static int present;

	public TimeCont _TimeCont;

	public SoundEffect_newone _SoundEffect_newone;

	public static float Plus_Point;

	public GameObject tutorial;

	public GameObject Testseason;

	public GameObject Vacaseason;

	public GameObject Abroad;

	public TextCont _TextCont;

	public Transform Heart_T;

	private int HeartAlarm;

	public static int Q_SpecN;

	public GameObject Point_obj;

	public TextUP _TextUP;

	public GameObject VacaBtn;

	public static int VacaMoney;

	public GameObject ThisParent;

	public GameObject TouchEffect;

	public GameObject FeverPrefabEffect;

	private GameObject TouchEffect_;

	private GameObject FeverTouchEffect_;

	public static int Q_Clicker;

	public GameObject CoinPref;

	public GameObject parent;

	private GameObject CoinPref_;

	public GameObject SettingWindow;

	public GameObject VibrateBtn;

	public GameObject CareffectBtn;

	public Sprite Y_Vibrate;

	public Sprite N_Vibrate;

	public Sprite Y_careffect;

	public Sprite N_careffect;

	private bool b_Vibrate;

	public static int Vibrate_int;

	public CarCont _CarCont;

	public GameObject ParticleBtn;

	public Sprite Y_Particle;

	public Sprite N_Particle;

	private bool b_Particle;

	public static int Particle_int;

	public GameObject CouponWindow;

	public Text Coupon_Number;

	public GameObject Putnumbernotice;

	public GameObject Putnumbernotice_Text;

	public RoomCont _RoomCont;

	public Pet _Pet;

	public PetPosition _PetPosition;

	public Char _Char;

	public FeeCont _FeeCont;

	public static int pinix_pet;

	public static int sorry;

	public static int reallysorry;

	public static int Comeback;

	public static int parrat;

	public static int Moon1;

	public static int Gradu5;

	public static int Gradu10;

	public static int Resetreward;

	public static int gem200;

	public static int gem500;

	public static int money3;

	public static int oeok_b;

	public static int hungry_b;

	public static int _event5chun;

	public string RealCoupon;

	public GameObject CouponBtn;

	private GameObject Event_One;

	public static int Event_a;

	public GameObject Graduwindow;

	public void Awake()
	{
		Particle_int = PlayerPrefs.GetInt("Particle_int");
		Vibrate_int = PlayerPrefs.GetInt("Vibrate_int");
	}

	private void Start()
	{
		_bossbackbtn = GameObject.Find("BOSSBackbtnManager");
		_backbtn = GameObject.Find("BackBtn");
		oeok_b = PlayerPrefs.GetInt("oeok_b");
		_event5chun = PlayerPrefs.GetInt("_event5chun");
		hungry_b = PlayerPrefs.GetInt("hungry_b");
		_GraduateCont = GameObject.Find("GraduateController");
		pinix_pet = PlayerPrefs.GetInt("pinix_pet");
		scene_controll_2.Testcomplete = PlayerPrefs.GetInt("Testcomplete");
		EventPopup.nomorepop_c = PlayerPrefs.GetInt("nomorepop_c");
		TutorialCont.Tutoint_event = PlayerPrefs.GetInt("Tutoint_event");
		present = PlayerPrefs.GetInt("present");
		if (TutorialCont.Tutorial_Int == 1 && TutorialCont.Tutoint_event == 0 && TimeCont.OneMonth != 12 && GraduateCont.GraduEnd_OK != 1 && present == 0)
		{
			GameObject gameObject = (GameObject)Resources.Load("Freegem200");
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Freegem200"));
			GameObject gameObject3 = GameObject.Find("eventpop_prt");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			scene_controll.gem += 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			PlayerPrefs.SetInt("present", 1);
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			UnistreetBtn.GetComponent<Button>().interactable = false;
		}
		if (PlayerPrefs.GetInt("Mute_b") == 1)
		{
			audioMUTE();
		}
		else
		{
			audioPlay();
		}
		BarCont.point = PlayerPrefs.GetFloat("point");
		if (Vibrate_int == 0)
		{
			VibrateBtn.GetComponent<Image>().sprite = Y_Vibrate;
		}
		else
		{
			VibrateBtn.GetComponent<Image>().sprite = N_Vibrate;
		}
		CarCont.Careffect = PlayerPrefs.GetInt("Careffect");
		if (CarCont.Careffect == 0)
		{
			CareffectBtn.GetComponent<Image>().sprite = Y_careffect;
		}
		else
		{
			CareffectBtn.GetComponent<Image>().sprite = N_careffect;
		}
	}

	public void SaveMoney()
	{
		scene_controll.money_Text = scene_controll.money_Text.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
	}

	private void FixedUpdate()
	{
		TimeCont.Vacation_int = PlayerPrefs.GetInt("Vacation");
		if (TutorialCont.Tutorial_Int == 1)
		{
			if (TimeCont.Heart_N == 0)
			{
				IlsangBtn.GetComponent<Button>().interactable = false;
				VacaBtn.GetComponent<Button>().interactable = false;
			}
			else
			{
				IlsangBtn.GetComponent<Button>().interactable = true;
				VacaBtn.GetComponent<Button>().interactable = true;
			}
		}
		if (TutorialCont.Tutorial_Int == 1)
		{
			if (TimeCont.OneMonth == 7 || TimeCont.OneMonth == 8)
			{
				StudyBtn.GetComponent<Button>().image.color = new Color(1f, 1f, 1f);
				Vacaseason.GetComponent<Text>().text = string.Format("Summer vac.");
				Vacaseason.GetComponent<Text>().color = Color.black;
				AlbaBtn.GetComponent<Button>().interactable = true;
				specupBtn.GetComponent<Button>().interactable = true;
				ShoppingBtn.GetComponent<Button>().interactable = true;
				StudyBtn.GetComponent<Button>().interactable = false;
				UnistreetBtn.GetComponent<Button>().interactable = true;
			}
			if (TimeCont.OneMonth == 1 || TimeCont.OneMonth == 2)
			{
				StudyBtn.GetComponent<Button>().image.color = new Color(1f, 1f, 1f);
				Vacaseason.GetComponent<Text>().text = string.Format("Winter vac.");
				Vacaseason.GetComponent<Text>().color = Color.black;
				AlbaBtn.GetComponent<Button>().interactable = true;
				specupBtn.GetComponent<Button>().interactable = true;
				ShoppingBtn.GetComponent<Button>().interactable = true;
				StudyBtn.GetComponent<Button>().interactable = false;
				UnistreetBtn.GetComponent<Button>().interactable = true;
			}
			if (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 4 || TimeCont.OneMonth == 5 || TimeCont.OneMonth == 9 || TimeCont.OneMonth == 10 || TimeCont.OneMonth == 11)
			{
				StudyBtn.GetComponent<Button>().image.color = new Color(1f, 0.7372549f, 1f / 51f);
				Vacaseason.GetComponent<Text>().text = string.Format("UNIVERSITY");
				Vacaseason.GetComponent<Text>().color = Color.black;
				AlbaBtn.GetComponent<Button>().interactable = true;
				specupBtn.GetComponent<Button>().interactable = true;
				ShoppingBtn.GetComponent<Button>().interactable = true;
				StudyBtn.GetComponent<Button>().interactable = true;
				UnistreetBtn.GetComponent<Button>().interactable = true;
			}
		}
		if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
		{
			if (BarCont.st <= 0f)
			{
				if (scene_controll_2.Testcomplete == 0)
				{
					Vacaseason.GetComponent<Text>().text = string.Format("TEST");
					StudyBtn.GetComponent<Button>().image.color = new Color(0.99215686f, 0.18431373f, 0.17254902f);
					StudyBtn.GetComponent<Button>().interactable = true;
					AlbaBtn.GetComponent<Button>().interactable = false;
					specupBtn.GetComponent<Button>().interactable = false;
					ShoppingBtn.GetComponent<Button>().interactable = false;
					UnistreetBtn.GetComponent<Button>().interactable = false;
				}
				else
				{
					Vacaseason.GetComponent<Text>().text = string.Format("UNIVERSITY");
					StudyBtn.GetComponent<Button>().interactable = true;
					AlbaBtn.GetComponent<Button>().interactable = true;
					specupBtn.GetComponent<Button>().interactable = true;
					ShoppingBtn.GetComponent<Button>().interactable = true;
					StudyBtn.GetComponent<Button>().image.color = new Color(1f, 0.7372549f, 1f / 51f);
					UnistreetBtn.GetComponent<Button>().interactable = true;
				}
			}
			else
			{
				Vacaseason.GetComponent<Text>().text = string.Format("UNIVERSITY");
				AlbaBtn.GetComponent<Button>().interactable = true;
				specupBtn.GetComponent<Button>().interactable = true;
				ShoppingBtn.GetComponent<Button>().interactable = true;
				StudyBtn.GetComponent<Button>().interactable = true;
				StudyBtn.GetComponent<Button>().image.color = new Color(1f, 0.7372549f, 1f / 51f);
				UnistreetBtn.GetComponent<Button>().interactable = true;
			}
		}
		if (EventScreen.activeInHierarchy && Input.GetKeyDown(KeyCode.Escape))
		{
			EventScreen.SetActive(false);
		}
		if (!Input.GetKeyDown(KeyCode.Escape))
		{
		}
	}

	public void GoBack()
	{
		EventScreen.SetActive(false);
		GameObject gameObject = GameObject.Find("BackBtn_Child");
		if (gameObject.activeInHierarchy)
		{
			gameObject.SetActive(false);
		}
		PlayerPrefs.SetString("LastTime", DateTime.Now.ToString());
		PlayerPrefs.SetInt("SavedMinute", TimeCont.Minutes);
		PlayerPrefs.SetInt("SavedSecon", TimeCont.Seconds);
	}

	public void GoBacktoTutorial()
	{
		if (TutorialCont.Tutorial_Int != 0)
		{
		}
	}

	public void TESTABROADWINDOW()
	{
		Abroad.SetActive(true);
	}

	public void eventScreen()
	{
		EventScreen.SetActive(true);
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = (GameObject)Resources.Load("Tutorial/Tuto_2");
			GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("Tutorial/Tuto_2"));
			GameObject gameObject3 = GameObject.Find("Bottom_parent");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
			UnityEngine.Object.Destroy(GameObject.Find("Tuto_1(Clone)"));
		}
	}

	public void eventScreenCLOSE()
	{
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		EventScreen.SetActive(false);
		PlayerPrefs.SetString("LastTime", DateTime.Now.ToString());
		PlayerPrefs.SetInt("SavedMinute", TimeCont.Minutes);
		PlayerPrefs.SetInt("SavedSecon", TimeCont.Seconds);
	}

	public void audioMUTE()
	{
		AudioCont.Mute_b = 1;
		AudioMute.SetActive(false);
		AudioPlay.SetActive(true);
		PlayerPrefs.SetInt("Mute_b", AudioCont.Mute_b);
	}

	public void audioPlay()
	{
		AudioCont.Mute_b = 2;
		AudioMute.SetActive(true);
		AudioPlay.SetActive(false);
		PlayerPrefs.SetInt("Mute_b", AudioCont.Mute_b);
	}

	public void ToeicEventbutton()
	{
		SpectUpPanel.SetActive(true);
		EventScreen.SetActive(false);
		GameObject gameObject = GameObject.Find("SpecUPPanel");
		gameObject.GetComponent<TextCont>().NextButtonFalse();
		EventCont.Event_N = 1;
	}

	public void ContestEventbutton()
	{
		SpectUpPanel.SetActive(true);
		EventScreen.SetActive(false);
		GameObject gameObject = GameObject.Find("SpecUPPanel");
		gameObject.GetComponent<TextCont>().NextButtonFalse();
		EventCont.Event_N = 2;
	}

	public void CloesSpceUp()
	{
		CloseThis.On_b = true;
		SpecUPResultPanel.SetActive(false);
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		Point_obj.SetActive(false);
		Q_SpecN++;
		PlayerPrefs.SetInt("Q_SpecN", Q_SpecN);
	}

	public void ToeicResultDelay()
	{
		ToeicResult();
	}

	public void ToeicResult()
	{
		SpectUpPanel.SetActive(false);
		SpecUPResultPanel.SetActive(true);
		if (EventCont.Event_N == 1)
		{
			Point_obj.SetActive(true);
		}
		else
		{
			Point_obj.SetActive(false);
		}
		Debug.Log("Event_N" + EventCont.Event_N);
	}

	public void vacaDelay()
	{
		Invoke("Vaca_Btn", 1f);
	}

	public void VacaResultClose()
	{
		_TextUP.PlusST();
		_TextUP.PlusMONEY();
	}

	public void GotoCashScreen()
	{

	}

	public void OpenSettingWin()
	{
		SettingWindow.SetActive(true);
	}

	public void CloseSettingWin()
	{
		SettingWindow.SetActive(false);
		CouponWindow.SetActive(false);
	}

	public void Vibrate()
	{
		if (!b_Vibrate)
		{
			No_vibrate();
		}
		else
		{
			Yes_vibrate();
		}
	}

	public void Yes_vibrate()
	{
		b_Vibrate = false;
		VibrateBtn.GetComponent<Image>().sprite = Y_Vibrate;
		Vibrate_int = 0;
		PlayerPrefs.SetInt("Vibrate_int", Vibrate_int);
		Vibrate_int = PlayerPrefs.GetInt("Vibrate_int");
	}

	public void No_vibrate()
	{
		b_Vibrate = true;
		VibrateBtn.GetComponent<Image>().sprite = N_Vibrate;
		Vibrate_int = 1;
		PlayerPrefs.SetInt("Vibrate_int", Vibrate_int);
		Vibrate_int = PlayerPrefs.GetInt("Vibrate_int");
	}

	public void Careffect()
	{
		if (CarCont.Careffect == 0)
		{
			No_careffect();
		}
		else if (CarCont.Careffect == 1)
		{
			Yes_careffect();
		}
	}

	public void Yes_careffect()
	{
		PlayerPrefs.SetInt("Careffect", 0);
		CarCont.Careffect = PlayerPrefs.GetInt("Careffect");
		_CarCont.Seteffect();
		CareffectBtn.GetComponent<Image>().sprite = Y_careffect;
	}

	public void No_careffect()
	{
		PlayerPrefs.SetInt("Careffect", 1);
		CarCont.Careffect = PlayerPrefs.GetInt("Careffect");
		_CarCont.Seteffect();
		CareffectBtn.GetComponent<Image>().sprite = N_careffect;
	}

	public void Particle()
	{
		if (!b_Particle)
		{
			No_particle();
		}
		else
		{
			Yes_particle();
		}
	}

	public void Yes_particle()
	{
		b_Particle = false;
		ParticleBtn.GetComponent<Image>().sprite = Y_Particle;
		Particle_int = 0;
		PlayerPrefs.SetInt("Particle_int", Particle_int);
		Particle_int = PlayerPrefs.GetInt("Particle_int");
	}

	public void No_particle()
	{
		b_Particle = true;
		ParticleBtn.GetComponent<Image>().sprite = N_Particle;
		Particle_int = 1;
		PlayerPrefs.SetInt("Particle_int", Particle_int);
		Particle_int = PlayerPrefs.GetInt("Particle_int");
	}

	public void FacebookBtn()
	{
		Application.OpenURL("https://www.facebook.com/608factory/posts/");
	}

	public void BlogBtn()
	{
		Application.OpenURL("http://cafe.naver.com/jachui2016");
	}

	public void Twitter()
	{
		Application.OpenURL("https://twitter.com/Yorohito");
	}

	public void OpenCouponWindow()
	{
		CouponWindow.SetActive(true);
		Coupon_Number.text = string.Empty;
	}

	public void Btn()
	{
		gem200 = PlayerPrefs.GetInt("gem200_");
		gem500 = PlayerPrefs.GetInt("gem500_");
		reallysorry = PlayerPrefs.GetInt("reallysorry");
		sorry = PlayerPrefs.GetInt("sorry");
		parrat = PlayerPrefs.GetInt("parrat");
		Moon1 = PlayerPrefs.GetInt("Moon1");
		Gradu5 = PlayerPrefs.GetInt("Gradu5");
		Gradu10 = PlayerPrefs.GetInt("Gradu10");
		Resetreward = PlayerPrefs.GetInt("Resetreward");
		Comeback = PlayerPrefs.GetInt("Comeback1");
		money3 = PlayerPrefs.GetInt("money3");
		if (Coupon_Number.text == "welcomeback1")
		{
			if (Comeback == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (Comeback == 0)
			{
				scene_controll.gem += 1000;
				SPrefs.SetInt("gem2", scene_controll.gem);
				scene_controll.gem = SPrefs.GetInt("gem2");
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("Comeback1", 1);
				Comeback = PlayerPrefs.GetInt("Comeback1");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("보석 1,000개를 보상받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "zxcv2")
		{
			if (gem200 == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (gem200 == 0)
			{
				scene_controll.gem += 200;
				SPrefs.SetInt("gem2", scene_controll.gem);
				scene_controll.gem = SPrefs.GetInt("gem2");
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("gem200_", 1);
				gem200 = PlayerPrefs.GetInt("gem200_");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("보석 200개를 보상받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "zxcv5")
		{
			if (gem500 == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (gem500 == 0)
			{
				scene_controll.gem += 500;
				SPrefs.SetInt("gem2", scene_controll.gem);
				scene_controll.gem = SPrefs.GetInt("gem2");
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("gem500_", 1);
				gem500 = PlayerPrefs.GetInt("gem500_");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("보석 500개를 보상받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "sorrysorry_")
		{
			if (sorry == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (sorry == 0)
			{
				scene_controll.money_Text = SPrefs.GetString("final_money2");
				scene_controll.money = long.Parse(scene_controll.money_Text);
				scene_controll.money += 10000000L;
				scene_controll.money_Text = scene_controll.money.ToString();
				scene_controll.money = long.Parse(scene_controll.money_Text);
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("sorry", 1);
				sorry = PlayerPrefs.GetInt("sorry");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("천만원을 보상받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "갈색패럿")
		{
			if (parrat == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (parrat == 0)
			{
				PlayerPrefs.SetFloat("Pet_15_Max", 50f);
				PlayerPrefs.SetInt("parrat", 1);
				parrat = PlayerPrefs.GetInt("parrat");
				PetPosition.Pet_15_Max = PlayerPrefs.GetFloat("Pet_15_Max");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("갈색패럿의 버그가 수정되었습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "mnbv3")
		{
			if (money3 == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (money3 == 0)
			{
				scene_controll.money_Text = SPrefs.GetString("final_money2");
				scene_controll.money = long.Parse(scene_controll.money_Text);
				scene_controll.money += 30000000L;
				scene_controll.money_Text = scene_controll.money.ToString();
				scene_controll.money = long.Parse(scene_controll.money_Text);
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("money3", 1);
				money3 = PlayerPrefs.GetInt("money3");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("3천만원을 받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "jspksfe")
		{
			if (Resetreward == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 보상을 받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (Resetreward == 0)
			{
				scene_controll.money_Text = SPrefs.GetString("final_money2");
				scene_controll.money = long.Parse(scene_controll.money_Text);
				scene_controll.money += 1000000000L;
				scene_controll.money_Text = scene_controll.money.ToString();
				scene_controll.money = long.Parse(scene_controll.money_Text);
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				scene_controll.gem += 500;
				SPrefs.SetInt("gem2", scene_controll.gem);
				scene_controll.gem = SPrefs.GetInt("gem2");
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("Resetreward", 1);
				Resetreward = PlayerPrefs.GetInt("Resetreward");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("10억원과 보석500개를 보상받았습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "aldkjGs")
		{
			if (Gradu5 == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (Gradu5 == 0)
			{
				GraduateCont.EndingCount += 5;
				PlayerPrefs.SetInt("EndingCount", GraduateCont.EndingCount);
				GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount");
				PlayerPrefs.SetInt("Gradu5", 1);
				Gradu5 = PlayerPrefs.GetInt("Gradu5");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("졸업엔딩 카운트가 5 올라갔습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "dasfkGw")
		{
			if (Gradu10 == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (Gradu10 == 0)
			{
				GraduateCont.EndingCount += 10;
				PlayerPrefs.SetInt("EndingCount", GraduateCont.EndingCount);
				GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount");
				PlayerPrefs.SetInt("Gradu10", 1);
				Gradu10 = PlayerPrefs.GetInt("Gradu10");
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("졸업엔딩 카운트가 10 올라갔습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
		}
		if (Coupon_Number.text == "reallysorry_")
		{
			if (reallysorry == 1)
			{
				Putnumbernotice_Text.GetComponent<Text>().text = string.Format("이미 쿠폰을 사용했습니다.");
				Putnumbernotice.SetActive(true);
				Invoke("SetFalseNotice", 1.5f);
			}
			if (reallysorry == 0)
			{
				scene_controll.money_Text = SPrefs.GetString("final_money2");
				scene_controll.money = long.Parse(scene_controll.money_Text);
				scene_controll.money += 50000000L;
				scene_controll.money_Text = scene_controll.money.ToString();
				scene_controll.money = long.Parse(scene_controll.money_Text);
				SPrefs.SetString("final_money2", scene_controll.money_Text);
				GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
				PlayerPrefs.SetInt("reallysorry", 1);
				reallysorry = PlayerPrefs.GetInt("reallysorry");
			}
		}
		if (Coupon_Number.text == "hobbit10000")
		{
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			scene_controll.money = long.Parse(scene_controll.money_Text);
			scene_controll.money += 9999999999999L;
			scene_controll.money_Text = scene_controll.money.ToString();
			scene_controll.money = long.Parse(scene_controll.money_Text);
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
		if (Coupon_Number.text == "go_graduate")
		{
			GameObject.Find("GraduateController/gradubuff").GetComponent<GraduateCont>().SetGraduEnding();
		}
		if (Coupon_Number.text == "-time")
		{
			GameObject.Find("TimeController").GetComponent<TimeCont>().Minustime();
		}
		if (Coupon_Number.text == "timegrade1")
		{
			GameObject.Find("TimeController").GetComponent<TimeCont>().grade1();
		}
		if (Coupon_Number.text == "timegrade4")
		{
			GameObject.Find("TimeController").GetComponent<TimeCont>().grade4();
		}
		if (Coupon_Number.text == "++")
		{
			SuddenDeathCont.Death_Count += 80;
			PlayerPrefs.SetInt("Death_Count", SuddenDeathCont.Death_Count);
		}
		if (Coupon_Number.text != "sorrysorry_" && Coupon_Number.text != "reallysorry_" && Coupon_Number.text != "hobbit10000" && Coupon_Number.text != "hobbitgradu" && Coupon_Number.text != "-time" && Coupon_Number.text != "timegrade1" && Coupon_Number.text != "timegrade4" && Coupon_Number.text != "welcomeback1" && Coupon_Number.text != "갈색패럿" && Coupon_Number.text != "mnbv3" && Coupon_Number.text != "aldkjGs" && Coupon_Number.text != "dasfkGw" && Coupon_Number.text != "jspksfe" && Coupon_Number.text != "zxcv5" && Coupon_Number.text != "zxcv2")
		{
			Putnumbernotice_Text.GetComponent<Text>().text = string.Format("Please check Coupon number again");
			Putnumbernotice.SetActive(true);
			Invoke("SetFalseNotice", 1.5f);
		}
	}

	public void CheckCoupon()
	{
		GameObject gameObject = (GameObject)Resources.Load("GetPinix");
		GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("GetPinix"));
		GameObject gameObject3 = GameObject.Find("CouponWindow");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
		pinix_pet = 1;
		PlayerPrefs.SetInt("pinix_pet", pinix_pet);
		pinix_pet = PlayerPrefs.GetInt("pinix_pet");
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		if (s3_7.PetBuyOK == 0)
		{
			GameObject.Find("ReportCont").GetComponent<ReportCont>().AdoptSetfalse();
		}
		s3_7.PetBuyOK = 1;
		PlayerPrefs.SetInt("PetBuyOK", s3_7.PetBuyOK);
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		Pet.Pet_N = 20;
		PlayerPrefs.SetInt("Pet_N", Pet.Pet_N);
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		PlayerPrefs.SetInt("pet_20", 1);
		_RoomCont.PetOnOFF();
		CancelInvoke();
		_PetPosition.Start();
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		scene_controll.money += 10000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		scene_controll.money = long.Parse(scene_controll.money_Text);
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
	}

	public void Coupon_OK()
	{
	}

	public void SetFalseNotice()
	{
		Putnumbernotice.SetActive(false);
		Coupon_Number.text = string.Empty;
	}

	public void CloseEventWindow()
	{
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		_bossbackbtn.GetComponent<BossBackbtnManager>().Window = null;
		UnityEngine.Object.Destroy(GameObject.Find("eventPopup(Clone)"));
		Event_a = 1;
	}

	public void GstarStartagain()
	{
		SceneManager.LoadScene("Start");
	}

	public void Graduwin()
	{
		Graduwindow.SetActive(true);
	}

	public void Closecoupon()
	{
		GameObject.Find("CouponWindow").SetActive(false);
	}

	public void Reallychangeroom()
	{
		GameObject gameObject = (GameObject)Resources.Load("ResetRoomReally");
		GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("ResetRoomReally"));
		GameObject gameObject3 = GameObject.Find("SettingWindow");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}
}
