using UnityEngine;
using UnityEngine.UI;

public class SuddenDeathCont : MonoBehaviour
{
	public GameObject SuddenDeathScreen;

	public GameObject SuddenDeahtImgObj;

	public static int SuddenDeath_N;

	public GameObject SuddenDeathText;

	public static int Death_1F;

	public static int Death_2F;

	public static int Death_3F;

	public static int Death_4F;

	public static int Death_5F;

	public static int Death_6F;

	public static int Death_7F;

	public static int Death_8F;

	public static int Death_9F;

	public static int Death_10F;

	public static int Death_11F;

	public static int Death_12F;

	public static int Death_13F;

	public static int Death_14F;

	public static int Death_15F;

	public static int Death_16F;

	public static int Death_17F;

	public static int Death_18F;

	public static int Death_19F;

	public static int Death_20F;

	public static int Death_21F;

	public static int Death_22F;

	public static int Death_23F;

	public static int Death_24F;

	public static int Death_25F;

	public static int Death_26F;

	public static int Death_27F;

	public static int Death_28F;

	public static int Death_29F;

	public static int Death_30F;

	public static int Death_31F;

	public static int Death_32F;

	public static int Death_33F;

	public static int Death_34F;

	public static int Death_35F;

	public static int Death_36F;

	public static int Death_37F;

	public static int Death_38F;

	public static int Death_39F;

	public static int Death_40F;

	public static int Death_41F;

	public static int Death_42F;

	public static int Death_43F;

	public static int Death_44F;

	public static int Death_45F;

	public static int Death_46F;

	public static int Death_47F;

	public static int Death_48F;

	public static int Death_49F;

	public static int Death_50F;

	public static int Death_51F;

	public static int Death_52F;

	public static int Death_53F;

	public static int Death_54F;

	public static int Death_55F;

	public static int Death_56F;

	public static int Death_57F;

	public static int Death_58F;

	public static int Death_59F;

	public static int AlbaDeath_1F;

	public static int AlbaDeath_2F;

	public static int AlbaDeath_3F;

	public static int AlbaDeath_4F;

	public static int AlbaDeath_5F;

	public static int AlbaDeath_6F;

	public static int AlbaDeath_7F;

	public static int AlbaDeath_8F;

	public static int AlbaDeath_9F;

	public static int AlbaDeath_10F;

	public static int AlbaDeath_11F;

	public static int AlbaDeath_12F;

	public static int AlbaDeath_13F;

	public static int AlbaDeath_14F;

	public static int AlbaDeath_15F;

	public static int AlbaDeath_16F;

	public static int AlbaDeath_17F;

	public static int AlbaDeath_18F;

	public static int AlbaDeath_19F;

	public static int AlbaDeath_20F;

	public static int AlbaDeath_21F;

	public static int AlbaDeath_22F;

	public static int AlbaDeath_23F;

	public static int AlbaDeath_24F;

	public static int AlbaDeath_25F;

	public static int AlbaDeath_26F;

	public static int AlbaDeath_27F;

	public static int AlbaDeath_28F;

	public static int AlbaDeath_29F;

	public static int AlbaDeath_30F;

	public static int AlbaDeath_31F;

	public static int ReasonDeath_N;

	public static int OtherDeath_N;

	public GameObject MoneyIcon;

	public Sprite[] MoneyIcon_img;

	public Transform Money_T;

	public int DeathMoney;

	public int PPlus_money;

	public static int Death_Count;

	public GameObject Indure_btn;

	public GameObject Gameover_btn;

	public GameObject Monthfee;

	public static int Circle_gradu;

	public static int Circle_frust;

	public static int Circle_main;

	public GameObject Circle_main_obj;

	public TextUP _TextUP;

	public s2_2 _s2_2;

	public GameObject allreport;

	public GameObject MonthlyReport;

	public GameObject VacaImage;

	public GameObject FinalDeath;

	public static int SuddenDeahtPlusGem;

	public static int SuddenDeahtPlusmoney;

	public suddenSound _suddenSound;

	public AudioCont _AudioCont;

	public GameObject Nogem;

	private GameObject _Timecont;

	private GameObject _reportcont;

	public static int Rebirth_OK;

	public GameObject Really;

	public void Awake()
	{
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
	}

	private void Start()
	{
		return;
		_Timecont = GameObject.Find("TimeController");
		Death_Count = PlayerPrefs.GetInt("Death_Count");
		TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
		TimeCont.Grade = PlayerPrefs.GetInt("Grade");
		TimeCont.OneSemes = PlayerPrefs.GetInt("OneSemes");
		FurnCont.Toilet_N = PlayerPrefs.GetInt("Toilet_N");
		FurnCont.Kitchen_N = PlayerPrefs.GetInt("Kitchen_N");
		FurnCont.Bed_N = PlayerPrefs.GetInt("Bed_N");
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		Death_1F = PlayerPrefs.GetInt("Death_1");
		Death_2F = PlayerPrefs.GetInt("Death_2");
		Death_3F = PlayerPrefs.GetInt("Death_3");
		Death_4F = PlayerPrefs.GetInt("Death_4");
		Death_5F = PlayerPrefs.GetInt("Death_5");
		Death_6F = PlayerPrefs.GetInt("Death_6");
		Death_7F = PlayerPrefs.GetInt("Death_7");
		Death_8F = PlayerPrefs.GetInt("Death_8");
		Death_9F = PlayerPrefs.GetInt("Death_9");
		Death_10F = PlayerPrefs.GetInt("Death_10");
		Death_11F = PlayerPrefs.GetInt("Death_11");
		Death_12F = PlayerPrefs.GetInt("Death_12");
		Death_13F = PlayerPrefs.GetInt("Death_13");
		Death_14F = PlayerPrefs.GetInt("Death_14");
		Death_15F = PlayerPrefs.GetInt("Death_15");
		Death_16F = PlayerPrefs.GetInt("Death_16");
		Death_17F = PlayerPrefs.GetInt("Death_17");
		Death_18F = PlayerPrefs.GetInt("Death_18");
		Death_19F = PlayerPrefs.GetInt("Death_19");
		Death_20F = PlayerPrefs.GetInt("Death_20");
		Death_21F = PlayerPrefs.GetInt("Death_21");
		Death_22F = PlayerPrefs.GetInt("Death_22");
		Death_23F = PlayerPrefs.GetInt("Death_23");
		Death_24F = PlayerPrefs.GetInt("Death_24");
		Death_25F = PlayerPrefs.GetInt("Death_25");
		Death_26F = PlayerPrefs.GetInt("Death_26");
		Death_27F = PlayerPrefs.GetInt("Death_27");
		Death_28F = PlayerPrefs.GetInt("Death_28");
		Death_29F = PlayerPrefs.GetInt("Death_29");
		Death_30F = PlayerPrefs.GetInt("Death_30");
		Death_31F = PlayerPrefs.GetInt("Death_31");
		Death_32F = PlayerPrefs.GetInt("Death_32");
		Death_33F = PlayerPrefs.GetInt("Death_33");
		Death_34F = PlayerPrefs.GetInt("Death_34");
		Death_35F = PlayerPrefs.GetInt("Death_35");
		Death_36F = PlayerPrefs.GetInt("Death_36");
		Death_37F = PlayerPrefs.GetInt("Death_37");
		Death_38F = PlayerPrefs.GetInt("Death_38");
		Death_39F = PlayerPrefs.GetInt("Death_39");
		Death_40F = PlayerPrefs.GetInt("Death_40");
		Death_41F = PlayerPrefs.GetInt("Death_41");
		Death_42F = PlayerPrefs.GetInt("Death_42");
		Death_43F = PlayerPrefs.GetInt("Death_43");
		Death_44F = PlayerPrefs.GetInt("Death_44");
		Death_45F = PlayerPrefs.GetInt("Death_45");
		Death_46F = PlayerPrefs.GetInt("Death_46");
		Death_47F = PlayerPrefs.GetInt("Death_47");
		Death_48F = PlayerPrefs.GetInt("Death_48");
		Death_49F = PlayerPrefs.GetInt("Death_49");
		Death_50F = PlayerPrefs.GetInt("Death_50");
		Death_51F = PlayerPrefs.GetInt("Death_51");
		Death_52F = PlayerPrefs.GetInt("Death_52");
		Death_53F = PlayerPrefs.GetInt("Death_53");
		Death_54F = PlayerPrefs.GetInt("Death_54");
		Death_55F = PlayerPrefs.GetInt("Death_55");
		Death_56F = PlayerPrefs.GetInt("Death_56");
		Death_57F = PlayerPrefs.GetInt("Death_57");
		Death_58F = PlayerPrefs.GetInt("Death_58");
		Death_59F = PlayerPrefs.GetInt("Death_59");
		AlbaDeath_1F = PlayerPrefs.GetInt("AlbaDeath_1");
		AlbaDeath_2F = PlayerPrefs.GetInt("AlbaDeath_2");
		AlbaDeath_3F = PlayerPrefs.GetInt("AlbaDeath_3");
		AlbaDeath_4F = PlayerPrefs.GetInt("AlbaDeath_4");
		AlbaDeath_5F = PlayerPrefs.GetInt("AlbaDeath_5");
		AlbaDeath_6F = PlayerPrefs.GetInt("AlbaDeath_6");
		AlbaDeath_7F = PlayerPrefs.GetInt("AlbaDeath_7");
		AlbaDeath_8F = PlayerPrefs.GetInt("AlbaDeath_8");
		AlbaDeath_9F = PlayerPrefs.GetInt("AlbaDeath_9");
		AlbaDeath_10F = PlayerPrefs.GetInt("AlbaDeath_10");
		AlbaDeath_11F = PlayerPrefs.GetInt("AlbaDeath_11");
		AlbaDeath_12F = PlayerPrefs.GetInt("AlbaDeath_12");
		AlbaDeath_13F = PlayerPrefs.GetInt("AlbaDeath_13");
		AlbaDeath_14F = PlayerPrefs.GetInt("AlbaDeath_14");
		AlbaDeath_15F = PlayerPrefs.GetInt("AlbaDeath_15");
		AlbaDeath_16F = PlayerPrefs.GetInt("AlbaDeath_16");
		AlbaDeath_17F = PlayerPrefs.GetInt("AlbaDeath_17");
		AlbaDeath_18F = PlayerPrefs.GetInt("AlbaDeath_18");
		AlbaDeath_19F = PlayerPrefs.GetInt("AlbaDeath_19");
		AlbaDeath_20F = PlayerPrefs.GetInt("AlbaDeath_20");
		AlbaDeath_21F = PlayerPrefs.GetInt("AlbaDeath_21");
		AlbaDeath_22F = PlayerPrefs.GetInt("AlbaDeath_22");
		AlbaDeath_23F = PlayerPrefs.GetInt("AlbaDeath_23");
		AlbaDeath_24F = PlayerPrefs.GetInt("AlbaDeath_24");
		AlbaDeath_25F = PlayerPrefs.GetInt("AlbaDeath_25");
		AlbaDeath_26F = PlayerPrefs.GetInt("AlbaDeath_26");
		AlbaDeath_27F = PlayerPrefs.GetInt("AlbaDeath_27");
		AlbaDeath_28F = PlayerPrefs.GetInt("AlbaDeath_28");
		AlbaDeath_29F = PlayerPrefs.GetInt("AlbaDeath_29");
		AlbaDeath_30F = PlayerPrefs.GetInt("AlbaDeath_30");
		AlbaDeath_31F = PlayerPrefs.GetInt("AlbaDeath_31");
		s3_7.CarEnding = PlayerPrefs.GetInt("CarEnding");
		SetFalseButton();
		AlbaDeath();
		S2_4.DidAlba = 0;
		if (Death_19F == 0 && Pet.Pet_N == 0)
		{
			Invoke("Death_19", 10f);
		}
		if (Death_20F == 0 && Pet.Pet_N == 3)
		{
			Invoke("Death_20", 10f);
		}
		if (Death_36F == 0 && Pet.Pet_N == 9)
		{
			Invoke("Death_36", 10f);
		}
		if (Death_37F == 0 && Pet.Pet_N == 14)
		{
			Invoke("Death_37", 10f);
		}
		if (Death_48F == 0 && Pet.Pet_N == 11)
		{
			Invoke("Death_48", 10f);
		}
		if (Death_49F == 0 && Pet.Pet_N == 16)
		{
			Invoke("Death_49", 10f);
		}
		if (s3_7.CarEnding == 1)
		{
			Invoke("Death_35", 3f);
		}
		if (TutorialCont.Tutorial_Int == 1)
		{
		}
		Circle_main = PlayerPrefs.GetInt("Circle_main");
		if (Circle_main == 1)
		{
			Circle_main_obj.SetActive(true);
		}
		else
		{
			Circle_main_obj.SetActive(false);
		}
	}

