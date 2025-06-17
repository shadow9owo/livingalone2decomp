using UnityEngine;
using UnityEngine.UI;

public class PtjManager : MonoBehaviour
{
	public GameObject scene_2_4;

	public GameObject scene_2_5;

	public Transform money_window_T;

	public GameObject MoneyWindow;

	public GameObject btn_Dark;

	public GameObject btn_more_Dark;

	public GameObject btn_money_inapp;

	public GameObject Cash_panel;

	private void Start()
	{
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		OnDestory();
	}

	private void OnDestory()
	{
		Resources.UnloadUnusedAssets();
	}

	private void FixedUpdate()
	{
		Change();
		if (scene_controll.money < FeeCont.MonthHouse)
		{
			MoneyWindow.GetComponent<Image>().color = Color.red;
		}
		else
		{
			MoneyWindow.GetComponent<Image>().color = Color.white;
		}
		if (Tapjoy_DMS.tapjoy_plusmoney > 0)
		{
			Application.LoadLevel("newone");
		}
	}

	public void Change()
	{
		if (scene_controll.money <= 0)
		{
			scene_controll.money = 0L;
		}
		long num = scene_controll.money % 1000000000000L;
		long num2 = scene_controll.money % 100000000;
		long num3 = scene_controll.money % 10000;
		long num4 = scene_controll.money % 1;
		if (scene_controll.money >= 1000000000000L)
		{
			long num5 = scene_controll.money / 1000000000000L;
			long num6 = (scene_controll.money - num5 * 1000000000000L) / 100000000;
			if (scene_controll.money - num5 * 1000000000000L <= 0)
			{
				money_window_T.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
			else
			{
				money_window_T.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
		}
		if (scene_controll.money >= 100000000 && scene_controll.money < 1000000000000L)
		{
			long num7 = scene_controll.money / 100000000;
			if (scene_controll.money - num7 * 100000000 <= 0)
			{
				money_window_T.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
			else
			{
				money_window_T.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
		}
		if (scene_controll.money < 100000000)
		{
			money_window_T.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		}
	}

	public void back()
	{
		Application.LoadLevel("newone");
		scene_controll_2.load_num = 1;
	}

	public void CashOpen()
	{
		Application.LoadLevel("Cashshop");
	}
}
