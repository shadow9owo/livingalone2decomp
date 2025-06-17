using UnityEngine;
using UnityEngine.UI;

public class QuestControll : MonoBehaviour
{
	public GameObject QuestScreen;

	public GameObject Bar_Clothes;

	public GameObject Bar_Hair;

	public GameObject Bar_Pet;

	public GameObject Bar_Car;

	public GameObject Bar_Friend;

	public GameObject Bar_Spec;

	public GameObject Bar_Buff;

	public GameObject Bar_Study;

	public GameObject Bar_Alba;

	public GameObject T_Clothes;

	public GameObject T_Hair;

	public GameObject T_Pet;

	public GameObject T_Car;

	public GameObject T_Friend;

	public GameObject T_Spec;

	public GameObject T_Buff;

	public GameObject T_Study;

	public GameObject T_Alba;

	public static int Goal_Clothes;

	public static int Goal_Hair;

	public static int Goal_Pet;

	public static int Goal_Car;

	public static int Goal_Friend;

	public static int Goal_Spec;

	public static int Goal_Buff;

	public static int Goal_Study;

	public static int Goal_Alba;

	public Button btn_Clothes;

	public Button btn_Hair;

	public Button btn_Pet;

	public Button btn_Car;

	public Button btn_Friend;

	public Button btn_Spec;

	public Button btn_Buff;

	public Button btn_Study;

	public Button btn_Alba;

	public static int M_Clothes;

	public static int M_Hair;

	public static int M_Pet;

	public static int M_Car;

	public static int M_Friend;

	public static int M_Spec;

	public static int M_Buff;

	public static int M_Study;

	public static int M_Alba;

	public GameObject M_T_Clothes;

	public GameObject M_T_Hair;

	public GameObject M_T_Pet;

	public GameObject M_T_Car;

	public GameObject M_T_Friend;

	public GameObject M_T_Spec;

	public GameObject M_T_Buff;

	public GameObject M_T_Study;

	public GameObject M_T_Alba;

	public GameObject MoneyPref;

	public GameObject Pa_Clothes;

	public GameObject Pa_Hair;

	public GameObject Pa_Pet;

	public GameObject Pa_Car;

	public GameObject Pa_Friend;

	public GameObject Pa_Spec;

	public GameObject Pa_Buff;

	public GameObject Pa_Study;

	public GameObject Pa_Alba;

	public GameObject Notice;

	public GameObject Btn_half;

	public GameObject Btn_wdragon;

	public GameObject Endingcount_T;

	public GameObject Gradu_Quest;

	public GameObject sad_Quest;

	public GameObject btn_wolf;

	public GameObject Sudden_count_T;

	private int int_half;

	private int int_wdradon;

	private int int_wolf;

	public static int GetPet;