	public void RealendingMoney()
	{
        return;
        if (RoomCont.Room_N == 1)
		{
			SuddenDeahtPlusmoney = 100000;
		}
		if (RoomCont.Room_N == 2)
		{
			SuddenDeahtPlusmoney = 175000;
		}
		if (RoomCont.Room_N == 3)
		{
			SuddenDeahtPlusmoney = 200000;
		}
		if (RoomCont.Room_N == 4)
		{
			SuddenDeahtPlusmoney = 250000;
		}
		if (RoomCont.Room_N == 5)
		{
			SuddenDeahtPlusmoney = 275000;
		}
		if (RoomCont.Room_N == 6)
		{
			SuddenDeahtPlusmoney = 300000;
		}
		if (RoomCont.Room_N == 7)
		{
			SuddenDeahtPlusmoney = 350000;
		}
		if (RoomCont.Room_N == 8)
		{
			SuddenDeahtPlusmoney = 500000;
		}
		if (RoomCont.Room_N == 9)
		{
			SuddenDeahtPlusmoney = 1000000;
		}
		if (RoomCont.Room_N == 10)
		{
			SuddenDeahtPlusmoney = 1500000;
		}
		if (RoomCont.Room_N == 11)
		{
			SuddenDeahtPlusmoney = 2500000;
		}
		if (RoomCont.Room_N == 12)
		{
			SuddenDeahtPlusmoney = 4000000;
		}
		if (RoomCont.Room_N == 13)
		{
			SuddenDeahtPlusmoney = 7500000;
		}
		if (RoomCont.Room_N == 14)
		{
			SuddenDeahtPlusmoney = 12500000;
		}
		if (RoomCont.Room_N == 15)
		{
			SuddenDeahtPlusmoney = 25000000;
		}
	}

