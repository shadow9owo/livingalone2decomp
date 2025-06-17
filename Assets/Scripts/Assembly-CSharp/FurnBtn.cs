using UnityEngine;
using UnityEngine.UI;

public class FurnBtn : MonoBehaviour
{
	public TextUP _TextUp;

	public SoundEffect_newone _SoundEffect_newone;

	public int TUto;

	public int I_Kitchen_Tuto;

	public int I_Bed_Tuto;

	public int I_Desk_Tuto;

	public int I_Toilet_Tuto;

	public GameObject Charbar;

	public GameObject Cahrbar_black;

	public GameObject bar_T;

	public GameObject Icon_Img;

	public Sprite[] Icon_sprite;

	public static bool Charwork;

	public GameObject[] Canttouchimage;

	public GameObject Char_gameobject;

	private GameObject Actingchar_object;

	public TextUP _TextUP;

	public GameObject Alert_;

	private GameObject _Timecontroller;

	private float Filltime;

	private float Finishtime;

	public static float st_decrease;

	public static int realestateplus;

	public static float Buff_minustime;

	private void Start()
	{
		I_Kitchen_Tuto = PlayerPrefs.GetInt("I_Kitchen_Tuto");
		I_Bed_Tuto = PlayerPrefs.GetInt("I_Bed_Tuto");
		I_Desk_Tuto = PlayerPrefs.GetInt("I_Desk_Tuto");
		I_Toilet_Tuto = PlayerPrefs.GetInt("I_Toilet_Tuto");
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		st_decrease = 3f;
		if (RoomCont.Room_N == 1)
		{
			realestateplus = 6;
		}
		if (RoomCont.Room_N == 2)
		{
			realestateplus = 8;
		}
		if (RoomCont.Room_N == 3)
		{
			realestateplus = 10;
		}
		if (RoomCont.Room_N == 4)
		{
			realestateplus = 12;
		}
		if (RoomCont.Room_N == 5)
		{
			realestateplus = 14;
		}
		if (RoomCont.Room_N == 6)
		{
			realestateplus = 16;
		}
		if (RoomCont.Room_N == 7)
		{
			realestateplus = 18;
		}
		if (RoomCont.Room_N == 8)
		{
			realestateplus = 20;
		}
		if (RoomCont.Room_N == 9)
		{
			realestateplus = 22;
		}
		if (RoomCont.Room_N == 10)
		{
			realestateplus = 24;
		}
		if (RoomCont.Room_N == 11)
		{
			realestateplus = 26;
		}
		if (RoomCont.Room_N == 12)
		{
			realestateplus = 28;
		}
		if (RoomCont.Room_N == 13)
		{
			realestateplus = 30;
		}
		if (RoomCont.Room_N == 14)
		{
			realestateplus = 32;
		}
		if (RoomCont.Room_N == 15)
		{
			realestateplus = 34;
		}
		if (RoomCont.Room_N == 16)
		{
			realestateplus = 35;
		}
		if (RoomCont.Room_N == 17)
		{
			realestateplus = 36;
		}
		Setbuff();
		if (I_Kitchen_Tuto != 1 || I_Bed_Tuto != 1 || I_Desk_Tuto != 1 || I_Toilet_Tuto == 1)
		{
		}
		_Timecontroller = GameObject.Find("TimeController");
	}

	public void Setbuff()
	{
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		if (Pet.Pet_N == 24 || Pet.Pet_N == 25)
		{
			if (TimeBuff.Buffer_N == 0)
			{
				Filltime = 2f;
				Finishtime = 0.4f;
				GetComponent<AudioSource>().pitch = 1.5999999f;
			}
			if (TimeBuff.Buffer_N == 1)
			{
				Filltime = 4f;
				Finishtime = 0.2f;
				GetComponent<AudioSource>().pitch = 3.6000001f;
			}
		}
		else
		{
			if (TimeBuff.Buffer_N == 0)
			{
				Filltime = 0.5f;
				Finishtime = 2f;
				GetComponent<AudioSource>().pitch = 0.64f;
			}
			if (TimeBuff.Buffer_N == 1)
			{
				Filltime = 1f;
				Finishtime = 1f;
				GetComponent<AudioSource>().pitch = 1.2f;
			}
		}
	}

	public void FixedUpdate()
	{
		if (Charwork)
		{
			if (Charbar.GetComponent<Image>().fillAmount < 1f && Charbar.GetComponent<Image>().fillAmount >= 0f)
			{
				Charbar.GetComponent<Image>().fillAmount += Filltime * Time.deltaTime;
				for (int i = 0; i < Canttouchimage.Length; i++)
				{
					Canttouchimage[i].SetActive(true);
				}
			}
			else if (Charbar.GetComponent<Image>().fillAmount >= 1f)
			{
				CheckSt();
				Charwork = false;
				Cahrbar_black.SetActive(false);
				return;
			}
		}
		if (Charwork)
		{
			return;
		}
		Charbar.GetComponent<Image>().fillAmount = 0f;
		for (int j = 0; j < Canttouchimage.Length; j++)
		{
			if (BarCont.st <= 0.01f)
			{
				if (TimeCont.OneMonth == 6 || TimeCont.OneMonth == 12)
				{
					Canttouchimage[5].SetActive(true);
					Canttouchimage[0].SetActive(true);
					Canttouchimage[1].SetActive(false);
					Canttouchimage[2].SetActive(true);
					Canttouchimage[3].SetActive(true);
					Canttouchimage[4].SetActive(true);
				}
				else
				{
					Canttouchimage[j].SetActive(true);
				}
			}
			else
			{
				Canttouchimage[j].SetActive(false);
			}
		}
	}

