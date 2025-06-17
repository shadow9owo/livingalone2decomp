using UnityEngine;
using UnityEngine.UI;

public class s3_2 : MonoBehaviour
{
	public scene_controll scene_controll;

	public s3_3 s3_3;

	public s3_7 s3_7;

	public GameObject[] room_panel_lock;

	public int[] room_num;

	public Transform real_buy_price;

	public Transform[] RoomPrice;

	public Image house_load;

	public GameObject[] arrow;

	public Transform home_lv;

	private void Awake()
	{
		CashCont.Scene_String = "3-2";
		s3_3.bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		s3_3.bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		s3_3.bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		s3_3.living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		s3_3.living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		s3_3.living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		s3_3.toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		s3_3.toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		s3_3.toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N", RoomCont.Room_N);
		if (RoomCont.Room_N == 0)
		{
			RoomCont.Room_N = 1;
		}
		home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
		for (int i = 0; i < room_panel_lock.Length; i++)
		{
			room_panel_lock[i].GetComponent<Button>().interactable = false;
		}
		if (RoomCont.Room_N == 0)
		{
			room_panel_lock[0].GetComponent<Button>().interactable = true;
			room_panel_lock[1].GetComponent<Button>().interactable = true;
			arrow[0].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_1");
			RoomCont.Room_N = 1;
		}
		if (RoomCont.Room_N == 1)
		{
			room_panel_lock[0].GetComponent<Button>().interactable = true;
			room_panel_lock[1].GetComponent<Button>().interactable = true;
			arrow[0].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_1");
		}
		if (RoomCont.Room_N == 2)
		{
			room_panel_lock[1].GetComponent<Button>().interactable = true;
			room_panel_lock[2].GetComponent<Button>().interactable = true;
			arrow[1].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_2");
		}
		if (RoomCont.Room_N == 3)
		{
			room_panel_lock[2].GetComponent<Button>().interactable = true;
			room_panel_lock[3].GetComponent<Button>().interactable = true;
			arrow[2].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_3");
		}
		if (RoomCont.Room_N == 4)
		{
			room_panel_lock[3].GetComponent<Button>().interactable = true;
			room_panel_lock[4].GetComponent<Button>().interactable = true;
			arrow[3].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_4");
		}
		if (RoomCont.Room_N == 5)
		{
			room_panel_lock[4].GetComponent<Button>().interactable = true;
			room_panel_lock[5].GetComponent<Button>().interactable = true;
			arrow[4].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_5");
		}
		if (RoomCont.Room_N == 6)
		{
			room_panel_lock[5].GetComponent<Button>().interactable = true;
			room_panel_lock[6].GetComponent<Button>().interactable = true;
			arrow[5].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_6");
		}
		if (RoomCont.Room_N == 7)
		{
			room_panel_lock[6].GetComponent<Button>().interactable = true;
			room_panel_lock[7].GetComponent<Button>().interactable = true;
			arrow[6].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_7");
		}
		if (RoomCont.Room_N == 8)
		{
			room_panel_lock[7].GetComponent<Button>().interactable = true;
			room_panel_lock[8].GetComponent<Button>().interactable = true;
			arrow[7].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_8");
		}
		if (RoomCont.Room_N == 9)
		{
			room_panel_lock[8].GetComponent<Button>().interactable = true;
			room_panel_lock[9].GetComponent<Button>().interactable = true;
			arrow[8].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_9");
		}
		if (RoomCont.Room_N == 10)
		{
			room_panel_lock[9].GetComponent<Button>().interactable = true;
			room_panel_lock[10].GetComponent<Button>().interactable = true;
			arrow[9].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_10");
		}
		if (RoomCont.Room_N == 11)
		{
			room_panel_lock[10].GetComponent<Button>().interactable = true;
			room_panel_lock[11].GetComponent<Button>().interactable = true;
			arrow[10].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_11");
		}
		if (RoomCont.Room_N == 12)
		{
			room_panel_lock[11].GetComponent<Button>().interactable = true;
			room_panel_lock[12].GetComponent<Button>().interactable = true;
			arrow[11].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_12");
		}
		if (RoomCont.Room_N == 13)
		{
			room_panel_lock[12].GetComponent<Button>().interactable = true;
			room_panel_lock[13].GetComponent<Button>().interactable = true;
			arrow[12].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_13");
		}
		if (RoomCont.Room_N == 14)
		{
			room_panel_lock[13].GetComponent<Button>().interactable = true;
			room_panel_lock[14].GetComponent<Button>().interactable = true;
			arrow[13].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_14");
		}
		if (RoomCont.Room_N == 15)
		{
			room_panel_lock[14].GetComponent<Button>().interactable = true;
			room_panel_lock[15].GetComponent<Button>().interactable = true;
			arrow[14].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_15");
		}
		if (RoomCont.Room_N == 16)
		{
			room_panel_lock[15].GetComponent<Button>().interactable = true;
			room_panel_lock[16].GetComponent<Button>().interactable = true;
			arrow[15].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_16");
		}
		if (RoomCont.Room_N == 17)
		{
			room_panel_lock[16].GetComponent<Button>().interactable = true;
			arrow[16].SetActive(true);
			house_load.sprite = Resources.Load<Sprite>("house_17");
		}
	}

