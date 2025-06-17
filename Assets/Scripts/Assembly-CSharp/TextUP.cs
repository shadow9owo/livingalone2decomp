using UnityEngine;
using UnityEngine.UI;

public class TextUP : MonoBehaviour
{
	public GameObject hpUp;

	public GameObject mpUp;

	public GameObject intUp;

	public GameObject happyUp;

	public GameObject stUp;

	public GameObject pointUp;

	public GameObject Parent;

	public GameObject MoneyUp;

	public GameObject MoneyText;

	public GameObject MonthUp;

	public GameObject Friendly;

	public int BackFromAlba;

	public GameObject Janghakmoney;

	public GameObject janghakMoneyText;

	private void Start()
	{
		BackFromAlba = PlayerPrefs.GetInt("BackFromAlba");
		SuddenDeathCont.Rebirth_OK = PlayerPrefs.GetInt("Rebirth_OK");
		_BackFromAlba();
	}

	public void AfterRebirth()
	{
		BackFromAlba = PlayerPrefs.GetInt("BackFromAlba");
		PlusDeathMONEY();
	}

	public void _BackFromAlba()
	{
		if (BackFromAlba == 2)
		{
			PlayerPrefs.SetInt("BackFromAlba", 1);
			Event();
			PlusMONEY();
		}
		BackFromAlba = PlayerPrefs.GetInt("BackFromAlba");
	}

	public void Event()
	{
		PlusHP();
		PlusMP();
		PlusST();
		PlusINT();
		PlusHAPPY();
	}

	public void Study()
	{
		PlusSTUDY();
	}

	public void PlusHP()
	{
		GameObject gameObject = Object.Instantiate(hpUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = hpUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (EventCont.Plus_HP >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0:n2}", EventCont.Plus_HP);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0:n2}", EventCont.Plus_HP);
		}
		setZERO_hp();
	}

	public void PlusMP()
	{
		GameObject gameObject = Object.Instantiate(mpUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = mpUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (EventCont.Plus_MP >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0:n2}", EventCont.Plus_MP);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0:n2}", EventCont.Plus_MP);
		}
		setZERO_mp();
	}

	public void PlusST()
	{
		GameObject gameObject = Object.Instantiate(stUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = stUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (EventCont.Plus_ST >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0:n2}", EventCont.Plus_ST);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0:n2}", EventCont.Plus_ST);
		}
		setZERO_st();
	}

	public void PlusINT()
	{
		GameObject gameObject = Object.Instantiate(intUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = intUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (EventCont.Plus_INT >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0:n2}", EventCont.Plus_INT);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0:n2}", EventCont.Plus_INT);
		}
		setZERO_int();
	}

	public void PlusHAPPY()
	{
		GameObject gameObject = Object.Instantiate(happyUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = happyUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (EventCont.Plus_HAPPY >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0:n2}", EventCont.Plus_HAPPY);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0:n2}", EventCont.Plus_HAPPY);
		}
		setZERO_happy();
	}

	public void PlusFriendly()
	{
		GameObject gameObject = Object.Instantiate(Friendly);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = Friendly.transform.localPosition;
		gameObject.transform.localScale = Friendly.transform.localScale;
	}

	public void PlusSTUDY()
	{
		GameObject gameObject = Object.Instantiate(pointUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = pointUp.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		if (ButtonCont.Plus_Point >= 0f)
		{
			gameObject.GetComponent<Text>().text = string.Format("+{0}", ButtonCont.Plus_Point);
		}
		else
		{
			gameObject.GetComponent<Text>().text = string.Format("{0}", ButtonCont.Plus_Point);
		}
		SetpointZero();
	}

	public void PlusMONEY()
	{
		MoneyText.GetComponent<Text>().color = Color.black;
		if (EventCont.Plus_MONEY >= 0)
		{
			MoneyText.GetComponent<Text>().text = string.Format("+{0:n0}G", EventCont.Plus_MONEY);
		}
		if (EventCont.Plus_MONEY < 0)
		{
			MoneyText.GetComponent<Text>().text = string.Format("{0:n0}G", EventCont.Plus_MONEY);
		}
		GameObject gameObject = Object.Instantiate(MoneyUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = MoneyUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		setZERO_money();
	}

	public void PlusClickMoney()
	{
		MoneyText.GetComponent<Text>().color = Color.black;
		MoneyText.GetComponent<Text>().text = string.Format("+{0:n0}G", Clicker.Clickmoney);
		GameObject gameObject = Object.Instantiate(MoneyUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = MoneyUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	public void PlusDeathMONEY()
	{
		MoneyText.GetComponent<Text>().color = Color.black;
		MoneyText.GetComponent<Text>().text = string.Format("{0:n0}", SuddenDeathCont.SuddenDeahtPlusGem);
		SuddenDeathCont.Rebirth_OK = 0;
		PlayerPrefs.SetInt("Rebirth_OK", 0);
		GameObject gameObject = Object.Instantiate(MoneyUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = MoneyUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		setZERO_money();
	}

	public void PlusJnaghakMONEY()
	{
		MoneyText.GetComponent<Text>().color = Color.black;
		if (EventCont.Plus_MONEY >= 0)
		{
			janghakMoneyText.GetComponent<Text>().text = string.Format("+{0:n0}G", EventCont.Plus_MONEY);
		}
		GameObject gameObject = Object.Instantiate(Janghakmoney);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = MoneyUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		setZERO_money();
	}

	public void PlusMONTH()
	{
		GameObject gameObject = Object.Instantiate(MonthUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = MonthUp.transform.localPosition;
		gameObject.transform.localScale = MonthUp.transform.localScale;
		gameObject.GetComponent<Text>().text = string.Format("{0}월이 되었습니다.", TimeCont.OneMonth);
	}

	public void setZERO_hp()
	{
		EventCont.Plus_HP = 0f;
	}

	public void setZERO_mp()
	{
		EventCont.Plus_MP = 0f;
	}

	public void setZERO_st()
	{
		EventCont.Plus_ST = 0f;
	}

	public void setZERO_int()
	{
		EventCont.Plus_INT = 0f;
	}

	public void setZERO_happy()
	{
		EventCont.Plus_HAPPY = 0f;
	}

	public void setZERO_money()
	{
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		EventCont.Plus_MONEY = 0L;
	}

	public void SetpointZero()
	{
		ButtonCont.Plus_Point = 0f;
	}
}
