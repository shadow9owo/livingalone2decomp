using UnityEngine;
using UnityEngine.UI;

public class GoAbroadCont : MonoBehaviour
{
	public TimeCont _TimeCont;

	public GameObject GoAbroad;

	public GameObject GoWindow;

	public GameObject ResultWindow;

	public Transform Month;

	public Transform point_T;

	public static int bool_Goabroad;

	public GameObject Nomoney;

	public TextUP _TextUP;

	private GameObject _BossManager;

	public GameObject _backbtn;

	private int where;

	private float pluspoint_;

	private void Start()
	{
		_BossManager = GameObject.Find("BOSSBackbtnManager");
	}

	public void Bool_()
	{
		PlayerPrefs.SetInt("bool_Goabroad", 1);
	}

	public void CloseWindow()
	{
		_backbtn.SetActive(false);
		GoAbroad.SetActive(false);
	}

	public void OK()
	{
		_TimeCont.Semester();
	}

	public void Nomoneyclose()
	{
		Nomoney.SetActive(false);
	}

	public void Philippines()
	{
		if (scene_controll.money < 100000)
		{
			Nomoney.SetActive(true);
			Invoke("Nomoneyclose", 3f);
		}
		else
		{
			_BossManager.GetComponent<BossBackbtnManager>().Window = GameObject.FindGameObjectWithTag("abroadresult");
			where = 1;
			if (TimeCont.OneMonth == 8)
			{
				TimeCont.OneMonth = 9;
				PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
				TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
			}
			if (TimeCont.OneMonth == 2)
			{
				TimeCont.OneMonth = 3;
				PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
				TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
			}
			ButtonCont.Plus_Point = Random.Range(10, 16);
			EventCont.Plus_MONEY = -100000L;
			_TimeCont.AbroadPhil();
			setTime();
			GoWindow.SetActive(false);
			ResultWindow.SetActive(true);
		}
		_TimeCont.Start();
		Bool_();
		_TextUP.PlusMONTH();
	}

	public void NewYork()
	{
		where = 2;
		if (TimeCont.OneMonth == 7)
		{
			TimeCont.OneMonth = 9;
			PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
			TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
		}
		if (TimeCont.OneMonth == 1)
		{
			TimeCont.OneMonth = 3;
			PlayerPrefs.SetInt("OneMonth", TimeCont.OneMonth);
			TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
		}
		ButtonCont.Plus_Point = Random.Range(15f, 21f);
		pluspoint_ = ButtonCont.Plus_Point;
		BarCont.point += ButtonCont.Plus_Point;
		scene_controll.money += 3000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		PlayerPrefs.SetFloat("point", BarCont.point);
		_TimeCont.Start();
		setTime();
		_TextUP.PlusSTUDY();
		GoWindow.SetActive(false);
		ResultWindow.SetActive(true);
		Bool_();
		_TextUP.PlusMONTH();
	}

	public void setTime()
	{
		_TimeCont.SetTimeText();
		Month.GetComponent<Text>().text = string.Format("{0}month now", TimeCont.OneMonth);
		point_T.GetComponent<Text>().text = string.Format("+{0:n0}", ButtonCont.Plus_Point);
	}

	public void ResltwinClose()
	{
		_backbtn.SetActive(false);
		EventCont.Plus_MONEY = 3000000L;
		_TextUP.PlusMONEY();
		if (where == 1)
		{
			scene_controll.money -= 100000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			EventCont.Plus_MONEY = -100000L;
			_TextUP.PlusMONEY();
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
	}

	public void ResltwinOnlyClose()
	{
		_backbtn.SetActive(false);
		ResultWindow.SetActive(false);
		GoAbroad.SetActive(false);
		GoWindow.SetActive(true);
		if (TimeCont.OneMonth == 10)
		{
			GameObject gameObject = GameObject.Find("FeeCont");
			gameObject.GetComponent<FeeCont>().FeeReport();
		}
		if (Lovercont.Phone == 2 && (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 5 || TimeCont.OneMonth == 9 || TimeCont.OneMonth == 11))
		{
			GameObject.Find("Lover_window").GetComponent<Lovercont>().NewLoverOpen();
		}
		_TimeCont.Semester();
	}
}
