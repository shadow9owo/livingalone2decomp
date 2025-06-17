using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
	public TextUP _TextUp;

	public AudioClip Coinsound;

	public static long Clickmoney;

	private bool Fever;

	public GameObject Bakui;

	private int r;

	private bool event_2x_pet;

	public AudioCont AudioCont_;

	public void Start()
	{
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		if (Pet.Pet_N == 22)
		{
			event_2x_pet = true;
		}
		else
		{
			event_2x_pet = false;
		}
		Setmoney();
		r = Random.Range(30, 120);
		Invoke("Setbakui", r);
	}

	public void Setbakui()
	{
		Bakui.GetComponent<RectTransform>().anchoredPosition = new Vector3(455f, Random.Range(216f, -353f), 0f);
		Bakui.GetComponent<Image>().enabled = true;
		Bakui.SetActive(true);
		Invoke("falsebakui", 5f);
		delay();
	}

	public void delay()
	{
		r = Random.Range(30, 120);
		Invoke("Setbakui", r);
	}

	public void falsebakui()
	{
		Bakui.SetActive(false);
	}

	public void Setmoney()
	{
		if (event_2x_pet)
		{
			if (!Fever)
			{
				Clickmoney = 2 * (FurnCont.Bed_N + 1 + (FurnCont.Kitchen_N + 1) + (FurnCont.Toilet_N + 1));
			}
			if (Fever)
			{
				Clickmoney = 20 * (FurnCont.Bed_N + 1 + (FurnCont.Kitchen_N + 1) + (FurnCont.Toilet_N + 1));
			}
		}
		if (!event_2x_pet)
		{
			if (!Fever)
			{
				Clickmoney = FurnCont.Bed_N + 1 + (FurnCont.Kitchen_N + 1) + (FurnCont.Toilet_N + 1);
			}
			if (Fever)
			{
				Clickmoney = 10 * (FurnCont.Bed_N + 1 + (FurnCont.Kitchen_N + 1) + (FurnCont.Toilet_N + 1));
			}
		}
	}

	public void Bakui_fever()
	{
		Fever = true;
		Setmoney();
		Bakui.GetComponent<Button>().interactable = false;
		GameObject gameObject = (GameObject)Resources.Load("fevertime_T");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("fevertime_T"));
		GameObject gameObject3 = GameObject.Find("Bottom_Panel");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(-3f, -371f, 0f);
		gameObject2.transform.localScale = gameObject.transform.localScale;
		GameObject gameObject4 = (GameObject)Resources.Load("Feveranim");
		GameObject gameObject5 = (GameObject)Object.Instantiate(Resources.Load("Feveranim"));
		GameObject gameObject6 = GameObject.Find("R_list");
		gameObject5.transform.SetParent(gameObject6.transform);
		gameObject5.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(348.25f, -80f, 0f);
		gameObject5.transform.localScale = gameObject4.transform.localScale;
		AudioCont_.GetComponent<AudioSource>().pitch = 1.5f;
		Invoke("Feverfinish", 10f);
		Bakui.GetComponent<Image>().enabled = false;
	}

	public void Feverfinish()
	{
		Fever = false;
		Setmoney();
		Bakui.GetComponent<Button>().interactable = true;
		Object.Destroy(GameObject.Find("Feveranim(Clone)"));
		Object.Destroy(GameObject.Find("fevertime_T(Clone)"));
		AudioCont_.GetComponent<AudioSource>().pitch = 1f;
	}

	public void Click()
	{
		scene_controll.money += Clickmoney;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
		GameObject gameObject = (GameObject)Resources.Load("coin");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("coin"));
		GameObject gameObject3 = GameObject.Find("Top_Panel");
		gameObject2.transform.SetParent(gameObject3.transform);
		gameObject2.transform.localPosition = gameObject.transform.localPosition;
		gameObject2.transform.localScale = gameObject.transform.localScale;
		_TextUp.PlusClickMoney();
		Sound();
	}

	public void Sound()
	{
		GetComponent<AudioSource>().clip = Coinsound;
		GetComponent<AudioSource>().Play();
	}
}
