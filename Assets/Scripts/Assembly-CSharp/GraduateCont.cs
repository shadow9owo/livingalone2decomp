using UnityEngine;
using UnityEngine.UI;

public class GraduateCont : MonoBehaviour
{
	public GameObject GraduEndingScreen;

	public static int Gradu_N;

	public GameObject Gradu_ImgObj;

	public Transform Gradu_Text;

	public Transform Gradu_Title_T;

	public Transform GraduMoney;

	public static int GraduDeathPlusMoney;

	public static int EndingCount;

	public static int GraduEnd_OK;

	public static int Class_N;

	public GameObject WhiteImg;

	public GameObject Circle_main_obj_gradu;

	public TimeCont _TimeCont;

	public static int GraduBonus;

	public void TESTGRADU()
	{
		GraduEndingScreen.SetActive(true);
	}

	private void Start()
	{
		EndingCount = PlayerPrefs.GetInt("EndingCount");
		GraduEnd_OK = PlayerPrefs.GetInt("GraduEnd_OK");
		S2_4.conviAlba = PlayerPrefs.GetInt("conviAlba");
		S2_4.cafeAlba = PlayerPrefs.GetInt("cafeAlba");
		S2_4.takbaeAlba = PlayerPrefs.GetInt("takbaeAlba");
		S2_4.factoryAlba = PlayerPrefs.GetInt("factoryAlba");
		S2_4.studyAlba = PlayerPrefs.GetInt("studyAlba");
		s2_3.Gradu_N0 = PlayerPrefs.GetInt("Gradu_N0");
		s2_3.Gradu_N1 = PlayerPrefs.GetInt("Gradu_N1");
		s2_3.Gradu_N2 = PlayerPrefs.GetInt("Gradu_N2");
		s2_3.Gradu_N3 = PlayerPrefs.GetInt("Gradu_N3");
		s2_3.Gradu_N4 = PlayerPrefs.GetInt("Gradu_N4");
		s2_3.Gradu_N5 = PlayerPrefs.GetInt("Gradu_N5");
		s2_3.Gradu_N6 = PlayerPrefs.GetInt("Gradu_N6");
		s2_3.Gradu_N7 = PlayerPrefs.GetInt("Gradu_N7");
		s2_3.Gradu_N8 = PlayerPrefs.GetInt("Gradu_N8");
		s2_3.Gradu_N9 = PlayerPrefs.GetInt("Gradu_N9");
		s2_3.Gradu_N10 = PlayerPrefs.GetInt("Gradu_N10");
		s2_3.Gradu_N11 = PlayerPrefs.GetInt("Gradu_N11");
		s2_3.Gradu_N12 = PlayerPrefs.GetInt("Gradu_N12");
		s2_3.Gradu_N13 = PlayerPrefs.GetInt("Gradu_N13");
		s2_3.Gradu_N14 = PlayerPrefs.GetInt("Gradu_N14");
		s2_3.Gradu_N15 = PlayerPrefs.GetInt("Gradu_N15");
		s2_3.Gradu_N16 = PlayerPrefs.GetInt("Gradu_N16");
		s2_3.Gradu_N17 = PlayerPrefs.GetInt("Gradu_N17");
		s2_3.Gradu_N18 = PlayerPrefs.GetInt("Gradu_N18");
		s2_3.Gradu_N19 = PlayerPrefs.GetInt("Gradu_N19");
		s2_3.Gradu_N20 = PlayerPrefs.GetInt("Gradu_N20");
		s2_3.Gradu_N21 = PlayerPrefs.GetInt("Gradu_N21");
		s2_3.Gradu_N22 = PlayerPrefs.GetInt("Gradu_N22");
		s2_3.Gradu_N23 = PlayerPrefs.GetInt("Gradu_N23");
		s2_3.Gradu_N24 = PlayerPrefs.GetInt("Gradu_N24");
		s2_3.Gradu_N25 = PlayerPrefs.GetInt("Gradu_N25");
		s2_3.Gradu_N26 = PlayerPrefs.GetInt("Gradu_N26");
		s2_3.Gradu_N27 = PlayerPrefs.GetInt("Gradu_N27");
		s2_3.Gradu_N28 = PlayerPrefs.GetInt("Gradu_N28");
		s2_3.Gradu_N29 = PlayerPrefs.GetInt("Gradu_N29");
		s2_3.Gradu_N30 = PlayerPrefs.GetInt("Gradu_N30");
		s2_3.Gradu_N31 = PlayerPrefs.GetInt("Gradu_N31");
		s2_3.Gradu_N32 = PlayerPrefs.GetInt("Gradu_N32");
		s2_3.Gradu_N33 = PlayerPrefs.GetInt("Gradu_N33");
		s2_3.Gradu_N34 = PlayerPrefs.GetInt("Gradu_N34");
		s2_3.Gradu_N35 = PlayerPrefs.GetInt("Gradu_N35");
		s2_3.Gradu_N36 = PlayerPrefs.GetInt("Gradu_N36");
		s2_3.Gradu_N37 = PlayerPrefs.GetInt("Gradu_N37");
		s2_3.Gradu_N38 = PlayerPrefs.GetInt("Gradu_N38");
		s2_3.Gradu_N39 = PlayerPrefs.GetInt("Gradu_N39");
		s2_3.Gradu_N40 = PlayerPrefs.GetInt("Gradu_N40");
		s2_3.Gradu_N41 = PlayerPrefs.GetInt("Gradu_N41");
		if (S2_4.M_class > S2_4.Y_class && S2_4.M_class > S2_4.S_class && S2_4.M_class > S2_4.E_class)
		{
			Class_N = 1;
		}
		else if (S2_4.E_class > S2_4.M_class && S2_4.E_class > S2_4.S_class && S2_4.E_class > S2_4.Y_class)
		{
			Class_N = 2;
		}
		else if (S2_4.Y_class > S2_4.M_class && S2_4.Y_class > S2_4.S_class && S2_4.Y_class > S2_4.E_class)
		{
			Class_N = 3;
		}
		else if (S2_4.S_class > S2_4.M_class && S2_4.S_class > S2_4.Y_class && S2_4.S_class > S2_4.E_class)
		{
			Class_N = 4;
		}
		else
		{
			Class_N = 1;
		}
	}

