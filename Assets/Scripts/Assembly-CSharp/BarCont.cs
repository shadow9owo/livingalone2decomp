using UnityEngine;
using UnityEngine.UI;

public class BarCont : MonoBehaviour
{
	public GameObject hp_bar;

	public GameObject mp_bar;

	public GameObject st_bar;

	public GameObject int_bar;

	public GameObject happy_bar;

	public Transform hp_Text;

	public Transform mp_Text;

	public Transform st_Text;

	public Transform int_Text;

	public Transform happy_Text;

	public static float hp;

	public static float mp;

	public static float st;

	public static float _int;

	public static float happy;

	public static float point;

	public GameObject janghak_bar;

	public GameObject White;

	private GameObject _SuddenDeathCont;

	public static float hp_Maxpoint;

	public static float mp_Maxpoint;

	public static float int_Maxpoint;

	public static float happy_Maxpoint;

	public GameObject Tipbox;

	public string[] Tips;

	private int Tipint_ran;

	public TextUP _TextUP;

	public static bool death16;

	public Camera MainCamera;

	public GameObject YEAH;

	public GameObject Text;

	public AudioClip Success_sound;

	public static float CharClick_int;

	public GameObject coloranim;

	public GameObject EmotionObj;

	public Sprite[] Emotion;

	private Image EmotionImg;

	private int emotion_N;

	public void Start()
	{
		CashCont.Scene_String = "newone";
		if (PlayerPrefs.GetInt("MaxFirst") == 0)
		{
			PlayerPrefs.SetFloat("hp_Maxpoint", 50f);
			PlayerPrefs.SetFloat("mp_Maxpoint", 50f);
			PlayerPrefs.SetFloat("int_Maxpoint", 50f);
			PlayerPrefs.SetFloat("happy_Maxpoint", 50f);
			PlayerPrefs.SetInt("MaxFirst", 1);
			int num = PlayerPrefs.GetInt("MaxFirst");
		}
		hp_Maxpoint = PlayerPrefs.GetFloat("hp_Maxpoint");
		mp_Maxpoint = PlayerPrefs.GetFloat("mp_Maxpoint");
		int_Maxpoint = PlayerPrefs.GetFloat("int_Maxpoint");
		happy_Maxpoint = PlayerPrefs.GetFloat("happy_Maxpoint");
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		if (Pet.Pet_N == 23)
		{
			hp_Maxpoint += 30f;
			mp_Maxpoint += 30f;
			int_Maxpoint += 30f;
			happy_Maxpoint += 30f;
		}
		else if (Pet.Pet_N == 25)
		{
			hp_Maxpoint += 30f;
			mp_Maxpoint += 30f;
			int_Maxpoint += 30f;
			happy_Maxpoint += 30f;
		}
		else
		{
			hp_Maxpoint = hp_Maxpoint;
			mp_Maxpoint = mp_Maxpoint;
			int_Maxpoint = int_Maxpoint;
			happy_Maxpoint = happy_Maxpoint;
		}
		ButtonCont.GPGS_Click = PlayerPrefs.GetInt("GPGS_Click");
		RbirthItem.Item_N_1 = PlayerPrefs.GetInt("Item_N_1");
		RbirthItem.Item_N_2 = PlayerPrefs.GetInt("Item_N_2");
		RbirthItem.Item_N_3 = PlayerPrefs.GetInt("Item_N_3");
		RbirthItem.Item_N_4 = PlayerPrefs.GetInt("Item_N_4");
		RbirthItem.Item_N_5 = PlayerPrefs.GetInt("Item_N_5");
		hp = PlayerPrefs.GetFloat("hp");
		mp = PlayerPrefs.GetFloat("mp");
		st = PlayerPrefs.GetFloat("st");
		_int = PlayerPrefs.GetFloat("int");
		happy = PlayerPrefs.GetFloat("happy");
		point = PlayerPrefs.GetFloat("point");
		PlayerPrefs.SetFloat("st", st);
		CharClick_int = 0f;
		SaveBar();
		SetTips();
		_SuddenDeathCont = GameObject.Find("SuddenDeathCont");
	}

	public void SetTips()
	{
		Tipint_ran = Random.Range(0, Tips.Length);
		Tipbox.GetComponent<Text>().text = Tips[Tipint_ran];
		Tipdelay();
	}

	public void Tipdelay()
	{
		Invoke("SetTips", 15f);
	}

