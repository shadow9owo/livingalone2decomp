using UnityEngine;
using UnityEngine.UI;

public class nomoreads : MonoBehaviour
{
	public void Start()
	{
		if (Application.loadedLevelName == "Cashshop")
		{
			SexAsk();
		}
	}

	public void SexAsk()
	{
		Char.Sex = PlayerPrefs.GetInt("Sex");
		GameObject gameObject = GameObject.Find("Alert_sex_Text");
		if (Char.Sex == 0)
		{
			gameObject.GetComponent<Text>().text = string.Format("Your gender is male. Do you want to buy?");
		}
		if (Char.Sex == 1)
		{
			gameObject.GetComponent<Text>().text = string.Format("Your gender is female. Do you want to buy?");
		}
	}

	public void Yes_buy()
	{
		if (CashCont.select_clothes_sex == 1)
		{
			GameObject.Find("Canvas").GetComponent<CashCont>().Limit_clothes_m();
		}
		if (CashCont.select_clothes_sex == 2)
		{
			GameObject.Find("Canvas").GetComponent<CashCont>().Limit_clothes_w();
		}
		Delete();
	}

	public void Delete()
	{
		Object.Destroy(base.gameObject);
	}
}
