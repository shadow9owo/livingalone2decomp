using UnityEngine;
using UnityEngine.UI;

public class Tuto_1 : MonoBehaviour
{
	private new string name;

	public GameObject TalkText;

	public static int Tutorial_Scene;

	private GameObject budongsan_Btn;

	private GameObject furn_Btn;

	private GameObject clothes_Btn;

	private GameObject hair_Btn;

	private GameObject car_Btn;

	private GameObject pet_Btn;

	private GameObject budongsan_Back;

	private GameObject furn_Back;

	private GameObject clothes_Back;

	private GameObject hair_Back;

	private GameObject car_Back;

	private GameObject pet_Back;

	private GameObject Cash_Btn;

	private GameObject Parking_Btn;

	private GameObject Buff_Btn;

	private GameObject Quest_Btn;

	private GameObject Gradubuff_Btn;

	private GameObject Album_Btn;

	private GameObject Item_Btn;

	private GameObject Rank_Btn;

	private GameObject Leader_Btn;

	private GameObject Setting_Btn;

	private GameObject btn_cash;

	private GameObject reportbtn;

	private GameObject window_talk;

	public AudioClip Buttonsound;

	private void Start()
	{
		name = PlayerPrefs.GetString("Nick");
		if (Application.loadedLevelName == "newone")
		{
			Cash_Btn = GameObject.Find("Btn_cash_shop");
			Parking_Btn = GameObject.Find("Btn_parking");
			Buff_Btn = GameObject.Find("btn");
			Quest_Btn = GameObject.Find("Btn_Awards");
			Gradubuff_Btn = GameObject.Find("Btn_GraduBuff");
			Album_Btn = GameObject.Find("Btn_ending");
			Item_Btn = GameObject.Find("Btn_item");
			Rank_Btn = GameObject.Find("Btn_achievement");
			Leader_Btn = GameObject.Find("Btn_leaderboard");
			Setting_Btn = GameObject.Find("Btn_Setting");
			btn_cash = GameObject.Find("btn_cash");
			reportbtn = GameObject.Find("reportbtn");
			window_talk = GameObject.Find("window_talk");
			Parking_Btn.GetComponent<Button>().interactable = false;
			Buff_Btn.GetComponent<Button>().interactable = false;
			Gradubuff_Btn.GetComponent<Button>().interactable = false;
			Album_Btn.GetComponent<Button>().interactable = false;
			Item_Btn.GetComponent<Button>().interactable = false;
			Rank_Btn.GetComponent<Button>().interactable = false;
			Leader_Btn.GetComponent<Button>().interactable = false;
			Setting_Btn.GetComponent<Button>().interactable = false;
			reportbtn.GetComponent<Button>().interactable = false;
			window_talk.GetComponent<Button>().interactable = false;
			if (Tutorial_Scene == 23)
			{
				TalkText.GetComponent<Text>().text = string.Format("Ouch! You already\nhave no money!\nI will let you know\nhow to earn money.");
			}
			if (Tutorial_Scene == 25)
			{
				TalkText.GetComponent<Text>().text = string.Format("How was your first\nday at work?\nHaha.Let's go to Uni now.");
				GetComponent<Button>().interactable = false;
				GameObject gameObject = (GameObject)Resources.Load("Tutorial/menu_study_tuto");
				GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/menu_study_tuto"));
				GameObject gameObject3 = GameObject.Find("Bottom_parent");
				gameObject2.transform.SetParent(gameObject3.transform);
				gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = gameObject.transform.localPosition;
				gameObject2.transform.localScale = gameObject.transform.localScale;
			}
			if (Tutorial_Scene == 26)
			{
				TalkText.GetComponent<Text>().text = string.Format("Your future is depends on what you learn!\nhmm? What happens after graduation?\nLet's check 'Album'");
				GameObject gameObject4 = (GameObject)Resources.Load("Tutorial/Btn_ending_tuto");
				GameObject gameObject5 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Btn_ending_tuto"));
				GameObject gameObject6 = GameObject.Find("Bottom_parent");
				gameObject5.transform.SetParent(gameObject6.transform);
				gameObject5.transform.GetComponent<RectTransform>().anchoredPosition = gameObject4.transform.localPosition;
				gameObject5.transform.localScale = gameObject4.transform.localScale;
				GetComponent<Button>().interactable = false;
			}
			if (Tutorial_Scene == 32)
			{
				TalkText.GetComponent<Text>().text = string.Format("Look! After going to Part time or Uni\ntime and desire are running out.");
				GameObject gameObject7 = (GameObject)Resources.Load("Tutorial/TimeBar");
				GameObject gameObject8 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/TimeBar"));
				GameObject gameObject9 = GameObject.Find("Top_parent");
				gameObject8.transform.SetParent(gameObject9.transform);
				gameObject8.transform.GetComponent<RectTransform>().anchoredPosition = gameObject7.transform.localPosition;
				gameObject8.transform.localScale = gameObject7.transform.localScale;
				GameObject gameObject10 = (GameObject)Resources.Load("Tutorial/Abilitybar");
				GameObject gameObject11 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Abilitybar"));
				GameObject gameObject12 = GameObject.Find("Top_parent");
				gameObject11.transform.SetParent(gameObject12.transform);
				gameObject11.transform.GetComponent<RectTransform>().anchoredPosition = gameObject10.transform.localPosition;
				gameObject11.transform.localScale = gameObject10.transform.localScale;
				GameObject.Find("tuto_hp_bar").GetComponent<Image>().fillAmount = BarCont.hp / 50f;
				GameObject.Find("tuto_mp_bar").GetComponent<Image>().fillAmount = BarCont.mp / 50f;
				GameObject.Find("tuto_int_bar").GetComponent<Image>().fillAmount = BarCont._int / 50f;
				GameObject.Find("tuto_happy_bar").GetComponent<Image>().fillAmount = BarCont.happy / 50f;
				GameObject.Find("tuto_GreenBar").GetComponent<Image>().fillAmount = BarCont.point / 100f;
				GameObject.Find("tuto_hp_000").GetComponent<Text>().text = string.Format("{0:n2}", BarCont.hp);
				GameObject.Find("tuto_mp_000").GetComponent<Text>().text = string.Format("{0:n2}", BarCont.mp);
				GameObject.Find("tuto_int_000").GetComponent<Text>().text = string.Format("{0:n2}", BarCont._int);
				GameObject.Find("tuto_happy_000").GetComponent<Text>().text = string.Format("{0:n2}", BarCont.happy);
				GameObject.Find("tuto_stbar").GetComponent<Image>().fillAmount = BarCont.st / 100f;
				GameObject.Find("tuto_st_text").GetComponent<Text>().text = string.Format("{0:n1}", BarCont.st);
			}
			if (Tutorial_Scene == 38)
			{
				NEXT();
			}
			if (Tutorial_Scene == 41)
			{
				number_39();
			}
			if (Tutorial_Scene == 42)
			{
				number_40();
			}
		}
		if (Application.loadedLevelName == "newone2")
		{
			GameObject.Find("btn_back").GetComponent<Button>().interactable = false;
			if (Tutorial_Scene < 7)
			{
				budongsan_Btn = GameObject.Find("btn_house");
				furn_Btn = GameObject.Find("btn_fur");
				clothes_Btn = GameObject.Find("btn_clo");
				hair_Btn = GameObject.Find("btn_hair");
				car_Btn = GameObject.Find("btn_car");
				pet_Btn = GameObject.Find("btn_pet");
				budongsan_Btn.GetComponent<Button>().interactable = false;
				furn_Btn.GetComponent<Button>().interactable = false;
				clothes_Btn.GetComponent<Button>().interactable = false;
				hair_Btn.GetComponent<Button>().interactable = false;
				car_Btn.GetComponent<Button>().interactable = false;
				pet_Btn.GetComponent<Button>().interactable = false;
			}
		}
		if (Application.loadedLevelName == "ptj")
		{
			if (Tutorial_Scene == 24)
			{
				TalkText.GetComponent<Text>().text = string.Format("The only gig you can take\nat the moment is\nthe Mascot doll job.");
			}
			if (Tutorial_Scene == 25)
			{
				TalkText.GetComponent<Text>().text = string.Format("When you go to school,\nyou must pay your living expenses\nfor 10 days every day.");
				GameObject gameObject13 = (GameObject)Resources.Load("Tutorial/studyInfo");
				GameObject gameObject14 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/studyInfo"));
				GameObject gameObject15 = GameObject.Find("tutorial_parent");
				gameObject14.transform.SetParent(gameObject15.transform);
				gameObject14.transform.localPosition = gameObject13.transform.localPosition;
				gameObject14.transform.localScale = gameObject13.transform.localScale;
			}
		}
		if (Application.loadedLevelName == "ending" && Tutorial_Scene == 26)
		{
			TalkText.GetComponent<Text>().text = string.Format("There are 'Graduation Ending'\nand 'Defeat Ending'.");
			GameObject.Find("back").GetComponent<Button>().interactable = false;
		}
	}

