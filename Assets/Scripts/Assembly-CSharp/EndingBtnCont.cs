using UnityEngine;
using UnityEngine.UI;

public class EndingBtnCont : MonoBehaviour
{
	public GameObject EndingMain;

	public GameObject SuddenDeathScreen;

	public GameObject GraduScreen;

	public GameObject cashbtn;

	public Transform Money;

	public Transform gem_text;

	public GameObject redcircle_gradu;

	public GameObject redcircle_frust;

	public GameObject MoneyWindow;

	private void Start()
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
		if (TutorialCont.Tutorial_Int == 0)
		{
			cashbtn.GetComponent<Button>().interactable = false;
		}
		else
		{
			cashbtn.GetComponent<Button>().interactable = true;
		}
		Setcircle();
		Momeysetting();
		if (scene_controll.money < FeeCont.MonthHouse)
		{
			MoneyWindow.GetComponent<Image>().color = Color.red;
		}
		else
		{
			MoneyWindow.GetComponent<Image>().color = Color.white;
		}
	}

	public void Setcircle()
	{
		SuddenDeathCont.Circle_gradu = PlayerPrefs.GetInt("Circle_gradu");
		SuddenDeathCont.Circle_frust = PlayerPrefs.GetInt("Circle_frust");
		if (SuddenDeathCont.Circle_gradu == 1)
		{
			redcircle_gradu.SetActive(true);
		}
		if (SuddenDeathCont.Circle_gradu == 0)
		{
			redcircle_gradu.SetActive(false);
		}
		if (SuddenDeathCont.Circle_frust == 1)
		{
			redcircle_frust.SetActive(true);
		}
		if (SuddenDeathCont.Circle_frust == 0)
		{
			redcircle_frust.SetActive(false);
		}
	}

	public void FixedUpdate()
	{
		if (TutorialCont.Tutorial_Int == 1 && EndingMain.activeInHierarchy && !SuddenDeathScreen.activeInHierarchy && !GraduScreen.activeInHierarchy && (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space)))
		{
			Application.LoadLevel("newone");
		}
	}

	public void Momeysetting()
	{
		if (scene_controll.money <= 0)
		{
			scene_controll.money = 0L;
		}
		Money.GetComponent<Text>().text = string.Format("{0:n0}G", scene_controll.money);
		gem_text.GetComponent<Text>().text = string.Format("{0:n0}", scene_controll.gem);
	}

	public void Goback()
	{
		if (EndingMain.activeInHierarchy)
		{
			Application.LoadLevel("newone");
		}
		else
		{
			EndingMain.SetActive(true);
			GraduScreen.SetActive(false);
			SuddenDeathScreen.SetActive(false);
		}
		if (TutorialCont.Tutorial_Int == 0)
		{
			if (Tuto_1.Tutorial_Scene == 29)
			{
				GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
			}
			if (Tuto_1.Tutorial_Scene == 31)
			{
				GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
			}
			Debug.Log("Tuto_1.Tutorial_Scene=" + Tuto_1.Tutorial_Scene);
		}
	}

	public void OpenSuddenDeathScreen()
	{
		EndingMain.SetActive(false);
		SuddenDeathScreen.SetActive(true);
	}

	public void OpenGraduateScreen()
	{
		EndingMain.SetActive(false);
		GraduScreen.SetActive(true);
	}

	public void EndingMainScreen()
	{
		EndingMain.SetActive(true);
		SuddenDeathScreen.SetActive(false);
		GraduScreen.SetActive(false);
	}

	public void CashScreenOn()
	{
		Application.LoadLevel("Cashshop");
	}
}
