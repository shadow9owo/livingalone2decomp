using UnityEngine;
using UnityEngine.UI;

public class Alba_BarCont : MonoBehaviour
{
	public GameObject Bar_hp;

	public GameObject Bar_mp;

	public GameObject Bar_int;

	public GameObject Bar_happy;

	public GameObject Bar_point;

	public Transform Bar_hp_T;

	public Transform Bar_mp_T;

	public Transform Bar_int_T;

	public Transform Bar_happy_T;

	private GameObject AlbaLV_;

	public static int AlbaDeath1;

	public static int AlbaDeath2;

	public static int AlbaDeath3;

	public static int AlbaDeath4;

	public static int AlbaDeath5;

	public static int AlbaDeath6;

	public static int AlbaDeath7;

	public static int AlbaDeath8;

	public static int AlbaDeath9;

	public static int AlbaDeath10;

	private void Start()
	{
		AlbaLV_ = GameObject.Find("dms");
		BarCont.hp = PlayerPrefs.GetFloat("hp");
		BarCont.mp = PlayerPrefs.GetFloat("mp");
		BarCont.st = PlayerPrefs.GetFloat("st");
		BarCont._int = PlayerPrefs.GetFloat("int");
		BarCont.happy = PlayerPrefs.GetFloat("happy");
		BarCont.point = PlayerPrefs.GetFloat("point");
		BarCont.hp_Maxpoint = PlayerPrefs.GetFloat("hp_Maxpoint");
		BarCont.mp_Maxpoint = PlayerPrefs.GetFloat("mp_Maxpoint");
		BarCont.int_Maxpoint = PlayerPrefs.GetFloat("int_Maxpoint");
		BarCont.happy_Maxpoint = PlayerPrefs.GetFloat("happy_Maxpoint");
		if (BarCont.hp > BarCont.hp_Maxpoint)
		{
			BarCont.hp = BarCont.hp_Maxpoint;
		}
		if (BarCont.hp <= 0f)
		{
			BarCont.hp = 0f;
		}
		if (BarCont.mp > BarCont.mp_Maxpoint)
		{
			BarCont.mp = BarCont.mp_Maxpoint;
		}
		if (BarCont.mp <= 0f)
		{
			BarCont.mp = 0f;
		}
		if (BarCont._int > BarCont.int_Maxpoint)
		{
			BarCont._int = BarCont.int_Maxpoint;
		}
		if (BarCont._int <= 0f)
		{
			BarCont._int = 0f;
		}
		if (BarCont.happy > BarCont.happy_Maxpoint)
		{
			BarCont.happy = BarCont.happy_Maxpoint;
		}
		if (BarCont.happy <= 0f)
		{
			BarCont.happy = 0f;
		}
		if (BarCont.st > 1000f)
		{
			BarCont.st = 1000f;
		}
		if (BarCont.st <= 0f)
		{
			BarCont.st = 0f;
		}
		if (BarCont.point > 100f)
		{
			BarCont.point = 100f;
		}
		if (BarCont.point <= 0f)
		{
			BarCont.point = 0f;
		}
	}