	public void SetGraduEnding()
	{
		ReportCont.EveryPoint = PlayerPrefs.GetInt("EveryPoint");
		if (ReportCont.EveryPoint <= 8)
		{
			if (scene_controll.money >= 100000000)
			{
				Gradu_N = 23;
				if (s2_3.Gradu_N23 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N23", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				Gradu_N = 0;
				if (s2_3.Gradu_N0 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N0", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 8;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 8;
					Invoke("GraduateEndint_already", 1f);
				}
			}
		}
		if (ReportCont.EveryPoint > 8 && ReportCont.EveryPoint < 16)
		{
			if (S2_4.conviAlba >= 30)
			{
				Gradu_N = 2;
				if (s2_3.Gradu_N2 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N2", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 16;
				}
				else
				{
					SuddenDeathCont.SuddenDeahtPlusGem = 16;
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (Class_N == 1)
				{
					Gradu_N = 1;
					if (s2_3.Gradu_N1 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N1", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 16;
					}
					else
					{
						SuddenDeathCont.SuddenDeahtPlusGem = 16;
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2)
				{
					Gradu_N = 4;
					if (s2_3.Gradu_N4 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N4", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
					}
					else
					{
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 3 || Class_N == 4)
				{
					Gradu_N = 13;
					if (s2_3.Gradu_N13 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N13", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
		}
		if (ReportCont.EveryPoint >= 16 && ReportCont.EveryPoint < 32)
		{
			if (S2_4.cafeAlba >= 29)
			{
				Gradu_N = 6;
				if (s2_3.Gradu_N6 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N6", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 24;
				}
				else
				{
					SuddenDeathCont.SuddenDeahtPlusGem = 24;
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (Class_N == 1)
				{
					Gradu_N = 7;
					if (s2_3.Gradu_N7 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N7", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 24;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2)
				{
					Gradu_N = 8;
					if (s2_3.Gradu_N8 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N8", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 3 || Class_N == 4)
				{
					Gradu_N = 9;
					if (s2_3.Gradu_N9 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N9", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
		}
		if (ReportCont.EveryPoint >= 32 && ReportCont.EveryPoint < 40)
		{
			if (S2_4.takbaeAlba >= 29)
			{
				Gradu_N = 5;
				if (s2_3.Gradu_N5 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N5", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
				}
				else
				{
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (Class_N == 1)
				{
					Gradu_N = 11;
					if (s2_3.Gradu_N11 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N11", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
					}
					else
					{
						SuddenDeathCont.SuddenDeahtPlusGem = 32;
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2)
				{
					Gradu_N = 12;
					if (s2_3.Gradu_N12 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N12", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 40;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 40;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 3 || Class_N == 4)
				{
					Gradu_N = 14;
					if (s2_3.Gradu_N14 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N14", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 40;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 40;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
		}
		if (ReportCont.EveryPoint >= 40 && ReportCont.EveryPoint < 48)
		{
			if (S2_4.factoryAlba >= 29)
			{
				Gradu_N = 18;
				if (s2_3.Gradu_N18 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N18", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 48;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 48;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else if (Class_N == 4)
			{
				Gradu_N = 15;
				if (s2_3.Gradu_N15 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N15", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 48;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 48;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (Char.Sex == 0)
				{
					Gradu_N = 16;
					if (s2_3.Gradu_N16 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N16", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 56;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 56;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Char.Sex == 1)
				{
					Gradu_N = 17;
					if (s2_3.Gradu_N17 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N17", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 56;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 56;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
		}
		if (ReportCont.EveryPoint >= 48 && ReportCont.EveryPoint < 56)
		{
			if (S2_4.studyAlba >= 29)
			{
				Gradu_N = 10;
				if (s2_3.Gradu_N10 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N10", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 64;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 64;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else if (scene_controll.money >= 100000000)
			{
				Gradu_N = 23;
				if (s2_3.Gradu_N23 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N23", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (Class_N == 2 || Class_N == 4)
				{
					Gradu_N = 19;
					if (s2_3.Gradu_N19 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N19", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 1 || Class_N == 3)
				{
					Gradu_N = 20;
					if (s2_3.Gradu_N20 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N20", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
		}
		if (ReportCont.EveryPoint >= 56 && ReportCont.EveryPoint < 64)
		{
			if (Class_N == 1)
			{
				Gradu_N = 21;
				if (s2_3.Gradu_N21 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N21", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (Class_N == 2)
			{
				Gradu_N = 22;
				if (s2_3.Gradu_N22 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N22", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (Class_N == 3 || Class_N == 4)
			{
				Gradu_N = 24;
				if (s2_3.Gradu_N24 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N24", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 80;
					Invoke("GraduateEndint_already", 1f);
				}
			}
		}
		if (ReportCont.EveryPoint >= 64 && ReportCont.EveryPoint < 72)
		{
			if (RoomCont.Room_N > 11)
			{
				if (Class_N == 3)
				{
					Gradu_N = 25;
					if (s2_3.Gradu_N25 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N25", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 160;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 160;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 1)
				{
					Gradu_N = 26;
					if (s2_3.Gradu_N26 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N26", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 240;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 240;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2 || Class_N == 4)
				{
					Gradu_N = 28;
					if (s2_3.Gradu_N28 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N28", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 320;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 320;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
			if (RoomCont.Room_N > 5 && RoomCont.Room_N <= 11)
			{
				Gradu_N = 11;
				if (s2_3.Gradu_N11 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N11", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
				}
				else
				{
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (RoomCont.Room_N <= 5)
			{
				Gradu_N = 8;
				if (s2_3.Gradu_N8 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N8", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 32;
					Invoke("GraduateEndint_already", 1f);
				}
			}
		}
		if (ReportCont.EveryPoint >= 72 && ReportCont.EveryPoint < 80)
		{
			if (RoomCont.Room_N >= 13)
			{
				if (Class_N == 1)
				{
					Gradu_N = 29;
					if (s2_3.Gradu_N29 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N29", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 400;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 400;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2)
				{
					Gradu_N = 30;
					if (s2_3.Gradu_N30 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N30", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 800;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 800;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 3)
				{
					Gradu_N = 33;
					if (s2_3.Gradu_N33 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N33", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 920;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 920;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 4)
				{
					Gradu_N = 32;
					if (s2_3.Gradu_N32 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N32", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 880;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 880;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
			if (RoomCont.Room_N >= 5 && RoomCont.Room_N < 13)
			{
				Gradu_N = 21;
				if (s2_3.Gradu_N21 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N21", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (RoomCont.Room_N < 5)
			{
				Gradu_N = 12;
				if (s2_3.Gradu_N12 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N12", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 40;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 40;
					Invoke("GraduateEndint_already", 1f);
				}
			}
		}
		if (ReportCont.EveryPoint >= 80 && ReportCont.EveryPoint < 88)
		{
			if (scene_controll.money > 100000000000L)
			{
				if (Class_N == 3)
				{
					Gradu_N = 34;
					if (s2_3.Gradu_N34 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N34", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 960;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 960;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 1)
				{
					Gradu_N = 35;
					if (s2_3.Gradu_N35 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N35", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 1000;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 1000;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (Class_N == 2 || Class_N == 4)
				{
					Gradu_N = 36;
					if (s2_3.Gradu_N36 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N36", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 1040;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 1040;
						Invoke("GraduateEndint_already", 1f);
					}
				}
			}
			if (scene_controll.money >= 50000000000L && scene_controll.money < 100000000000L)
			{
				Gradu_N = 37;
				if (s2_3.Gradu_N37 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N37", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 1080;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 1080;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (scene_controll.money >= 100000000 && scene_controll.money < 50000000000L)
			{
				Gradu_N = 28;
				if (s2_3.Gradu_N28 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N28", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 320;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 320;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			if (scene_controll.money < 100000000)
			{
				Gradu_N = 21;
				if (s2_3.Gradu_N21 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N21", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 72;
					Invoke("GraduateEndint_already", 1f);
				}
			}
		}
		if (ReportCont.EveryPoint >= 88)
		{
			if (s2_3.Gradu_N0 == 1 && s2_3.Gradu_N1 == 1 && s2_3.Gradu_N2 == 1 && s2_3.Gradu_N3 == 1 && s2_3.Gradu_N4 == 1 && s2_3.Gradu_N5 == 1 && s2_3.Gradu_N6 == 1 && s2_3.Gradu_N7 == 1 && s2_3.Gradu_N8 == 1 && s2_3.Gradu_N9 == 1 && s2_3.Gradu_N10 == 1 && s2_3.Gradu_N11 == 1 && s2_3.Gradu_N12 == 1 && s2_3.Gradu_N13 == 1 && s2_3.Gradu_N14 == 1 && s2_3.Gradu_N15 == 1 && s2_3.Gradu_N16 == 1 && s2_3.Gradu_N17 == 1 && s2_3.Gradu_N18 == 1 && s2_3.Gradu_N19 == 1 && s2_3.Gradu_N20 == 1 && s2_3.Gradu_N21 == 1 && s2_3.Gradu_N22 == 1 && s2_3.Gradu_N23 == 1 && s2_3.Gradu_N24 == 1 && s2_3.Gradu_N25 == 1 && s2_3.Gradu_N26 == 1 && s2_3.Gradu_N27 == 1 && s2_3.Gradu_N28 == 1 && s2_3.Gradu_N29 == 1 && s2_3.Gradu_N30 == 1)
			{
				Gradu_N = 31;
				if (s2_3.Gradu_N31 == 0)
				{
					PlayerPrefs.SetInt("Gradu_N31", 1);
					WhiteImg.SetActive(true);
					Invoke("GraduateEndint", 1f);
					SuddenDeathCont.SuddenDeahtPlusGem = 1300;
				}
				else
				{
					WhiteImg.SetActive(true);
					SuddenDeathCont.SuddenDeahtPlusGem = 1300;
					Invoke("GraduateEndint_already", 1f);
				}
			}
			else
			{
				if (RoomCont.Room_N < 5)
				{
					Gradu_N = 19;
					if (s2_3.Gradu_N19 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N19", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 64;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (RoomCont.Room_N >= 5 && RoomCont.Room_N < 8)
				{
					Gradu_N = 21;
					if (s2_3.Gradu_N21 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N21", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 72;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 72;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (RoomCont.Room_N >= 8 && RoomCont.Room_N < 15)
				{
					Gradu_N = 22;
					if (s2_3.Gradu_N22 == 0)
					{
						PlayerPrefs.SetInt("Gradu_N22", 1);
						WhiteImg.SetActive(true);
						Invoke("GraduateEndint", 1f);
						SuddenDeathCont.SuddenDeahtPlusGem = 72;
					}
					else
					{
						WhiteImg.SetActive(true);
						SuddenDeathCont.SuddenDeahtPlusGem = 72;
						Invoke("GraduateEndint_already", 1f);
					}
				}
				if (RoomCont.Room_N >= 15)
				{
					if (Class_N == 2)
					{
						Gradu_N = 38;
						if (s2_3.Gradu_N38 == 0)
						{
							PlayerPrefs.SetInt("Gradu_N38", 1);
							WhiteImg.SetActive(true);
							Invoke("GraduateEndint", 1f);
							SuddenDeathCont.SuddenDeahtPlusGem = 1120;
						}
						else
						{
							WhiteImg.SetActive(true);
							SuddenDeathCont.SuddenDeahtPlusGem = 1120;
							Invoke("GraduateEndint_already", 1f);
						}
					}
					if (Class_N == 1)
					{
						Gradu_N = 39;
						if (s2_3.Gradu_N39 == 0)
						{
							PlayerPrefs.SetInt("Gradu_N39", 1);
							WhiteImg.SetActive(true);
							Invoke("GraduateEndint", 1f);
							SuddenDeathCont.SuddenDeahtPlusGem = 1160;
						}
						else
						{
							WhiteImg.SetActive(true);
							SuddenDeathCont.SuddenDeahtPlusGem = 1160;
							Invoke("GraduateEndint_already", 1f);
						}
					}
					if (Class_N == 3)
					{
						Gradu_N = 40;
						if (s2_3.Gradu_N40 == 0)
						{
							PlayerPrefs.SetInt("Gradu_N40", 1);
							WhiteImg.SetActive(true);
							Invoke("GraduateEndint", 1f);
							SuddenDeathCont.SuddenDeahtPlusGem = 1200;
						}
						else
						{
							WhiteImg.SetActive(true);
							SuddenDeathCont.SuddenDeahtPlusGem = 1200;
							Invoke("GraduateEndint_already", 1f);
						}
					}
					if (Class_N == 4)
					{
						Gradu_N = 41;
						if (s2_3.Gradu_N41 == 0)
						{
							PlayerPrefs.SetInt("Gradu_N41", 1);
							WhiteImg.SetActive(true);
							Invoke("GraduateEndint", 1f);
							SuddenDeathCont.SuddenDeahtPlusGem = 1240;
						}
						else
						{
							WhiteImg.SetActive(true);
							SuddenDeathCont.SuddenDeahtPlusGem = 1240;
							Invoke("GraduateEndint_already", 1f);
						}
					}
				}
			}
		}
		PlayerPrefs.SetInt("Ending_N", 1);
	}

	public void GraduateEndint()
	{
		Debug.Log("졸업셋팅");
		GraduEndingScreen.SetActive(true);
		SetText();
		EndingCount++;
		PlayerPrefs.SetInt("EndingCount", EndingCount);
		EndingCount = PlayerPrefs.GetInt("EndingCount");
		WhiteImg.SetActive(false);
		GraduMoney.GetComponent<Text>().text = string.Format("{0:n0}", SuddenDeathCont.SuddenDeahtPlusGem);
		GraduEnd_OK = 1;
		PlayerPrefs.SetInt("GraduEnd_OK", GraduEnd_OK);
		PlayerPrefs.SetInt("Circle_main", 1);
		PlayerPrefs.SetInt("Circle_gradu", 1);
		SuddenDeathCont.Circle_main = PlayerPrefs.GetInt("Circle_main");
		SuddenDeathCont.Circle_gradu = PlayerPrefs.GetInt("Circle_gradu");
		Circle_main_obj_gradu.SetActive(true);
	}

	public void GraduateEndint_already()
	{
		GraduEndingScreen.SetActive(true);
		SetText();
		PlayerPrefs.SetInt("GraduDeathPlusMoney", GraduDeathPlusMoney);
		WhiteImg.SetActive(false);
		GraduMoney.GetComponent<Text>().text = string.Format("{0:n0}", SuddenDeathCont.SuddenDeahtPlusGem);
		GraduEnd_OK = 1;
		PlayerPrefs.SetInt("GraduEnd_OK", GraduEnd_OK);
	}

	public void SetText()
	{
		Image component = Gradu_ImgObj.GetComponent<Image>();
		if (Gradu_N == 0)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_1");
		}
		if (Gradu_N == 1)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_2");
		}
		if (Gradu_N == 2)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_3");
		}
		if (Gradu_N == 4)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_4");
		}
		if (Gradu_N == 5)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_5");
		}
		if (Gradu_N == 6)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_6");
		}
		if (Gradu_N == 7)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_7");
		}
		if (Gradu_N == 8)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_8");
		}
		if (Gradu_N == 9)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_9");
		}
		if (Gradu_N == 10)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_10");
		}
		if (Gradu_N == 11)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_11");
		}
		if (Gradu_N == 12)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_12");
		}
		if (Gradu_N == 13)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_13");
		}
		if (Gradu_N == 14)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_14");
		}
		if (Gradu_N == 15)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_15");
		}
		if (Gradu_N == 16)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_16");
		}
		if (Gradu_N == 17)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_17");
		}
		if (Gradu_N == 18)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_18");
		}
		if (Gradu_N == 19)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_19");
		}
		if (Gradu_N == 20)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_20");
		}
		if (Gradu_N == 21)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_21");
		}
		if (Gradu_N == 22)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_22");
		}
		if (Gradu_N == 23)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_23");
		}
		if (Gradu_N == 24)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_24");
		}
		if (Gradu_N == 25)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_25");
		}
		if (Gradu_N == 26)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_26");
		}
		if (Gradu_N == 28)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_27");
		}
		if (Gradu_N == 29)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_28");
		}
		if (Gradu_N == 30)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_29");
		}
		if (Gradu_N == 31)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_40");
		}
		if (Gradu_N == 32)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_30");
		}
		if (Gradu_N == 33)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_31");
		}
		if (Gradu_N == 34)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_32");
		}
		if (Gradu_N == 35)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_33");
		}
		if (Gradu_N == 36)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_34");
		}
		if (Gradu_N == 37)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_35");
		}
		if (Gradu_N == 38)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_36");
		}
		if (Gradu_N == 39)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_37");
		}
		if (Gradu_N == 40)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_38");
		}
		if (Gradu_N == 41)
		{
			component.sprite = Resources.Load<Sprite>("RealEnding/_39");
		}
		Text component2 = Gradu_Title_T.GetComponent<Text>();
		if (Gradu_N == 0)
		{
			component2.text = string.Format("Being out of work");
		}
		if (Gradu_N == 1)
		{
			component2.text = string.Format("Job Seeker");
		}
		if (Gradu_N == 2)
		{
			component2.text = string.Format("Convenience store part-time");
		}
		if (Gradu_N == 4)
		{
			component2.text = string.Format("Victim of Pyramid Scheme");
		}
		if (Gradu_N == 5)
		{
			component2.text = string.Format("Delivery man");
		}
		if (Gradu_N == 6)
		{
			component2.text = string.Format("Street Vendor");
		}
		if (Gradu_N == 7)
		{
			component2.text = string.Format("Exemplary Citizen");
		}
		if (Gradu_N == 8)
		{
			component2.text = string.Format("fried chicken restaurant owner");
		}
		if (Gradu_N == 9)
		{
			component2.text = string.Format("Famous bloger");
		}
		if (Gradu_N == 10)
		{
			component2.text = string.Format("Teacher");
		}
		if (Gradu_N == 11)
		{
			component2.text = string.Format("Preparing to become a Government Official");
		}
		if (Gradu_N == 12)
		{
			component2.text = string.Format("Venture entrepreneur");
		}
		if (Gradu_N == 13)
		{
			component2.text = string.Format("Cafe owner");
		}
		if (Gradu_N == 14)
		{
			component2.text = string.Format("Leader of a Pseudo-religion");
		}
		if (Gradu_N == 15)
		{
			component2.text = string.Format("World famous Youtuber");
		}
		if (Gradu_N == 16)
		{
			component2.text = string.Format("Small business office worker (male)");
		}
		if (Gradu_N == 17)
		{
			component2.text = string.Format("Small business office worker (female)");
		}
		if (Gradu_N == 18)
		{
			component2.text = string.Format("Field Team Leader");
		}
		if (Gradu_N == 19)
		{
			component2.text = string.Format("Graduate student");
		}
		if (Gradu_N == 20)
		{
			component2.text = string.Format("Workingholiday");
		}
		if (Gradu_N == 21)
		{
			component2.text = string.Format("Worker of major company");
		}
		if (Gradu_N == 22)
		{
			component2.text = string.Format("AI developer");
		}
		if (Gradu_N == 23)
		{
			component2.text = string.Format("Rich idle");
		}
		if (Gradu_N == 24)
		{
			component2.text = string.Format("Populer chef");
		}
		if (Gradu_N == 25)
		{
			component2.text = string.Format("Super star");
		}
		if (Gradu_N == 26)
		{
			component2.text = string.Format("President");
		}
		if (Gradu_N == 28)
		{
			component2.text = string.Format("Global enterprise CEO");
		}
		if (Gradu_N == 29)
		{
			component2.text = string.Format("Building owner");
		}
		if (Gradu_N == 30)
		{
			component2.text = string.Format("Conglomerate");
		}
		if (Gradu_N == 31)
		{
			component2.text = string.Format("A Transcendent One");
		}
		if (Gradu_N == 32)
		{
			component2.text = string.Format("The Heirs");
		}
		if (Gradu_N == 33)
		{
			component2.text = string.Format("World class celebrity");
		}
		if (Gradu_N == 34)
		{
			component2.text = string.Format("Hotel Millionaire");
		}
		if (Gradu_N == 35)
		{
			component2.text = string.Format("Building Owner in Hongkong");
		}
		if (Gradu_N == 36)
		{
			component2.text = string.Format("Casino Millionaire");
		}
		if (Gradu_N == 37)
		{
			component2.text = string.Format("Country Founder");
		}
		if (Gradu_N == 38)
		{
			component2.text = string.Format("World Class Millionaire");
		}
		if (Gradu_N == 39)
		{
			component2.text = string.Format("Richest Man on Earth");
		}
		if (Gradu_N == 40)
		{
			component2.text = string.Format("Richest Man in the Whole Universe");
		}
		if (Gradu_N == 41)
		{
			component2.text = string.Format("Universe Conqueror");
		}
		Text component3 = Gradu_Text.GetComponent<Text>();
		if (Gradu_N == 0)
		{
			component3.text = string.Format("I’m not slacking. I'm just taking a break.");
		}
		if (Gradu_N == 1)
		{
			component3.text = string.Format("Why did you apply to our company? I applied to make money.");
		}
		if (Gradu_N == 2)
		{
			component3.text = string.Format("I can't seem to find other job for w while. ");
		}
		if (Gradu_N == 4)
		{
			component3.text = string.Format("Again, this is a legitimate multi-stage marketing.");
		}
		if (Gradu_N == 5)
		{
			component3.text = string.Format("You ordered 3 things of drinking water, right? Is there an elevator in the building? ...no?");
		}
		if (Gradu_N == 6)
		{
			component3.text = string.Format("Tax? You have to pay that?");
		}
		if (Gradu_N == 7)
		{
			component3.text = string.Format("Let us all vote.");
		}
		if (Gradu_N == 8)
		{
			component3.text = string.Format("No matter what you do, you will end up frying chicken at the end of your career.");
		}
		if (Gradu_N == 9)
		{
			component3.text = string.Format("You can earn money with a hobby!");
		}
		if (Gradu_N == 10)
		{
			component3.text = string.Format("I got invited to a parents’ chat room.");
		}
		if (Gradu_N == 11)
		{
			component3.text = string.Format("It's a narrow gate, but I’ll bet my life on the civil service exam.");
		}
		if (Gradu_N == 12)
		{
			component3.text = string.Format("I have a lot of ideas but I don’t have the money to start.");
		}
		if (Gradu_N == 13)
		{
			component3.text = string.Format("You gotta sell coffee to make money.");
		}
		if (Gradu_N == 14)
		{
			component3.text = string.Format("Let's be friends together!! friends!");
		}
		if (Gradu_N == 15)
		{
			component3.text = string.Format("It's exciting. Always feels fresh. Support me, yes!");
		}
		if (Gradu_N == 16)
		{
			component3.text = string.Format("Mountain climbing with my boss on a weekend, oh what fun.^.^");
		}
		if (Gradu_N == 17)
		{
			component3.text = string.Format("No glass ceiling, please.");
		}
		if (Gradu_N == 18)
		{
			component3.text = string.Format("This is probably the most “real work” out there.");
		}
		if (Gradu_N == 19)
		{
			component3.text = string.Format("I just want to be a student a little longer.");
		}
		if (Gradu_N == 20)
		{
			component3.text = string.Format("I love the “more developed” countries. The hourly wage is great.");
		}
		if (Gradu_N == 21)
		{
			component3.text = string.Format("So much fun, working overtime.");
		}
		if (Gradu_N == 22)
		{
			component3.text = string.Format("This Alpha-dog will soon dominate humanity.");
		}
		if (Gradu_N == 23)
		{
			component3.text = string.Format("Money is all that matters. Oh ho ho.");
		}
		if (Gradu_N == 24)
		{
			component3.text = string.Format("Reservations can be taken one month in advance.");
		}
		if (Gradu_N == 25)
		{
			component3.text = string.Format("My followers like they be shot! Bang Bang Bang!");
		}
		if (Gradu_N == 26)
		{
			component3.text = string.Format("What does your dad.... n, never mind.");
		}
		if (Gradu_N == 28)
		{
			component3.text = string.Format("Stay hungry! You can be a CEO!");
		}
		if (Gradu_N == 29)
		{
			component3.text = string.Format("Congratulations. You got the best job in Korea.");
		}
		if (Gradu_N == 30)
		{
			component3.text = string.Format("All you gotta do is learn how to sit on a wheelchair. Summon, appear, wheelchair. The recipe");
		}
		if (Gradu_N == 31)
		{
			component3.text = string.Format("You cleared this game! Wonderful!");
		}
		if (Gradu_N == 32)
		{
			component3.text = string.Format("The world that they live in... You are now a heir! Enjoy life as a rich successor.");
		}
		if (Gradu_N == 33)
		{
			component3.text = string.Format("You became a famous celebrity. The moment you step on the photo zone, the 0's in your bank account will start surging.");
		}
		if (Gradu_N == 34)
		{
			component3.text = string.Format("What country should I go to take a nap in a hotel tomorrow?");
		}
		if (Gradu_N == 35)
		{
			component3.text = string.Format("If you have just one building in Hong Kong, you're considered super rich, eh?");
		}
		if (Gradu_N == 36)
		{
			component3.text = string.Format("You own a casino. Super duper rich!");
		}
		if (Gradu_N == 37)
		{
			component3.text = string.Format("I go my own way. I found my own country.");
		}
		if (Gradu_N == 38)
		{
			component3.text = string.Format("I am a world-class millionaire who lends money to the banks.");
		}
		if (Gradu_N == 39)
		{
			component3.text = string.Format("The earth is in my palms. The earth is getting a little boring.");
		}
		if (Gradu_N == 40)
		{
			component3.text = string.Format("Going to outer space to shop some planets. Collecting my own planets!");
		}
		if (Gradu_N == 41)
		{
			component3.text = string.Format("The solar system is too small. My stage is the outer space! Space conquest!");
		}
	}

	public void CloseScene()
	{
		GraduEndingScreen.SetActive(false);
		GraduBonus = PlayerPrefs.GetInt("GraduBonus");
		if (GraduBonus == 0)
		{
			scene_controll.gem += SuddenDeathCont.SuddenDeahtPlusGem;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
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
			scene_controll.money_Text = scene_controll.money.ToString();
			scene_controll.money = long.Parse(scene_controll.money_Text);
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			PlayerPrefs.SetInt("GraduBonus", 1);
			GraduBonus = PlayerPrefs.GetInt("GraduBonus");
		}
		Application.LoadLevel("Rebirth");
	}
}