	public void ButtonSound()
	{
		GetComponent<AudioSource>().clip = Buttonsound;
		GetComponent<AudioSource>().Play();
	}

	public void NEXT()
	{
		ButtonSound();
		if (Tutorial_Scene == 0)
		{
			TalkText.GetComponent<Text>().text = string.Format("Nice to see you {0}.!\nLet me introduce this world~", name);
		}
		if (Tutorial_Scene == 1)
		{
			TalkText.GetComponent<Text>().text = string.Format("Look above!\nThere are your Desire and GPA");
			GameObject gameObject = (GameObject)Resources.Load("Tutorial/Abilitybar");
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Abilitybar"));
			GameObject gameObject3 = GameObject.Find("Top_parent");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = gameObject.transform.localPosition;
			gameObject2.transform.localScale = gameObject.transform.localScale;
		}
		if (Tutorial_Scene == 2)
		{
			TalkText.GetComponent<Text>().text = string.Format("These are Gem, money\nyou have and your name,grade\nand semester.");
			GameObject gameObject4 = (GameObject)Resources.Load("Tutorial/Calander");
			GameObject gameObject5 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Calander"));
			GameObject gameObject6 = GameObject.Find("Top_parent");
			gameObject5.transform.SetParent(gameObject6.transform);
			gameObject5.transform.GetComponent<RectTransform>().anchoredPosition = gameObject4.transform.localPosition;
			gameObject5.transform.localScale = gameObject4.transform.localScale;
			GameObject.Find("tuto_name").GetComponent<Text>().text = string.Format("{0}", name);
			GameObject.Find("tuto_money_text").GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
			Object.DestroyImmediate(GameObject.Find("Abilitybar(Clone)"));
		}
		if (Tutorial_Scene == 3)
		{
			TalkText.GetComponent<Text>().text = string.Format("This is time.It is March now.\nIf you run out of time, you will move on to the next month.");
			GameObject gameObject7 = (GameObject)Resources.Load("Tutorial/TimeBar");
			GameObject gameObject8 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/TimeBar"));
			GameObject gameObject9 = GameObject.Find("Top_parent");
			gameObject8.transform.SetParent(gameObject9.transform);
			gameObject8.transform.GetComponent<RectTransform>().anchoredPosition = gameObject7.transform.localPosition;
			gameObject8.transform.localScale = gameObject7.transform.localScale;
			Object.DestroyImmediate(GameObject.Find("Calander(Clone)"));
		}
		if (Tutorial_Scene == 4)
		{
			TalkText.GetComponent<Text>().text = string.Format("You can see your inside here");
			GameObject gameObject10 = (GameObject)Resources.Load("Tutorial/window_talk_tuto");
			GameObject gameObject11 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/window_talk_tuto"));
			GameObject gameObject12 = GameObject.Find("Bottom_parent");
			gameObject11.transform.SetParent(gameObject12.transform);
			gameObject11.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 259f, 0f);
			gameObject11.transform.localScale = gameObject10.transform.localScale;
			Object.DestroyImmediate(GameObject.Find("TimeBar(Clone)"));
		}
		if (Tutorial_Scene == 5)
		{
			TalkText.GetComponent<Text>().text = string.Format("I think that’s enough introduction.\nHm? The house too shabby?\nThen shall we go take a look at a better house? \nTap the shopping!");
			Object.DestroyImmediate(GameObject.Find("window_talk_tuto(Clone)"));
			GetComponent<Button>().interactable = false;
			GameObject gameObject13 = (GameObject)Resources.Load("Tutorial/menu_shopping_tuto");
			GameObject gameObject14 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/menu_shopping_tuto"));
			GameObject gameObject15 = GameObject.Find("Bottom_parent");
			gameObject14.transform.SetParent(gameObject15.transform);
			gameObject14.transform.GetComponent<RectTransform>().anchoredPosition = gameObject13.transform.localPosition;
			gameObject14.transform.localScale = gameObject13.transform.localScale;
		}
		if (Tutorial_Scene == 6)
		{
			TalkText.GetComponent<Text>().text = string.Format("Please tap 'real property'");
			budongsan_Btn.GetComponent<Button>().interactable = true;
			furn_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			car_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
			clothes_Btn.GetComponent<Button>().interactable = false;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 7)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you have enough money\nYou can move out anytime!");
			budongsan_Back = GameObject.Find("btn_back_3_2");
			budongsan_Back.GetComponent<Button>().interactable = false;
			GetComponent<Button>().enabled = true;
			GetComponent<Image>().enabled = true;
		}
		if (Tutorial_Scene == 8)
		{
			TalkText.GetComponent<Text>().text = string.Format("But there is condition\nto move out.\nLet's go back and go to the furniture store.");
			GetComponent<Button>().interactable = false;
			budongsan_Back = GameObject.Find("btn_back_3_2");
			budongsan_Back.GetComponent<Button>().interactable = true;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 9)
		{
			TalkText.GetComponent<Text>().text = string.Format("Tap'furniture store'");
			GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = true;
			clothes_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			car_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
		}
		if (Tutorial_Scene == 10)
		{
			TalkText.GetComponent<Text>().text = string.Format("The furnitures are distributed in 3 areas:\nbedroom,living room and bathroom.\nBuy first 3 of furnitures.");
			furn_Back = GameObject.Find("btn_back_3_3");
			furn_Back.GetComponent<Button>().interactable = false;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 11)
		{
			TalkText.GetComponent<Text>().text = string.Format("Well done!\nYou have to buy all nine furniture\nin the furniture store\nbefore you can move to the next house.\nRemember.");
			GetComponent<Button>().interactable = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 12)
		{
			TalkText.GetComponent<Text>().text = string.Format("Next, I will introduce 'Clothing store'.");
			clothes_Btn.GetComponent<Button>().interactable = true;
			GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			car_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
		}
		if (Tutorial_Scene == 13)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you buy clothes,\nyou can get the effects of rent deduction.\nIf you can afford it, get it.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 14)
		{
			TalkText.GetComponent<Text>().text = string.Format("Now let's go to\n'Beauty salon'");
			hair_Btn.GetComponent<Button>().interactable = true;
			GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			clothes_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = false;
			car_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
		}
		if (Tutorial_Scene == 15)
		{
			TalkText.GetComponent<Text>().text = string.Format("Changing your hair can raise\nyour Desire Reduction rate. \nIf you can afford it, get it.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 16)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you live alone,\nit's going to be lonely.\nDo you want to buy a pet?");
			pet_Btn.GetComponent<Button>().interactable = true;
			GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			clothes_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = false;
			car_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			GameObject.Find("tuto_Image").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 1432f, 0f);
			GameObject.Find("talkballoon").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(63f, 393f, 0f);
			GameObject.Find("TalkText").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(76f, 394f, 0f);
		}
		if (Tutorial_Scene == 17)
		{
			pet_Back = GameObject.Find("btn_back_3_7");
			pet_Back.GetComponent<Button>().interactable = false;
			TalkText.GetComponent<Text>().text = string.Format("Pets make money for you\nevery 10 seconds,\nso be sure to buy it.\nLocked pets will open when you collect\n'Defeat Endings'.");
			GameObject.Find("tuto_Image").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 163f, 0f);
			GameObject.Find("talkballoon").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(63f, -876f, 0f);
			GameObject.Find("TalkText").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(76f, -875f, 0f);
			GetComponent<Button>().enabled = true;
			GetComponent<Button>().interactable = true;
			GetComponent<Image>().enabled = true;
		}
		if (Tutorial_Scene == 18)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's buy a Cat!");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 19)
		{
			pet_Back = GameObject.Find("btn_back_3_7");
			pet_Back.GetComponent<Button>().interactable = true;
			TalkText.GetComponent<Text>().text = string.Format("Good job!You make pet's lv. goes up by tap a pet.\nThen pet makes money more.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 20)
		{
			TalkText.GetComponent<Text>().text = string.Format("Oh! You can buy car also.");
			car_Btn.GetComponent<Button>().interactable = true;
			GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			clothes_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
			GameObject.Find("tuto_Image").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 1432f, 0f);
			GameObject.Find("talkballoon").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(63f, 393f, 0f);
			GameObject.Find("TalkText").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(76f, 394f, 0f);
		}
		if (Tutorial_Scene == 21)
		{
			TalkText.GetComponent<Text>().text = string.Format("You probably can't\nafford a car now,\nbut work hard to buy one.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
			GameObject.Find("tuto_Image").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 163f, 0f);
			GameObject.Find("talkballoon").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(63f, -876f, 0f);
			GameObject.Find("TalkText").transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(76f, -875f, 0f);
		}
		if (Tutorial_Scene == 22)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's go back home!");
			car_Btn.GetComponent<Button>().interactable = false;
			budongsan_Btn.GetComponent<Button>().interactable = false;
			clothes_Btn.GetComponent<Button>().interactable = false;
			furn_Btn.GetComponent<Button>().interactable = false;
			hair_Btn.GetComponent<Button>().interactable = false;
			pet_Btn.GetComponent<Button>().interactable = false;
			GameObject.Find("btn_back").GetComponent<Button>().interactable = true;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 23)
		{
			TalkText.GetComponent<Text>().text = string.Format("You can earn money\nby part-time\nTap 'Part time'");
			GetComponent<Button>().interactable = false;
			GameObject gameObject16 = (GameObject)Resources.Load("Tutorial/menu_parttime_tuto");
			GameObject gameObject17 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/menu_parttime_tuto"));
			GameObject gameObject18 = GameObject.Find("Bottom_parent");
			gameObject17.transform.SetParent(gameObject18.transform);
			gameObject17.transform.GetComponent<RectTransform>().anchoredPosition = gameObject16.transform.localPosition;
			gameObject17.transform.localScale = gameObject16.transform.localScale;
		}
		if (Tutorial_Scene == 24)
		{
			TalkText.GetComponent<Text>().text = string.Format("As your part-time lv. goes up,\nthe money you earn will increase.\nSo keep working at your part time jobs.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 25)
		{
			TalkText.GetComponent<Text>().text = string.Format("You can take one of the 4 classes:\nHumanities, Science, Art&PE, and Liberal Arts.\nChoose a class that seems most appealing to you.");
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 26)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's look around 'Graduation Ending'first.");
			GameObject.Find("Gradu_btn").GetComponent<Button>().interactable = true;
			GameObject.Find("Frust_btn").GetComponent<Button>().interactable = false;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 27)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you graduate school, You can get this ending.\nGood graduation ending gives more gem.");
			GetComponent<Button>().enabled = true;
			GetComponent<Image>().enabled = true;
		}
		if (Tutorial_Scene == 28)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's go back\nto check 'Defeat Ending'.");
			GameObject.Find("back").GetComponent<Button>().interactable = true;
			GetComponent<Button>().enabled = false;
			GetComponent<Image>().enabled = false;
		}
		if (Tutorial_Scene == 29)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's check 'Defeat Ending'");
			GameObject.Find("Gradu_btn").GetComponent<Button>().interactable = false;
			GameObject.Find("Frust_btn").GetComponent<Button>().interactable = true;
			GameObject.Find("back").GetComponent<Button>().interactable = false;
		}
		if (Tutorial_Scene == 30)
		{
			TalkText.GetComponent<Text>().text = string.Format("Defeat endings are some things\nthat you will experience in your life.\nGetting defeat endings unlock pets for purchase.");
			GameObject.Find("back").GetComponent<Button>().interactable = true;
		}
		if (Tutorial_Scene == 31)
		{
			TalkText.GetComponent<Text>().text = string.Format("Let's go back home.");
			GameObject.Find("back").GetComponent<Button>().interactable = true;
			GameObject.Find("Gradu_btn").GetComponent<Button>().interactable = false;
			GameObject.Find("Frust_btn").GetComponent<Button>().interactable = false;
		}
		if (Tutorial_Scene == 32)
		{
			TalkText.GetComponent<Text>().text = string.Format("You must pay rent fee at the end of every month.\nAnd pay the tuition fee yourself.");
		}
		if (Tutorial_Scene == 33)
		{
			TalkText.GetComponent<Text>().text = string.Format("Do you see that\nmoney part is red?\nBecause you can't pay rent fee for the next month.");
			Object.Destroy(GameObject.Find("TimeBar(Clone)"));
			Object.Destroy(GameObject.Find("Abilitybar(Clone)"));
			GameObject gameObject19 = (GameObject)Resources.Load("Tutorial/Calander");
			GameObject gameObject20 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Calander"));
			GameObject gameObject21 = GameObject.Find("Top_parent");
			gameObject20.transform.SetParent(gameObject21.transform);
			gameObject20.transform.GetComponent<RectTransform>().anchoredPosition = gameObject19.transform.localPosition;
			gameObject20.transform.localScale = gameObject19.transform.localScale;
			GameObject.Find("tuto_name").GetComponent<Text>().text = string.Format("{0}", TalkingText.Name);
			GameObject.Find("tuto_money_text").GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		}
		if (Tutorial_Scene == 34)
		{
			TalkText.GetComponent<Text>().text = string.Format("You can choose to “Spec-Up” if you would like something\nto replace part-time jobs and school without spending time.");
			Object.Destroy(GameObject.Find("Calander(Clone)"));
			GetComponent<Button>().interactable = false;
			GameObject gameObject22 = (GameObject)Resources.Load("Tutorial/menu_event_tuto");
			GameObject gameObject23 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/menu_event_tuto"));
			GameObject gameObject24 = GameObject.Find("Bottom_parent");
			gameObject23.transform.SetParent(gameObject24.transform);
			gameObject23.transform.GetComponent<RectTransform>().anchoredPosition = gameObject22.transform.localPosition;
			gameObject23.transform.localScale = gameObject22.transform.localScale;
		}
		if (Tutorial_Scene == 35)
		{
			Object.Destroy(GameObject.Find("menu_event_tuto(Clone)"));
			TalkText.GetComponent<Text>().text = string.Format("Spec-Up gives you some extra GPA,\nand you can even win some prize money\nif you do well in the competition.");
			GameObject.Find("ToeicBtn").GetComponent<Button>().interactable = false;
			GameObject.Find("ContestBtn").GetComponent<Button>().interactable = false;
			GetComponent<Image>().color = Color.clear;
		}
		if (Tutorial_Scene == 36)
		{
			TalkText.GetComponent<Text>().text = string.Format("You need Hearts to do Spec-Up, so think wisely.\nYou get a Heart recharged every 15 minutes.");
			Object.DestroyImmediate(GameObject.Find("menu_event_tuto(Clone)"));
		}
		if (Tutorial_Scene == 37)
		{
			Object.Destroy(GameObject.Find("Tuto_2(Clone)"));
			GameObject.Find("event_panel").SetActive(false);
			GameObject.Find("BackBtn_Child").SetActive(false);
			GameObject gameObject25 = (GameObject)Resources.Load("Tutorial/Tuto_1");
			GameObject gameObject26 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_1"));
			GameObject gameObject27 = GameObject.Find("tutorial_parent");
			gameObject26.transform.SetParent(gameObject27.transform);
			gameObject26.transform.localPosition = gameObject25.transform.localPosition;
			gameObject26.transform.localScale = gameObject25.transform.localScale;
		}
		if (Tutorial_Scene == 38)
		{
			TalkText.GetComponent<Text>().text = string.Format("You can fill your Desire meter\nby touching furnitures in your house.");
		}
		if (Tutorial_Scene == 39)
		{
			TalkText.GetComponent<Text>().text = string.Format("Bed is for HP,\nkitchen is for Hunger,\ndesk is for Fun, and toilet is for Hygiene.");
		}
		if (Tutorial_Scene == 40)
		{
			Object.Destroy(GameObject.Find("Tuto_1(Clone)"));
			GameObject gameObject28 = (GameObject)Resources.Load("Tutorial/Tuto_2");
			GameObject gameObject29 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_2"));
			GameObject gameObject30 = GameObject.Find("Bottom_parent");
			gameObject29.transform.SetParent(gameObject30.transform);
			gameObject29.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject29.transform.localScale = gameObject28.transform.localScale;
			Debug.Log("39");
			GetComponent<Image>().enabled = false;
			GetComponent<Button>().enabled = false;
			TalkText.GetComponent<Text>().text = string.Format("Tap any furniture you like!");
		}
		if (Tutorial_Scene == 41)
		{
			TalkText.GetComponent<Text>().text = string.Format("Manage your Desires well.\nBut be careful.\nTime is running out even when you are using the furnitures.");
			Object.Destroy(GameObject.Find("Tuto_2(Clone)"));
			GameObject gameObject31 = (GameObject)Resources.Load("Tutorial/Tuto_1");
			GameObject gameObject32 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_1"));
			GameObject gameObject33 = GameObject.Find("tutorial_parent");
			gameObject32.transform.SetParent(gameObject33.transform);
			gameObject32.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject32.transform.localScale = gameObject31.transform.localScale;
		}
		if (Tutorial_Scene == 42)
		{
			TalkText.GetComponent<Text>().text = string.Format("Finally, I will let you know\nthe most important thing!");
		}
		if (Tutorial_Scene == 43)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you let your balance become 0,");
			Object.Destroy(GameObject.Find("Tuto_UpInfo_6(Clone)"));
			GameObject gameObject34 = (GameObject)Resources.Load("Tutorial/Tuto_UpInfo_7");
			GameObject gameObject35 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_UpInfo_7"));
			GameObject gameObject36 = GameObject.Find("tutorial_parent");
			gameObject35.transform.SetParent(gameObject36.transform);
			gameObject35.transform.localPosition = gameObject34.transform.localPosition;
			gameObject35.transform.localScale = gameObject34.transform.localScale;
		}
		if (Tutorial_Scene == 44)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you let your balance become 0,\nor GPA drop to F,");
			GameObject gameObject37 = (GameObject)Resources.Load("Tutorial/Tuto_UpInfo_8");
			GameObject gameObject38 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_UpInfo_8"));
			GameObject gameObject39 = GameObject.Find("tutorial_parent");
			gameObject38.transform.SetParent(gameObject39.transform);
			gameObject38.transform.localPosition = gameObject37.transform.localPosition;
			gameObject38.transform.localScale = gameObject37.transform.localScale;
		}
		if (Tutorial_Scene == 45)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you let your balance become 0,\nor GPA drop to F,\nor let all the desire meters reach 0,");
			GameObject gameObject40 = (GameObject)Resources.Load("Tutorial/Tuto_UpInfo_9");
			GameObject gameObject41 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_UpInfo_9"));
			GameObject gameObject42 = GameObject.Find("tutorial_parent");
			gameObject41.transform.SetParent(gameObject42.transform);
			gameObject41.transform.localPosition = gameObject40.transform.localPosition;
			gameObject41.transform.localScale = gameObject40.transform.localScale;
		}
		if (Tutorial_Scene == 46)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you let your balance become 0,\nor GPA drop to F,\nor let all the desire reach 0, you have to “Reincarnate”.");
		}
		if (Tutorial_Scene == 47)
		{
			TalkText.GetComponent<Text>().text = string.Format("If you Reincarnate, you go back to the beginning of the first semester in freshman year.");
		}
		if (Tutorial_Scene == 48)
		{
			TalkText.GetComponent<Text>().text = string.Format("I think I've explained enough.\nYou’ll be able to learn the rest by playing the game.");
			Object.Destroy(GameObject.Find("Tuto_UpInfo_7(Clone)"));
			Object.Destroy(GameObject.Find("Tuto_UpInfo_8(Clone)"));
			Object.Destroy(GameObject.Find("Tuto_UpInfo_9(Clone)"));
		}
		if (Tutorial_Scene == 49)
		{
			TalkText.GetComponent<Text>().text = string.Format("Then enjoy your school life\nand take care!!");
			GameObject gameObject43 = (GameObject)Resources.Load("Tutorial/start_btn");
			GameObject.Find("skip_btn").SetActive(false);
			GameObject gameObject44 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/start_btn"));
			GameObject gameObject45 = GameObject.Find("tutorial_parent");
			gameObject44.transform.SetParent(gameObject45.transform);
			gameObject44.transform.localPosition = gameObject43.transform.localPosition;
			gameObject44.transform.localScale = gameObject43.transform.localScale;
		}
		Tutorial_Scene++;
		Debug.Log("Tutorial_Scene=" + Tutorial_Scene);
	}

	private void OnDestory()
	{
		Resources.UnloadUnusedAssets();
		Object.DestroyImmediate(GameObject.Find("Tuto_UpInfo_1(Clone)"));
	}

	public void FinishTuto()
	{
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().Success();
		Parking_Btn = GameObject.Find("Btn_parking");
		Buff_Btn = GameObject.Find("btn");
		Quest_Btn = GameObject.Find("Btn_Awards");
		Gradubuff_Btn = GameObject.Find("Btn_GraduBuff");
		Album_Btn = GameObject.Find("Btn_ending");
		Item_Btn = GameObject.Find("Btn_item");
		Rank_Btn = GameObject.Find("Btn_achievement");
		Leader_Btn = GameObject.Find("Btn_leaderboard");
		Setting_Btn = GameObject.Find("Btn_Setting");
		btn_cash = GameObject.Find("btn_cash");
		reportbtn = GameObject.Find("reportbtn");
		window_talk = GameObject.Find("window_talk");
		Parking_Btn.GetComponent<Button>().interactable = true;
		Buff_Btn.GetComponent<Button>().interactable = true;
		Gradubuff_Btn.GetComponent<Button>().interactable = true;
		Album_Btn.GetComponent<Button>().interactable = true;
		Item_Btn.GetComponent<Button>().interactable = true;
		Rank_Btn.GetComponent<Button>().interactable = true;
		Leader_Btn.GetComponent<Button>().interactable = true;
		Setting_Btn.GetComponent<Button>().interactable = true;
		reportbtn.GetComponent<Button>().interactable = true;
		window_talk.GetComponent<Button>().interactable = true;
		GameObject.Find("menu_unistreet").GetComponent<Button>().interactable = true;
		PlayerPrefs.SetInt("Tutorial_Int", 1);
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		PlayerPrefs.SetInt("Tutoint_event", 1);
		Object.Destroy(GameObject.Find("tutorial_parent"));
		Object.Destroy(GameObject.Find("Top_parent"));
		Object.Destroy(GameObject.Find("Bottom_parent"));
		GameObject.Find("TimeController").GetComponent<TimeCont>().LovertimeStart();
		ButtonCont.present = PlayerPrefs.GetInt("present");
		if (ButtonCont.present == 0)
		{
			GameObject gameObject = (GameObject)Resources.Load("Freegem200");
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Freegem200"));
			GameObject gameObject3 = GameObject.Find("eventpop_prt");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, 47f, 0f);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			scene_controll.gem += 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			PlayerPrefs.SetInt("present", 1);
		}
	}

	public void number_39()
	{
		GetComponent<Image>().enabled = false;
		GetComponent<Button>().enabled = false;
		TalkText.GetComponent<Text>().text = string.Format("Tap any furniture you like!");
	}

	public void number_40()
	{
		TalkText.GetComponent<Text>().text = string.Format("Manage your Desires well. But be careful.\nTime is running out even when you are using the furnitures.");
	}

	public void Reallyskip()
	{
		GameObject gameObject = (GameObject)Resources.Load("Tutorial/Tutoconfirm");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tutoconfirm"));
		GameObject gameObject3 = GameObject.Find("tutorial_parent");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
	}

	public void Noskip()
	{
		Object.Destroy(GameObject.Find("Tutoconfirm(Clone)"));
	}

	public void ButtonSound_menu()
	{
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<ButtonCont>().SaveMoney();
	}

	public void EndingBtn()
	{
		GameObject.Find("dms").GetComponent<scene_controll_2>().btn_album();
	}

	public void StudyBtn()
	{
		GameObject.Find("dms").GetComponent<scene_controll_2>().studyScreen();
	}

	public void Parttimejob()
	{
		GameObject.Find("dms").GetComponent<scene_controll_2>().btn_ptj();
	}

	public void Shopping()
	{
		GameObject.Find("dms").GetComponent<scene_controll_2>().btn_shopping();
	}

	public void Event()
	{
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<ButtonCont>().eventScreen();
	}
}