	private void btn_buy()
	{
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		if (s3_3.bed_num[0] == 1 && s3_3.bed_num[1] == 1 && s3_3.bed_num[2] == 1 && s3_3.living_num[0] == 1 && s3_3.living_num[1] == 1 && s3_3.living_num[2] == 1 && s3_3.toilet_num[0] == 1 && s3_3.toilet_num[1] == 1 && s3_3.toilet_num[2] == 1)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.panel_notice[8].SetActive(true);
			if (RoomCont.Room_N == 0 && house_load.sprite == Resources.Load<Sprite>("house_1"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 1 && house_load.sprite == Resources.Load<Sprite>("house_1"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 2 && house_load.sprite == Resources.Load<Sprite>("house_2"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 3 && house_load.sprite == Resources.Load<Sprite>("house_3"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 4 && house_load.sprite == Resources.Load<Sprite>("house_4"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 5 && house_load.sprite == Resources.Load<Sprite>("house_5"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 6 && house_load.sprite == Resources.Load<Sprite>("house_6"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 7 && house_load.sprite == Resources.Load<Sprite>("house_7"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 8 && house_load.sprite == Resources.Load<Sprite>("house_8"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 9 && house_load.sprite == Resources.Load<Sprite>("house_9"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 10 && house_load.sprite == Resources.Load<Sprite>("house_10"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 11 && house_load.sprite == Resources.Load<Sprite>("house_11"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 12 && house_load.sprite == Resources.Load<Sprite>("house_12"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 13 && house_load.sprite == Resources.Load<Sprite>("house_13"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 14 && house_load.sprite == Resources.Load<Sprite>("house_14"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 15 && house_load.sprite == Resources.Load<Sprite>("house_15"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 16 && house_load.sprite == Resources.Load<Sprite>("house_16"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
			if (RoomCont.Room_N == 17 && house_load.sprite == Resources.Load<Sprite>("house_17"))
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[5].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		else if (RoomCont.Room_N == 17 && house_load.sprite == Resources.Load<Sprite>("house_17"))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[5].SetActive(true);
			Invoke("nothing", 1f);
		}
		else
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[6].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	private void back()
	{
		scene_controll.scene_3_2.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		house_load.sprite = Resources.Load<Sprite>(null);
		Resources.UnloadUnusedAssets();
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = GameObject.Find("Tuto_2(Clone)");
			gameObject.GetComponent<Tuto_1>().NEXT();
		}
		s3_7.price_gem = 0;
		s3_7.price = 0;
	}

	public void room_0()
	{
		house_load.sprite = Resources.Load<Sprite>("house_1");
		s3_7.price = 200000;
	}

	public void room_1()
	{
		house_load.sprite = Resources.Load<Sprite>("house_2");
		s3_7.price = 350000;
	}

	public void room_2()
	{
		house_load.sprite = Resources.Load<Sprite>("house_3");
		s3_7.price = 400000;
	}

	public void room_3()
	{
		house_load.sprite = Resources.Load<Sprite>("house_4");
		s3_7.price = 500000;
	}

	public void room_4()
	{
		house_load.sprite = Resources.Load<Sprite>("house_5");
		s3_7.price = 550000;
	}

	public void room_5()
	{
		house_load.sprite = Resources.Load<Sprite>("house_6");
		s3_7.price = 600000;
	}

	public void room_6()
	{
		house_load.sprite = Resources.Load<Sprite>("house_7");
		s3_7.price = 700000;
	}

	public void room_7()
	{
		house_load.sprite = Resources.Load<Sprite>("house_8");
		s3_7.price = 1000000;
	}

	public void room_8()
	{
		house_load.sprite = Resources.Load<Sprite>("house_9");
		s3_7.price = 2000000;
	}

	public void room_9()
	{
		house_load.sprite = Resources.Load<Sprite>("house_10");
		s3_7.price = 3000000;
	}

	public void room_10()
	{
		house_load.sprite = Resources.Load<Sprite>("house_11");
		s3_7.price = 5000000;
	}

	private void room_11()
	{
		house_load.sprite = Resources.Load<Sprite>("house_12");
		s3_7.price = 8000000;
	}

	public void room_12()
	{
		house_load.sprite = Resources.Load<Sprite>("house_13");
		s3_7.price = 15000000;
	}

	public void room_13()
	{
		house_load.sprite = Resources.Load<Sprite>("house_14");
		s3_7.price = 25000000;
	}

	public void room_14()
	{
		house_load.sprite = Resources.Load<Sprite>("house_15");
		s3_7.price = 50000000;
	}

	public void room_15()
	{
		house_load.sprite = Resources.Load<Sprite>("house_16");
		s3_7.price = 100000000;
	}

	public void room_16()
	{
		house_load.sprite = Resources.Load<Sprite>("house_17");
		s3_7.price = 200000000;
	}

	private void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}
}
