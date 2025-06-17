using TapjoyUnity;
using UnityEngine;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
	public GameObject tap;

	public GameObject black_panel;

	private GameObject _EventParticle2;

	public GameObject ParticleParent2;

	public GameObject EventParticle2;

	public AudioClip click;

	public Image[] img_load;

	public Sprite[] sprite;

	public Sprite[] sprite2;

	private int ran;

	public GameObject ci;

	public GameObject title;

	public int StartConfirm;

	public void Awake()
	{
		if (Application.platform == RuntimePlatform.Android)
		{
            Screen.SetResolution(Screen.width, Screen.width * 16 / 9, true);
        }else
		{
            Screen.SetResolution(Screen.width, Screen.width * 16 / 9, false);
        }
			StartConfirm = PlayerPrefs.GetInt("s1_1");
		sprite = Resources.LoadAll<Sprite>("logo");
		sprite2 = Resources.LoadAll<Sprite>("talkboxx2");
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		try
		{
            img_load[0].sprite = Resources.Load<Sprite>("house_2");
            img_load[1].sprite = Resources.Load<Sprite>("logo_2");
            img_load[2].sprite = sprite2[6];
            img_load[3].sprite = sprite2[8];
            img_load[4].sprite = sprite2[5];
            img_load[5].sprite = sprite2[7];
            img_load[6].sprite = sprite2[10];
        }catch { }
		if (TutorialCont.Tutorial_Int == 1)
		{
			PlayerPrefs.SetInt("Tutoint_event", 0);
		}
	}

	public void Delete()
	{
		PlayerPrefs.DeleteAll();
	}

	private void Start()
	{
		ci.SetActive(true);
		title.SetActive(false);
		Ads_Admob.no_ad = SPrefs.GetInt("no_ad");
		if (Ads_Admob.no_ad == 0)
		{

		}
		Debug.Log("no_ad" + Ads_Admob.no_ad);
		Social.localUser.Authenticate(delegate(bool success)
		{
			if (success)
			{
				Debug.Log("You've successfully logged in");
			}
			else
			{
				Debug.Log("Login failed for some reason");
			}
		});
		if (!Tapjoy.IsConnected)
		{
			Tapjoy.Connect();
		}
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		AudioCont.Mute_b = PlayerPrefs.GetInt("Mute_b");
		PlayerPrefs.SetInt("Mute_b", AudioCont.Mute_b);
		if (AudioCont.Mute_b == 1)
		{
			AudioListener.volume = 0f;
		}
		if (AudioCont.Mute_b == 2)
		{
			AudioListener.volume = 1f;
		}
		Rebirth.NewLife = PlayerPrefs.GetInt("NewLife");
		Invoke("Settitle", 4f);
	}

	public void Settitle()
	{
		GameObject.Find("Canvas").GetComponent<AudioSource>().Play();
		ci.SetActive(false);
		title.SetActive(true);
		Invoke("tap_start", 1f);
		ParticleParent2.GetComponent<Button>().interactable = false;
	}

	public void tap_start()
	{
		tap.SetActive(true);
		Invoke("ButtonOK", 1f);
	}

	public void ButtonOK()
	{
		ParticleParent2.GetComponent<Button>().interactable = true;
	}

	public void real_start()
	{
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		if (scene_controll.money_Text != null)
		{
			if (scene_controll.money_Text.Length == 0)
			{
				scene_controll.money = 0L;
			}
			else
			{
				scene_controll.money = long.Parse(scene_controll.money_Text);
			}
			scene_controll.money_Text = scene_controll.money.ToString();
		}
		else
		{
			scene_controll.money = 0L;
		}
		scene_controll.gem = SPrefs.GetInt("gem2");
		black_panel.SetActive(true);
		GetComponent<AudioSource>().clip = click;
		GetComponent<AudioSource>().Play();
		if (TutorialCont.Tutorial_Int == 0)
		{
			PlayerPrefs.SetInt("Lv1_living", 0);
			s3_7.Lv1_living = PlayerPrefs.GetInt("Lv1_living");
			PlayerPrefs.SetInt("Lv1_bed", 0);
			s3_7.Lv1_bed = PlayerPrefs.GetInt("Lv1_bed");
			PlayerPrefs.SetInt("Lv1_toilet", 0);
			s3_7.Lv1_toilet = PlayerPrefs.GetInt("Lv1_toilet");
			PlayerPrefs.SetInt("pet_0", 0);
			PlayerPrefs.SetInt("PetBuyOK", 0);
			PlayerPrefs.SetInt("Bed_N", 0);
			PlayerPrefs.SetInt("Toilet_N", 0);
			PlayerPrefs.SetInt("Kitchen_N", 0);
			PlayerPrefs.SetInt("bed_num[0]", 0);
			PlayerPrefs.SetInt("living_num[0]", 0);
			PlayerPrefs.SetInt("toilet_num[0]", 0);
			PlayerPrefs.SetInt("bed_num[1]", 0);
			PlayerPrefs.SetInt("living_num[1]", 0);
			PlayerPrefs.SetInt("toilet_num[1]", 0);
			PlayerPrefs.SetInt("bed_num[2]", 0);
			PlayerPrefs.SetInt("living_num[2]", 0);
			PlayerPrefs.SetInt("toilet_num[2]", 0);
			scene_controll.money_Text = scene_controll.money.ToString();
			SPrefs.SetString("final_money2", "100000");
			scene_controll.money_Text = SPrefs.GetString("final_money2");
			PlayerPrefs.Save();
			SPrefs.Save();
			PlayerPrefs.SetFloat("st", 100f);
			PlayerPrefs.SetFloat("hp", 50f);
			PlayerPrefs.SetFloat("mp", 50f);
			PlayerPrefs.SetFloat("int", 50f);
			PlayerPrefs.SetFloat("happy", 50f);
			PlayerPrefs.SetInt("S_class", 0);
			PlayerPrefs.SetInt("Y_class", 0);
			PlayerPrefs.SetInt("M_class", 0);
			PlayerPrefs.SetInt("E_class", 0);
			PlayerPrefs.SetFloat("point", 0f);
			PlayerPrefs.SetFloat("Alba_exp[0]", 0f);
			PlayerPrefs.SetInt("M_Pet", 0);
			PlayerPrefs.SetInt("M_Alba", 0);
			PlayerPrefs.SetInt("M_Study", 0);
			if (TutorialCont.Tutorial_Int == 0)
			{
				PlayerPrefs.SetFloat("Alba_Lv[0]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[1]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[2]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[3]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[4]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[5]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[6]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[7]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[8]", 1f);
				PlayerPrefs.SetFloat("Alba_Lv[9]", 1f);
				PlayerPrefs.SetInt("Goal_Clothes", 1);
				PlayerPrefs.SetInt("M_Clothes", 10000);
				PlayerPrefs.SetInt("Goal_Hair", 1);
				PlayerPrefs.SetInt("M_Hair", 10000);
				PlayerPrefs.SetInt("Goal_Pet", 1);
				PlayerPrefs.SetInt("M_Pet", 5000);
				PlayerPrefs.SetInt("Goal_Car", 1);
				PlayerPrefs.SetInt("M_Car", 1000000);
				PlayerPrefs.SetInt("Goal_Friend", 10);
				PlayerPrefs.SetInt("M_Friend", 10000);
				PlayerPrefs.SetInt("Goal_Spec", 5);
				PlayerPrefs.SetInt("M_Spec", 10000);
				PlayerPrefs.SetInt("Goal_Buff", 5);
				PlayerPrefs.SetInt("M_Buff", 10000);
				PlayerPrefs.SetInt("Goal_Study", 4);
				PlayerPrefs.SetInt("M_Study", 50000);
				PlayerPrefs.SetInt("Goal_Alba", 4);
				PlayerPrefs.SetInt("M_Alba", 50000);
			}
		}
		Invoke("GoScene", 2f);
	}

	public void GoScene()
	{
		Resources.UnloadUnusedAssets();
		if (StartConfirm == 0)
		{
			Application.LoadLevel("char_select");
		}
		if (StartConfirm == 1)
		{
			if (Rebirth.NewLife == 1)
			{
				Application.LoadLevel("char_select");
			}
			else
			{
				Application.LoadLevel("newone");
			}
		}
	}
}
