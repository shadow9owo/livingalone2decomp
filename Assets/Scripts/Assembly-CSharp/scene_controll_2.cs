using UnityEngine;
using UnityEngine.UI;

public class scene_controll_2 : MonoBehaviour
{
	public static int load_num;

	public Transform money_window;

	public Transform gem_text;

	public static int Ptj_N;

	public GameObject MoneyBar;

	private GameObject Alert;

	private GameObject Alert_;

	private GameObject parent;

	public static int Testcomplete;

	public void Awake()
	{
	}

	private void Start()
	{
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		if (scene_controll.money_Text != null)
		{
			if (scene_controll.money_Text.Length == 0)
			{
				scene_controll.money = 0L;
			}
			else
			{
				scene_controll.money = long.Parse(scene_controll.money_Text);
			}
			scene_controll.money_Text = scene_controll.money.ToString();
		}
		else
		{
			scene_controll.money = 0L;
		}
		scene_controll.gem = SPrefs.GetInt("gem2");
		if (TutorialCont.Tutorial_Int == 0 && scene_controll.money > 100000)
		{
			scene_controll.money = 100000L;
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
		}
		Change();
	}

	public void Change()
	{
		if (scene_controll.money <= 0)
		{
			scene_controll.money = 0L;
		}
		money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		gem_text.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
		if (scene_controll.money < FeeCont.MonthTOtal)
		{
			MoneyBar.GetComponent<Image>().color = Color.red;
		}
		else
		{
			MoneyBar.GetComponent<Image>().color = Color.white;
		}
	}

	private void OnDestory()
	{
		Resources.UnloadUnusedAssets();
	}

	public void Buygem()
	{
		scene_controll.gem += 50;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Change();
	}

	public void btn_shopping()
	{
		Application.LoadLevel("newone2");
		load_num = 2;
		OnDestory();
	}

	public void btn_ptj()
	{
		load_num = 4;
		Ptj_N = 1;
		if (BarCont.hp <= 20f || BarCont.mp <= 20f || BarCont.happy <= 20f || BarCont._int <= 20f)
		{
			ShowAlert();
		}
		if (BarCont.hp > 20f && BarCont.mp > 20f && BarCont.happy > 20f && BarCont._int > 20f)
		{
			Application.LoadLevel("ptj");
			OnDestory();
		}
	}

	public void btn_uni_street()
	{
		load_num = 4;
		Ptj_N = 4;
		if (BarCont.hp <= 20f || BarCont.mp <= 20f || BarCont.happy <= 20f || BarCont._int <= 20f)
		{
			ShowAlert();
		}
		if (BarCont.hp > 20f && BarCont.mp > 20f && BarCont.happy > 20f && BarCont._int > 20f)
		{
			Application.LoadLevel("ptj");
			OnDestory();
		}
	}

	public void btn_album()
	{
		Application.LoadLevel("ending");
		load_num = 5;
		scene_controll.money_Text = scene_controll.money.ToString();
		scene_controll.money = long.Parse(scene_controll.money_Text);
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		OnDestory();
	}

	public void ItemScreen()
	{
		Application.LoadLevel("newone2");
		load_num = 6;
		OnDestory();
	}

	public void studyScreen()
	{
		if ((RoomCont.Room_N == 1) | (RoomCont.Room_N == 0))
		{
			S2_4.month_fee_ = 100000;
		}
		if (RoomCont.Room_N == 2)
		{
			S2_4.month_fee_ = 200000;
		}
		if (RoomCont.Room_N == 3)
		{
			S2_4.month_fee_ = 290000;
		}
		if (RoomCont.Room_N == 4)
		{
			S2_4.month_fee_ = 400000;
		}
		if (RoomCont.Room_N == 5)
		{
			S2_4.month_fee_ = 500000;
		}
		if (RoomCont.Room_N == 6)
		{
			S2_4.month_fee_ = 600000;
		}
		if (RoomCont.Room_N == 7)
		{
			S2_4.month_fee_ = 700000;
		}
		if (RoomCont.Room_N == 8)
		{
			S2_4.month_fee_ = 800000;
		}
		if (RoomCont.Room_N == 9)
		{
			S2_4.month_fee_ = 900000;
		}
		if (RoomCont.Room_N == 10)
		{
			S2_4.month_fee_ = 1000000;
		}
		if (RoomCont.Room_N == 11)
		{
			S2_4.month_fee_ = 1100000;
		}
		if (RoomCont.Room_N == 12)
		{
			S2_4.month_fee_ = 1200000;
		}
		if (RoomCont.Room_N == 13)
		{
			S2_4.month_fee_ = 1290000;
		}
		if (RoomCont.Room_N == 14)
		{
			S2_4.month_fee_ = 1400000;
		}
		if (RoomCont.Room_N == 15)
		{
			S2_4.month_fee_ = 1500000;
		}
		if (RoomCont.Room_N == 16)
		{
			S2_4.month_fee_ = 1600000;
		}
		if (RoomCont.Room_N == 17)
		{
			S2_4.month_fee_ = 1700000;
		}
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		if (scene_controll.money_Text != null)
		{
			if (scene_controll.money_Text.Length == 0)
			{
				scene_controll.money = 0L;
			}
			else
			{
				scene_controll.money = long.Parse(scene_controll.money_Text);
			}
			scene_controll.money_Text = scene_controll.money.ToString();
		}
		else
		{
			scene_controll.money = 0L;
		}
		if (BarCont.st <= 0f)
		{
			if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
			{
				Ptj_N = 3;
				Application.LoadLevel("ptj");
				OnDestory();
				return;
			}
			Ptj_N = 2;
			if (scene_controll.money > 10000 * RoomCont.Room_N)
			{
				if (BarCont.hp > 20f && BarCont.mp > 20f && BarCont.happy > 20f && BarCont._int > 20f)
				{
					Application.LoadLevel("ptj");
					OnDestory();
				}
				if (BarCont.hp <= 20f || BarCont.mp <= 20f || BarCont.happy <= 20f || BarCont._int <= 20f)
				{
					ShowAlert();
				}
			}
			else
			{
				ShowAlert();
			}
			return;
		}
		Ptj_N = 2;
		if (scene_controll.money > 10000 * RoomCont.Room_N)
		{
			if (BarCont.hp > 20f && BarCont.mp > 20f && BarCont.happy > 20f && BarCont._int > 20f)
			{
				Application.LoadLevel("ptj");
				OnDestory();
			}
			if (BarCont.hp <= 20f || BarCont.mp <= 20f || BarCont.happy <= 20f || BarCont._int <= 20f)
			{
				ShowAlert();
			}
		}
		else
		{
			ShowAlert();
		}
	}

	public void ShowAlert()
	{
		Alert = (GameObject)Resources.Load("Alert_window");
		Alert_ = (GameObject)Object.Instantiate(Resources.Load("Alert_window"));
		parent = GameObject.Find("1_2");
		Alert_.transform.SetParent(parent.transform);
		Alert_.transform.localPosition = Alert.transform.localPosition;
		Alert_.transform.localScale = Alert.transform.localScale;
	}
}
