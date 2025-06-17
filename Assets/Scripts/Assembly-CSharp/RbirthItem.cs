using UnityEngine;
using UnityEngine.UI;

public class RbirthItem : MonoBehaviour
{
	public GameObject Panel;

	public GameObject Particle_Pref;

	public AudioClip Button_1;

	public AudioClip Yeah;

	public GameObject[] ResultImg;

	public GameObject mybutton;

	public static int Item_N_1;

	public static int Item_N_2;

	public static int Item_N_3;

	public static int Item_N_4;

	public static int Item_N_5;

	public Transform Item_N_1_percent;

	public Transform Item_N_2_percent;

	public Transform Item_N_3_percent;

	public Transform Item_N_4_percent;

	public Transform Item_N_5_percent;

	public GameObject WhiteImg;

	private float Plus_percentage;

	public static int Item_N;

	public static int bonusmoney;

	private int Plus_buffmoney;

	private GameObject Parent;

	private GameObject canvas;

	private void Awake()
	{
		Item_N_1 = PlayerPrefs.GetInt("Item_N_1");
		Item_N_2 = PlayerPrefs.GetInt("Item_N_2");
		Item_N_3 = PlayerPrefs.GetInt("Item_N_3");
		Item_N_4 = PlayerPrefs.GetInt("Item_N_4");
		Item_N_5 = PlayerPrefs.GetInt("Item_N_5");
	}

	private void Start()
	{
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
	}

	public void Item1()
	{
		Item_N = 1;
		int num = Random.Range(1, 4);
		if (num == 1)
		{
			Plus_percentage = 0.03f;
		}
		if (num == 2)
		{
			Plus_percentage = 0.05f;
		}
		if (num == 3)
		{
			Plus_percentage = 0.09f;
		}
		Item_N_1_percent.GetComponent<Text>().text = string.Format("+" + Plus_percentage * 100f + "%");
		PetPosition.bonuspercent += Plus_percentage;
		Debug.Log("아이템1상자클릭" + Item_N);
		Confirm();
	}

	public void Item2()
	{
		Item_N = 2;
		int num = Random.Range(1, 4);
		if (num == 1)
		{
			Plus_percentage = 0.05f;
		}
		if (num == 2)
		{
			Plus_percentage = 0.06f;
		}
		if (num == 3)
		{
			Plus_percentage = 0.09f;
		}
		Item_N_2_percent.GetComponent<Text>().text = string.Format("+" + Plus_percentage * 100f + "%");
		S2_4.Buff_pluspay += Plus_percentage;
		Debug.Log("아이템2상자클릭" + Item_N);
		Confirm();
	}

	public void Item3()
	{
		Item_N = 3;
		int num = Random.Range(1, 4);
		if (num == 1)
		{
			Plus_percentage = 0.03f;
		}
		if (num == 2)
		{
			Plus_percentage = 0.05f;
		}
		if (num == 3)
		{
			Plus_percentage = 0.1f;
		}
		Item_N_3_percent.GetComponent<Text>().text = string.Format("-" + Plus_percentage * 100f + "%");
		FeeCont.bonussale += Plus_percentage;
		Debug.Log("아이템3상자클릭" + Item_N);
		Confirm();
	}

	public void Item4()
	{
		Item_N = 4;
		int num = Random.Range(1, 4);
		if (num == 1)
		{
			Plus_percentage = 0.01f;
		}
		if (num == 2)
		{
			Plus_percentage = 0.02f;
		}
		if (num == 3)
		{
			Plus_percentage = 0.03f;
		}
		Item_N_4_percent.GetComponent<Text>().text = string.Format("+" + Plus_percentage * 100f + "%");
		FurnBtn.Buff_minustime += Plus_percentage;
		Debug.Log("아이템4상자클릭" + Item_N);
		Confirm();
	}

	public void Item5()
	{
		Item_N = 5;
		int num = Random.Range(1, 4);
		if (num == 1)
		{
			Plus_buffmoney = 200000;
		}
		if (num == 2)
		{
			Plus_buffmoney = 500000;
		}
		if (num == 3)
		{
			Plus_buffmoney = 1000000;
		}
		Item_N_5_percent.GetComponent<Text>().text = string.Format("{0:n0}", Plus_buffmoney);
		bonusmoney += Plus_buffmoney;
		Debug.Log("아이템5상자클릭" + Item_N);
		Confirm();
	}

	public void ButtonSound()
	{
		GetComponent<AudioSource>().clip = Button_1;
		GetComponent<AudioSource>().Play();
	}

	public void YeahSound()
	{
		GetComponent<AudioSource>().clip = Yeah;
		GetComponent<AudioSource>().Play();
		Particle();
	}

	public void Particle()
	{
		Parent = GameObject.Find("Parent");
		GameObject gameObject = Object.Instantiate(Particle_Pref);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = Particle_Pref.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	public void particleRepeat()
	{
		Invoke("Particle", 1.2f);
	}

	public void Confirm()
	{
		ButtonSound();
		mybutton.GetComponent<Button>().interactable = false;
		Parent = GameObject.Find("Parent");
		GameObject gameObject = Object.Instantiate(Panel);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = Panel.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		canvas = GameObject.Find("canvas");
		GameObject gameObject2 = Object.Instantiate(WhiteImg);
		gameObject2.transform.SetParent(canvas.transform);
		gameObject2.transform.localPosition = WhiteImg.transform.position;
		gameObject2.transform.localScale = new Vector3(10f, 10f, 10f);
		Object.DestroyImmediate(GameObject.Find("Confetti(Clone)"));
		Invoke("Delay", 2f);
	}

	public void Delay()
	{
		GameObject gameObject = GameObject.Find("ResultImgParent(Clone)");
		if (Item_N == 1)
		{
			GameObject gameObject2 = Object.Instantiate(ResultImg[0]);
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localPosition = gameObject2.transform.position;
			gameObject2.transform.localScale = new Vector3(4f, 4f, 4f);
		}
		if (Item_N == 2)
		{
			GameObject gameObject3 = Object.Instantiate(ResultImg[1]);
			gameObject3.transform.SetParent(gameObject.transform);
			gameObject3.transform.localPosition = gameObject3.transform.position;
			gameObject3.transform.localScale = new Vector3(4f, 4f, 4f);
		}
		if (Item_N == 3)
		{
			GameObject gameObject4 = Object.Instantiate(ResultImg[2]);
			gameObject4.transform.SetParent(gameObject.transform);
			gameObject4.transform.localPosition = gameObject4.transform.position;
			gameObject4.transform.localScale = new Vector3(4f, 4f, 4f);
		}
		if (Item_N == 4)
		{
			GameObject gameObject5 = Object.Instantiate(ResultImg[3]);
			gameObject5.transform.SetParent(gameObject.transform);
			gameObject5.transform.localPosition = gameObject5.transform.position;
			gameObject5.transform.localScale = new Vector3(4f, 4f, 4f);
		}
		if (Item_N == 5)
		{
			GameObject gameObject6 = Object.Instantiate(ResultImg[4]);
			gameObject6.transform.SetParent(gameObject.transform);
			gameObject6.transform.localPosition = gameObject6.transform.position;
			gameObject6.transform.localScale = new Vector3(4f, 4f, 4f);
		}
		GameObject.Find("Main Camera").GetComponent<Rebirth>().Reset();
		Object.Destroy(GameObject.Find("WhiteImg(Clone)"));
		YeahSound();
	}
}
