using UnityEngine;
using UnityEngine.UI;

public class s3_4 : MonoBehaviour
{
	public scene_controll scene_controll;

	public GameObject[] real_lock;

	public Transform real_buy_price;

	private void Awake()
	{
		CashCont.Scene_String = "3-4";
		CarCont.car_park_num0 = PlayerPrefs.GetInt("car_park_num0");
		CarCont.car_park_num1 = PlayerPrefs.GetInt("car_park_num1");
		CarCont.car_park_num2 = PlayerPrefs.GetInt("car_park_num2");
		CarCont.car_park_num3 = PlayerPrefs.GetInt("car_park_num3");
		CarCont.car_park_num4 = PlayerPrefs.GetInt("car_park_num4");
		CarCont.car_park_num5 = PlayerPrefs.GetInt("car_park_num5");
		CarCont.car_park_num6 = PlayerPrefs.GetInt("car_park_num6");
		CarCont.car_park_num7 = PlayerPrefs.GetInt("car_park_num7");
		CarCont.car_park_num8 = PlayerPrefs.GetInt("car_park_num8");
		CarCont.car_park_num9 = PlayerPrefs.GetInt("car_park_num9");
		CarCont.car_park_num10 = PlayerPrefs.GetInt("car_park_num10");
		CarCont.car_park_num11 = PlayerPrefs.GetInt("car_park_num11");
		CarCont.car_park_num13 = PlayerPrefs.GetInt("car_park_num13");
		CarCont.car_park_num12 = PlayerPrefs.GetInt("car_park_num12");
		CarCont.car_park_num16 = PlayerPrefs.GetInt("car_park_num16");
		if (CarCont.car_park_num0 == 1)
		{
			real_lock[0].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num1 == 1)
		{
			real_lock[1].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num2 == 1)
		{
			real_lock[2].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num3 == 1)
		{
			real_lock[3].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num4 == 1)
		{
			real_lock[4].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num5 == 1)
		{
			real_lock[5].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num6 == 1)
		{
			real_lock[6].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num7 == 1)
		{
			real_lock[7].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num8 == 1)
		{
			real_lock[8].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num9 == 1)
		{
			real_lock[9].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num10 == 1)
		{
			real_lock[10].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num11 == 1)
		{
			real_lock[11].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num13 == 1)
		{
			real_lock[12].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num12 == 1)
		{
			real_lock[13].GetComponent<Button>().interactable = false;
		}
		if (CarCont.car_park_num16 == 1)
		{
			real_lock[14].GetComponent<Button>().interactable = false;
		}
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
	}

	private void FixedUpdate()
	{
	}

	public void back()
	{
		scene_controll.scene_3_4.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = GameObject.Find("Tuto_2(Clone)");
			gameObject.GetComponent<Tuto_1>().NEXT();
		}
		s3_7.price = 0;
		s3_7.price_gem = 0;
	}

	public void btn_car_0()
	{
		s3_7.price = 8000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num0 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
			if (scene_controll.gem < s3_7.price_gem)
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[9].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_1()
	{
		s3_7.price = 12000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num1 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_2()
	{
		s3_7.price = 15000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num2 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_3()
	{
		s3_7.price = 20000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num3 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_4()
	{
		s3_7.price = 30000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num4 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_5()
	{
		s3_7.price = 40000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num5 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_6()
	{
		s3_7.price = 50000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num6 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_7()
	{
		s3_7.price = 70000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num7 = 1;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_8()
	{
		s3_7.price = 90000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num8 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_9()
	{
		s3_7.price = 120000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num9 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_10()
	{
		s3_7.price = 200000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num10 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_11()
	{
		s3_7.price = 300000000;
		s3_7.price_gem = 0;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num11 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_12()
	{
		s3_7.price = 0;
		s3_7.price_gem = 640;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num13 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
			if (scene_controll.gem < s3_7.price_gem)
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[9].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_13()
	{
		s3_7.price = 0;
		s3_7.price_gem = 960;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num16 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num12 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
			if (scene_controll.gem < s3_7.price_gem)
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[9].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
			if (scene_controll.gem < s3_7.price_gem)
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[9].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_car_14()
	{
		s3_7.price = 0;
		s3_7.price_gem = 1200;
		CarCont.car_park_num1 = 0;
		CarCont.car_park_num2 = 0;
		CarCont.car_park_num3 = 0;
		CarCont.car_park_num4 = 0;
		CarCont.car_park_num5 = 0;
		CarCont.car_park_num6 = 0;
		CarCont.car_park_num7 = 0;
		CarCont.car_park_num8 = 0;
		CarCont.car_park_num9 = 0;
		CarCont.car_park_num10 = 0;
		CarCont.car_park_num11 = 0;
		CarCont.car_park_num12 = 0;
		CarCont.car_park_num13 = 0;
		CarCont.car_park_num14 = 0;
		CarCont.car_park_num15 = 0;
		CarCont.car_park_num0 = 0;
		CarCont.car_park_num17 = 0;
		CarCont.car_park_num18 = 0;
		CarCont.car_park_num19 = 0;
		CarCont.car_park_num16 = 1;
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (s3_7.price != 0)
		{
			return;
		}
		if (s3_7.price == 0 && s3_7.price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
			if (scene_controll.gem < s3_7.price_gem)
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[9].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void nothing()
	{
		s3_7.price = 0;
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}
}
