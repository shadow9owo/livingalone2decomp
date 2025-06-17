using UnityEngine;

public class EventPopup : MonoBehaviour
{
	private GameObject ButtonCont_;

	private int Next;

	public static int nomorepop_c;

	private void Start()
	{
		Nomore();
        ButtonCont_ = GameObject.Find("ButtonController(study)/furnBtn");
        ButtonCont_.GetComponent<ButtonCont>().CloseEventWindow();
	}

	public void CloseEventWindow()
	{
		ButtonCont_.GetComponent<ButtonCont>().CloseEventWindow();
	}

	public void BuyButton()
	{
		ButtonCont_.GetComponent<ButtonCont>().GotoCashScreen();
		ButtonCont_.GetComponent<ButtonCont>().CloseEventWindow();
	}

	public void GotoCafe()
	{
		Application.OpenURL("http://ninjaflex.com");
	}

	public void FacebookBtn()
	{
		Application.OpenURL("http://ninjaflex.com");
	}

	public void Nomore()
	{
		PlayerPrefs.SetInt("nomorepop_c", 1);
		nomorepop_c = PlayerPrefs.GetInt("nomorepop_c");
		CloseEventWindow();
	}
}
