using UnityEngine;

public class CloseThis : MonoBehaviour
{
	private GameObject _Barcont;

	private GameObject _talkingtext;

	private GameObject _buttoncont;

	private GameObject _goabroad;

	private GameObject _eventcont;

	private GameObject _textcont;

	private GameObject _timecont;

	private GameObject _report;

	public static bool On_b;

	private GameObject vacaResult;

	private GameObject goabroadResult;

	private GameObject specResult;

	private GameObject report;

	private void Start()
	{
		On_b = true;
		_Barcont = GameObject.Find("BarController");
		_talkingtext = GameObject.Find("talkingbar");
		_buttoncont = GameObject.Find("ButtonController(study)/furnBtn");
		_goabroad = GameObject.Find("GoAbroad/CarCont");
		_eventcont = GameObject.Find("EventController");
		_textcont = GameObject.Find("SpecUPPanel");
		_timecont = GameObject.Find("TimeController");
		_report = GameObject.Find("ReportCont");
	}

	private void FixedUpdate()
	{
		if (base.gameObject.activeInHierarchy && On_b)
		{
			vacaResult = GameObject.Find("Vaca_Result_Panel");
			goabroadResult = GameObject.Find("GameObject");
			specResult = GameObject.Find("SpecUPResultPanel");
			report = GameObject.Find("report");
			On_();
		}
	}

	public void On_()
	{
		if (base.gameObject == vacaResult)
		{
			_Barcont.GetComponent<BarCont>().EventResult();
			_buttoncont.GetComponent<ButtonCont>().VacaResultClose();
		}
		if (base.gameObject == goabroadResult)
		{
			_goabroad.GetComponent<GoAbroadCont>().ResltwinClose();
		}
		if (base.gameObject == specResult)
		{
			if (EventCont.Event_N == 1)
			{
				_timecont.GetComponent<TimeCont>().ToeicEventbutton();
			}
			if (EventCont.Event_N == 2)
			{
				_timecont.GetComponent<TimeCont>().ContestEventbutton();
			}
		}
		if (base.gameObject == report)
		{
			_timecont.GetComponent<TimeCont>().Start();
		}
		On_b = false;
	}

	public void Off_()
	{
	}
}
