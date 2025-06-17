using UnityEngine;
using UnityEngine.UI;

public class PetPosition : MonoBehaviour
{
	public PetMoneyUp _PetMoneyUp;

	public static bool PetTimer;

	public static float bonuspercent;

	public RuntimeAnimatorController[] AnimController;

	private GameObject Textup_parent;

	private GameObject Audiocont_;

	private int _event_pet;

	private int _quest_pet;

	private int monkeyandwolf;

	public static float Wolftime;

	public static int Pet_money_0;

	public static int Pet_money_1;

	public static int Pet_money_2;

	public static int Pet_money_3;

	public static int Pet_money_4;

	public static int Pet_money_5;

	public static int Pet_money_6;

	public static int Pet_money_7;

	public static int Pet_money_8;

	public static int Pet_money_9;

	public static int Pet_money_10;

	public static int Pet_money_11;

	public static int Pet_money_12;

	public static int Pet_money_13;

	public static int Pet_money_14;

	public static int Pet_money_15;

	public static int Pet_money_16;

	public static int Pet_money_17;

	public static int Pet_money_18;

	public static int Pet_money_19;

	public static int Pet_money_20;

	public static int Pet_money_21;

	public static int Pet_money_22;

	public static int Pet_money_23;

	public static int Pet_money_24;

	public static int Pet_money_25;

	public static int Pet_money_26;

	public AudioClip Pet_coin_sound;

	public float pet_plusmoney;

	public int pet_plusgem;

	private int petearnmoney;

	public TextUP _TextUP;

	public static float Pet_0_exp;

	public static float Pet_1_exp;

	public static float Pet_2_exp;

	public static float Pet_3_exp;

	public static float Pet_4_exp;

	public static float Pet_5_exp;

	public static float Pet_6_exp;

	public static float Pet_7_exp;

	public static float Pet_8_exp;

	public static float Pet_9_exp;

	public static float Pet_10_exp;

	public static float Pet_11_exp;

	public static float Pet_12_exp;

	public static float Pet_13_exp;

	public static float Pet_14_exp;

	public static float Pet_15_exp;

	public static float Pet_16_exp;

	public static float Pet_17_exp;

	public static float Pet_18_exp;

	public static float Pet_19_exp;

	public static float Pet_20_exp;

	public static float Pet_21_exp;

	public static float Pet_22_exp;

	public static float Pet_23_exp;

	public static float Pet_24_exp;

	public static float Pet_25_exp;

	public static float Pet_26_exp;

	public static float Pet_0_Max;

	public static float Pet_1_Max;

	public static float Pet_2_Max;

	public static float Pet_3_Max;

	public static float Pet_4_Max;

	public static float Pet_5_Max;

	public static float Pet_6_Max;

	public static float Pet_7_Max;

	public static float Pet_8_Max;

	public static float Pet_9_Max;

	public static float Pet_10_Max;

	public static float Pet_11_Max;

	public static float Pet_12_Max;

	public static float Pet_13_Max;

	public static float Pet_14_Max;

	public static float Pet_15_Max;

	public static float Pet_16_Max;

	public static float Pet_17_Max;

	public static float Pet_18_Max;

	public static float Pet_19_Max;

	public static float Pet_20_Max;

	public static float Pet_21_Max;

	public static float Pet_22_Max;

	public static float Pet_23_Max;

	public static float Pet_24_Max;

	public static float Pet_25_Max;

	public static float Pet_26_Max;

	public static int Pet_0_level;

	public static int Pet_1_level;

	public static int Pet_2_level;

	public static int Pet_3_level;

	public static int Pet_4_level;

	public static int Pet_5_level;

	public static int Pet_6_level;

	public static int Pet_7_level;

	public static int Pet_8_level;

	public static int Pet_9_level;

	public static int Pet_10_level;

	public static int Pet_11_level;

	public static int Pet_12_level;

	public static int Pet_13_level;

	public static int Pet_14_level;

	public static int Pet_15_level;

	public static int Pet_16_level;

	public static int Pet_17_level;

	public static int Pet_18_level;

	public static int Pet_19_level;

	public static int Pet_20_level;

	public static int Pet_21_level;

	public static int Pet_22_level;

	public static int Pet_23_level;

	public static int Pet_24_level;

	public static int Pet_25_level;

	public static int Pet_26_level;

	public GameObject T_PetLv;

	public GameObject T_Petname;

	public GameObject T_money;

	public GameObject moneyicon;

	public Sprite[] moneygem;

	public GameObject Image_Pet;

	public static int PetLv;

	public static float PetExp;

	public static float PetMaxexp;

	public GameObject petexpbar;

	public Sprite[] Sprite_pet;

	public string[] Text_petname;

	public GameObject Petemotion_obj;

	public static int Q_P_Friendly;

	public GameObject pet_lv_object;

	public GameObject Pet_parent;