	private void Start()
	{
		Goal_Car = 1;
		PlayerPrefs.SetInt("Goal_Car", 1);
		s3_7.ClotheBuyOK = PlayerPrefs.GetInt("ClotheBuyOK");
		s3_7.HairBuyOK = PlayerPrefs.GetInt("HairBuyOK");
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		s3_7.CarBuyOK = PlayerPrefs.GetInt("CarBuyOK");
		ButtonCont.Q_Clicker = PlayerPrefs.GetInt("Q_Clicker");
		PetPosition.Q_P_Friendly = PlayerPrefs.GetInt("Q_P_Friendly");
		ButtonCont.Q_SpecN = PlayerPrefs.GetInt("Q_SpecN");
		TimeBuff.Q_BuffN = PlayerPrefs.GetInt("Q_BuffN");
		S2_4.Q_StudyN = PlayerPrefs.GetInt("Q_StudyN");
		S2_4.Q_AlbaN = PlayerPrefs.GetInt("Q_AlbaN");
		if (s3_7.ClotheBuyOK <= 0)
		{
			s3_7.ClotheBuyOK = 0;
		}
		if (s3_7.HairBuyOK <= 0)
		{
			s3_7.HairBuyOK = 0;
		}
		if (s3_7.HowmanyPETOK <= 0)
		{
			s3_7.HowmanyPETOK = 0;
		}
		if (s3_7.CarBuyOK <= 0)
		{
			s3_7.CarBuyOK = 0;
		}
		if (ButtonCont.Q_Clicker <= 0)
		{
			ButtonCont.Q_Clicker = 0;
		}
		if (PetPosition.Q_P_Friendly <= 0)
		{
			PetPosition.Q_P_Friendly = 0;
		}
		if (ButtonCont.Q_SpecN <= 0)
		{
			ButtonCont.Q_SpecN = 0;
		}
		if (TimeBuff.Q_BuffN <= 0)
		{
			TimeBuff.Q_BuffN = 0;
		}
		if (S2_4.Q_StudyN <= 0)
		{
			S2_4.Q_StudyN = 0;
		}
		if (S2_4.Q_AlbaN <= 0)
		{
			S2_4.Q_AlbaN = 0;
		}
		Goal_Clothes = PlayerPrefs.GetInt("Goal_Clothes");
		M_Clothes = PlayerPrefs.GetInt("M_Clothes");
		Goal_Hair = PlayerPrefs.GetInt("Goal_Hair");
		M_Hair = PlayerPrefs.GetInt("M_Hair");
		Goal_Pet = PlayerPrefs.GetInt("Goal_Pet");
		M_Pet = PlayerPrefs.GetInt("M_Pet");
		Goal_Car = PlayerPrefs.GetInt("Goal_Car");
		M_Car = PlayerPrefs.GetInt("M_Car");
		Goal_Friend = PlayerPrefs.GetInt("Goal_Friend");
		M_Friend = PlayerPrefs.GetInt("M_Friend");
		Goal_Spec = PlayerPrefs.GetInt("Goal_Spec");
		M_Spec = PlayerPrefs.GetInt("M_Spec");
		Goal_Buff = PlayerPrefs.GetInt("Goal_Buff");
		M_Buff = PlayerPrefs.GetInt("M_Buff");
		Goal_Study = PlayerPrefs.GetInt("Goal_Study");
		M_Study = PlayerPrefs.GetInt("M_Study");
		Goal_Alba = PlayerPrefs.GetInt("Goal_Alba");
		M_Alba = PlayerPrefs.GetInt("M_Alba");
		M_T_Clothes.GetComponent<Text>().text = string.Format("{0:n0}", M_Clothes);
		M_T_Hair.GetComponent<Text>().text = string.Format("{0:n0}", M_Hair);
		M_T_Pet.GetComponent<Text>().text = string.Format("{0:n0}", M_Pet);
		M_T_Car.GetComponent<Text>().text = string.Format("{0:n0}", M_Car);
		M_T_Friend.GetComponent<Text>().text = string.Format("{0:n0}", M_Friend);
		M_T_Spec.GetComponent<Text>().text = string.Format("{0:n0}", M_Spec);
		M_T_Buff.GetComponent<Text>().text = string.Format("{0:n0}", M_Buff);
		M_T_Study.GetComponent<Text>().text = string.Format("{0:n0}", M_Study);
		M_T_Alba.GetComponent<Text>().text = string.Format("{0:n0}", M_Alba);
		Delay();
		Setbuttons();
	}

	public void OpenGrauQuest()
	{
		Setbuttons();
		Gradu_Quest.SetActive(true);
	}

	public void OpenSuddenQuest()
	{
		SuddenDeathCont.Death_Count = PlayerPrefs.GetInt("Death_Count");
		Sudden_count_T.GetComponent<Text>().text = string.Format("{0}/89", SuddenDeathCont.Death_Count);
		int_wolf = PlayerPrefs.GetInt("int_wolf");
		Debug.Log("wolf" + int_wolf);
		if (SuddenDeathCont.Death_Count >= 85)
		{
			if (int_wolf == 0)
			{
				btn_wolf.GetComponent<Button>().interactable = true;
			}
			if (int_wolf == 1)
			{
				btn_wolf.GetComponent<Button>().interactable = false;
			}
		}
		else
		{
			btn_wolf.GetComponent<Button>().interactable = false;
		}
		sad_Quest.SetActive(true);
	}

