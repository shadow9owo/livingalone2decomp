using UnityEngine;
using UnityEngine.UI;

public class s1_5 : MonoBehaviour
{
	public Transform NicName_T;

	public Transform tuition;

	public GameObject OK_Btn;

	public GameObject train;

	public GameObject train_man;

	public GameObject train_woman;

	public GameObject money;

	private void Start()
	{
		if (Char.Sex == 0)
		{
			train_man.SetActive(true);
			train_woman.SetActive(false);
		}
		if (Char.Sex == 1)
		{
			train_man.SetActive(false);
			train_woman.SetActive(true);
		}
		string text = PlayerPrefs.GetString("Nick");
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		OK_Btn.SetActive(false);
		Invoke("OK_BtnAppear", 8f);
		Invoke("StampAnim", 10f);
	}

	public void OK_BtnAppear()
	{
		OK_Btn.SetActive(true);
	}

	public void StampAnim()
	{
	}

	public void OK_select()
	{
		Invoke("go_new_one", 2f);
		tuition.GetComponent<Text>().text = string.Format("100,000G");
		money.SetActive(true);
		train.SetActive(true);
		PlayerPrefs.SetInt("s1_1", 1);
		PlayerPrefs.SetInt("Grade", 1);
		PlayerPrefs.SetInt("OneSemes", 1);
		PlayerPrefs.SetInt("OneMonth", 3);
		PlayerPrefs.SetFloat("hp", 50f);
		PlayerPrefs.SetFloat("mp", 50f);
		PlayerPrefs.SetFloat("int", 50f);
		PlayerPrefs.SetFloat("happy", 50f);
		PlayerPrefs.SetFloat("st", 100f);
		PlayerPrefs.SetInt("Sex", Char.Sex);
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
		scene_controll.money += 100000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		GameObject.Find("OK_Button").GetComponent<Button>().interactable = false;
	}

	public void go_new_one()
	{
		Application.LoadLevel("newone");
	}
}
