using UnityEngine;

public class DonCont : MonoBehaviour
{
	private GameObject DonScreen;

	private void Start()
	{
		DonScreen = GameObject.Find("DonScreen");
		FeeCont.SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
	}
}