	public void Setbuttons()
	{
		int_half = PlayerPrefs.GetInt("int_half");
		int_wdradon = PlayerPrefs.GetInt("int_wdradon");
		GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount");
		if (GraduateCont.EndingCount >= 5)
		{
			if (int_half == 0)
			{
				Btn_half.GetComponent<Button>().interactable = true;
			}
			else
			{
				Btn_half.GetComponent<Button>().interactable = false;
			}
		}
		else
		{
			Btn_half.GetComponent<Button>().interactable = false;
		}
		if (GraduateCont.EndingCount >= 10)
		{
			if (int_wdradon == 0)
			{
				Btn_wdragon.GetComponent<Button>().interactable = true;
			}
			else
			{
				Btn_wdragon.GetComponent<Button>().interactable = false;
			}
		}
		else
		{
			Btn_wdragon.GetComponent<Button>().interactable = false;
		}
		Endingcount_T.GetComponent<Text>().text = string.Format("{0}/42", GraduateCont.EndingCount);
	}

	public void btn_gethalf()
	{
		GetPet = 1;
		PlayerPrefs.SetInt("Pet_N", 23);
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		PlayerPrefs.SetInt("int_half", 1);
		int_half = PlayerPrefs.GetInt("int_half");
		PlayerPrefs.SetInt("pet_23", 1);
		BarCont.hp_Maxpoint += 30f;
		BarCont.mp_Maxpoint += 30f;
		BarCont.int_Maxpoint += 30f;
		BarCont.happy_Maxpoint += 30f;
		PlayerPrefs.SetInt("PetBuyOK", 1);
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		s3_7.HowmanyPETOK++;
		PlayerPrefs.SetInt("HowmanyPETOK", s3_7.HowmanyPETOK);
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		Btn_half.GetComponent<Button>().interactable = false;
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<FurnBtn>().Setbuff();
		Delay();
		Showalert();
	}

	public void btn_getdragon()
	{
		GetPet = 2;
		PlayerPrefs.SetInt("Pet_N", 24);
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		PlayerPrefs.SetInt("int_wdradon", 1);
		int_wdradon = PlayerPrefs.GetInt("int_wdradon");
		PlayerPrefs.SetInt("pet_24", 1);
		PlayerPrefs.SetInt("PetBuyOK", 1);
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		s3_7.HowmanyPETOK++;
		PlayerPrefs.SetInt("HowmanyPETOK", s3_7.HowmanyPETOK);
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		Btn_wdragon.GetComponent<Button>().interactable = false;
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<FurnBtn>().Setbuff();
		Delay();
		Showalert();
	}

	public void btn_getwolf()
	{
		GetPet = 3;
		PlayerPrefs.SetInt("Pet_N", 26);
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		PlayerPrefs.SetInt("int_wolf", 1);
		int_wolf = PlayerPrefs.GetInt("int_wolf");
		PlayerPrefs.SetInt("pet_26", 1);
		PlayerPrefs.SetInt("PetBuyOK", 1);
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		s3_7.HowmanyPETOK++;
		PlayerPrefs.SetInt("HowmanyPETOK", s3_7.HowmanyPETOK);
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		btn_wolf.GetComponent<Button>().interactable = false;
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<FurnBtn>().Setbuff();
		Delay();
		Showalert();
	}

