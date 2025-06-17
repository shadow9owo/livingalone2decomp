using UnityEngine;
using UnityEngine.UI;

public class CashCont : MonoBehaviour
{
	public GameObject Scr_Itemshop;

	public GameObject Scr_Gemshop;

	public GameObject Scr_Moneyshop;

	public GameObject btn_Itemshop;

	public GameObject btn_Gemshop;

	public GameObject btn_Moneyshop;

	public GameObject Notice_nogem;

	public GameObject money_window;

	public GameObject gem_text;

	public GameObject money_bar;

	public static string Scene_String;

	public GameObject home_btn_1;

	public GameObject home_btn_2;

	public GameObject home_btn_3;

	public int[] bed_num;

	public int[] living_num;

	public int[] toilet_num;

	private GameObject YesW;

	private GameObject YesM;

	private int item1;

	private int item2;

	private int limit_pac_1;

	private int limit_pac_2;

	private int limit_pac_3;

	private int limit_pac_4;

	private int home_pac_1;

	private int home_pac_2;

	private int home_pac_3;

	private int clothes_m_42;

	private int clothes_m_43;

	private int clothes_m_44;

	private int clothes_w_42;

	private int clothes_w_43;

	private int clothes_w_44;

	private int clothes_m_45;

	private int clothes_m_46;

	private int clothes_m_48;

	private int clothes_w_45;

	private int clothes_w_46;

	private int clothes_w_48;

	public static int select_clothes_sex;

	private GameObject notice;

	private GameObject notice_;

	private GameObject parent;

	public GameObject Alert_sex_cash_obj;

	public GameObject Yes_W;

	public GameObject Yes_M;

	public Sprite[] Item_Icon_Img;

	public Sprite[] Item_Icon_Img_M;

	public Sprite[] S_Item_Icon_Img_Price;

	public GameObject Item_Icon;

	public GameObject Item_Title;

	public GameObject Item_Info;

	public GameObject Item_Price;

	public GameObject Item_Icon_M;

	public GameObject Item_Price_M;

	public GameObject Item_Icon_price;

	public static int Item_N;

	public GameObject ConfirmWindow;

	private bool ChangeSexbool;

	public static int RandomBox_N;