	public void CheckSt()
	{
		if (BarCont.st <= 0.1f)
		{
			_Timecontroller.GetComponent<TimeCont>().Week();
			Debug.Log("week()");
		}
	}

	public void Alert_setfalse()
	{
		Alert_.SetActive(false);
	}

	public void Energy_HP_Button()
	{
		if (BarCont.hp >= BarCont.hp_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(0.99215686f, 0.18431373f, 0.17254902f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Bed_Tuto", 1);
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Charwork = true;
			Charbar.GetComponent<Image>().color = new Color(0.99215686f, 0.18431373f, 0.17254902f);
			bar_T.GetComponent<Text>().text = string.Format("Sleeping..");
			Icon_Img.GetComponent<Image>().sprite = Icon_sprite[0];
			Cahrbar_black.SetActive(true);
			Char_gameobject.SetActive(false);
			if (RoomCont.Room_N == 1)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 2)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 3)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 4)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 5)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 6)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 7)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 8)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 9)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 10)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 11)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 12)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 13)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 14)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 15)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 16)
			{
				EventCont.Plus_HP = realestateplus;
			}
			if (RoomCont.Room_N == 17)
			{
				EventCont.Plus_HP = realestateplus;
			}
			GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
			GetComponent<AudioSource>().Play();
			if (Alert_.activeInHierarchy)
			{
				Alert_.SetActive(false);
			}
			Invoke("Plushp_japan", Finishtime);
		}
	}

	public void Tuto_0()
	{
		GameObject.Find("Tuto_2(Clone)").GetComponent<Image>().enabled = true;
		GameObject.Find("Tuto_2(Clone)").GetComponent<Button>().enabled = true;
		GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
	}

	public void Plushp_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (TutorialCont.Tutorial_Int == 0)
		{
			Tuto_0();
		}
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			Debug.Log("st_decrease" + st_decrease);
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont.hp >= BarCont.hp_Maxpoint)
		{
			BarCont.hp = BarCont.hp_Maxpoint;
		}
		else
		{
			BarCont.hp += (int)EventCont.Plus_HP;
			PlayerPrefs.SetFloat("hp", BarCont.hp);
			_TextUp.PlusHP();
		}
		Sound();
	}

	public void Hungry_Mp_Button()
	{
		PlayerPrefs.SetInt("I_Kitchen_Tuto", 1);
		if (BarCont.mp >= BarCont.mp_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(0.4627451f, 0.5882353f, 0.12156863f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		if (!(BarCont.mp < BarCont.mp_Maxpoint))
		{
			return;
		}
		Charwork = true;
		Charbar.GetComponent<Image>().color = new Color(0.59607846f, 78f / 85f, 21f / 85f);
		bar_T.GetComponent<Text>().text = string.Format("Washing dishes..");
		Icon_Img.GetComponent<Image>().sprite = Icon_sprite[1];
		Cahrbar_black.SetActive(true);
		Char_gameobject.SetActive(false);
		if (RoomCont.Room_N == 1)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 0)
			{
				GameObject.Find("Kitchen_1_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 1)
			{
				GameObject.Find("Kitchen_1_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 2)
			{
				GameObject.Find("Kitchen_1_3(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 2)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 2)
			{
				GameObject.Find("Kitchen_2_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 3)
			{
				GameObject.Find("Kitchen_2_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 4)
			{
				GameObject.Find("Kitchen_2_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 5)
			{
				GameObject.Find("Kitchen_2_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 3)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 5)
			{
				GameObject.Find("Kitchen_3_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 6)
			{
				GameObject.Find("Kitchen_3_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 7)
			{
				GameObject.Find("Kitchen_3_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 8)
			{
				GameObject.Find("Kitchen_3_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 4)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 8)
			{
				GameObject.Find("Kitchen_4_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 9)
			{
				GameObject.Find("Kitchen_4_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 10)
			{
				GameObject.Find("Kitchen_4_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 11)
			{
				GameObject.Find("Kitchen_4_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 5)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 11)
			{
				GameObject.Find("Kitchen_5_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 12)
			{
				GameObject.Find("Kitchen_5_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 13)
			{
				GameObject.Find("Kitchen_5_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 14)
			{
				GameObject.Find("Kitchen_5_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 6)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 14)
			{
				GameObject.Find("Kitchen_6_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 15)
			{
				GameObject.Find("Kitchen_6_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 16)
			{
				GameObject.Find("Kitchen_6_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 17)
			{
				GameObject.Find("Kitchen_6_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 7)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 17)
			{
				GameObject.Find("Kitchen_7_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 18)
			{
				GameObject.Find("Kitchen_7_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 19)
			{
				GameObject.Find("Kitchen_7_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("Kitchen_7_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("Kitchen_8_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 21)
			{
				GameObject.Find("Kitchen_8_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 22)
			{
				GameObject.Find("Kitchen_8_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("Kitchen_8_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("Kitchen_9_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 24)
			{
				GameObject.Find("Kitchen_9_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 25)
			{
				GameObject.Find("Kitchen_9_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("Kitchen_9_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("Kitchen_10_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 27)
			{
				GameObject.Find("Kitchen_10_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 28)
			{
				GameObject.Find("Kitchen_10_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("Kitchen_10_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("Kitchen_11_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 30)
			{
				GameObject.Find("Kitchen_11_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 31)
			{
				GameObject.Find("Kitchen_11_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("Kitchen_11_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("Kitchen_12_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 33)
			{
				GameObject.Find("Kitchen_12_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 34)
			{
				GameObject.Find("Kitchen_12_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("Kitchen_12_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("Kitchen_13_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 36)
			{
				GameObject.Find("Kitchen_13_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 37)
			{
				GameObject.Find("Kitchen_13_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("Kitchen_13_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("Kitchen_14_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 39)
			{
				GameObject.Find("Kitchen_14_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 40)
			{
				GameObject.Find("Kitchen_14_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("Kitchen_14_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("Kitchen_15_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 42)
			{
				GameObject.Find("Kitchen_15_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 43)
			{
				GameObject.Find("Kitchen_15_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("Kitchen_15_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("Kitchen_16_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 45)
			{
				GameObject.Find("Kitchen_16_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 46)
			{
				GameObject.Find("Kitchen_16_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("Kitchen_16_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("Kitchen_17_1(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 48)
			{
				GameObject.Find("Kitchen_17_2(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 49)
			{
				GameObject.Find("Kitchen_17_3(Clone)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 50)
			{
				GameObject.Find("Kitchen_17_4(Clone)").GetComponent<Button>().interactable = false;
			}
		}
		if (Alert_.activeInHierarchy)
		{
			Alert_.SetActive(false);
		}
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
		GetComponent<AudioSource>().Play();
		Invoke("Plusmp_japan", Finishtime);
	}

	public void Plusmp_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (TutorialCont.Tutorial_Int == 0)
		{
			Tuto_0();
		}
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont.mp >= BarCont.mp_Maxpoint)
		{
			BarCont.mp = BarCont.mp_Maxpoint;
		}
		else
		{
			BarCont.mp += (int)EventCont.Plus_MP;
			PlayerPrefs.SetFloat("mp", BarCont.mp);
			_TextUp.PlusMP();
		}
		if (RoomCont.Room_N == 1)
		{
			Debug.Log("KitchenN" + FurnCont.Kitchen_N);
			if (FurnCont.Kitchen_N == 0)
			{
				GameObject.Find("Kitchen_1_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 1)
			{
				GameObject.Find("Kitchen_1_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 2)
			{
				GameObject.Find("Kitchen_1_3(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 2)
		{
			if (FurnCont.Kitchen_N == 2)
			{
				GameObject.Find("Kitchen_2_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 3)
			{
				GameObject.Find("Kitchen_2_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 4)
			{
				GameObject.Find("Kitchen_2_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 5)
			{
				GameObject.Find("Kitchen_2_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 3)
		{
			if (FurnCont.Kitchen_N == 5)
			{
				GameObject.Find("Kitchen_3_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 6)
			{
				GameObject.Find("Kitchen_3_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 7)
			{
				GameObject.Find("Kitchen_3_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 8)
			{
				GameObject.Find("Kitchen_3_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 4)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 8)
			{
				GameObject.Find("Kitchen_4_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 9)
			{
				GameObject.Find("Kitchen_4_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 10)
			{
				GameObject.Find("Kitchen_4_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 11)
			{
				GameObject.Find("Kitchen_4_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 5)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 11)
			{
				GameObject.Find("Kitchen_5_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 12)
			{
				GameObject.Find("Kitchen_5_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 13)
			{
				GameObject.Find("Kitchen_5_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 14)
			{
				GameObject.Find("Kitchen_5_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 6)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 14)
			{
				GameObject.Find("Kitchen_6_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 15)
			{
				GameObject.Find("Kitchen_6_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 16)
			{
				GameObject.Find("Kitchen_6_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 17)
			{
				GameObject.Find("Kitchen_6_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 7)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 17)
			{
				GameObject.Find("Kitchen_7_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 18)
			{
				GameObject.Find("Kitchen_7_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 19)
			{
				GameObject.Find("Kitchen_7_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("Kitchen_7_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("Kitchen_8_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 21)
			{
				GameObject.Find("Kitchen_8_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 22)
			{
				GameObject.Find("Kitchen_8_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("Kitchen_8_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("Kitchen_9_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 24)
			{
				GameObject.Find("Kitchen_9_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 25)
			{
				GameObject.Find("Kitchen_9_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("Kitchen_9_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("Kitchen_10_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 27)
			{
				GameObject.Find("Kitchen_10_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 28)
			{
				GameObject.Find("Kitchen_10_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("Kitchen_10_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("Kitchen_11_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 30)
			{
				GameObject.Find("Kitchen_11_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 31)
			{
				GameObject.Find("Kitchen_11_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("Kitchen_11_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("Kitchen_12_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 33)
			{
				GameObject.Find("Kitchen_12_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 34)
			{
				GameObject.Find("Kitchen_12_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("Kitchen_12_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("Kitchen_13_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 36)
			{
				GameObject.Find("Kitchen_13_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 37)
			{
				GameObject.Find("Kitchen_13_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("Kitchen_13_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("Kitchen_14_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 39)
			{
				GameObject.Find("Kitchen_14_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 40)
			{
				GameObject.Find("Kitchen_14_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("Kitchen_14_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("Kitchen_15_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 42)
			{
				GameObject.Find("Kitchen_15_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 43)
			{
				GameObject.Find("Kitchen_15_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("Kitchen_15_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("Kitchen_16_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 45)
			{
				GameObject.Find("Kitchen_16_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 46)
			{
				GameObject.Find("Kitchen_16_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("Kitchen_16_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("Kitchen_17_1(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 48)
			{
				GameObject.Find("Kitchen_17_2(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 49)
			{
				GameObject.Find("Kitchen_17_3(Clone)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 50)
			{
				GameObject.Find("Kitchen_17_4(Clone)").GetComponent<Button>().interactable = true;
			}
		}
		Sound();
	}

	public void Hungry_MP_Table_Button()
	{
		if (BarCont.mp >= BarCont.mp_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(0.4627451f, 0.5882353f, 0.12156863f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Kitchen_Tuto", 1);
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Charwork = true;
			Charbar.GetComponent<Image>().color = new Color(0.59607846f, 78f / 85f, 21f / 85f);
			bar_T.GetComponent<Text>().text = string.Format("Having meals..");
			Icon_Img.GetComponent<Image>().sprite = Icon_sprite[1];
			Cahrbar_black.SetActive(true);
			Char_gameobject.SetActive(false);
			if (RoomCont.Room_N == 1)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 2)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 3)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 4)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 5)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 6)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 7)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 8)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 9)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 10)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 11)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 12)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 13)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 14)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 15)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 16)
			{
				EventCont.Plus_MP = realestateplus;
			}
			if (RoomCont.Room_N == 17)
			{
				EventCont.Plus_MP = realestateplus;
			}
			GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
			GetComponent<AudioSource>().Play();
			if (Alert_.activeInHierarchy)
			{
				Alert_.SetActive(false);
			}
			Invoke("Plusmp_Table_japan", Finishtime);
		}
	}

	public void Plusmp_Table_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont.mp >= BarCont.mp_Maxpoint)
		{
			BarCont.mp = BarCont.mp_Maxpoint;
		}
		else
		{
			BarCont.mp += (int)EventCont.Plus_MP;
			PlayerPrefs.SetFloat("mp", BarCont.mp);
			_TextUp.PlusMP();
		}
		Sound();
	}

	public void Toilet_Int_Button()
	{
		if (BarCont._int >= BarCont.int_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(0.11372549f, 0.6039216f, 0.64705884f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Toilet_Tuto", 1);
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Charwork = true;
			Charbar.GetComponent<Image>().color = new Color(0.17254902f, 14f / 15f, 0.99215686f);
			bar_T.GetComponent<Text>().text = string.Format("Using toilet..");
			Icon_Img.GetComponent<Image>().sprite = Icon_sprite[2];
			Cahrbar_black.SetActive(true);
			Char_gameobject.SetActive(false);
			if (RoomCont.Room_N == 1)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 2)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 3)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 4)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 5)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 6)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 7)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 8)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 9)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 10)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 11)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 12)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 13)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 14)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 15)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 16)
			{
				EventCont.Plus_INT = realestateplus;
			}
			if (RoomCont.Room_N == 17)
			{
				EventCont.Plus_INT = realestateplus;
			}
			GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
			GetComponent<AudioSource>().Play();
			if (Alert_.activeInHierarchy)
			{
				Alert_.SetActive(false);
			}
			Invoke("Plusint_japan", Finishtime);
		}
	}

	public void Plusint_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (TutorialCont.Tutorial_Int == 0)
		{
			Tuto_0();
		}
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont._int >= BarCont.int_Maxpoint)
		{
			BarCont._int = BarCont.int_Maxpoint;
		}
		else
		{
			BarCont._int += (int)EventCont.Plus_INT;
			PlayerPrefs.SetFloat("int", BarCont._int);
			_TextUp.PlusINT();
		}
		Sound();
	}

	public void Toilet_Int_bath_Button()
	{
		if (BarCont._int >= BarCont.int_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(0.11372549f, 0.6039216f, 0.64705884f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Toilet_Tuto", 1);
		if (!(BarCont._int < BarCont.int_Maxpoint))
		{
			return;
		}
		Charwork = true;
		Charbar.GetComponent<Image>().color = new Color(0.17254902f, 14f / 15f, 0.99215686f);
		bar_T.GetComponent<Text>().text = string.Format("Taking a bath..");
		Icon_Img.GetComponent<Image>().sprite = Icon_sprite[2];
		Cahrbar_black.SetActive(true);
		Char_gameobject.SetActive(false);
		EventCont.Plus_INT = realestateplus;
		if (RoomCont.Room_N == 1)
		{
			EventCont.Plus_INT = realestateplus;
		}
		if (RoomCont.Room_N == 2)
		{
			EventCont.Plus_INT = realestateplus;
		}
		if (RoomCont.Room_N >= 3 && RoomCont.Room_N < 8)
		{
			GameObject.Find("Toilet (1)").GetComponent<Button>().interactable = false;
		}
		if (RoomCont.Room_N == 8)
		{
			if (FurnCont.Toilet_N == 20)
			{
				GameObject.Find("Toilet (1)").GetComponent<Button>().interactable = false;
			}
			else
			{
				if (FurnCont.Toilet_N == 21)
				{
					GameObject.Find("Bath_8_2").GetComponent<Button>().interactable = false;
				}
				if (FurnCont.Toilet_N == 22)
				{
					GameObject.Find("Bath_8_3").GetComponent<Button>().interactable = false;
				}
				if (FurnCont.Toilet_N == 23)
				{
					GameObject.Find("Bath_8_4").GetComponent<Button>().interactable = false;
				}
			}
		}
		if (RoomCont.Room_N == 9)
		{
			if (FurnCont.Toilet_N == 23)
			{
				GameObject.Find("Bath_9_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 24)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 25)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 26)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			GameObject.Find("Bath (1)").GetComponent<Button>().interactable = false;
		}
		if (RoomCont.Room_N == 11)
		{
			if (FurnCont.Toilet_N == 29)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 30)
			{
				GameObject.Find("Bath_11_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 31)
			{
				GameObject.Find("Bath_11_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 32)
			{
				GameObject.Find("Bath_11_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			if (FurnCont.Toilet_N == 32)
			{
				GameObject.Find("Bath_12_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 33)
			{
				GameObject.Find("Bath_12_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 34)
			{
				GameObject.Find("Bath_12_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 35)
			{
				GameObject.Find("Bath_12_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			if (FurnCont.Toilet_N == 35)
			{
				GameObject.Find("Bath_13_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 36)
			{
				GameObject.Find("Bath_13_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 37)
			{
				GameObject.Find("Bath_13_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 38)
			{
				GameObject.Find("Bath_13_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			if (FurnCont.Toilet_N == 38)
			{
				GameObject.Find("Bath_14_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 39)
			{
				GameObject.Find("Bath_14_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 40)
			{
				GameObject.Find("Bath_14_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 41)
			{
				GameObject.Find("Bath_14_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			if (FurnCont.Toilet_N == 41)
			{
				GameObject.Find("Bath_15_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 42)
			{
				GameObject.Find("Bath_15_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 43)
			{
				GameObject.Find("Bath_15_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 44)
			{
				GameObject.Find("Bath_15_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			if (FurnCont.Toilet_N == 44)
			{
				GameObject.Find("Bath_16_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 45)
			{
				GameObject.Find("Bath_16_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 46)
			{
				GameObject.Find("Bath_16_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 47)
			{
				GameObject.Find("Bath_16_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			if (FurnCont.Toilet_N == 47)
			{
				GameObject.Find("Bath_17_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 48)
			{
				GameObject.Find("Bath_17_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 49)
			{
				GameObject.Find("Bath_17_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Toilet_N == 50)
			{
				GameObject.Find("Bath_17_4").GetComponent<Button>().interactable = false;
			}
		}
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
		GetComponent<AudioSource>().Play();
		if (Alert_.activeInHierarchy)
		{
			Alert_.SetActive(false);
		}
		Invoke("Plusint_bath_japan", Finishtime);
	}

	public void Plusint_bath_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont._int >= BarCont.int_Maxpoint)
		{
			BarCont._int = BarCont.int_Maxpoint;
		}
		else
		{
			BarCont._int += (int)EventCont.Plus_INT;
			PlayerPrefs.SetFloat("int", BarCont._int);
			_TextUp.PlusINT();
		}
		if (RoomCont.Room_N >= 3 && RoomCont.Room_N < 8)
		{
			EventCont.Plus_INT = realestateplus;
			GameObject.Find("Toilet (1)").GetComponent<Button>().interactable = true;
		}
		if (RoomCont.Room_N == 8)
		{
			if (FurnCont.Toilet_N == 20)
			{
				GameObject.Find("Toilet (1)").GetComponent<Button>().interactable = true;
			}
			else
			{
				if (FurnCont.Toilet_N == 21)
				{
					GameObject.Find("Bath_8_2").GetComponent<Button>().interactable = true;
				}
				if (FurnCont.Toilet_N == 22)
				{
					GameObject.Find("Bath_8_3").GetComponent<Button>().interactable = true;
				}
				if (FurnCont.Toilet_N == 23)
				{
					GameObject.Find("Bath_8_4").GetComponent<Button>().interactable = true;
				}
			}
		}
		if (RoomCont.Room_N == 9)
		{
			if (FurnCont.Toilet_N == 23)
			{
				GameObject.Find("Bath_9_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 24)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 25)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 26)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			GameObject.Find("Bath (1)").GetComponent<Button>().interactable = true;
		}
		if (RoomCont.Room_N == 11)
		{
			if (FurnCont.Toilet_N == 29)
			{
				GameObject.Find("Bath (1)").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 30)
			{
				GameObject.Find("Bath_11_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 31)
			{
				GameObject.Find("Bath_11_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 32)
			{
				GameObject.Find("Bath_11_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			if (FurnCont.Toilet_N == 32)
			{
				GameObject.Find("Bath_12_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 33)
			{
				GameObject.Find("Bath_12_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 34)
			{
				GameObject.Find("Bath_12_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 35)
			{
				GameObject.Find("Bath_12_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			if (FurnCont.Toilet_N == 35)
			{
				GameObject.Find("Bath_13_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 36)
			{
				GameObject.Find("Bath_13_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 37)
			{
				GameObject.Find("Bath_13_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 38)
			{
				GameObject.Find("Bath_13_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			if (FurnCont.Toilet_N == 38)
			{
				GameObject.Find("Bath_14_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 39)
			{
				GameObject.Find("Bath_14_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 40)
			{
				GameObject.Find("Bath_14_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 41)
			{
				GameObject.Find("Bath_14_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			if (FurnCont.Toilet_N == 41)
			{
				GameObject.Find("Bath_15_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 42)
			{
				GameObject.Find("Bath_15_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 43)
			{
				GameObject.Find("Bath_15_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 44)
			{
				GameObject.Find("Bath_15_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			if (FurnCont.Toilet_N == 44)
			{
				GameObject.Find("Bath_16_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 45)
			{
				GameObject.Find("Bath_16_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 46)
			{
				GameObject.Find("Bath_16_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 47)
			{
				GameObject.Find("Bath_16_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			if (FurnCont.Toilet_N == 47)
			{
				GameObject.Find("Bath_17_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 48)
			{
				GameObject.Find("Bath_17_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 49)
			{
				GameObject.Find("Bath_17_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Toilet_N == 50)
			{
				GameObject.Find("Bath_17_4").GetComponent<Button>().interactable = true;
			}
		}
		Sound();
	}

	public void Fun_Happy_Button()
	{
		if (BarCont.happy >= BarCont.happy_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(79f / 85f, 0.23137255f, 42f / 85f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Desk_Tuto", 1);
		if (!(BarCont.happy < BarCont.happy_Maxpoint))
		{
			return;
		}
		Charwork = true;
		Charbar.GetComponent<Image>().color = new Color(79f / 85f, 0.23137255f, 42f / 85f);
		bar_T.GetComponent<Text>().text = string.Format("Playing..");
		Icon_Img.GetComponent<Image>().sprite = Icon_sprite[3];
		Cahrbar_black.SetActive(true);
		Char_gameobject.SetActive(false);
		if (RoomCont.Room_N == 1)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 0)
			{
				GameObject.Find("Desk_1_1").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 2)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 2)
			{
				GameObject.Find("Desk_2_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 3)
			{
				GameObject.Find("Desk_2_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 4)
			{
				GameObject.Find("Desk_2_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 5)
			{
				GameObject.Find("Desk_2_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 3)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 5)
			{
				GameObject.Find("Desk_3_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 6)
			{
				GameObject.Find("Desk_3_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 7)
			{
				GameObject.Find("Desk_3_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 8)
			{
				GameObject.Find("Desk_3_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 4)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 8)
			{
				GameObject.Find("Desk_4_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 9)
			{
				GameObject.Find("Desk_4_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 10)
			{
				GameObject.Find("Desk_4_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 11)
			{
				GameObject.Find("Desk_4_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 5)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 11)
			{
				GameObject.Find("Desk_5_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 12)
			{
				GameObject.Find("Desk_5_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 13)
			{
				GameObject.Find("Desk_5_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 14)
			{
				GameObject.Find("Desk_5_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 6)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 14)
			{
				GameObject.Find("Desk_6_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 15)
			{
				GameObject.Find("Desk_6_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 16)
			{
				GameObject.Find("Desk_6_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 17)
			{
				GameObject.Find("Desk_6_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 7)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 17)
			{
				GameObject.Find("Desk_7_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 18)
			{
				GameObject.Find("Desk_7_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 19)
			{
				GameObject.Find("Desk_7_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 20)
			{
				GameObject.Find("Desk_7_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 20)
			{
				GameObject.Find("Desk_8_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 21)
			{
				GameObject.Find("Desk_8_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 22)
			{
				GameObject.Find("Desk_8_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 23)
			{
				GameObject.Find("Desk_8_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 23)
			{
				GameObject.Find("Desk_9_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 24)
			{
				GameObject.Find("Desk_9_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 25)
			{
				GameObject.Find("Desk_9_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 26)
			{
				GameObject.Find("Desk_9_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 26)
			{
				GameObject.Find("Desk_10_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 27)
			{
				GameObject.Find("Desk_10_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 28)
			{
				GameObject.Find("Desk_10_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 29)
			{
				GameObject.Find("Desk_10_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 29)
			{
				GameObject.Find("Desk_11_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 30)
			{
				GameObject.Find("Desk_11_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 31)
			{
				GameObject.Find("Desk_11_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 32)
			{
				GameObject.Find("Desk_11_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 32)
			{
				GameObject.Find("Desk_12_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 33)
			{
				GameObject.Find("Desk_12_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 34)
			{
				GameObject.Find("Desk_12_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 35)
			{
				GameObject.Find("Desk_12_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 35)
			{
				GameObject.Find("Desk_13_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 36)
			{
				GameObject.Find("Desk_13_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 37)
			{
				GameObject.Find("Desk_13_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 38)
			{
				GameObject.Find("Desk_13_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 38)
			{
				GameObject.Find("Desk_14_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 39)
			{
				GameObject.Find("Desk_14_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 40)
			{
				GameObject.Find("Desk_14_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 41)
			{
				GameObject.Find("Desk_14_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 41)
			{
				GameObject.Find("Desk_15_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 42)
			{
				GameObject.Find("Desk_15_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 43)
			{
				GameObject.Find("Desk_15_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Bed_N == 44)
			{
				GameObject.Find("Desk_15_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 44)
			{
				GameObject.Find("Desk_16_1").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_HAPPY = realestateplus;
			GameObject.Find("Waterpool").GetComponent<Button>().interactable = false;
		}
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
		GetComponent<AudioSource>().Play();
		if (Alert_.activeInHierarchy)
		{
			Alert_.SetActive(false);
		}
		Invoke("Plushappy_japan", Finishtime);
	}

	public void Plushappy_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (TutorialCont.Tutorial_Int == 0)
		{
			Tuto_0();
		}
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont.happy >= BarCont.happy_Maxpoint)
		{
			BarCont.happy = BarCont.happy_Maxpoint;
		}
		else
		{
			BarCont.happy += (int)EventCont.Plus_HAPPY;
			PlayerPrefs.SetFloat("happy", BarCont.happy);
			_TextUp.PlusHAPPY();
		}
		Debug.Log("EventCont.Plus_HAPPY" + EventCont.Plus_HAPPY);
		if (RoomCont.Room_N == 1)
		{
			EventCont.Plus_MP = realestateplus;
			if (FurnCont.Bed_N == 0)
			{
				GameObject.Find("Desk_1_1").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 2)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 2)
			{
				GameObject.Find("Desk_2_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 3)
			{
				GameObject.Find("Desk_2_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 4)
			{
				GameObject.Find("Desk_2_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 5)
			{
				GameObject.Find("Desk_2_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 3)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 5)
			{
				GameObject.Find("Desk_3_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 6)
			{
				GameObject.Find("Desk_3_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 7)
			{
				GameObject.Find("Desk_3_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 8)
			{
				GameObject.Find("Desk_3_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 4)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 8)
			{
				GameObject.Find("Desk_4_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 9)
			{
				GameObject.Find("Desk_4_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 10)
			{
				GameObject.Find("Desk_4_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 11)
			{
				GameObject.Find("Desk_4_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 5)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 11)
			{
				GameObject.Find("Desk_5_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 12)
			{
				GameObject.Find("Desk_5_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 13)
			{
				GameObject.Find("Desk_5_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 14)
			{
				GameObject.Find("Desk_5_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 6)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 14)
			{
				GameObject.Find("Desk_6_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 15)
			{
				GameObject.Find("Desk_6_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 16)
			{
				GameObject.Find("Desk_6_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 17)
			{
				GameObject.Find("Desk_6_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 7)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 17)
			{
				GameObject.Find("Desk_7_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 18)
			{
				GameObject.Find("Desk_7_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 19)
			{
				GameObject.Find("Desk_7_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 20)
			{
				GameObject.Find("Desk_7_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 20)
			{
				GameObject.Find("Desk_8_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 21)
			{
				GameObject.Find("Desk_8_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 22)
			{
				GameObject.Find("Desk_8_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 23)
			{
				GameObject.Find("Desk_8_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 23)
			{
				GameObject.Find("Desk_9_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 24)
			{
				GameObject.Find("Desk_9_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 25)
			{
				GameObject.Find("Desk_9_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 26)
			{
				GameObject.Find("Desk_9_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 26)
			{
				GameObject.Find("Desk_10_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 27)
			{
				GameObject.Find("Desk_10_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 28)
			{
				GameObject.Find("Desk_10_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 29)
			{
				GameObject.Find("Desk_10_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 29)
			{
				GameObject.Find("Desk_11_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 30)
			{
				GameObject.Find("Desk_11_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 31)
			{
				GameObject.Find("Desk_11_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 32)
			{
				GameObject.Find("Desk_11_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 32)
			{
				GameObject.Find("Desk_12_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 33)
			{
				GameObject.Find("Desk_12_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 34)
			{
				GameObject.Find("Desk_12_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 35)
			{
				GameObject.Find("Desk_12_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 35)
			{
				GameObject.Find("Desk_13_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 36)
			{
				GameObject.Find("Desk_13_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 37)
			{
				GameObject.Find("Desk_13_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 38)
			{
				GameObject.Find("Desk_13_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 38)
			{
				GameObject.Find("Desk_14_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 39)
			{
				GameObject.Find("Desk_14_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 40)
			{
				GameObject.Find("Desk_14_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 41)
			{
				GameObject.Find("Desk_14_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 41)
			{
				GameObject.Find("Desk_15_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 42)
			{
				GameObject.Find("Desk_15_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 43)
			{
				GameObject.Find("Desk_15_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Bed_N == 44)
			{
				GameObject.Find("Desk_15_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Bed_N == 44)
			{
				GameObject.Find("Desk_16_1").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_HAPPY = realestateplus;
			GameObject.Find("Waterpool").GetComponent<Button>().interactable = true;
		}
		Sound();
	}

	public void Fun_Happy_TV_Button()
	{
		if (BarCont.happy >= BarCont.happy_Maxpoint)
		{
			Alert_.GetComponent<Text>().color = new Color(79f / 85f, 0.23137255f, 42f / 85f);
			Alert_.SetActive(true);
			Invoke("Alert_setfalse", 1.5f);
		}
		PlayerPrefs.SetInt("I_Desk_Tuto", 1);
		if (!(BarCont.happy < BarCont.happy_Maxpoint))
		{
			return;
		}
		Charwork = true;
		Charbar.GetComponent<Image>().color = new Color(79f / 85f, 0.23137255f, 42f / 85f);
		bar_T.GetComponent<Text>().text = string.Format("Watching TV..");
		Icon_Img.GetComponent<Image>().sprite = Icon_sprite[3];
		Cahrbar_black.SetActive(true);
		Char_gameobject.SetActive(false);
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("TV_8_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 21)
			{
				GameObject.Find("TV_8_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 22)
			{
				GameObject.Find("TV_8_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("TV_8_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("TV_9_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 24)
			{
				GameObject.Find("TV_9_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 25)
			{
				GameObject.Find("TV_9_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("TV_9_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("TV_10_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 27)
			{
				GameObject.Find("TV_10_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 28)
			{
				GameObject.Find("TV_10_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("TV_10_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("TV_11_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 30)
			{
				GameObject.Find("TV_11_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 31)
			{
				GameObject.Find("TV_11_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("TV_11_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("TV_12_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 33)
			{
				GameObject.Find("TV_12_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 34)
			{
				GameObject.Find("TV_12_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("TV_12_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("TV_13_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 36)
			{
				GameObject.Find("TV_13_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 37)
			{
				GameObject.Find("TV_13_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("TV_13_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("TV_14_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 39)
			{
				GameObject.Find("TV_14_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 40)
			{
				GameObject.Find("TV_14_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("TV_14_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("TV_15_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 42)
			{
				GameObject.Find("TV_15_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 43)
			{
				GameObject.Find("TV_15_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("TV_15_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("TV_16_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 45)
			{
				GameObject.Find("TV_16_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 46)
			{
				GameObject.Find("TV_16_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("TV_16_4").GetComponent<Button>().interactable = false;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("TV_17_1").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 48)
			{
				GameObject.Find("TV_17_2").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 49)
			{
				GameObject.Find("TV_17_3").GetComponent<Button>().interactable = false;
			}
			if (FurnCont.Kitchen_N == 50)
			{
				GameObject.Find("TV_17_4").GetComponent<Button>().interactable = false;
			}
		}
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/Increase_bell_2");
		GetComponent<AudioSource>().Play();
		if (Alert_.activeInHierarchy)
		{
			Alert_.SetActive(false);
		}
		Invoke("Plushappy_TV_japan", Finishtime);
	}

	public void Plushappy_TV_japan()
	{
		Actingchar_object = GameObject.Find("ActingChar(Clone)");
		Object.DestroyImmediate(Actingchar_object);
		if (BarCont.st > 0.1f)
		{
			BarCont.st -= st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime;
			PlayerPrefs.SetFloat("st", BarCont.st);
			EventCont.Plus_ST = 0f - (st_decrease - st_decrease * CarCont.all_car_effect - st_decrease * Buff_minustime);
			_TextUP.PlusST();
		}
		if (BarCont.happy >= BarCont.happy_Maxpoint)
		{
			BarCont.happy = BarCont.happy_Maxpoint;
		}
		else
		{
			BarCont.happy += (int)EventCont.Plus_HAPPY;
			PlayerPrefs.SetFloat("happy", BarCont.happy);
			_TextUp.PlusHAPPY();
		}
		if (RoomCont.Room_N == 8)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 20)
			{
				GameObject.Find("TV_8_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 21)
			{
				GameObject.Find("TV_8_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 22)
			{
				GameObject.Find("TV_8_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("TV_8_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 9)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 23)
			{
				GameObject.Find("TV_9_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 24)
			{
				GameObject.Find("TV_9_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 25)
			{
				GameObject.Find("TV_9_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("TV_9_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 10)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 26)
			{
				GameObject.Find("TV_10_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 27)
			{
				GameObject.Find("TV_10_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 28)
			{
				GameObject.Find("TV_10_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("TV_10_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 11)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 29)
			{
				GameObject.Find("TV_11_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 30)
			{
				GameObject.Find("TV_11_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 31)
			{
				GameObject.Find("TV_11_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("TV_11_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 12)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 32)
			{
				GameObject.Find("TV_12_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 33)
			{
				GameObject.Find("TV_12_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 34)
			{
				GameObject.Find("TV_12_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("TV_12_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 13)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 35)
			{
				GameObject.Find("TV_13_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 36)
			{
				GameObject.Find("TV_13_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 37)
			{
				GameObject.Find("TV_13_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("TV_13_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 14)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 38)
			{
				GameObject.Find("TV_14_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 39)
			{
				GameObject.Find("TV_14_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 40)
			{
				GameObject.Find("TV_14_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("TV_14_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 15)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 41)
			{
				GameObject.Find("TV_15_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 42)
			{
				GameObject.Find("TV_15_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 43)
			{
				GameObject.Find("TV_15_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("TV_15_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 16)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 44)
			{
				GameObject.Find("TV_16_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 45)
			{
				GameObject.Find("TV_16_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 46)
			{
				GameObject.Find("TV_16_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("TV_16_4").GetComponent<Button>().interactable = true;
			}
		}
		if (RoomCont.Room_N == 17)
		{
			EventCont.Plus_HAPPY = realestateplus;
			if (FurnCont.Kitchen_N == 47)
			{
				GameObject.Find("TV_17_1").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 48)
			{
				GameObject.Find("TV_17_2").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 49)
			{
				GameObject.Find("TV_17_3").GetComponent<Button>().interactable = true;
			}
			if (FurnCont.Kitchen_N == 50)
			{
				GameObject.Find("TV_17_4").GetComponent<Button>().interactable = true;
			}
		}
		Sound();
	}

	public void Sound()
	{
		Char_gameobject.SetActive(true);
		_SoundEffect_newone.FurnitureButton();
	}
}
