using UnityEngine;

public class s2_1 : MonoBehaviour
{
	public GameObject go_s2_1;

	public GameObject total_money;

	private void Start()
	{
		scene_controll_2.load_num = 0;
		CashCont.Scene_String = "ending";
	}

	public void btn_realending()
	{
		scene_controll_2.load_num = 0;
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
		PlayerPrefs.SetInt("Circle_gradu", 0);
		PlayerPrefs.SetInt("Circle_main", 0);
		GameObject.Find("dms").GetComponent<EndingBtnCont>().Setcircle();
	}

	public void btn_sadending()
	{
		scene_controll_2.load_num = 0;
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject.Find("Tuto_2(Clone)").GetComponent<Tuto_1>().NEXT();
		}
		PlayerPrefs.SetInt("Circle_frust", 0);
		PlayerPrefs.SetInt("Circle_main", 0);
		GameObject.Find("dms").GetComponent<EndingBtnCont>().Setcircle();
	}
}