	private void Start()
	{
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		s3_7.ClotheBuyOK = PlayerPrefs.GetInt("ClotheBuyOK");
		s3_7.CarBuyOK = PlayerPrefs.GetInt("CarBuyOK");
		s3_7.HairBuyOK = PlayerPrefs.GetInt("HairBuyOK");
		Ads_Admob.no_ad = SPrefs.GetInt("no_ad");
		bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
		TimeBuff.BUff_Purchase = PlayerPrefs.GetInt("BUff_Purchase");
		if (TimeBuff.BUff_Purchase == 1)
		{
			GameObject.Find("btn_1 (1)").GetComponent<Button>().interactable = false;
		}
		S2_4.Albapaybuff = PlayerPrefs.GetInt("Albapaybuff");
		if (S2_4.Albapaybuff == 1)
		{
			GameObject.Find("btn_1").GetComponent<Button>().interactable = false;
		}
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		if (Ads_Admob.no_ad == 1)
		{
			GameObject.Find("btn_1 (3)").GetComponent<Button>().interactable = false;
		}
		Char.Sex = PlayerPrefs.GetInt("Sex");
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
		Momeysetting();
		item1 = PlayerPrefs.GetInt("item1");
		if (item1 == 1)
		{
			GameObject.Find("btn_1").GetComponent<Button>().interactable = false;
		}
		item2 = PlayerPrefs.GetInt("item2");
		if (item2 == 1)
		{
			GameObject.Find("btn_1 (1)").GetComponent<Button>().interactable = false;
		}
		limit_pac_1 = PlayerPrefs.GetInt("limit_pac_1");
		limit_pac_2 = PlayerPrefs.GetInt("limit_pac_2");
		limit_pac_3 = PlayerPrefs.GetInt("limit_pac_3");
		limit_pac_4 = PlayerPrefs.GetInt("limit_pac_4");
		home_pac_1 = PlayerPrefs.GetInt("home_pac_1");
		home_pac_2 = PlayerPrefs.GetInt("home_pac_2");
		home_pac_3 = PlayerPrefs.GetInt("home_pac_3");
		if (RoomCont.Room_N < 3)
		{
			home_btn_1.GetComponent<RectTransform>().anchoredPosition = new Vector3(-346f, -1790.5f, 0f);
			home_btn_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(1f, -1790.5f, 0f);
			home_btn_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(346f, -1790.5f, 0f);
		}
		if (RoomCont.Room_N >= 3 && RoomCont.Room_N < 6)
		{
			home_btn_1.SetActive(false);
			home_btn_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(-172f, -1790.5f, 0f);
			home_btn_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(173f, -1790.5f, 0f);
		}
		if (RoomCont.Room_N >= 6 && RoomCont.Room_N < 10)
		{
			home_btn_1.SetActive(false);
			home_btn_2.SetActive(false);
			home_btn_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, -1790.5f, 0f);
		}
		if (RoomCont.Room_N >= 10)
		{
			home_btn_1.SetActive(false);
			home_btn_2.SetActive(false);
			home_btn_3.SetActive(false);
		}
		if (limit_pac_1 == 1)
		{
			GameObject.Find("limite_pac_1").GetComponent<Button>().interactable = false;
		}
		if (limit_pac_2 == 1)
		{
			GameObject.Find("limite_pac_2").GetComponent<Button>().interactable = false;
		}
		if (limit_pac_3 == 1)
		{
			GameObject.Find("limite_pac_3").GetComponent<Button>().interactable = false;
		}
		if (limit_pac_4 == 1)
		{
			GameObject.Find("limite_pac_4").GetComponent<Button>().interactable = false;
		}
		clothes_m_42 = PlayerPrefs.GetInt("cont_m_clothse[42]");
		clothes_m_43 = PlayerPrefs.GetInt("cont_m_clothse[43]");
		clothes_m_44 = PlayerPrefs.GetInt("cont_m_clothse[44]");
		clothes_w_42 = PlayerPrefs.GetInt("cont_w_clothse[42]");
		clothes_w_43 = PlayerPrefs.GetInt("cont_w_clothse[43]");
		clothes_w_44 = PlayerPrefs.GetInt("cont_w_clothse[44]");
		clothes_m_45 = PlayerPrefs.GetInt("cont_m_clothse[45]");
		clothes_m_46 = PlayerPrefs.GetInt("cont_m_clothse[46]");
		clothes_m_48 = PlayerPrefs.GetInt("cont_m_clothse[48]");
		clothes_w_45 = PlayerPrefs.GetInt("cont_w_clothse[45]");
		clothes_w_46 = PlayerPrefs.GetInt("cont_w_clothse[46]");
		clothes_w_48 = PlayerPrefs.GetInt("cont_w_clothse[48 ]");
	}

	public void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
		{
			if (Notice_nogem.activeInHierarchy)
			{
				Notice_nogem.SetActive(false);
				return;
			}
			if (ConfirmWindow.activeInHierarchy)
			{
				ConfirmWindow.SetActive(false);
				return;
			}
			if (Scene_String == "newone")
			{
				Application.LoadLevel("newone");
			}
			if (Scene_String == "ptj")
			{
				Application.LoadLevel("ptj");
			}
			if (Scene_String == "ending")
			{
				Application.LoadLevel("ending");
			}
			if (Scene_String == "1-4")
			{
				scene_controll_2.load_num = 6;
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-1")
			{
				scene_controll_2.load_num = 2;
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-2")
			{
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-3")
			{
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-4")
			{
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-5")
			{
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-6")
			{
				Application.LoadLevel("newone2");
			}
			if (Scene_String == "3-7")
			{
				Application.LoadLevel("newone2");
			}
		}
		if (scene_controll.money < FeeCont.MonthHouse)
		{
			money_bar.GetComponent<Image>().color = Color.red;
		}
		else
		{
			money_bar.GetComponent<Image>().color = Color.white;
		}
	}

	public void Momeysetting()
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
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.gem);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.gem);
			}
		}
		if (scene_controll.money >= 100000000 && scene_controll.money < 1000000000000L)
		{
			long num7 = scene_controll.money / 100000000;
			if (scene_controll.money - num7 * 100000000 <= 0)
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.gem);
			}
			else
			{
				money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.gem);
			}
		}
		if (scene_controll.money < 100000000)
		{
			money_window.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		}
		gem_text.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
		ChangeSexbool = false;
	}

	public void Backbtn()
	{
		if (Scene_String == "newone")
		{
			Application.LoadLevel("newone");
		}
		if (Scene_String == "ptj")
		{
			Application.LoadLevel("ptj");
		}
		if (Scene_String == "ending")
		{
			Application.LoadLevel("ending");
		}
		if (Scene_String == "1-4")
		{
			scene_controll_2.load_num = 6;
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-1")
		{
			scene_controll_2.load_num = 2;
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-2")
		{
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-3")
		{
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-4")
		{
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-5")
		{
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-6")
		{
			Application.LoadLevel("newone2");
		}
		if (Scene_String == "3-7")
		{
			Application.LoadLevel("newone2");
		}
		Debug.Log("Scene_String" + Scene_String);
	}

	public void Btn_Itmeshop()
	{
		Scr_Itemshop.SetActive(true);
		Scr_Gemshop.SetActive(false);
		Scr_Moneyshop.SetActive(false);
		btn_Itemshop.GetComponent<Image>().color = new Color(0.972549f, 0.14901961f, 0.14901961f);
		btn_Gemshop.GetComponent<Image>().color = Color.white;
		btn_Moneyshop.GetComponent<Image>().color = Color.white;
	}

	public void Btn_Gemshop()
	{
		Scr_Itemshop.SetActive(false);
		Scr_Gemshop.SetActive(true);
		Scr_Moneyshop.SetActive(false);
		btn_Itemshop.GetComponent<Image>().color = Color.white;
		btn_Gemshop.GetComponent<Image>().color = new Color(0.20784314f, 0.9137255f, 1f);
		btn_Moneyshop.GetComponent<Image>().color = Color.white;
	}

	public void Btn_Moneyshop()
	{
		Scr_Itemshop.SetActive(false);
		Scr_Gemshop.SetActive(false);
		Scr_Moneyshop.SetActive(true);
		btn_Itemshop.GetComponent<Image>().color = Color.white;
		btn_Gemshop.GetComponent<Image>().color = Color.white;
		btn_Moneyshop.GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
	}

	public void Cash_50()
	{
		scene_controll.gem += 50;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Cash_100()
	{
		scene_controll.gem += 100;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Cash_200()
	{
		scene_controll.gem += 200;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Cash_500()
	{
		scene_controll.gem += 500;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Cash_1150()
	{
		scene_controll.gem += 1150;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Cash_3600()
	{
		scene_controll.gem += 3600;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		Momeysetting();
	}

	public void Room_pack_1()
	{
		PlayerPrefs.SetInt("Room_N", 3);
		PlayerPrefs.SetInt("RoomBuyOK", 2);
		PlayerPrefs.SetInt("Lv1_bed", 1);
		PlayerPrefs.SetInt("Lv1_living", 1);
		PlayerPrefs.SetInt("Lv1_toilet", 1);
		PlayerPrefs.SetInt("Toilet_N", 5);
		PlayerPrefs.SetInt("Kitchen_N", 5);
		PlayerPrefs.SetInt("Bed_N", 5);
		bed_num[0] = 0;
		bed_num[1] = 0;
		bed_num[2] = 0;
		living_num[0] = 0;
		living_num[1] = 0;
		living_num[2] = 0;
		toilet_num[0] = 0;
		toilet_num[1] = 0;
		toilet_num[2] = 0;
		PlayerPrefs.SetInt("bed_num[0]", bed_num[0]);
		PlayerPrefs.SetInt("bed_num[1]", bed_num[1]);
		PlayerPrefs.SetInt("bed_num[2]", bed_num[2]);
		PlayerPrefs.SetInt("living_num[0]", living_num[0]);
		PlayerPrefs.SetInt("living_num[1]", living_num[1]);
		PlayerPrefs.SetInt("living_num[2]", living_num[2]);
		PlayerPrefs.SetInt("toilet_num[0]", toilet_num[0]);
		PlayerPrefs.SetInt("toilet_num[1]", toilet_num[1]);
		PlayerPrefs.SetInt("toilet_num[2]", toilet_num[2]);
		scene_controll.money += 25000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		home_btn_1.GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("home_pac_1", 1);
		Momeysetting();
	}

	public void Room_pack_2()
	{
		PlayerPrefs.SetInt("Room_N", 6);
		PlayerPrefs.SetInt("RoomBuyOK", 5);
		PlayerPrefs.SetInt("Lv1_bed", 1);
		PlayerPrefs.SetInt("Lv1_living", 1);
		PlayerPrefs.SetInt("Lv1_toilet", 1);
		PlayerPrefs.SetInt("Toilet_N", 14);
		PlayerPrefs.SetInt("Kitchen_N", 14);
		PlayerPrefs.SetInt("Bed_N", 14);
		bed_num[0] = 0;
		bed_num[1] = 0;
		bed_num[2] = 0;
		living_num[0] = 0;
		living_num[1] = 0;
		living_num[2] = 0;
		toilet_num[0] = 0;
		toilet_num[1] = 0;
		toilet_num[2] = 0;
		PlayerPrefs.SetInt("bed_num[0]", bed_num[0]);
		PlayerPrefs.SetInt("bed_num[1]", bed_num[1]);
		PlayerPrefs.SetInt("bed_num[2]", bed_num[2]);
		PlayerPrefs.SetInt("living_num[0]", living_num[0]);
		PlayerPrefs.SetInt("living_num[1]", living_num[1]);
		PlayerPrefs.SetInt("living_num[2]", living_num[2]);
		PlayerPrefs.SetInt("toilet_num[0]", toilet_num[0]);
		PlayerPrefs.SetInt("toilet_num[1]", toilet_num[1]);
		PlayerPrefs.SetInt("toilet_num[2]", toilet_num[2]);
		scene_controll.money += 60000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		home_btn_1.SetActive(false);
		home_btn_2.GetComponent<Button>().interactable = false;
		home_btn_2.GetComponent<RectTransform>().anchoredPosition = new Vector3(-172f, -1790.5f, 0f);
		home_btn_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(173f, -1790.5f, 0f);
		PlayerPrefs.SetInt("home_pac_2", 1);
		Momeysetting();
	}

	public void Room_pack_3()
	{
		PlayerPrefs.SetInt("Room_N", 10);
		PlayerPrefs.SetInt("RoomBuyOK", 9);
		PlayerPrefs.SetInt("Lv1_bed", 1);
		PlayerPrefs.SetInt("Lv1_living", 1);
		PlayerPrefs.SetInt("Lv1_toilet", 1);
		PlayerPrefs.SetInt("Toilet_N", 26);
		PlayerPrefs.SetInt("Kitchen_N", 26);
		PlayerPrefs.SetInt("Bed_N", 26);
		bed_num[0] = 0;
		bed_num[1] = 0;
		bed_num[2] = 0;
		living_num[0] = 0;
		living_num[1] = 0;
		living_num[2] = 0;
		toilet_num[0] = 0;
		toilet_num[1] = 0;
		toilet_num[2] = 0;
		PlayerPrefs.SetInt("bed_num[0]", bed_num[0]);
		PlayerPrefs.SetInt("bed_num[1]", bed_num[1]);
		PlayerPrefs.SetInt("bed_num[2]", bed_num[2]);
		PlayerPrefs.SetInt("living_num[0]", living_num[0]);
		PlayerPrefs.SetInt("living_num[1]", living_num[1]);
		PlayerPrefs.SetInt("living_num[2]", living_num[2]);
		PlayerPrefs.SetInt("toilet_num[0]", toilet_num[0]);
		PlayerPrefs.SetInt("toilet_num[1]", toilet_num[1]);
		PlayerPrefs.SetInt("toilet_num[2]", toilet_num[2]);
		scene_controll.money += 140000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		PlayerPrefs.SetInt("car_park_num15", 1);
		s3_7.CarBuyOK++;
		PlayerPrefs.SetInt("CarBuyOK", s3_7.CarBuyOK);
		PlayerPrefs.SetInt("home_pac_3", 1);
		home_btn_1.SetActive(false);
		home_btn_2.SetActive(false);
		home_btn_3.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, -1790.5f, 0f);
		home_btn_3.GetComponent<Button>().interactable = false;
		Momeysetting();
	}

	public void Limit_luxury_pack()
	{
		scene_controll.money += 1000000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.gem += 2000;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		PlayerPrefs.SetInt("car_park_num19", 1);
		s3_7.CarBuyOK++;
		PlayerPrefs.SetInt("CarBuyOK", s3_7.CarBuyOK);
		Momeysetting();
		GameObject.Find("limite_pac_4").GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("limit_pac_4", 1);
	}

	public void Limit_car_pack()
	{
		PlayerPrefs.SetInt("car_park_num14", 1);
		s3_7.CarBuyOK++;
		PlayerPrefs.SetInt("CarBuyOK", s3_7.CarBuyOK);
		scene_controll.money += 25000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		Momeysetting();
		GameObject.Find("limite_pac_3").GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("limit_pac_3", 1);
	}

	public void Select_Limit_clothes_m()
	{
		select_clothes_sex = 1;
		Alert_sex_cash_obj.SetActive(true);
		Yes_M.SetActive(true);
		Yes_W.SetActive(false);
	}

	public void Select_Limit_clothes_w()
	{
		select_clothes_sex = 2;
		Alert_sex_cash_obj.SetActive(true);
		Yes_W.SetActive(true);
		Yes_M.SetActive(false);
	}

	public void CloseSexAlert()
	{
		Alert_sex_cash_obj.SetActive(false);
	}

	public void Limit_clothes_w()
	{
		if (clothes_w_45 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
		}
		if (clothes_w_46 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.015f);
		}
		if (clothes_w_48 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_W", FeeCont.SaleMonthLife_W += 0.014f);
		}
		PlayerPrefs.SetInt("ClotheBuyOK", s3_7.ClotheBuyOK += 3);
		PlayerPrefs.SetInt("HairBuyOK", s3_7.HairBuyOK += 3);
		PlayerPrefs.SetInt("cont_w_clothse[45]", 1);
		PlayerPrefs.SetInt("cont_w_clothse[46]", 1);
		PlayerPrefs.SetInt("cont_w_clothse[48]", 1);
		PlayerPrefs.SetInt("cash_hair_N[7]", 1);
		PlayerPrefs.SetInt("cash_hair_N[9]", 1);
		PlayerPrefs.SetInt("cash_hair_N[13]", 1);
		GameObject.Find("limite_pac_1").GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("limit_pac_1", 1);
	}

	public void Limit_clothes_m()
	{
		if (clothes_m_45 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
		}
		if (clothes_m_46 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.015f);
		}
		if (clothes_m_48 == 0)
		{
			PlayerPrefs.SetFloat("SaleMonthLife_M", FeeCont.SaleMonthLife_M += 0.014f);
		}
		PlayerPrefs.SetInt("ClotheBuyOK", s3_7.ClotheBuyOK += 3);
		PlayerPrefs.SetInt("HairBuyOK", s3_7.HairBuyOK += 3);
		PlayerPrefs.SetInt("cont_m_clothse[45]", 1);
		PlayerPrefs.SetInt("cont_m_clothse[46]", 1);
		PlayerPrefs.SetInt("cont_m_clothse[48]", 1);
		PlayerPrefs.SetInt("cash_hair_N[6]", 1);
		PlayerPrefs.SetInt("cash_hair_N[8]", 1);
		PlayerPrefs.SetInt("cash_hair_N[12]", 1);
		GameObject.Find("limite_pac_2").GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("limit_pac_2", 1);
	}

	public void Money_50man()
	{
		Item_N = 11;
		if (scene_controll.gem >= 40)
		{
			scene_controll.gem -= 40;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 5000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void Money_100man()
	{
		Item_N = 11;
		if (scene_controll.gem >= 80)
		{
			scene_controll.gem -= 80;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 10000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void Money_250man()
	{
		Item_N = 11;
		if (scene_controll.gem >= 160)
		{
			scene_controll.gem -= 160;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 25000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void Money_600man()
	{
		Item_N = 11;
		if (scene_controll.gem >= 320)
		{
			scene_controll.gem -= 320;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 60000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void Money_1400man()
	{
		Item_N = 11;
		if (scene_controll.gem >= 640)
		{
			scene_controll.gem -= 640;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 140000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void Money_1eok()
	{
		Item_N = 11;
		if (scene_controll.gem >= 3000)
		{
			scene_controll.gem -= 3000;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.money += 1000000000L;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			Momeysetting();
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void AlbaPay_btn()
	{
		Item_N = 1;
		Item_Icon.SetActive(true);
		Item_Info.SetActive(true);
		Item_Icon_M.SetActive(false);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon.GetComponent<Image>().sprite = Item_Icon_Img[0];
		Item_Title.GetComponent<Text>().text = string.Format("Forbidden potion");
		Item_Info.GetComponent<Text>().text = string.Format("Your part-time pay increases \n by 20 % permanently.");
		Item_Price.GetComponent<Text>().text = string.Format("200");
		Confirm_Window();
	}

	public void Timebuff_btn()
	{
		Item_N = 2;
		Item_Icon.SetActive(true);
		Item_Info.SetActive(true);
		Item_Icon_M.SetActive(false);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon.GetComponent<Image>().sprite = Item_Icon_Img[1];
		Item_Title.GetComponent<Text>().text = string.Format("Permanent Time buff");
		Item_Info.GetComponent<Text>().text = string.Format("Game speed is constantly increasing.");
		Item_Price.GetComponent<Text>().text = string.Format("200");
		Confirm_Window();
	}

	public void Changesex_btn()
	{
		Item_N = 3;
		Item_Icon.SetActive(true);
		Item_Info.SetActive(true);
		Item_Icon_M.SetActive(false);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon.GetComponent<Image>().sprite = Item_Icon_Img[2];
		Item_Title.GetComponent<Text>().text = string.Format("Sex reversal");
		Item_Info.GetComponent<Text>().text = string.Format("Gender changes.");
		Item_Price.GetComponent<Text>().text = string.Format("50");
		Confirm_Window();
	}

	public void No_ad_btn()
	{
		Item_N = 10;
		Item_Icon.SetActive(true);
		Item_Info.SetActive(true);
		Item_Icon_M.SetActive(false);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[1];
		Item_Icon.GetComponent<Image>().sprite = Item_Icon_Img[6];
		Item_Title.GetComponent<Text>().text = string.Format("Delete ad");
		Item_Info.GetComponent<Text>().text = string.Format("Advertisement of banner ads and\nSudden defeat ending are removed.");
		Item_Price.GetComponent<Text>().text = string.Format("$5");
		Confirm_Window();
	}

	public void Money40_btn()
	{
		Item_N = 4;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[0];
		Item_Price_M.GetComponent<Text>().text = string.Format("5,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("40");
		Confirm_Window();
	}

	public void Money80_btn()
	{
		Item_N = 5;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[0];
		Item_Price_M.GetComponent<Text>().text = string.Format("10,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("80");
		Confirm_Window();
	}

	public void Money160_btn()
	{
		Item_N = 6;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[1];
		Item_Price_M.GetComponent<Text>().text = string.Format("25,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("160");
		Confirm_Window();
	}

	public void Money320_btn()
	{
		Item_N = 7;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[1];
		Item_Price_M.GetComponent<Text>().text = string.Format("60,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("320");
		Confirm_Window();
	}

	public void Money640_btn()
	{
		Item_N = 8;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[2];
		Item_Price_M.GetComponent<Text>().text = string.Format("140,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("640");
		Confirm_Window();
	}

	public void Money3000_btn()
	{
		Item_N = 9;
		Item_Icon.SetActive(false);
		Item_Info.SetActive(false);
		Item_Icon_M.SetActive(true);
		Item_Icon_price.GetComponent<Image>().sprite = S_Item_Icon_Img_Price[0];
		Item_Icon_M.GetComponent<Image>().sprite = Item_Icon_Img_M[2];
		Item_Price_M.GetComponent<Text>().text = string.Format("1,000,000,000G");
		Item_Price.GetComponent<Text>().text = string.Format("3,000");
		Confirm_Window();
	}

	public void Confirm_Window()
	{
		ConfirmWindow.SetActive(true);
	}

	public void Close_Confirm_Window()
	{
		ConfirmWindow.SetActive(false);
	}

	public void Confirm_Buy_Btn()
	{
		if (Item_N == 1)
		{
			AlbaPayBuff_item();
		}
		if (Item_N == 2)
		{
			TimeBuff_item();
		}
		if (Item_N == 3)
		{
			ChangeSex();
		}
		if (Item_N == 4)
		{
			Money_50man();
		}
		if (Item_N == 5)
		{
			Money_100man();
		}
		if (Item_N == 6)
		{
			Money_250man();
		}
		if (Item_N == 7)
		{
			Money_600man();
		}
		if (Item_N == 8)
		{
			Money_1400man();
		}
		if (Item_N == 9)
		{
			Money_1eok();
		}
	}

	public void no_ad()
	{
		Item_N = 10;
		SPrefs.SetInt("no_ad", 1);
		Ads_Admob.no_ad = SPrefs.GetInt("no_ad");
		GameObject.Find("btn_1 (3)").GetComponent<Button>().interactable = false;
		Close_Confirm_Window();
	}

	public void AlbaPayBuff_item()
	{
		if (scene_controll.gem >= 200)
		{
			scene_controll.gem -= 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			PlayerPrefs.SetInt("Albapaybuff", 1);
			S2_4.Albapaybuff = PlayerPrefs.GetInt("Albapaybuff");
			Momeysetting();
			GameObject.Find("btn_1").GetComponent<Button>().interactable = false;
			PlayerPrefs.SetInt("item1", 1);
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void TimeBuff_item()
	{
		if (scene_controll.gem >= 200)
		{
			scene_controll.gem -= 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			PlayerPrefs.SetInt("BUff_Purchase", 1);
			Momeysetting();
			GameObject.Find("btn_1 (1)").GetComponent<Button>().interactable = false;
			PlayerPrefs.SetInt("item2", 1);
			Close_Confirm_Window();
		}
		else
		{
			Notice();
		}
	}

	public void ChangeSex()
	{
		if (scene_controll.gem >= 50)
		{
			scene_controll.gem -= 50;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			Debug.Log("SEX1" + Char.Sex + ChangeSexbool);
			if (Char.Sex == 0 && !ChangeSexbool)
			{
				PlayerPrefs.SetInt("Sex", 1);
				Char.Sex = PlayerPrefs.GetInt("Sex");
				ChangeSexbool = true;
			}
			if (Char.Sex == 1 && !ChangeSexbool)
			{
				PlayerPrefs.SetInt("Sex", 0);
				Char.Sex = PlayerPrefs.GetInt("Sex");
				ChangeSexbool = true;
			}
			PlayerPrefs.SetInt("Hair_N", 0);
			Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
			PlayerPrefs.SetFloat("minushairpoint_W", 0f);
			PlayerPrefs.SetInt("Clothes_N", 0);
			Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
			Debug.Log("SEX2" + Char.Sex);
			Close_Confirm_Window();
			GameObject gameObject = (GameObject)Resources.Load("Check_Sex");
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Check_Sex"));
			GameObject gameObject3 = GameObject.Find("Canvas");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			gameObject2.transform.localPosition = gameObject.transform.localPosition;
			Momeysetting();
		}
		else
		{
			Notice();
		}
	}

	public void Btn_RandomPack_1()
	{
		RandomBox_N = 1;
		scene_controll.money += 25000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		Momeysetting();
		int num = Random.Range(1, 22);
		Debug.LogFormat("sex" + Char.Sex + "RandomPack_1_ran_N" + num);
		if (Char.Sex == 1)
		{
			if (num == 1)
			{
				PlayerPrefs.SetInt("cont_w_clothse[1]", 1);
				PlayerPrefs.SetInt("Clothes_N", 1);
			}
			if (num == 2)
			{
				PlayerPrefs.SetInt("cont_w_clothse[2]", 1);
				PlayerPrefs.SetInt("Clothes_N", 2);
			}
			if (num == 3)
			{
				PlayerPrefs.SetInt("cont_w_clothse[3]", 1);
				PlayerPrefs.SetInt("Clothes_N", 3);
			}
			if (num == 4)
			{
				PlayerPrefs.SetInt("cont_w_clothse[4]", 1);
				PlayerPrefs.SetInt("Clothes_N", 4);
			}
			if (num == 5)
			{
				PlayerPrefs.SetInt("cont_w_clothse[5]", 1);
				PlayerPrefs.SetInt("Clothes_N", 5);
			}
			if (num == 6)
			{
				PlayerPrefs.SetInt("cont_w_clothse[6]", 1);
				PlayerPrefs.SetInt("Clothes_N", 6);
			}
			if (num == 7)
			{
				PlayerPrefs.SetInt("cont_w_clothse[7]", 1);
				PlayerPrefs.SetInt("Clothes_N", 7);
			}
			if (num == 8)
			{
				PlayerPrefs.SetInt("cont_w_clothse[8]", 1);
				PlayerPrefs.SetInt("Clothes_N", 8);
			}
			if (num == 9)
			{
				PlayerPrefs.SetInt("cont_w_clothse[9]", 1);
				PlayerPrefs.SetInt("Clothes_N", 9);
			}
			if (num == 10)
			{
				PlayerPrefs.SetInt("cont_w_clothse[10]", 1);
				PlayerPrefs.SetInt("Clothes_N", 10);
			}
			if (num == 11)
			{
				PlayerPrefs.SetInt("cont_w_clothse[11]", 1);
				PlayerPrefs.SetInt("Clothes_N", 11);
			}
			if (num == 12)
			{
				PlayerPrefs.SetInt("cont_w_clothse[12]", 1);
				PlayerPrefs.SetInt("Clothes_N", 12);
			}
			if (num == 13)
			{
				PlayerPrefs.SetInt("cont_w_clothse[13]", 1);
				PlayerPrefs.SetInt("Clothes_N", 13);
			}
			if (num == 14)
			{
				PlayerPrefs.SetInt("cont_w_clothse[14]", 1);
				PlayerPrefs.SetInt("Clothes_N", 14);
			}
			if (num == 15)
			{
				PlayerPrefs.SetInt("cont_w_clothse[15]", 1);
				PlayerPrefs.SetInt("Clothes_N", 15);
			}
			if (num == 16)
			{
				PlayerPrefs.SetInt("cont_w_clothse[16]", 1);
				PlayerPrefs.SetInt("Clothes_N", 16);
			}
			if (num == 17)
			{
				PlayerPrefs.SetInt("cont_w_clothse[17]", 1);
				PlayerPrefs.SetInt("Clothes_N", 17);
			}
			if (num == 18)
			{
				PlayerPrefs.SetInt("cont_w_clothse[18]", 1);
				PlayerPrefs.SetInt("Clothes_N", 18);
			}
			if (num == 19)
			{
				PlayerPrefs.SetInt("cont_w_clothse[19]", 1);
				PlayerPrefs.SetInt("Clothes_N", 19);
			}
			if (num == 20)
			{
				PlayerPrefs.SetInt("cont_w_clothse[20]", 1);
				PlayerPrefs.SetInt("Clothes_N", 20);
			}
			if (num == 21)
			{
				PlayerPrefs.SetInt("cont_w_clothse[21]", 1);
				PlayerPrefs.SetInt("Clothes_N", 21);
			}
		}
		if (Char.Sex == 0)
		{
			if (num == 1)
			{
				PlayerPrefs.SetInt("cont_m_clothse[1]", 1);
				PlayerPrefs.SetInt("Clothes_N", 1);
			}
			if (num == 2)
			{
				PlayerPrefs.SetInt("cont_m_clothse[2]", 1);
				PlayerPrefs.SetInt("Clothes_N", 2);
			}
			if (num == 3)
			{
				PlayerPrefs.SetInt("cont_m_clothse[3]", 1);
				PlayerPrefs.SetInt("Clothes_N", 3);
			}
			if (num == 4)
			{
				PlayerPrefs.SetInt("cont_m_clothse[4]", 1);
				PlayerPrefs.SetInt("Clothes_N", 4);
			}
			if (num == 5)
			{
				PlayerPrefs.SetInt("cont_m_clothse[5]", 1);
				PlayerPrefs.SetInt("Clothes_N", 5);
			}
			if (num == 6)
			{
				PlayerPrefs.SetInt("cont_m_clothse[6]", 1);
				PlayerPrefs.SetInt("Clothes_N", 6);
			}
			if (num == 7)
			{
				PlayerPrefs.SetInt("cont_m_clothse[7]", 1);
				PlayerPrefs.SetInt("Clothes_N", 7);
			}
			if (num == 8)
			{
				PlayerPrefs.SetInt("cont_m_clothse[8]", 1);
				PlayerPrefs.SetInt("Clothes_N", 8);
			}
			if (num == 9)
			{
				PlayerPrefs.SetInt("cont_m_clothse[9]", 1);
				PlayerPrefs.SetInt("Clothes_N", 9);
			}
			if (num == 10)
			{
				PlayerPrefs.SetInt("cont_m_clothse[10]", 1);
				PlayerPrefs.SetInt("Clothes_N", 10);
			}
			if (num == 11)
			{
				PlayerPrefs.SetInt("cont_m_clothse[11]", 1);
				PlayerPrefs.SetInt("Clothes_N", 11);
			}
			if (num == 12)
			{
				PlayerPrefs.SetInt("cont_m_clothse[12]", 1);
				PlayerPrefs.SetInt("Clothes_N", 12);
			}
			if (num == 13)
			{
				PlayerPrefs.SetInt("cont_m_clothse[13]", 1);
				PlayerPrefs.SetInt("Clothes_N", 13);
			}
			if (num == 14)
			{
				PlayerPrefs.SetInt("cont_m_clothse[14]", 1);
				PlayerPrefs.SetInt("Clothes_N", 14);
			}
			if (num == 15)
			{
				PlayerPrefs.SetInt("cont_m_clothse[15]", 1);
				PlayerPrefs.SetInt("Clothes_N", 15);
			}
			if (num == 16)
			{
				PlayerPrefs.SetInt("cont_m_clothse[16]", 1);
				PlayerPrefs.SetInt("Clothes_N", 16);
			}
			if (num == 17)
			{
				PlayerPrefs.SetInt("cont_m_clothse[17]", 1);
				PlayerPrefs.SetInt("Clothes_N", 17);
			}
			if (num == 18)
			{
				PlayerPrefs.SetInt("cont_m_clothse[18]", 1);
				PlayerPrefs.SetInt("Clothes_N", 18);
			}
			if (num == 19)
			{
				PlayerPrefs.SetInt("cont_m_clothse[19]", 1);
				PlayerPrefs.SetInt("Clothes_N", 19);
			}
			if (num == 20)
			{
				PlayerPrefs.SetInt("cont_m_clothse[20]", 1);
				PlayerPrefs.SetInt("Clothes_N", 20);
			}
			if (num == 21)
			{
				PlayerPrefs.SetInt("cont_m_clothse[21]", 1);
				PlayerPrefs.SetInt("Clothes_N", 21);
			}
		}
		GameObject.Find("RandomPack_1").GetComponent<Button>().interactable = false;
	}

	public void Btn_RandomPack_2()
	{
		scene_controll.money += 60000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		Momeysetting();
		int num = Random.Range(1, 21);
		Debug.LogFormat("sex" + Char.Sex + "RandomPack_2_ran_N" + num);
		if (Char.Sex == 1)
		{
			if (num == 1)
			{
				PlayerPrefs.SetInt("cont_w_clothse[22]", 1);
				PlayerPrefs.SetInt("Clothes_N", 22);
			}
			if (num == 2)
			{
				PlayerPrefs.SetInt("cont_w_clothse[23]", 1);
				PlayerPrefs.SetInt("Clothes_N", 23);
			}
			if (num == 3)
			{
				PlayerPrefs.SetInt("cont_w_clothse[24]", 1);
				PlayerPrefs.SetInt("Clothes_N", 24);
			}
			if (num == 4)
			{
				PlayerPrefs.SetInt("cont_w_clothse[25]", 1);
				PlayerPrefs.SetInt("Clothes_N", 25);
			}
			if (num == 5)
			{
				PlayerPrefs.SetInt("cont_w_clothse[26]", 1);
				PlayerPrefs.SetInt("Clothes_N", 26);
			}
			if (num == 6)
			{
				PlayerPrefs.SetInt("cont_w_clothse[27]", 1);
				PlayerPrefs.SetInt("Clothes_N", 27);
			}
			if (num == 7)
			{
				PlayerPrefs.SetInt("cont_w_clothse[28]", 1);
				PlayerPrefs.SetInt("Clothes_N", 28);
			}
			if (num == 8)
			{
				PlayerPrefs.SetInt("cont_w_clothse[29]", 1);
				PlayerPrefs.SetInt("Clothes_N", 29);
			}
			if (num == 9)
			{
				PlayerPrefs.SetInt("cont_w_clothse[30]", 1);
				PlayerPrefs.SetInt("Clothes_N", 30);
			}
			if (num == 10)
			{
				PlayerPrefs.SetInt("cont_w_clothse[31]", 1);
				PlayerPrefs.SetInt("Clothes_N", 31);
			}
			if (num == 11)
			{
				PlayerPrefs.SetInt("cont_w_clothse[32]", 1);
				PlayerPrefs.SetInt("Clothes_N", 32);
			}
			if (num == 12)
			{
				PlayerPrefs.SetInt("cont_w_clothse[33]", 1);
				PlayerPrefs.SetInt("Clothes_N", 33);
			}
			if (num == 13)
			{
				PlayerPrefs.SetInt("cont_w_clothse[34]", 1);
				PlayerPrefs.SetInt("Clothes_N", 34);
			}
			if (num == 14)
			{
				PlayerPrefs.SetInt("cont_w_clothse[35]", 1);
				PlayerPrefs.SetInt("Clothes_N", 35);
			}
			if (num == 15)
			{
				PlayerPrefs.SetInt("cont_w_clothse[36]", 1);
				PlayerPrefs.SetInt("Clothes_N", 36);
			}
			if (num == 16)
			{
				PlayerPrefs.SetInt("cont_w_clothse[37]", 1);
				PlayerPrefs.SetInt("Clothes_N", 37);
			}
			if (num == 17)
			{
				PlayerPrefs.SetInt("cont_w_clothse[38]", 1);
				PlayerPrefs.SetInt("Clothes_N", 38);
			}
			if (num == 18)
			{
				PlayerPrefs.SetInt("cont_w_clothse[39]", 1);
				PlayerPrefs.SetInt("Clothes_N", 39);
			}
			if (num == 19)
			{
				PlayerPrefs.SetInt("cont_w_clothse[40]", 1);
				PlayerPrefs.SetInt("Clothes_N", 40);
			}
			if (num == 20)
			{
				PlayerPrefs.SetInt("cont_w_clothse[41]", 1);
				PlayerPrefs.SetInt("Clothes_N", 41);
			}
		}
		if (Char.Sex == 0)
		{
			if (num == 1)
			{
				PlayerPrefs.SetInt("cont_m_clothse[22]", 1);
				PlayerPrefs.SetInt("Clothes_N", 22);
			}
			if (num == 2)
			{
				PlayerPrefs.SetInt("cont_m_clothse[23]", 1);
				PlayerPrefs.SetInt("Clothes_N", 23);
			}
			if (num == 3)
			{
				PlayerPrefs.SetInt("cont_m_clothse[24]", 1);
				PlayerPrefs.SetInt("Clothes_N", 24);
			}
			if (num == 4)
			{
				PlayerPrefs.SetInt("cont_m_clothse[25]", 1);
				PlayerPrefs.SetInt("Clothes_N", 25);
			}
			if (num == 5)
			{
				PlayerPrefs.SetInt("cont_m_clothse[26]", 1);
				PlayerPrefs.SetInt("Clothes_N", 26);
			}
			if (num == 6)
			{
				PlayerPrefs.SetInt("cont_m_clothse[27]", 1);
				PlayerPrefs.SetInt("Clothes_N", 27);
			}
			if (num == 7)
			{
				PlayerPrefs.SetInt("cont_m_clothse[28]", 1);
				PlayerPrefs.SetInt("Clothes_N", 28);
			}
			if (num == 8)
			{
				PlayerPrefs.SetInt("cont_m_clothse[29]", 1);
				PlayerPrefs.SetInt("Clothes_N", 29);
			}
			if (num == 9)
			{
				PlayerPrefs.SetInt("cont_m_clothse[30]", 1);
				PlayerPrefs.SetInt("Clothes_N", 30);
			}
			if (num == 10)
			{
				PlayerPrefs.SetInt("cont_m_clothse[31]", 1);
				PlayerPrefs.SetInt("Clothes_N", 31);
			}
			if (num == 11)
			{
				PlayerPrefs.SetInt("cont_m_clothse[32]", 1);
				PlayerPrefs.SetInt("Clothes_N", 32);
			}
			if (num == 12)
			{
				PlayerPrefs.SetInt("cont_m_clothse[33]", 1);
				PlayerPrefs.SetInt("Clothes_N", 33);
			}
			if (num == 13)
			{
				PlayerPrefs.SetInt("cont_m_clothse[34]", 1);
				PlayerPrefs.SetInt("Clothes_N", 34);
			}
			if (num == 14)
			{
				PlayerPrefs.SetInt("cont_m_clothse[35]", 1);
				PlayerPrefs.SetInt("Clothes_N", 35);
			}
			if (num == 15)
			{
				PlayerPrefs.SetInt("cont_m_clothse[36]", 1);
				PlayerPrefs.SetInt("Clothes_N", 36);
			}
			if (num == 16)
			{
				PlayerPrefs.SetInt("cont_m_clothse[37]", 1);
				PlayerPrefs.SetInt("Clothes_N", 37);
			}
			if (num == 17)
			{
				PlayerPrefs.SetInt("cont_m_clothse[38]", 1);
				PlayerPrefs.SetInt("Clothes_N", 38);
			}
			if (num == 18)
			{
				PlayerPrefs.SetInt("cont_m_clothse[39]", 1);
				PlayerPrefs.SetInt("Clothes_N", 39);
			}
			if (num == 19)
			{
				PlayerPrefs.SetInt("cont_m_clothse[40]", 1);
				PlayerPrefs.SetInt("Clothes_N", 40);
			}
			if (num == 20)
			{
				PlayerPrefs.SetInt("cont_m_clothse[41]", 1);
				PlayerPrefs.SetInt("Clothes_N", 41);
			}
		}
	}

	public void Btn_RandomPack_3()
	{
		scene_controll.money += 140000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		Momeysetting();
		int num = 3;
		int num2 = 3;
		if (num2 == num)
		{
			num2 = Random.Range(1, 21);
		}
		Debug.LogFormat("sex" + Char.Sex + "RandomPack_3_ran_N_1" + num);
		Debug.LogFormat("sex" + Char.Sex + "RandomPack_3_ran_N_2" + num2);
	}

	public void Notice()
	{
		Notice_nogem.SetActive(true);
		Invoke("Closenotice", 1f);
	}

	public void Closenotice()
	{
		Notice_nogem.SetActive(false);
	}
}