	public void Showalert()
	{
		GameObject gameObject = (GameObject)Resources.Load("Alert_window");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Alert_window"));
		GameObject gameObject3 = GameObject.Find("1_2");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void Delay()
	{
		Clothes();
		Hair();
		Pet_();
		Car();
		Friend();
		Spec();
		Buff();
		Study();
		Alba();
		Invoke("Again", 0.1f);
		if (btn_Clothes.interactable || btn_Hair.interactable || btn_Pet.interactable || btn_Car.interactable || btn_Friend.interactable || btn_Spec.interactable || btn_Buff.interactable || btn_Study.interactable || btn_Alba.interactable)
		{
			Notice.SetActive(true);
		}
		else
		{
			Notice.SetActive(false);
		}
	}

	public void Again()
	{
		Delay();
	}

	private void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
		{
			QuestScreen.SetActive(false);
			SaveAll();
		}
	}

	public void Clothes()
	{
		if (s3_7.ClotheBuyOK <= Goal_Clothes)
		{
			Bar_Clothes.GetComponent<Image>().fillAmount = (float)s3_7.ClotheBuyOK / (float)Goal_Clothes;
			if (s3_7.ClotheBuyOK <= 0)
			{
				Bar_Clothes.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Clothes.GetComponent<Image>().fillAmount = 1f;
		}
		T_Clothes.GetComponent<Text>().text = string.Format("{0}/{1}", s3_7.ClotheBuyOK, Goal_Clothes);
		if (Goal_Clothes <= s3_7.ClotheBuyOK)
		{
			btn_Clothes.interactable = true;
		}
		else
		{
			btn_Clothes.interactable = false;
		}
	}

	public void Btn_Clothes()
	{
		s3_7.ClotheBuyOK -= Goal_Clothes;
		if (s3_7.ClotheBuyOK <= 0)
		{
			s3_7.ClotheBuyOK = 0;
		}
		Goal_Clothes += 4;
		Q_MoneyPref.Plus_Q_Money = M_Clothes;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Clothes.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Clothes;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Clothes += 40000;
		M_T_Clothes.GetComponent<Text>().text = string.Format("{0:n0}", M_Clothes);
		SaveAll();
		Save();
	}

	public void Hair()
	{
		if (s3_7.HairBuyOK <= Goal_Hair)
		{
			Bar_Hair.GetComponent<Image>().fillAmount = (float)s3_7.HairBuyOK / (float)Goal_Hair;
			if (s3_7.HairBuyOK <= 0)
			{
				Bar_Hair.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Hair.GetComponent<Image>().fillAmount = 1f;
		}
		T_Hair.GetComponent<Text>().text = string.Format("{0}/{1}", (float)s3_7.HairBuyOK, Goal_Hair);
		if (Goal_Hair <= s3_7.HairBuyOK)
		{
			btn_Hair.interactable = true;
		}
		else
		{
			btn_Hair.interactable = false;
		}
	}

	public void Btn_Hair()
	{
		s3_7.HairBuyOK -= Goal_Hair;
		if (s3_7.HairBuyOK <= 0)
		{
			s3_7.HairBuyOK = 0;
		}
		Goal_Hair += 4;
		Q_MoneyPref.Plus_Q_Money = M_Hair;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Hair.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Hair;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Hair += 40000;
		M_T_Hair.GetComponent<Text>().text = string.Format("{0:n0}", M_Hair);
		SaveAll();
		Save();
	}

	public void Pet_()
	{
		if (s3_7.HowmanyPETOK <= Goal_Pet)
		{
			Bar_Pet.GetComponent<Image>().fillAmount = (float)s3_7.HowmanyPETOK / (float)Goal_Pet;
			if (s3_7.HowmanyPETOK <= 0)
			{
				Bar_Pet.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Pet.GetComponent<Image>().fillAmount = 1f;
		}
		T_Pet.GetComponent<Text>().text = string.Format("{0}/{1}", (float)s3_7.HowmanyPETOK, Goal_Pet);
		if (Goal_Pet <= s3_7.HowmanyPETOK)
		{
			btn_Pet.interactable = true;
		}
		else
		{
			btn_Pet.interactable = false;
		}
	}

	public void Btn_Pet()
	{
		s3_7.HowmanyPETOK -= Goal_Pet;
		if (s3_7.HowmanyPETOK <= 0)
		{
			s3_7.HowmanyPETOK = 0;
		}
		Goal_Pet++;
		Q_MoneyPref.Plus_Q_Money = M_Pet;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Pet.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Pet;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Pet += 15000;
		M_T_Pet.GetComponent<Text>().text = string.Format("{0:n0}", M_Pet);
		SaveAll();
		Save();
	}

	public void Car()
	{
		if (s3_7.CarBuyOK <= Goal_Car)
		{
			Bar_Car.GetComponent<Image>().fillAmount = (float)s3_7.CarBuyOK / (float)Goal_Car;
			if (s3_7.CarBuyOK <= 0)
			{
				Bar_Car.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Car.GetComponent<Image>().fillAmount = 1f;
		}
		T_Car.GetComponent<Text>().text = string.Format("{0}/{1}", (float)s3_7.CarBuyOK, Goal_Car);
		if (Goal_Car <= s3_7.CarBuyOK)
		{
			btn_Car.interactable = true;
		}
		if (Goal_Car > s3_7.CarBuyOK)
		{
			btn_Car.interactable = false;
		}
	}

	public void Btn_Car()
	{
		s3_7.CarBuyOK -= Goal_Car;
		Q_MoneyPref.Plus_Q_Money = M_Car;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Car.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Car;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Car += 1000000;
		M_T_Car.GetComponent<Text>().text = string.Format("{0:n0}", M_Car);
		SaveAll();
		Save();
	}

	public void Friend()
	{
		if (PetPosition.Q_P_Friendly <= Goal_Friend)
		{
			Bar_Friend.GetComponent<Image>().fillAmount = (float)PetPosition.Q_P_Friendly / (float)Goal_Friend;
			if (PetPosition.Q_P_Friendly <= 0)
			{
				Bar_Friend.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Friend.GetComponent<Image>().fillAmount = 1f;
		}
		T_Friend.GetComponent<Text>().text = string.Format("{0}/{1}", (float)PetPosition.Q_P_Friendly, Goal_Friend);
		if (Goal_Friend <= PetPosition.Q_P_Friendly)
		{
			btn_Friend.interactable = true;
		}
		else
		{
			btn_Friend.interactable = false;
		}
	}

	public void Btn_Friend()
	{
		PetPosition.Q_P_Friendly -= Goal_Friend;
		if (PetPosition.Q_P_Friendly <= 0)
		{
			PetPosition.Q_P_Friendly = 0;
		}
		Goal_Friend += 50;
		Q_MoneyPref.Plus_Q_Money = M_Friend;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Friend.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Friend;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Friend += 30000;
		M_T_Friend.GetComponent<Text>().text = string.Format("{0:n0}", M_Friend);
		SaveAll();
		Save();
	}

	public void Spec()
	{
		if (ButtonCont.Q_SpecN <= Goal_Spec)
		{
			Bar_Spec.GetComponent<Image>().fillAmount = (float)ButtonCont.Q_SpecN / (float)Goal_Spec;
			if (ButtonCont.Q_SpecN <= 0)
			{
				Bar_Spec.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Spec.GetComponent<Image>().fillAmount = 1f;
		}
		T_Spec.GetComponent<Text>().text = string.Format("{0}/{1}", (float)ButtonCont.Q_SpecN, Goal_Spec);
		if (Goal_Spec <= ButtonCont.Q_SpecN)
		{
			btn_Spec.interactable = true;
		}
		else
		{
			btn_Spec.interactable = false;
		}
	}

	public void Btn_Spec()
	{
		ButtonCont.Q_SpecN -= Goal_Spec;
		if (ButtonCont.Q_SpecN <= 0)
		{
			ButtonCont.Q_SpecN = 0;
		}
		Goal_Spec += 5;
		Q_MoneyPref.Plus_Q_Money = M_Spec;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Spec.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Spec;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Spec += 30000;
		M_T_Spec.GetComponent<Text>().text = string.Format("{0:n0}", M_Spec);
		SaveAll();
		Save();
	}

	public void Buff()
	{
		if (TimeBuff.Q_BuffN <= Goal_Buff)
		{
			Bar_Buff.GetComponent<Image>().fillAmount = (float)TimeBuff.Q_BuffN / (float)Goal_Buff;
			if (TimeBuff.Q_BuffN <= 0)
			{
				Bar_Buff.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Buff.GetComponent<Image>().fillAmount = 1f;
		}
		T_Buff.GetComponent<Text>().text = string.Format("{0}/{1}", (float)TimeBuff.Q_BuffN, Goal_Buff);
		if (Goal_Buff <= TimeBuff.Q_BuffN)
		{
			btn_Buff.interactable = true;
		}
		else
		{
			btn_Buff.interactable = false;
		}
	}

	public void Btn_Buff()
	{
		TimeBuff.Q_BuffN -= Goal_Buff;
		if (TimeBuff.Q_BuffN <= 0)
		{
			TimeBuff.Q_BuffN = 0;
		}
		Goal_Buff += 5;
		Q_MoneyPref.Plus_Q_Money = M_Buff;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Buff.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Buff;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Buff += 30000;
		M_T_Buff.GetComponent<Text>().text = string.Format("{0:n0}", M_Buff);
		SaveAll();
		Save();
	}

	public void Study()
	{
		if (S2_4.Q_StudyN <= Goal_Study)
		{
			Bar_Study.GetComponent<Image>().fillAmount = (float)S2_4.Q_StudyN / (float)Goal_Study;
			if (S2_4.Q_StudyN <= 0)
			{
				Bar_Study.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Study.GetComponent<Image>().fillAmount = 1f;
		}
		T_Study.GetComponent<Text>().text = string.Format("{0}/{1}", (float)S2_4.Q_StudyN, Goal_Study);
		if (Goal_Study <= S2_4.Q_StudyN)
		{
			btn_Study.interactable = true;
		}
		else
		{
			btn_Study.interactable = false;
		}
	}

	public void Btn_Study()
	{
		S2_4.Q_StudyN -= Goal_Study;
		if (S2_4.Q_StudyN <= 0)
		{
			S2_4.Q_StudyN = 0;
		}
		Goal_Study++;
		Q_MoneyPref.Plus_Q_Money = M_Study;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Study.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Study;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Study += 50000;
		M_T_Study.GetComponent<Text>().text = string.Format("{0:n0}", M_Study);
		SaveAll();
		Save();
	}

	public void Alba()
	{
		if (S2_4.Q_AlbaN <= Goal_Alba)
		{
			Bar_Alba.GetComponent<Image>().fillAmount = (float)S2_4.Q_AlbaN / (float)Goal_Alba;
			if (S2_4.Q_AlbaN <= 0)
			{
				Bar_Alba.GetComponent<Image>().fillAmount = 0f;
			}
		}
		else
		{
			Bar_Alba.GetComponent<Image>().fillAmount = 1f;
		}
		T_Alba.GetComponent<Text>().text = string.Format("{0}/{1}", (float)S2_4.Q_AlbaN, Goal_Alba);
		if (Goal_Alba <= S2_4.Q_AlbaN)
		{
			btn_Alba.interactable = true;
		}
		else
		{
			btn_Alba.interactable = false;
		}
	}

	public void Btn_Alba()
	{
		S2_4.Q_AlbaN -= Goal_Alba;
		if (S2_4.Q_AlbaN <= 0)
		{
			S2_4.Q_AlbaN = 0;
		}
		Goal_Alba++;
		Q_MoneyPref.Plus_Q_Money = M_Alba;
		GameObject gameObject = Object.Instantiate(MoneyPref);
		gameObject.transform.SetParent(Pa_Alba.transform);
		gameObject.transform.localPosition = MoneyPref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		scene_controll.money += M_Alba;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		M_Alba += 50000;
		M_T_Alba.GetComponent<Text>().text = string.Format("{0:n0}", M_Alba);
		SaveAll();
		Save();
	}

	public void OpenQuest()
	{
		QuestScreen.SetActive(true);
	}

	public void CloseQuest()
	{
		QuestScreen.SetActive(false);
		SaveAll();
	}

	public void SaveAll()
	{
		PlayerPrefs.SetInt("Goal_Clothes", Goal_Clothes);
		PlayerPrefs.SetInt("M_Clothes", M_Clothes);
		PlayerPrefs.SetInt("Goal_Hair", Goal_Hair);
		PlayerPrefs.SetInt("M_Hair", M_Hair);
		PlayerPrefs.SetInt("Goal_Pet", Goal_Pet);
		PlayerPrefs.SetInt("M_Pet", M_Pet);
		PlayerPrefs.SetInt("Goal_Car", Goal_Car);
		PlayerPrefs.SetInt("M_Car", M_Car);
		PlayerPrefs.SetInt("Goal_Friend", Goal_Friend);
		PlayerPrefs.SetInt("M_Friend", M_Friend);
		PlayerPrefs.SetInt("Goal_Spec", Goal_Spec);
		PlayerPrefs.SetInt("M_Spec", M_Spec);
		PlayerPrefs.SetInt("Goal_Buff", Goal_Buff);
		PlayerPrefs.SetInt("M_Buff", M_Buff);
		PlayerPrefs.SetInt("Goal_Study", Goal_Study);
		PlayerPrefs.SetInt("M_Study", M_Study);
		PlayerPrefs.SetInt("Goal_Alba", Goal_Alba);
		PlayerPrefs.SetInt("M_Alba", M_Alba);
		Goal_Clothes = PlayerPrefs.GetInt("Goal_Clothes");
		M_Clothes = PlayerPrefs.GetInt("M_Clothes");
		Goal_Hair = PlayerPrefs.GetInt("Goal_Hair");
		M_Hair = PlayerPrefs.GetInt("M_Hair");
		Goal_Pet = PlayerPrefs.GetInt("Goal_Pet");
		M_Pet = PlayerPrefs.GetInt("M_Pet");
		Goal_Car = PlayerPrefs.GetInt("Goal_Car");
		M_Car = PlayerPrefs.GetInt("M_Car");
		Goal_Friend = PlayerPrefs.GetInt("Goal_Friend");
		M_Friend = PlayerPrefs.GetInt("M_Friend");
		Goal_Spec = PlayerPrefs.GetInt("Goal_Spec");
		M_Spec = PlayerPrefs.GetInt("M_Spec");
		Goal_Buff = PlayerPrefs.GetInt("Goal_Buff");
		M_Buff = PlayerPrefs.GetInt("M_Buff");
		Goal_Study = PlayerPrefs.GetInt("Goal_Study");
		M_Study = PlayerPrefs.GetInt("M_Study");
		Goal_Alba = PlayerPrefs.GetInt("Goal_Alba");
		M_Alba = PlayerPrefs.GetInt("M_Alba");
	}

	public void Save()
	{
		PlayerPrefs.SetInt("ClotheBuyOK", s3_7.ClotheBuyOK);
		PlayerPrefs.SetInt("HairBuyOK", s3_7.HairBuyOK);
		PlayerPrefs.SetInt("HowmanyPETOK", s3_7.HowmanyPETOK);
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		PlayerPrefs.SetInt("CarBuyOK", s3_7.CarBuyOK);
		PlayerPrefs.SetInt("Q_Clicker", ButtonCont.Q_Clicker);
		PlayerPrefs.SetInt("Q_P_Friendly", PetPosition.Q_P_Friendly);
		PlayerPrefs.SetInt("Q_SpecN", ButtonCont.Q_SpecN);
		PlayerPrefs.SetInt("Q_BuffN", TimeBuff.Q_BuffN);
		PlayerPrefs.SetInt("Q_StudyN", S2_4.Q_StudyN);
		PlayerPrefs.SetInt("Q_AlbaN", S2_4.Q_AlbaN);
	}
}
