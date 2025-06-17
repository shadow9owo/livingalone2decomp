using UnityEngine;
using UnityEngine.UI;

public class s1_1 : MonoBehaviour
{
	public GameObject man_talk;

	public GameObject woman_talk;

	public GameObject ss1_1;

	public GameObject ss1_5;

	public GameObject ss1_2;

	public GameObject man;

	public GameObject woman;

	public GameObject Confrim;

	public GameObject Confirm_Text;

	public string[] defaultname;

	public GameObject Window;

	public GameObject NameScreen;

	public GameObject SexScreen;

	public GameObject[] SexImg_NameScreen;

	public new Text name;

	public GameObject MakeNameScreen;

	public static bool MakeName;

	public void deleteall()
	{
		PlayerPrefs.DeleteAll();
	}

	private void Start()
	{
		defaultname[0] = "Roxy";
		defaultname[1] = "Silky";
		defaultname[2] = "Ariel";
		defaultname[3] = "Dana";
		defaultname[4] = "Tyler";
		defaultname[5] = "Jamie";
		man_talk.SetActive(false);
		woman_talk.SetActive(false);
		Rebirth.NewLife = PlayerPrefs.GetInt("NewLife");
	}

	private void Update()
	{
		if (!Input.GetKeyDown(KeyCode.Escape) && !Input.GetKeyDown(KeyCode.Space))
		{
			return;
		}
		if (Window == null && NameScreen.activeInHierarchy)
		{
			NameScreen.SetActive(false);
			SexScreen.SetActive(true);
			MakeNameScreen.SetActive(false);
			name.text = string.Empty;
			for (int i = 0; i < SexImg_NameScreen.Length; i++)
			{
				SexImg_NameScreen[i].SetActive(false);
			}
		}
		if (Window != null)
		{
			Window.SetActive(false);
			Window = null;
		}
	}

	public void Backbtn()
	{
		if (NameScreen.activeInHierarchy)
		{
			NameScreen.SetActive(false);
			SexScreen.SetActive(true);
			MakeNameScreen.SetActive(false);
			name.text = string.Empty;
			for (int i = 0; i < SexImg_NameScreen.Length; i++)
			{
				SexImg_NameScreen[i].SetActive(false);
			}
		}
	}

	public void man_btn()
	{
		man_talk.SetActive(true);
		woman_talk.SetActive(false);
		Char.Sex = 0;
	}

	public void woman_btn()
	{
		man_talk.SetActive(false);
		woman_talk.SetActive(true);
		Char.Sex = 1;
	}

	public void OpenNameScreen_Man()
	{
		NameScreen.SetActive(true);
		SexScreen.SetActive(false);
		Char.Sex = 0;
		SexImg_NameScreen[0].SetActive(true);
		SexImg_NameScreen[1].SetActive(false);
	}

	public void OpenNameScreen_Woman()
	{
		NameScreen.SetActive(true);
		SexScreen.SetActive(false);
		Char.Sex = 1;
		SexImg_NameScreen[1].SetActive(true);
		SexImg_NameScreen[0].SetActive(false);
	}

	public void Openconfirm()
	{
		Confirm_Text.GetComponent<Text>().text = string.Format("Are you sure you want to {0}?", name.text);
		Confrim.SetActive(true);
	}

	public void Closeconfirm()
	{
		Confrim.SetActive(false);
	}

	public void NameSaveClick()
	{
		string text = name.text;
		if (text == string.Empty)
		{
			MakeNameScreen.SetActive(true);
			MakeName = false;
		}
		if (text != string.Empty)
		{
			Openconfirm();
		}
		Rebirth.NewLife = 0;
		PlayerPrefs.SetInt("NewLife", Rebirth.NewLife);
	}

	public void SaveOK()
	{
		SaveNickname();
		TimeCont.Heart_N = 3;
		PlayerPrefs.SetInt("Heart_N_Q", TimeCont.Heart_N);
		MakeName = true;
	}

	public void No_wanttomakename()
	{
		MakeNameScreen.SetActive(false);
	}

	public void Yes_dontwanttomakename()
	{
		int num = Random.Range(0, defaultname.Length);
		PlayerPrefs.SetString("Nick", defaultname[num]);
		ss1_2.SetActive(true);
		ss1_1.SetActive(false);
		TimeCont.Heart_N = 3;
		PlayerPrefs.SetInt("Heart_N_Q", TimeCont.Heart_N);
		MakeName = true;
	}

	public void MakeNameScreenClose()
	{
		MakeNameScreen.SetActive(false);
	}

	public void SaveNickname()
	{
		PlayerPrefs.SetString("Nick", name.text);
		ss1_2.SetActive(true);
		ss1_1.SetActive(false);
	}
}