	public void Start()
	{
		Textup_parent = GameObject.Find("TextUp");
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		Audiocont_ = GameObject.Find("ButtonAud");
		if (TutorialCont.Tutorial_Int == 0)
		{
			PlayerPrefs.SetInt("Pet_0_level", 1);
			PlayerPrefs.SetInt("Pet_1_level", 1);
			PlayerPrefs.SetInt("Pet_2_level", 1);
			PlayerPrefs.SetInt("Pet_3_level", 1);
			PlayerPrefs.SetInt("Pet_4_level", 1);
			PlayerPrefs.SetInt("Pet_5_level", 1);
			PlayerPrefs.SetInt("Pet_6_level", 1);
			PlayerPrefs.SetInt("Pet_7_level", 1);
			PlayerPrefs.SetInt("Pet_8_level", 1);
			PlayerPrefs.SetInt("Pet_9_level", 1);
			PlayerPrefs.SetInt("Pet_10_level", 1);
			PlayerPrefs.SetInt("Pet_11_level", 1);
			PlayerPrefs.SetInt("Pet_12_level", 1);
			PlayerPrefs.SetInt("Pet_13_level", 1);
			PlayerPrefs.SetInt("Pet_14_level", 1);
			PlayerPrefs.SetInt("Pet_15_level", 1);
			PlayerPrefs.SetInt("Pet_16_level", 1);
			PlayerPrefs.SetInt("Pet_17_level", 1);
			PlayerPrefs.SetInt("Pet_18_level", 1);
			PlayerPrefs.SetInt("Pet_19_level", 1);
			PlayerPrefs.SetInt("Pet_20_level", 1);
			PlayerPrefs.SetInt("Pet_21_level", 1);
			PlayerPrefs.SetInt("Pet_22_level", 1);
			PlayerPrefs.SetInt("Pet_23_level", 1);
			PlayerPrefs.SetInt("Pet_24_level", 1);
			PlayerPrefs.SetInt("Pet_25_level", 1);
			PlayerPrefs.SetInt("Pet_26_level", 1);
			PlayerPrefs.SetFloat("Pet_0_Max", 50f);
			PlayerPrefs.SetFloat("Pet_1_Max", 50f);
			PlayerPrefs.SetFloat("Pet_2_Max", 50f);
			PlayerPrefs.SetFloat("Pet_3_Max", 50f);
			PlayerPrefs.SetFloat("Pet_4_Max", 50f);
			PlayerPrefs.SetFloat("Pet_5_Max", 50f);
			PlayerPrefs.SetFloat("Pet_6_Max", 50f);
			PlayerPrefs.SetFloat("Pet_7_Max", 50f);
			PlayerPrefs.SetFloat("Pet_8_Max", 50f);
			PlayerPrefs.SetFloat("Pet_9_Max", 50f);
			PlayerPrefs.SetFloat("Pet_10_Max", 50f);
			PlayerPrefs.SetFloat("Pet_11_Max", 50f);
			PlayerPrefs.SetFloat("Pet_12_Max", 50f);
			PlayerPrefs.SetFloat("Pet_13_Max", 50f);
			PlayerPrefs.SetFloat("Pet_14_Max", 50f);
			PlayerPrefs.SetFloat("Pet_15_Max", 50f);
			PlayerPrefs.SetFloat("Pet_16_Max", 50f);
			PlayerPrefs.SetFloat("Pet_17_Max", 50f);
			PlayerPrefs.SetFloat("Pet_18_Max", 50f);
			PlayerPrefs.SetFloat("Pet_19_Max", 50f);
			PlayerPrefs.SetFloat("Pet_20_Max", 50f);
			PlayerPrefs.SetFloat("Pet_21_Max", 50f);
			PlayerPrefs.SetFloat("Pet_22_Max", 50f);
			PlayerPrefs.SetFloat("Pet_23_Max", 50f);
			PlayerPrefs.SetFloat("Pet_24_Max", 50f);
			PlayerPrefs.SetFloat("Pet_25_Max", 50f);
			PlayerPrefs.SetFloat("Pet_26_Max", 50f);
		}
		_event_pet = PlayerPrefs.GetInt("_event_pet");
		if (_event_pet == 0)
		{
			PlayerPrefs.SetInt("Pet_22_level", 1);
			PlayerPrefs.SetFloat("Pet_22_Max", 50f);
			PlayerPrefs.SetInt("_event_pet", 1);
		}
		_quest_pet = PlayerPrefs.GetInt("_quest_pet");
		if (_quest_pet == 0)
		{
			PlayerPrefs.SetInt("Pet_23_level", 1);
			PlayerPrefs.SetFloat("Pet_23_Max", 50f);
			PlayerPrefs.SetInt("Pet_24_level", 1);
			PlayerPrefs.SetFloat("Pet_24_Max", 50f);
			PlayerPrefs.SetInt("_quest_pet", 1);
			_quest_pet = PlayerPrefs.GetInt("_quest_pet");
		}
		monkeyandwolf = PlayerPrefs.GetInt("monkeyandwolf");
		if (monkeyandwolf == 0)
		{
			PlayerPrefs.SetInt("Pet_25_level", 1);
			PlayerPrefs.SetFloat("Pet_25_Max", 50f);
			PlayerPrefs.SetInt("Pet_26_level", 1);
			PlayerPrefs.SetFloat("Pet_26_Max", 50f);
			PlayerPrefs.SetInt("monkeyandwolf", 1);
			monkeyandwolf = PlayerPrefs.GetInt("monkeyandwolf");
		}
		Pet_0_level = PlayerPrefs.GetInt("Pet_0_level");
		Pet_0_exp = PlayerPrefs.GetFloat("Pet_0_exp");
		Pet_0_Max = PlayerPrefs.GetFloat("Pet_0_Max");
		Pet_1_level = PlayerPrefs.GetInt("Pet_1_level");
		Pet_1_exp = PlayerPrefs.GetFloat("Pet_1_exp");
		Pet_1_Max = PlayerPrefs.GetFloat("Pet_1_Max");
		Pet_2_level = PlayerPrefs.GetInt("Pet_2_level");
		Pet_2_exp = PlayerPrefs.GetFloat("Pet_2_exp");
		Pet_2_Max = PlayerPrefs.GetFloat("Pet_2_Max");
		Pet_3_level = PlayerPrefs.GetInt("Pet_3_level");
		Pet_3_exp = PlayerPrefs.GetFloat("Pet_3_exp");
		Pet_3_Max = PlayerPrefs.GetFloat("Pet_3_Max");
		Pet_4_level = PlayerPrefs.GetInt("Pet_4_level");
		Pet_4_exp = PlayerPrefs.GetFloat("Pet_4_exp");
		Pet_4_Max = PlayerPrefs.GetFloat("Pet_4_Max");
		Pet_5_level = PlayerPrefs.GetInt("Pet_5_level");
		Pet_5_exp = PlayerPrefs.GetFloat("Pet_5_exp");
		Pet_5_Max = PlayerPrefs.GetFloat("Pet_5_Max");
		Pet_6_level = PlayerPrefs.GetInt("Pet_6_level");
		Pet_6_exp = PlayerPrefs.GetFloat("Pet_6_exp");
		Pet_6_Max = PlayerPrefs.GetFloat("Pet_6_Max");
		Pet_7_level = PlayerPrefs.GetInt("Pet_7_level");
		Pet_7_exp = PlayerPrefs.GetFloat("Pet_7_exp");
		Pet_7_Max = PlayerPrefs.GetFloat("Pet_7_Max");
		Pet_8_level = PlayerPrefs.GetInt("Pet_8_level");
		Pet_8_exp = PlayerPrefs.GetFloat("Pet_8_exp");
		Pet_8_Max = PlayerPrefs.GetFloat("Pet_8_Max");
		Pet_9_level = PlayerPrefs.GetInt("Pet_9_level");
		Pet_9_exp = PlayerPrefs.GetFloat("Pet_9_exp");
		Pet_9_Max = PlayerPrefs.GetFloat("Pet_9_Max");
		Pet_10_level = PlayerPrefs.GetInt("Pet_10_level");
		Pet_10_exp = PlayerPrefs.GetFloat("Pet_10_exp");
		Pet_10_Max = PlayerPrefs.GetFloat("Pet_10_Max");
		Pet_11_level = PlayerPrefs.GetInt("Pet_11_level");
		Pet_11_exp = PlayerPrefs.GetFloat("Pet_11_exp");
		Pet_11_Max = PlayerPrefs.GetFloat("Pet_11_Max");
		Pet_12_level = PlayerPrefs.GetInt("Pet_12_level");
		Pet_12_exp = PlayerPrefs.GetFloat("Pet_12_exp");
		Pet_12_Max = PlayerPrefs.GetFloat("Pet_12_Max");
		Pet_13_level = PlayerPrefs.GetInt("Pet_13_level");
		Pet_13_exp = PlayerPrefs.GetFloat("Pet_13_exp");
		Pet_13_Max = PlayerPrefs.GetFloat("Pet_13_Max");
		Pet_14_level = PlayerPrefs.GetInt("Pet_14_level");
		Pet_14_exp = PlayerPrefs.GetFloat("Pet_14_exp");
		Pet_14_Max = PlayerPrefs.GetFloat("Pet_14_Max");
		Pet_15_level = PlayerPrefs.GetInt("Pet_15_level");
		Pet_15_exp = PlayerPrefs.GetFloat("Pet_15_exp");
		Pet_15_Max = PlayerPrefs.GetFloat("Pet_15_Max");
		Pet_16_level = PlayerPrefs.GetInt("Pet_16_level");
		Pet_16_exp = PlayerPrefs.GetFloat("Pet_16_exp");
		Pet_16_Max = PlayerPrefs.GetFloat("Pet_16_Max");
		Pet_17_level = PlayerPrefs.GetInt("Pet_17_level");
		Pet_17_exp = PlayerPrefs.GetFloat("Pet_17_exp");
		Pet_17_Max = PlayerPrefs.GetFloat("Pet_17_Max");
		Pet_18_level = PlayerPrefs.GetInt("Pet_18_level");
		Pet_18_exp = PlayerPrefs.GetFloat("Pet_18_exp");
		Pet_18_Max = PlayerPrefs.GetFloat("Pet_18_Max");
		Pet_19_level = PlayerPrefs.GetInt("Pet_19_level");
		Pet_19_exp = PlayerPrefs.GetFloat("Pet_19_exp");
		Pet_19_Max = PlayerPrefs.GetFloat("Pet_19_Max");
		Pet_20_level = PlayerPrefs.GetInt("Pet_20_level");
		Pet_20_exp = PlayerPrefs.GetFloat("Pet_20_exp");
		Pet_20_Max = PlayerPrefs.GetFloat("Pet_20_Max");
		Pet_21_level = PlayerPrefs.GetInt("Pet_21_level");
		Pet_21_exp = PlayerPrefs.GetFloat("Pet_21_exp");
		Pet_21_Max = PlayerPrefs.GetFloat("Pet_21_Max");
		Pet_22_level = PlayerPrefs.GetInt("Pet_22_level");
		Pet_22_exp = PlayerPrefs.GetFloat("Pet_22_exp");
		Pet_22_Max = PlayerPrefs.GetFloat("Pet_22_Max");
		Pet_23_level = PlayerPrefs.GetInt("Pet_23_level");
		Pet_23_exp = PlayerPrefs.GetFloat("Pet_23_exp");
		Pet_23_Max = PlayerPrefs.GetFloat("Pet_23_Max");
		Pet_24_level = PlayerPrefs.GetInt("Pet_24_level");
		Pet_24_exp = PlayerPrefs.GetFloat("Pet_24_exp");
		Pet_24_Max = PlayerPrefs.GetFloat("Pet_24_Max");
		Pet_25_level = PlayerPrefs.GetInt("Pet_25_level");
		Pet_25_exp = PlayerPrefs.GetFloat("Pet_25_exp");
		Pet_25_Max = PlayerPrefs.GetFloat("Pet_25_Max");
		Pet_26_level = PlayerPrefs.GetInt("Pet_26_level");
		Pet_26_exp = PlayerPrefs.GetFloat("Pet_26_exp");
		Pet_26_Max = PlayerPrefs.GetFloat("Pet_26_Max");
		Wolftime = 600 - 6 * (Pet_26_level - 1);
		Setmoney();
		SetPosition();
		Set1_4();
		if (s3_7.PetBuyOK == 1)
		{
			SetPetInfor();
			SetPetexpInfor();
			if (Pet.Pet_N == 26)
			{
				moneyicon.GetComponent<Image>().sprite = moneygem[1];
				Invoke("PetMoneyPlus", Wolftime);
			}
			else
			{
				moneyicon.GetComponent<Image>().sprite = moneygem[0];
				Invoke("PetMoneyPlus", 10f);
			}
		}
	}

