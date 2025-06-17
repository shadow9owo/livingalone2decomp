using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class S2_4 : MonoBehaviour
{
	public GameObject scroll_cont;

	public PtjManager _PtjManager;

	public GameObject s2_5_;

	public GameObject s2_4_;

	public GameObject s2_6_;

	public static int PartTime_N;

	public Transform money_window;

	public static int conviAlba;

	public static int cafeAlba;

	public static int takbaeAlba;

	public static int factoryAlba;

	public static int studyAlba;

	public Button Goback;

	public Button adsbtn;

	public Button adsbtn2;

	public static float AlbaTime;

	public GameObject[] btn_lock_alba;

	public Sprite[] change_hair;

	public Sprite[] change_hair_2;

	public Sprite[] change_hair_3;

	public Image[] hair_img2;

	public Image[] hair_img;

	public Animator[] Ani_man_load;

	public GameObject[] Ani_controll;

	public Image pivot_bottom;

	public Image pivot_top;

	public GameObject vacation_mode;

	public static int ptj_date = 1;

	public static long final_money;

	public int get_money_;

	public Transform ptj_date_transform;

	public Transform ptj_text_transform;

	public Transform final_money_window;

	public Transform final_money_window2;

	public Transform plus_hp;

	public Transform plus_mp;

	public Transform plus_int;

	public Transform plus_happy;

	public Transform s_Plus_hp;

	public Transform s_Plus_mp;

	public Transform s_Plus_happy;

	public Transform s_Plus_int;

	public Transform s_Plus_point;

	public static int Changed_hp;

	public static int Changed_mp;

	public static int Changed_st;

	public static int Changed_int;

	public static int Changed_happy;

	public static int Alba_hp;

	public static int Alba_mp;

	public static int Alba_st;

	public static int Alba_int;

	public static int Alba_happy;

	public AudioClip get_money;

	public int rand;

	public GameObject[] result_panel;

	public GameObject Ani_plus_money;

	public GameObject Ani_plus_smart;

	public Transform Ani_plus_money_text;

	public Image[] alba_in_head;

	public GameObject[] Ani_total_controller;

	public GameObject[] ptj_study;

	public Transform month_fee;

	public Transform grade_;

	public Transform class_sco;

	public static int month_fee_;

	public GameObject[] icon_class;

	public Sprite[] sprite;

	public Image[] img_study;

	public static int S_class;

	public static int Y_class;

	public static int M_class;

	public static int E_class;

	public int[] class_sco_plus;

	public Transform class_sco_text;

	public GameObject[] result_icon;

	public Transform sco_S_text;

	public Transform sco_Y_text;

	public Transform sco_M_text;

	public Transform sco_E_text;

	public Transform cash;

	public static float Buff_pluspay;

	public GameObject _coin_ani;

	public GameObject[] title_name;

	public GameObject exam_no;

	public float examtime;

	public static int Albapaybuff;

	public GameObject Albabufftext;

	public Sprite[] uni_sprite;

	public Image uni_bg;

	public Sprite[] uni_clo_sprite_m;

	public Sprite[] uni_clo_sprite_m_2;

	public Sprite[] uni_clo_sprite_w;

	public Sprite[] uni_clo_sprite_w_2;

	public float[] Alba_Level;

	public Animator clothse_load;

	public Animator head_load;

	public Animator clothse_load_lover;

	public Animator head_load_lover;

	public GameObject[] select_uni;

	public Image[] uni_head;

	public Image[] uni_clo;

	public int uni_select_int;

	public Sprite[] Lover_M_hair;

	public Sprite[] Lover_W_hair;

	public Sprite[] Lover_M_clothes;

	public Sprite[] Lover_W_clothes;

	public Image lover_health;

	public Image lover_pub;

	public Image lover_pub_clo;

	public Image lover_club;

	public Image lover_jjim;

	public GameObject lover_obj_health;

	public GameObject lover_obj_pub;

	public GameObject lover_obj_club;

	public GameObject lover_obj_jjim;

	public int uni_sco;

	public Transform uni_sco_text;

	private float time = 15f;

	public Transform uni_time_text;

	public Text final_uni_sco;

	public Text final_uni_desire;

	public Text final_uni_money;

	public int final_uni_sco_int;

	public int final_uni_de_int;

	public int final_uni_mo_int;

	public Image jjim_sprite;

	public Image pub_sprite;

	public Image health_sprite;

	public Transform clear_sco_text;

	public int clear_sco;

	public int uni_sco_int_1;

	public int uni_sco_int_2;

	public int uni_sco_int_3;

	public int uni_sco_int_4;

	public Sprite[] uni_sprite_everything;

	public AlbaTextCont _AlbaTextCont;

	public Alba_BarCont _Alba_BarCont;

	public static int Q_AlbaN;

	public static int Q_StudyN;

	public static int Alba_N;

	public static long AlbaPayMoney;

	public static long albamon_1;

	public static long albamon_2;

	public static long albamon_3;

	public static long albamon_4;

	public static long albamon_5;

	public static long albamon_6;

	public static long albamon_7;

	public static long albamon_8;

	public static long albamon_9;

	public static long albamon_10;

	public static float Plusall_hp;

	public static float Plusall_mp;

	public static float Plusall_happy;

	public static float Plusall_int;

	public static int Random_hp;

	public static int Random_mp;

	public static int Random_happy;

	public static int Random_int;

	public static float Plusall_point;

	public static float Random_point;

	public GameObject Textbox;

	public GameObject[] uni_icon;

	public GameObject[] btn_true_false;

	public Sprite[] Uni_little_icon;

	public Image Uni_icon_img;

	public GameObject Closer_sco_T;

	public static int DidAlba;

	private void Start()
	{
		CashCont.Scene_String = "ptj";
		s2_4_.SetActive(true);
		s2_5_.SetActive(false);
		for (int i = 0; i < result_panel.Length; i++)
		{
			result_panel[i].SetActive(false);
		}
		_coin_ani.SetActive(false);
		final_money = 0L;
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		scene_controll.gem = SPrefs.GetInt("gem2");
		TimeBuff.Buffer_N = PlayerPrefs.GetInt("Buffer_N");
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		if (Pet.Pet_N == 24 || Pet.Pet_N == 25)
		{
			if (TimeBuff.Buffer_N == 0)
			{
				AlbaTime = 0.4f;
				examtime = 3.6000001f;
			}
			if (TimeBuff.Buffer_N == 1)
			{
				AlbaTime = 0.120000005f;
				examtime = 1.08f;
			}
		}
		else
		{
			if (TimeBuff.Buffer_N == 0)
			{
				AlbaTime = 2f;
				examtime = 18f;
			}
			if (TimeBuff.Buffer_N == 1)
			{
				AlbaTime = 0.6f;
				examtime = 5.4f;
			}
		}
		Char.Sex = PlayerPrefs.GetInt("Sex");
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		BarCont.hp = PlayerPrefs.GetFloat("hp");
		BarCont.mp = PlayerPrefs.GetFloat("mp");
		BarCont._int = PlayerPrefs.GetFloat("int");
		BarCont.happy = PlayerPrefs.GetFloat("happy");
		BarCont.point = PlayerPrefs.GetFloat("point");
		BarCont.st = PlayerPrefs.GetFloat("st");
		_Alba_BarCont.AlbaClick();
		_Alba_BarCont.StudyClick();
		TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
		TimeCont.Grade = PlayerPrefs.GetInt("Grade");
		S_class = PlayerPrefs.GetInt("S_class");
		Y_class = PlayerPrefs.GetInt("Y_class");
		M_class = PlayerPrefs.GetInt("M_class");
		E_class = PlayerPrefs.GetInt("E_class");
		change_hair = Resources.LoadAll<Sprite>("Head_man");
		change_hair_2 = Resources.LoadAll<Sprite>("Head_woman");
        change_hair_3 = change_hair.Concat(change_hair_2).ToArray();
        uni_clo_sprite_m = Resources.LoadAll<Sprite>("Clothes_man");
		uni_clo_sprite_m_2 = Resources.LoadAll<Sprite>("Clothes_man_2");
		uni_clo_sprite_w = Resources.LoadAll<Sprite>("Clothes_woman");
		uni_clo_sprite_w_2 = Resources.LoadAll<Sprite>("Clothes_woman_2_moreman");
		PlayerPrefs.GetFloat("minushairpoint_W", s3_7.minushairpoint_W);
		cash.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
		for (int j = 0; j < title_name.Length; j++)
		{
			title_name[j].SetActive(false);
		}
		if (scene_controll_2.Ptj_N == 3)
		{
			title_name[1].SetActive(true);
			Invoke("btn_exam", 0.001f);
			exam_no.SetActive(false);
		}
		if (scene_controll_2.Ptj_N == 4)
		{
			uni_sprite = Resources.LoadAll<Sprite>("uni_street");
			title_name[2].SetActive(true);
			Ani_plus_smart.SetActive(false);
			uni_clothes();
			for (int k = 0; k < ptj_study.Length; k++)
			{
				ptj_study[k].SetActive(false);
				ptj_study[5].SetActive(true);
			}
			for (int l = 0; l < hair_img2.Length; l++)
			{
				if (Head.Hair_N == 0)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[1];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[1];
					}
				}
				if (Head.Hair_N == 1)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[5];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[5];
					}
				}
				if (Head.Hair_N == 2)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[9];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[9];
					}
				}
				if (Head.Hair_N == 3)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[13];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[13];
					}
				}
				if (Head.Hair_N == 4)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[17];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[17];
					}
				}
				if (Head.Hair_N == 5)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[21];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[21];
					}
				}
				if (Head.Hair_N == 6)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[25];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[25];
					}
				}
				if (Head.Hair_N == 7)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[29];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[29];
					}
				}
				if (Head.Hair_N == 8)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[33];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[33];
					}
				}
				if (Head.Hair_N == 9)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[37];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[37];
					}
				}
				if (Head.Hair_N == 10)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[41];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[41];
					}
				}
				if (Head.Hair_N == 11)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[45];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[45];
					}
				}
				if (Head.Hair_N == 12)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[49];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[49];
					}
				}
				if (Head.Hair_N == 13)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[53];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[53];
					}
				}
				if (Head.Hair_N == 14)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[57];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[57];
					}
				}
				if (Head.Hair_N == 15)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[61];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[61];
					}
				}
				if (Head.Hair_N == 16)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[65];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[65];
					}
				}
				if (Head.Hair_N == 17)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[69];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[69];
					}
				}
				if (Head.Hair_N == 18)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[73];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[73];
					}
				}
				if (Head.Hair_N == 19)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[77];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[77];
					}
				}
				if (Head.Hair_N == 20)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[81];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[81];
					}
				}
				if (Head.Hair_N == 21)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[85];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[85];
					}
				}
				if (Head.Hair_N == 22)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[89];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[89];
					}
				}
				if (Head.Hair_N == 23)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[93];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[93];
					}
				}
				if (Head.Hair_N == 24)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[97];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[97];
					}
				}
				if (Head.Hair_N == 25)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[101];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[101];
					}
				}
				if (Head.Hair_N == 26)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[105];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[105];
					}
				}
				if (Head.Hair_N == 27)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[109];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[109];
					}
				}
				if (Head.Hair_N == 28)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[113];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[113];
					}
				}
				if (Head.Hair_N == 29)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair[117];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_2[117];
					}
				}
				if (Head.Hair_N == 30)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[13];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[1];
					}
				}
				if (Head.Hair_N == 31)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[17];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[5];
					}
				}
				if (Head.Hair_N == 32)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[21];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[9];
					}
				}
				if (Head.Hair_N == 33)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[25];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[25];
					}
				}
				if (Head.Hair_N == 34)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[63];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[51];
					}
				}
				if (Head.Hair_N == 35)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[67];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[55];
					}
				}
				if (Head.Hair_N == 36)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[71];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[59];
					}
				}
				if (Head.Hair_N == 37)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[79];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[75];
					}
				}
				if (Head.Hair_N == 38)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[87];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[83];
					}
				}
				if (Head.Hair_N == 39)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[91];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[95];
					}
				}
				if (Head.Hair_N == 40)
				{
					if (Char.Sex == 0)
					{
						hair_img2[l].sprite = change_hair_3[103];
					}
					if (Char.Sex == 1)
					{
						hair_img2[l].sprite = change_hair_3[99];
					}
				}
			}
		}
		if (scene_controll_2.Ptj_N == 2)
		{
			exam_no.SetActive(true);
			sco_S_text.GetComponent<Text>().text = string.Format("{0}", S_class);
			sco_Y_text.GetComponent<Text>().text = string.Format("{0}", Y_class);
			sco_M_text.GetComponent<Text>().text = string.Format("{0}", M_class);
			sco_E_text.GetComponent<Text>().text = string.Format("{0}", E_class);
			title_name[1].SetActive(true);
			for (int m = 0; m < ptj_study.Length; m++)
			{
				ptj_study[m].SetActive(false);
				ptj_study[1].SetActive(true);
			}
			sprite = Resources.LoadAll<Sprite>("ptj_ani_2");
			if ((RoomCont.Room_N == 1) | (RoomCont.Room_N == 0))
			{
				month_fee_ = 100000;
			}
			if (RoomCont.Room_N == 2)
			{
				month_fee_ = 200000;
			}
			if (RoomCont.Room_N == 3)
			{
				month_fee_ = 290000;
			}
			if (RoomCont.Room_N == 4)
			{
				month_fee_ = 400000;
			}
			if (RoomCont.Room_N == 5)
			{
				month_fee_ = 500000;
			}
			if (RoomCont.Room_N == 6)
			{
				month_fee_ = 600000;
			}
			if (RoomCont.Room_N == 7)
			{
				month_fee_ = 700000;
			}
			if (RoomCont.Room_N == 8)
			{
				month_fee_ = 800000;
			}
			if (RoomCont.Room_N == 9)
			{
				month_fee_ = 900000;
			}
			if (RoomCont.Room_N == 10)
			{
				month_fee_ = 1000000;
			}
			if (RoomCont.Room_N == 11)
			{
				month_fee_ = 1100000;
			}
			if (RoomCont.Room_N == 12)
			{
				month_fee_ = 1200000;
			}
			if (RoomCont.Room_N == 13)
			{
				month_fee_ = 1290000;
			}
			if (RoomCont.Room_N == 14)
			{
				month_fee_ = 1400000;
			}
			if (RoomCont.Room_N == 15)
			{
				month_fee_ = 1500000;
			}
			if (RoomCont.Room_N == 16)
			{
				month_fee_ = 1600000;
			}
			if (RoomCont.Room_N == 17)
			{
				month_fee_ = 1700000;
			}
			month_fee.GetComponent<Text>().text = string.Format("-{0:n0}G", 10000 * RoomCont.Room_N);
			grade_.GetComponent<Text>().text = string.Format("{0}", TimeCont.Grade);
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			Goback.GetComponent<Button>().interactable = false;
		}
		else
		{
			Goback.GetComponent<Button>().interactable = true;
		}
		if (scene_controll_2.Ptj_N == 1)
		{
			title_name[0].SetActive(true);
			Ani_plus_smart.SetActive(false);
			for (int n = 0; n < ptj_study.Length; n++)
			{
				ptj_study[n].SetActive(false);
				ptj_study[0].SetActive(true);
			}
			for (int num = 0; num < hair_img.Length; num++)
			{
				if (Head.Hair_N == 0)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[1];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[1];
					}
				}
				if (Head.Hair_N == 1)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[5];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[5];
					}
				}
				if (Head.Hair_N == 2)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[9];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[9];
					}
				}
				if (Head.Hair_N == 3)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[13];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[13];
					}
				}
				if (Head.Hair_N == 4)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[17];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[17];
					}
				}
				if (Head.Hair_N == 5)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[21];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[21];
					}
				}
				if (Head.Hair_N == 6)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[25];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[25];
					}
				}
				if (Head.Hair_N == 7)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[29];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[29];
					}
				}
				if (Head.Hair_N == 8)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[33];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[33];
					}
				}
				if (Head.Hair_N == 9)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[37];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[37];
					}
				}
				if (Head.Hair_N == 10)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[41];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[41];
					}
				}
				if (Head.Hair_N == 11)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[45];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[45];
					}
				}
				if (Head.Hair_N == 12)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[49];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[49];
					}
				}
				if (Head.Hair_N == 13)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[53];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[53];
					}
				}
				if (Head.Hair_N == 14)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[57];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[57];
					}
				}
				if (Head.Hair_N == 15)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[61];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[61];
					}
				}
				if (Head.Hair_N == 16)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[65];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[65];
					}
				}
				if (Head.Hair_N == 17)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[69];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[69];
					}
				}
				if (Head.Hair_N == 18)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[73];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[73];
					}
				}
				if (Head.Hair_N == 19)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[77];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[77];
					}
				}
				if (Head.Hair_N == 20)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[81];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[81];
					}
				}
				if (Head.Hair_N == 21)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[85];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[85];
					}
				}
				if (Head.Hair_N == 22)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[89];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[89];
					}
				}
				if (Head.Hair_N == 23)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[93];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[93];
					}
				}
				if (Head.Hair_N == 24)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[97];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[97];
					}
				}
				if (Head.Hair_N == 25)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[101];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[101];
					}
				}
				if (Head.Hair_N == 26)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[105];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[105];
					}
				}
				if (Head.Hair_N == 27)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[109];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[109];
					}
				}
				if (Head.Hair_N == 28)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[113];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[113];
					}
				}
				if (Head.Hair_N == 29)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair[117];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_2[117];
					}
				}
				if (Head.Hair_N == 30)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[13];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[1];
					}
				}
				if (Head.Hair_N == 31)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[17];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[5];
					}
				}
				if (Head.Hair_N == 32)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[21];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[9];
					}
				}
				if (Head.Hair_N == 33)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[25];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[25];
					}
				}
				if (Head.Hair_N == 34)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[63];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[51];
					}
				}
				if (Head.Hair_N == 35)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[67];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[55];
					}
				}
				if (Head.Hair_N == 36)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[71];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[59];
					}
				}
				if (Head.Hair_N == 37)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[79];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[75];
					}
				}
				if (Head.Hair_N == 38)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[87];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[83];
					}
				}
				if (Head.Hair_N == 39)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[91];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[95];
					}
				}
				if (Head.Hair_N == 40)
				{
					if (Char.Sex == 0)
					{
						hair_img[num].sprite = change_hair_3[103];
					}
					if (Char.Sex == 1)
					{
						hair_img[num].sprite = change_hair_3[99];
					}
				}
			}
			for (int num2 = 0; num2 < btn_lock_alba.Length; num2++)
			{
				btn_lock_alba[num2].GetComponent<Button>().interactable = false;
				if (RoomCont.Room_N == 1)
				{
					btn_lock_alba[0].GetComponent<Button>().interactable = true;
				}
				if (RoomCont.Room_N == 2)
				{
					btn_lock_alba[0].GetComponent<Button>().interactable = true;
					btn_lock_alba[1].GetComponent<Button>().interactable = true;
				}
				if (RoomCont.Room_N == 3)
				{
					btn_lock_alba[0].GetComponent<Button>().interactable = true;
					btn_lock_alba[1].GetComponent<Button>().interactable = true;
					btn_lock_alba[2].GetComponent<Button>().interactable = true;
				}
				if (RoomCont.Room_N == 4)
				{
					btn_lock_alba[0].GetComponent<Button>().interactable = true;
					btn_lock_alba[1].GetComponent<Button>().interactable = true;
					btn_lock_alba[2].GetComponent<Button>().interactable = true;
					btn_lock_alba[3].GetComponent<Button>().interactable = true;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, -7f, 0f);
				}
				if (RoomCont.Room_N == 5)
				{
					btn_lock_alba[0].GetComponent<Button>().interactable = true;
					btn_lock_alba[1].GetComponent<Button>().interactable = true;
					btn_lock_alba[2].GetComponent<Button>().interactable = true;
					btn_lock_alba[3].GetComponent<Button>().interactable = true;
					btn_lock_alba[4].GetComponent<Button>().interactable = true;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, -4.8f, 0f);
				}
				if (RoomCont.Room_N == 6)
				{
					btn_lock_alba[num2].GetComponent<Button>().interactable = true;
					btn_lock_alba[6].GetComponent<Button>().interactable = false;
					btn_lock_alba[7].GetComponent<Button>().interactable = false;
					btn_lock_alba[8].GetComponent<Button>().interactable = false;
					btn_lock_alba[9].GetComponent<Button>().interactable = false;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, -4f, 0f);
				}
				if (RoomCont.Room_N == 7)
				{
					btn_lock_alba[num2].GetComponent<Button>().interactable = true;
					btn_lock_alba[7].GetComponent<Button>().interactable = false;
					btn_lock_alba[8].GetComponent<Button>().interactable = false;
					btn_lock_alba[9].GetComponent<Button>().interactable = false;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, -2f, 0f);
				}
				if (RoomCont.Room_N == 8)
				{
					btn_lock_alba[num2].GetComponent<Button>().interactable = true;
					btn_lock_alba[8].GetComponent<Button>().interactable = false;
					btn_lock_alba[9].GetComponent<Button>().interactable = false;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, -1.2f, 0f);
				}
				if (RoomCont.Room_N == 9)
				{
					btn_lock_alba[num2].GetComponent<Button>().interactable = true;
					btn_lock_alba[9].GetComponent<Button>().interactable = false;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, 0.5f, 0f);
				}
				if ((RoomCont.Room_N == 10) | (RoomCont.Room_N == 11) | (RoomCont.Room_N == 12) | (RoomCont.Room_N == 13) | (RoomCont.Room_N == 14) | (RoomCont.Room_N == 15) | (RoomCont.Room_N == 16) | (RoomCont.Room_N == 17))
				{
					btn_lock_alba[num2].GetComponent<Button>().interactable = true;
					scroll_cont.GetComponent<RectTransform>().position = new Vector3(0f, 1.5f, 0f);
				}
			}
		}
		scene_controll_2.load_num = 0;
		ptj_date = 0;
		Plusall_hp = 0f;
		Plusall_mp = 0f;
		Plusall_happy = 0f;
		Plusall_int = 0f;
		Plusall_point = 0f;
	}

	public void SetLv()
	{
		Alba_Level[0] = PlayerPrefs.GetFloat("Alba_Lv[0]");
		Alba_Level[1] = PlayerPrefs.GetFloat("Alba_Lv[1]");
		Alba_Level[2] = PlayerPrefs.GetFloat("Alba_Lv[2]");
		Alba_Level[3] = PlayerPrefs.GetFloat("Alba_Lv[3]");
		Alba_Level[4] = PlayerPrefs.GetFloat("Alba_Lv[4]");
		Alba_Level[5] = PlayerPrefs.GetFloat("Alba_Lv[5]");
		Alba_Level[6] = PlayerPrefs.GetFloat("Alba_Lv[6]");
		Alba_Level[7] = PlayerPrefs.GetFloat("Alba_Lv[7]");
		Alba_Level[8] = PlayerPrefs.GetFloat("Alba_Lv[8]");
		Alba_Level[9] = PlayerPrefs.GetFloat("Alba_Lv[9]");
		albamon_1 = 29000 + (long)(Alba_Level[0] * 1000f);
		albamon_2 = 38000 + (long)(Alba_Level[1] * 2000f);
		albamon_3 = 45000 + (long)(Alba_Level[2] * 5000f);
		albamon_4 = 48000 + (long)(Alba_Level[3] * 7000f);
		albamon_5 = 50000 + (long)(Alba_Level[4] * 10000f);
		albamon_6 = 50000 + (long)(Alba_Level[5] * 15000f);
		albamon_7 = 40000 + (long)(Alba_Level[6] * 30000f);
		albamon_8 = 30000 + (long)(Alba_Level[7] * 50000f);
		albamon_9 = 10000 + (long)(Alba_Level[8] * 80000f);
		albamon_10 = 0 + (long)(Alba_Level[9] * 100000f);
	}

	private void FixedUpdate()
	{
		final_money_window2.GetComponent<Text>().text = string.Format("{0:n0}G", final_money);
		ptj_date_transform.GetComponent<Text>().text = string.Format("{0:n0}", ptj_date);
		Ani_plus_money_text.GetComponent<Text>().text = string.Format("+{0:n0}", get_money_);
		if (icon_class[0].activeSelf)
		{
			class_sco.GetComponent<Text>().text = string.Format("{0}", S_class);
		}
		if (icon_class[1].activeSelf)
		{
			class_sco.GetComponent<Text>().text = string.Format("{0}", Y_class);
		}
		if (icon_class[2].activeSelf)
		{
			class_sco.GetComponent<Text>().text = string.Format("{0}", M_class);
		}
		if (icon_class[3].activeSelf)
		{
			class_sco.GetComponent<Text>().text = string.Format("{0}", E_class);
		}
		if (TutorialCont.Tutorial_Int == 1)
		{
			if (s2_5_.activeInHierarchy)
			{
				GameObject.Find("btn_cash").GetComponent<Button>().interactable = false;
			}
			else
			{
				GameObject.Find("btn_cash").GetComponent<Button>().interactable = true;
			}
		}
	}

	public void btn_health()
	{
		select_uni[0].SetActive(true);
		s2_4_.SetActive(false);
		s2_6_.SetActive(true);
		uni_hair();
		Goback.GetComponent<Button>().interactable = false;
		GameObject.Find("btn_cash").GetComponent<Button>().interactable = false;
		uni_select_int = 1;
		if (Lovercont.Phone == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				lover_health.sprite = Lover_M_hair[LoverHead.L_Hair_N];
			}
			if (LoverChar.L_Sex == 1)
			{
				lover_health.sprite = Lover_W_hair[LoverHead.L_Hair_N];
			}
			lover_obj_health.SetActive(true);
		}
		else
		{
			lover_obj_health.SetActive(false);
		}
	}

	public void btn_pub()
	{
		select_uni[1].SetActive(true);
		s2_4_.SetActive(false);
		s2_6_.SetActive(true);
		uni_hair();
		uni_clothes();
		Goback.GetComponent<Button>().interactable = false;
		GameObject.Find("btn_cash").GetComponent<Button>().interactable = false;
		uni_select_int = 2;
		if (Lovercont.Phone == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				lover_pub.sprite = Lover_M_hair[LoverHead.L_Hair_N];
				lover_pub_clo.sprite = Lover_M_clothes[LoverClothes.L_Clothes_N];
			}
			if (LoverChar.L_Sex == 1)
			{
				lover_pub.sprite = Lover_W_hair[LoverHead.L_Hair_N];
				lover_pub_clo.sprite = Lover_W_clothes[LoverClothes.L_Clothes_N];
			}
			lover_obj_pub.SetActive(true);
		}
		else
		{
			lover_obj_pub.SetActive(false);
		}
	}

	public void btn_club()
	{
		select_uni[2].SetActive(true);
		s2_4_.SetActive(false);
		s2_6_.SetActive(true);
		club_clo_hair();
		club_clo_hair2();
		Goback.GetComponent<Button>().interactable = false;
		GameObject.Find("btn_cash").GetComponent<Button>().interactable = false;
		uni_select_int = 3;
		if (Lovercont.Phone == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				lover_club.sprite = Lover_M_hair[LoverHead.L_Hair_N];
			}
			if (LoverChar.L_Sex == 1)
			{
				lover_club.sprite = Lover_W_hair[LoverHead.L_Hair_N];
			}
			lover_obj_club.SetActive(true);
		}
		else
		{
			lover_obj_club.SetActive(false);
		}
	}

	public void btn_jjim()
	{
		select_uni[3].SetActive(true);
		s2_4_.SetActive(false);
		s2_6_.SetActive(true);
		uni_hair();
		Goback.GetComponent<Button>().interactable = false;
		GameObject.Find("btn_cash").GetComponent<Button>().interactable = false;
		uni_select_int = 4;
		if (Lovercont.Phone == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				lover_jjim.sprite = Lover_M_hair[LoverHead.L_Hair_N];
			}
			if (LoverChar.L_Sex == 1)
			{
				lover_jjim.sprite = Lover_W_hair[LoverHead.L_Hair_N];
			}
			lover_obj_jjim.SetActive(true);
		}
		else
		{
			lover_obj_jjim.SetActive(false);
		}
	}

	private void Update()
	{
		if (!s2_6_.activeSelf)
		{
			return;
		}
		if ((double)time > 0.01)
		{
			time -= Time.deltaTime;
			uni_time_text.GetComponent<Text>().text = string.Format("{0:f3}", time);
			return;
		}
		uni_time_text.GetComponent<Text>().text = string.Format("0s");
		if (!result_panel[3].activeSelf)
		{
			return;
		}
		if (Lovercont.Phone == 1)
		{
			if (uni_sco < 1000)
			{
				if (final_uni_sco_int < uni_sco + clear_sco * 30)
				{
					final_uni_sco_int += 10;
				}
				else
				{
					final_uni_sco_int = final_uni_sco_int;
					final_sco_stop();
				}
			}
			if (uni_sco >= 1000)
			{
				if (final_uni_sco_int < uni_sco + clear_sco * 30)
				{
					final_uni_sco_int += 100;
				}
				else
				{
					final_uni_sco_int = final_uni_sco_int;
					final_sco_stop();
				}
			}
		}
		else
		{
			if (uni_sco < 1000)
			{
				if (final_uni_sco_int < uni_sco + clear_sco * 30)
				{
					final_uni_sco_int += 10;
				}
				else
				{
					final_uni_sco_int = final_uni_sco_int;
					final_sco_stop();
				}
			}
			if (uni_sco >= 1000)
			{
				if (final_uni_sco_int < uni_sco + clear_sco * 30)
				{
					final_uni_sco_int += 100;
				}
				else
				{
					final_uni_sco_int = final_uni_sco_int;
					final_sco_stop();
				}
			}
		}
		final_uni_sco.GetComponent<Text>().text = string.Format("{0}", final_uni_sco_int);
	}

	public void final_sco_stop()
	{
		final_uni_sco_int = uni_sco + clear_sco * 30;
		final_uni_sco.GetComponent<Text>().text = string.Format("{0}", uni_sco + clear_sco * 30);
	}

	public void uni_tap()
	{
		if (uni_time_text.GetComponent<Text>().text == string.Format("0s"))
		{
			Invoke("ResultScreen_4", 0f);
		}
		if (Lovercont.Phone == 1)
		{
			uni_sco += 10 + Lovercont.LoverLv;
		}
		else
		{
			uni_sco += 10;
		}
		clear_sco = uni_sco / 800;
		clear_sco_text.GetComponent<Text>().text = string.Format("x{0}", clear_sco);
		uni_sco_text.GetComponent<Text>().text = string.Format("{0}", uni_sco);
		if (uni_select_int == 1)
		{
			if (uni_sco < 200)
			{
				health_sprite.sprite = uni_sprite[26];
			}
			if (uni_sco > 400 && uni_sco < 600)
			{
				health_sprite.sprite = uni_sprite[27];
			}
			if (uni_sco > 600 && uni_sco < 800)
			{
				health_sprite.sprite = uni_sprite[28];
			}
			if (uni_sco > 800 && uni_sco < 1000)
			{
				health_sprite.sprite = uni_sprite[26];
			}
			if (uni_sco > 1000 && uni_sco < 1200)
			{
				health_sprite.sprite = uni_sprite[27];
			}
			if (uni_sco > 1200 && uni_sco < 1400)
			{
				health_sprite.sprite = uni_sprite[28];
			}
			if (uni_sco > 1400 && uni_sco < 1600)
			{
				health_sprite.sprite = uni_sprite[26];
			}
			if (uni_sco > 1600 && uni_sco < 1800)
			{
				health_sprite.sprite = uni_sprite[27];
			}
			if (uni_sco > 1800 && uni_sco < 2000)
			{
				health_sprite.sprite = uni_sprite[28];
			}
			if (uni_sco > 2000 && uni_sco < 2200)
			{
				health_sprite.sprite = uni_sprite[26];
			}
			if (uni_sco > 2200 && uni_sco < 2400)
			{
				health_sprite.sprite = uni_sprite[27];
			}
			if (uni_sco > 2400 && uni_sco < 2600)
			{
				health_sprite.sprite = uni_sprite[28];
			}
			if (uni_sco > 2600 && uni_sco < 2800)
			{
				health_sprite.sprite = uni_sprite[26];
			}
			if (uni_sco > 2800 && uni_sco < 3000)
			{
				health_sprite.sprite = uni_sprite[27];
			}
			if (uni_sco > 3000 && uni_sco < 3200)
			{
				health_sprite.sprite = uni_sprite[28];
			}
		}
		if (uni_select_int == 2)
		{
			if (uni_sco < 200)
			{
				pub_sprite.sprite = uni_sprite[23];
			}
			if (uni_sco > 400 && uni_sco < 600)
			{
				pub_sprite.sprite = uni_sprite[24];
			}
			if (uni_sco > 600 && uni_sco < 800)
			{
				pub_sprite.sprite = uni_sprite[25];
			}
			if (uni_sco > 800 && uni_sco < 1000)
			{
				pub_sprite.sprite = uni_sprite[23];
			}
			if (uni_sco > 1000 && uni_sco < 1200)
			{
				pub_sprite.sprite = uni_sprite[24];
			}
			if (uni_sco > 1200 && uni_sco < 1400)
			{
				pub_sprite.sprite = uni_sprite[25];
			}
			if (uni_sco > 1400 && uni_sco < 1600)
			{
				pub_sprite.sprite = uni_sprite[23];
			}
			if (uni_sco > 1600 && uni_sco < 1800)
			{
				pub_sprite.sprite = uni_sprite[24];
			}
			if (uni_sco > 1800 && uni_sco < 2000)
			{
				pub_sprite.sprite = uni_sprite[25];
			}
			if (uni_sco > 2000 && uni_sco < 2200)
			{
				pub_sprite.sprite = uni_sprite[23];
			}
			if (uni_sco > 2200 && uni_sco < 2400)
			{
				pub_sprite.sprite = uni_sprite[24];
			}
			if (uni_sco > 2400 && uni_sco < 2600)
			{
				pub_sprite.sprite = uni_sprite[25];
			}
			if (uni_sco > 2600 && uni_sco < 2800)
			{
				pub_sprite.sprite = uni_sprite[23];
			}
			if (uni_sco > 2800 && uni_sco < 3000)
			{
				pub_sprite.sprite = uni_sprite[24];
			}
			if (uni_sco > 3000 && uni_sco < 3200)
			{
				pub_sprite.sprite = uni_sprite[25];
			}
		}
		if (uni_select_int == 4)
		{
			if (uni_sco < 200)
			{
				jjim_sprite.sprite = uni_sprite[17];
			}
			if (uni_sco > 400 && uni_sco < 600)
			{
				jjim_sprite.sprite = uni_sprite[18];
			}
			if (uni_sco > 600 && uni_sco < 800)
			{
				jjim_sprite.sprite = uni_sprite[19];
			}
			if (uni_sco > 800 && uni_sco < 1000)
			{
				jjim_sprite.sprite = uni_sprite[17];
			}
			if (uni_sco > 1000 && uni_sco < 1200)
			{
				jjim_sprite.sprite = uni_sprite[18];
			}
			if (uni_sco > 1200 && uni_sco < 1400)
			{
				jjim_sprite.sprite = uni_sprite[19];
			}
			if (uni_sco > 1400 && uni_sco < 1600)
			{
				jjim_sprite.sprite = uni_sprite[17];
			}
			if (uni_sco > 1600 && uni_sco < 1800)
			{
				jjim_sprite.sprite = uni_sprite[18];
			}
			if (uni_sco > 1800 && uni_sco < 2000)
			{
				jjim_sprite.sprite = uni_sprite[19];
			}
			if (uni_sco > 2000 && uni_sco < 2200)
			{
				jjim_sprite.sprite = uni_sprite[17];
			}
			if (uni_sco > 2200 && uni_sco < 2400)
			{
				jjim_sprite.sprite = uni_sprite[18];
			}
			if (uni_sco > 2400 && uni_sco < 2600)
			{
				jjim_sprite.sprite = uni_sprite[19];
			}
			if (uni_sco > 2600 && uni_sco < 2800)
			{
				jjim_sprite.sprite = uni_sprite[17];
			}
			if (uni_sco > 2800 && uni_sco < 3000)
			{
				jjim_sprite.sprite = uni_sprite[18];
			}
			if (uni_sco > 3000 && uni_sco < 3200)
			{
				jjim_sprite.sprite = uni_sprite[19];
			}
		}
	}

	public void Btn_AlbaText()
	{
	}

	public void btn_event_ptj()
	{
		Alba_N = 1;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[0].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_bottom.sprite = Resources.Load<Sprite>("ptj_1");
		Ani_controll[1].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_mac_ptj()
	{
		Alba_N = 2;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[1].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[2];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[2];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[6];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[6];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[10];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[10];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[14];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[18];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[22];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[26];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[30];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[30];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[34];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[34];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[38];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[38];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[42];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[42];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[46];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[46];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[50];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[50];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[54];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[54];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[58];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[58];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[62];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[62];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[66];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[66];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[70];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[70];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[74];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[74];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[78];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[78];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[82];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[82];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[86];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[86];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[90];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[90];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[94];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[94];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[98];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[98];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[102];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[102];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[106];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[106];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[110];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[110];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[114];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[114];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair[118];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_2[118];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[2];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[6];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[10];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[26];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[64];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[52];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[68];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[56];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[72];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[60];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[80];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[76];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[88];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[84];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[95];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[0].sprite = change_hair_3[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[0].sprite = change_hair_3[99];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_2");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_convenience_ptj()
	{
		Alba_N = 3;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[2].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[2];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[2];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[6];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[6];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[10];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[10];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[14];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[18];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[22];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[26];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[30];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[30];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[34];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[34];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[38];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[38];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[42];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[42];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[46];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[46];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[50];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[50];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[54];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[54];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[58];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[58];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[62];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[62];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[66];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[66];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[70];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[70];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[74];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[74];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[78];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[78];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[82];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[82];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[86];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[86];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[90];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[90];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[94];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[94];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[98];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[98];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[102];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[102];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[106];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[106];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[110];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[110];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[114];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[114];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair[118];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_2[118];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[2];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[6];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[10];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[26];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[64];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[52];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[68];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[56];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[72];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[60];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[80];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[76];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[88];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[84];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[92];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[96];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[1].sprite = change_hair_3[104];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[1].sprite = change_hair_3[100];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_3");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_clo_store_ptj()
	{
		Alba_N = 4;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[3].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[2];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[2];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[6];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[6];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[10];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[10];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[14];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[18];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[22];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[26];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[30];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[30];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[34];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[34];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[38];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[38];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[42];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[42];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[46];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[46];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[50];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[50];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[54];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[54];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[58];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[58];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[62];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[62];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[66];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[66];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[70];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[70];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[74];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[74];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[78];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[78];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[82];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[82];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[86];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[86];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[90];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[90];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[94];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[94];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[98];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[98];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[102];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[102];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[106];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[106];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[110];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[110];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[114];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[114];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair[118];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_2[118];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[2];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[6];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[10];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[26];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[64];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[52];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[68];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[56];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[72];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[60];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[80];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[76];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[88];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[84];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[92];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[96];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[2].sprite = change_hair_3[104];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[2].sprite = change_hair_3[100];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_4");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_cafe_ptj()
	{
		Alba_N = 5;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[4].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[2];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[2];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[6];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[6];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[10];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[10];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[14];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[18];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[22];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[26];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[30];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[30];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[34];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[34];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[38];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[38];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[42];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[42];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[46];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[46];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[50];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[50];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[54];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[54];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[58];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[58];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[62];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[62];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[66];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[66];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[70];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[70];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[74];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[74];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[78];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[78];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[82];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[82];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[86];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[86];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[90];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[90];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[94];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[94];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[98];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[98];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[102];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[102];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[106];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[106];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[110];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[110];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[114];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[114];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair[118];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_2[118];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[2];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[6];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[10];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[26];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[64];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[52];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[68];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[56];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[72];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[60];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[80];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[76];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[88];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[84];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[92];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[96];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[3].sprite = change_hair_3[104];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[3].sprite = change_hair_3[100];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_bottom.sprite = Resources.Load<Sprite>("ptj_5");
		Ani_controll[1].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_rest_ptj()
	{
		Alba_N = 6;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[5].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[2];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[2];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[6];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[6];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[10];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[10];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[14];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[18];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[22];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[26];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[30];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[30];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[34];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[34];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[38];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[38];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[42];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[42];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[46];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[46];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[50];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[50];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[54];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[54];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[58];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[58];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[62];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[62];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[66];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[66];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[70];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[70];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[74];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[74];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[78];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[78];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[82];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[82];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[86];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[86];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[90];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[90];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[94];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[94];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[98];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[98];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[102];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[102];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[106];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[106];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[110];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[110];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[114];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[114];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair[118];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_2[118];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[14];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[2];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[18];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[6];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[22];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[10];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[26];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[26];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[64];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[52];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[68];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[56];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[72];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[60];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[80];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[76];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[88];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[84];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[92];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[96];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[4].sprite = change_hair_3[104];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[4].sprite = change_hair_3[100];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_6");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.0001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_tak_ptj()
	{
		Alba_N = 7;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[6].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[1];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[1];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[5];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[5];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[9];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[9];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[13];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[17];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[21];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[25];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[29];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[29];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[33];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[33];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[37];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[37];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[41];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[41];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[45];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[45];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[49];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[49];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[53];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[53];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[57];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[57];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[61];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[61];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[65];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[65];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[69];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[69];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[73];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[73];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[77];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[77];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[81];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[81];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[85];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[85];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[89];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[89];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[93];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[93];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[97];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[97];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[101];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[101];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[105];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[105];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[109];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[109];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[113];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[113];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair[117];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_2[117];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[1];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[5];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[9];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[25];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[63];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[51];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[67];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[55];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[71];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[59];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[79];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[75];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[87];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[83];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[95];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[5].sprite = change_hair_3[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[5].sprite = change_hair_3[99];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_7");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.0001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_tele_ptj()
	{
		Alba_N = 8;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[7].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[1];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[1];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[5];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[5];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[9];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[9];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[13];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[17];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[21];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[25];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[29];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[29];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[33];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[33];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[37];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[37];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[41];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[41];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[45];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[45];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[49];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[49];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[53];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[53];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[57];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[57];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[61];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[61];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[65];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[65];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[69];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[69];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[73];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[73];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[77];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[77];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[81];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[81];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[85];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[85];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[89];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[89];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[93];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[93];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[97];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[97];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[101];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[101];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[105];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[105];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[109];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[109];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[113];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[113];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair[117];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_2[117];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[1];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[5];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[9];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[25];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[63];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[51];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[67];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[55];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[71];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[59];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[79];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[75];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[87];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[83];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[95];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[6].sprite = change_hair_3[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[6].sprite = change_hair_3[99];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_8");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.0001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_hard_ptj()
	{
		Alba_N = 9;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[8].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[1];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[1];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[5];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[5];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[9];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[9];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[13];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[17];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[21];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[25];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[29];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[29];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[33];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[33];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[37];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[37];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[41];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[41];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[45];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[45];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[49];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[49];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[53];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[53];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[57];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[57];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[61];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[61];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[65];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[65];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[69];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[69];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[73];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[73];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[77];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[77];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[81];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[81];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[85];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[85];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[89];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[89];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[93];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[93];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[97];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[97];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[101];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[101];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[105];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[105];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[109];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[109];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[113];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[113];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair[117];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_2[117];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[1];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[5];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[9];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[25];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[63];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[51];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[67];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[55];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[71];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[59];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[79];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[75];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[87];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[83];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[95];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[7].sprite = change_hair_3[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[7].sprite = change_hair_3[99];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_9");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		Ani_plus_money.SetActive(false);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.0001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void btn_aca_ptj()
	{
		Alba_N = 10;
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[9].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[2].SetActive(true);
			ptj_study[4].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[1];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[1];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[5];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[5];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[9];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[9];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[13];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[17];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[21];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[25];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[29];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[29];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[33];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[33];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[37];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[37];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[41];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[41];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[45];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[45];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[49];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[49];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[53];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[53];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[57];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[57];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[61];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[61];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[65];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[65];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[69];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[69];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[73];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[73];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[77];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[77];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[81];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[81];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[85];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[85];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[89];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[89];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[93];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[93];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[97];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[97];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[101];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[101];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[105];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[105];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[109];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[109];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[113];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[113];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair[117];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_2[117];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[13];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[1];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[17];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[5];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[21];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[9];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[25];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[25];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[63];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[51];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[67];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[55];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[71];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[59];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[79];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[75];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[87];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[83];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[95];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[8].sprite = change_hair_3[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[8].sprite = change_hair_3[99];
			}
		}
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("ptj_10");
		Ani_controll[0].SetActive(false);
		if ((TimeCont.OneMonth == 7) | (TimeCont.OneMonth == 8) | (TimeCont.OneMonth == 1) | (TimeCont.OneMonth == 2))
		{
			vacation_mode.SetActive(true);
		}
		else
		{
			vacation_mode.SetActive(false);
		}
		Ani_plus_money.SetActive(false);
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 1f);
			for (int k = 0; k < Ani_man_load.Length; k++)
			{
				Ani_man_load[k].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>(null);
			}
		}
		rand = Random.Range(0, 2);
		if (ptj_date == 0)
		{
			Invoke("alba_time", 0.0001f);
		}
		else
		{
			Invoke("alba_time", AlbaTime);
		}
		_coin_ani.SetActive(false);
	}

	public void SetAlbaPayMoney()
	{
		if (Albapaybuff == 0)
		{
			if (Alba_N == 1)
			{
				AlbaPayMoney = (long)((float)albamon_1 + (float)albamon_1 * Buff_pluspay);
			}
			if (Alba_N == 2)
			{
				AlbaPayMoney = (long)((float)albamon_2 + (float)albamon_2 * Buff_pluspay);
			}
			if (Alba_N == 3)
			{
				AlbaPayMoney = (long)((float)albamon_3 + (float)albamon_3 * Buff_pluspay);
			}
			if (Alba_N == 4)
			{
				AlbaPayMoney = (long)((float)albamon_4 + (float)albamon_4 * Buff_pluspay);
			}
			if (Alba_N == 5)
			{
				AlbaPayMoney = (long)((float)albamon_5 + (float)albamon_5 * Buff_pluspay);
			}
			if (Alba_N == 6)
			{
				AlbaPayMoney = (long)((float)albamon_6 + (float)albamon_6 * Buff_pluspay);
			}
			if (Alba_N == 7)
			{
				AlbaPayMoney = (long)((float)albamon_7 + (float)albamon_7 * Buff_pluspay);
			}
			if (Alba_N == 8)
			{
				AlbaPayMoney = (long)((float)albamon_8 + (float)albamon_8 * Buff_pluspay);
			}
			if (Alba_N == 9)
			{
				AlbaPayMoney = (long)((float)albamon_9 + (float)albamon_9 * Buff_pluspay);
			}
			if (Alba_N == 10)
			{
				AlbaPayMoney = (long)((float)albamon_10 + (float)albamon_10 * Buff_pluspay);
			}
		}
		if (Albapaybuff == 1)
		{
			if (Alba_N == 1)
			{
				AlbaPayMoney = (long)(((float)albamon_1 + (float)albamon_1 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 2)
			{
				AlbaPayMoney = (long)(((float)albamon_2 + (float)albamon_2 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 3)
			{
				AlbaPayMoney = (long)(((float)albamon_3 + (float)albamon_3 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 4)
			{
				AlbaPayMoney = (long)(((float)albamon_4 + (float)albamon_4 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 5)
			{
				AlbaPayMoney = (long)(((float)albamon_5 + (float)albamon_5 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 6)
			{
				AlbaPayMoney = (long)(((float)albamon_6 + (float)albamon_6 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 7)
			{
				AlbaPayMoney = (long)(((float)albamon_7 + (float)albamon_7 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 8)
			{
				AlbaPayMoney = (long)(((float)albamon_8 + (float)albamon_8 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 9)
			{
				AlbaPayMoney = (long)(((float)albamon_9 + (float)albamon_9 * Buff_pluspay) * 1.2f);
			}
			if (Alba_N == 10)
			{
				AlbaPayMoney = (long)(((float)albamon_10 + (float)albamon_10 * Buff_pluspay) * 1.2f);
			}
		}
		GetComponent<AlbaLv>().SetLvMoney();
	}

	public void Click_Albaposion_Btn()
	{
		GameObject gameObject = (GameObject)Resources.Load("Confirm_Screen_obj");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Confirm_Screen_obj"));
		GameObject gameObject3 = GameObject.Find("dms");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = new Vector3(0f, 3f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void Paybufftest()
	{
		if (scene_controll.gem >= 200)
		{
			PlayerPrefs.SetInt("Albapaybuff", 1);
			Albapaybuff = PlayerPrefs.GetInt("Albapaybuff");
			GameObject.Find("paybuff_inapp").GetComponent<Button>().interactable = false;
			Albabufftext.GetComponent<Text>().text = string.Format("획득급여+20% 적용 중");
			scene_controll.gem = SPrefs.GetInt("gem2");
			scene_controll.gem -= 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			cash.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
			Object.Destroy(GameObject.Find("Confirm_Screen_obj(Clone)"));
			SetAlbaPayMoney();
		}
		else
		{
			GameObject gameObject = (GameObject)Resources.Load("No_gem_notice");
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("No_gem_notice"));
			GameObject gameObject3 = GameObject.Find("dms");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.localPosition = new Vector3(0f, 3f, 0f);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			Invoke("Destory_notice_gem", 2f);
		}
	}

	public void Destory_notice_gem()
	{
		Object.Destroy(GameObject.Find("No_gem_notice(Clone)"));
	}

	public void btn_sub_class()
	{
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Ani_plus_smart.SetActive(false);
		for (int i = 0; i < Ani_total_controller.Length; i++)
		{
			Ani_total_controller[i].SetActive(false);
			Ani_total_controller[10].SetActive(true);
		}
		for (int j = 0; j < ptj_study.Length; j++)
		{
			ptj_study[j].SetActive(false);
			ptj_study[3].SetActive(true);
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[3];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[3];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[7];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[7];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[11];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[11];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[15];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[15];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[19];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[19];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[23];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[23];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[27];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[27];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[31];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[31];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[35];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[35];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[39];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[39];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[43];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[43];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[47];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[47];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[51];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[51];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[55];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[55];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[59];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[59];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[63];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[63];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[67];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[67];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[71];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[71];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[75];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[75];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[79];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[79];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[83];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[83];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[87];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[87];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[91];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[91];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[95];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[95];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[99];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[99];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[103];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[103];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[107];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[107];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[111];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[111];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[115];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[115];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair[119];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_2[119];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[15];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[3];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[19];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[7];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[23];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[11];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[27];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[27];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[65];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[53];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[69];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[57];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[73];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[61];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[81];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[77];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[89];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[85];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[93];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[97];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				alba_in_head[9].sprite = change_hair_3[105];
			}
			if (Char.Sex == 1)
			{
				alba_in_head[9].sprite = change_hair_3[101];
			}
		}
		Goback.GetComponent<Button>().interactable = false;
		pivot_top.sprite = Resources.Load<Sprite>("study_1");
		Ani_controll[0].SetActive(false);
		if (ptj_date == 10)
		{
			Invoke("ResultScreen_2", 2f);
		}
		rand = Random.Range(0, 2);
		if (ptj_date == 0)
		{
			Invoke("study_time", 0.0001f);
		}
		else
		{
			Invoke("study_time", AlbaTime);
		}
		for (int k = 0; k < icon_class.Length; k++)
		{
			icon_class[k].SetActive(false);
			icon_class[0].SetActive(true);
		}
	}

	public void btn_Y_class()
	{
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Ani_plus_smart.SetActive(false);
		for (int i = 0; i < ptj_study.Length; i++)
		{
			ptj_study[i].SetActive(false);
			ptj_study[3].SetActive(true);
		}
		if (TimeCont.Grade == 1)
		{
			for (int j = 0; j < Ani_total_controller.Length; j++)
			{
				Ani_total_controller[j].SetActive(false);
				Ani_total_controller[11].SetActive(true);
				if (Head.Hair_N == 0)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[3];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[3];
					}
				}
				if (Head.Hair_N == 1)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[7];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[7];
					}
				}
				if (Head.Hair_N == 2)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[11];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[11];
					}
				}
				if (Head.Hair_N == 3)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[15];
					}
				}
				if (Head.Hair_N == 4)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[19];
					}
				}
				if (Head.Hair_N == 5)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[23];
					}
				}
				if (Head.Hair_N == 6)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[27];
					}
				}
				if (Head.Hair_N == 7)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[31];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[31];
					}
				}
				if (Head.Hair_N == 8)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[35];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[35];
					}
				}
				if (Head.Hair_N == 9)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[39];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[39];
					}
				}
				if (Head.Hair_N == 10)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[43];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[43];
					}
				}
				if (Head.Hair_N == 11)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[47];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[47];
					}
				}
				if (Head.Hair_N == 12)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[51];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[51];
					}
				}
				if (Head.Hair_N == 13)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[55];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[55];
					}
				}
				if (Head.Hair_N == 14)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[59];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[59];
					}
				}
				if (Head.Hair_N == 15)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[63];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[63];
					}
				}
				if (Head.Hair_N == 16)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[67];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[67];
					}
				}
				if (Head.Hair_N == 17)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[71];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[71];
					}
				}
				if (Head.Hair_N == 18)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[75];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[75];
					}
				}
				if (Head.Hair_N == 19)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[79];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[79];
					}
				}
				if (Head.Hair_N == 20)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[83];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[83];
					}
				}
				if (Head.Hair_N == 21)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[87];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[87];
					}
				}
				if (Head.Hair_N == 22)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[91];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[91];
					}
				}
				if (Head.Hair_N == 23)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[95];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[95];
					}
				}
				if (Head.Hair_N == 24)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[99];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[99];
					}
				}
				if (Head.Hair_N == 25)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[103];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[103];
					}
				}
				if (Head.Hair_N == 26)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[107];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[107];
					}
				}
				if (Head.Hair_N == 27)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[111];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[111];
					}
				}
				if (Head.Hair_N == 28)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[115];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[115];
					}
				}
				if (Head.Hair_N == 29)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair[119];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_2[119];
					}
				}
				if (Head.Hair_N == 30)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[3];
					}
				}
				if (Head.Hair_N == 31)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[7];
					}
				}
				if (Head.Hair_N == 32)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[11];
					}
				}
				if (Head.Hair_N == 33)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[27];
					}
				}
				if (Head.Hair_N == 34)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[65];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[53];
					}
				}
				if (Head.Hair_N == 35)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[69];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[57];
					}
				}
				if (Head.Hair_N == 36)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[73];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[61];
					}
				}
				if (Head.Hair_N == 37)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[81];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[77];
					}
				}
				if (Head.Hair_N == 38)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[89];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[85];
					}
				}
				if (Head.Hair_N == 39)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[93];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[97];
					}
				}
				if (Head.Hair_N == 40)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[10].sprite = change_hair_3[105];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[10].sprite = change_hair_3[101];
					}
				}
				pivot_top.sprite = Resources.Load<Sprite>("study_2");
				Ani_controll[0].SetActive(false);
			}
		}
		if ((TimeCont.Grade == 2) | (TimeCont.Grade == 3))
		{
			for (int k = 0; k < Ani_total_controller.Length; k++)
			{
				Ani_total_controller[k].SetActive(false);
				Ani_total_controller[12].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[11].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[11].sprite = change_hair_3[101];
				}
			}
			pivot_top.sprite = Resources.Load<Sprite>("study_2");
			Ani_controll[0].SetActive(false);
		}
		if (TimeCont.Grade == 4)
		{
			for (int l = 0; l < Ani_total_controller.Length; l++)
			{
				Ani_total_controller[l].SetActive(false);
				Ani_total_controller[13].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[2];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[2];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[6];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[6];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[10];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[10];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[14];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[14];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[18];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[18];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[22];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[22];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[26];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[26];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[30];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[30];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[34];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[34];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[38];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[38];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[42];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[42];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[46];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[46];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[50];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[50];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[54];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[54];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[58];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[58];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[62];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[62];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[66];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[66];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[70];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[70];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[74];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[74];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[78];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[78];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[82];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[82];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[86];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[86];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[90];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[90];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[94];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[94];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[98];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[98];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[102];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[102];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[106];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[106];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[110];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[110];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[114];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[114];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair[118];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_2[118];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[14];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[2];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[18];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[6];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[22];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[10];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[26];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[26];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[64];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[52];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[68];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[56];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[72];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[60];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[80];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[76];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[88];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[84];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[92];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[96];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[12].sprite = change_hair_3[104];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[12].sprite = change_hair_3[100];
				}
			}
			pivot_bottom.sprite = Resources.Load<Sprite>("study_2");
			Ani_controll[1].SetActive(false);
		}
		Goback.GetComponent<Button>().interactable = false;
		if (ptj_date == 10)
		{
			Invoke("ResultScreen_2", 2f);
		}
		rand = Random.Range(0, 2);
		if (ptj_date == 0)
		{
			Invoke("study_time", 0.0001f);
		}
		else
		{
			Invoke("study_time", AlbaTime);
		}
		for (int m = 0; m < icon_class.Length; m++)
		{
			icon_class[m].SetActive(false);
			icon_class[1].SetActive(true);
		}
	}

	public void btn_M_class()
	{
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Ani_plus_smart.SetActive(false);
		for (int i = 0; i < ptj_study.Length; i++)
		{
			ptj_study[i].SetActive(false);
			ptj_study[3].SetActive(true);
		}
		if (TimeCont.Grade == 1)
		{
			for (int j = 0; j < Ani_total_controller.Length; j++)
			{
				Ani_total_controller[j].SetActive(false);
				Ani_total_controller[14].SetActive(true);
				if (Head.Hair_N == 0)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[3];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[3];
					}
				}
				if (Head.Hair_N == 1)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[7];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[7];
					}
				}
				if (Head.Hair_N == 2)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[11];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[11];
					}
				}
				if (Head.Hair_N == 3)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[15];
					}
				}
				if (Head.Hair_N == 4)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[19];
					}
				}
				if (Head.Hair_N == 5)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[23];
					}
				}
				if (Head.Hair_N == 6)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[27];
					}
				}
				if (Head.Hair_N == 7)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[31];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[31];
					}
				}
				if (Head.Hair_N == 8)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[35];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[35];
					}
				}
				if (Head.Hair_N == 9)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[39];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[39];
					}
				}
				if (Head.Hair_N == 10)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[43];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[43];
					}
				}
				if (Head.Hair_N == 11)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[47];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[47];
					}
				}
				if (Head.Hair_N == 12)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[51];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[51];
					}
				}
				if (Head.Hair_N == 13)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[55];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[55];
					}
				}
				if (Head.Hair_N == 14)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[59];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[59];
					}
				}
				if (Head.Hair_N == 15)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[63];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[63];
					}
				}
				if (Head.Hair_N == 16)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[67];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[67];
					}
				}
				if (Head.Hair_N == 17)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[71];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[71];
					}
				}
				if (Head.Hair_N == 18)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[75];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[75];
					}
				}
				if (Head.Hair_N == 19)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[79];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[79];
					}
				}
				if (Head.Hair_N == 20)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[83];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[83];
					}
				}
				if (Head.Hair_N == 21)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[87];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[87];
					}
				}
				if (Head.Hair_N == 22)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[91];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[91];
					}
				}
				if (Head.Hair_N == 23)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[95];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[95];
					}
				}
				if (Head.Hair_N == 24)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[99];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[99];
					}
				}
				if (Head.Hair_N == 25)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[103];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[103];
					}
				}
				if (Head.Hair_N == 26)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[107];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[107];
					}
				}
				if (Head.Hair_N == 27)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[111];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[111];
					}
				}
				if (Head.Hair_N == 28)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[115];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[115];
					}
				}
				if (Head.Hair_N == 29)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair[119];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_2[119];
					}
				}
				if (Head.Hair_N == 30)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[3];
					}
				}
				if (Head.Hair_N == 31)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[7];
					}
				}
				if (Head.Hair_N == 32)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[11];
					}
				}
				if (Head.Hair_N == 33)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[27];
					}
				}
				if (Head.Hair_N == 34)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[65];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[53];
					}
				}
				if (Head.Hair_N == 35)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[69];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[57];
					}
				}
				if (Head.Hair_N == 36)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[73];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[61];
					}
				}
				if (Head.Hair_N == 37)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[81];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[77];
					}
				}
				if (Head.Hair_N == 38)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[89];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[85];
					}
				}
				if (Head.Hair_N == 39)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[93];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[97];
					}
				}
				if (Head.Hair_N == 40)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[13].sprite = change_hair_3[105];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[13].sprite = change_hair_3[101];
					}
				}
				pivot_top.sprite = Resources.Load<Sprite>("study_3");
				Ani_controll[0].SetActive(false);
			}
		}
		if (TimeCont.Grade == 2)
		{
			for (int k = 0; k < Ani_total_controller.Length; k++)
			{
				Ani_total_controller[k].SetActive(false);
				Ani_total_controller[15].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[14].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[14].sprite = change_hair_3[101];
				}
			}
			pivot_top.sprite = Resources.Load<Sprite>("study_3");
			Ani_controll[0].SetActive(false);
		}
		if (TimeCont.Grade == 3)
		{
			for (int l = 0; l < Ani_total_controller.Length; l++)
			{
				Ani_total_controller[l].SetActive(false);
				Ani_total_controller[16].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[1];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[1];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[5];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[5];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[9];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[9];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[13];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[13];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[17];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[17];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[21];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[21];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[25];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[25];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[29];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[29];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[33];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[33];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[37];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[37];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[41];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[41];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[45];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[45];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[49];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[49];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[53];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[53];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[57];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[57];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[61];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[61];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[65];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[69];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[73];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[77];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[77];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[81];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[85];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[85];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[89];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[93];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[97];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[97];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[101];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[101];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[105];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[109];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[109];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[113];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[113];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair[117];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_2[117];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[13];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[1];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[17];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[5];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[21];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[9];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[25];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[25];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[51];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[55];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[59];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[75];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[83];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[95];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[15].sprite = change_hair_3[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[15].sprite = change_hair_3[99];
				}
			}
			pivot_top.sprite = Resources.Load<Sprite>("study_3");
			Ani_controll[0].SetActive(false);
		}
		if (TimeCont.Grade == 4)
		{
			for (int m = 0; m < Ani_total_controller.Length; m++)
			{
				Ani_total_controller[m].SetActive(false);
				Ani_total_controller[17].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[1];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[1];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[5];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[5];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[9];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[9];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[13];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[13];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[17];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[17];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[21];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[21];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[25];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[25];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[29];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[29];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[33];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[33];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[37];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[37];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[41];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[41];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[45];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[45];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[49];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[49];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[53];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[53];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[57];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[57];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[61];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[61];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[65];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[69];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[73];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[77];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[77];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[81];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[85];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[85];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[89];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[93];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[97];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[97];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[101];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[101];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[105];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[109];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[109];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[113];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[113];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair[117];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_2[117];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[13];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[1];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[17];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[5];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[21];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[9];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[25];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[25];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[51];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[55];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[59];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[75];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[83];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[95];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[16].sprite = change_hair_3[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[16].sprite = change_hair_3[99];
				}
			}
			pivot_bottom.sprite = Resources.Load<Sprite>("study_3");
			Ani_controll[1].SetActive(false);
		}
		Goback.GetComponent<Button>().interactable = false;
		if (ptj_date == 10)
		{
			Invoke("ResultScreen_2", 2f);
		}
		rand = Random.Range(0, 2);
		if (ptj_date == 0)
		{
			Invoke("study_time", 0.0001f);
		}
		else
		{
			Invoke("study_time", AlbaTime);
		}
		for (int n = 0; n < icon_class.Length; n++)
		{
			icon_class[n].SetActive(false);
			icon_class[2].SetActive(true);
		}
	}

	public void btn_E_class()
	{
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Ani_plus_smart.SetActive(false);
		for (int i = 0; i < ptj_study.Length; i++)
		{
			ptj_study[i].SetActive(false);
			ptj_study[3].SetActive(true);
		}
		if (TimeCont.Grade == 1)
		{
			for (int j = 0; j < Ani_total_controller.Length; j++)
			{
				Ani_total_controller[j].SetActive(false);
				Ani_total_controller[18].SetActive(true);
				if (Head.Hair_N == 0)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[3];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[3];
					}
				}
				if (Head.Hair_N == 1)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[7];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[7];
					}
				}
				if (Head.Hair_N == 2)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[11];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[11];
					}
				}
				if (Head.Hair_N == 3)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[15];
					}
				}
				if (Head.Hair_N == 4)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[19];
					}
				}
				if (Head.Hair_N == 5)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[23];
					}
				}
				if (Head.Hair_N == 6)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[27];
					}
				}
				if (Head.Hair_N == 7)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[31];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[31];
					}
				}
				if (Head.Hair_N == 8)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[35];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[35];
					}
				}
				if (Head.Hair_N == 9)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[39];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[39];
					}
				}
				if (Head.Hair_N == 10)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[43];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[43];
					}
				}
				if (Head.Hair_N == 11)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[47];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[47];
					}
				}
				if (Head.Hair_N == 12)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[51];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[51];
					}
				}
				if (Head.Hair_N == 13)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[55];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[55];
					}
				}
				if (Head.Hair_N == 14)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[59];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[59];
					}
				}
				if (Head.Hair_N == 15)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[63];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[63];
					}
				}
				if (Head.Hair_N == 16)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[67];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[67];
					}
				}
				if (Head.Hair_N == 17)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[71];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[71];
					}
				}
				if (Head.Hair_N == 18)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[75];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[75];
					}
				}
				if (Head.Hair_N == 19)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[79];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[79];
					}
				}
				if (Head.Hair_N == 20)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[83];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[83];
					}
				}
				if (Head.Hair_N == 21)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[87];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[87];
					}
				}
				if (Head.Hair_N == 22)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[91];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[91];
					}
				}
				if (Head.Hair_N == 23)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[95];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[95];
					}
				}
				if (Head.Hair_N == 24)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[99];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[99];
					}
				}
				if (Head.Hair_N == 25)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[103];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[103];
					}
				}
				if (Head.Hair_N == 26)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[107];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[107];
					}
				}
				if (Head.Hair_N == 27)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[111];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[111];
					}
				}
				if (Head.Hair_N == 28)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[115];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[115];
					}
				}
				if (Head.Hair_N == 29)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair[119];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_2[119];
					}
				}
				if (Head.Hair_N == 30)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[15];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[3];
					}
				}
				if (Head.Hair_N == 31)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[19];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[7];
					}
				}
				if (Head.Hair_N == 32)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[23];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[11];
					}
				}
				if (Head.Hair_N == 33)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[27];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[27];
					}
				}
				if (Head.Hair_N == 34)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[65];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[53];
					}
				}
				if (Head.Hair_N == 35)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[69];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[57];
					}
				}
				if (Head.Hair_N == 36)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[73];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[61];
					}
				}
				if (Head.Hair_N == 37)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[81];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[77];
					}
				}
				if (Head.Hair_N == 38)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[89];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[85];
					}
				}
				if (Head.Hair_N == 39)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[93];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[97];
					}
				}
				if (Head.Hair_N == 40)
				{
					if (Char.Sex == 0)
					{
						alba_in_head[17].sprite = change_hair_3[105];
					}
					if (Char.Sex == 1)
					{
						alba_in_head[17].sprite = change_hair_3[101];
					}
				}
				pivot_bottom.sprite = Resources.Load<Sprite>("study_4");
				Ani_controll[1].SetActive(false);
			}
		}
		if (TimeCont.Grade == 2)
		{
			for (int k = 0; k < Ani_total_controller.Length; k++)
			{
				Ani_total_controller[k].SetActive(false);
				Ani_total_controller[19].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[18].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[18].sprite = change_hair_3[101];
				}
			}
			pivot_top.sprite = Resources.Load<Sprite>("study_4");
			Ani_controll[0].SetActive(false);
		}
		if (TimeCont.Grade == 3)
		{
			for (int l = 0; l < Ani_total_controller.Length; l++)
			{
				Ani_total_controller[l].SetActive(false);
				Ani_total_controller[20].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[19].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[19].sprite = change_hair_3[101];
				}
			}
			pivot_top.sprite = Resources.Load<Sprite>("study_4");
			Ani_controll[0].SetActive(false);
		}
		if (TimeCont.Grade == 4)
		{
			for (int m = 0; m < Ani_total_controller.Length; m++)
			{
				Ani_total_controller[m].SetActive(false);
				Ani_total_controller[21].SetActive(true);
			}
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[20].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[20].sprite = change_hair_3[101];
				}
			}
			pivot_bottom.sprite = Resources.Load<Sprite>("study_4");
			Ani_controll[1].SetActive(false);
		}
		Goback.GetComponent<Button>().interactable = false;
		if (ptj_date == 10)
		{
			Invoke("ResultScreen_2", 2f);
		}
		rand = Random.Range(0, 2);
		if (ptj_date == 0)
		{
			Invoke("study_time", 0.0001f);
		}
		else
		{
			Invoke("study_time", AlbaTime);
		}
		for (int n = 0; n < icon_class.Length; n++)
		{
			icon_class[n].SetActive(false);
			icon_class[3].SetActive(true);
		}
	}

	public void btn_exam()
	{
		s2_4_.SetActive(false);
		s2_5_.SetActive(true);
		Ani_plus_smart.SetActive(false);
		Ani_plus_money.SetActive(false);
		for (int i = 0; i < ptj_study.Length; i++)
		{
			ptj_study[i].SetActive(false);
			ptj_study[3].SetActive(true);
		}
		for (int j = 0; j < Ani_total_controller.Length; j++)
		{
			Ani_total_controller[j].SetActive(false);
			Ani_total_controller[22].SetActive(true);
		}
		for (int k = 0; k < Ani_total_controller.Length; k++)
		{
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[3];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[3];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[7];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[7];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[11];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[11];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[15];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[19];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[23];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[27];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[31];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[31];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[35];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[35];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[39];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[39];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[43];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[43];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[47];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[47];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[51];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[51];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[55];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[55];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[59];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[59];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[63];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[63];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[67];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[67];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[71];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[71];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[75];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[75];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[79];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[79];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[83];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[83];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[87];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[87];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[91];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[91];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[95];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[95];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[99];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[99];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[103];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[103];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[107];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[107];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[111];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[111];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[115];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[115];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair[119];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_2[119];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[15];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[3];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[19];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[7];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[23];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[11];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[27];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[27];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[65];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[53];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[69];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[57];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[73];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[61];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[81];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[77];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[89];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[85];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[93];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[97];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					alba_in_head[21].sprite = change_hair_3[105];
				}
				if (Char.Sex == 1)
				{
					alba_in_head[21].sprite = change_hair_3[101];
				}
			}
		}
		Textbox.GetComponent<Text>().text = string.Format("어렵다...어렵다...어렵다!!!!!!!");
		pivot_top.sprite = Resources.Load<Sprite>("study_5");
		Ani_controll[0].SetActive(false);
		Goback.GetComponent<Button>().interactable = false;
		if (TimeBuff.Buffer_N == 0)
		{
			GameObject.Find("exam_panel_anim").GetComponent<Animator>().speed = 1f;
		}
		if (TimeBuff.Buffer_N == 1)
		{
			GameObject.Find("exam_panel_anim").GetComponent<Animator>().speed = 3.1f;
		}
		Invoke("ResultScreen_3", examtime);
		for (int l = 0; l < icon_class.Length; l++)
		{
			icon_class[l].SetActive(false);
		}
	}

	public void alba_time()
	{
		if (rand == 0)
		{
			Random_hp = Random.Range(2, 4);
			Random_mp = Random.Range(2, 4);
			Random_happy = Random.Range(2, 4);
			Random_int = Random.Range(2, 4);
		}
		if (rand == 1)
		{
			Random_hp = Random.Range(1, 3);
			Random_mp = Random.Range(1, 3);
			Random_happy = Random.Range(1, 3);
			Random_int = Random.Range(1, 3);
		}
		if (ptj_date == 5)
		{
			Invoke("ResultScreen", 2f);
			return;
		}
		GetComponent<AudioSource>().clip = get_money;
		GetComponent<AudioSource>().Play();
		Ani_plus_money.SetActive(false);
		Ani_plus_money.SetActive(true);
		if (pivot_bottom.sprite == Resources.Load<Sprite>("ptj_1") && Ani_controll[0].activeSelf)
		{
			ptj_date++;
			Invoke("btn_event_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[0].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("2_5_1_1");
					Ani_man_load[1].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("2_5_1_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I am dancing hard but I only see crows in the park! ", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[0].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("2_5_1_1");
					Ani_man_load[1].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("2_5_1_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, People are crowded. We have succeeded!", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_2") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_mac_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[2].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I think I made an order mistake. The customer looks upset.", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[2].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It was a pretty successful day. Bored. ", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_3") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_convenience_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[3].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The line is getting longer because of a single rude customer. Please go away.", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[2].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It was an okay day. I could call it a success.", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_4") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_clo_store_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[4].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Asking for a refund of worn out clothes? What do you want me to do!", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[4].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It was a normal day. Is it successful?", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_bottom.sprite == Resources.Load<Sprite>("ptj_5") && Ani_controll[0].activeSelf)
		{
			ptj_date++;
			Invoke("btn_cafe_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[5].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, If you order something that’s not on the menu, what can I do?", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[5].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("mac_ani_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Nothing happened at the store. Then it's successful, right?", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_6") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_rest_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[7].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					Ani_man_load[6].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I swear I didn't do anything! He fell down on his own!!", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[6].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					Ani_man_load[7].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I did my best to serve. My shoulder hurts but it was successful.", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_7") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_tak_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[8].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Clang!Clang! Oh, come on! This is going to happen !!", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[8].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It's too painful, but it's okay!", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_8") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_tele_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[9].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, There is a customers who is angry for no reason. I’m speechless.", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[9].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Fortunately, there were no rude customers today. Fortunately, it was a successful day.", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_9") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_hard_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					alba_in_head[7].GetComponent<RectTransform>().anchoredPosition = new Vector3(-53.8f, 29.7f, 0f);
					Ani_man_load[10].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					Ani_man_load[11].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It was so hard that I actually ran away. But then I got caught by the chief.", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					alba_in_head[7].GetComponent<RectTransform>().anchoredPosition = new Vector3(-6.45f, 10.87f, 0f);
					Ani_man_load[10].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					Ani_man_load[11].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Nothing “successful” today, except that I worked hard.", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		if (pivot_top.sprite == Resources.Load<Sprite>("ptj_10") && Ani_controll[1].activeSelf)
		{
			ptj_date++;
			Invoke("btn_aca_ptj", 1f);
			if (rand == 0)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[12].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					Ani_man_load[13].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					Ani_man_load[14].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					Ani_man_load[15].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					Ani_man_load[16].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					else
					{
						final_money += AlbaPayMoney / 2;
						scene_controll.money += AlbaPayMoney / 2;
						get_money_ = (int)(AlbaPayMoney / 2);
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It is obvious that I do not have the qualities of the teacher.", ptj_date);
				}
			}
			if (rand == 1)
			{
				if (ptj_date == 6)
				{
					final_money = final_money;
					scene_controll.money = scene_controll.money;
				}
				else
				{
					Ani_man_load[12].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					Ani_man_load[13].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					Ani_man_load[14].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					Ani_man_load[15].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					Ani_man_load[16].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					if (vacation_mode.activeSelf)
					{
						final_money += AlbaPayMoney * 2;
						scene_controll.money += AlbaPayMoney * 2;
						get_money_ = (int)AlbaPayMoney * 2;
					}
					else
					{
						final_money += AlbaPayMoney;
						scene_controll.money += AlbaPayMoney;
						get_money_ = (int)AlbaPayMoney;
					}
					Alba_Woman_minus_point();
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Everyone is paying attention to me! It's a success!", ptj_date);
					_coin_ani.SetActive(true);
				}
			}
		}
		Plusall_hp += (float)Random_hp - (float)Random_hp * s3_7.minushairpoint_W;
		Plusall_mp += (float)Random_mp - (float)Random_mp * s3_7.minushairpoint_W;
		Plusall_happy += (float)Random_happy - (float)Random_happy * s3_7.minushairpoint_W;
		Plusall_int += (float)Random_int - (float)Random_int * s3_7.minushairpoint_W;
		EventCont.Plus_MONEY = final_money;
		_Alba_BarCont.AlbaClick();
	}

	public void study_time()
	{
		if (ptj_date < 10)
		{
			GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/furniture_btn");
			GetComponent<AudioSource>().Play();
		}
		if (rand == 0)
		{
			Random_hp = Random.Range(2, 4);
			Random_mp = Random.Range(2, 4);
			Random_happy = Random.Range(2, 4);
			Random_int = Random.Range(2, 4);
			Ani_plus_smart.SetActive(false);
		}
		if (rand == 1)
		{
			Random_hp = Random.Range(1, 3);
			Random_mp = Random.Range(1, 3);
			Random_happy = Random.Range(1, 3);
			Random_int = Random.Range(1, 3);
			Ani_plus_smart.SetActive(false);
			Ani_plus_smart.SetActive(true);
		}
		if (TimeCont.Grade == 1)
		{
			if (rand == 0)
			{
				Random_point = Random.Range(0f, 0.7f);
			}
			if (rand == 1)
			{
				Random_point = Random.Range(0.7f, 1.5f);
			}
		}
		if (TimeCont.Grade == 2)
		{
			if (rand == 0)
			{
				Random_point = Random.Range(0f, 0.6f);
			}
			if (rand == 1)
			{
				Random_point = Random.Range(0.6f, 1.2f);
			}
		}
		if (TimeCont.Grade == 3)
		{
			if (rand == 0)
			{
				Random_point = Random.Range(0f, 0.5f);
			}
			if (rand == 1)
			{
				Random_point = Random.Range(0.5f, 1f);
			}
		}
		if (TimeCont.Grade == 4)
		{
			if (rand == 0)
			{
				Random_point = Random.Range(0f, 0.25f);
			}
			if (rand == 1)
			{
				Random_point = Random.Range(0.25f, 0.5f);
			}
		}
		BarCont.point += Random_point;
		if (ptj_date == 10)
		{
			BarCont.point = BarCont.point;
			Ani_plus_smart.SetActive(false);
			return;
		}
		Plusall_hp += (float)Random_hp - (float)Random_hp * s3_7.minushairpoint_W;
		Plusall_mp += (float)Random_mp - (float)Random_mp * s3_7.minushairpoint_W;
		Plusall_happy += (float)Random_happy - (float)Random_happy * s3_7.minushairpoint_W;
		Plusall_int += (float)Random_int - (float)Random_int * s3_7.minushairpoint_W;
		Plusall_point += Random_point;
		Alba_Woman_minus_point();
		_Alba_BarCont.AlbaClick();
		_Alba_BarCont.StudyClick();
		if (icon_class[0].activeSelf && (bool)Resources.Load<Sprite>("study_1"))
		{
			if (rand == 0)
			{
				S_class = S_class;
				ref int reference = ref class_sco_plus[0];
				reference = reference;
			}
			if (rand == 1)
			{
				S_class++;
				class_sco_plus[0]++;
			}
			ptj_date++;
			if (TimeCont.Grade == 1)
			{
				Invoke("btn_sub_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[0];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The chair in the lecture room is the best place to sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[0];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, He says... He made some useful stuff in the old days.", ptj_date);
				}
			}
			if (TimeCont.Grade == 2)
			{
				Invoke("btn_sub_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[1];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 1");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The chair in the lecture room is the best place to sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[1];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 1");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Hmm... He says he's pretty rich. How lucky.", ptj_date);
				}
			}
			if (TimeCont.Grade == 3)
			{
				Invoke("btn_sub_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[3];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[1].sprite = sprite[19];
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 2");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The chair in the lecture room is the best place to sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[3];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[1].sprite = sprite[19];
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 2");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, He is a family of people who took the pension for Koreans.", ptj_date);
				}
			}
			if (TimeCont.Grade == 4)
			{
				Invoke("btn_sub_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[2];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[1].sprite = sprite[18];
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 3");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The chair in the lecture room is the best place to sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[0].sprite = sprite[2];
						img_study[1].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[1].sprite = sprite[18];
						Ani_man_load[17].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_man 3");
						Ani_man_load[18].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, He says he used to be a president somewhere... I see.", ptj_date);
				}
			}
		}
		if (icon_class[1].activeSelf && (bool)Resources.Load<Sprite>("study_2"))
		{
			ptj_date++;
			if (rand == 0)
			{
				Y_class = Y_class;
				ref int reference2 = ref class_sco_plus[1];
				reference2 = reference2;
			}
			if (rand == 1)
			{
				Y_class++;
				class_sco_plus[1]++;
			}
			if (TimeCont.Grade == 1)
			{
				Invoke("btn_Y_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[20].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I can sit in the first row and sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[20].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Art is like drawing unfinished pictures as if you are going to find many questions and answers.", ptj_date);
				}
			}
			if (TimeCont.Grade == 2)
			{
				Invoke("btn_Y_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[2].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[3].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[32].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I sleep with a pencil in my hand.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[2].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[3].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[32].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Julien is one of the most famous plaster statue for sketching.", ptj_date);
				}
			}
			if (TimeCont.Grade == 3)
			{
				Invoke("btn_Y_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[3].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[2].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[32].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I sleep with a pencil in my hand.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						img_study[3].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						img_study[2].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						Ani_man_load[32].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The only reason I take this class is because of the nude croquis.", ptj_date);
				}
			}
			if (TimeCont.Grade == 4)
			{
				Invoke("btn_Y_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[21].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_Y_body 2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Professor! Sorry, but my legs are hurting!", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[21].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("img_Y_body");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Yaaaaaaaaaaaaaay!", ptj_date);
				}
			}
		}
		if (icon_class[2].activeSelf && (bool)Resources.Load<Sprite>("study_3"))
		{
			ptj_date++;
			if (rand == 0)
			{
				M_class = M_class;
				ref int reference3 = ref class_sco_plus[2];
				reference3 = reference3;
			}
			if (rand == 1)
			{
				M_class++;
				class_sco_plus[2]++;
			}
			if (TimeCont.Grade == 1)
			{
				Invoke("btn_M_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[22].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I can sit in the first row and sleep.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[22].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Literature is like a star running on an endless track.", ptj_date);
				}
			}
			if (TimeCont.Grade == 2)
			{
				Invoke("btn_M_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[23].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz…  I don't know what he's saying... But I’m sleepy because it's so dark.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[23].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It was a huge presentation! That's cooooool!", ptj_date);
				}
			}
			if (TimeCont.Grade == 3)
			{
				Invoke("btn_M_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[33].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_effect");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, My legs wobble and my mouth does not fall.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[33].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I think I can present better than Steve Jobs.", ptj_date);
				}
			}
			if (TimeCont.Grade == 4)
			{
				Invoke("btn_M_class", 1f);
				if (rand == 0)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[24].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
						img_study[4].GetComponent<Image>().enabled = true;
						Ani_man_load[25].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz…  The air is cool, and I’m sleepy.", ptj_date);
				}
				if (rand == 1)
				{
					if (ptj_date == 10)
					{
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					else
					{
						Ani_man_load[24].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
						img_study[4].GetComponent<Image>().enabled = false;
						Ani_man_load[25].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
						final_money -= 1000 * RoomCont.Room_N;
						scene_controll.money -= 1000 * RoomCont.Room_N;
					}
					Textbox.GetComponent<Text>().text = string.Format("{0}attempt, I had a deep literary discussion. I am such a genuine intellectual.", ptj_date);
				}
			}
		}
		if (!icon_class[3].activeSelf || !Resources.Load<Sprite>("study_4"))
		{
			return;
		}
		ptj_date++;
		if (rand == 0)
		{
			E_class = E_class;
			ref int reference4 = ref class_sco_plus[3];
			reference4 = reference4;
		}
		if (rand == 1)
		{
			E_class++;
			class_sco_plus[3]++;
		}
		if (TimeCont.Grade == 1)
		{
			Invoke("btn_E_class", 1f);
			if (rand == 0)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[26].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I can sit in the first row and sleep.", ptj_date);
			}
			if (rand == 1)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[26].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Science is like a star running on an endless track.  ", ptj_date);
			}
		}
		if (TimeCont.Grade == 2)
		{
			Invoke("btn_E_class", 1f);
			if (rand == 0)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[27].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_3");
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Zzzz… I have to write the lab report... Ugh, I’ll do that later.", ptj_date);
			}
			if (rand == 1)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[27].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_aca_2");
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, It's a perfect experiment! I’m like the rising divinity of the scientific community...!", ptj_date);
			}
		}
		if (TimeCont.Grade == 3)
		{
			Invoke("btn_E_class", 1f);
			if (rand == 0)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[28].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_e_4");
					img_study[5].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					Ani_man_load[29].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The experiment failed! A mutation has appeared!", ptj_date);
			}
			if (rand == 1)
			{
				if (ptj_date == 10)
				{
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				else
				{
					Ani_man_load[28].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_e_2");
					Ani_man_load[29].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
					img_study[5].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
					final_money -= 1000 * RoomCont.Room_N;
					scene_controll.money -= 1000 * RoomCont.Room_N;
				}
				Textbox.GetComponent<Text>().text = string.Format("{0}attempt, The experiment failed! A mutation has appeared!", ptj_date);
			}
		}
		if (TimeCont.Grade != 4)
		{
			return;
		}
		Invoke("btn_E_class", 1f);
		if (rand == 0)
		{
			if (ptj_date == 10)
			{
				final_money -= 1000 * RoomCont.Room_N;
				scene_controll.money -= 1000 * RoomCont.Room_N;
			}
			else
			{
				Ani_man_load[31].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_e_4");
				Ani_man_load[30].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
				img_study[6].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
				final_money -= 1000 * RoomCont.Room_N;
				scene_controll.money -= 1000 * RoomCont.Room_N;
			}
			Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Where is wrong? It doesn't work.", ptj_date);
		}
		if (rand == 1)
		{
			if (ptj_date == 10)
			{
				final_money -= 1000 * RoomCont.Room_N;
				scene_controll.money -= 1000 * RoomCont.Room_N;
			}
			else
			{
				Ani_man_load[31].runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("ani_e_2");
				Ani_man_load[30].GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
				img_study[6].GetComponent<Image>().color = new Color(1f, 1f, 1f, 0f);
				final_money -= 1000 * RoomCont.Room_N;
				scene_controll.money -= 1000 * RoomCont.Room_N;
			}
			Textbox.GetComponent<Text>().text = string.Format("{0}attempt, Now I can just enter the competition!", ptj_date);
		}
	}

	public void Alba_Woman_minus_point()
	{
		BarCont.hp -= (float)Random_hp - (float)Random_hp * s3_7.minushairpoint_W;
		BarCont.mp -= (float)Random_mp - (float)Random_mp * s3_7.minushairpoint_W;
		BarCont.happy -= (float)Random_happy - (float)Random_happy * s3_7.minushairpoint_W;
		BarCont._int -= (float)Random_int - (float)Random_int * s3_7.minushairpoint_W;
	}

	public void ResultScreen()
	{
		plus_hp.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_hp);
		plus_mp.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_mp);
		plus_happy.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_happy);
		plus_int.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_int);
		final_money_window.GetComponent<Text>().text = string.Format("{0:n0}G", final_money);
		EventCont.Plus_ST = -5f;
		PlayerPrefs.SetFloat("st", BarCont.st - 5f);
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		PlayerPrefs.Save();
		SPrefs.Save();
		ptj_date = 5;
		result_panel[3].SetActive(true);
		result_panel[0].SetActive(true);
	}

	public void ResultScreen_2()
	{
		ptj_date = 10;
		for (int i = 0; i < result_panel.Length; i++)
		{
			result_panel[i].SetActive(false);
		}
		for (int j = 0; j < result_icon.Length; j++)
		{
			result_icon[j].SetActive(false);
		}
		result_panel[3].SetActive(true);
		result_panel[1].SetActive(true);
		s_Plus_hp.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_hp);
		s_Plus_mp.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_mp);
		s_Plus_happy.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_happy);
		s_Plus_int.GetComponent<Text>().text = string.Format("-{0:n2}", Plusall_int);
		s_Plus_point.GetComponent<Text>().text = string.Format("+{0:n2}", Plusall_point);
		final_money_window.GetComponent<Text>().text = string.Format("-{0:n0}", final_money);
		EventCont.Plus_HP = 0f - Plusall_hp;
		EventCont.Plus_MP = 0f - Plusall_mp;
		EventCont.Plus_HAPPY = 0f - Plusall_happy;
		EventCont.Plus_INT = 0f - Plusall_int;
		ButtonCont.Plus_Point = Plusall_point;
		EventCont.Plus_ST = -10f;
		PlayerPrefs.SetFloat("st", BarCont.st - 10f);
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		PlayerPrefs.Save();
		SPrefs.Save();
		if (icon_class[0].activeSelf)
		{
			result_icon[0].SetActive(true);
			class_sco_text.GetComponent<Text>().text = string.Format("{0}", class_sco_plus[0]);
		}
		if (icon_class[1].activeSelf)
		{
			result_icon[1].SetActive(true);
			class_sco_text.GetComponent<Text>().text = string.Format("{0}", class_sco_plus[1]);
		}
		if (icon_class[2].activeSelf)
		{
			result_icon[2].SetActive(true);
			class_sco_text.GetComponent<Text>().text = string.Format("{0}", class_sco_plus[2]);
		}
		if (icon_class[3].activeSelf)
		{
			result_icon[3].SetActive(true);
			class_sco_text.GetComponent<Text>().text = string.Format("{0}", class_sco_plus[3]);
		}
		PlayerPrefs.SetInt("S_class", S_class);
		PlayerPrefs.SetInt("Y_class", Y_class);
		PlayerPrefs.SetInt("M_class", M_class);
		PlayerPrefs.SetInt("E_class", E_class);
	}

	public void ResultScreen_3()
	{
		for (int i = 0; i < result_panel.Length; i++)
		{
			result_panel[i].SetActive(false);
		}
		result_panel[3].SetActive(true);
		result_panel[2].SetActive(true);
	}

	public void ResultScreen_4()
	{
		btn_true_false[0].SetActive(false);
		btn_true_false[1].SetActive(false);
		Invoke("btn_true", 2f);
		Invoke("SetClosersco", 1f);
		for (int i = 0; i < result_panel.Length; i++)
		{
			result_panel[i].SetActive(false);
		}
		result_panel[3].SetActive(true);
		result_panel[4].SetActive(true);
		if (Lovercont.Phone == 1)
		{
			final_uni_de_int = (int)Mathf.Floor(uni_sco + clear_sco * 30) / 200;
			final_uni_mo_int = (int)Mathf.Floor(uni_sco + clear_sco * 30) * 100;
		}
		else
		{
			final_uni_de_int = (int)Mathf.Floor(uni_sco + clear_sco * 30) / 200;
			final_uni_mo_int = (int)Mathf.Floor(uni_sco + clear_sco * 30) * 100;
		}
		if (uni_select_int == 1)
		{
			for (int j = 0; j < uni_icon.Length; j++)
			{
				uni_icon[j].SetActive(false);
				uni_icon[0].SetActive(true);
			}
		}
		if (uni_select_int == 2)
		{
			for (int k = 0; k < uni_icon.Length; k++)
			{
				uni_icon[k].SetActive(false);
				uni_icon[1].SetActive(true);
			}
		}
		if (uni_select_int == 3)
		{
			for (int l = 0; l < uni_icon.Length; l++)
			{
				uni_icon[l].SetActive(false);
				uni_icon[2].SetActive(true);
			}
		}
		if (uni_select_int == 4)
		{
			for (int m = 0; m < uni_icon.Length; m++)
			{
				uni_icon[m].SetActive(false);
				uni_icon[3].SetActive(true);
			}
		}
		final_uni_desire.GetComponent<Text>().text = string.Format("{0}", final_uni_de_int);
		final_uni_money.GetComponent<Text>().text = string.Format("{0:n0}G", final_uni_mo_int);
	}

	public void SetClosersco()
	{
		Closer_sco_T.GetComponent<Text>().text = string.Format("+{0:n0}", clear_sco * 30);
		Uni_icon_img.GetComponent<Image>().sprite = Uni_little_icon[uni_select_int - 1];
		Closer_sco_T.SetActive(true);
		Invoke("Setfalse_claersco", 2f);
	}

	public void Setfalse_claersco()
	{
		Closer_sco_T.SetActive(false);
	}

	public void btn_true()
	{
		btn_true_false[0].SetActive(true);
		btn_true_false[1].SetActive(true);
	}

	public void change_point()
	{
		if (uni_select_int == 1)
		{
			BarCont.hp_Maxpoint += final_uni_de_int;
			PlayerPrefs.SetFloat("hp_Maxpoint", BarCont.hp_Maxpoint);
		}
		if (uni_select_int == 2)
		{
			BarCont.mp_Maxpoint += final_uni_de_int;
			PlayerPrefs.SetFloat("mp_Maxpoint", BarCont.mp_Maxpoint);
		}
		if (uni_select_int == 3)
		{
			BarCont.happy_Maxpoint += final_uni_de_int;
			PlayerPrefs.SetFloat("happy_Maxpoint", BarCont.happy_Maxpoint);
		}
		if (uni_select_int == 4)
		{
			BarCont.int_Maxpoint += final_uni_de_int;
			PlayerPrefs.SetFloat("int_Maxpoint", BarCont.int_Maxpoint);
		}
		BarCont.st -= 20f;
		PlayerPrefs.SetFloat("st", BarCont.st);
		GoToHome();
	}

	public void change_money()
	{
		scene_controll.money += final_uni_mo_int;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		BarCont.st -= 20f;
		PlayerPrefs.SetFloat("st", BarCont.st);
		GoToHome();
	}

	public void GoToHome()
	{
		DidAlba = 1;
		Application.LoadLevel("newone");
		PlayerPrefs.SetFloat("hp", BarCont.hp);
		PlayerPrefs.SetFloat("mp", BarCont.mp);
		PlayerPrefs.SetFloat("happy", BarCont.happy);
		PlayerPrefs.SetFloat("int", BarCont._int);
		PlayerPrefs.SetFloat("point", BarCont.point);
		GameObject gameObject = GameObject.Find("dms");
		Resources.UnloadUnusedAssets();
		if (scene_controll_2.Ptj_N == 1)
		{
			Q_AlbaN++;
			PlayerPrefs.SetInt("Q_AlbaN", Q_AlbaN);
			if (Alba_N == 3)
			{
				conviAlba++;
			}
			if (Alba_N == 5)
			{
				cafeAlba++;
			}
			if (Alba_N == 7)
			{
				takbaeAlba++;
			}
			if (Alba_N == 9)
			{
				factoryAlba++;
			}
			if (Alba_N == 10)
			{
				studyAlba++;
			}
			PlayerPrefs.SetInt("conviAlba", conviAlba);
			PlayerPrefs.SetInt("cafeAlba", cafeAlba);
			PlayerPrefs.SetInt("takbaeAlba", takbaeAlba);
			PlayerPrefs.SetInt("factoryAlba", factoryAlba);
			PlayerPrefs.SetInt("studyAlba", studyAlba);
			PlayerPrefs.SetInt("BackFromAlba", 2);
		}
		if (scene_controll_2.Ptj_N == 2)
		{
			PlayerPrefs.SetInt("BackFromAlba", 2);
			Q_StudyN++;
			PlayerPrefs.SetInt("Q_StudyN", Q_StudyN);
			EventCont.Plus_MONEY = -(10000 * RoomCont.Room_N);
		}
		if (scene_controll_2.Ptj_N == 3)
		{
			PlayerPrefs.SetInt("Testcomplete", 1);
		}
		scene_controll_2.Ptj_N = 0;
		if (TimeBuff.Buffer_N == 1)
		{
			TimeBuff.Buff_weekCount--;
			PlayerPrefs.SetInt("Buff_weekCount", TimeBuff.Buff_weekCount);
		}
		EventCont.Plus_HP = 0f - Plusall_hp;
		EventCont.Plus_MP = 0f - Plusall_mp;
		EventCont.Plus_HAPPY = 0f - Plusall_happy;
		EventCont.Plus_INT = 0f - Plusall_int;
		if (Alba_N == 1)
		{
			_Alba_BarCont.Eventbtn();
		}
		if (Alba_N == 2)
		{
			_Alba_BarCont.cinemabtn();
		}
		if (Alba_N == 3)
		{
			_Alba_BarCont.convibtn();
		}
		if (Alba_N == 4)
		{
			_Alba_BarCont.consmeticbtn();
		}
		if (Alba_N == 5)
		{
			_Alba_BarCont.cafebtn();
		}
		if (Alba_N == 6)
		{
			_Alba_BarCont.restaubtn();
		}
		if (Alba_N == 7)
		{
			_Alba_BarCont.tackbaebtn();
		}
		if (Alba_N == 8)
		{
			_Alba_BarCont.telebtn();
		}
		if (Alba_N == 9)
		{
			_Alba_BarCont.Plantsbtn();
		}
		if (Alba_N == 10)
		{
			_Alba_BarCont.Studybtn();
		}
		gameObject.GetComponent<AlbaLv>().SaveLvExp();
		Debug.Log("Ddd");
	}

	public void CashScene()
	{
		Application.LoadLevel("Cashshop");
	}

	public void test_money()
	{
		scene_controll.money += 1000000000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		scene_controll.money = long.Parse(scene_controll.money_Text);
		PlayerPrefs.Save();
	}

	public void AbilityFull()
	{
		PlayerPrefs.SetFloat("hp", BarCont.hp_Maxpoint);
		PlayerPrefs.SetFloat("mp", BarCont.mp_Maxpoint);
		PlayerPrefs.SetFloat("happy", BarCont.happy_Maxpoint);
		PlayerPrefs.SetFloat("int", BarCont.int_Maxpoint);
		_Alba_BarCont.AlbaClick();
	}

	public void uni_clothes()
	{
		for (int i = 0; i < uni_clo.Length; i++)
		{
			if (Clothes.Clothes_N == 0)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[0];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[0];
				}
			}
			if (Clothes.Clothes_N == 1)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[8];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[8];
				}
			}
			if (Clothes.Clothes_N == 2)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[16];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[16];
				}
			}
			if (Clothes.Clothes_N == 3)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[24];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[24];
				}
			}
			if (Clothes.Clothes_N == 4)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[32];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[32];
				}
			}
			if (Clothes.Clothes_N == 5)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[40];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[40];
				}
			}
			if (Clothes.Clothes_N == 6)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[48];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[48];
				}
			}
			if (Clothes.Clothes_N == 7)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[56];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[56];
				}
			}
			if (Clothes.Clothes_N == 8)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[64];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[64];
				}
			}
			if (Clothes.Clothes_N == 9)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[72];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[72];
				}
			}
			if (Clothes.Clothes_N == 10)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[80];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[80];
				}
			}
			if (Clothes.Clothes_N == 11)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[88];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[88];
				}
			}
			if (Clothes.Clothes_N == 12)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[96];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[96];
				}
			}
			if (Clothes.Clothes_N == 13)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[104];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[104];
				}
			}
			if (Clothes.Clothes_N == 14)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[112];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[112];
				}
			}
			if (Clothes.Clothes_N == 15)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[120];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[120];
				}
			}
			if (Clothes.Clothes_N == 16)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[128];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[128];
				}
			}
			if (Clothes.Clothes_N == 17)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[136];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[136];
				}
			}
			if (Clothes.Clothes_N == 18)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[144];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[144];
				}
			}
			if (Clothes.Clothes_N == 19)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[0];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[0];
				}
			}
			if (Clothes.Clothes_N == 20)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[8];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[8];
				}
			}
			if (Clothes.Clothes_N == 21)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[16];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[16];
				}
			}
			if (Clothes.Clothes_N == 22)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[24];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[24];
				}
			}
			if (Clothes.Clothes_N == 23)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[32];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[32];
				}
			}
			if (Clothes.Clothes_N == 24)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[40];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[40];
				}
			}
			if (Clothes.Clothes_N == 25)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[48];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[48];
				}
			}
			if (Clothes.Clothes_N == 26)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[56];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[56];
				}
			}
			if (Clothes.Clothes_N == 27)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[64];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[64];
				}
			}
			if (Clothes.Clothes_N == 28)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[72];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[72];
				}
			}
			if (Clothes.Clothes_N == 29)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[80];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[80];
				}
			}
			if (Clothes.Clothes_N == 30)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[88];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[88];
				}
			}
			if (Clothes.Clothes_N == 31)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[96];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[96];
				}
			}
			if (Clothes.Clothes_N == 32)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[104];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[104];
				}
			}
			if (Clothes.Clothes_N == 33)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[112];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[112];
				}
			}
			if (Clothes.Clothes_N == 34)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[120];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[120];
				}
			}
			if (Clothes.Clothes_N == 35)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[128];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[128];
				}
			}
			if (Clothes.Clothes_N == 36)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[136];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[136];
				}
			}
			if (Clothes.Clothes_N == 37)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m_2[144];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[144];
				}
			}
			if (Clothes.Clothes_N == 38)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[176];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[152];
				}
			}
			if (Clothes.Clothes_N == 39)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[184];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[160];
				}
			}
			if (Clothes.Clothes_N == 40)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[192];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[168];
				}
			}
			if (Clothes.Clothes_N == 41)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[200];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w_2[200];
				}
			}
			if (Clothes.Clothes_N == 42)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[152];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[152];
				}
			}
			if (Clothes.Clothes_N == 43)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[160];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[160];
				}
			}
			if (Clothes.Clothes_N == 44)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[168];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[168];
				}
			}
			if (Clothes.Clothes_N == 45)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[176];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[176];
				}
			}
			if (Clothes.Clothes_N == 46)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[184];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[184];
				}
			}
			if (Clothes.Clothes_N == 47)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[192];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[192];
				}
			}
			if (Clothes.Clothes_N == 48)
			{
				if (Char.Sex == 0)
				{
					uni_clo[i].sprite = uni_clo_sprite_m[200];
				}
				if (Char.Sex == 1)
				{
					uni_clo[i].sprite = uni_clo_sprite_w[200];
				}
			}
		}
	}

	public void uni_hair()
	{
		for (int i = 0; i < uni_head.Length; i++)
		{
			if (Head.Hair_N == 0)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[1];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[1];
				}
			}
			if (Head.Hair_N == 1)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[5];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[5];
				}
			}
			if (Head.Hair_N == 2)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[9];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[9];
				}
			}
			if (Head.Hair_N == 3)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[13];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[13];
				}
			}
			if (Head.Hair_N == 4)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[17];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[17];
				}
			}
			if (Head.Hair_N == 5)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[21];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[21];
				}
			}
			if (Head.Hair_N == 6)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[25];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[25];
				}
			}
			if (Head.Hair_N == 7)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[29];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[29];
				}
			}
			if (Head.Hair_N == 8)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[33];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[33];
				}
			}
			if (Head.Hair_N == 9)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[37];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[37];
				}
			}
			if (Head.Hair_N == 10)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[41];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[41];
				}
			}
			if (Head.Hair_N == 11)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[45];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[45];
				}
			}
			if (Head.Hair_N == 12)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[49];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[49];
				}
			}
			if (Head.Hair_N == 13)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[53];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[53];
				}
			}
			if (Head.Hair_N == 14)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[57];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[57];
				}
			}
			if (Head.Hair_N == 15)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[61];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[61];
				}
			}
			if (Head.Hair_N == 16)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[65];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[65];
				}
			}
			if (Head.Hair_N == 17)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[69];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[69];
				}
			}
			if (Head.Hair_N == 18)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[73];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[73];
				}
			}
			if (Head.Hair_N == 19)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[77];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[77];
				}
			}
			if (Head.Hair_N == 20)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[81];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[81];
				}
			}
			if (Head.Hair_N == 21)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[85];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[85];
				}
			}
			if (Head.Hair_N == 22)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[89];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[89];
				}
			}
			if (Head.Hair_N == 23)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[93];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[93];
				}
			}
			if (Head.Hair_N == 24)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[97];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[97];
				}
			}
			if (Head.Hair_N == 25)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[101];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[101];
				}
			}
			if (Head.Hair_N == 26)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[105];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[105];
				}
			}
			if (Head.Hair_N == 27)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[109];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[109];
				}
			}
			if (Head.Hair_N == 28)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[113];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[113];
				}
			}
			if (Head.Hair_N == 29)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair[117];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_2[117];
				}
			}
			if (Head.Hair_N == 30)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[13];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[1];
				}
			}
			if (Head.Hair_N == 31)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[17];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[5];
				}
			}
			if (Head.Hair_N == 32)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[21];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[9];
				}
			}
			if (Head.Hair_N == 33)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[25];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[25];
				}
			}
			if (Head.Hair_N == 34)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[63];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[51];
				}
			}
			if (Head.Hair_N == 35)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[67];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[55];
				}
			}
			if (Head.Hair_N == 36)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[71];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[59];
				}
			}
			if (Head.Hair_N == 37)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[79];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[75];
				}
			}
			if (Head.Hair_N == 38)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[87];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[83];
				}
			}
			if (Head.Hair_N == 39)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[91];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[95];
				}
			}
			if (Head.Hair_N == 40)
			{
				if (Char.Sex == 0)
				{
					uni_head[i].sprite = change_hair_3[103];
				}
				if (Char.Sex == 1)
				{
					uni_head[i].sprite = change_hair_3[99];
				}
			}
		}
	}

	public void club_clo_hair2()
	{
		if (LoverClothes.L_Clothes_N == 0)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (LoverClothes.L_Clothes_N == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (LoverClothes.L_Clothes_N == 2)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (LoverClothes.L_Clothes_N == 3)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (LoverClothes.L_Clothes_N == 4)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (LoverClothes.L_Clothes_N == 5)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (LoverClothes.L_Clothes_N == 6)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (LoverClothes.L_Clothes_N == 7)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (LoverClothes.L_Clothes_N == 8)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (LoverClothes.L_Clothes_N == 9)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (LoverClothes.L_Clothes_N == 10)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (LoverClothes.L_Clothes_N == 11)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (LoverClothes.L_Clothes_N == 12)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (LoverClothes.L_Clothes_N == 13)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (LoverClothes.L_Clothes_N == 14)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (LoverClothes.L_Clothes_N == 15)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (LoverClothes.L_Clothes_N == 16)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (LoverClothes.L_Clothes_N == 17)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (LoverClothes.L_Clothes_N == 18)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (LoverClothes.L_Clothes_N == 19)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (LoverClothes.L_Clothes_N == 20)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (LoverClothes.L_Clothes_N == 21)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (LoverClothes.L_Clothes_N == 22)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (LoverClothes.L_Clothes_N == 23)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (LoverClothes.L_Clothes_N == 24)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (LoverClothes.L_Clothes_N == 25)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (LoverClothes.L_Clothes_N == 26)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (LoverClothes.L_Clothes_N == 27)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (LoverClothes.L_Clothes_N == 28)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (LoverClothes.L_Clothes_N == 29)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (LoverClothes.L_Clothes_N == 30)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (LoverClothes.L_Clothes_N == 31)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (LoverClothes.L_Clothes_N == 32)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (LoverClothes.L_Clothes_N == 33)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (LoverClothes.L_Clothes_N == 34)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (LoverClothes.L_Clothes_N == 35)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (LoverClothes.L_Clothes_N == 36)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (LoverClothes.L_Clothes_N == 37)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (LoverClothes.L_Clothes_N == 38)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (LoverClothes.L_Clothes_N == 39)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (LoverClothes.L_Clothes_N == 40)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (LoverClothes.L_Clothes_N == 41)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (LoverClothes.L_Clothes_N == 42)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (LoverClothes.L_Clothes_N == 43)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (LoverClothes.L_Clothes_N == 44)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (LoverClothes.L_Clothes_N == 45)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (LoverClothes.L_Clothes_N == 46)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (LoverClothes.L_Clothes_N == 47)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (LoverClothes.L_Clothes_N == 48)
		{
			if (LoverChar.L_Sex == 0)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (LoverChar.L_Sex == 1)
			{
				clothse_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
		if (LoverHead.L_Hair_N == 0)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (LoverHead.L_Hair_N == 1)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (LoverHead.L_Hair_N == 2)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (LoverHead.L_Hair_N == 3)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (LoverHead.L_Hair_N == 4)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (LoverHead.L_Hair_N == 5)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (LoverHead.L_Hair_N == 6)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (LoverHead.L_Hair_N == 7)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (LoverHead.L_Hair_N == 8)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (LoverHead.L_Hair_N == 9)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (LoverHead.L_Hair_N == 10)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (LoverHead.L_Hair_N == 11)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (LoverHead.L_Hair_N == 12)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (LoverHead.L_Hair_N == 13)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (LoverHead.L_Hair_N == 14)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (LoverHead.L_Hair_N == 15)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (LoverHead.L_Hair_N == 16)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (LoverHead.L_Hair_N == 17)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (LoverHead.L_Hair_N == 18)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (LoverHead.L_Hair_N == 19)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (LoverHead.L_Hair_N == 20)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (LoverHead.L_Hair_N == 21)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (LoverHead.L_Hair_N == 22)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (LoverHead.L_Hair_N == 23)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (LoverHead.L_Hair_N == 24)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (LoverHead.L_Hair_N == 25)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (LoverHead.L_Hair_N == 26)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (LoverHead.L_Hair_N == 27)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (LoverHead.L_Hair_N == 28)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (LoverHead.L_Hair_N == 29)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (LoverHead.L_Hair_N == 30)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (LoverHead.L_Hair_N == 31)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (LoverHead.L_Hair_N == 32)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (LoverHead.L_Hair_N == 33)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (LoverHead.L_Hair_N == 34)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (LoverHead.L_Hair_N == 35)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (LoverHead.L_Hair_N == 36)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (LoverHead.L_Hair_N == 37)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (LoverHead.L_Hair_N == 38)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (LoverHead.L_Hair_N == 39)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (LoverHead.L_Hair_N == 40)
		{
			if (LoverChar.L_Sex == 0)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (LoverChar.L_Sex == 1)
			{
				head_load_lover.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
	}

	public void club_clo_hair()
	{
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				head_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
	}
}