	private void FixedUpdate()
	{
		hp_bar.GetComponent<Image>().fillAmount = hp / hp_Maxpoint;
		mp_bar.GetComponent<Image>().fillAmount = mp / mp_Maxpoint;
		int_bar.GetComponent<Image>().fillAmount = _int / int_Maxpoint;
		happy_bar.GetComponent<Image>().fillAmount = happy / happy_Maxpoint;
		janghak_bar.GetComponent<Image>().fillAmount = point / 100f;
		if (point < 20f)
		{
			janghak_bar.GetComponent<Image>().color = Color.red;
		}
		else
		{
			janghak_bar.GetComponent<Image>().color = new Color(13f / 85f, 0.23137255f, 50f / 51f);
		}
		st_bar.GetComponent<Image>().fillAmount = st / 100f;
		if (hp >= hp_Maxpoint)
		{
			hp = hp_Maxpoint;
		}
		if (hp <= 0.01f)
		{
			hp = 0f;
		}
		if (mp >= mp_Maxpoint)
		{
			mp = mp_Maxpoint;
		}
		if (mp <= 0.01f)
		{
			mp = 0f;
		}
		if (st >= 100f)
		{
			st = 100f;
		}
		if (st <= 0.01f)
		{
			st = 0f;
		}
		if (_int >= int_Maxpoint)
		{
			_int = int_Maxpoint;
		}
		if (_int <= 0.01f)
		{
			_int = 0f;
		}
		if (happy >= happy_Maxpoint)
		{
			happy = happy_Maxpoint;
		}
		if (happy <= 0.01f)
		{
			happy = 0f;
		}
		if (point >= 100f)
		{
			point = 100f;
		}
		if (point <= 0.01f)
		{
			point = 0f;
		}
		hp_Text.GetComponent<Text>().text = string.Format("{0:n2}", hp);
		mp_Text.GetComponent<Text>().text = string.Format("{0:n2}", mp);
		st_Text.GetComponent<Text>().text = string.Format("{0:n1}", st);
		int_Text.GetComponent<Text>().text = string.Format("{0:n2}", _int);
		happy_Text.GetComponent<Text>().text = string.Format("{0:n2}", happy);
		if (hp <= 0.01f && mp <= 0.01f && happy <= 0.01f && _int <= 0.01f && !death16)
		{
			Noabilitydeath();
			death16 = true;
		}
	}

	public void Noabilitydeath()
	{
		_SuddenDeathCont.GetComponent<SuddenDeathCont>().OtherSuddenDeath();
	}

	public void SaveBar()
	{
		EmotionObj.SetActive(true);
		if (hp > 40f && mp > 40f && _int > 40f && happy > 40f)
		{
			emotion_N = 0;
			Emotion_Image();
		}
		else if (hp <= 25f)
		{
			emotion_N = 1;
			Emotion_Image();
		}
		else if (mp <= 25f)
		{
			emotion_N = 2;
			Emotion_Image();
		}
		else if (happy <= 25f)
		{
			emotion_N = 3;
			Emotion_Image();
		}
		else if (_int <= 25f)
		{
			emotion_N = 4;
			Emotion_Image();
		}
		else
		{
			EmotionObj.SetActive(false);
		}
		PlayerPrefs.SetFloat("hp", hp);
		PlayerPrefs.SetFloat("mp", mp);
		PlayerPrefs.SetFloat("st", st);
		PlayerPrefs.SetFloat("int", _int);
		PlayerPrefs.SetFloat("happy", happy);
		Delay_();
	}

	public void Delay_()
	{
		Invoke("SaveBar", 1f);
	}

	public void Emotion_Image()
	{
		EmotionImg = EmotionObj.GetComponent<Image>();
		EmotionImg.sprite = Emotion[emotion_N];
	}

	public void SetFull()
	{
		PlayerPrefs.SetFloat("hp", 10f);
		PlayerPrefs.SetFloat("mp", 10f);
		PlayerPrefs.SetFloat("int", 10f);
		PlayerPrefs.SetFloat("happy", 10f);
		PlayerPrefs.SetFloat("point", 100f);
		hp = PlayerPrefs.GetFloat("hp");
		mp = PlayerPrefs.GetFloat("mp");
		_int = PlayerPrefs.GetFloat("int");
		happy = PlayerPrefs.GetFloat("happy");
		point = PlayerPrefs.GetFloat("point");
	}

	public void EventResult()
	{
		Debug.Log("BARCONT_EVETN RESUTL");
		hp += EventCont.Plus_HP;
		mp += EventCont.Plus_MP;
		_int += EventCont.Plus_INT;
		happy += EventCont.Plus_HAPPY;
		point += ButtonCont.Plus_Point;
		PlayerPrefs.SetFloat("point", point);
		point = PlayerPrefs.GetFloat("point");
		ButtonCont.Plus_Point = 0f;
	}

	public void StudyResult()
	{
		hp += EventCont.Plus_HP;
		mp += EventCont.Plus_MP;
		_int += EventCont.Plus_INT;
		happy += EventCont.Plus_HAPPY;
	}

	public void MINUSability()
	{
		PlayerPrefs.SetFloat("hp", 10f);
		PlayerPrefs.SetFloat("mp", 10f);
		PlayerPrefs.SetFloat("int", 10f);
		PlayerPrefs.SetFloat("happy", 10f);
		hp = PlayerPrefs.GetFloat("hp");
		mp = PlayerPrefs.GetFloat("mp");
		st = PlayerPrefs.GetFloat("st");
		_int = PlayerPrefs.GetFloat("int");
		happy = PlayerPrefs.GetFloat("happy");
	}
}