	public void Delay()
	{
		PetMoneyPlus();
	}

	public void Setmoney()
	{
		if (Pet.Pet_N == 0)
		{
			pet_plusmoney = ((float)Pet_0_level - 1f) / 2f;
			petearnmoney = (int)(20f + 20f * pet_plusmoney + (20f + 20f * pet_plusmoney) * bonuspercent);
			Pet_money_0 = (int)(20f + 20f * pet_plusmoney + (20f + 20f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 1)
		{
			pet_plusmoney = ((float)Pet_1_level - 1f) / 2f;
			petearnmoney = (int)(30f + 30f * pet_plusmoney + (30f + 30f * pet_plusmoney) * bonuspercent);
			Pet_money_1 = (int)(30f + 30f * pet_plusmoney + (30f + 30f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 2)
		{
			pet_plusmoney = ((float)Pet_2_level - 1f) / 2f;
			petearnmoney = (int)(50f + 50f * pet_plusmoney + (50f + 50f * pet_plusmoney) * bonuspercent);
			Pet_money_2 = (int)(50f + 50f * pet_plusmoney + (50f + 50f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 3)
		{
			pet_plusmoney = ((float)Pet_3_level - 1f) / 2f;
			petearnmoney = (int)(70f + 70f * pet_plusmoney + (70f + 70f * pet_plusmoney) * bonuspercent);
			Pet_money_3 = (int)(70f + 70f * pet_plusmoney + (70f + 70f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 4)
		{
			pet_plusmoney = ((float)Pet_4_level - 1f) / 2f;
			petearnmoney = (int)(100f + 100f * pet_plusmoney + (100f + 100f * pet_plusmoney) * bonuspercent);
			Pet_money_4 = (int)(100f + 100f * pet_plusmoney + (100f + 100f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 5)
		{
			pet_plusmoney = ((float)Pet_5_level - 1f) / 2f;
			petearnmoney = (int)(150f + 150f * pet_plusmoney + (150f + 150f * pet_plusmoney) * bonuspercent);
			Pet_money_5 = (int)(150f + 150f * pet_plusmoney + (150f + 150f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 6)
		{
			pet_plusmoney = ((float)Pet_6_level - 1f) / 2f;
			petearnmoney = (int)(200f + 200f * pet_plusmoney + (200f + 200f * pet_plusmoney) * bonuspercent);
			Pet_money_6 = (int)(200f + 200f * pet_plusmoney + (200f + 200f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 7)
		{
			pet_plusmoney = ((float)Pet_7_level - 1f) / 2f;
			petearnmoney = (int)(300f + 300f * pet_plusmoney + (300f + 300f * pet_plusmoney) * bonuspercent);
			Pet_money_7 = (int)(300f + 300f * pet_plusmoney + (300f + 300f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 8)
		{
			pet_plusmoney = ((float)Pet_8_level - 1f) / 2f;
			petearnmoney = (int)(400f + 400f * pet_plusmoney + (400f + 400f * pet_plusmoney) * bonuspercent);
			Pet_money_8 = (int)(400f + 400f * pet_plusmoney + (400f + 400f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 9)
		{
			pet_plusmoney = ((float)Pet_9_level - 1f) / 2f;
			petearnmoney = (int)(700f + 700f * pet_plusmoney + (700f + 700f * pet_plusmoney) * bonuspercent);
			Pet_money_9 = (int)(700f + 700f * pet_plusmoney + (700f + 700f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 10)
		{
			pet_plusmoney = ((float)Pet_10_level - 1f) / 2f;
			petearnmoney = (int)(1000f + 1000f * pet_plusmoney + (1000f + 1000f * pet_plusmoney) * bonuspercent);
			Pet_money_10 = (int)(1000f + 1000f * pet_plusmoney + (1000f + 1000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 11)
		{
			pet_plusmoney = ((float)Pet_11_level - 1f) / 2f;
			petearnmoney = (int)(2000f + 2000f * pet_plusmoney + (2000f + 2000f * pet_plusmoney) * bonuspercent);
			Pet_money_11 = (int)(2000f + 2000f * pet_plusmoney + (2000f + 2000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 12)
		{
			pet_plusmoney = ((float)Pet_12_level - 1f) / 2f;
			petearnmoney = (int)(3500f + 3500f * pet_plusmoney + (3500f + 3500f * pet_plusmoney) * bonuspercent);
			Pet_money_12 = (int)(3500f + 3500f * pet_plusmoney + (3500f + 3500f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 13)
		{
			pet_plusmoney = ((float)Pet_13_level - 1f) / 2f;
			petearnmoney = (int)(4000f + 4000f * pet_plusmoney + (4000f + 4000f * pet_plusmoney) * bonuspercent);
			Pet_money_13 = (int)(4000f + 4000f * pet_plusmoney + (4000f + 4000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 14)
		{
			pet_plusmoney = ((float)Pet_14_level - 1f) / 2f;
			petearnmoney = (int)(8000f + 8000f * pet_plusmoney + (8000f + 8000f * pet_plusmoney) * bonuspercent);
			Pet_money_14 = (int)(8000f + 8000f * pet_plusmoney + (8000f + 8000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 15)
		{
			pet_plusmoney = ((float)Pet_15_level - 1f) / 2f;
			petearnmoney = (int)(30000f + 30000f * pet_plusmoney + (30000f + 30000f * pet_plusmoney) * bonuspercent);
			Pet_money_15 = (int)(30000f + 30000f * pet_plusmoney + (30000f + 30000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 16)
		{
			pet_plusmoney = ((float)Pet_16_level - 1f) / 2f;
			petearnmoney = (int)(100000f + 100000f * pet_plusmoney + (100000f + 100000f * pet_plusmoney) * bonuspercent);
			Pet_money_16 = (int)(100000f + 100000f * pet_plusmoney + (100000f + 100000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 17)
		{
			pet_plusmoney = ((float)Pet_17_level - 1f) / 2f;
			petearnmoney = (int)(130000f + 130000f * pet_plusmoney + (130000f + 130000f * pet_plusmoney) * bonuspercent);
			Pet_money_17 = (int)(130000f + 130000f * pet_plusmoney + (130000f + 130000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 18)
		{
			pet_plusmoney = ((float)Pet_18_level - 1f) / 2f;
			petearnmoney = (int)(160000f + 160000f * pet_plusmoney + (160000f + 160000f * pet_plusmoney) * bonuspercent);
			Pet_money_18 = (int)(160000f + 160000f * pet_plusmoney + (160000f + 160000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 19)
		{
			pet_plusmoney = ((float)Pet_19_level - 1f) / 2f;
			petearnmoney = (int)(200000f + 200000f * pet_plusmoney + (200000f + 200000f * pet_plusmoney) * bonuspercent);
			Pet_money_19 = (int)(200000f + 200000f * pet_plusmoney + (200000f + 200000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 20)
		{
			pet_plusmoney = ((float)Pet_20_level - 1f) / 2f;
			petearnmoney = (int)(1000f + 5000f * pet_plusmoney + (1000f + 5000f * pet_plusmoney) * bonuspercent);
			Pet_money_20 = (int)(1000f + 5000f * pet_plusmoney + (1000f + 5000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 21)
		{
			pet_plusmoney = ((float)Pet_21_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			Pet_money_21 = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 22)
		{
			pet_plusmoney = ((float)Pet_22_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			Pet_money_22 = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 23)
		{
			pet_plusmoney = ((float)Pet_23_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			Pet_money_23 = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 24)
		{
			pet_plusmoney = ((float)Pet_24_level - 1f) / 2f;
			petearnmoney = (int)(20000f + 20000f * pet_plusmoney + (20000f + 20000f * pet_plusmoney) * bonuspercent);
			Pet_money_24 = (int)(20000f + 20000f * pet_plusmoney + (20000f + 20000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 25)
		{
			pet_plusmoney = ((float)Pet_25_level - 1f) / 2f;
			petearnmoney = (int)(50000f + 50000f * pet_plusmoney + (50000f + 50000f * pet_plusmoney) * bonuspercent);
			Pet_money_25 = (int)(50000f + 50000f * pet_plusmoney + (50000f + 50000f * pet_plusmoney) * bonuspercent);
		}
		if (Pet.Pet_N == 26)
		{
			Wolftime = 600 - 6 * (Pet_26_level - 1);
			pet_plusgem = 1;
			petearnmoney = 1;
			Pet_money_26 = 1;
			T_money.GetComponent<Text>().text = string.Format("per{0}min{1}sec +{2:n0}", Mathf.Floor(Wolftime / 60f), Wolftime % 60f, petearnmoney);
		}
		else
		{
			T_money.GetComponent<Text>().text = string.Format("{0:n0}G", petearnmoney);
		}
	}

	public void Set1_4()
	{
		Pet_money_0 = (int)(20f + 20f * (((float)Pet_0_level - 1f) / 2f) + (20f + 20f * (((float)Pet_0_level - 1f) / 2f)) * bonuspercent);
		Pet_money_1 = (int)(30f + 30f * (((float)Pet_1_level - 1f) / 2f) + (30f + 30f * (((float)Pet_1_level - 1f) / 2f)) * bonuspercent);
		Pet_money_2 = (int)(50f + 50f * (((float)Pet_2_level - 1f) / 2f) + (50f + 50f * (((float)Pet_2_level - 1f) / 2f)) * bonuspercent);
		Pet_money_3 = (int)(70f + 70f * (((float)Pet_3_level - 1f) / 2f) + (70f + 70f * (((float)Pet_3_level - 1f) / 2f)) * bonuspercent);
		Pet_money_4 = (int)(100f + 100f * (((float)Pet_4_level - 1f) / 2f) + (100f + 100f * (((float)Pet_4_level - 1f) / 2f)) * bonuspercent);
		Pet_money_5 = (int)(150f + 150f * (((float)Pet_5_level - 1f) / 2f) + (150f + 150f * (((float)Pet_5_level - 1f) / 2f)) * bonuspercent);
		Pet_money_6 = (int)(200f + 200f * (((float)Pet_6_level - 1f) / 2f) + (200f + 200f * (((float)Pet_6_level - 1f) / 2f)) * bonuspercent);
		Pet_money_7 = (int)(300f + 300f * (((float)Pet_7_level - 1f) / 2f) + (300f + 300f * (((float)Pet_7_level - 1f) / 2f)) * bonuspercent);
		Pet_money_8 = (int)(400f + 400f * (((float)Pet_8_level - 1f) / 2f) + (400f + 400f * (((float)Pet_8_level - 1f) / 2f)) * bonuspercent);
		Pet_money_9 = (int)(700f + 700f * (((float)Pet_9_level - 1f) / 2f) + (700f + 700f * (((float)Pet_9_level - 1f) / 2f)) * bonuspercent);
		Pet_money_10 = (int)(1000f + 1000f * (((float)Pet_10_level - 1f) / 2f) + (1000f + 1000f * (((float)Pet_10_level - 1f) / 2f)) * bonuspercent);
		Pet_money_11 = (int)(2000f + 2000f * (((float)Pet_11_level - 1f) / 2f) + (2000f + 2000f * (((float)Pet_11_level - 1f) / 2f)) * bonuspercent);
		Pet_money_12 = (int)(3500f + 3500f * (((float)Pet_12_level - 1f) / 2f) + (3500f + 3500f * (((float)Pet_12_level - 1f) / 2f)) * bonuspercent);
		Pet_money_13 = (int)(4000f + 4000f * (((float)Pet_13_level - 1f) / 2f) + (4000f + 4000f * (((float)Pet_13_level - 1f) / 2f)) * bonuspercent);
		Pet_money_14 = (int)(8000f + 8000f * (((float)Pet_14_level - 1f) / 2f) + (8000f + 8000f * (((float)Pet_14_level - 1f) / 2f)) * bonuspercent);
		Pet_money_15 = (int)(30000f + 30000f * (((float)Pet_15_level - 1f) / 2f) + (30000f + 30000f * (((float)Pet_15_level - 1f) / 2f)) * bonuspercent);
		Pet_money_16 = (int)(100000f + 100000f * (((float)Pet_16_level - 1f) / 2f) + (100000f + 100000f * (((float)Pet_16_level - 1f) / 2f)) * bonuspercent);
		Pet_money_17 = (int)(130000f + 130000f * (((float)Pet_17_level - 1f) / 2f) + (130000f + 130000f * (((float)Pet_17_level - 1f) / 2f)) * bonuspercent);
		Pet_money_18 = (int)(160000f + 160000f * (((float)Pet_18_level - 1f) / 2f) + (160000f + 160000f * (((float)Pet_18_level - 1f) / 2f)) * bonuspercent);
		Pet_money_19 = (int)(200000f + 200000f * (((float)Pet_19_level - 1f) / 2f) + (200000f + 200000f * (((float)Pet_19_level - 1f) / 2f)) * bonuspercent);
		Pet_money_20 = (int)(1000f + 5000f * (((float)Pet_20_level - 1f) / 2f) + (1000f + 5000f * (((float)Pet_20_level - 1f) / 2f)) * bonuspercent);
		Pet_money_21 = (int)(15000f + 15000f * (((float)Pet_21_level - 1f) / 2f) + (15000f + 15000f * (((float)Pet_21_level - 1f) / 2f)) * bonuspercent);
		Pet_money_22 = (int)(15000f + 15000f * (((float)Pet_22_level - 1f) / 2f) + (15000f + 15000f * (((float)Pet_22_level - 1f) / 2f)) * bonuspercent);
		Pet_money_23 = (int)(15000f + 15000f * (((float)Pet_23_level - 1f) / 2f) + (15000f + 15000f * (((float)Pet_23_level - 1f) / 2f)) * bonuspercent);
		Pet_money_24 = (int)(20000f + 20000f * (((float)Pet_24_level - 1f) / 2f) + (20000f + 20000f * (((float)Pet_24_level - 1f) / 2f)) * bonuspercent);
		Pet_money_25 = (int)(20000f + 20000f * (((float)Pet_25_level - 1f) / 2f) + (20000f + 20000f * (((float)Pet_25_level - 1f) / 2f)) * bonuspercent);
		Pet_money_26 = 1;
	}

	public void PetMoneyPlus()
	{
		if (AudioCont.Mute_b == 1)
		{
			GetComponent<AudioSource>().mute = true;
			AudioListener.volume = 0f;
		}
		if (AudioCont.Mute_b == 2)
		{
			GetComponent<AudioSource>().mute = false;
			AudioListener.volume = 1f;
		}
		GetComponent<AudioSource>().clip = Pet_coin_sound;
		GetComponent<AudioSource>().Play();
		if (Pet.Pet_N == 0)
		{
			pet_plusmoney = ((float)Pet_0_level - 1f) / 2f;
			petearnmoney = (int)(20f + 20f * pet_plusmoney + (20f + 20f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 1)
		{
			pet_plusmoney = ((float)Pet_1_level - 1f) / 2f;
			petearnmoney = (int)(30f + 30f * pet_plusmoney + (30f + 30f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 2)
		{
			pet_plusmoney = ((float)Pet_2_level - 1f) / 2f;
			petearnmoney = (int)(50f + 50f * pet_plusmoney + (50f + 50f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 3)
		{
			pet_plusmoney = ((float)Pet_3_level - 1f) / 2f;
			petearnmoney = (int)(70f + 70f * pet_plusmoney + (70f + 70f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 4)
		{
			pet_plusmoney = ((float)Pet_4_level - 1f) / 2f;
			petearnmoney = (int)(100f + 100f * pet_plusmoney + (100f + 100f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 5)
		{
			pet_plusmoney = ((float)Pet_5_level - 1f) / 2f;
			petearnmoney = (int)(150f + 150f * pet_plusmoney + (150f + 150f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 6)
		{
			pet_plusmoney = ((float)Pet_6_level - 1f) / 2f;
			petearnmoney = (int)(200f + 200f * pet_plusmoney + (200f + 200f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 7)
		{
			pet_plusmoney = ((float)Pet_7_level - 1f) / 2f;
			petearnmoney = (int)(300f + 300f * pet_plusmoney + (300f + 300f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 8)
		{
			pet_plusmoney = ((float)Pet_8_level - 1f) / 2f;
			petearnmoney = (int)(400f + 400f * pet_plusmoney + (400f + 400f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 9)
		{
			pet_plusmoney = ((float)Pet_9_level - 1f) / 2f;
			petearnmoney = (int)(700f + 700f * pet_plusmoney + (700f + 700f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 10)
		{
			pet_plusmoney = ((float)Pet_10_level - 1f) / 2f;
			petearnmoney = (int)(1000f + 1000f * pet_plusmoney + (1000f + 1000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 11)
		{
			pet_plusmoney = ((float)Pet_11_level - 1f) / 2f;
			petearnmoney = (int)(2000f + 2000f * pet_plusmoney + (2000f + 2000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 12)
		{
			pet_plusmoney = ((float)Pet_12_level - 1f) / 2f;
			petearnmoney = (int)(3500f + 3500f * pet_plusmoney + (3500f + 3500f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 13)
		{
			pet_plusmoney = ((float)Pet_13_level - 1f) / 2f;
			petearnmoney = (int)(4000f + 4000f * pet_plusmoney + (4000f + 4000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 14)
		{
			pet_plusmoney = ((float)Pet_14_level - 1f) / 2f;
			petearnmoney = (int)(8000f + 8000f * pet_plusmoney + (8000f + 8000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 15)
		{
			pet_plusmoney = ((float)Pet_15_level - 1f) / 2f;
			petearnmoney = (int)(30000f + 30000f * pet_plusmoney + (30000f + 30000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 16)
		{
			pet_plusmoney = ((float)Pet_16_level - 1f) / 2f;
			petearnmoney = (int)(100000f + 100000f * pet_plusmoney + (100000f + 100000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 17)
		{
			pet_plusmoney = ((float)Pet_17_level - 1f) / 2f;
			petearnmoney = (int)(130000f + 130000f * pet_plusmoney + (130000f + 130000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 18)
		{
			pet_plusmoney = ((float)Pet_18_level - 1f) / 2f;
			petearnmoney = (int)(160000f + 160000f * pet_plusmoney + (160000f + 160000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 19)
		{
			pet_plusmoney = ((float)Pet_19_level - 1f) / 2f;
			petearnmoney = (int)(200000f + 200000f * pet_plusmoney + (200000f + 200000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 20)
		{
			pet_plusmoney = ((float)Pet_20_level - 1f) / 2f;
			petearnmoney = (int)(1000f + 5000f * pet_plusmoney + (1000f + 5000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 21)
		{
			pet_plusmoney = ((float)Pet_21_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 22)
		{
			pet_plusmoney = ((float)Pet_22_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 23)
		{
			pet_plusmoney = ((float)Pet_23_level - 1f) / 2f;
			petearnmoney = (int)(15000f + 15000f * pet_plusmoney + (15000f + 15000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 24)
		{
			pet_plusmoney = ((float)Pet_24_level - 1f) / 2f;
			petearnmoney = (int)(20000f + 20000f * pet_plusmoney + (20000f + 20000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 25)
		{
			pet_plusmoney = ((float)Pet_25_level - 1f) / 2f;
			petearnmoney = (int)(50000f + 50000f * pet_plusmoney + (50000f + 50000f * pet_plusmoney) * bonuspercent);
			scene_controll.money += petearnmoney;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetMONEY();
			Invoke("Delay", 10f);
		}
		if (Pet.Pet_N == 26)
		{
			Wolftime = 600 - 6 * (Pet_26_level - 1);
			pet_plusmoney = 1f;
			petearnmoney = 1;
			scene_controll.gem++;
			EventCont.Plus_PetMoney = petearnmoney;
			_PetMoneyUp.PlusPetGEM();
			Invoke("Delay", Wolftime);
			bonuspercent = PlayerPrefs.GetFloat("bonuspercent");
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			T_money.GetComponent<Text>().text = string.Format("per{0}min{1}sec +{2:n0}", Mathf.Floor(Wolftime / 60f), Wolftime % 60f, petearnmoney);
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
		else
		{
			bonuspercent = PlayerPrefs.GetFloat("bonuspercent");
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			T_money.GetComponent<Text>().text = string.Format("{0:n0}G", petearnmoney);
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		}
	}

	public void SetPosition()
	{
		if (RoomCont.Room_N == 0)
		{
			base.transform.localPosition = new Vector3(-15f, -205f, 0f);
		}
		if (RoomCont.Room_N == 1)
		{
			base.transform.localPosition = new Vector3(-196f, -118f, 0f);
		}
		if (RoomCont.Room_N == 2)
		{
			base.transform.localPosition = new Vector3(-336f, 101f, 0f);
		}
		if (RoomCont.Room_N == 3)
		{
			base.transform.localPosition = new Vector3(-67.5f, -26.7f, 0f);
		}
		if (RoomCont.Room_N == 4)
		{
			base.transform.localPosition = new Vector3(-72.3f, -55.6f, 0f);
		}
		if (RoomCont.Room_N == 5)
		{
			base.transform.localPosition = new Vector3(-72.3f, -55.6f, 0f);
		}
		if (RoomCont.Room_N == 6)
		{
			base.transform.localPosition = new Vector3(-202f, -196f, 0f);
		}
		if (RoomCont.Room_N == 7)
		{
			base.transform.localPosition = new Vector3(-174f, -187f, 0f);
		}
		if (RoomCont.Room_N == 8)
		{
			base.transform.localPosition = new Vector3(-174f, -187f, 0f);
		}
		if (RoomCont.Room_N == 9)
		{
			base.transform.localPosition = new Vector3(-309f, 240f, 0f);
		}
		if (RoomCont.Room_N == 10)
		{
			base.transform.localPosition = new Vector3(-462f, 81f, 0f);
		}
		if (RoomCont.Room_N == 11)
		{
			base.transform.localPosition = new Vector3(-191f, -8f, 0f);
		}
		if (RoomCont.Room_N == 12)
		{
			base.transform.localPosition = new Vector3(-173f, -258f, 0f);
		}
		if (RoomCont.Room_N == 13)
		{
			base.transform.localPosition = new Vector3(-242f, 58f, 0f);
		}
		if (RoomCont.Room_N == 14)
		{
			base.transform.localPosition = new Vector3(115f, 130f, 0f);
		}
		if (RoomCont.Room_N == 15)
		{
			base.transform.localPosition = new Vector3(-146f, 68f, 0f);
		}
		if (RoomCont.Room_N == 16)
		{
			base.transform.localPosition = new Vector3(-84f, -146f, 0f);
		}
		if (RoomCont.Room_N == 17)
		{
			base.transform.localPosition = new Vector3(-43f, -83f, 0f);
		}
	}

	public void PetPointUp()
	{
		if (Pet.Pet_N == 0)
		{
			Pet_0_exp += 1f;
			if (Pet_0_exp >= Pet_0_Max)
			{
				Pet_0_level++;
				Pet_0_exp = 0f;
				Pet_0_Max += Pet_0_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_0_Max", Pet_0_Max);
				PlayerPrefs.SetInt("Pet_0_level", Pet_0_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_0_exp", Pet_0_exp);
		}
		if (Pet.Pet_N == 1)
		{
			Pet_1_exp += 1f;
			if (Pet_1_exp >= Pet_1_Max)
			{
				Pet_1_level++;
				Pet_1_exp = 0f;
				Pet_1_Max += Pet_1_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_1_Max", Pet_1_Max);
				PlayerPrefs.SetInt("Pet_1_level", Pet_1_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_1_exp", Pet_1_exp);
		}
		if (Pet.Pet_N == 2)
		{
			Pet_2_exp += 1f;
			if (Pet_2_exp >= Pet_2_Max)
			{
				Pet_2_level++;
				Pet_2_exp = 0f;
				Pet_2_Max += Pet_2_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_2_Max", Pet_2_Max);
				PlayerPrefs.SetInt("Pet_2_level", Pet_2_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_2_exp", Pet_2_exp);
		}
		if (Pet.Pet_N == 3)
		{
			Pet_3_exp += 1f;
			if (Pet_3_exp >= Pet_3_Max)
			{
				Pet_3_level++;
				Pet_3_exp = 0f;
				Pet_3_Max += Pet_3_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_3_Max", Pet_3_Max);
				PlayerPrefs.SetInt("Pet_3_level", Pet_3_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_3_exp", Pet_3_exp);
		}
		if (Pet.Pet_N == 4)
		{
			Pet_4_exp += 1f;
			if (Pet_4_exp >= Pet_4_Max)
			{
				Pet_4_level++;
				Pet_4_exp = 0f;
				Pet_4_Max += Pet_4_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_4_Max", Pet_4_Max);
				PlayerPrefs.SetInt("Pet_4_level", Pet_4_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_4_exp", Pet_4_exp);
		}
		if (Pet.Pet_N == 5)
		{
			Pet_5_exp += 1f;
			if (Pet_5_exp >= Pet_5_Max)
			{
				Pet_5_level++;
				Pet_5_exp = 0f;
				Pet_5_Max += Pet_5_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_5_Max", Pet_5_Max);
				PlayerPrefs.SetInt("Pet_5_level", Pet_5_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_5_exp", Pet_5_exp);
		}
		if (Pet.Pet_N == 6)
		{
			Pet_6_exp += 1f;
			if (Pet_6_exp >= Pet_6_Max)
			{
				Pet_6_level++;
				Pet_6_exp = 0f;
				Pet_6_Max += Pet_6_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_6_Max", Pet_6_Max);
				PlayerPrefs.SetInt("Pet_6_level", Pet_6_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_6_exp", Pet_6_exp);
		}
		if (Pet.Pet_N == 7)
		{
			Pet_7_exp += 1f;
			if (Pet_7_exp >= Pet_7_Max)
			{
				Pet_7_level++;
				Pet_7_exp = 0f;
				Pet_7_Max += Pet_7_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_7_Max", Pet_7_Max);
				PlayerPrefs.SetInt("Pet_7_level", Pet_7_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_7_exp", Pet_7_exp);
		}
		if (Pet.Pet_N == 8)
		{
			Pet_8_exp += 1f;
			if (Pet_8_exp >= Pet_8_Max)
			{
				Pet_8_level++;
				Pet_8_exp = 0f;
				Pet_8_Max += Pet_8_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_8_Max", Pet_8_Max);
				PlayerPrefs.SetInt("Pet_8_level", Pet_8_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_8_exp", Pet_8_exp);
		}
		if (Pet.Pet_N == 9)
		{
			Pet_9_exp += 1f;
			if (Pet_9_exp >= Pet_9_Max)
			{
				Pet_9_level++;
				Pet_9_exp = 0f;
				Pet_9_Max += Pet_9_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_9_Max", Pet_9_Max);
				PlayerPrefs.SetInt("Pet_9_level", Pet_9_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_9_exp", Pet_9_exp);
		}
		if (Pet.Pet_N == 10)
		{
			Pet_10_exp += 1f;
			if (Pet_10_exp >= Pet_10_Max)
			{
				Pet_10_level++;
				Pet_10_exp = 0f;
				Pet_10_Max += Pet_10_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_10_Max", Pet_10_Max);
				PlayerPrefs.SetInt("Pet_10_level", Pet_10_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_10_exp", Pet_10_exp);
		}
		if (Pet.Pet_N == 11)
		{
			Pet_11_exp += 1f;
			if (Pet_11_exp >= Pet_11_Max)
			{
				Pet_11_level++;
				Pet_11_exp = 0f;
				Pet_11_Max += Pet_11_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_11_Max", Pet_11_Max);
				PlayerPrefs.SetInt("Pet_11_level", Pet_11_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_11_exp", Pet_11_exp);
		}
		if (Pet.Pet_N == 12)
		{
			Pet_12_exp += 1f;
			if (Pet_12_exp >= Pet_12_Max)
			{
				Pet_12_level++;
				Pet_12_exp = 0f;
				Pet_12_Max += Pet_12_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_12_Max", Pet_12_Max);
				PlayerPrefs.SetInt("Pet_12_level", Pet_12_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_12_exp", Pet_12_exp);
		}
		if (Pet.Pet_N == 13)
		{
			Pet_13_exp += 1f;
			if (Pet_13_exp >= Pet_13_Max)
			{
				Pet_13_level++;
				Pet_13_exp = 0f;
				Pet_13_Max += Pet_13_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_13_Max", Pet_13_Max);
				PlayerPrefs.SetInt("Pet_13_level", Pet_13_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_13_exp", Pet_13_exp);
		}
		if (Pet.Pet_N == 14)
		{
			Pet_14_exp += 1f;
			if (Pet_14_exp >= Pet_14_Max)
			{
				Pet_14_level++;
				Pet_14_exp = 0f;
				Pet_14_Max += Pet_14_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_14_Max", Pet_14_Max);
				PlayerPrefs.SetInt("Pet_14_level", Pet_14_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_14_exp", Pet_14_exp);
		}
		if (Pet.Pet_N == 15)
		{
			Pet_15_exp += 1f;
			if (Pet_15_exp >= Pet_15_Max)
			{
				Pet_15_level++;
				Pet_15_exp = 0f;
				Pet_15_Max += Pet_15_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_15_Max", Pet_15_Max);
				PlayerPrefs.SetInt("Pet_15_level", Pet_15_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_15_exp", Pet_15_exp);
		}
		if (Pet.Pet_N == 16)
		{
			Pet_16_exp += 1f;
			if (Pet_16_exp >= Pet_16_Max)
			{
				Pet_16_level++;
				Pet_16_exp = 0f;
				Pet_16_Max += Pet_16_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_16_Max", Pet_16_Max);
				PlayerPrefs.SetInt("Pet_16_level", Pet_16_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_16_exp", Pet_16_exp);
		}
		if (Pet.Pet_N == 17)
		{
			Pet_17_exp += 1f;
			if (Pet_17_exp >= Pet_17_Max)
			{
				Pet_17_level++;
				Pet_17_exp = 0f;
				Pet_17_Max += Pet_17_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_17_Max", Pet_17_Max);
				PlayerPrefs.SetInt("Pet_17_level", Pet_17_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_17_exp", Pet_17_exp);
		}
		if (Pet.Pet_N == 18)
		{
			Pet_18_exp += 1f;
			if (Pet_18_exp >= Pet_18_Max)
			{
				Pet_18_level++;
				Pet_18_exp = 0f;
				Pet_18_Max += Pet_18_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_18_Max", Pet_18_Max);
				PlayerPrefs.SetInt("Pet_18_level", Pet_18_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_18_exp", Pet_18_exp);
		}
		if (Pet.Pet_N == 19)
		{
			Pet_19_exp += 1f;
			if (Pet_19_exp >= Pet_19_Max)
			{
				Pet_19_level++;
				Pet_19_exp = 0f;
				Pet_19_Max += Pet_19_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_19_Max", Pet_19_Max);
				PlayerPrefs.SetInt("Pet_19_level", Pet_19_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_19_exp", Pet_19_exp);
		}
		if (Pet.Pet_N == 20)
		{
			Pet_20_exp += 1f;
			if (Pet_20_exp >= Pet_20_Max)
			{
				Pet_20_level++;
				Pet_20_exp = 0f;
				Pet_20_Max += Pet_20_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_20_Max", Pet_20_Max);
				PlayerPrefs.SetInt("Pet_20_level", Pet_20_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_20_exp", Pet_20_exp);
		}
		if (Pet.Pet_N == 21)
		{
			Pet_21_exp += 1f;
			if (Pet_21_exp >= Pet_21_Max)
			{
				Pet_21_level++;
				Pet_21_exp = 0f;
				Pet_21_Max += Pet_21_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_21_Max", Pet_21_Max);
				PlayerPrefs.SetInt("Pet_21_level", Pet_21_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_21_exp", Pet_21_exp);
		}
		if (Pet.Pet_N == 22)
		{
			Pet_22_exp += 1f;
			if (Pet_22_exp >= Pet_22_Max)
			{
				Pet_22_level++;
				Pet_22_exp = 0f;
				Pet_22_Max += Pet_22_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_22_Max", Pet_22_Max);
				PlayerPrefs.SetInt("Pet_22_level", Pet_22_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_22_exp", Pet_22_exp);
		}
		if (Pet.Pet_N == 23)
		{
			Pet_23_exp += 1f;
			if (Pet_23_exp >= Pet_23_Max)
			{
				Pet_23_level++;
				Pet_23_exp = 0f;
				Pet_23_Max += Pet_23_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_23_Max", Pet_23_Max);
				PlayerPrefs.SetInt("Pet_23_level", Pet_23_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_23_exp", Pet_23_exp);
		}
		if (Pet.Pet_N == 24)
		{
			Pet_24_exp += 1f;
			if (Pet_24_exp >= Pet_24_Max)
			{
				Pet_24_level++;
				Pet_24_exp = 0f;
				Pet_24_Max += Pet_24_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_24_Max", Pet_24_Max);
				PlayerPrefs.SetInt("Pet_24_level", Pet_24_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_24_exp", Pet_24_exp);
		}
		if (Pet.Pet_N == 25)
		{
			Pet_25_exp += 1f;
			if (Pet_25_exp >= Pet_25_Max)
			{
				Pet_25_level++;
				Pet_25_exp = 0f;
				Pet_25_Max += Pet_25_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_25_Max", Pet_25_Max);
				PlayerPrefs.SetInt("Pet_25_level", Pet_25_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_25_exp", Pet_25_exp);
		}
		if (Pet.Pet_N == 26)
		{
			Pet_26_exp += 1f;
			if (Pet_26_exp >= Pet_26_Max && Pet_26_level < 50)
			{
				Pet_26_level++;
				Pet_26_exp = 0f;
				Pet_26_Max += Pet_26_Max * 0.5f;
				PlayerPrefs.SetFloat("Pet_26_Max", Pet_26_Max);
				PlayerPrefs.SetInt("Pet_26_level", Pet_26_level);
				SetPetInfor();
				PetLevelUp();
			}
			PlayerPrefs.SetFloat("Pet_26_exp", Pet_26_exp);
		}
		SetPetexpInfor();
		Q_P_Friendly++;
		PlayerPrefs.SetInt("Q_P_Friendly", Q_P_Friendly);
		GameObject gameObject = (GameObject)Resources.Load("FriendlyUp");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("FriendlyUp"));
		gameObject2.transform.SetParent(Textup_parent.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
		Audiocont_.GetComponent<SoundEffect_newone>().ButtonSound_1();
		SetPetemotion();
	}

	public void SetPetemotion()
	{
		if (GameObject.Find("Pet_emotion(Clone)") == null)
		{
			GameObject gameObject = Object.Instantiate(Petemotion_obj);
			gameObject.transform.SetParent(base.gameObject.transform);
			gameObject.transform.localPosition = new Vector3(4.3f, 70.4f, 0f);
			gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		}
		Object.Destroy(GameObject.Find("Pet_emotion(Clone)"), 5f);
	}

	public void Petemotion_FALSE()
	{
		Petemotion_obj.SetActive(false);
	}

	public void SetPetInfor()
	{
		if (Pet.Pet_N == 0)
		{
			PetLv = Pet_0_level;
		}
		if (Pet.Pet_N == 1)
		{
			PetLv = Pet_1_level;
		}
		if (Pet.Pet_N == 2)
		{
			PetLv = Pet_2_level;
		}
		if (Pet.Pet_N == 3)
		{
			PetLv = Pet_3_level;
		}
		if (Pet.Pet_N == 4)
		{
			PetLv = Pet_4_level;
		}
		if (Pet.Pet_N == 5)
		{
			PetLv = Pet_5_level;
		}
		if (Pet.Pet_N == 6)
		{
			PetLv = Pet_6_level;
		}
		if (Pet.Pet_N == 7)
		{
			PetLv = Pet_7_level;
		}
		if (Pet.Pet_N == 8)
		{
			PetLv = Pet_8_level;
		}
		if (Pet.Pet_N == 9)
		{
			PetLv = Pet_9_level;
		}
		if (Pet.Pet_N == 10)
		{
			PetLv = Pet_10_level;
		}
		if (Pet.Pet_N == 11)
		{
			PetLv = Pet_11_level;
		}
		if (Pet.Pet_N == 12)
		{
			PetLv = Pet_12_level;
		}
		if (Pet.Pet_N == 13)
		{
			PetLv = Pet_13_level;
		}
		if (Pet.Pet_N == 14)
		{
			PetLv = Pet_14_level;
		}
		if (Pet.Pet_N == 15)
		{
			PetLv = Pet_15_level;
		}
		if (Pet.Pet_N == 16)
		{
			PetLv = Pet_16_level;
		}
		if (Pet.Pet_N == 17)
		{
			PetLv = Pet_17_level;
		}
		if (Pet.Pet_N == 18)
		{
			PetLv = Pet_18_level;
		}
		if (Pet.Pet_N == 19)
		{
			PetLv = Pet_19_level;
		}
		if (Pet.Pet_N == 20)
		{
			PetLv = Pet_20_level;
		}
		if (Pet.Pet_N == 21)
		{
			PetLv = Pet_21_level;
		}
		if (Pet.Pet_N == 22)
		{
			PetLv = Pet_22_level;
		}
		if (Pet.Pet_N == 23)
		{
			PetLv = Pet_23_level;
		}
		if (Pet.Pet_N == 24)
		{
			PetLv = Pet_24_level;
		}
		if (Pet.Pet_N == 25)
		{
			PetLv = Pet_25_level;
		}
		if (Pet.Pet_N == 26)
		{
			PetLv = Pet_26_level;
		}
		Setmoney();
		if (s3_7.PetBuyOK == 0)
		{
			Image_Pet.GetComponent<Image>().sprite = Sprite_pet[0];
			T_Petname.GetComponent<Text>().text = string.Format("{0}", Text_petname[0]);
		}
		else
		{
			Image_Pet.GetComponent<Image>().sprite = Sprite_pet[Pet.Pet_N];
			T_Petname.GetComponent<Text>().text = string.Format("{0}", Text_petname[Pet.Pet_N]);
		}
		if (Pet.Pet_N == 26)
		{
			if (Pet_26_level >= 50)
			{
				T_PetLv.GetComponent<Text>().text = string.Format("MAX{0:n0}", PetLv);
			}
			else
			{
				T_PetLv.GetComponent<Text>().text = string.Format("{0:n0}", PetLv);
			}
		}
		else
		{
			T_PetLv.GetComponent<Text>().text = string.Format("{0:n0}", PetLv);
		}
	}

	public void SetPetexpInfor()
	{
		if (Pet.Pet_N == 0)
		{
			PetExp = Pet_0_exp;
			PetMaxexp = Pet_0_Max;
		}
		if (Pet.Pet_N == 1)
		{
			PetExp = Pet_1_exp;
			PetMaxexp = Pet_1_Max;
		}
		if (Pet.Pet_N == 2)
		{
			PetExp = Pet_2_exp;
			PetMaxexp = Pet_2_Max;
		}
		if (Pet.Pet_N == 3)
		{
			PetExp = Pet_3_exp;
			PetMaxexp = Pet_3_Max;
		}
		if (Pet.Pet_N == 4)
		{
			PetExp = Pet_4_exp;
			PetMaxexp = Pet_4_Max;
		}
		if (Pet.Pet_N == 5)
		{
			PetExp = Pet_5_exp;
			PetMaxexp = Pet_5_Max;
		}
		if (Pet.Pet_N == 6)
		{
			PetExp = Pet_6_exp;
			PetMaxexp = Pet_6_Max;
		}
		if (Pet.Pet_N == 7)
		{
			PetExp = Pet_7_exp;
			PetMaxexp = Pet_7_Max;
		}
		if (Pet.Pet_N == 8)
		{
			PetExp = Pet_8_exp;
			PetMaxexp = Pet_8_Max;
		}
		if (Pet.Pet_N == 9)
		{
			PetExp = Pet_9_exp;
			PetMaxexp = Pet_9_Max;
		}
		if (Pet.Pet_N == 10)
		{
			PetExp = Pet_10_exp;
			PetMaxexp = Pet_10_Max;
		}
		if (Pet.Pet_N == 11)
		{
			PetExp = Pet_11_exp;
			PetMaxexp = Pet_11_Max;
		}
		if (Pet.Pet_N == 12)
		{
			PetExp = Pet_12_exp;
			PetMaxexp = Pet_12_Max;
		}
		if (Pet.Pet_N == 13)
		{
			PetExp = Pet_13_exp;
			PetMaxexp = Pet_13_Max;
		}
		if (Pet.Pet_N == 14)
		{
			PetExp = Pet_14_exp;
			PetMaxexp = Pet_14_Max;
		}
		if (Pet.Pet_N == 15)
		{
			PetExp = Pet_15_exp;
			PetMaxexp = Pet_15_Max;
		}
		if (Pet.Pet_N == 16)
		{
			PetExp = Pet_16_exp;
			PetMaxexp = Pet_16_Max;
		}
		if (Pet.Pet_N == 17)
		{
			PetExp = Pet_17_exp;
			PetMaxexp = Pet_17_Max;
		}
		if (Pet.Pet_N == 18)
		{
			PetExp = Pet_18_exp;
			PetMaxexp = Pet_18_Max;
		}
		if (Pet.Pet_N == 19)
		{
			PetExp = Pet_19_exp;
			PetMaxexp = Pet_19_Max;
		}
		if (Pet.Pet_N == 20)
		{
			PetExp = Pet_20_exp;
			PetMaxexp = Pet_20_Max;
		}
		if (Pet.Pet_N == 21)
		{
			PetExp = Pet_21_exp;
			PetMaxexp = Pet_21_Max;
		}
		if (Pet.Pet_N == 22)
		{
			PetExp = Pet_22_exp;
			PetMaxexp = Pet_22_Max;
		}
		if (Pet.Pet_N == 23)
		{
			PetExp = Pet_23_exp;
			PetMaxexp = Pet_23_Max;
		}
		if (Pet.Pet_N == 24)
		{
			PetExp = Pet_24_exp;
			PetMaxexp = Pet_24_Max;
		}
		if (Pet.Pet_N == 25)
		{
			PetExp = Pet_25_exp;
			PetMaxexp = Pet_25_Max;
		}
		if (Pet.Pet_N == 26)
		{
			PetExp = Pet_26_exp;
			PetMaxexp = Pet_26_Max;
		}
		petexpbar.GetComponent<Image>().fillAmount = PetExp / PetMaxexp;
	}

	public void PetLevelUp()
	{
		GameObject gameObject = Object.Instantiate(pet_lv_object);
		gameObject.transform.SetParent(Pet_parent.transform);
		gameObject.transform.localPosition = pet_lv_object.transform.position;
		gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/DM-CGS-26_pet");
		GetComponent<AudioSource>().Play();
	}
}
