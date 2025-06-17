using UnityEngine;
using UnityEngine.UI;

public class scene_controll : MonoBehaviour
{
	public s3_2 s3_2;

	public GameObject scene_1_4;

	public GameObject scene_3_1;

	public GameObject scene_3_2;

	public GameObject scene_3_3;

	public GameObject scene_3_4;

	public GameObject scene_3_5;

	public GameObject scene_3_6;

	public GameObject scene_3_7;

	public GameObject upper_panel;

	public static long money;

	public static int gem;

	public static string money_Text;

	public GameObject head_load;

	public GameObject pet_load;

	public GameObject clothse_load;

	public GameObject MoneyWindow;

	public GameObject gem_text;

	public GameObject btn_cash;

	public GameObject[] money_gem;

	public Transform price_gem_text;

	public GameObject[] panel_notice;

	public static int s1_1_int;

	public GameObject money_window;

	private void Awake()
	{
		OnDestory();
		if (CashCont.Scene_String == "3-2")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(true);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		if (CashCont.Scene_String == "3-3")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(true);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		if (CashCont.Scene_String == "3-4")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(true);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
			Debug.Log("3-4");
		}
		if (CashCont.Scene_String == "3-5")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(true);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
			Debug.Log("3-5");
		}
		if (CashCont.Scene_String == "3-6")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(true);
			scene_3_7.SetActive(false);
			Debug.Log("3-6");
		}
		if (CashCont.Scene_String == "3-7")
		{
			scene_1_4.SetActive(false);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(true);
		}
	}

	private void Start()
	{
		if (TutorialCont.Tutorial_Int == 0)
		{
			btn_cash.SetActive(false);
		}
		else
		{
			btn_cash.SetActive(true);
		}
		money_Text = money.ToString();
		money_Text = SPrefs.GetString("final_money2");
		money = long.Parse(money_Text);
		gem = SPrefs.GetInt("gem2");
		Change();
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		if (scene_controll_2.load_num == 2)
		{
			CashCont.Scene_String = "3-1";
			scene_3_1.SetActive(true);
			scene_1_4.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		if (scene_controll_2.load_num == 4)
		{
			scene_3_1.SetActive(false);
			scene_1_4.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		if (scene_controll_2.load_num == 5)
		{
			scene_3_1.SetActive(false);
			scene_1_4.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		if (scene_controll_2.load_num == 6)
		{
			CashCont.Scene_String = "1-4";
			scene_1_4.SetActive(true);
			scene_3_1.SetActive(false);
			scene_3_2.SetActive(false);
			scene_3_3.SetActive(false);
			scene_3_4.SetActive(false);
			scene_3_5.SetActive(false);
			scene_3_6.SetActive(false);
			scene_3_7.SetActive(false);
		}
		PlayerPrefs.SetInt("MoneyWindow", FeeCont.TotalFee_int);
		if (scene_3_3.activeInHierarchy)
		{
			pet_load.SetActive(false);
			head_load.SetActive(false);
			clothse_load.SetActive(false);
		}
		if (scene_3_2.activeInHierarchy || scene_3_4.activeInHierarchy || scene_3_5.activeInHierarchy || scene_3_6.activeInHierarchy)
		{
			pet_load.SetActive(false);
		}
	}

	private void FixedUpdate()
	{
		if (TutorialCont.Tutorial_Int == 1 && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space)))
		{
			if (scene_1_4.activeInHierarchy)
			{
				Application.LoadLevel("newone");
			}
			if (scene_3_1.activeInHierarchy)
			{
				back();
			}
			if (scene_3_2.activeInHierarchy || scene_3_3.activeInHierarchy || scene_3_4.activeInHierarchy || scene_3_5.activeInHierarchy || scene_3_6.activeInHierarchy || scene_3_7.activeInHierarchy)
			{
				scene_3_1.SetActive(true);
				scene_3_2.SetActive(false);
				scene_3_3.SetActive(false);
				scene_3_4.SetActive(false);
				scene_3_5.SetActive(false);
				scene_3_6.SetActive(false);
				scene_3_7.SetActive(false);
				pet_load.SetActive(false);
				head_load.SetActive(false);
				clothse_load.SetActive(false);
				for (int i = 0; i < panel_notice.Length; i++)
				{
					panel_notice[i].SetActive(false);
				}
			}
		}
		if (money < FeeCont.MonthHouse)
		{
			MoneyWindow.GetComponent<Image>().color = Color.red;
		}
		else
		{
			MoneyWindow.GetComponent<Image>().color = Color.white;
		}
	}

	private void Change()
	{
		if (money <= 0)
		{
			money = 0L;
		}
		long num = money % 1000000000000L;
		long num2 = money % 100000000;
		long num3 = money % 10000;
		long num4 = money % 1;
		if (money >= 1000000000000L)
		{
			long num5 = money / 1000000000000L;
			long num6 = (money - num5 * 1000000000000L) / 100000000;
			if (money - num5 * 1000000000000L <= 0)
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", money);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", money);
			}
		}
		if (money >= 100000000 && money < 1000000000000L)
		{
			long num7 = money / 100000000;
			if (money - num7 * 100000000 <= 0)
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", money);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", money);
			}
		}
		if (money < 100000000)
		{
			money_window.GetComponent<Text>().text = string.Format("{0:n0}G", money);
		}
		gem_text.GetComponent<Text>().text = string.Format("{0:n0}", gem);
	}

	private void CashScene()
	{
		Application.LoadLevel("Cashshop");
		pet_load.SetActive(false);
		head_load.SetActive(false);
		clothse_load.SetActive(false);
	}

	private void back()
	{
		Application.LoadLevel("newone");
		scene_controll_2.load_num = 1;
		pet_load.SetActive(false);
		head_load.SetActive(false);
		clothse_load.SetActive(false);
		s3_7.price = 0;
		s3_7.price_gem = 0;
	}

	private void OnDestory()
	{
		Resources.UnloadUnusedAssets();
	}

	private void plus_money()
	{
		money += 1000000000000L;
		money_Text = money.ToString();
		SPrefs.SetString("final_money2", money_Text);
		PlayerPrefs.Save();
		SPrefs.Save();
	}
}
