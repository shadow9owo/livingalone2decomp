using UnityEngine;
using UnityEngine.UI;

public class BossBackbtnManager : MonoBehaviour
{
	public GameObject Window;

	public GameObject QuiteReally;

	public GameObject endingmain;

	public GameObject ThisParent;

	public GameObject _buttoncont;

	public GameObject _goabroad;

	public GameObject _feecont;

	public GameObject _suddendeath;

	public GameObject _audiocont;

	public GameObject _reportcont;

	public GameObject _timecont;

	public GameObject _admob;

	public GameObject _graducont;

	public GameObject _s4_2;

	public GameObject _studycont;

	public GameObject _backbtn;

	private void Awake()
	{
		_buttoncont = GameObject.Find("ButtonController(study)/furnBtn");
		_goabroad = GameObject.Find("GoAbroad/CarCont");
		_feecont = GameObject.Find("FeeCont");
		_suddendeath = GameObject.Find("SuddenDeathCont");
		_audiocont = GameObject.Find("AudioCont");
		_reportcont = GameObject.Find("ReportCont");
		_timecont = GameObject.Find("TimeController");
		_admob = GameObject.Find("AdmobCont");
		_graducont = GameObject.Find("GraduateController");
		_backbtn = GameObject.Find("BackBtn");
	}

	private void Update()
	{
		if (TutorialCont.Tutorial_Int != 1 || (!Input.GetKeyDown(KeyCode.Escape) && !Input.GetKeyDown(KeyCode.Space)))
		{
			return;
		}
		Debug.Log("getkeydonw");
		CloseThis.On_b = true;
		if (Window == null && Application.loadedLevelName == "newone")
		{
			QuiteReally.SetActive(true);
		}
		else
		{
			if (!(Window != null))
			{
				return;
			}
			if (TutorialCont.Tutorial_Int == 1)
			{
				if (Window == GameObject.Find("Gowindow"))
				{
					_goabroad.GetComponent<GoAbroadCont>().ResltwinOnlyClose();
					return;
				}
				if (Window == GameObject.Find("GameObject"))
				{
					_goabroad.GetComponent<GoAbroadCont>().ResltwinOnlyClose();
					return;
				}
				if (Window == GameObject.Find("SpecUPPanel"))
				{
					TextCont.TextPage = 0;
				}
				if (Window == GameObject.Find("SpecUPResultPanel"))
				{
					_buttoncont.GetComponent<ButtonCont>().CloesSpceUp();
					return;
				}
				if (Window == GameObject.Find("suddenyellopanel"))
				{
					Debug.Log("suddne");
					_suddendeath.GetComponent<SuddenDeathCont>().AdsBtn();
					_suddendeath.GetComponent<SuddenDeathCont>().SavaDehat_Num();
					_audiocont.GetComponent<AudioCont>().Start();
					_timecont.GetComponent<TimeCont>().Start();
				}
				if (Window == GameObject.Find("reportScreen"))
				{
					_reportcont.GetComponent<ReportCont>().AllscreenExit();
					return;
				}
				if (Window == GameObject.Find("yellopanel (1)"))
				{
					_graducont.GetComponent<GraduateCont>().CloseScene();
					return;
				}
				if (Window == GameObject.Find("Alert_window(Clone)"))
				{
					Object.Destroy(GameObject.Find("Alert_window(Clone)"));
				}
				if (Window == GameObject.Find("Love_getgem(Clone)"))
				{
					Object.Destroy(GameObject.Find("Love_getgem(Clone)"));
				}
				if (Window == GameObject.Find("Smartphone(Clone)"))
				{
					Object.Destroy(GameObject.Find("Smartphone(Clone)"));
				}
				if (Window == GameObject.Find("eventPopup(Clone)"))
				{
					_buttoncont.GetComponent<ButtonCont>().CloseEventWindow();
					Object.Destroy(GameObject.Find("eventPopup(Clone)"));
				}
				if (Window == GameObject.Find("2-1"))
				{
					Application.LoadLevel("newone");
					Debug.Log("main");
					return;
				}
				if (Window == GameObject.Find("2-2"))
				{
					if (Window != null)
					{
						endingmain.SetActive(true);
						Window.SetActive(false);
					}
					return;
				}
				if (Window == GameObject.Find("2_3"))
				{
					if (Window != null)
					{
						endingmain.SetActive(true);
						Window.SetActive(false);
					}
					return;
				}
				if (Window == GameObject.Find("2-4"))
				{
					Application.LoadLevel("newone");
					return;
				}
				if (Window == GameObject.Find("panel_result"))
				{
					if (Window != null)
					{
						GameObject gameObject = GameObject.Find("ExitButton");
						gameObject.GetComponent<Button>().onClick.Invoke();
					}
					return;
				}
				if (Window == GameObject.Find("st_result_panel"))
				{
					if (Window != null)
					{
						_s4_2 = GameObject.Find("4-2");
						_studycont = GameObject.Find("dms");
					}
					return;
				}
				if (Window == GameObject.Find("exam_result_panel (1)"))
				{
					if (Window != null)
					{
						_s4_2 = GameObject.Find("4-2");
						_studycont = GameObject.Find("dms");
					}
					return;
				}
				if (Window != GameObject.Find("2-1") && Window != GameObject.Find("2-4") && Window != GameObject.Find("Gowindow"))
				{
					Window.SetActive(false);
					Window = null;
					if (Application.loadedLevelName == "newone")
					{
						_backbtn.GetComponent<BackBtn>().backbtnclick();
					}
					return;
				}
				Debug.Log("WINDOWCLOSE");
			}
			if (Application.loadedLevelName == "newone")
			{
				_backbtn.GetComponent<BackBtn>().backbtnclick();
			}
		}
	}
}
