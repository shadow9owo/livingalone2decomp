using UnityEngine;

public class TutorialCont : MonoBehaviour
{
	public static int Tutorial_Int;

	public static int nonsave_tutoint;

	private GameObject Tutorial_obj;

	private GameObject Tutorial_obj_RS;

	public static int Tutoint_event;

	private GameObject Parent;

	public void Awake()
	{
		Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		if (Tutorial_Int == 0)
		{
			Parent = GameObject.Find("tutorial_parent");
			if (Application.loadedLevelName == "newone")
			{
				Settuto_newone();
			}
			if (Application.loadedLevelName == "newone2" || Application.loadedLevelName == "ptj" || Application.loadedLevelName == "ending")
			{
				Settuto_newone2();
			}
		}
		else
		{
			Object.Destroy(GameObject.Find("tutorial_parent"));
			Object.Destroy(GameObject.Find("Top_parent"));
			Object.Destroy(GameObject.Find("Bottom_parent"));
		}
	}

	public void Settuto_newone()
	{
		Tutorial_obj_RS = (GameObject)Resources.Load("Tutorial/Tuto_1");
		Tutorial_obj = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_1"));
		Tutorial_obj.transform.SetParent(Parent.transform);
		Tutorial_obj.transform.localPosition = Tutorial_obj_RS.transform.localPosition;
		Tutorial_obj.transform.localScale = Tutorial_obj_RS.transform.localScale;
	}

	public void Settuto_newone2()
	{
		Tutorial_obj_RS = (GameObject)Resources.Load("Tutorial/Tuto_2");
		Tutorial_obj = (GameObject)Object.Instantiate(Resources.Load("Tutorial/Tuto_2"));
		Tutorial_obj.transform.SetParent(Parent.transform);
		Tutorial_obj.transform.localPosition = Tutorial_obj_RS.transform.localPosition;
		Tutorial_obj.transform.localScale = Tutorial_obj_RS.transform.localScale;
	}
}
