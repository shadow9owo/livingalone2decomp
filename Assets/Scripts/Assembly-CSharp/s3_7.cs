using System;
using UnityEngine;
using UnityEngine.UI;

public class s3_7 : MonoBehaviour
{
	public GameObject[] already_buy_lock;

	public scene_controll scene_controll;

	public s3_5 s3_5;

	public s3_4 s3_4;

	public s3_3 s3_3;

	public s3_2 s3_2;

	public s3_6 s3_6;

	public Animator pet_load;

	public Transform money_window;

	public Transform real_buy_price;

	public static int price;

	public static int price_gem;

	public int[] Pet_N;

	public int[] toilet_realnum;

	public int[] living_realnum;

	public int[] bed_realnum;

	public static int CarEnding;

	public int car_27;

	public GameObject[] pet_ending_lock;

	public GameObject[] pet_stamp;

	public Transform[] pet_stamp_text;

	public GameObject RoomSHOP;

	public GameObject FurnSHOP;

	public GameObject ClotheSHOP;

	public GameObject HairSHOP;

	public GameObject s3_7_obj;

	public GameObject CarSHOP;

	public static int RoomBuyOK;

	public static int FurnBuyOK;

	public static int ClotheBuyOK;

	public static int HairBuyOK;

	public static int HowmanyPETOK;

	public static int CarBuyOK;

	public static int PetBuyOK;

	public static int HairBUY_B;

	public GameObject TutoPanel;

	public static int Lv1_bed;

	public static int Lv1_living;

	public static int Lv1_toilet;

	public static float minushairpoint_W;

