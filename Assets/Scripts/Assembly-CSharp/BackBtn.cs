using UnityEngine;
using UnityEngine.UI;

public class BackBtn : MonoBehaviour
{
	public GameObject ThisWindow;

	public GameObject BackButton;

	private GameObject _goabroad;

	private GameObject _buttoncont;

	private GameObject _bossbackbtn;

	private GameObject _feecont;

	private GameObject _reportcont;

	private GameObject _barcont;

	private GameObject _textcont;

	private GameObject OK_Button_specup;

	public TextCont Specup_Textcont;

	private void Start()
	{
		_goabroad = GameObject.Find("GoAbroad/CarCont");
		_buttoncont = GameObject.Find("ButtonController(study)/furnBtn");
		_bossbackbtn = GameObject.Find("BOSSBackbtnManager");
		_feecont = GameObject.Find("FeeCont");
		_reportcont = GameObject.Find("ReportCont");
		_barcont = GameObject.Find("BarController");
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
	}

	public void backbtnclick()
	{
		if (ThisWindow != null)
		{
			if (ThisWindow == GameObject.Find("Gowindow"))
			{
				_goabroad.GetComponent<GoAbroadCont>().ResltwinOnlyClose();
			}
			if (ThisWindow == GameObject.Find("SpecUPResultPanel"))
			{
				OK_Button_specup = GameObject.Find("OK_Button_specup");
				OK_Button_specup.GetComponent<Button>().onClick.Invoke();
			}
			if (ThisWindow == GameObject.Find("SpecUPPanel"))
			{
				TextCont.TextPage = 0;
			}
			if (ThisWindow == GameObject.Find("GameObject"))
			{
				_goabroad.GetComponent<GoAbroadCont>().ResltwinOnlyClose();
			}
			if (ThisWindow == GameObject.Find("SettingWindow"))
			{
				_buttoncont.GetComponent<ButtonCont>().CouponWindow.SetActive(false);
			}
			if (ThisWindow == GameObject.Find("Alert_window(Clone)"))
			{
				Object.Destroy(GameObject.Find("Alert_window(Clone)"));
			}
			if (ThisWindow == GameObject.Find("Smartphone(Clone)"))
			{
				Object.Destroy(GameObject.Find("Smartphone(Clone)"));
			}
			if (ThisWindow == GameObject.Find("Love_getgem(Clone)"))
			{
				Object.Destroy(GameObject.Find("Love_getgem(Clone)"));
			}
			_bossbackbtn.GetComponent<BossBackbtnManager>().Window = null;
			ThisWindow.SetActive(false);
			BackButton.SetActive(false);
		}
	}
}
