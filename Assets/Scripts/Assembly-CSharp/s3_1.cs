using System;
using UnityEngine;
using UnityEngine.UI;

public class s3_1 : MonoBehaviour
{
	private Transform money_window;

	public scene_controll scene_controll;

	public s3_2 s3_2;

	public s3_3 s3_3;

	public s3_4 s3_4;

	public s3_5 s3_5;

	public s3_6 s3_6;

	public s3_7 s3_7;

	private void Start()
	{
		CashCont.Scene_String = "3-1";
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N", RoomCont.Room_N);
		GC.Collect();
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.pet_load.SetActive(false);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		scene_controll_2.load_num = 0;
	}

	private void btn_budongsan()
	{
		Debug.LogFormat("room_num{0}", RoomCont.Room_N);
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_2.SetActive(true);
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		s3_2.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
		s3_3.bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		s3_3.bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		s3_3.bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		s3_3.living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		s3_3.living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		s3_3.living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		s3_3.toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		s3_3.toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		s3_3.toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
		if (RoomCont.Room_N == 0)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_1");
		}
		if (RoomCont.Room_N == 1)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_1");
		}
		if (RoomCont.Room_N == 2)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_2");
		}
		if (RoomCont.Room_N == 3)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_3");
		}
		if (RoomCont.Room_N == 4)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_4");
		}
		if (RoomCont.Room_N == 5)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_5");
		}
		if (RoomCont.Room_N == 6)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_6");
		}
		if (RoomCont.Room_N == 7)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_7");
		}
		if (RoomCont.Room_N == 8)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_8");
		}
		if (RoomCont.Room_N == 9)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_9");
		}
		if (RoomCont.Room_N == 10)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_10");
		}
		if (RoomCont.Room_N == 11)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_11");
		}
		if (RoomCont.Room_N == 12)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_12");
		}
		if (RoomCont.Room_N == 13)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_13");
		}
		if (RoomCont.Room_N == 14)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_14");
		}
		if (RoomCont.Room_N == 15)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_15");
		}
		if (RoomCont.Room_N == 16)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_16");
		}
		if (RoomCont.Room_N == 17)
		{
			s3_2.house_load.sprite = Resources.Load<Sprite>("house_17");
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_ikea()
	{
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		s3_3.home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
		scene_controll_2.load_num = 0;
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_3.SetActive(true);
		s3_3.bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		s3_3.bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		s3_3.bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		s3_3.living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		s3_3.living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		s3_3.living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		s3_3.toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		s3_3.toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		s3_3.toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
		s3_7.price_gem = 0;
		if (s3_3.bed_num[0] == 0 && s3_3.bed_num[1] == 0 && s3_3.bed_num[2] == 0)
		{
			s3_3.bed_panel_lock[0].GetComponent<Button>().interactable = true;
			s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.bed_num[0] == 1 && s3_3.bed_num[1] == 0 && s3_3.bed_num[2] == 0)
		{
			s3_3.bed_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = true;
			s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.bed_num[0] == 1 && s3_3.bed_num[1] == 1 && s3_3.bed_num[2] == 0)
		{
			s3_3.bed_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (s3_3.bed_num[0] == 1 && s3_3.bed_num[1] == 1 && s3_3.bed_num[2] == 1)
		{
			s3_3.bed_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.living_num[0] == 0 && s3_3.living_num[1] == 0 && s3_3.living_num[2] == 0)
		{
			s3_3.living_panel_lock[0].GetComponent<Button>().interactable = true;
			s3_3.living_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.living_num[0] == 1 && s3_3.living_num[1] == 0 && s3_3.living_num[2] == 0)
		{
			s3_3.living_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[1].GetComponent<Button>().interactable = true;
			s3_3.living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.living_num[0] == 1 && s3_3.living_num[1] == 1 && s3_3.living_num[2] == 0)
		{
			s3_3.living_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (s3_3.living_num[0] == 1 && s3_3.living_num[1] == 1 && s3_3.living_num[2] == 1)
		{
			s3_3.living_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.toilet_num[0] == 0 && s3_3.toilet_num[1] == 0 && s3_3.toilet_num[2] == 0)
		{
			s3_3.toilet_panel_lock[0].GetComponent<Button>().interactable = true;
			s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.toilet_num[0] == 1 && s3_3.toilet_num[1] == 0 && s3_3.toilet_num[2] == 0)
		{
			s3_3.toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = true;
			s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (s3_3.toilet_num[0] == 1 && s3_3.toilet_num[1] == 1 && s3_3.toilet_num[2] == 0)
		{
			s3_3.toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (s3_3.toilet_num[0] == 1 && s3_3.toilet_num[1] == 1 && s3_3.toilet_num[2] == 1)
		{
			s3_3.toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			s3_3.toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
        if (RoomCont.Room_N == 1)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.1");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.2");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.3");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.1");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.2");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.3");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.1");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.2");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.3");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("10,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("100,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("150,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("10,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("100,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("150,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("10,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("100,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("150,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[41 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[42 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[43 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[0];
            s3_3.img_living[1].sprite = s3_3.sprite_2[1];
            s3_3.img_living[2].sprite = s3_3.sprite_2[2];
            s3_3.img_bath[0].sprite = s3_3.sprite[0];
            s3_3.img_bath[1].sprite = s3_3.sprite[1];
            s3_3.img_bath[2].sprite = s3_3.sprite[2];
        }
        if (RoomCont.Room_N == 2)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.4");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.5");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.6");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.4");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.5");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.6");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.4");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.5");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.6");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("200,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("250,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("300,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("200,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("250,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("300,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("200,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("250,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("300,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[44 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[45 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[46 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[3];
            s3_3.img_living[1].sprite = s3_3.sprite_2[4];
            s3_3.img_living[2].sprite = s3_3.sprite_2[5];
            s3_3.img_bath[0].sprite = s3_3.sprite[2];
            s3_3.img_bath[1].sprite = s3_3.sprite[2];
            s3_3.img_bath[2].sprite = s3_3.sprite[3];
        }
        if (RoomCont.Room_N == 3)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.7");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.8");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.9");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.7");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.8");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.9");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.7");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.8");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.9");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("350,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("400,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("450,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("350,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("400,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("450,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("350,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("400,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("450,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[47 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[48 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[49 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[6];
            s3_3.img_living[1].sprite = s3_3.sprite_2[7];
            s3_3.img_living[2].sprite = s3_3.sprite_2[8];
            s3_3.img_bath[0].sprite = s3_3.sprite[4];
            s3_3.img_bath[1].sprite = s3_3.sprite[5];
            s3_3.img_bath[2].sprite = s3_3.sprite[6];
        }
        if (RoomCont.Room_N == 4)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.10");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.11");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.12");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.10");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.11");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.12");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.10");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.11");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.12");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("500,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("550,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("600,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("500,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("550,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("600,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("500,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("550,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("600,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[50 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[51 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[52 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[9];
            s3_3.img_living[1].sprite = s3_3.sprite_2[10];
            s3_3.img_living[2].sprite = s3_3.sprite_2[10];
            s3_3.img_bath[0].sprite = s3_3.sprite[7];
            s3_3.img_bath[1].sprite = s3_3.sprite[8];
            s3_3.img_bath[2].sprite = s3_3.sprite[9];
        }
        if (RoomCont.Room_N == 5)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.13");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.14");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.15");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.13");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.14");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.15");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.13");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.14");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.15");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("650,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("700,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("750,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("650,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("700,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("750,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("650,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("700,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("750,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[53 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[54 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[55 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[12];
            s3_3.img_living[1].sprite = s3_3.sprite_2[13];
            s3_3.img_living[2].sprite = s3_3.sprite_2[14];
            s3_3.img_bath[0].sprite = s3_3.sprite[10];
            s3_3.img_bath[1].sprite = s3_3.sprite[11];
            s3_3.img_bath[2].sprite = s3_3.sprite[12];
        }
        if (RoomCont.Room_N == 6)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.16");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.17");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.18");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.16");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.17");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.18");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.16");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.17");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.18");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("800,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("850,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("900,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("800,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("850,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("900,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("800,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("850,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("900,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[56 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[57 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[58 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[14];
            s3_3.img_living[1].sprite = s3_3.sprite_2[15];
            s3_3.img_living[2].sprite = s3_3.sprite_2[16];
            s3_3.img_bath[0].sprite = s3_3.sprite[13];
            s3_3.img_bath[1].sprite = s3_3.sprite[14];
            s3_3.img_bath[2].sprite = s3_3.sprite[15];
        }
        if (RoomCont.Room_N == 7)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.19");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.20");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.21");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.19");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.20");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.21");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.19");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.20");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.21");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("950,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("1,000,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("1,100,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("950,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("1,000,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("1,100,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("950,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("1,000,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("1,100,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[59 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[60 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[61 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[17];
            s3_3.img_living[1].sprite = s3_3.sprite_2[18];
            s3_3.img_living[2].sprite = s3_3.sprite_2[19];
            s3_3.img_bath[0].sprite = s3_3.sprite[16];
            s3_3.img_bath[1].sprite = s3_3.sprite[17];
            s3_3.img_bath[2].sprite = s3_3.sprite[18];
        }
        if (RoomCont.Room_N == 8)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.22");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.23");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.24");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.22");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.23");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.24");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.22");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.23");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.24");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("1,200,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("1,300,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("1,400,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("1,200,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("1,300,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("1,400,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("1,200,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("1,300,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("1,400,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[62 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[63 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[64 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[20];
            s3_3.img_living[1].sprite = s3_3.sprite_2[21];
            s3_3.img_living[2].sprite = s3_3.sprite_2[22];
            s3_3.img_bath[0].sprite = s3_3.sprite[19];
            s3_3.img_bath[1].sprite = s3_3.sprite[20];
            s3_3.img_bath[2].sprite = s3_3.sprite[21];
        }
        if (RoomCont.Room_N == 9)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.25");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.26");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.27");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.25");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.26");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.27");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.25");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.26");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.27");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("1,500,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("1,700,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("1,900,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("1,500,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("1,700,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("1,900,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("1,500,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("1,700,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("1,900,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[65 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[66 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[67 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[23];
            s3_3.img_living[1].sprite = s3_3.sprite_2[24];
            s3_3.img_living[2].sprite = s3_3.sprite_2[25];
            s3_3.img_bath[0].sprite = s3_3.sprite[22];
            s3_3.img_bath[1].sprite = s3_3.sprite[23];
            s3_3.img_bath[2].sprite = s3_3.sprite[24];
        }
        if (RoomCont.Room_N == 10)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.28");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.29");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.30");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.28");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.29");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.30");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.28");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.29");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.30");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("2,200,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("2,500,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("2,800,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("2,200,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("2,500,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("2,800,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("2,200,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("2,500,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("2,800,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[68 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[69 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[70 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[26];
            s3_3.img_living[1].sprite = s3_3.sprite_2[27];
            s3_3.img_living[2].sprite = s3_3.sprite_2[28];
            s3_3.img_bath[0].sprite = s3_3.sprite[25];
            s3_3.img_bath[1].sprite = s3_3.sprite[26];
            s3_3.img_bath[2].sprite = s3_3.sprite[27];
        }
        if (RoomCont.Room_N == 11)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.31");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.32");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.33");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.31");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.32");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.33");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.31");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.32");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.33");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("5,000,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("6,000,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("7,000,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("5,000,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("6,000,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("7,000,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("5,000,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("6,000,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("7,000,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[71 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[72 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[73 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[29];
            s3_3.img_living[1].sprite = s3_3.sprite_2[30];
            s3_3.img_living[2].sprite = s3_3.sprite_2[31];
            s3_3.img_bath[0].sprite = s3_3.sprite[31];
            s3_3.img_bath[1].sprite = s3_3.sprite[31];
            s3_3.img_bath[2].sprite = s3_3.sprite[31];
        }
        if (RoomCont.Room_N == 12)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.34");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.35");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.36");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.34");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.35");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.36");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.34");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.35");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.36");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("20,000,000");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("35,000,000");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("50,000,000");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("20,000,000");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("35,000,000");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("50,000,000");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("20,000,000");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("35,000,000");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("50,000,000");
            s3_3.img_bed[0].sprite = s3_3.sprite[74 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[75 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[76 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[32];
            s3_3.img_living[1].sprite = s3_3.sprite_2[33];
            s3_3.img_living[2].sprite = s3_3.sprite_2[34];
            s3_3.img_bath[0].sprite = s3_3.sprite[28];
            s3_3.img_bath[1].sprite = s3_3.sprite[29];
            s3_3.img_bath[2].sprite = s3_3.sprite[30];
        }
        if (RoomCont.Room_N == 13)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.37");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.38");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.39");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.37");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.38");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.39");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.37");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.38");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.39");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("100million");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("200million");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("400million");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("100million");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("200million");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("400million");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("100million");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("200million");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("400million");
            s3_3.img_bed[0].sprite = s3_3.sprite[77 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[78 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[79 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[35];
            s3_3.img_living[1].sprite = s3_3.sprite_2[36];
            s3_3.img_living[2].sprite = s3_3.sprite_2[37];
            s3_3.img_bath[0].sprite = s3_3.sprite[32];
            s3_3.img_bath[1].sprite = s3_3.sprite[33];
            s3_3.img_bath[2].sprite = s3_3.sprite[34];
        }
        if (RoomCont.Room_N == 14)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.40");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.41");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.42");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.40");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.41");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.42");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.40");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.41");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.42");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("1Billion");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("1Billion");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("1Billion");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.img_bed[0].sprite = s3_3.sprite[80 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[81 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[82 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[38];
            s3_3.img_living[1].sprite = s3_3.sprite_2[39];
            s3_3.img_living[2].sprite = s3_3.sprite_2[40];
            s3_3.img_bath[0].sprite = s3_3.sprite[35];
            s3_3.img_bath[1].sprite = s3_3.sprite[36];
            s3_3.img_bath[2].sprite = s3_3.sprite[37];
        }
        if (RoomCont.Room_N == 15)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.43");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.44");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.45");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.43");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.44");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.45");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.43");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.44");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.45");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("3Billion");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("3Billion");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("1.5Billion");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("2Billion");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("3Billion");
            s3_3.img_bed[0].sprite = s3_3.sprite[83 + 2];
            s3_3.img_bed[1].sprite = s3_3.sprite[84 + 2];
            s3_3.img_bed[2].sprite = s3_3.sprite[85 + 2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[41];
            s3_3.img_living[1].sprite = s3_3.sprite_2[42];
            s3_3.img_living[2].sprite = s3_3.sprite_2[43];
            s3_3.img_bath[0].sprite = s3_3.sprite[38];
            s3_3.img_bath[1].sprite = s3_3.sprite[39];
            s3_3.img_bath[2].sprite = s3_3.sprite[40];
        }
        if (RoomCont.Room_N == 16)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.46");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.47");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.48");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.46");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.47");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.48");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.46");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.47");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.48");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("6Billion");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("12Billion");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("24Billion");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("6Billion");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("12Billion");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("24Billion");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("6Billion");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("12Billion");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("24Billion");
            s3_3.img_bed[0].sprite = s3_3.sprite_3[0];
            s3_3.img_bed[1].sprite = s3_3.sprite_3[1];
            s3_3.img_bed[2].sprite = s3_3.sprite_3[2];
            s3_3.img_living[0].sprite = s3_3.sprite_2[44];
            s3_3.img_living[1].sprite = s3_3.sprite_2[45];
            s3_3.img_living[2].sprite = s3_3.sprite_2[46];
            s3_3.img_bath[0].sprite = s3_3.sprite_3[3];
            s3_3.img_bath[1].sprite = s3_3.sprite_3[4];
            s3_3.img_bath[2].sprite = s3_3.sprite_3[5];
        }
        if (RoomCont.Room_N == 17)
        {
            s3_3.text_lv[0].GetComponent<Text>().text = string.Format("LV.49");
            s3_3.text_lv[1].GetComponent<Text>().text = string.Format("LV.50");
            s3_3.text_lv[2].GetComponent<Text>().text = string.Format("LV.51");
            s3_3.text_lv[3].GetComponent<Text>().text = string.Format("LV.49");
            s3_3.text_lv[4].GetComponent<Text>().text = string.Format("LV.50");
            s3_3.text_lv[5].GetComponent<Text>().text = string.Format("LV.51");
            s3_3.text_lv[6].GetComponent<Text>().text = string.Format("LV.49");
            s3_3.text_lv[7].GetComponent<Text>().text = string.Format("LV.50");
            s3_3.text_lv[8].GetComponent<Text>().text = string.Format("LV.51");
            s3_3.text_fur_money[0].GetComponent<Text>().text = string.Format("50Billion");
            s3_3.text_fur_money[1].GetComponent<Text>().text = string.Format("100Billion");
            s3_3.text_fur_money[2].GetComponent<Text>().text = string.Format("500Billion");
            s3_3.text_fur_money[3].GetComponent<Text>().text = string.Format("50Billion");
            s3_3.text_fur_money[4].GetComponent<Text>().text = string.Format("100Billion");
            s3_3.text_fur_money[5].GetComponent<Text>().text = string.Format("500Billion");
            s3_3.text_fur_money[6].GetComponent<Text>().text = string.Format("50Billion");
            s3_3.text_fur_money[7].GetComponent<Text>().text = string.Format("100Billion");
            s3_3.text_fur_money[8].GetComponent<Text>().text = string.Format("500Billion");
            s3_3.img_bed[0].sprite = s3_3.sprite_3[6];
            s3_3.img_bed[1].sprite = s3_3.sprite_3[7];
            s3_3.img_bed[2].sprite = s3_3.sprite_3[8];
            s3_3.img_living[0].sprite = s3_3.sprite_2[47];
            s3_3.img_living[1].sprite = s3_3.sprite_2[48];
            s3_3.img_living[2].sprite = s3_3.sprite_2[49];
            s3_3.img_bath[0].sprite = s3_3.sprite_3[9];
            s3_3.img_bath[1].sprite = s3_3.sprite_3[10];
            s3_3.img_bath[2].sprite = s3_3.sprite_3[11];
        }
        if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_car_shop()
	{
		scene_controll_2.load_num = 0;
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_4.SetActive(true);
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_clothes_shop()
	{
		scene_controll_2.load_num = 0;
		scene_controll.head_load.SetActive(true);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_5.SetActive(true);
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_hair_shop()
	{
		scene_controll_2.load_num = 0;
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_6.SetActive(true);
		scene_controll.head_load.SetActive(true);
		scene_controll.clothse_load.SetActive(true);
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		Debug.LogFormat("헤어샵들어갈때 옷넘버{0}", Clothes.Clothes_N);
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_pet_shop()
	{
		if (s3_7.PetBuyOK == 0)
		{
			s3_7.pet_load.GetComponent<Image>().sprite = null;
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
		}
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		scene_controll_2.load_num = 0;
		scene_controll.scene_3_1.SetActive(false);
		scene_controll.scene_3_7.SetActive(true);
		scene_controll.pet_load.SetActive(true);
		s3_7.Pet_N[0] = PlayerPrefs.GetInt("pet_0");
		s3_7.Pet_N[1] = PlayerPrefs.GetInt("pet_1");
		s3_7.Pet_N[2] = PlayerPrefs.GetInt("pet_2");
		s3_7.Pet_N[3] = PlayerPrefs.GetInt("pet_3");
		s3_7.Pet_N[4] = PlayerPrefs.GetInt("pet_4");
		s3_7.Pet_N[5] = PlayerPrefs.GetInt("pet_5");
		s3_7.Pet_N[6] = PlayerPrefs.GetInt("pet_6");
		s3_7.Pet_N[7] = PlayerPrefs.GetInt("pet_7");
		s3_7.Pet_N[8] = PlayerPrefs.GetInt("pet_8");
		s3_7.Pet_N[9] = PlayerPrefs.GetInt("pet_9");
		s3_7.Pet_N[10] = PlayerPrefs.GetInt("pet_10");
		s3_7.Pet_N[11] = PlayerPrefs.GetInt("pet_11");
		s3_7.Pet_N[12] = PlayerPrefs.GetInt("pet_12");
		s3_7.Pet_N[13] = PlayerPrefs.GetInt("pet_13");
		s3_7.Pet_N[14] = PlayerPrefs.GetInt("pet_14");
		s3_7.Pet_N[15] = PlayerPrefs.GetInt("pet_15");
		s3_7.Pet_N[16] = PlayerPrefs.GetInt("pet_16");
		s3_7.Pet_N[17] = PlayerPrefs.GetInt("pet_17");
		s3_7.Pet_N[18] = PlayerPrefs.GetInt("pet_18");
		s3_7.Pet_N[19] = PlayerPrefs.GetInt("pet_19");
		s3_7.Pet_N[20] = PlayerPrefs.GetInt("pet_20");
		s3_7.Pet_N[21] = PlayerPrefs.GetInt("pet_21");
		s3_7.Pet_N[22] = PlayerPrefs.GetInt("pet_22");
		s3_7.Pet_N[23] = PlayerPrefs.GetInt("pet_23");
		s3_7.Pet_N[24] = PlayerPrefs.GetInt("pet_24");
		s3_7.Pet_N[25] = PlayerPrefs.GetInt("pet_25");
		if (Pet.Pet_N == 0)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
		}
		if (Pet.Pet_N == 1)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
		}
		if (Pet.Pet_N == 2)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
		}
		if (Pet.Pet_N == 3)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
		}
		if (Pet.Pet_N == 4)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
		}
		if (Pet.Pet_N == 5)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
		}
		if (Pet.Pet_N == 6)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
		}
		if (Pet.Pet_N == 7)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphdog");
		}
		if (Pet.Pet_N == 8)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
		}
		if (Pet.Pet_N == 9)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
		}
		if (Pet.Pet_N == 10)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
		}
		if (Pet.Pet_N == 11)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
		}
		if (Pet.Pet_N == 12)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
		}
		if (Pet.Pet_N == 13)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
		}
		if (Pet.Pet_N == 14)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
		}
		if (Pet.Pet_N == 15)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
		}
		if (Pet.Pet_N == 16)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
		}
		if (Pet.Pet_N == 17)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
		}
		if (Pet.Pet_N == 18)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
		}
		if (Pet.Pet_N == 19)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
		}
		if (Pet.Pet_N == 20)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
		}
		if (Pet.Pet_N == 21)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
		}
		if (Pet.Pet_N == 22)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
		}
		if (Pet.Pet_N == 23)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
		}
		if (Pet.Pet_N == 24)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
		}
		if (Pet.Pet_N == 25)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
		}
		if (s3_7.PetBuyOK == 0)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
	}
}