	private void Awake()
	{
		CashCont.Scene_String = "3-7";
		for (int i = 0; i < pet_stamp.Length; i++)
		{
			pet_stamp[i].SetActive(true);
			pet_stamp[19].SetActive(false);
			pet_stamp[20].SetActive(false);
			pet_stamp[21].SetActive(false);
			pet_stamp[22].SetActive(false);
		}
		if (scene_controll.scene_3_7.activeSelf)
		{
			Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
			Debug.LogFormat("펫넘버{0}", Pet.Pet_N);
			scene_controll.pet_load.SetActive(true);
			SuddenDeathCont.Death_Count = byte.MaxValue;
			for (int j = 0; j < pet_ending_lock.Length; j++)
			{
				pet_ending_lock[j].GetComponent<Button>().interactable = false;
				if (SuddenDeathCont.Death_Count < 0)
				{
					continue;
				}
				pet_ending_lock[0].GetComponent<Button>().interactable = true;
				if (SuddenDeathCont.Death_Count >= 4)
				{
					pet_ending_lock[1].GetComponent<Button>().interactable = true;
					pet_stamp[0].SetActive(false);
				}
				if (SuddenDeathCont.Death_Count < 8)
				{
					continue;
				}
				pet_ending_lock[2].GetComponent<Button>().interactable = true;
				pet_stamp[1].SetActive(false);
				if (SuddenDeathCont.Death_Count < 12)
				{
					continue;
				}
				pet_ending_lock[3].GetComponent<Button>().interactable = true;
				pet_stamp[2].SetActive(false);
				if (SuddenDeathCont.Death_Count < 16)
				{
					continue;
				}
				pet_ending_lock[4].GetComponent<Button>().interactable = true;
				pet_stamp[3].SetActive(false);
				if (SuddenDeathCont.Death_Count < 20)
				{
					continue;
				}
				pet_ending_lock[5].GetComponent<Button>().interactable = true;
				pet_stamp[4].SetActive(false);
				if (SuddenDeathCont.Death_Count < 24)
				{
					continue;
				}
				pet_ending_lock[6].GetComponent<Button>().interactable = true;
				pet_stamp[5].SetActive(false);
				if (SuddenDeathCont.Death_Count < 28)
				{
					continue;
				}
				pet_ending_lock[7].GetComponent<Button>().interactable = true;
				pet_stamp[6].SetActive(false);
				if (SuddenDeathCont.Death_Count < 32)
				{
					continue;
				}
				pet_ending_lock[8].GetComponent<Button>().interactable = true;
				pet_stamp[7].SetActive(false);
				if (SuddenDeathCont.Death_Count < 36)
				{
					continue;
				}
				pet_ending_lock[9].GetComponent<Button>().interactable = true;
				pet_stamp[8].SetActive(false);
				if (SuddenDeathCont.Death_Count < 40)
				{
					continue;
				}
				pet_ending_lock[10].GetComponent<Button>().interactable = true;
				pet_stamp[9].SetActive(false);
				if (SuddenDeathCont.Death_Count < 44)
				{
					continue;
				}
				pet_ending_lock[11].GetComponent<Button>().interactable = true;
				pet_stamp[10].SetActive(false);
				if (SuddenDeathCont.Death_Count < 48)
				{
					continue;
				}
				pet_ending_lock[12].GetComponent<Button>().interactable = true;
				pet_stamp[11].SetActive(false);
				if (SuddenDeathCont.Death_Count < 52)
				{
					continue;
				}
				pet_ending_lock[13].GetComponent<Button>().interactable = true;
				pet_stamp[12].SetActive(false);
				if (SuddenDeathCont.Death_Count < 56)
				{
					continue;
				}
				pet_ending_lock[14].GetComponent<Button>().interactable = true;
				pet_stamp[13].SetActive(false);
				if (SuddenDeathCont.Death_Count < 60)
				{
					continue;
				}
				pet_ending_lock[15].GetComponent<Button>().interactable = true;
				pet_stamp[14].SetActive(false);
				if (SuddenDeathCont.Death_Count < 64)
				{
					continue;
				}
				pet_ending_lock[16].GetComponent<Button>().interactable = true;
				pet_stamp[15].SetActive(false);
				if (SuddenDeathCont.Death_Count < 68)
				{
					continue;
				}
				pet_ending_lock[17].GetComponent<Button>().interactable = true;
				pet_stamp[16].SetActive(false);
				if (SuddenDeathCont.Death_Count >= 72)
				{
					pet_ending_lock[18].GetComponent<Button>().interactable = true;
					pet_stamp[17].SetActive(false);
					if (SuddenDeathCont.Death_Count >= 76)
					{
						pet_ending_lock[19].GetComponent<Button>().interactable = true;
						pet_stamp[18].SetActive(false);
					}
				}
			}
            SuddenDeathCont.Death_Count = PlayerPrefs.GetInt("Death_Count");
            scene_controll.money_Text = SPrefs.GetString("final_money2");
			scene_controll.money = long.Parse(scene_controll.money_Text);
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			Pet_N[0] = PlayerPrefs.GetInt("pet_0");
			Pet_N[1] = PlayerPrefs.GetInt("pet_1");
			Pet_N[2] = PlayerPrefs.GetInt("pet_2");
			Pet_N[3] = PlayerPrefs.GetInt("pet_3");
			Pet_N[4] = PlayerPrefs.GetInt("pet_4");
			Pet_N[5] = PlayerPrefs.GetInt("pet_5");
			Pet_N[6] = PlayerPrefs.GetInt("pet_6");
			Pet_N[7] = PlayerPrefs.GetInt("pet_7");
			Pet_N[8] = PlayerPrefs.GetInt("pet_8");
			Pet_N[9] = PlayerPrefs.GetInt("pet_9");
			Pet_N[10] = PlayerPrefs.GetInt("pet_10");
			Pet_N[11] = PlayerPrefs.GetInt("pet_11");
			Pet_N[12] = PlayerPrefs.GetInt("pet_12");
			Pet_N[13] = PlayerPrefs.GetInt("pet_13");
			Pet_N[14] = PlayerPrefs.GetInt("pet_14");
			Pet_N[15] = PlayerPrefs.GetInt("pet_15");
			Pet_N[16] = PlayerPrefs.GetInt("pet_16");
			Pet_N[17] = PlayerPrefs.GetInt("pet_17");
			Pet_N[18] = PlayerPrefs.GetInt("pet_18");
			Pet_N[19] = PlayerPrefs.GetInt("pet_19");
			Pet_N[20] = PlayerPrefs.GetInt("pet_20");
			Pet_N[21] = PlayerPrefs.GetInt("pet_21");
			Pet_N[22] = PlayerPrefs.GetInt("pet_22");
			Pet_N[23] = PlayerPrefs.GetInt("pet_23");
			Pet_N[24] = PlayerPrefs.GetInt("pet_24");
			Pet_N[25] = PlayerPrefs.GetInt("pet_25");
			Pet_N[26] = PlayerPrefs.GetInt("pet_26");
			if (Pet_N[0] == 1)
			{
				already_buy_lock[0].GetComponent<Button>().interactable = false;
				pet_stamp[19].SetActive(true);
			}
			if (Pet_N[1] == 1)
			{
				already_buy_lock[1].GetComponent<Button>().interactable = false;
				pet_stamp[0].SetActive(true);
				pet_stamp[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[0].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[0].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[2] == 1)
			{
				already_buy_lock[2].GetComponent<Button>().interactable = false;
				pet_stamp[1].SetActive(true);
				pet_stamp[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[1].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[1].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[3] == 1)
			{
				already_buy_lock[3].GetComponent<Button>().interactable = false;
				pet_stamp[2].SetActive(true);
				pet_stamp[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[2].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[2].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[4] == 1)
			{
				already_buy_lock[4].GetComponent<Button>().interactable = false;
				pet_stamp[3].SetActive(true);
				pet_stamp[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[3].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[3].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[5] == 1)
			{
				already_buy_lock[5].GetComponent<Button>().interactable = false;
				pet_stamp[4].SetActive(true);
				pet_stamp[4].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[4].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[4].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[6] == 1)
			{
				already_buy_lock[6].GetComponent<Button>().interactable = false;
				pet_stamp[5].SetActive(true);
				pet_stamp[5].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[5].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[5].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[7] == 1)
			{
				already_buy_lock[7].GetComponent<Button>().interactable = false;
				pet_stamp[6].SetActive(true);
				pet_stamp[6].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[6].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[6].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[8] == 1)
			{
				already_buy_lock[8].GetComponent<Button>().interactable = false;
				pet_stamp[7].SetActive(true);
				pet_stamp[7].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[7].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[7].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[9] == 1)
			{
				already_buy_lock[9].GetComponent<Button>().interactable = false;
				pet_stamp[8].SetActive(true);
				pet_stamp[8].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[8].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[8].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[10] == 1)
			{
				already_buy_lock[10].GetComponent<Button>().interactable = false;
				pet_stamp[9].SetActive(true);
				pet_stamp[9].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[9].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[9].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[11] == 1)
			{
				already_buy_lock[11].GetComponent<Button>().interactable = false;
				pet_stamp[10].SetActive(true);
				pet_stamp[10].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[10].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[10].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[12] == 1)
			{
				already_buy_lock[12].GetComponent<Button>().interactable = false;
				pet_stamp[11].SetActive(true);
				pet_stamp[11].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[11].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[11].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[13] == 1)
			{
				already_buy_lock[13].GetComponent<Button>().interactable = false;
				pet_stamp[12].SetActive(true);
				pet_stamp[12].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[12].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[12].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[14] == 1)
			{
				already_buy_lock[14].GetComponent<Button>().interactable = false;
				pet_stamp[13].SetActive(true);
				pet_stamp[13].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[13].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[13].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[15] == 1)
			{
				already_buy_lock[15].GetComponent<Button>().interactable = false;
				pet_stamp[14].SetActive(true);
				pet_stamp[14].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[14].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[14].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[16] == 1)
			{
				already_buy_lock[16].GetComponent<Button>().interactable = false;
				pet_stamp[15].SetActive(true);
				pet_stamp[15].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[15].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[15].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[17] == 1)
			{
				already_buy_lock[17].GetComponent<Button>().interactable = false;
				pet_stamp[16].SetActive(true);
				pet_stamp[16].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[16].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[16].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[18] == 1)
			{
				already_buy_lock[18].GetComponent<Button>().interactable = false;
				pet_stamp[17].SetActive(true);
				pet_stamp[17].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[17].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[17].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[19] == 1)
			{
				already_buy_lock[19].GetComponent<Button>().interactable = false;
				pet_stamp[18].SetActive(true);
				pet_stamp[18].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[18].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[18].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (Pet_N[21] == 1)
			{
				already_buy_lock[20].GetComponent<Button>().interactable = false;
				pet_stamp[20].SetActive(true);
			}
			if (Pet_N[22] == 1)
			{
				already_buy_lock[21].GetComponent<Button>().interactable = false;
				pet_stamp[21].SetActive(true);
			}
			if (Pet_N[25] == 1)
			{
				already_buy_lock[22].GetComponent<Button>().interactable = false;
				pet_stamp[22].SetActive(true);
			}
			if (Pet.Pet_N == 0)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
			}
			if (Pet.Pet_N == 1)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
			}
			if (Pet.Pet_N == 2)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
			}
			if (Pet.Pet_N == 3)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
			}
			if (Pet.Pet_N == 4)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
			}
			if (Pet.Pet_N == 5)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
			}
			if (Pet.Pet_N == 6)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
			}
			if (Pet.Pet_N == 7)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphadog");
			}
			if (Pet.Pet_N == 8)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
			}
			if (Pet.Pet_N == 9)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
			}
			if (Pet.Pet_N == 10)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
			}
			if (Pet.Pet_N == 11)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
			}
			if (Pet.Pet_N == 12)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
			}
			if (Pet.Pet_N == 13)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
			}
			if (Pet.Pet_N == 14)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
			}
			if (Pet.Pet_N == 15)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
			}
			if (Pet.Pet_N == 16)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
			}
			if (Pet.Pet_N == 17)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
			}
			if (Pet.Pet_N == 18)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
			}
			if (Pet.Pet_N == 19)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
			}
			if (Pet.Pet_N == 20)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
			}
			if (Pet.Pet_N == 21)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
			}
			if (Pet.Pet_N == 22)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
			}
			if (Pet.Pet_N == 23)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
			}
			if (Pet.Pet_N == 24)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
			}
			if (Pet.Pet_N == 25)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
			}
			if (Pet.Pet_N == 26)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 3");
			}
			if (Pet.Pet_N == 99)
			{
				pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		FeeCont.SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
		minushairpoint_W = PlayerPrefs.GetFloat("minushairpoint_W", minushairpoint_W);
	}

	public void reset()
	{
		price = 0;
		scene_controll.pet_load.SetActive(true);
		if (Pet.Pet_N == 0)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
		}
		if (Pet.Pet_N == 1)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
		}
		if (Pet.Pet_N == 2)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
		}
		if (Pet.Pet_N == 3)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
		}
		if (Pet.Pet_N == 4)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
		}
		if (Pet.Pet_N == 5)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
		}
		if (Pet.Pet_N == 6)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
		}
		if (Pet.Pet_N == 7)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphadog");
		}
		if (Pet.Pet_N == 8)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
		}
		if (Pet.Pet_N == 9)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
		}
		if (Pet.Pet_N == 10)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
		}
		if (Pet.Pet_N == 11)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
		}
		if (Pet.Pet_N == 12)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
		}
		if (Pet.Pet_N == 13)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
		}
		if (Pet.Pet_N == 14)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
		}
		if (Pet.Pet_N == 15)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
		}
		if (Pet.Pet_N == 16)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
		}
		if (Pet.Pet_N == 17)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
		}
		if (Pet.Pet_N == 18)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
		}
		if (Pet.Pet_N == 19)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
		}
		if (Pet.Pet_N == 20)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
		}
		if (Pet.Pet_N == 21)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
		}
		if (Pet.Pet_N == 22)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
		}
		if (Pet.Pet_N == 23)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
		}
		if (Pet.Pet_N == 24)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
		}
		if (Pet.Pet_N == 25)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
		}
		if (Pet.Pet_N == 25)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 3");
		}
		if (Pet.Pet_N == 99)
		{
			pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
		}
	}

	public void btn_buy()
	{
		scene_controll.panel_notice[7].SetActive(true);
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		if (scene_controll.scene_3_2.activeSelf)
		{
			return;
		}
		if (scene_controll.money < price)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (price != 0)
		{
			return;
		}
		if (price == 0 && price_gem > 0)
		{
			scene_controll.panel_notice[7].SetActive(true);
			scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", price_gem);
			for (int j = 0; j < scene_controll.money_gem.Length; j++)
			{
				scene_controll.money_gem[j].SetActive(false);
			}
			scene_controll.money_gem[1].SetActive(true);
			if (scene_controll.gem < price_gem)
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

	public void btn_real_buy_no()
	{
		if (scene_controll.scene_3_4.activeSelf)
		{
			CarCont.car_park_num0 = 0;
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
		}
		if (scene_controll.scene_3_3.activeSelf)
		{
			for (int i = 0; i < s3_3.bed_num.Length; i++)
			{
				s3_3.bed_num[i] = 0;
			}
			for (int j = 0; j < s3_3.living_num.Length; j++)
			{
				s3_3.living_num[j] = 0;
			}
			for (int k = 0; k < s3_3.toilet_num.Length; k++)
			{
				s3_3.toilet_num[k] = 0;
			}
			s3_3.fur_money = 0L;
		}
		for (int l = 0; l < scene_controll.panel_notice.Length; l++)
		{
			scene_controll.panel_notice[l].SetActive(false);
		}
		price = 0;
		price_gem = 0;
	}

	public void btn_real_buy_yes()
	{
		scene_controll.panel_notice[0].SetActive(true);
		scene_controll.panel_notice[3].SetActive(true);
		scene_controll.panel_notice[7].SetActive(false);
		if (scene_controll.scene_3_2.activeSelf)
		{
			price = 0;
		}
		if (scene_controll.scene_3_3.activeSelf)
		{
			scene_controll.money -= s3_3.fur_money;
		}
		else
		{
			scene_controll.money -= price;
			scene_controll.gem -= price_gem;
		}
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		PlayerPrefs.Save();
		SPrefs.Save();
		Invoke("thing", 0.1f);
	}

	public void btn_cat()
	{
		price = 20000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_dog()
	{
		price = 30000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_pig()
	{
		price = 50000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_rabbit()
	{
		price = 70000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_d_fox()
	{
		price = 100000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_rocoon()
	{
		price = 150000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_fox()
	{
		price = 200000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_alphadog()
	{
		price = 300000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphadog");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_pangguin()
	{
		price = 400000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_chick()
	{
		price = 700000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_alpaca()
	{
		price = 1000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_turtle()
	{
		price = 2000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_ele()
	{
		price = 3500000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_snake()
	{
		price = 4000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_panda()
	{
		price = 8000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_parret()
	{
		price = 30000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_dragon()
	{
		price = 100000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_tiger()
	{
		price = 130000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_elepant()
	{
		price = 160000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_kang()
	{
		price = 200000000;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", price);
	}

	public void btn_pinix()
	{
		price = 0;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
		PlayerPrefs.SetInt("Pet_N", 20);
		PlayerPrefs.SetInt("PetBuyOK", 1);
	}

	public void btn_pega()
	{
		price = 0;
		price_gem = 300;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
	}

	public void btn_babychick()
	{
		price = 0;
		price_gem = 300;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
	}

	public void btn_waterdog()
	{
		price = 0;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
	}

	public void btn_Wdragon()
	{
		price = 0;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
	}

	public void btn_monkey()
	{
		price = 0;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
	}

	public void btn_wolf()
	{
		price = 0;
		price_gem = 0;
		scene_controll.pet_load.SetActive(true);
		pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 3");
	}

	public void back()
	{
		scene_controll.pet_load.SetActive(false);
		scene_controll.scene_3_7.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		Resources.UnloadUnusedAssets();
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
		price = 0;
		price_gem = 0;
	}

	public void thing()
	{
		Invoke("nothing", 1f);
		if (RoomSHOP.activeInHierarchy)
		{
			RoomBuyOK++;
			PlayerPrefs.SetInt("RoomBuyOK", RoomBuyOK);
		}
		if (FurnSHOP.activeInHierarchy)
		{
			FurnBuyOK++;
			PlayerPrefs.SetInt("FurnBuyOK", FurnBuyOK);
		}
		if (ClotheSHOP.activeInHierarchy)
		{
			ClotheBuyOK++;
			PlayerPrefs.SetInt("ClotheBuyOK", ClotheBuyOK);
		}
		if (HairSHOP.activeInHierarchy)
		{
			HairBuyOK++;
			PlayerPrefs.SetInt("HairBuyOK", HairBuyOK);
			HairBUY_B = 2;
		}
		if (s3_7_obj.activeInHierarchy)
		{
			PetBuyOK = 1;
			PlayerPrefs.SetInt("PetBuyOK", PetBuyOK);
			HowmanyPETOK++;
			PlayerPrefs.SetInt("HowmanyPETOK", HowmanyPETOK);
			HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		}
		if (CarSHOP.activeInHierarchy)
		{
			CarBuyOK++;
			PlayerPrefs.SetInt("CarBuyOK", CarBuyOK);
			PlayerPrefs.SetInt("CarEnding", 1);
			CarEnding = PlayerPrefs.GetInt("CarEnding");
		}
		if (scene_controll.scene_3_2.activeSelf)
		{
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_1"))
			{
				s3_2.room_num[0] = 1;
				PlayerPrefs.SetInt("room_num[0]", s3_2.room_num[0]);
				RoomCont.Room_N = 1;
				PlayerPrefs.SetInt("Room_N", 1);
				s3_2.room_panel_lock[0].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[2].GetComponent<Button>().interactable = true;
				for (int i = 0; i < s3_2.arrow.Length; i++)
				{
					s3_2.arrow[i].SetActive(false);
				}
				s3_2.arrow[1].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_2"))
			{
				s3_2.room_num[1] = 1;
				PlayerPrefs.SetInt("room_num[1]", s3_2.room_num[1]);
				RoomCont.Room_N = 2;
				PlayerPrefs.SetInt("Room_N", 2);
				s3_2.room_panel_lock[0].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[2].GetComponent<Button>().interactable = true;
				for (int j = 0; j < s3_2.arrow.Length; j++)
				{
					s3_2.arrow[j].SetActive(false);
				}
				s3_2.arrow[1].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_3"))
			{
				s3_2.room_num[2] = 1;
				PlayerPrefs.SetInt("room_num[2]", s3_2.room_num[2]);
				RoomCont.Room_N = 3;
				PlayerPrefs.SetInt("Room_N", 3);
				s3_2.room_panel_lock[1].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[3].GetComponent<Button>().interactable = true;
				for (int k = 0; k < s3_2.arrow.Length; k++)
				{
					s3_2.arrow[k].SetActive(false);
				}
				s3_2.arrow[2].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_4"))
			{
				s3_2.room_num[3] = 1;
				PlayerPrefs.SetInt("room_num[3]", s3_2.room_num[3]);
				RoomCont.Room_N = 4;
				PlayerPrefs.SetInt("Room_N", 4);
				s3_2.room_panel_lock[2].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[4].GetComponent<Button>().interactable = true;
				for (int l = 0; l < s3_2.arrow.Length; l++)
				{
					s3_2.arrow[l].SetActive(false);
				}
				s3_2.arrow[3].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_5"))
			{
				s3_2.room_num[4] = 1;
				PlayerPrefs.SetInt("room_num[4]", s3_2.room_num[4]);
				RoomCont.Room_N = 5;
				PlayerPrefs.SetInt("Room_N", 5);
				s3_2.room_panel_lock[3].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[5].GetComponent<Button>().interactable = true;
				for (int m = 0; m < s3_2.arrow.Length; m++)
				{
					s3_2.arrow[m].SetActive(false);
				}
				s3_2.arrow[4].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_6"))
			{
				s3_2.room_num[5] = 1;
				PlayerPrefs.SetInt("room_num[5]", s3_2.room_num[5]);
				RoomCont.Room_N = 6;
				PlayerPrefs.SetInt("Room_N", 6);
				s3_2.room_panel_lock[4].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[6].GetComponent<Button>().interactable = true;
				for (int n = 0; n < s3_2.arrow.Length; n++)
				{
					s3_2.arrow[n].SetActive(false);
				}
				s3_2.arrow[5].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_7"))
			{
				s3_2.room_num[6] = 1;
				PlayerPrefs.SetInt("room_num[6]", s3_2.room_num[6]);
				RoomCont.Room_N = 7;
				PlayerPrefs.SetInt("Room_N", 7);
				s3_2.room_panel_lock[5].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[7].GetComponent<Button>().interactable = true;
				for (int num = 0; num < s3_2.arrow.Length; num++)
				{
					s3_2.arrow[num].SetActive(false);
				}
				s3_2.arrow[6].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_8"))
			{
				s3_2.room_num[7] = 1;
				PlayerPrefs.SetInt("room_num[7]", s3_2.room_num[7]);
				RoomCont.Room_N = 8;
				PlayerPrefs.SetInt("Room_N", 8);
				s3_2.room_panel_lock[6].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[8].GetComponent<Button>().interactable = true;
				for (int num2 = 0; num2 < s3_2.arrow.Length; num2++)
				{
					s3_2.arrow[num2].SetActive(false);
				}
				s3_2.arrow[7].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_9"))
			{
				s3_2.room_num[8] = 1;
				PlayerPrefs.SetInt("room_num[8]", s3_2.room_num[8]);
				RoomCont.Room_N = 9;
				PlayerPrefs.SetInt("Room_N", 9);
				s3_2.room_panel_lock[7].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[9].GetComponent<Button>().interactable = true;
				for (int num3 = 0; num3 < s3_2.arrow.Length; num3++)
				{
					s3_2.arrow[num3].SetActive(false);
				}
				s3_2.arrow[8].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_10"))
			{
				s3_2.room_num[9] = 1;
				PlayerPrefs.SetInt("room_num[9]", s3_2.room_num[9]);
				RoomCont.Room_N = 10;
				PlayerPrefs.SetInt("Room_N", 10);
				s3_2.room_panel_lock[8].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[10].GetComponent<Button>().interactable = true;
				for (int num4 = 0; num4 < s3_2.arrow.Length; num4++)
				{
					s3_2.arrow[num4].SetActive(false);
				}
				s3_2.arrow[9].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_11"))
			{
				s3_2.room_num[10] = 1;
				PlayerPrefs.SetInt("room_num[10]", s3_2.room_num[10]);
				RoomCont.Room_N = 11;
				PlayerPrefs.SetInt("Room_N", 11);
				s3_2.room_panel_lock[9].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[11].GetComponent<Button>().interactable = true;
				for (int num5 = 0; num5 < s3_2.arrow.Length; num5++)
				{
					s3_2.arrow[num5].SetActive(false);
				}
				s3_2.arrow[10].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_12"))
			{
				s3_2.room_num[11] = 1;
				PlayerPrefs.SetInt("room_num[11]", s3_2.room_num[11]);
				RoomCont.Room_N = 12;
				PlayerPrefs.SetInt("Room_N", 12);
				s3_2.room_panel_lock[10].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[12].GetComponent<Button>().interactable = true;
				for (int num6 = 0; num6 < s3_2.arrow.Length; num6++)
				{
					s3_2.arrow[num6].SetActive(false);
				}
				s3_2.arrow[11].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_13"))
			{
				s3_2.room_num[12] = 1;
				PlayerPrefs.SetInt("room_num[12]", s3_2.room_num[12]);
				RoomCont.Room_N = 13;
				PlayerPrefs.SetInt("Room_N", 13);
				s3_2.room_panel_lock[11].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[13].GetComponent<Button>().interactable = true;
				for (int num7 = 0; num7 < s3_2.arrow.Length; num7++)
				{
					s3_2.arrow[num7].SetActive(false);
				}
				s3_2.arrow[12].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_14"))
			{
				s3_2.room_num[13] = 1;
				PlayerPrefs.SetInt("room_num[13]", s3_2.room_num[13]);
				RoomCont.Room_N = 14;
				PlayerPrefs.SetInt("Room_N", 14);
				s3_2.room_panel_lock[12].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[14].GetComponent<Button>().interactable = true;
				for (int num8 = 0; num8 < s3_2.arrow.Length; num8++)
				{
					s3_2.arrow[num8].SetActive(false);
				}
				s3_2.arrow[13].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_15"))
			{
				s3_2.room_num[14] = 1;
				PlayerPrefs.SetInt("room_num[14]", s3_2.room_num[14]);
				RoomCont.Room_N = 15;
				PlayerPrefs.SetInt("Room_N", 15);
				s3_2.room_panel_lock[13].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[15].GetComponent<Button>().interactable = true;
				for (int num9 = 0; num9 < s3_2.arrow.Length; num9++)
				{
					s3_2.arrow[num9].SetActive(false);
				}
				s3_2.arrow[14].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_16"))
			{
				s3_2.room_num[15] = 1;
				PlayerPrefs.SetInt("room_num[15]", s3_2.room_num[15]);
				RoomCont.Room_N = 16;
				PlayerPrefs.SetInt("Room_N", 16);
				s3_2.room_panel_lock[14].GetComponent<Button>().interactable = false;
				s3_2.room_panel_lock[16].GetComponent<Button>().interactable = true;
				for (int num10 = 0; num10 < s3_2.arrow.Length; num10++)
				{
					s3_2.arrow[num10].SetActive(false);
				}
				s3_2.arrow[15].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
			if (s3_2.house_load.sprite == Resources.Load<Sprite>("house_17"))
			{
				s3_2.room_num[16] = 1;
				PlayerPrefs.SetInt("room_num[16]", s3_2.room_num[16]);
				RoomCont.Room_N = 17;
				PlayerPrefs.SetInt("Room_N", 17);
				s3_2.room_panel_lock[15].GetComponent<Button>().interactable = false;
				for (int num11 = 0; num11 < s3_2.arrow.Length; num11++)
				{
					s3_2.arrow[num11].SetActive(false);
				}
				s3_2.arrow[16].SetActive(true);
				s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
			}
		}
		if (scene_controll.scene_3_3.activeSelf)
		{
			if (s3_3.bed_num[0] == 1 && s3_3.bed_panel_lock[0].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Bed_N = 0;
					PlayerPrefs.SetInt("Lv1_bed", 1);
					Lv1_bed = PlayerPrefs.GetInt("Lv1_bed");
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Bed_N = 3;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Bed_N = 6;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Bed_N = 9;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Bed_N = 12;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Bed_N = 15;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Bed_N = 18;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Bed_N = 21;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Bed_N = 24;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Bed_N = 27;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Bed_N = 30;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Bed_N = 33;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Bed_N = 36;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Bed_N = 39;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Bed_N = 42;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Bed_N = 45;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Bed_N = 48;
				}
				s3_3.bed_panel_lock[0].GetComponent<Button>().interactable = false;
				s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("bed_num[0]", s3_3.bed_num[0]);
			}
			if (s3_3.bed_num[1] == 1 && s3_3.bed_panel_lock[1].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Bed_N = 1;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Bed_N = 4;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Bed_N = 7;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Bed_N = 10;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Bed_N = 13;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Bed_N = 16;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Bed_N = 19;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Bed_N = 22;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Bed_N = 25;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Bed_N = 28;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Bed_N = 31;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Bed_N = 34;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Bed_N = 37;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Bed_N = 40;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Bed_N = 43;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Bed_N = 46;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Bed_N = 49;
				}
				s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = false;
				s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("bed_num[1]", s3_3.bed_num[1]);
			}
			if (s3_3.bed_num[2] == 1 && s3_3.bed_panel_lock[2].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Bed_N = 2;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Bed_N = 5;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Bed_N = 8;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Bed_N = 11;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Bed_N = 14;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Bed_N = 17;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Bed_N = 20;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Bed_N = 23;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Bed_N = 26;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Bed_N = 29;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Bed_N = 32;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Bed_N = 35;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Bed_N = 38;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Bed_N = 41;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Bed_N = 44;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Bed_N = 47;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Bed_N = 50;
				}
				s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = false;
				PlayerPrefs.SetInt("bed_num[2]", s3_3.bed_num[2]);
			}
			if (s3_3.living_num[0] == 1 && s3_3.living_panel_lock[0].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Kitchen_N = 0;
					PlayerPrefs.SetInt("Lv1_living", 1);
					Lv1_living = PlayerPrefs.GetInt("Lv1_living");
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Kitchen_N = 3;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Kitchen_N = 6;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Kitchen_N = 9;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Kitchen_N = 12;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Kitchen_N = 15;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Kitchen_N = 18;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Kitchen_N = 21;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Kitchen_N = 24;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Kitchen_N = 27;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Kitchen_N = 30;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Kitchen_N = 33;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Kitchen_N = 36;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Kitchen_N = 39;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Kitchen_N = 42;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Kitchen_N = 45;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Kitchen_N = 48;
				}
				s3_3.living_panel_lock[0].GetComponent<Button>().interactable = false;
				s3_3.living_panel_lock[1].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("living_num[0]", s3_3.living_num[0]);
			}
			if (s3_3.living_num[1] == 1 && s3_3.living_panel_lock[1].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Kitchen_N = 1;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Kitchen_N = 4;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Kitchen_N = 7;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Kitchen_N = 10;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Kitchen_N = 13;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Kitchen_N = 16;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Kitchen_N = 19;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Kitchen_N = 22;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Kitchen_N = 25;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Kitchen_N = 28;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Kitchen_N = 31;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Kitchen_N = 34;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Kitchen_N = 37;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Kitchen_N = 40;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Kitchen_N = 43;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Kitchen_N = 46;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Kitchen_N = 49;
				}
				s3_3.living_panel_lock[1].GetComponent<Button>().interactable = false;
				s3_3.living_panel_lock[2].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("living_num[1]", s3_3.living_num[1]);
			}
			if (s3_3.living_num[2] == 1 && s3_3.living_panel_lock[2].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Kitchen_N = 2;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Kitchen_N = 5;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Kitchen_N = 8;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Kitchen_N = 11;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Kitchen_N = 14;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Kitchen_N = 17;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Kitchen_N = 20;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Kitchen_N = 23;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Kitchen_N = 26;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Kitchen_N = 29;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Kitchen_N = 32;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Kitchen_N = 35;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Kitchen_N = 38;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Kitchen_N = 41;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Kitchen_N = 44;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Kitchen_N = 47;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Kitchen_N = 50;
				}
				s3_3.living_panel_lock[2].GetComponent<Button>().interactable = false;
				PlayerPrefs.SetInt("living_num[2]", s3_3.living_num[2]);
			}
			if (s3_3.toilet_num[0] == 1 && s3_3.toilet_panel_lock[0].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					PlayerPrefs.SetInt("Lv1_toilet", 1);
					Lv1_toilet = PlayerPrefs.GetInt("Lv1_toilet");
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Toilet_N = 3;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Toilet_N = 6;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Toilet_N = 9;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Toilet_N = 12;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Toilet_N = 15;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Toilet_N = 18;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Toilet_N = 21;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Toilet_N = 24;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Toilet_N = 27;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Toilet_N = 30;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Toilet_N = 33;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Toilet_N = 36;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Toilet_N = 39;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Toilet_N = 42;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Toilet_N = 45;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Toilet_N = 48;
				}
				s3_3.toilet_panel_lock[0].GetComponent<Button>().interactable = false;
				s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("toilet_num[0]", s3_3.toilet_num[0]);
			}
			if (s3_3.toilet_num[1] == 1 && s3_3.toilet_panel_lock[1].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Toilet_N = 1;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Toilet_N = 4;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Toilet_N = 7;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Toilet_N = 10;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Toilet_N = 13;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Toilet_N = 16;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Toilet_N = 19;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Toilet_N = 22;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Toilet_N = 25;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Toilet_N = 28;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Toilet_N = 31;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Toilet_N = 34;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Toilet_N = 37;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Toilet_N = 40;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Toilet_N = 43;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Toilet_N = 46;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Toilet_N = 49;
				}
				s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = false;
				s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = true;
				PlayerPrefs.SetInt("toilet_num[1]", s3_3.toilet_num[1]);
			}
			if (s3_3.toilet_num[2] == 1 && s3_3.toilet_panel_lock[2].activeSelf)
			{
				if (RoomCont.Room_N == 1)
				{
					FurnCont.Toilet_N = 2;
				}
				if (RoomCont.Room_N == 2)
				{
					FurnCont.Toilet_N = 5;
				}
				if (RoomCont.Room_N == 3)
				{
					FurnCont.Toilet_N = 8;
				}
				if (RoomCont.Room_N == 4)
				{
					FurnCont.Toilet_N = 11;
				}
				if (RoomCont.Room_N == 5)
				{
					FurnCont.Toilet_N = 14;
				}
				if (RoomCont.Room_N == 6)
				{
					FurnCont.Toilet_N = 17;
				}
				if (RoomCont.Room_N == 7)
				{
					FurnCont.Toilet_N = 20;
				}
				if (RoomCont.Room_N == 8)
				{
					FurnCont.Toilet_N = 23;
				}
				if (RoomCont.Room_N == 9)
				{
					FurnCont.Toilet_N = 26;
				}
				if (RoomCont.Room_N == 10)
				{
					FurnCont.Toilet_N = 29;
				}
				if (RoomCont.Room_N == 11)
				{
					FurnCont.Toilet_N = 32;
				}
				if (RoomCont.Room_N == 12)
				{
					FurnCont.Toilet_N = 35;
				}
				if (RoomCont.Room_N == 13)
				{
					FurnCont.Toilet_N = 38;
				}
				if (RoomCont.Room_N == 14)
				{
					FurnCont.Toilet_N = 41;
				}
				if (RoomCont.Room_N == 15)
				{
					FurnCont.Toilet_N = 44;
				}
				if (RoomCont.Room_N == 16)
				{
					FurnCont.Toilet_N = 47;
				}
				if (RoomCont.Room_N == 17)
				{
					FurnCont.Toilet_N = 50;
				}
				s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = false;
				PlayerPrefs.SetInt("toilet_num[2]", s3_3.toilet_num[2]);
				Debug.Log("Bed_N" + FurnCont.Bed_N);
				Debug.Log("Toilet_N" + FurnCont.Toilet_N);
				Debug.Log("Kitchen_N" + FurnCont.Kitchen_N);
			}
		}
		if (scene_controll.scene_3_4.activeSelf)
		{
			if (CarCont.car_park_num0 == 1)
			{
				PlayerPrefs.SetInt("car_park_num0", CarCont.car_park_num0);
				s3_4.real_lock[0].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num1 == 1)
			{
				PlayerPrefs.SetInt("car_park_num1", CarCont.car_park_num1);
				s3_4.real_lock[1].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num2 == 1)
			{
				PlayerPrefs.SetInt("car_park_num2", CarCont.car_park_num2);
				s3_4.real_lock[2].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num3 == 1)
			{
				PlayerPrefs.SetInt("car_park_num3", CarCont.car_park_num3);
				s3_4.real_lock[3].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num4 == 1)
			{
				PlayerPrefs.SetInt("car_park_num4", CarCont.car_park_num4);
				s3_4.real_lock[4].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num5 == 1)
			{
				PlayerPrefs.SetInt("car_park_num5", CarCont.car_park_num5);
				s3_4.real_lock[5].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num6 == 1)
			{
				PlayerPrefs.SetInt("car_park_num6", CarCont.car_park_num6);
				s3_4.real_lock[6].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num7 == 1)
			{
				PlayerPrefs.SetInt("car_park_num7", CarCont.car_park_num7);
				s3_4.real_lock[7].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num8 == 1)
			{
				PlayerPrefs.SetInt("car_park_num8", CarCont.car_park_num8);
				s3_4.real_lock[8].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num9 == 1)
			{
				PlayerPrefs.SetInt("car_park_num9", CarCont.car_park_num9);
				s3_4.real_lock[9].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num10 == 1)
			{
				PlayerPrefs.SetInt("car_park_num10", CarCont.car_park_num10);
				s3_4.real_lock[10].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num11 == 1)
			{
				PlayerPrefs.SetInt("car_park_num11", CarCont.car_park_num11);
				s3_4.real_lock[11].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num13 == 1)
			{
				PlayerPrefs.SetInt("car_park_num13", CarCont.car_park_num13);
				s3_4.real_lock[12].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num12 == 1)
			{
				PlayerPrefs.SetInt("car_park_num12", CarCont.car_park_num12);
				s3_4.real_lock[13].GetComponent<Button>().interactable = false;
			}
			if (CarCont.car_park_num16 == 1)
			{
				PlayerPrefs.SetInt("car_park_num16", CarCont.car_park_num16);
				s3_4.real_lock[14].GetComponent<Button>().interactable = false;
			}
		}
		if (scene_controll.scene_3_5.activeSelf)
		{
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 1")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 42")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[1] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[1]", s3_5.cont_m_clothse[1]);
					Clothes.Clothes_N = 1;
					s3_5.already_buy_lock_m[0].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.001f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[1] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[1]", s3_5.cont_w_clothse[1]);
					Clothes.Clothes_N = 1;
					s3_5.already_buy_lock_w[0].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W + 0.001f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 2")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 43")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[2] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[2]", s3_5.cont_m_clothse[2]);
					Clothes.Clothes_N = 2;
					s3_5.already_buy_lock_m[1].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.001f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[2] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[2]", s3_5.cont_w_clothse[2]);
					Clothes.Clothes_N = 2;
					s3_5.already_buy_lock_w[1].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W + 0.001f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 3")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 44")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[3] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[3]", s3_5.cont_m_clothse[3]);
					Clothes.Clothes_N = 3;
					s3_5.already_buy_lock_m[2].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.001f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[3] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[3]", s3_5.cont_w_clothse[3]);
					Clothes.Clothes_N = 3;
					s3_5.already_buy_lock_w[2].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.001f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 4")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 45")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[4] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[4]", s3_5.cont_m_clothse[4]);
					Clothes.Clothes_N = 4;
					s3_5.already_buy_lock_m[3].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.002f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[4] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[4]", s3_5.cont_w_clothse[4]);
					Clothes.Clothes_N = 4;
					s3_5.already_buy_lock_w[3].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.002f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 5")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 46")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[5] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[5]", s3_5.cont_m_clothse[5]);
					Clothes.Clothes_N = 5;
					s3_5.already_buy_lock_m[4].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.002f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[5] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[5]", s3_5.cont_w_clothse[5]);
					Clothes.Clothes_N = 5;
					s3_5.already_buy_lock_w[4].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.002f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 6")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 47")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[6] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[6]", s3_5.cont_m_clothse[6]);
					Clothes.Clothes_N = 6;
					s3_5.already_buy_lock_m[5].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.002f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[6] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[6]", s3_5.cont_w_clothse[6]);
					Clothes.Clothes_N = 6;
					s3_5.already_buy_lock_w[5].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.002f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 7")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 48")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[7] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[7]", s3_5.cont_m_clothse[7]);
					Clothes.Clothes_N = 7;
					s3_5.already_buy_lock_m[6].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.003f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[7] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[7]", s3_5.cont_w_clothse[7]);
					Clothes.Clothes_N = 7;
					s3_5.already_buy_lock_w[6].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.003f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 8")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 49")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[8] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[8]", s3_5.cont_m_clothse[8]);
					Clothes.Clothes_N = 8;
					s3_5.already_buy_lock_m[7].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.003f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[8] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[8]", s3_5.cont_w_clothse[8]);
					Clothes.Clothes_N = 8;
					s3_5.already_buy_lock_w[7].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.003f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 9")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 50")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[9] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[9]", s3_5.cont_m_clothse[9]);
					Clothes.Clothes_N = 9;
					s3_5.already_buy_lock_m[8].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.003f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[9] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[9]", s3_5.cont_w_clothse[9]);
					Clothes.Clothes_N = 9;
					s3_5.already_buy_lock_w[8].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.003f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 10")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 51")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[10] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[10]", s3_5.cont_m_clothse[10]);
					Clothes.Clothes_N = 10;
					s3_5.already_buy_lock_m[9].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.004f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[10] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[10]", s3_5.cont_w_clothse[10]);
					Clothes.Clothes_N = 10;
					s3_5.already_buy_lock_w[9].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.004f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 11")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 52")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[11] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[11]", s3_5.cont_m_clothse[11]);
					Clothes.Clothes_N = 11;
					s3_5.already_buy_lock_m[10].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.004f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[11] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[11]", s3_5.cont_w_clothse[11]);
					Clothes.Clothes_N = 11;
					s3_5.already_buy_lock_w[10].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.004f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 12")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 53")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[12] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[12]", s3_5.cont_m_clothse[12]);
					Clothes.Clothes_N = 12;
					s3_5.already_buy_lock_m[11].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.004f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[12] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[12]", s3_5.cont_w_clothse[12]);
					Clothes.Clothes_N = 12;
					s3_5.already_buy_lock_w[11].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.004f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 13")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 54")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[13] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[13]", s3_5.cont_m_clothse[13]);
					Clothes.Clothes_N = 13;
					s3_5.already_buy_lock_m[12].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.005f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[13] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[13]", s3_5.cont_w_clothse[13]);
					Clothes.Clothes_N = 13;
					s3_5.already_buy_lock_w[12].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.005f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 14")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 55")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[14] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[14]", s3_5.cont_m_clothse[14]);
					Clothes.Clothes_N = 14;
					s3_5.already_buy_lock_m[13].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.005f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[14] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[14]", s3_5.cont_w_clothse[14]);
					Clothes.Clothes_N = 14;
					s3_5.already_buy_lock_w[13].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.005f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 15")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 56")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[15] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[15]", s3_5.cont_m_clothse[15]);
					Clothes.Clothes_N = 15;
					s3_5.already_buy_lock_m[14].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.005f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[15] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[15]", s3_5.cont_w_clothse[15]);
					Clothes.Clothes_N = 15;
					s3_5.already_buy_lock_w[14].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.005f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 16")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 57")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[16] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[16]", s3_5.cont_m_clothse[16]);
					Clothes.Clothes_N = 16;
					s3_5.already_buy_lock_m[15].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.006f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[16] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[16]", s3_5.cont_w_clothse[16]);
					Clothes.Clothes_N = 16;
					s3_5.already_buy_lock_w[15].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.006f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 17")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 58")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[17] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[17]", s3_5.cont_m_clothse[17]);
					Clothes.Clothes_N = 17;
					s3_5.already_buy_lock_m[16].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.006f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[17] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[17]", s3_5.cont_w_clothse[17]);
					Clothes.Clothes_N = 17;
					s3_5.already_buy_lock_w[16].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.006f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 18")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 59")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[18] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[18]", s3_5.cont_m_clothse[18]);
					Clothes.Clothes_N = 18;
					s3_5.already_buy_lock_m[17].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.006f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[18] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[18]", s3_5.cont_w_clothse[18]);
					Clothes.Clothes_N = 18;
					s3_5.already_buy_lock_w[17].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.006f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 19")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 60")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[19] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[19]", s3_5.cont_m_clothse[19]);
					Clothes.Clothes_N = 19;
					s3_5.already_buy_lock_m[18].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.007f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[19] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[19]", s3_5.cont_w_clothse[19]);
					Clothes.Clothes_N = 19;
					s3_5.already_buy_lock_w[18].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.007f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 20")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 61")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[20] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[20]", s3_5.cont_m_clothse[20]);
					Clothes.Clothes_N = 20;
					s3_5.already_buy_lock_m[19].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.007f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[20] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[20]", s3_5.cont_w_clothse[20]);
					Clothes.Clothes_N = 20;
					s3_5.already_buy_lock_w[19].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.007f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 21")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 62")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[21] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[21]", s3_5.cont_m_clothse[21]);
					Clothes.Clothes_N = 21;
					s3_5.already_buy_lock_m[20].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.007f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[21] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[21]", s3_5.cont_w_clothse[21]);
					Clothes.Clothes_N = 21;
					s3_5.already_buy_lock_w[20].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.007f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 22")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 63")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[22] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[22]", s3_5.cont_m_clothse[22]);
					Clothes.Clothes_N = 22;
					s3_5.already_buy_lock_m[21].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.008f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[22] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[22]", s3_5.cont_w_clothse[22]);
					Clothes.Clothes_N = 22;
					s3_5.already_buy_lock_w[21].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.008f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 23")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 64")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[23] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[23]", s3_5.cont_m_clothse[23]);
					Clothes.Clothes_N = 23;
					s3_5.already_buy_lock_m[22].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.008f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[23] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[23]", s3_5.cont_w_clothse[23]);
					Clothes.Clothes_N = 23;
					s3_5.already_buy_lock_w[22].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.008f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 24")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 65")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[24] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[24]", s3_5.cont_m_clothse[24]);
					Clothes.Clothes_N = 24;
					s3_5.already_buy_lock_m[23].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.008f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[24] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[24]", s3_5.cont_w_clothse[24]);
					Clothes.Clothes_N = 24;
					s3_5.already_buy_lock_w[23].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.008f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 25")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 66")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[25] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[25]", s3_5.cont_m_clothse[25]);
					Clothes.Clothes_N = 25;
					s3_5.already_buy_lock_m[24].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.009f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[25] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[25]", s3_5.cont_w_clothse[25]);
					Clothes.Clothes_N = 25;
					s3_5.already_buy_lock_w[24].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.009f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 26")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 67")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[26] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[26]", s3_5.cont_m_clothse[26]);
					Clothes.Clothes_N = 26;
					s3_5.already_buy_lock_m[25].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.009f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[26] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[26]", s3_5.cont_w_clothse[26]);
					Clothes.Clothes_N = 26;
					s3_5.already_buy_lock_w[25].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.009f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 27")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 68")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[27] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[27]", s3_5.cont_m_clothse[27]);
					Clothes.Clothes_N = 27;
					s3_5.already_buy_lock_m[26].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.009f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[27] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[27]", s3_5.cont_w_clothse[27]);
					Clothes.Clothes_N = 27;
					s3_5.already_buy_lock_w[26].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.009f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 28")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 69")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[28] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[28]", s3_5.cont_m_clothse[28]);
					Clothes.Clothes_N = 28;
					s3_5.already_buy_lock_m[27].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.01f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[28] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[28]", s3_5.cont_w_clothse[28]);
					Clothes.Clothes_N = 28;
					s3_5.already_buy_lock_w[27].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.01f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 29")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 70")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[29] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[29]", s3_5.cont_m_clothse[29]);
					Clothes.Clothes_N = 29;
					s3_5.already_buy_lock_m[28].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.01f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[29] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[29]", s3_5.cont_w_clothse[29]);
					Clothes.Clothes_N = 29;
					s3_5.already_buy_lock_w[28].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.01f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 30")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 71")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[30] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[30]", s3_5.cont_m_clothse[30]);
					Clothes.Clothes_N = 30;
					s3_5.already_buy_lock_m[29].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.01f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[30] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[30]", s3_5.cont_w_clothse[30]);
					Clothes.Clothes_N = 30;
					s3_5.already_buy_lock_w[29].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.01f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 31")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 72")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[31] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[31]", s3_5.cont_m_clothse[31]);
					Clothes.Clothes_N = 31;
					s3_5.already_buy_lock_m[30].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.011f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[31] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[31]", s3_5.cont_w_clothse[31]);
					Clothes.Clothes_N = 31;
					s3_5.already_buy_lock_w[30].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.011f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 32")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 73")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[32] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[32]", s3_5.cont_m_clothse[32]);
					Clothes.Clothes_N = 32;
					s3_5.already_buy_lock_m[31].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.011f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[32] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[32]", s3_5.cont_w_clothse[32]);
					Clothes.Clothes_N = 32;
					s3_5.already_buy_lock_w[31].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.011f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 33")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 74")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[33] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[33]", s3_5.cont_m_clothse[33]);
					Clothes.Clothes_N = 33;
					s3_5.already_buy_lock_m[32].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M + 0.011f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[33] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[33]", s3_5.cont_w_clothse[33]);
					Clothes.Clothes_N = 33;
					s3_5.already_buy_lock_w[32].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.011f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 34")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 75")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[34] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[34]", s3_5.cont_m_clothse[34]);
					Clothes.Clothes_N = 34;
					s3_5.already_buy_lock_m[33].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.012f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[34] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[34]", s3_5.cont_w_clothse[34]);
					Clothes.Clothes_N = 34;
					s3_5.already_buy_lock_w[33].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.012f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 35")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 76")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[35] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[35]", s3_5.cont_m_clothse[35]);
					Clothes.Clothes_N = 35;
					s3_5.already_buy_lock_m[34].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.012f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[35] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[35]", s3_5.cont_w_clothse[35]);
					Clothes.Clothes_N = 35;
					s3_5.already_buy_lock_w[34].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.012f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 36")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 77")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[36] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[36]", s3_5.cont_m_clothse[36]);
					Clothes.Clothes_N = 36;
					s3_5.already_buy_lock_m[35].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.012f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[36] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[36]", s3_5.cont_w_clothse[36]);
					Clothes.Clothes_N = 36;
					s3_5.already_buy_lock_w[35].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.012f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 37")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 78")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[37] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[37]", s3_5.cont_m_clothse[37]);
					Clothes.Clothes_N = 37;
					s3_5.already_buy_lock_m[36].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.013f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[37] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[37]", s3_5.cont_w_clothse[37]);
					Clothes.Clothes_N = 37;
					s3_5.already_buy_lock_w[36].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.013f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 38")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 79")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[38] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[38]", s3_5.cont_m_clothse[38]);
					Clothes.Clothes_N = 38;
					s3_5.already_buy_lock_m[37].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.013f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[38] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[38]", s3_5.cont_w_clothse[38]);
					Clothes.Clothes_N = 38;
					s3_5.already_buy_lock_w[37].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.013f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 39")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 80")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[39] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[39]", s3_5.cont_m_clothse[39]);
					Clothes.Clothes_N = 39;
					s3_5.already_buy_lock_m[38].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.013f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[39] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[39]", s3_5.cont_w_clothse[39]);
					Clothes.Clothes_N = 39;
					s3_5.already_buy_lock_w[38].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.013f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 40")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 81")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[40] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[40]", s3_5.cont_m_clothse[40]);
					Clothes.Clothes_N = 40;
					s3_5.already_buy_lock_m[39].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.014f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[40] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[40]", s3_5.cont_w_clothse[40]);
					Clothes.Clothes_N = 40;
					s3_5.already_buy_lock_w[39].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.014f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 41")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 82")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[41] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[41]", s3_5.cont_m_clothse[41]);
					Clothes.Clothes_N = 41;
					s3_5.already_buy_lock_m[40].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.014f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[41] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[41]", s3_5.cont_w_clothse[41]);
					Clothes.Clothes_N = 41;
					s3_5.already_buy_lock_w[40].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.014f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack1")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[42] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[42]", s3_5.cont_m_clothse[42]);
					Clothes.Clothes_N = 42;
					s3_5.already_buy_lock_m[41].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.014f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[42] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[42]", s3_5.cont_w_clothse[42]);
					Clothes.Clothes_N = 42;
					s3_5.already_buy_lock_w[41].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.014f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack2")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[43] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[43]", s3_5.cont_m_clothse[43]);
					Clothes.Clothes_N = 43;
					s3_5.already_buy_lock_m[42].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[43] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[43]", s3_5.cont_w_clothse[43]);
					Clothes.Clothes_N = 43;
					s3_5.already_buy_lock_w[42].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack3")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[44] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[44]", s3_5.cont_m_clothse[44]);
					Clothes.Clothes_N = 44;
					s3_5.already_buy_lock_m[43].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.016f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[44] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[44]", s3_5.cont_w_clothse[44]);
					Clothes.Clothes_N = 44;
					s3_5.already_buy_lock_w[43].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.016f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack4")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[45] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[45]", s3_5.cont_m_clothse[45]);
					Clothes.Clothes_N = 45;
					s3_5.already_buy_lock_m[44].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[45] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[45]", s3_5.cont_w_clothse[45]);
					Clothes.Clothes_N = 45;
					s3_5.already_buy_lock_w[44].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 94")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 93")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[46] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[46]", s3_5.cont_m_clothse[46]);
					Clothes.Clothes_N = 46;
					s3_5.already_buy_lock_m[45].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[46] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[46]", s3_5.cont_w_clothse[46]);
					Clothes.Clothes_N = 46;
					s3_5.already_buy_lock_w[45].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 95")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 97")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[47] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[47]", s3_5.cont_m_clothse[47]);
					Clothes.Clothes_N = 47;
					s3_5.already_buy_lock_m[46].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[47] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[47]", s3_5.cont_w_clothse[47]);
					Clothes.Clothes_N = 47;
					s3_5.already_buy_lock_w[46].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
				}
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 96")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 98")))
			{
				if (Char.Sex == 0)
				{
					s3_5.cont_m_clothse[48] = 1;
					PlayerPrefs.SetInt("cont_m_clothse[48]", s3_5.cont_m_clothse[48]);
					Clothes.Clothes_N = 48;
					s3_5.already_buy_lock_m[47].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.014f);
				}
				if (Char.Sex == 1)
				{
					s3_5.cont_w_clothse[48] = 1;
					PlayerPrefs.SetInt("cont_w_clothse[48]", s3_5.cont_w_clothse[48]);
					Clothes.Clothes_N = 48;
					s3_5.already_buy_lock_w[47].GetComponent<Button>().interactable = false;
					PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.014f);
				}
			}
		}
		if (scene_controll.scene_3_6.activeSelf)
		{
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 33")))
			{
				Head.Hair_N = 0;
				minushairpoint_W = 0.01f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 1")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 34")))
			{
				Head.Hair_N = 1;
				minushairpoint_W = 0.01f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 2")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 35")))
			{
				Head.Hair_N = 2;
				minushairpoint_W = 0.01f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 3")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 36")))
			{
				Head.Hair_N = 3;
				minushairpoint_W = 0.02f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 4")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 37")))
			{
				Head.Hair_N = 4;
				minushairpoint_W = 0.02f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 5")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 38")))
			{
				Head.Hair_N = 5;
				minushairpoint_W = 0.02f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 6")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 39")))
			{
				Head.Hair_N = 6;
				minushairpoint_W = 0.03f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 7")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 40")))
			{
				Head.Hair_N = 7;
				minushairpoint_W = 0.03f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 8")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 41")))
			{
				Head.Hair_N = 8;
				minushairpoint_W = 0.03f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 9")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 42")))
			{
				Head.Hair_N = 9;
				minushairpoint_W = 0.04f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 10")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 43")))
			{
				Head.Hair_N = 10;
				minushairpoint_W = 0.04f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 11")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 44")))
			{
				Head.Hair_N = 11;
				minushairpoint_W = 0.04f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 12")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 45")))
			{
				Head.Hair_N = 12;
				minushairpoint_W = 0.05f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 13")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 46")))
			{
				Head.Hair_N = 13;
				minushairpoint_W = 0.05f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 14")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 47")))
			{
				Head.Hair_N = 14;
				minushairpoint_W = 0.05f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 15")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 48")))
			{
				Head.Hair_N = 15;
				minushairpoint_W = 0.06f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 16")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 49")))
			{
				Head.Hair_N = 16;
				minushairpoint_W = 0.06f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 17")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 50")))
			{
				Head.Hair_N = 17;
				minushairpoint_W = 0.06f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 18")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 51")))
			{
				Head.Hair_N = 18;
				minushairpoint_W = 0.07f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 19")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 52")))
			{
				Head.Hair_N = 19;
				minushairpoint_W = 0.07f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 20")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 53")))
			{
				Head.Hair_N = 20;
				minushairpoint_W = 0.07f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 21")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 54")))
			{
				Head.Hair_N = 21;
				minushairpoint_W = 0.08f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 22")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 55")))
			{
				Head.Hair_N = 22;
				minushairpoint_W = 0.08f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 23")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 56")))
			{
				Head.Hair_N = 23;
				minushairpoint_W = 0.08f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 24")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 57")))
			{
				Head.Hair_N = 24;
				minushairpoint_W = 0.09f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 25")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 58")))
			{
				Head.Hair_N = 25;
				minushairpoint_W = 0.09f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 26")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 59")))
			{
				Head.Hair_N = 26;
				minushairpoint_W = 0.09f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 27")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 60")))
			{
				Head.Hair_N = 27;
				minushairpoint_W = 0.1f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 28")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 61")))
			{
				Head.Hair_N = 28;
				minushairpoint_W = 0.1f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 29")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 62")))
			{
				Head.Hair_N = 29;
				minushairpoint_W = 0.1f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 30")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 63")))
			{
				Head.Hair_N = 30;
				minushairpoint_W = 0.11f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 31")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 64")))
			{
				Head.Hair_N = 31;
				minushairpoint_W = 0.11f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 32")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 65")))
			{
				Head.Hair_N = 32;
				minushairpoint_W = 0.11f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 66")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 66")))
			{
				Head.Hair_N = 33;
				minushairpoint_W = 0.12f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 72")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 75")))
			{
				Head.Hair_N = 34;
				minushairpoint_W = 0.13f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[34].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[0] = 1;
					PlayerPrefs.SetInt("cash_hair_N[0]", s3_6.cash_hair_N[0]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[34].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[3] = 1;
					PlayerPrefs.SetInt("cash_hair_N[3]", s3_6.cash_hair_N[3]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 73")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 76")))
			{
				Head.Hair_N = 35;
				minushairpoint_W = 0.14f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[35].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[1] = 1;
					PlayerPrefs.SetInt("cash_hair_N[1]", s3_6.cash_hair_N[1]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[35].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[4] = 1;
					PlayerPrefs.SetInt("cash_hair_N[4]", s3_6.cash_hair_N[4]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 74")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 77")))
			{
				Head.Hair_N = 36;
				minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[36].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[2] = 1;
					PlayerPrefs.SetInt("cash_hair_N[2]", s3_6.cash_hair_N[2]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[36].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[5] = 1;
					PlayerPrefs.SetInt("cash_hair_N[5]", s3_6.cash_hair_N[5]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 78")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 79")))
			{
				Head.Hair_N = 37;
				minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[37].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[6] = 1;
					PlayerPrefs.SetInt("cash_hair_N[6]", s3_6.cash_hair_N[6]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[37].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[7] = 1;
					PlayerPrefs.SetInt("cash_hair_N[7]", s3_6.cash_hair_N[7]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 81")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 80")))
			{
				Head.Hair_N = 38;
				minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[38].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[8] = 1;
					PlayerPrefs.SetInt("cash_hair_N[8]", s3_6.cash_hair_N[8]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[38].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[9] = 1;
					PlayerPrefs.SetInt("cash_hair_N[9]", s3_6.cash_hair_N[9]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 82")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 83")))
			{
				Head.Hair_N = 39;
				minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[39].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[10] = 1;
					PlayerPrefs.SetInt("cash_hair_N[10]", s3_6.cash_hair_N[10]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[39].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[11] = 1;
					PlayerPrefs.SetInt("cash_hair_N[11]", s3_6.cash_hair_N[11]);
				}
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 84")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 85")))
			{
				Head.Hair_N = 40;
				minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", minushairpoint_W);
				if (Char.Sex == 0)
				{
					s3_6.lock_m[40].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[12] = 1;
					PlayerPrefs.SetInt("cash_hair_N[12]", s3_6.cash_hair_N[12]);
				}
				if (Char.Sex == 1)
				{
					s3_6.lock_w[40].GetComponent<Button>().interactable = false;
					s3_6.cash_hair_N[13] = 1;
					PlayerPrefs.SetInt("cash_hair_N[13]", s3_6.cash_hair_N[13]);
				}
			}
		}
		if (scene_controll.scene_3_7.activeSelf)
		{
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_cat"))
			{
				Pet_N[0] = 1;
				PlayerPrefs.SetInt("pet_0", Pet_N[0]);
				Pet_N[0] = PlayerPrefs.GetInt("pet_0");
				already_buy_lock[0].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 0;
				pet_stamp[19].SetActive(true);
				Debug.LogFormat("펫넘버{0}", Pet.Pet_N);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_dog"))
			{
				Pet_N[1] = 1;
				PlayerPrefs.SetInt("pet_1", Pet_N[1]);
				already_buy_lock[1].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 1;
				pet_stamp[0].SetActive(true);
				pet_stamp[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[0].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[0].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pig"))
			{
				Pet_N[2] = 1;
				PlayerPrefs.SetInt("pet_2", Pet_N[2]);
				already_buy_lock[2].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 2;
				pet_stamp[1].SetActive(true);
				pet_stamp[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[1].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[1].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_rabbit"))
			{
				Pet_N[3] = 1;
				PlayerPrefs.SetInt("pet_3", Pet_N[3]);
				already_buy_lock[3].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 3;
				pet_stamp[2].SetActive(true);
				pet_stamp[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[2].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[2].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_d_fox"))
			{
				Pet_N[4] = 1;
				PlayerPrefs.SetInt("pet_4", Pet_N[4]);
				already_buy_lock[4].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 4;
				pet_stamp[3].SetActive(true);
				pet_stamp[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[3].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[3].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_rocoon"))
			{
				Pet_N[5] = 1;
				PlayerPrefs.SetInt("pet_5", Pet_N[5]);
				already_buy_lock[5].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 5;
				pet_stamp[4].SetActive(true);
				pet_stamp[4].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[4].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[4].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_fox"))
			{
				Pet_N[6] = 1;
				PlayerPrefs.SetInt("pet_6", Pet_N[6]);
				already_buy_lock[6].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 6;
				pet_stamp[5].SetActive(true);
				pet_stamp[5].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[5].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[5].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_alphadog"))
			{
				Pet_N[7] = 1;
				PlayerPrefs.SetInt("pet_7", Pet_N[7]);
				already_buy_lock[7].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 7;
				pet_stamp[6].SetActive(true);
				pet_stamp[6].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[6].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[6].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pangguin"))
			{
				Pet_N[8] = 1;
				PlayerPrefs.SetInt("pet_8", Pet_N[8]);
				already_buy_lock[8].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 8;
				pet_stamp[7].SetActive(true);
				pet_stamp[7].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[7].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[7].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_chick"))
			{
				Pet_N[9] = 1;
				PlayerPrefs.SetInt("pet_9", Pet_N[9]);
				already_buy_lock[9].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 9;
				pet_stamp[8].SetActive(true);
				pet_stamp[8].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[8].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[8].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_alpaca"))
			{
				Pet_N[10] = 1;
				PlayerPrefs.SetInt("pet_10", Pet_N[10]);
				already_buy_lock[10].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 10;
				pet_stamp[9].SetActive(true);
				pet_stamp[9].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[9].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[9].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_turtle"))
			{
				Pet_N[11] = 1;
				PlayerPrefs.SetInt("pet_11", Pet_N[11]);
				already_buy_lock[11].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 11;
				pet_stamp[10].SetActive(true);
				pet_stamp[10].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[10].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[10].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_ele"))
			{
				Pet_N[12] = 1;
				PlayerPrefs.SetInt("pet_12", Pet_N[12]);
				already_buy_lock[12].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 12;
				pet_stamp[11].SetActive(true);
				pet_stamp[11].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[11].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[11].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_snake"))
			{
				Pet_N[13] = 1;
				PlayerPrefs.SetInt("pet_13", Pet_N[13]);
				already_buy_lock[13].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 13;
				pet_stamp[12].SetActive(true);
				pet_stamp[12].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[12].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[12].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_panda"))
			{
				Pet_N[14] = 1;
				PlayerPrefs.SetInt("pet_14", Pet_N[14]);
				already_buy_lock[14].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 14;
				pet_stamp[13].SetActive(true);
				pet_stamp[13].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[13].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[13].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_parret"))
			{
				Pet_N[15] = 1;
				PlayerPrefs.SetInt("pet_15", Pet_N[15]);
				already_buy_lock[15].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 15;
				pet_stamp[14].SetActive(true);
				pet_stamp[14].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[14].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[14].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_dragon"))
			{
				Pet_N[16] = 1;
				PlayerPrefs.SetInt("pet_16", Pet_N[16]);
				already_buy_lock[16].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 16;
				pet_stamp[15].SetActive(true);
				pet_stamp[15].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[15].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[15].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("tiger"))
			{
				Pet_N[17] = 1;
				PlayerPrefs.SetInt("pet_17", Pet_N[17]);
				already_buy_lock[17].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 17;
				pet_stamp[16].SetActive(true);
				pet_stamp[16].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[16].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[16].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("elepant"))
			{
				Pet_N[18] = 1;
				PlayerPrefs.SetInt("pet_18", Pet_N[18]);
				already_buy_lock[18].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 18;
				pet_stamp[17].SetActive(true);
				pet_stamp[17].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[17].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[17].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("kang"))
			{
				Pet_N[19] = 1;
				PlayerPrefs.SetInt("pet_19", Pet_N[19]);
				already_buy_lock[19].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 19;
				pet_stamp[18].SetActive(true);
				pet_stamp[18].GetComponent<Image>().sprite = Resources.Load<Sprite>("hold_2");
				pet_stamp_text[18].GetComponent<Text>().text = string.Format("Completion!");
				pet_stamp_text[18].GetComponent<Text>().color = new Color(255f, 0f, 0f);
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pega"))
			{
				Pet_N[21] = 1;
				PlayerPrefs.SetInt("pet_21", Pet_N[21]);
				pet_stamp[20].SetActive(true);
				already_buy_lock[20].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 21;
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Pet_babychick"))
			{
				Pet_N[22] = 1;
				PlayerPrefs.SetInt("pet_22", Pet_N[22]);
				pet_stamp[21].SetActive(true);
				already_buy_lock[21].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 22;
			}
			if (pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_pet 2"))
			{
				Pet_N[25] = 1;
				PlayerPrefs.SetInt("pet_25", Pet_N[25]);
				pet_stamp[22].SetActive(true);
				already_buy_lock[22].GetComponent<Button>().interactable = false;
				Pet.Pet_N = 25;
			}
		}
		SaveShopping();
		price = 0;
		minushairpoint_W = PlayerPrefs.GetFloat("minushairpoint_W", minushairpoint_W);
		FeeCont.SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
		FeeCont.SaleMonthLife_M = PlayerPrefs.GetFloat("SaleMonthLife_M");
	}

	public void SaveShopping()
	{
		money_window.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.money);
		Change();
		if (scene_controll.money < FeeCont.MonthHouse)
		{
			scene_controll.MoneyWindow.GetComponent<Image>().color = Color.red;
		}
		else
		{
			scene_controll.MoneyWindow.GetComponent<Image>().color = Color.white;
		}
		if (scene_controll.scene_3_2.activeSelf)
		{
			for (int i = 0; i < s3_3.bed_num.Length; i++)
			{
				s3_3.bed_num[i] = 0;
			}
			for (int j = 0; j < s3_3.living_num.Length; j++)
			{
				s3_3.living_num[j] = 0;
			}
			for (int k = 0; k < s3_3.toilet_num.Length; k++)
			{
				s3_3.toilet_num[k] = 0;
			}
			PlayerPrefs.SetInt("bed_num[0]", s3_3.bed_num[0]);
			PlayerPrefs.SetInt("bed_num[1]", s3_3.bed_num[1]);
			PlayerPrefs.SetInt("bed_num[2]", s3_3.bed_num[2]);
			PlayerPrefs.SetInt("living_num[0]", s3_3.living_num[0]);
			PlayerPrefs.SetInt("living_num[1]", s3_3.living_num[1]);
			PlayerPrefs.SetInt("living_num[2]", s3_3.living_num[2]);
			PlayerPrefs.SetInt("toilet_num[0]", s3_3.toilet_num[0]);
			PlayerPrefs.SetInt("toilet_num[1]", s3_3.toilet_num[1]);
			PlayerPrefs.SetInt("toilet_num[2]", s3_3.toilet_num[2]);
		}
		if (scene_controll.scene_3_3.activeSelf)
		{
			PlayerPrefs.SetInt("Toilet_N", FurnCont.Toilet_N);
			PlayerPrefs.SetInt("Kitchen_N", FurnCont.Kitchen_N);
			PlayerPrefs.SetInt("Bed_N", FurnCont.Bed_N);
		}
		if (scene_controll.scene_3_5.activeSelf | scene_controll.scene_3_6.activeSelf)
		{
			PlayerPrefs.SetInt("Hair_N", Head.Hair_N);
			PlayerPrefs.SetInt("Clothes_N", Clothes.Clothes_N);
		}
		if (scene_controll.scene_3_7.activeSelf)
		{
			PlayerPrefs.SetInt("Pet_N", Pet.Pet_N);
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			if (Tuto_1.Tutorial_Scene == 11 && Lv1_bed == 1 && Lv1_living == 1 && Lv1_toilet == 1)
			{
				GameObject.Find("btn_back_3_3").GetComponent<Button>().interactable = true;
				GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
			}
			if (Tuto_1.Tutorial_Scene == 19 && Pet_N[0] == 1)
			{
				GameObject.Find("btn_back_3_7").GetComponent<Button>().interactable = true;
				GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
			}
		}
	}

	public void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
		if (scene_controll.scene_3_2.activeSelf)
		{
		}
		if (scene_controll.scene_3_6.activeSelf)
		{
			scene_controll.head_load.SetActive(false);
			scene_controll.clothse_load.SetActive(false);
		}
		if (scene_controll.scene_3_7.activeSelf)
		{
			scene_controll.pet_load.SetActive(false);
		}
		if (scene_controll.scene_3_5.activeSelf)
		{
			scene_controll.clothse_load.SetActive(false);
			scene_controll.head_load.SetActive(false);
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
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
		}
		if (scene_controll.money >= 100000000 && scene_controll.money < 1000000000000L)
		{
			long num7 = scene_controll.money / 100000000;
			if (scene_controll.money - num7 * 100000000 <= 0)
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			}
		}
		if (scene_controll.money < 100000000)
		{
			money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		}
		scene_controll.gem_text.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
	}
}
