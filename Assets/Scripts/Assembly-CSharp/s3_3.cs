using UnityEngine;
using UnityEngine.UI;

public class s3_3 : MonoBehaviour
{
	public scene_controll scene_controll;

	public s3_7 s3_7;

	public s3_2 s3_2;

	public GameObject[] bed_panel_lock;

	public GameObject[] living_panel_lock;

	public GameObject[] toilet_panel_lock;

	public int[] bed_num;

	public int[] living_num;

	public int[] toilet_num;

	public Transform real_buy_price;

	public Transform home_lv;

	public Image[] img_bed;

	public Image[] img_living;

	public Image[] img_bath;

	public Sprite[] sprite;

	public Sprite[] sprite_2;

	public Sprite[] sprite_3;

	public Transform[] text_lv;

	public Transform[] text_fur_money;

	public long fur_money;

	public string fur_money_Text;

	public GameObject TutoFurn_T;

	public GameObject BackBtn;

	public Transform Tuto_Set;

	private void Awake()
	{
		fur_money = 0L;
		fur_money_Text = fur_money.ToString();
		fur_money = long.Parse(fur_money_Text);
		Debug.Log("Scene_String" + CashCont.Scene_String);
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N", RoomCont.Room_N);
		if (RoomCont.Room_N == 0)
		{
			RoomCont.Room_N = 1;
		}
		home_lv.GetComponent<Text>().text = string.Format("{0}", RoomCont.Room_N);
		Debug.LogFormat("집레벨{0}", RoomCont.Room_N);
		sprite = Resources.LoadAll<Sprite>("fur_bath");
		sprite_2 = Resources.LoadAll<Sprite>("fur_ki");
		sprite_3 = Resources.LoadAll<Sprite>("fur_bath_2");
		bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
		Debug.Log("침대넘버" + FurnCont.Bed_N);
		Debug.Log("키친넘버" + FurnCont.Kitchen_N);
		Debug.Log("장실넘버" + FurnCont.Toilet_N);
		if (bed_num[0] == 0 && bed_num[1] == 0 && bed_num[2] == 0)
		{
			bed_panel_lock[0].GetComponent<Button>().interactable = true;
			bed_panel_lock[1].GetComponent<Button>().interactable = false;
			bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (bed_num[0] == 1 && bed_num[1] == 0 && bed_num[2] == 0)
		{
			bed_panel_lock[0].GetComponent<Button>().interactable = false;
			bed_panel_lock[1].GetComponent<Button>().interactable = true;
			bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (bed_num[0] == 1 && bed_num[1] == 1 && bed_num[2] == 0)
		{
			bed_panel_lock[0].GetComponent<Button>().interactable = false;
			bed_panel_lock[1].GetComponent<Button>().interactable = false;
			bed_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (bed_num[0] == 1 && bed_num[1] == 1 && bed_num[2] == 1)
		{
			bed_panel_lock[0].GetComponent<Button>().interactable = false;
			bed_panel_lock[1].GetComponent<Button>().interactable = false;
			bed_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (living_num[0] == 0 && living_num[1] == 0 && living_num[2] == 0)
		{
			living_panel_lock[0].GetComponent<Button>().interactable = true;
			living_panel_lock[1].GetComponent<Button>().interactable = false;
			living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (living_num[0] == 1 && living_num[1] == 0 && living_num[2] == 0)
		{
			living_panel_lock[0].GetComponent<Button>().interactable = false;
			living_panel_lock[1].GetComponent<Button>().interactable = true;
			living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (living_num[0] == 1 && living_num[1] == 1 && living_num[2] == 0)
		{
			living_panel_lock[0].GetComponent<Button>().interactable = false;
			living_panel_lock[1].GetComponent<Button>().interactable = false;
			living_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (living_num[0] == 1 && living_num[1] == 1 && living_num[2] == 1)
		{
			living_panel_lock[0].GetComponent<Button>().interactable = false;
			living_panel_lock[1].GetComponent<Button>().interactable = false;
			living_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (toilet_num[0] == 0 && toilet_num[1] == 0 && toilet_num[2] == 0)
		{
			toilet_panel_lock[0].GetComponent<Button>().interactable = true;
			toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (toilet_num[0] == 1 && toilet_num[1] == 0 && toilet_num[2] == 0)
		{
			toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			toilet_panel_lock[1].GetComponent<Button>().interactable = true;
			toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (toilet_num[0] == 1 && toilet_num[1] == 1 && toilet_num[2] == 0)
		{
			toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			toilet_panel_lock[2].GetComponent<Button>().interactable = true;
		}
		if (toilet_num[0] == 1 && toilet_num[1] == 1 && toilet_num[2] == 1)
		{
			toilet_panel_lock[0].GetComponent<Button>().interactable = false;
			toilet_panel_lock[1].GetComponent<Button>().interactable = false;
			toilet_panel_lock[2].GetComponent<Button>().interactable = false;
		}
		if (RoomCont.Room_N == 1)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.1");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.2");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.3");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.1");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.2");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.3");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.1");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.2");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.3");
			text_fur_money[0].GetComponent<Text>().text = string.Format("10,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("100,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("150,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("10,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("100,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("150,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("10,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("100,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("150,000");
			img_bed[0].sprite = sprite[41 + 2];
			img_bed[1].sprite = sprite[42 + 2];
			img_bed[2].sprite = sprite[43 + 2];
			img_living[0].sprite = sprite_2[0];
			img_living[1].sprite = sprite_2[1];
			img_living[2].sprite = sprite_2[2];
			img_bath[0].sprite = sprite[0];
			img_bath[1].sprite = sprite[1];
			img_bath[2].sprite = sprite[2];
		}
		if (RoomCont.Room_N == 2)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.4");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.5");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.6");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.4");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.5");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.6");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.4");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.5");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.6");
			text_fur_money[0].GetComponent<Text>().text = string.Format("200,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("250,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("300,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("200,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("250,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("300,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("200,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("250,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("300,000");
			img_bed[0].sprite = sprite[44 + 2];
			img_bed[1].sprite = sprite[45 + 2];
			img_bed[2].sprite = sprite[46 + 2];
			img_living[0].sprite = sprite_2[3];
			img_living[1].sprite = sprite_2[4];
			img_living[2].sprite = sprite_2[5];
			img_bath[0].sprite = sprite[2];
			img_bath[1].sprite = sprite[2];
			img_bath[2].sprite = sprite[3];
		}
		if (RoomCont.Room_N == 3)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.7");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.8");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.9");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.7");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.8");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.9");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.7");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.8");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.9");
			text_fur_money[0].GetComponent<Text>().text = string.Format("350,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("400,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("450,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("350,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("400,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("450,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("350,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("400,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("450,000");
			img_bed[0].sprite = sprite[47 + 2];
			img_bed[1].sprite = sprite[48 + 2];
			img_bed[2].sprite = sprite[49 + 2];
			img_living[0].sprite = sprite_2[6];
			img_living[1].sprite = sprite_2[7];
			img_living[2].sprite = sprite_2[8];
			img_bath[0].sprite = sprite[4];
			img_bath[1].sprite = sprite[5];
			img_bath[2].sprite = sprite[6];
		}
		if (RoomCont.Room_N == 4)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.10");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.11");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.12");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.10");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.11");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.12");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.10");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.11");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.12");
			text_fur_money[0].GetComponent<Text>().text = string.Format("500,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("550,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("600,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("500,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("550,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("600,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("500,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("550,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("600,000");
			img_bed[0].sprite = sprite[50 + 2];
			img_bed[1].sprite = sprite[51 + 2];
			img_bed[2].sprite = sprite[52 + 2];
			img_living[0].sprite = sprite_2[9];
			img_living[1].sprite = sprite_2[10];
			img_living[2].sprite = sprite_2[10];
			img_bath[0].sprite = sprite[7];
			img_bath[1].sprite = sprite[8];
			img_bath[2].sprite = sprite[9];
		}
		if (RoomCont.Room_N == 5)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.13");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.14");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.15");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.13");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.14");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.15");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.13");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.14");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.15");
			text_fur_money[0].GetComponent<Text>().text = string.Format("650,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("700,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("750,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("650,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("700,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("750,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("650,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("700,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("750,000");
			img_bed[0].sprite = sprite[53 + 2];
			img_bed[1].sprite = sprite[54 + 2];
			img_bed[2].sprite = sprite[55 + 2];
			img_living[0].sprite = sprite_2[12];
			img_living[1].sprite = sprite_2[13];
			img_living[2].sprite = sprite_2[14];
			img_bath[0].sprite = sprite[10];
			img_bath[1].sprite = sprite[11];
			img_bath[2].sprite = sprite[12];
		}
		if (RoomCont.Room_N == 6)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.16");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.17");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.18");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.16");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.17");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.18");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.16");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.17");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.18");
			text_fur_money[0].GetComponent<Text>().text = string.Format("800,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("850,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("900,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("800,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("850,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("900,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("800,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("850,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("900,000");
			img_bed[0].sprite = sprite[56 + 2];
			img_bed[1].sprite = sprite[57 + 2];
			img_bed[2].sprite = sprite[58 + 2];
			img_living[0].sprite = sprite_2[14];
			img_living[1].sprite = sprite_2[15];
			img_living[2].sprite = sprite_2[16];
			img_bath[0].sprite = sprite[13];
			img_bath[1].sprite = sprite[14];
			img_bath[2].sprite = sprite[15];
		}
		if (RoomCont.Room_N == 7)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.19");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.20");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.21");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.19");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.20");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.21");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.19");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.20");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.21");
			text_fur_money[0].GetComponent<Text>().text = string.Format("950,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("1,000,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("1,100,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("950,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("1,000,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("1,100,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("950,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("1,000,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("1,100,000");
			img_bed[0].sprite = sprite[59 + 2];
			img_bed[1].sprite = sprite[60 + 2];
			img_bed[2].sprite = sprite[61 + 2];
			img_living[0].sprite = sprite_2[17];
			img_living[1].sprite = sprite_2[18];
			img_living[2].sprite = sprite_2[19];
			img_bath[0].sprite = sprite[16];
			img_bath[1].sprite = sprite[17];
			img_bath[2].sprite = sprite[18];
		}
		if (RoomCont.Room_N == 8)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.22");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.23");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.24");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.22");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.23");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.24");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.22");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.23");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.24");
			text_fur_money[0].GetComponent<Text>().text = string.Format("1,200,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("1,300,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("1,400,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("1,200,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("1,300,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("1,400,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("1,200,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("1,300,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("1,400,000");
			img_bed[0].sprite = sprite[62 + 2];
			img_bed[1].sprite = sprite[63 + 2];
			img_bed[2].sprite = sprite[64 + 2];
			img_living[0].sprite = sprite_2[20];
			img_living[1].sprite = sprite_2[21];
			img_living[2].sprite = sprite_2[22];
			img_bath[0].sprite = sprite[19];
			img_bath[1].sprite = sprite[20];
			img_bath[2].sprite = sprite[21];
		}
		if (RoomCont.Room_N == 9)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.25");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.26");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.27");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.25");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.26");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.27");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.25");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.26");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.27");
			text_fur_money[0].GetComponent<Text>().text = string.Format("1,500,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("1,700,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("1,900,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("1,500,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("1,700,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("1,900,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("1,500,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("1,700,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("1,900,000");
			img_bed[0].sprite = sprite[65 + 2];
			img_bed[1].sprite = sprite[66 + 2];
			img_bed[2].sprite = sprite[67 + 2];
			img_living[0].sprite = sprite_2[23];
			img_living[1].sprite = sprite_2[24];
			img_living[2].sprite = sprite_2[25];
			img_bath[0].sprite = sprite[22];
			img_bath[1].sprite = sprite[23];
			img_bath[2].sprite = sprite[24];
		}
		if (RoomCont.Room_N == 10)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.28");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.29");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.30");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.28");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.29");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.30");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.28");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.29");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.30");
			text_fur_money[0].GetComponent<Text>().text = string.Format("2,200,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("2,500,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("2,800,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("2,200,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("2,500,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("2,800,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("2,200,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("2,500,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("2,800,000");
			img_bed[0].sprite = sprite[68 + 2];
			img_bed[1].sprite = sprite[69 + 2];
			img_bed[2].sprite = sprite[70 + 2];
			img_living[0].sprite = sprite_2[26];
			img_living[1].sprite = sprite_2[27];
			img_living[2].sprite = sprite_2[28];
			img_bath[0].sprite = sprite[25];
			img_bath[1].sprite = sprite[26];
			img_bath[2].sprite = sprite[27];
		}
		if (RoomCont.Room_N == 11)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.31");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.32");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.33");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.31");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.32");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.33");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.31");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.32");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.33");
			text_fur_money[0].GetComponent<Text>().text = string.Format("5,000,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("6,000,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("7,000,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("5,000,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("6,000,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("7,000,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("5,000,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("6,000,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("7,000,000");
			img_bed[0].sprite = sprite[71 + 2];
			img_bed[1].sprite = sprite[72 + 2];
			img_bed[2].sprite = sprite[73 + 2];
			img_living[0].sprite = sprite_2[29];
			img_living[1].sprite = sprite_2[30];
			img_living[2].sprite = sprite_2[31];
			img_bath[0].sprite = sprite[31];
			img_bath[1].sprite = sprite[31];
			img_bath[2].sprite = sprite[31];
		}
		if (RoomCont.Room_N == 12)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.34");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.35");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.36");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.34");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.35");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.36");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.34");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.35");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.36");
			text_fur_money[0].GetComponent<Text>().text = string.Format("20,000,000");
			text_fur_money[1].GetComponent<Text>().text = string.Format("35,000,000");
			text_fur_money[2].GetComponent<Text>().text = string.Format("50,000,000");
			text_fur_money[3].GetComponent<Text>().text = string.Format("20,000,000");
			text_fur_money[4].GetComponent<Text>().text = string.Format("35,000,000");
			text_fur_money[5].GetComponent<Text>().text = string.Format("50,000,000");
			text_fur_money[6].GetComponent<Text>().text = string.Format("20,000,000");
			text_fur_money[7].GetComponent<Text>().text = string.Format("35,000,000");
			text_fur_money[8].GetComponent<Text>().text = string.Format("50,000,000");
			img_bed[0].sprite = sprite[74 + 2];
			img_bed[1].sprite = sprite[75 + 2];
			img_bed[2].sprite = sprite[76 + 2];
			img_living[0].sprite = sprite_2[32];
			img_living[1].sprite = sprite_2[33];
			img_living[2].sprite = sprite_2[34];
			img_bath[0].sprite = sprite[28];
			img_bath[1].sprite = sprite[29];
			img_bath[2].sprite = sprite[30];
		}
		if (RoomCont.Room_N == 13)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.37");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.38");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.39");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.37");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.38");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.39");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.37");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.38");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.39");
			text_fur_money[0].GetComponent<Text>().text = string.Format("100million");
			text_fur_money[1].GetComponent<Text>().text = string.Format("200million");
			text_fur_money[2].GetComponent<Text>().text = string.Format("400million");
			text_fur_money[3].GetComponent<Text>().text = string.Format("100million");
			text_fur_money[4].GetComponent<Text>().text = string.Format("200million");
			text_fur_money[5].GetComponent<Text>().text = string.Format("400million");
			text_fur_money[6].GetComponent<Text>().text = string.Format("100million");
			text_fur_money[7].GetComponent<Text>().text = string.Format("200million");
			text_fur_money[8].GetComponent<Text>().text = string.Format("400million");
			img_bed[0].sprite = sprite[77 + 2];
			img_bed[1].sprite = sprite[78 + 2];
			img_bed[2].sprite = sprite[79 + 2];
			img_living[0].sprite = sprite_2[35];
			img_living[1].sprite = sprite_2[36];
			img_living[2].sprite = sprite_2[37];
			img_bath[0].sprite = sprite[32];
			img_bath[1].sprite = sprite[33];
			img_bath[2].sprite = sprite[34];
		}
		if (RoomCont.Room_N == 14)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.40");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.41");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.42");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.40");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.41");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.42");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.40");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.41");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.42");
			text_fur_money[0].GetComponent<Text>().text = string.Format("1Billion");
			text_fur_money[1].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[2].GetComponent<Text>().text = string.Format("2Billion");
			text_fur_money[3].GetComponent<Text>().text = string.Format("1Billion");
			text_fur_money[4].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[5].GetComponent<Text>().text = string.Format("2Billion");
			text_fur_money[6].GetComponent<Text>().text = string.Format("1Billion");
			text_fur_money[7].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[8].GetComponent<Text>().text = string.Format("2Billion");
			img_bed[0].sprite = sprite[80 + 2];
			img_bed[1].sprite = sprite[81 + 2];
			img_bed[2].sprite = sprite[82 + 2];
			img_living[0].sprite = sprite_2[38];
			img_living[1].sprite = sprite_2[39];
			img_living[2].sprite = sprite_2[40];
			img_bath[0].sprite = sprite[35];
			img_bath[1].sprite = sprite[36];
			img_bath[2].sprite = sprite[37];
		}
		if (RoomCont.Room_N == 15)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.43");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.44");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.45");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.43");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.44");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.45");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.43");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.44");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.45");
			text_fur_money[0].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[1].GetComponent<Text>().text = string.Format("2Billion");
			text_fur_money[2].GetComponent<Text>().text = string.Format("3Billion");
			text_fur_money[3].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[4].GetComponent<Text>().text = string.Format("2Billion");
			text_fur_money[5].GetComponent<Text>().text = string.Format("3Billion");
			text_fur_money[6].GetComponent<Text>().text = string.Format("1.5Billion");
			text_fur_money[7].GetComponent<Text>().text = string.Format("2Billion");
			text_fur_money[8].GetComponent<Text>().text = string.Format("3Billion");
			img_bed[0].sprite = sprite[83 + 2];
			img_bed[1].sprite = sprite[84 + 2];
			img_bed[2].sprite = sprite[85 + 2];
			img_living[0].sprite = sprite_2[41];
			img_living[1].sprite = sprite_2[42];
			img_living[2].sprite = sprite_2[43];
			img_bath[0].sprite = sprite[38];
			img_bath[1].sprite = sprite[39];
			img_bath[2].sprite = sprite[40];
		}
		if (RoomCont.Room_N == 16)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.46");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.47");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.48");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.46");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.47");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.48");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.46");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.47");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.48");
			text_fur_money[0].GetComponent<Text>().text = string.Format("6Billion");
			text_fur_money[1].GetComponent<Text>().text = string.Format("12Billion");
			text_fur_money[2].GetComponent<Text>().text = string.Format("24Billion");
			text_fur_money[3].GetComponent<Text>().text = string.Format("6Billion");
			text_fur_money[4].GetComponent<Text>().text = string.Format("12Billion");
			text_fur_money[5].GetComponent<Text>().text = string.Format("24Billion");
			text_fur_money[6].GetComponent<Text>().text = string.Format("6Billion");
			text_fur_money[7].GetComponent<Text>().text = string.Format("12Billion");
			text_fur_money[8].GetComponent<Text>().text = string.Format("24Billion");
			img_bed[0].sprite = sprite_3[0];
			img_bed[1].sprite = sprite_3[1];
			img_bed[2].sprite = sprite_3[2];
			img_living[0].sprite = sprite_2[44];
			img_living[1].sprite = sprite_2[45];
			img_living[2].sprite = sprite_2[46];
			img_bath[0].sprite = sprite_3[3];
			img_bath[1].sprite = sprite_3[4];
			img_bath[2].sprite = sprite_3[5];
		}
		if (RoomCont.Room_N == 17)
		{
			text_lv[0].GetComponent<Text>().text = string.Format("LV.49");
			text_lv[1].GetComponent<Text>().text = string.Format("LV.50");
			text_lv[2].GetComponent<Text>().text = string.Format("LV.51");
			text_lv[3].GetComponent<Text>().text = string.Format("LV.49");
			text_lv[4].GetComponent<Text>().text = string.Format("LV.50");
			text_lv[5].GetComponent<Text>().text = string.Format("LV.51");
			text_lv[6].GetComponent<Text>().text = string.Format("LV.49");
			text_lv[7].GetComponent<Text>().text = string.Format("LV.50");
			text_lv[8].GetComponent<Text>().text = string.Format("LV.51");
			text_fur_money[0].GetComponent<Text>().text = string.Format("50Billion");
			text_fur_money[1].GetComponent<Text>().text = string.Format("100Billion");
			text_fur_money[2].GetComponent<Text>().text = string.Format("500Billion");
			text_fur_money[3].GetComponent<Text>().text = string.Format("50Billion");
			text_fur_money[4].GetComponent<Text>().text = string.Format("100Billion");
			text_fur_money[5].GetComponent<Text>().text = string.Format("500Billion");
			text_fur_money[6].GetComponent<Text>().text = string.Format("50Billion");
			text_fur_money[7].GetComponent<Text>().text = string.Format("100Billion");
			text_fur_money[8].GetComponent<Text>().text = string.Format("500Billion");
			img_bed[0].sprite = sprite_3[6];
			img_bed[1].sprite = sprite_3[7];
			img_bed[2].sprite = sprite_3[8];
			img_living[0].sprite = sprite_2[47];
			img_living[1].sprite = sprite_2[48];
			img_living[2].sprite = sprite_2[49];
			img_bath[0].sprite = sprite_3[9];
			img_bath[1].sprite = sprite_3[10];
			img_bath[2].sprite = sprite_3[11];
		}
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
	}

	public void back()
	{
		scene_controll.scene_3_3.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		fur_money = 0L;
		CashCont.Scene_String = "3-1";
		Resources.UnloadUnusedAssets();
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = GameObject.Find("Tuto_2(Clone)");
			gameObject.GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_bed_0()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		bed_num[0] = 1;
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.1"))
		{
			fur_money = 10000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.4"))
		{
			fur_money = 200000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.7"))
		{
			fur_money = 350000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.10"))
		{
			fur_money = 500000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.13"))
		{
			fur_money = 650000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.16"))
		{
			fur_money = 800000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.19"))
		{
			fur_money = 950000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.22"))
		{
			fur_money = 1200000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.25"))
		{
			fur_money = 1500000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.28"))
		{
			fur_money = 2200000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.31"))
		{
			fur_money = 5000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.34"))
		{
			fur_money = 20000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.37"))
		{
			fur_money = 100000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.40"))
		{
			fur_money = 1000000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.43"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.46"))
		{
			fur_money = 6000000000L;
		}
		if (text_lv[0].GetComponent<Text>().text == string.Format("LV.49"))
		{
			fur_money = 50000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_bed_1()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		bed_num[1] = 1;
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.2"))
		{
			fur_money = 100000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.5"))
		{
			fur_money = 250000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.8"))
		{
			fur_money = 400000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.11"))
		{
			fur_money = 550000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.14"))
		{
			fur_money = 700000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.17"))
		{
			fur_money = 850000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.20"))
		{
			fur_money = 1000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.23"))
		{
			fur_money = 1300000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.26"))
		{
			fur_money = 1700000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.29"))
		{
			fur_money = 2500000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.32"))
		{
			fur_money = 6000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.35"))
		{
			fur_money = 35000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.38"))
		{
			fur_money = 200000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.41"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.44"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.47"))
		{
			fur_money = 12000000000L;
		}
		if (text_lv[1].GetComponent<Text>().text == string.Format("LV.50"))
		{
			fur_money = 100000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_bed_2()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		bed_num[2] = 1;
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.3"))
		{
			fur_money = 150000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.6"))
		{
			fur_money = 300000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.9"))
		{
			fur_money = 450000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.12"))
		{
			fur_money = 600000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.15"))
		{
			fur_money = 750000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.18"))
		{
			fur_money = 900000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.21"))
		{
			fur_money = 1100000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.24"))
		{
			fur_money = 1400000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.27"))
		{
			fur_money = 1900000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.30"))
		{
			fur_money = 2800000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.33"))
		{
			fur_money = 7000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.36"))
		{
			fur_money = 50000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.39"))
		{
			fur_money = 400000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.42"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.45"))
		{
			fur_money = 3000000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.48"))
		{
			fur_money = 24000000000L;
		}
		if (text_lv[2].GetComponent<Text>().text == string.Format("LV.51"))
		{
			fur_money = 500000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_living_0()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		living_num[0] = 1;
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.1"))
		{
			fur_money = 10000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.4"))
		{
			fur_money = 200000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.7"))
		{
			fur_money = 350000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.10"))
		{
			fur_money = 500000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.13"))
		{
			fur_money = 650000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.16"))
		{
			fur_money = 800000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.19"))
		{
			fur_money = 950000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.22"))
		{
			fur_money = 1200000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.25"))
		{
			fur_money = 1500000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.28"))
		{
			fur_money = 2200000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.31"))
		{
			fur_money = 5000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.34"))
		{
			fur_money = 20000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.37"))
		{
			fur_money = 100000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.40"))
		{
			fur_money = 1000000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.43"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.46"))
		{
			fur_money = 6000000000L;
		}
		if (text_lv[3].GetComponent<Text>().text == string.Format("LV.49"))
		{
			fur_money = 50000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_living_1()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		living_num[1] = 1;
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.2"))
		{
			fur_money = 100000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.5"))
		{
			fur_money = 250000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.8"))
		{
			fur_money = 400000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.11"))
		{
			fur_money = 550000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.14"))
		{
			fur_money = 700000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.17"))
		{
			fur_money = 850000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.20"))
		{
			fur_money = 1000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.23"))
		{
			fur_money = 1300000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.26"))
		{
			fur_money = 1700000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.29"))
		{
			fur_money = 2500000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.32"))
		{
			fur_money = 6000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.35"))
		{
			fur_money = 35000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.38"))
		{
			fur_money = 200000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.41"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.44"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.47"))
		{
			fur_money = 12000000000L;
		}
		if (text_lv[4].GetComponent<Text>().text == string.Format("LV.50"))
		{
			fur_money = 100000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_living_2()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		living_num[2] = 1;
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.3"))
		{
			fur_money = 150000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.6"))
		{
			fur_money = 300000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.9"))
		{
			fur_money = 450000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.12"))
		{
			fur_money = 600000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.15"))
		{
			fur_money = 750000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.18"))
		{
			fur_money = 900000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.21"))
		{
			fur_money = 1100000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.24"))
		{
			fur_money = 1400000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.27"))
		{
			fur_money = 1900000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.30"))
		{
			fur_money = 2800000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.33"))
		{
			fur_money = 7000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.36"))
		{
			fur_money = 50000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.39"))
		{
			fur_money = 400000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.42"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.45"))
		{
			fur_money = 3000000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.48"))
		{
			fur_money = 24000000000L;
		}
		if (text_lv[5].GetComponent<Text>().text == string.Format("LV.51"))
		{
			fur_money = 500000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_toilet_0()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		toilet_num[0] = 1;
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.1"))
		{
			fur_money = 10000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.4"))
		{
			fur_money = 200000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.7"))
		{
			fur_money = 350000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.10"))
		{
			fur_money = 500000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.13"))
		{
			fur_money = 650000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.16"))
		{
			fur_money = 800000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.19"))
		{
			fur_money = 950000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.22"))
		{
			fur_money = 1200000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.25"))
		{
			fur_money = 1500000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.28"))
		{
			fur_money = 2200000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.31"))
		{
			fur_money = 5000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.34"))
		{
			fur_money = 20000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.37"))
		{
			fur_money = 100000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.40"))
		{
			fur_money = 1000000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.43"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.46"))
		{
			fur_money = 6000000000L;
		}
		if (text_lv[6].GetComponent<Text>().text == string.Format("LV.49"))
		{
			fur_money = 50000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_toilet_1()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		toilet_num[1] = 1;
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.2"))
		{
			fur_money = 100000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.5"))
		{
			fur_money = 250000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.8"))
		{
			fur_money = 400000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.11"))
		{
			fur_money = 550000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.14"))
		{
			fur_money = 70000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.17"))
		{
			fur_money = 850000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.20"))
		{
			fur_money = 1000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.23"))
		{
			fur_money = 1300000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.26"))
		{
			fur_money = 1700000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.29"))
		{
			fur_money = 2500000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.32"))
		{
			fur_money = 6000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.35"))
		{
			fur_money = 35000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.38"))
		{
			fur_money = 200000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.41"))
		{
			fur_money = 1500000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.44"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.47"))
		{
			fur_money = 12000000000L;
		}
		if (text_lv[7].GetComponent<Text>().text == string.Format("LV.50"))
		{
			fur_money = 100000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void btn_toilet_2()
	{
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		scene_controll.panel_notice[7].SetActive(true);
		toilet_num[2] = 1;
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.3"))
		{
			fur_money = 150000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.6"))
		{
			fur_money = 300000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.9"))
		{
			fur_money = 450000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.12"))
		{
			fur_money = 600000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.15"))
		{
			fur_money = 750000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.18"))
		{
			fur_money = 900000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.21"))
		{
			fur_money = 1100000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.24"))
		{
			fur_money = 1400000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.27"))
		{
			fur_money = 1900000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.30"))
		{
			fur_money = 2800000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.33"))
		{
			fur_money = 7000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.36"))
		{
			fur_money = 50000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.39"))
		{
			fur_money = 400000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.42"))
		{
			fur_money = 2000000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.45"))
		{
			fur_money = 3000000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.48"))
		{
			fur_money = 24000000000L;
		}
		if (text_lv[8].GetComponent<Text>().text == string.Format("LV.51"))
		{
			fur_money = 500000000000L;
		}
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", fur_money);
		fur_Change();
		if (scene_controll.money < fur_money)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
		if (fur_money == 0L)
		{
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[3].SetActive(false);
			scene_controll.panel_notice[2].SetActive(true);
			scene_controll.panel_notice[7].SetActive(false);
			Invoke("nothing", 1f);
		}
	}

	private void fur_Change()
	{
		if (fur_money <= 0)
		{
			fur_money = 0L;
		}
		long num = fur_money % 1000000000000L;
		long num2 = fur_money % 100000000;
		long num3 = fur_money % 10000;
		long num4 = fur_money % 1;
		if (fur_money >= 1000000000000L)
		{
			long num5 = fur_money / 1000000000000L;
			long num6 = (fur_money - num5 * 1000000000000L) / 100000000;
			if (fur_money - num5 * 1000000000000L <= 0)
			{
				real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}G", fur_money);
			}
			else
			{
				real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}G", fur_money);
			}
		}
		if (fur_money >= 100000000 && fur_money < 1000000000000L)
		{
			long num7 = fur_money / 100000000;
			if (fur_money - num7 * 100000000 <= 0)
			{
				real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}G", fur_money);
			}
			else
			{
				real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}G", fur_money);
			}
		}
		if (fur_money < 100000000)
		{
			real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}G", fur_money);
		}
	}

	private void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}
}