	public void AlbaClick()
	{
		if (BarCont.hp > BarCont.hp_Maxpoint)
		{
			BarCont.hp = BarCont.hp_Maxpoint;
		}
		if (BarCont.hp <= 0f)
		{
			BarCont.hp = 0f;
		}
		if (BarCont.mp > BarCont.mp_Maxpoint)
		{
			BarCont.mp = BarCont.mp_Maxpoint;
		}
		if (BarCont.mp <= 0f)
		{
			BarCont.mp = 0f;
		}
		if (BarCont._int > BarCont.int_Maxpoint)
		{
			BarCont._int = BarCont.int_Maxpoint;
		}
		if (BarCont._int <= 0f)
		{
			BarCont._int = 0f;
		}
		if (BarCont.happy > BarCont.happy_Maxpoint)
		{
			BarCont.happy = BarCont.happy_Maxpoint;
		}
		if (BarCont.happy <= 0f)
		{
			BarCont.happy = 0f;
		}
		Bar_hp_T.GetComponent<Text>().text = string.Format("{0:n2}", BarCont.hp);
		Bar_mp_T.GetComponent<Text>().text = string.Format("{0:n2}", BarCont.mp);
		Bar_int_T.GetComponent<Text>().text = string.Format("{0:n2}", BarCont._int);
		Bar_happy_T.GetComponent<Text>().text = string.Format("{0:n2}", BarCont.happy);
		Bar_hp.GetComponent<Image>().fillAmount = BarCont.hp / BarCont.hp_Maxpoint;
		Bar_mp.GetComponent<Image>().fillAmount = BarCont.mp / BarCont.mp_Maxpoint;
		Bar_int.GetComponent<Image>().fillAmount = BarCont._int / BarCont.int_Maxpoint;
		Bar_happy.GetComponent<Image>().fillAmount = BarCont.happy / BarCont.happy_Maxpoint;
	}

	public void StudyClick()
	{
		if (BarCont.point > 100f)
		{
			BarCont.point = 100f;
		}
		if (BarCont.point <= 0f)
		{
			BarCont.point = 0f;
		}
		Bar_point.GetComponent<Image>().fillAmount = BarCont.point / 100f;
		if (BarCont.point < 20f)
		{
			Bar_point.GetComponent<Image>().color = Color.red;
		}
		else
		{
			Bar_point.GetComponent<Image>().color = new Color(13f / 85f, 0.23137255f, 50f / 51f);
		}
	}

	public void Save()
	{
		PlayerPrefs.SetFloat("hp", BarCont.hp);
		PlayerPrefs.SetFloat("mp", BarCont.mp);
		PlayerPrefs.SetFloat("int", BarCont._int);
		PlayerPrefs.SetFloat("happy", BarCont.happy);
		PlayerPrefs.SetFloat("point", BarCont.point);
	}

	public void Eventbtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath1++;
			PlayerPrefs.SetInt("AlbaDeath1", AlbaDeath1);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[0] += 1f;
		Debug.Log("Alba_exp[0]++" + AlbaLV_.GetComponent<AlbaLv>().Alba_exp[0]);
		Debug.Log("AlbaDeath1" + AlbaDeath1);
	}

	public void cinemabtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath2++;
			PlayerPrefs.SetInt("AlbaDeath2", AlbaDeath2);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[1] += 1f;
	}

	public void convibtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath3++;
			PlayerPrefs.SetInt("AlbaDeath3", AlbaDeath3);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[2] += 1f;
	}

	public void consmeticbtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath4++;
			PlayerPrefs.SetInt("AlbaDeath4", AlbaDeath4);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[3] += 1f;
	}

	public void cafebtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath5++;
			PlayerPrefs.SetInt("AlbaDeath5", AlbaDeath5);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[4] += 1f;
	}

	public void restaubtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath6++;
			PlayerPrefs.SetInt("AlbaDeath6", AlbaDeath6);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[5] += 1f;
	}

	public void tackbaebtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath7++;
			PlayerPrefs.SetInt("AlbaDeath7", AlbaDeath7);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[6] += 1f;
	}

	public void telebtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath8++;
			PlayerPrefs.SetInt("AlbaDeath8", AlbaDeath8);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[7] += 1f;
	}

	public void Plantsbtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath9++;
			PlayerPrefs.SetInt("AlbaDeath9", AlbaDeath9);
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[8] += 1f;
	}

	public void Studybtn()
	{
		if (TutorialCont.Tutorial_Int == 1)
		{
			AlbaDeath10++;
			PlayerPrefs.SetInt("AlbaDeath10", AlbaDeath10);
			Debug.Log("ddddd");
		}
		AlbaLV_.GetComponent<AlbaLv>().Alba_exp[9] += 1f;
		Debug.Log("dwtewtdddddd" + AlbaLV_.GetComponent<AlbaLv>().Alba_exp[9]);
	}
}
