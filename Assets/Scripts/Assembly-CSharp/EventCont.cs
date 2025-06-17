using UnityEngine;
using UnityEngine.UI;

public class EventCont : MonoBehaviour
{
	public GameObject EventImg;

	public Sprite[] Eventsprite;

	public GameObject ResultBtn;

	public GameObject SpecUPImg;

	public Transform ResultText;

	public Transform Event_hp;

	public Transform Event_mp;

	public Transform Event_st;

	public Transform Event_int;

	public Transform Event_happy;

	public Transform Event_Point;

	public Transform Event_Money;

	private GameObject _backbtn;

	public static int Event_N;

	private int Event_result_N;

	public TextCont _TextCont;

	public TextCont_result _TextCont_result;

	public GameObject EventParticle;

	public GameObject ParticleParent;

	private GameObject _EventParticle;

	public GameObject ContestMoney;

	public SoundEffect_newone _SoundEffect_newone;

	public GameObject NoMoney;

	public static float Plus_HP;

	public static float Plus_MP;

	public static float Plus_INT;

	public static float Plus_HAPPY;

	public static float Plus_PetMoney;

	public static float pet_PlusSt;

	public static long Plus_MONEY;

	public static float Plus_ST;

	public TextUP _TextUp;

	public void Start()
	{
		_backbtn = GameObject.Find("BackBtn");
		FeeCont.MonthHouse = PlayerPrefs.GetInt("MonthHouse");
	}

	public void Toeic()
	{
		EventImg.GetComponent<Image>().sprite = Eventsprite[0];
		SpecUPImg.GetComponent<Image>().sprite = Eventsprite[0];
		_TextCont.TextStart();
	}

	public void Contest()
	{
		EventImg.GetComponent<Image>().sprite = Eventsprite[1];
		SpecUPImg.GetComponent<Image>().sprite = Eventsprite[1];
		_TextCont.TextStart();
	}

	public void EvnetParticle()
	{
		_SoundEffect_newone.Success();
		if (ButtonCont.Particle_int == 0)
		{
			_EventParticle = Object.Instantiate(EventParticle);
			_EventParticle.transform.SetParent(ParticleParent.transform);
			_EventParticle.transform.localPosition = new Vector3(-2f, 421f, -600f);
			_EventParticle.transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}

	public void SpecUpResult()
	{
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		EvnetParticle();
		ResultBtn.SetActive(false);
		TextCont.TextPage = 0;
		_TextCont_result.TextStart();
		SpecUPResultPlus();
		ResultPointText();
		GetComponent<AudioSource>().clip = (AudioClip)Resources.Load("Audio/yeah2");
		GetComponent<AudioSource>().Play();
	}

	public void SpecUpClose()
	{
		_TextUp.Event();
		_TextUp.Study();
		if (Event_N == 2)
		{
			scene_controll.money += Plus_MONEY;
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", scene_controll.money_Text);
			_TextUp.PlusMONEY();
		}
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
	}

	public void SpecUPResultPlus()
	{
		float num = Random.Range(-3f, -6f);
		if (Event_N == 1)
		{
			if (TextCont_result.Result_N == 0)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				ButtonCont.Plus_Point = Random.Range(4f, 7f);
			}
			if (TextCont_result.Result_N == 1)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				ButtonCont.Plus_Point = Random.Range(7f, 10f);
			}
			if (TextCont_result.Result_N == 2)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				ButtonCont.Plus_Point = Random.Range(10f, 13f);
			}
		}
		if (Event_N == 2)
		{
			if (TextCont_result.Result_N == 3)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				Plus_MONEY = (long)((float)FeeCont.MonthHouse * 0.05f);
				scene_controll.money += (long)((float)FeeCont.MonthHouse * 0.05f);
			}
			if (TextCont_result.Result_N == 4)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				Plus_MONEY = (long)((float)FeeCont.MonthHouse * 0.15f);
				scene_controll.money += (long)((float)FeeCont.MonthHouse * 0.15f);
			}
			if (TextCont_result.Result_N == 5)
			{
				Plus_HP = num;
				Plus_MP = num;
				Plus_INT = num;
				Plus_HAPPY = num;
				Plus_MONEY = (long)((float)FeeCont.MonthHouse * 0.3f);
				scene_controll.money += (long)((float)FeeCont.MonthHouse * 0.3f);
			}
		}
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		if (Event_N == 1)
		{
			ContestMoney.SetActive(false);
		}
		if (Event_N == 2)
		{
			ContestMoney.SetActive(true);
		}
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
	}

	public void ResultPointText()
	{
		if (Plus_HP >= 0f)
		{
			Event_hp.GetComponent<Text>().text = string.Format("+{0:n0}", Plus_HP);
		}
		else
		{
			Event_hp.GetComponent<Text>().text = string.Format("{0:n0}", Plus_HP);
		}
		if (Plus_MP >= 0f)
		{
			Event_mp.GetComponent<Text>().text = string.Format("+{0:n0}", Plus_MP);
		}
		else
		{
			Event_mp.GetComponent<Text>().text = string.Format("{0:n0}", Plus_MP);
		}
		if (Plus_INT >= 0f)
		{
			Event_int.GetComponent<Text>().text = string.Format("+{0:n0}", Plus_INT);
		}
		else
		{
			Event_int.GetComponent<Text>().text = string.Format("{0:n0}", Plus_INT);
		}
		if (Plus_HAPPY >= 0f)
		{
			Event_happy.GetComponent<Text>().text = string.Format("+{0:n0}", Plus_HAPPY);
		}
		else
		{
			Event_happy.GetComponent<Text>().text = string.Format("{0:n0}", Plus_HAPPY);
		}
		if (ButtonCont.Plus_Point >= 0f)
		{
			Event_Point.GetComponent<Text>().text = string.Format("+{0:n0}", ButtonCont.Plus_Point);
		}
		if (Plus_MONEY >= 0)
		{
			Event_Money.GetComponent<Text>().text = string.Format("{0:n0} G", Plus_MONEY);
		}
	}

	public void CloesNoMoney()
	{
		NoMoney.SetActive(false);
	}
}