	public void AlbaDeath()
	{
		Alba_BarCont.AlbaDeath1 = PlayerPrefs.GetInt("AlbaDeath1");
		Alba_BarCont.AlbaDeath2 = PlayerPrefs.GetInt("AlbaDeath2");
		Alba_BarCont.AlbaDeath3 = PlayerPrefs.GetInt("AlbaDeath3");
		Alba_BarCont.AlbaDeath4 = PlayerPrefs.GetInt("AlbaDeath4");
		Alba_BarCont.AlbaDeath5 = PlayerPrefs.GetInt("AlbaDeath5");
		Alba_BarCont.AlbaDeath6 = PlayerPrefs.GetInt("AlbaDeath6");
		Alba_BarCont.AlbaDeath7 = PlayerPrefs.GetInt("AlbaDeath7");
		Alba_BarCont.AlbaDeath8 = PlayerPrefs.GetInt("AlbaDeath8");
		Alba_BarCont.AlbaDeath9 = PlayerPrefs.GetInt("AlbaDeath9");
		Alba_BarCont.AlbaDeath10 = PlayerPrefs.GetInt("AlbaDeath10");
		if (allreport.activeInHierarchy || MonthlyReport.activeInHierarchy || FinalDeath.activeInHierarchy || VacaImage.activeInHierarchy || TutorialCont.Tutorial_Int == 0)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1 && BarCont.st <= 0.01f)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		if (Alba_BarCont.AlbaDeath1 >= 2 && Alba_BarCont.AlbaDeath1 < 5)
		{
			AlbaDeath_13();
		}
		if (Alba_BarCont.AlbaDeath1 >= 5 && Alba_BarCont.AlbaDeath1 < 10)
		{
			AlbaDeath_18();
		}
		if (Alba_BarCont.AlbaDeath1 >= 10 && Alba_BarCont.AlbaDeath1 < 15)
		{
			AlbaDeath_19();
		}
		if (Alba_BarCont.AlbaDeath1 >= 15)
		{
			AlbaDeath_29();
		}
		if (Alba_BarCont.AlbaDeath2 >= 5 && Alba_BarCont.AlbaDeath2 < 10)
		{
			AlbaDeath_1();
		}
		if (Alba_BarCont.AlbaDeath2 >= 10 && Alba_BarCont.AlbaDeath2 < 15)
		{
			AlbaDeath_3();
		}
		if (Alba_BarCont.AlbaDeath2 >= 15)
		{
			AlbaDeath_21();
		}
		if (Alba_BarCont.AlbaDeath3 >= 5 && Alba_BarCont.AlbaDeath3 < 10)
		{
			AlbaDeath_26();
		}
		if (Alba_BarCont.AlbaDeath3 >= 10 && Alba_BarCont.AlbaDeath3 < 15)
		{
			AlbaDeath_28();
		}
		if (Alba_BarCont.AlbaDeath3 >= 15)
		{
			AlbaDeath_31();
		}
		if (Alba_BarCont.AlbaDeath4 >= 5 && Alba_BarCont.AlbaDeath4 < 10)
		{
			AlbaDeath_2();
		}
		if (Alba_BarCont.AlbaDeath4 >= 10 && Alba_BarCont.AlbaDeath4 < 15)
		{
			AlbaDeath_6();
		}
		if (Alba_BarCont.AlbaDeath4 >= 15)
		{
			AlbaDeath_20();
		}
		if (Alba_BarCont.AlbaDeath5 >= 5 && Alba_BarCont.AlbaDeath5 < 10)
		{
			AlbaDeath_10();
		}
		if (Alba_BarCont.AlbaDeath5 >= 10 && Alba_BarCont.AlbaDeath5 < 15)
		{
			AlbaDeath_16();
		}
		if (Alba_BarCont.AlbaDeath5 >= 15)
		{
			AlbaDeath_23();
		}
		if (Alba_BarCont.AlbaDeath6 >= 5 && Alba_BarCont.AlbaDeath6 < 10)
		{
			AlbaDeath_14();
		}
		if (Alba_BarCont.AlbaDeath6 >= 10 && Alba_BarCont.AlbaDeath6 < 15)
		{
			AlbaDeath_17();
		}
		if (Alba_BarCont.AlbaDeath6 >= 15)
		{
			AlbaDeath_30();
		}
		if (Alba_BarCont.AlbaDeath7 >= 5 && Alba_BarCont.AlbaDeath7 < 10)
		{
			AlbaDeath_8();
		}
		if (Alba_BarCont.AlbaDeath7 >= 10 && Alba_BarCont.AlbaDeath7 < 15)
		{
			AlbaDeath_9();
		}
		if (Alba_BarCont.AlbaDeath7 >= 15)
		{
			AlbaDeath_25();
		}
		if (Alba_BarCont.AlbaDeath8 >= 5 && Alba_BarCont.AlbaDeath8 < 10)
		{
			AlbaDeath_4();
		}
		if (Alba_BarCont.AlbaDeath8 >= 10 && Alba_BarCont.AlbaDeath8 < 15)
		{
			AlbaDeath_5();
		}
		if (Alba_BarCont.AlbaDeath8 >= 15)
		{
			AlbaDeath_24();
		}
		if (Alba_BarCont.AlbaDeath9 >= 5 && Alba_BarCont.AlbaDeath9 < 10)
		{
			AlbaDeath_7();
		}
		if (Alba_BarCont.AlbaDeath9 >= 10 && Alba_BarCont.AlbaDeath9 < 15)
		{
			AlbaDeath_15();
		}
		if (Alba_BarCont.AlbaDeath9 >= 15)
		{
			AlbaDeath_22();
		}
		if (Alba_BarCont.AlbaDeath10 >= 5 && Alba_BarCont.AlbaDeath10 < 10)
		{
			AlbaDeath_11();
		}
		if (Alba_BarCont.AlbaDeath10 >= 10 && Alba_BarCont.AlbaDeath10 < 15)
		{
			AlbaDeath_12();
		}
		if (Alba_BarCont.AlbaDeath10 >= 15)
		{
			AlbaDeath_27();
		}
	}

	public void AdsBtn()
	{
		SuddenDeathScreen.SetActive(false);
		PlayerPrefs.SetInt("Rebirth_OK", 1);
		scene_controll.gem += SuddenDeahtPlusGem;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		PlayerPrefs.SetInt("Circle_frust", 1);
		PlayerPrefs.SetInt("Circle_main", 1);
		Circle_frust = PlayerPrefs.GetInt("Circle_frust");
		Circle_main = PlayerPrefs.GetInt("Circle_main");
		Circle_main_obj.SetActive(true);
		SuddenDeahtPlusGem = 0;
	}

	public void AlbaDeath_1()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 1;
		if (AlbaDeath_1F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_2()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 2;
		if (AlbaDeath_2F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_3()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 3;
		if (AlbaDeath_3F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_4()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 4;
		if (AlbaDeath_4F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_5()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 5;
		if (AlbaDeath_5F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_6()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 6;
		if (AlbaDeath_6F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_7()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 7;
		if (AlbaDeath_7F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_8()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 8;
		if (AlbaDeath_8F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_9()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 9;
		if (AlbaDeath_9F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_10()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 10;
		if (AlbaDeath_10F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_11()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 11;
		if (AlbaDeath_11F == 0)
		{
			SuddenDeahtPlusGem = 6;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_12()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 12;
		if (AlbaDeath_12F == 0)
		{
			SuddenDeahtPlusGem = 6;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_13()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 13;
		if (AlbaDeath_13F == 0)
		{
			SuddenDeahtPlusGem = 1;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_14()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 14;
		if (AlbaDeath_14F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_15()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 15;
		if (AlbaDeath_15F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_16()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 16;
		if (AlbaDeath_16F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_17()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 17;
		if (AlbaDeath_17F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_18()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 18;
		if (AlbaDeath_18F == 0)
		{
			SuddenDeahtPlusGem = 1;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_19()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 19;
		if (AlbaDeath_19F == 0)
		{
			SuddenDeahtPlusGem = 1;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_20()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 20;
		if (AlbaDeath_20F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_21()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 21;
		if (AlbaDeath_21F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_22()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 22;
		if (AlbaDeath_22F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_23()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 23;
		if (AlbaDeath_23F == 0)
		{
			SuddenDeahtPlusGem = 3;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_24()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 24;
		if (AlbaDeath_24F == 0)
		{
			SuddenDeahtPlusGem = 5;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_25()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 25;
		if (AlbaDeath_25F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_26()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 26;
		if (AlbaDeath_26F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_27()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 27;
		if (AlbaDeath_27F == 0)
		{
			SuddenDeahtPlusGem = 6;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_28()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 28;
		if (AlbaDeath_28F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_29()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 29;
		if (AlbaDeath_29F == 0)
		{
			SuddenDeahtPlusGem = 1;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_30()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 30;
		if (AlbaDeath_30F == 0)
		{
			SuddenDeahtPlusGem = 4;
			OtherSuddenDeath();
		}
	}

	public void AlbaDeath_31()
	{
		Gameover_btn.SetActive(false);
		Indure_btn.SetActive(true);
		OtherDeath_N = 31;
		if (AlbaDeath_31F == 0)
		{
			SuddenDeahtPlusGem = 2;
			OtherSuddenDeath();
		}
	}

	public void SavaDehat_Num()
	{
		return;
		PPlus_money = 0;
		if (SuddenDeath_N == 1)
		{
			PlayerPrefs.SetInt("Death_1", 1);
		}
		if (SuddenDeath_N == 2)
		{
			PlayerPrefs.SetInt("Death_2", 1);
		}
		if (SuddenDeath_N == 3)
		{
			PlayerPrefs.SetInt("Death_3", 1);
		}
		if (SuddenDeath_N == 4)
		{
			PlayerPrefs.SetInt("Death_4", 1);
		}
		if (SuddenDeath_N == 5)
		{
			PlayerPrefs.SetInt("Death_5", 1);
		}
		if (SuddenDeath_N == 6)
		{
			PlayerPrefs.SetInt("Death_6", 1);
		}
		if (SuddenDeath_N == 7)
		{
			PlayerPrefs.SetInt("Death_7", 1);
		}
		if (ReasonDeath_N == 1)
		{
			PlayerPrefs.SetInt("Death_8", 1);
		}
		if (SuddenDeath_N == 9)
		{
			PlayerPrefs.SetInt("Death_9", 1);
		}
		if (SuddenDeath_N == 10)
		{
			PlayerPrefs.SetInt("Death_10", 1);
		}
		if (SuddenDeath_N == 11)
		{
			PlayerPrefs.SetInt("Death_11", 1);
		}
		if (SuddenDeath_N == 12)
		{
			PlayerPrefs.SetInt("Death_12", 1);
		}
		if (SuddenDeath_N == 13)
		{
			PlayerPrefs.SetInt("Death_13", 1);
		}
		if (ReasonDeath_N == 2)
		{
			PlayerPrefs.SetInt("Death_14", 1);
		}
		if (SuddenDeath_N == 15)
		{
			PlayerPrefs.SetInt("Death_15", 1);
		}
		if (ReasonDeath_N == 3)
		{
			PlayerPrefs.SetInt("Death_16", 1);
		}
		if (SuddenDeath_N == 17)
		{
			PlayerPrefs.SetInt("Death_17", 1);
		}
		if (SuddenDeath_N == 18)
		{
			PlayerPrefs.SetInt("Death_18", 1);
		}
		if (ReasonDeath_N == 4)
		{
			PlayerPrefs.SetInt("Death_19", 1);
		}
		if (ReasonDeath_N == 5)
		{
			PlayerPrefs.SetInt("Death_20", 1);
		}
		if (SuddenDeath_N == 21)
		{
			PlayerPrefs.SetInt("Death_21", 1);
		}
		if (SuddenDeath_N == 22)
		{
			PlayerPrefs.SetInt("Death_22", 1);
		}
		if (ReasonDeath_N == 6)
		{
			PlayerPrefs.SetInt("Death_23", 1);
		}
		if (SuddenDeath_N == 24)
		{
			PlayerPrefs.SetInt("Death_24", 1);
		}
		if (SuddenDeath_N == 25)
		{
			PlayerPrefs.SetInt("Death_25", 1);
		}
		if (SuddenDeath_N == 26)
		{
			PlayerPrefs.SetInt("Death_26", 1);
		}
		if (SuddenDeath_N == 27)
		{
			PlayerPrefs.SetInt("Death_27", 1);
		}
		if (SuddenDeath_N == 28)
		{
			PlayerPrefs.SetInt("Death_28", 1);
		}
		if (SuddenDeath_N == 29)
		{
			PlayerPrefs.SetInt("Death_29", 1);
		}
		if (SuddenDeath_N == 30)
		{
			PlayerPrefs.SetInt("Death_30", 1);
		}
		if (SuddenDeath_N == 31)
		{
			PlayerPrefs.SetInt("Death_31", 1);
		}
		if (SuddenDeath_N == 32)
		{
			PlayerPrefs.SetInt("Death_32", 1);
		}
		if (SuddenDeath_N == 33)
		{
			PlayerPrefs.SetInt("Death_33", 1);
		}
		if (SuddenDeath_N == 34)
		{
			PlayerPrefs.SetInt("Death_34", 1);
		}
		if (ReasonDeath_N == 7)
		{
			PlayerPrefs.SetInt("Death_35", 1);
		}
		if (ReasonDeath_N == 8)
		{
			PlayerPrefs.SetInt("Death_36", 1);
		}
		if (ReasonDeath_N == 9)
		{
			PlayerPrefs.SetInt("Death_37", 1);
		}
		if (ReasonDeath_N == 10)
		{
			PlayerPrefs.SetInt("Death_38", 1);
		}
		if (ReasonDeath_N == 11)
		{
			PlayerPrefs.SetInt("Death_39", 1);
		}
		if (ReasonDeath_N == 12)
		{
			PlayerPrefs.SetInt("Death_40", 1);
		}
		if (ReasonDeath_N == 13)
		{
			PlayerPrefs.SetInt("Death_41", 1);
		}
		if (SuddenDeath_N == 42)
		{
			PlayerPrefs.SetInt("Death_42", 1);
		}
		if (SuddenDeath_N == 43)
		{
			PlayerPrefs.SetInt("Death_43", 1);
		}
		if (SuddenDeath_N == 44)
		{
			PlayerPrefs.SetInt("Death_44", 1);
		}
		if (SuddenDeath_N == 45)
		{
			PlayerPrefs.SetInt("Death_45", 1);
		}
		if (SuddenDeath_N == 46)
		{
			PlayerPrefs.SetInt("Death_46", 1);
		}
		if (SuddenDeath_N == 47)
		{
			PlayerPrefs.SetInt("Death_47", 1);
		}
		if (ReasonDeath_N == 14)
		{
			PlayerPrefs.SetInt("Death_48", 1);
		}
		if (ReasonDeath_N == 15)
		{
			PlayerPrefs.SetInt("Death_49", 1);
		}
		if (SuddenDeath_N == 50)
		{
			PlayerPrefs.SetInt("Death_50", 1);
		}
		if (SuddenDeath_N == 51)
		{
			PlayerPrefs.SetInt("Death_51", 1);
		}
		if (SuddenDeath_N == 52)
		{
			PlayerPrefs.SetInt("Death_52", 1);
		}
		if (SuddenDeath_N == 53)
		{
			PlayerPrefs.SetInt("Death_53", 1);
		}
		if (SuddenDeath_N == 54)
		{
			PlayerPrefs.SetInt("Death_54", 1);
		}
		if (SuddenDeath_N == 55)
		{
			PlayerPrefs.SetInt("Death_55", 1);
		}
		if (SuddenDeath_N == 56)
		{
			PlayerPrefs.SetInt("Death_56", 1);
		}
		if (SuddenDeath_N == 57)
		{
			PlayerPrefs.SetInt("Death_57", 1);
		}
		if (SuddenDeath_N == 58)
		{
			PlayerPrefs.SetInt("Death_58", 1);
		}
		if (SuddenDeath_N == 59)
		{
			PlayerPrefs.SetInt("Death_59", 1);
		}
		if (OtherDeath_N == 1)
		{
			PlayerPrefs.SetInt("AlbaDeath_1", 1);
		}
		if (OtherDeath_N == 2)
		{
			PlayerPrefs.SetInt("AlbaDeath_2", 1);
		}
		if (OtherDeath_N == 3)
		{
			PlayerPrefs.SetInt("AlbaDeath_3", 1);
		}
		if (OtherDeath_N == 4)
		{
			PlayerPrefs.SetInt("AlbaDeath_4", 1);
		}
		if (OtherDeath_N == 5)
		{
			PlayerPrefs.SetInt("AlbaDeath_5", 1);
		}
		if (OtherDeath_N == 6)
		{
			PlayerPrefs.SetInt("AlbaDeath_6", 1);
		}
		if (OtherDeath_N == 7)
		{
			PlayerPrefs.SetInt("AlbaDeath_7", 1);
		}
		if (OtherDeath_N == 8)
		{
			PlayerPrefs.SetInt("AlbaDeath_8", 1);
		}
		if (OtherDeath_N == 9)
		{
			PlayerPrefs.SetInt("AlbaDeath_9", 1);
		}
		if (OtherDeath_N == 10)
		{
			PlayerPrefs.SetInt("AlbaDeath_10", 1);
		}
		if (OtherDeath_N == 11)
		{
			PlayerPrefs.SetInt("AlbaDeath_11", 1);
		}
		if (OtherDeath_N == 12)
		{
			PlayerPrefs.SetInt("AlbaDeath_12", 1);
		}
		if (OtherDeath_N == 13)
		{
			PlayerPrefs.SetInt("AlbaDeath_13", 1);
		}
		if (OtherDeath_N == 14)
		{
			PlayerPrefs.SetInt("AlbaDeath_14", 1);
		}
		if (OtherDeath_N == 15)
		{
			PlayerPrefs.SetInt("AlbaDeath_15", 1);
		}
		if (OtherDeath_N == 16)
		{
			PlayerPrefs.SetInt("AlbaDeath_16", 1);
		}
		if (OtherDeath_N == 17)
		{
			PlayerPrefs.SetInt("AlbaDeath_17", 1);
		}
		if (OtherDeath_N == 18)
		{
			PlayerPrefs.SetInt("AlbaDeath_18", 1);
		}
		if (OtherDeath_N == 19)
		{
			PlayerPrefs.SetInt("AlbaDeath_19", 1);
		}
		if (OtherDeath_N == 20)
		{
			PlayerPrefs.SetInt("AlbaDeath_20", 1);
		}
		if (OtherDeath_N == 21)
		{
			PlayerPrefs.SetInt("AlbaDeath_21", 1);
		}
		if (OtherDeath_N == 22)
		{
			PlayerPrefs.SetInt("AlbaDeath_22", 1);
		}
		if (OtherDeath_N == 23)
		{
			PlayerPrefs.SetInt("AlbaDeath_23", 1);
		}
		if (OtherDeath_N == 24)
		{
			PlayerPrefs.SetInt("AlbaDeath_24", 1);
		}
		if (OtherDeath_N == 25)
		{
			PlayerPrefs.SetInt("AlbaDeath_25", 1);
		}
		if (OtherDeath_N == 26)
		{
			PlayerPrefs.SetInt("AlbaDeath_26", 1);
		}
		if (OtherDeath_N == 27)
		{
			PlayerPrefs.SetInt("AlbaDeath_27", 1);
		}
		if (OtherDeath_N == 28)
		{
			PlayerPrefs.SetInt("AlbaDeath_28", 1);
		}
		if (OtherDeath_N == 29)
		{
			PlayerPrefs.SetInt("AlbaDeath_29", 1);
		}
		if (OtherDeath_N == 30)
		{
			PlayerPrefs.SetInt("AlbaDeath_30", 1);
		}
		if (OtherDeath_N == 31)
		{
			PlayerPrefs.SetInt("AlbaDeath_31", 1);
		}
		SaveDeath();
	}

	public void CountDeahtCont()
	{
		Death_Count++;
		PlayerPrefs.SetInt("Death_Count", Death_Count);
		GameObject.Find("GPGSCont").GetComponent<GPGS_Cont>().Suddendeathending();
	}

	public void SaveDeath()
	{
		Death_Count = PlayerPrefs.GetInt("Death_Count");
		Death_1F = PlayerPrefs.GetInt("Death_1");
		Death_2F = PlayerPrefs.GetInt("Death_2");
		Death_3F = PlayerPrefs.GetInt("Death_3");
		Death_4F = PlayerPrefs.GetInt("Death_4");
		Death_5F = PlayerPrefs.GetInt("Death_5");
		Death_6F = PlayerPrefs.GetInt("Death_6");
		Death_7F = PlayerPrefs.GetInt("Death_7");
		Death_8F = PlayerPrefs.GetInt("Death_8");
		Death_9F = PlayerPrefs.GetInt("Death_9");
		Death_10F = PlayerPrefs.GetInt("Death_10");
		Death_11F = PlayerPrefs.GetInt("Death_11");
		Death_12F = PlayerPrefs.GetInt("Death_12");
		Death_13F = PlayerPrefs.GetInt("Death_13");
		Death_14F = PlayerPrefs.GetInt("Death_14");
		Death_15F = PlayerPrefs.GetInt("Death_15");
		Death_16F = PlayerPrefs.GetInt("Death_16");
		Death_17F = PlayerPrefs.GetInt("Death_17");
		Death_18F = PlayerPrefs.GetInt("Death_18");
		Death_19F = PlayerPrefs.GetInt("Death_19");
		Death_20F = PlayerPrefs.GetInt("Death_20");
		Death_21F = PlayerPrefs.GetInt("Death_21");
		Death_22F = PlayerPrefs.GetInt("Death_22");
		Death_23F = PlayerPrefs.GetInt("Death_23");
		Death_24F = PlayerPrefs.GetInt("Death_24");
		Death_25F = PlayerPrefs.GetInt("Death_25");
		Death_26F = PlayerPrefs.GetInt("Death_26");
		Death_27F = PlayerPrefs.GetInt("Death_27");
		Death_28F = PlayerPrefs.GetInt("Death_28");
		Death_29F = PlayerPrefs.GetInt("Death_29");
		Death_30F = PlayerPrefs.GetInt("Death_30");
		Death_31F = PlayerPrefs.GetInt("Death_31");
		Death_32F = PlayerPrefs.GetInt("Death_32");
		Death_33F = PlayerPrefs.GetInt("Death_33");
		Death_34F = PlayerPrefs.GetInt("Death_34");
		Death_35F = PlayerPrefs.GetInt("Death_35");
		Death_36F = PlayerPrefs.GetInt("Death_36");
		Death_37F = PlayerPrefs.GetInt("Death_37");
		Death_38F = PlayerPrefs.GetInt("Death_38");
		Death_39F = PlayerPrefs.GetInt("Death_39");
		Death_40F = PlayerPrefs.GetInt("Death_40");
		Death_41F = PlayerPrefs.GetInt("Death_41");
		Death_42F = PlayerPrefs.GetInt("Death_42");
		Death_43F = PlayerPrefs.GetInt("Death_43");
		Death_44F = PlayerPrefs.GetInt("Death_44");
		Death_45F = PlayerPrefs.GetInt("Death_45");
		Death_46F = PlayerPrefs.GetInt("Death_46");
		Death_47F = PlayerPrefs.GetInt("Death_47");
		Death_48F = PlayerPrefs.GetInt("Death_48");
		Death_49F = PlayerPrefs.GetInt("Death_49");
		Death_50F = PlayerPrefs.GetInt("Death_50");
		Death_51F = PlayerPrefs.GetInt("Death_51");
		Death_52F = PlayerPrefs.GetInt("Death_52");
		Death_53F = PlayerPrefs.GetInt("Death_53");
		Death_54F = PlayerPrefs.GetInt("Death_54");
		Death_55F = PlayerPrefs.GetInt("Death_55");
		Death_56F = PlayerPrefs.GetInt("Death_56");
		Death_57F = PlayerPrefs.GetInt("Death_57");
		Death_58F = PlayerPrefs.GetInt("Death_58");
		Death_59F = PlayerPrefs.GetInt("Death_59");
		AlbaDeath_1F = PlayerPrefs.GetInt("AlbaDeath_1");
		AlbaDeath_2F = PlayerPrefs.GetInt("AlbaDeath_2");
		AlbaDeath_3F = PlayerPrefs.GetInt("AlbaDeath_3");
		AlbaDeath_4F = PlayerPrefs.GetInt("AlbaDeath_4");
		AlbaDeath_5F = PlayerPrefs.GetInt("AlbaDeath_5");
		AlbaDeath_6F = PlayerPrefs.GetInt("AlbaDeath_6");
		AlbaDeath_7F = PlayerPrefs.GetInt("AlbaDeath_7");
		AlbaDeath_8F = PlayerPrefs.GetInt("AlbaDeath_8");
		AlbaDeath_9F = PlayerPrefs.GetInt("AlbaDeath_9");
		AlbaDeath_10F = PlayerPrefs.GetInt("AlbaDeath_10");
		AlbaDeath_11F = PlayerPrefs.GetInt("AlbaDeath_11");
		AlbaDeath_12F = PlayerPrefs.GetInt("AlbaDeath_12");
		AlbaDeath_13F = PlayerPrefs.GetInt("AlbaDeath_13");
		AlbaDeath_14F = PlayerPrefs.GetInt("AlbaDeath_14");
		AlbaDeath_15F = PlayerPrefs.GetInt("AlbaDeath_15");
		AlbaDeath_16F = PlayerPrefs.GetInt("AlbaDeath_16");
		AlbaDeath_17F = PlayerPrefs.GetInt("AlbaDeath_17");
		AlbaDeath_18F = PlayerPrefs.GetInt("AlbaDeath_18");
		AlbaDeath_19F = PlayerPrefs.GetInt("AlbaDeath_19");
		AlbaDeath_20F = PlayerPrefs.GetInt("AlbaDeath_20");
		AlbaDeath_21F = PlayerPrefs.GetInt("AlbaDeath_21");
		AlbaDeath_22F = PlayerPrefs.GetInt("AlbaDeath_22");
		AlbaDeath_23F = PlayerPrefs.GetInt("AlbaDeath_23");
		AlbaDeath_24F = PlayerPrefs.GetInt("AlbaDeath_24");
		AlbaDeath_25F = PlayerPrefs.GetInt("AlbaDeath_25");
		AlbaDeath_26F = PlayerPrefs.GetInt("AlbaDeath_26");
		AlbaDeath_27F = PlayerPrefs.GetInt("AlbaDeath_27");
		AlbaDeath_28F = PlayerPrefs.GetInt("AlbaDeath_28");
		AlbaDeath_29F = PlayerPrefs.GetInt("AlbaDeath_29");
		AlbaDeath_30F = PlayerPrefs.GetInt("AlbaDeath_30");
		AlbaDeath_31F = PlayerPrefs.GetInt("AlbaDeath_31");
	}

	public void SuddenDeath()
	{
		return;
		if (allreport.activeInHierarchy || FinalDeath.activeInHierarchy || VacaImage.activeInHierarchy || TutorialCont.Tutorial_Int == 0)
		{
			return;
		}
		if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1 && BarCont.st <= 0f)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		_suddenSound.SuddenDeath_();
		_AudioCont.QuiteSuddenDeath();
		PPlus_money = PlayerPrefs.GetInt("PPlus_money");
		if (ButtonCont.Vibrate_int == 0)
		{
			
		}
		SuddenDeathScreen.SetActive(true);
		Image component = SuddenDeahtImgObj.GetComponent<Image>();
		if (SuddenDeath_N == 0)
		{
			component.sprite = null;
		}
		if (SuddenDeath_N == 1)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_4");
		}
		if (SuddenDeath_N == 2)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_5");
		}
		if (SuddenDeath_N == 3)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_38");
		}
		if (SuddenDeath_N == 4)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_13");
		}
		if (SuddenDeath_N == 5)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_30");
		}
		if (SuddenDeath_N == 6)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_40");
		}
		if (SuddenDeath_N == 7)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_6");
		}
		if (SuddenDeath_N == 9)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_22");
		}
		if (SuddenDeath_N == 10)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_15");
		}
		if (SuddenDeath_N == 11)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_58");
		}
		if (SuddenDeath_N == 12)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_41");
		}
		if (SuddenDeath_N == 13)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_28");
		}
		if (SuddenDeath_N == 14)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_1");
		}
		if (SuddenDeath_N == 15)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_59");
		}
		if (SuddenDeath_N == 16)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_3");
		}
		if (SuddenDeath_N == 17)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_45");
		}
		if (SuddenDeath_N == 18)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_23");
		}
		if (SuddenDeath_N == 19)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_8");
		}
		if (SuddenDeath_N == 20)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_24");
		}
		if (SuddenDeath_N == 21)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_68");
		}
		if (SuddenDeath_N == 22)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_29");
		}
		if (SuddenDeath_N == 23)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_2");
		}
		if (SuddenDeath_N == 24)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_31");
		}
		if (SuddenDeath_N == 25)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_50");
		}
		if (SuddenDeath_N == 26)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_20");
		}
		if (SuddenDeath_N == 27)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_39");
		}
		if (SuddenDeath_N == 28)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_48");
		}
		if (SuddenDeath_N == 29)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_46");
		}
		if (SuddenDeath_N == 30)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_64");
		}
		if (SuddenDeath_N == 31)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_21");
		}
		if (SuddenDeath_N == 32)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_65");
		}
		if (SuddenDeath_N == 33)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_14");
		}
		if (SuddenDeath_N == 34)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_67");
		}
		if (SuddenDeath_N == 35)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_37");
		}
		if (SuddenDeath_N == 36)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_47");
		}
		if (SuddenDeath_N == 37)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_73");
		}
		if (SuddenDeath_N == 38)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_7");
		}
		if (SuddenDeath_N == 39)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_16");
		}
		if (SuddenDeath_N == 40)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_89");
		}
		if (SuddenDeath_N == 41)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_32");
		}
		if (SuddenDeath_N == 42)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_78");
		}
		if (SuddenDeath_N == 43)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_77");
		}
		if (SuddenDeath_N == 44)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_49");
		}
		if (SuddenDeath_N == 45)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_69");
		}
		if (SuddenDeath_N == 46)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_76");
		}
		if (SuddenDeath_N == 47)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_33");
		}
		if (SuddenDeath_N == 48)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_60");
		}
		if (SuddenDeath_N == 49)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_88");
		}
		if (SuddenDeath_N == 50)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_74");
		}
		if (SuddenDeath_N == 51)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_56");
		}
		if (SuddenDeath_N == 52)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_54");
		}
		if (SuddenDeath_N == 53)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_84");
		}
		if (SuddenDeath_N == 54)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_57");
		}
		if (SuddenDeath_N == 55)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_66");
		}
		if (SuddenDeath_N == 56)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_75");
		}
		if (SuddenDeath_N == 57)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_83");
		}
		if (SuddenDeath_N == 58)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_55");
		}
		if (SuddenDeath_N == 59)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_82");
		}
		Text component2 = SuddenDeathText.GetComponent<Text>();
		if (SuddenDeath_N == 0)
		{
			component2.text = string.Format(string.Empty);
		}
		if (SuddenDeath_N == 1)
		{
			component2.text = string.Format("Eeeek! A wild cricket appeared!");
		}
		if (SuddenDeath_N == 2)
		{
			component2.text = string.Format("Water drop from the ceiling");
		}
		if (SuddenDeath_N == 3)
		{
			component2.text = string.Format("Do you know where this dust is coming from?");
		}
		if (SuddenDeath_N == 4)
		{
			component2.text = string.Format("Fire in th hole!!");
		}
		if (SuddenDeath_N == 5)
		{
			component2.text = string.Format("Drosophilas hatche eggs. Oh it's terrible.");
		}
		if (SuddenDeath_N == 6)
		{
			component2.text = string.Format("Today is the payday, but the boss went missing?");
		}
		if (SuddenDeath_N == 7)
		{
			component2.text = string.Format("It tastes like hell.");
		}
		if (SuddenDeath_N == 9)
		{
			component2.text = string.Format("I forgot to turn off the heater!!!!! ");
		}
		if (SuddenDeath_N == 10)
		{
			component2.text = string.Format("Wild Ekans... no, a snake appeared... (Unable to speak...)");
		}
		if (SuddenDeath_N == 11)
		{
			component2.text = string.Format("I think I see someone every night, but I live alone...");
		}
		if (SuddenDeath_N == 12)
		{
			component2.text = string.Format("I wonder how they are doing. It's more than 10years ago.");
		}
		if (SuddenDeath_N == 13)
		{
			component2.text = string.Format("A thief!! Let’s lock the door well.");
		}
		if (SuddenDeath_N == 14)
		{
			component2.text = string.Format("I got F at test!");
		}
		if (SuddenDeath_N == 15)
		{
			component2.text = string.Format("I can hear the classmates talking outside the bathroom.");
		}
		if (SuddenDeath_N == 16)
		{
			component2.text = string.Format("It sucks when you get sick when you're living alone.");
		}
		if (SuddenDeath_N == 17)
		{
			component2.text = string.Format("Even plunger doesn't work!");
		}
		if (SuddenDeath_N == 18)
		{
			component2.text = string.Format("In-Seoul University Selected as One of the Worst!!?");
		}
		if (SuddenDeath_N == 19)
		{
			component2.text = string.Format("Finally I raise a cat! So adorable!");
		}
		if (SuddenDeath_N == 20)
		{
			component2.text = string.Format("House dust mites and dust... On top of that, I have a runny nose... >sniffle<");
		}
		if (SuddenDeath_N == 21)
		{
			component2.text = string.Format("I don't need your advice. Mind your own business.");
		}
		if (SuddenDeath_N == 22)
		{
			component2.text = string.Format("It's ant's house, not mine.");
		}
		if (SuddenDeath_N == 23)
		{
			component2.text = string.Format("No money? It’s a game over. Capitalism is cold-blooded.");
		}
		if (SuddenDeath_N == 24)
		{
			component2.text = string.Format("I came back from the vacation, and my major disappeared from the department?!! What do I do now?");
		}
		if (SuddenDeath_N == 25)
		{
			component2.text = string.Format("Fermentation is not science. It just means upset stomach.");
		}
		if (SuddenDeath_N == 26)
		{
			component2.text = string.Format("Sliding in the bathroom!!! Thank goodness, I didn't die!");
		}
		if (SuddenDeath_N == 27)
		{
			component2.text = string.Format("108 missed phone calls... I was supposed to do a presentation today...");
		}
		if (SuddenDeath_N == 28)
		{
			component2.text = string.Format("The pain of parting is so hurt.");
		}
		if (SuddenDeath_N == 29)
		{
			component2.text = string.Format("hought it was my house, but it was actually the cockroach's’ house.");
		}
		if (SuddenDeath_N == 30)
		{
			component2.text = string.Format("I actually have a hobby that I can’t tell the others.");
		}
		if (SuddenDeath_N == 31)
		{
			component2.text = string.Format("I stumped my pinky toe to the corner of the bed!!!");
		}
		if (SuddenDeath_N == 32)
		{
			component2.text = string.Format("The best part of living alone is drinking all night!");
		}
		if (SuddenDeath_N == 33)
		{
			component2.text = string.Format("I've been living off of convenience store lunchbox... It’s really getting old.");
		}
		if (SuddenDeath_N == 34)
		{
			component2.text = string.Format("Why does it seem like I didn't get paid properly??");
		}
		if (SuddenDeath_N == 35)
		{
			component2.text = string.Format("The road is a scary place... Revenge driving is scary....");
		}
		if (SuddenDeath_N == 36)
		{
			component2.text = string.Format("I am glad to save money for eggs!!!");
		}
		if (SuddenDeath_N == 37)
		{
			component2.text = string.Format("My pet was a natural monument? No way.");
		}
		if (SuddenDeath_N == 38)
		{
			component2.text = string.Format("My head is boiling... I’m too weak...");
		}
		if (SuddenDeath_N == 39)
		{
			component2.text = string.Format("Brain on!! 2+2x2=8??!");
		}
		if (SuddenDeath_N == 40)
		{
			component2.text = string.Format("It's cold... Both my physical strength and mental strength are at their limit!");
		}
		if (SuddenDeath_N == 41)
		{
			component2.text = string.Format("I could not pay my rent, and I was immediately kicked out.");
		}
		if (SuddenDeath_N == 42)
		{
			component2.text = string.Format("M... Mom and Dad? Please let me know in advance when you’re going to come.");
		}
		if (SuddenDeath_N == 43)
		{
			component2.text = string.Format("I am Hermione in my school.");
		}
		if (SuddenDeath_N == 44)
		{
			component2.text = string.Format("I'm so lonely. This city is too cold.");
		}
		if (SuddenDeath_N == 45)
		{
			component2.text = string.Format("Found plastic in pizza!");
		}
		if (SuddenDeath_N == 46)
		{
			component2.text = string.Format("Don't you stop shooting missiles?");
		}
		if (SuddenDeath_N == 47)
		{
			component2.text = string.Format("A centipede!!! How many legs do you have?");
		}
		if (SuddenDeath_N == 48)
		{
			component2.text = string.Format("I am chosen to go on a trip to the underwater palace!");
		}
		if (SuddenDeath_N == 49)
		{
			component2.text = string.Format("I am chosen to take a walk to the heaven...");
		}
		if (SuddenDeath_N == 50)
		{
			component2.text = string.Format("No. Hot. Water.");
		}
		if (SuddenDeath_N == 51)
		{
			component2.text = string.Format("What is that in the mirror?! A ghost?!");
		}
		if (SuddenDeath_N == 52)
		{
			component2.text = string.Format("I had a terrible nightmare. Someone sing me a lullaby...");
		}
		if (SuddenDeath_N == 53)
		{
			component2.text = string.Format("Food shortage!! Who ate it all?! (I did.)");
		}
		if (SuddenDeath_N == 54)
		{
			component2.text = string.Format("My feet stinks... Deodorant is useless...");
		}
		if (SuddenDeath_N == 55)
		{
			component2.text = string.Format("Guys, My house is not hotel..");
		}
		if (SuddenDeath_N == 56)
		{
			component2.text = string.Format("The smell of dirty sewers! It's even worse today!!");
		}
		if (SuddenDeath_N == 57)
		{
			component2.text = string.Format("zzZ... This semester is doomed... More like my life is doomed.");
		}
		if (SuddenDeath_N == 58)
		{
			component2.text = string.Format("My reports are deleted all! This must bedream!");
		}
		if (SuddenDeath_N == 59)
		{
			component2.text = string.Format("Boiler is broken and I slept like polar bear.");
		}
		Money_T.GetComponent<Text>().text = string.Format("{0:n0}", SuddenDeahtPlusGem);
		CountDeahtCont();
		SavaDehat_Num();
		PlayerPrefs.SetInt("Circle_frust", 1);
		PlayerPrefs.SetInt("Circle_main", 1);
		Circle_frust = PlayerPrefs.GetInt("Circle_frust");
		Circle_main = PlayerPrefs.GetInt("Circle_main");
		Circle_main_obj.SetActive(true);
	}

	public void ReasonSuddenDeath()
	{
		if (allreport.activeInHierarchy || FinalDeath.activeInHierarchy || VacaImage.activeInHierarchy || TutorialCont.Tutorial_Int == 0)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		_suddenSound.SuddenDeath_();
		_AudioCont.QuiteSuddenDeath();
		PPlus_money = PlayerPrefs.GetInt("PPlus_money");
		if (ButtonCont.Vibrate_int == 0)
		{
			
		}
		SuddenDeathScreen.SetActive(true);
		Image component = SuddenDeahtImgObj.GetComponent<Image>();
		if (ReasonDeath_N == 0)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_3");
		}
		if (ReasonDeath_N == 2)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_1");
		}
		if (ReasonDeath_N == 3)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_3");
		}
		if (ReasonDeath_N == 4)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_8");
		}
		if (ReasonDeath_N == 5)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_24");
		}
		if (ReasonDeath_N == 6)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_2");
		}
		if (ReasonDeath_N == 7)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_37");
		}
		if (ReasonDeath_N == 8)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_47");
		}
		if (ReasonDeath_N == 9)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_73");
		}
		if (ReasonDeath_N == 10)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_7");
		}
		if (ReasonDeath_N == 11)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_16");
		}
		if (ReasonDeath_N == 12)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_89");
		}
		if (ReasonDeath_N == 13)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_32");
		}
		if (ReasonDeath_N == 14)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_60");
		}
		if (ReasonDeath_N == 15)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_88");
		}
		Text component2 = SuddenDeathText.GetComponent<Text>();
		if (ReasonDeath_N == 0)
		{
			component2.text = string.Format(string.Empty);
		}
		if (ReasonDeath_N == 2)
		{
			component2.text = string.Format("I got F at test!");
		}
		if (ReasonDeath_N == 3)
		{
			component2.text = string.Format("It's cold... Both my physical strength and mental strength are at their limit!");
		}
		if (ReasonDeath_N == 4)
		{
			component2.text = string.Format("Finally I raise a cat! So adorable!");
		}
		if (ReasonDeath_N == 5)
		{
			component2.text = string.Format("House dust mites and dust... On top of that, I have a runny nose... >sniffle<");
		}
		if (ReasonDeath_N == 6)
		{
			component2.text = string.Format("No money? It’s a game over. Capitalism is cold-blooded.");
		}
		if (ReasonDeath_N == 7)
		{
			component2.text = string.Format("The road is a scary place... Revenge driving is scary....");
		}
		if (ReasonDeath_N == 8)
		{
			component2.text = string.Format("I am glad to save money for eggs!!");
		}
		if (ReasonDeath_N == 9)
		{
			component2.text = string.Format("My pet was a natural monument? No way.");
		}
		if (ReasonDeath_N == 10)
		{
			component2.text = string.Format("My head is boiling... I’m too weak...");
		}
		if (ReasonDeath_N == 11)
		{
			component2.text = string.Format("Brain on! 2+2x2=8??");
		}
		if (ReasonDeath_N == 12)
		{
			component2.text = string.Format("I'm so sick. I don't have power to talk.");
		}
		if (ReasonDeath_N == 13)
		{
			component2.text = string.Format("The rent is too expensive. It's too much.");
		}
		if (ReasonDeath_N == 14)
		{
			component2.text = string.Format("I am chosen to go on a trip to the underwater palace!");
		}
		if (ReasonDeath_N == 15)
		{
			component2.text = string.Format("I am chosen to take a walk to the heaven...");
		}
		if (ReasonDeath_N != 2 && ReasonDeath_N != 3 && ReasonDeath_N != 6)
		{
			Money_T.GetComponent<Text>().text = string.Format("{0}", SuddenDeahtPlusGem);
			MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[0];
		}
		if (ReasonDeath_N == 2)
		{
			Money_T.GetComponent<Text>().text = string.Format("{0:n0}G", SuddenDeahtPlusmoney);
			MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[1];
		}
		if (ReasonDeath_N == 3)
		{
			Money_T.GetComponent<Text>().text = string.Format("{0:n0}G", SuddenDeahtPlusmoney);
			MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[1];
		}
		if (ReasonDeath_N == 6)
		{
			Money_T.GetComponent<Text>().text = string.Format("{0:n0}G", SuddenDeahtPlusmoney);
			MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[1];
		}
		CountDeahtCont();
		SavaDehat_Num();
		PlayerPrefs.SetInt("Circle_frust", 1);
		PlayerPrefs.SetInt("Circle_main", 1);
		Circle_frust = PlayerPrefs.GetInt("Circle_frust");
		Circle_main = PlayerPrefs.GetInt("Circle_main");
		Circle_main_obj.SetActive(true);
	}

	public void OtherSuddenDeath()
	{
		if (allreport.activeInHierarchy || FinalDeath.activeInHierarchy || VacaImage.activeInHierarchy || TutorialCont.Tutorial_Int == 0)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1 && BarCont.st <= 0f)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		_suddenSound.SuddenDeath_();
		_AudioCont.QuiteSuddenDeath();
		PPlus_money = PlayerPrefs.GetInt("PPlus_money");
		if (ButtonCont.Vibrate_int == 0)
		{
			
		}
		SuddenDeathScreen.SetActive(true);
		Image component = SuddenDeahtImgObj.GetComponent<Image>();
		if (OtherDeath_N == 19)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_9");
		}
		if (OtherDeath_N == 18)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_10");
		}
		if (OtherDeath_N == 13)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_11");
		}
		if (OtherDeath_N == 29)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_12");
		}
		if (OtherDeath_N == 1)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_17");
		}
		if (OtherDeath_N == 21)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_18");
		}
		if (OtherDeath_N == 3)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_19");
		}
		if (OtherDeath_N == 31)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_25");
		}
		if (OtherDeath_N == 28)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_26");
		}
		if (OtherDeath_N == 26)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_27");
		}
		if (OtherDeath_N == 6)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_34");
		}
		if (OtherDeath_N == 2)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_35");
		}
		if (OtherDeath_N == 20)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_36");
		}
		if (OtherDeath_N == 10)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_42");
		}
		if (OtherDeath_N == 16)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_43");
		}
		if (OtherDeath_N == 23)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_44");
		}
		if (OtherDeath_N == 17)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_51");
		}
		if (OtherDeath_N == 14)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_52");
		}
		if (OtherDeath_N == 30)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_53");
		}
		if (OtherDeath_N == 25)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_61");
		}
		if (OtherDeath_N == 8)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_62");
		}
		if (OtherDeath_N == 9)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_63");
		}
		if (OtherDeath_N == 4)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_70");
		}
		if (OtherDeath_N == 24)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_71");
		}
		if (OtherDeath_N == 5)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_72");
		}
		if (OtherDeath_N == 7)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_79");
		}
		if (OtherDeath_N == 15)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_80");
		}
		if (OtherDeath_N == 22)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_81");
		}
		if (OtherDeath_N == 11)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_85");
		}
		if (OtherDeath_N == 12)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_86");
		}
		if (OtherDeath_N == 27)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_87");
		}
		Text component2 = SuddenDeathText.GetComponent<Text>();
		if (OtherDeath_N == 0)
		{
			component2.text = string.Format(string.Empty);
		}
		if (OtherDeath_N == 19)
		{
			component2.text = string.Format("Why am I getting fired?! I’m getting fired by text message??");
		}
		if (OtherDeath_N == 18)
		{
			component2.text = string.Format("Why they keep pooping on my head?!");
		}
		if (OtherDeath_N == 13)
		{
			component2.text = string.Format("My Leaflets are fluttering!!");
		}
		if (OtherDeath_N == 29)
		{
			component2.text = string.Format("Doesn’t seem like an average kid!");
		}
		if (OtherDeath_N == 1)
		{
			component2.text = string.Format("We don't sale dimsum...");
		}
		if (OtherDeath_N == 21)
		{
			component2.text = string.Format("Someone dropped the hamburger on the floor!!");
		}
		if (OtherDeath_N == 3)
		{
			component2.text = string.Format("Trash in the trash can! I'm not a trash can.");
		}
		if (OtherDeath_N == 31)
		{
			component2.text = string.Format("Coin Rush! All coins?!");
		}
		if (OtherDeath_N == 28)
		{
			component2.text = string.Format("Only my appearance looks like a thief, I'm not really.");
		}
		if (OtherDeath_N == 26)
		{
			component2.text = string.Format("Ugh, drunk much? Here he comes again.");
		}
		if (OtherDeath_N == 6)
		{
			component2.text = string.Format("Another thief! I’ll get him next time.");
		}
		if (OtherDeath_N == 2)
		{
			component2.text = string.Format("A customer left after touching and making a mess with all the clothes!!");
		}
		if (OtherDeath_N == 20)
		{
			component2.text = string.Format("A rude customer appeared! My head hurts already.");
		}
		if (OtherDeath_N == 10)
		{
			component2.text = string.Format("Other part timers are bring super mean. I cry again.");
		}
		if (OtherDeath_N == 16)
		{
			component2.text = string.Format("Cool hot black coffee doesn't exist in this world sir.");
		}
		if (OtherDeath_N == 23)
		{
			component2.text = string.Format("I gave a customer a shower... with coffee.");
		}
		if (OtherDeath_N == 17)
		{
			component2.text = string.Format("Mistake! Big mistake! The manager doesn’t look very happy today.");
		}
		if (OtherDeath_N == 14)
		{
			component2.text = string.Format("Hey, you there, the steak is salty. Take it back.");
		}
		if (OtherDeath_N == 30)
		{
			component2.text = string.Format("I spilled all plates on the trolley");
		}
		if (OtherDeath_N == 25)
		{
			component2.text = string.Format("I almost die under boxes.");
		}
		if (OtherDeath_N == 8)
		{
			component2.text = string.Format("I was hit by a backing truck while being careless.");
		}
		if (OtherDeath_N == 9)
		{
			component2.text = string.Format("I twisted my back for overworking. I spent all my money on pain relief patches.");
		}
		if (OtherDeath_N == 4)
		{
			component2.text = string.Format("Please calm down sir..");
		}
		if (OtherDeath_N == 24)
		{
			component2.text = string.Format("I was stung by a reprimand.");
		}
		if (OtherDeath_N == 5)
		{
			component2.text = string.Format("The eyes of the manager who is watching my every move... I can feel it with the back of my head.");
		}
		if (OtherDeath_N == 7)
		{
			component2.text = string.Format("Leaving footstep on the... cement.");
		}
		if (OtherDeath_N == 15)
		{
			component2.text = string.Format("Something exploded! The unfortunate thing is that I was standing there.");
		}
		if (OtherDeath_N == 22)
		{
			component2.text = string.Format("I keep working and working, but there is no end to it.");
		}
		if (OtherDeath_N == 12)
		{
			component2.text = string.Format("I came in time, but no student came to class.");
		}
		if (OtherDeath_N == 11)
		{
			component2.text = string.Format("Student keeps asking what I don't know. I can't keep pretending like I know everything.");
		}
		if (OtherDeath_N == 27)
		{
			component2.text = string.Format("My student got a 0 on the test. Maybe I actually suck at teaching.");
		}
		Money_T.GetComponent<Text>().text = string.Format("{0}", SuddenDeahtPlusGem);
		MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[0];
		CountDeahtCont();
		SavaDehat_Num();
		PlayerPrefs.SetInt("Circle_frust", 1);
		PlayerPrefs.SetInt("Circle_main", 1);
		Circle_frust = PlayerPrefs.GetInt("Circle_frust");
		Circle_main = PlayerPrefs.GetInt("Circle_main");
		Circle_main_obj.SetActive(true);
	}

	public void AgainNAgainDeath()
	{
		//USELESS FEATURE GET RID OF il return before it can fuck shit up
		return;
		if (allreport.activeInHierarchy || FinalDeath.activeInHierarchy || VacaImage.activeInHierarchy || TutorialCont.Tutorial_Int == 0)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1 && BarCont.st <= 0f)
		{
			SuddenDeathScreen.SetActive(false);
			return;
		}
		_suddenSound.SuddenDeath_();
		_AudioCont.QuiteSuddenDeath();
		PPlus_money = PlayerPrefs.GetInt("PPlus_money");
		if (ButtonCont.Vibrate_int == 0)
		{
			
		}
		SuddenDeathScreen.SetActive(true);
		Image component = SuddenDeahtImgObj.GetComponent<Image>();
		if (ReasonDeath_N == 2)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_1");
		}
		if (ReasonDeath_N == 3)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_3");
		}
		if (ReasonDeath_N == 6)
		{
			component.sprite = Resources.Load<Sprite>("SadEnding/_2");
		}
		Text component2 = SuddenDeathText.GetComponent<Text>();
		if (ReasonDeath_N == 2)
		{
			component2.text = string.Format("I got F at test!");
		}
		if (ReasonDeath_N == 3)
		{
			component2.text = string.Format("It's cold... Both my physical strength and mental strength are at their limit!");
		}
		if (ReasonDeath_N == 6)
		{
			component2.text = string.Format("No money? It’s a game over. Capitalism is cold-blooded.");
		}
		Money_T.GetComponent<Text>().text = string.Format("{0:n0}G", SuddenDeahtPlusmoney);
		MoneyIcon.GetComponent<Image>().sprite = MoneyIcon_img[1];
		SavaDehat_Num();
	}

	public void usegem()
	{
		if (scene_controll.gem >= 3)
		{
			PlayerPrefs.SetInt("Testcomplete", 0);
			scene_controll.gem -= 3;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			SuddenDeathScreen.SetActive(false);
			PlayerPrefs.SetInt("Rebirth_OK", 1);
			Debug.Log("SuddenDeahtPlusmoney" + SuddenDeahtPlusmoney);
			scene_controll.money += SuddenDeahtPlusmoney;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			if (ReportCont.Grade_N == 1)
			{
				if (TimeCont.Grade == 4 && TimeCont.OneMonth == 1 && TimeCont.OneSemes == 1)
				{
					Death_14F = 0;
					return;
				}
				OtherSuddenDeath();
				ReportCont.Grade_N = 0;
				return;
			}
			_AudioCont.Playagain();
			if (ReasonDeath_N == 3)
			{
				BarCont.hp = 10f;
				BarCont.mp = 10f;
				BarCont._int = 10f;
				BarCont.happy = 10f;
				PlayerPrefs.SetFloat("hp", BarCont.hp);
				PlayerPrefs.SetFloat("mp", BarCont.mp);
				PlayerPrefs.SetFloat("int", BarCont._int);
				PlayerPrefs.SetFloat("happy", BarCont.happy);
				BarCont.death16 = false;
			}
			if (ReasonDeath_N == 2)
			{
				_TextUP.PlusMONTH();
				_Timecont.GetComponent<TimeCont>().SetTimeText();
				PlayerPrefs.SetFloat("st", 100f);
				BarCont.st = PlayerPrefs.GetFloat("st");
				Debug.Log("onemonth=" + TimeCont.OneMonth);
				GameObject.Find("FeeCont").GetComponent<FeeCont>().death23_closemonth();
			}
			if (ReasonDeath_N == 6)
			{
				if (MonthlyReport.activeInHierarchy)
				{
					GameObject.Find("FeeCont").GetComponent<FeeCont>().death23_closemonth();
				}
				_Timecont.GetComponent<TimeCont>().SetTimeText();
				PlayerPrefs.SetFloat("st", 100f);
				BarCont.st = PlayerPrefs.GetFloat("st");
			}
			_reportcont = GameObject.Find("ReportCont");
			if (PlayerPrefs.GetInt("score1-1") != 0 && TimeCont.OneMonth == 4)
			{
				GameObject gameObject = GameObject.Find("FeeCont");
				gameObject.GetComponent<FeeCont>().FeeReport();
			}
			_Timecont.GetComponent<TimeCont>().ShowVacaSignImage();
			if (Lovercont.Phone == 2 && (TimeCont.OneMonth == 3 || TimeCont.OneMonth == 5 || TimeCont.OneMonth == 9 || TimeCont.OneMonth == 11))
			{
				GameObject.Find("Lover_window").GetComponent<Lovercont>().NewLoverOpen();
			}
		}
		else
		{
			Nogem.SetActive(true);
		}
	}

	public void CloseNogem()
	{
		Nogem.SetActive(false);
	}

	public void BtnRebirth()
	{
		SuddenDeathScreen.SetActive(false);
		SaveCount();
		PlayerPrefs.SetInt("Rebirth_OK", 1);
		scene_controll.money += SuddenDeahtPlusmoney;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		SuddenDeahtPlusmoney = 0;
		BarCont.death16 = false;
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
	}

	public void SaveCount()
	{
		PlayerPrefs.SetInt("Death_Count", Death_Count);
	}

	public void Reallyrebirth()
	{
		Really.SetActive(true);
	}

	public void NOrebirth()
	{
		Really.SetActive(false);
	}

	public void SetFalseButton()
	{
		if (Death_1F == 1 && FurnCont.Bed_N == 1)
		{
			GameObject.Find("Death_1").SetActive(false);
		}
		if (Death_7F == 1 && FurnCont.Kitchen_N == 2 && RoomCont.Room_N == 1)
		{
			GameObject.Find("Death_7").SetActive(false);
		}
		if (Death_33F == 1 && FurnCont.Kitchen_N == 4)
		{
			GameObject.Find("Death_33").SetActive(false);
		}
		if (Death_4F == 1 && FurnCont.Kitchen_N == 3)
		{
			GameObject.Find("Death_4").SetActive(false);
		}
		if (Death_31F == 1 && FurnCont.Bed_N == 8 && RoomCont.Room_N == 3)
		{
			GameObject.Find("Death_31").gameObject.SetActive(false);
		}
		if (Death_26F == 1 && FurnCont.Toilet_N == 6)
		{
			GameObject.Find("Death_26").SetActive(false);
		}
		if (Death_22F == 1 && FurnCont.Kitchen_N == 10)
		{
			GameObject.Find("Death_22").SetActive(false);
		}
		if (Death_13F == 1 && FurnCont.Bed_N == 9)
		{
			GameObject.Find("Death_13").SetActive(false);
		}
		if (Death_5F == 1 && FurnCont.Kitchen_N == 11 && RoomCont.Room_N == 4)
		{
			GameObject.Find("Death_5").SetActive(false);
		}
		if (Death_3F == 1 && FurnCont.Bed_N == 13)
		{
			GameObject.Find("Death_3").SetActive(false);
		}
		if (Death_27F == 1 && FurnCont.Bed_N == 14 && RoomCont.Room_N == 5)
		{
			GameObject.Find("Death_27").SetActive(false);
		}
		if (Death_47F == 1 && FurnCont.Toilet_N == 12)
		{
			GameObject.Find("Death_47").SetActive(false);
		}
		if (Death_17F == 1 && FurnCont.Toilet_N == 15)
		{
			GameObject.Find("Death_17").SetActive(false);
		}
		if (Death_29F == 1 && FurnCont.Kitchen_N == 16)
		{
			GameObject.Find("Death_29").SetActive(false);
		}
		if (Death_25F == 1 && FurnCont.Kitchen_N == 17 && RoomCont.Room_N == 6)
		{
			GameObject.Find("Death_25").SetActive(false);
		}
		if (Death_54F == 1 && FurnCont.Kitchen_N == 19)
		{
			GameObject.Find("Death_54").SetActive(false);
		}
		if (Death_58F == 1 && FurnCont.Bed_N == 18)
		{
			GameObject.Find("Death_58").SetActive(false);
		}
		if (Death_51F == 1 && FurnCont.Toilet_N == 20 && RoomCont.Room_N == 7)
		{
			GameObject.Find("Death_51").SetActive(false);
		}
		if (Death_52F == 1 && FurnCont.Bed_N == 19)
		{
			GameObject.Find("Death_52").SetActive(false);
		}
		if (Death_30F == 1 && FurnCont.Bed_N == 21)
		{
			GameObject.Find("Death_30").SetActive(false);
		}
		if (Death_32F == 1 && FurnCont.Kitchen_N == 22)
		{
			GameObject.Find("Death_32").SetActive(false);
		}
		if (Death_55F == 1 && FurnCont.Bed_N == 23 && RoomCont.Room_N == 8)
		{
			GameObject.Find("Death_55").SetActive(false);
		}
		if (Death_50F == 1 && FurnCont.Toilet_N == 3)
		{
			GameObject.Find("Death_50").SetActive(false);
		}
		if (Death_56F == 1 && FurnCont.Toilet_N == 23 && RoomCont.Room_N == 8)
		{
			GameObject.Find("Death_56").SetActive(false);
		}
		if (Death_43F == 1 && FurnCont.Bed_N == 26 && RoomCont.Room_N == 9)
		{
			GameObject.Find("Death_43").SetActive(false);
		}
		if (Death_46F == 1 && FurnCont.Kitchen_N == 25)
		{
			GameObject.Find("Death_46").SetActive(false);
		}
		if (Death_59F == 1 && FurnCont.Bed_N == 27)
		{
			GameObject.Find("Death_59").SetActive(false);
		}
		if (Death_57F == 1 && FurnCont.Bed_N == 28)
		{
			GameObject.Find("Death_57").SetActive(false);
		}
		if (Death_53F == 1 && FurnCont.Kitchen_N == 29 && RoomCont.Room_N == 10)
		{
			GameObject.Find("Death_53").SetActive(false);
		}
		if (Death_40F == 1 && FurnCont.Bed_N == 36)
		{
			GameObject.Find("Death_40").SetActive(false);
		}
	}

	public void False_1()
	{
		if (Death_1F == 1 && FurnCont.Bed_N == 1)
		{
			GameObject.Find("Death_1").SetActive(false);
		}
	}

	public void False_7()
	{
		if (Death_7F == 1 && FurnCont.Kitchen_N == 2 && RoomCont.Room_N == 1)
		{
			GameObject.Find("Death_7").SetActive(false);
		}
	}

	public void False_33()
	{
		if (Death_33F == 1 && FurnCont.Kitchen_N == 4)
		{
			GameObject.Find("Death_33").SetActive(false);
		}
	}

	public void False_4()
	{
		if (Death_4F == 1 && FurnCont.Kitchen_N == 3)
		{
			GameObject.Find("Death_4").SetActive(false);
		}
	}

	public void False_31()
	{
		if (Death_31F == 1 && FurnCont.Bed_N == 8 && RoomCont.Room_N == 3)
		{
			GameObject.Find("Death_31").gameObject.SetActive(false);
		}
	}

	public void False_26()
	{
		if (Death_26F == 1 && FurnCont.Toilet_N == 6)
		{
			GameObject.Find("Death_26").SetActive(false);
		}
	}

	public void False_22()
	{
		if (Death_22F == 1 && FurnCont.Kitchen_N == 10)
		{
			GameObject.Find("Death_22").SetActive(false);
		}
	}

	public void False_13()
	{
		if (Death_13F == 1 && FurnCont.Bed_N == 9)
		{
			GameObject.Find("Death_13").SetActive(false);
		}
	}

	public void False_5()
	{
		if (Death_5F == 1 && FurnCont.Kitchen_N == 11 && RoomCont.Room_N == 4)
		{
			GameObject.Find("Death_5").SetActive(false);
		}
	}

	public void False_3()
	{
		if (Death_3F == 1 && FurnCont.Bed_N == 13)
		{
			GameObject.Find("Death_3").SetActive(false);
		}
	}

	public void False_27()
	{
		if (Death_27F == 1 && FurnCont.Bed_N == 14 && RoomCont.Room_N == 5)
		{
			GameObject.Find("Death_27").SetActive(false);
		}
	}

	public void False_47()
	{
		if (Death_47F == 1 && FurnCont.Toilet_N == 12)
		{
			GameObject.Find("Death_47").SetActive(false);
		}
	}

	public void False_17()
	{
		if (Death_17F == 1 && FurnCont.Toilet_N == 15)
		{
			GameObject.Find("Death_17").SetActive(false);
		}
	}

	public void False_29()
	{
		if (Death_29F == 1 && FurnCont.Kitchen_N == 16)
		{
			GameObject.Find("Death_29").SetActive(false);
		}
	}

	public void False_25()
	{
		if (Death_25F == 1 && FurnCont.Kitchen_N == 17 && RoomCont.Room_N == 6)
		{
			GameObject.Find("Death_25").SetActive(false);
		}
	}

	public void False_54()
	{
		if (Death_54F == 1 && FurnCont.Kitchen_N == 19)
		{
			GameObject.Find("Death_54").SetActive(false);
		}
	}

	public void False_58()
	{
		if (Death_58F == 1 && FurnCont.Bed_N == 18)
		{
			GameObject.Find("Death_58").SetActive(false);
		}
	}

	public void False_51()
	{
		if (Death_51F == 1 && FurnCont.Toilet_N == 20 && RoomCont.Room_N == 7)
		{
			GameObject.Find("Death_51").SetActive(false);
		}
	}

	public void False_52()
	{
		if (Death_52F == 1 && FurnCont.Bed_N == 19)
		{
			GameObject.Find("Death_52").SetActive(false);
		}
	}

	public void False_30()
	{
		if (Death_30F == 1 && FurnCont.Bed_N == 21)
		{
			GameObject.Find("Death_30").SetActive(false);
		}
	}

	public void False_32()
	{
		if (Death_32F == 1 && FurnCont.Kitchen_N == 22)
		{
			GameObject.Find("Death_32").SetActive(false);
		}
	}

	public void False_55()
	{
		if (Death_55F == 1 && FurnCont.Bed_N == 23 && RoomCont.Room_N == 8)
		{
			GameObject.Find("Death_55").SetActive(false);
		}
	}

	public void False_50()
	{
		if (Death_50F == 1 && FurnCont.Toilet_N == 3)
		{
			GameObject.Find("Death_50").SetActive(false);
		}
	}

	public void False_56()
	{
		if (Death_56F == 1 && FurnCont.Toilet_N == 23 && RoomCont.Room_N == 8)
		{
			GameObject.Find("Death_56").SetActive(false);
		}
	}

	public void False_43()
	{
		if (Death_43F == 1 && FurnCont.Bed_N == 26 && RoomCont.Room_N == 9)
		{
			GameObject.Find("Death_43").SetActive(false);
		}
	}

	public void False_46()
	{
		if (Death_46F == 1 && FurnCont.Kitchen_N == 25)
		{
			GameObject.Find("Death_46").SetActive(false);
		}
	}

	public void False_59()
	{
		if (Death_59F == 1 && FurnCont.Bed_N == 27)
		{
			GameObject.Find("Death_59").SetActive(false);
		}
	}

	public void False_57()
	{
		if (Death_57F == 1 && FurnCont.Bed_N == 28)
		{
			GameObject.Find("Death_57").SetActive(false);
		}
	}

	public void False_53()
	{
		if (Death_53F == 1 && FurnCont.Kitchen_N == 29 && RoomCont.Room_N == 10)
		{
			GameObject.Find("Death_53").SetActive(false);
		}
	}

	public void False_40()
	{
		if (Death_40F == 1 && FurnCont.Bed_N == 36)
		{
			GameObject.Find("Death_40").SetActive(false);
		}
	}
}
