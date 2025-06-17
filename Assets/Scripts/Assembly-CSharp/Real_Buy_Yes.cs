using UnityEngine;

public class Real_Buy_Yes : MonoBehaviour
{
	public GameObject RoomSHOP;

	public GameObject FurnSHOP;

	public GameObject ClotheSHOP;

	public GameObject HairSHOP;

	public GameObject s3_7_obj;

	public GameObject CarSHOP;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void btn_real_buy_yes()
	{
		scene_controll.money -= s3_7.price;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		PlayerPrefs.Save();
		if (RoomSHOP.activeInHierarchy)
		{
			s3_7.RoomBuyOK++;
			PlayerPrefs.SetInt("RoomBuyOK", s3_7.RoomBuyOK);
		}
		if (FurnSHOP.activeInHierarchy)
		{
			s3_7.FurnBuyOK++;
			PlayerPrefs.SetInt("FurnBuyOK", s3_7.FurnBuyOK);
		}
		if (ClotheSHOP.activeInHierarchy)
		{
			s3_7.ClotheBuyOK++;
			PlayerPrefs.SetInt("ClotheBuyOK", s3_7.ClotheBuyOK);
		}
		if (HairSHOP.activeInHierarchy)
		{
			s3_7.HairBuyOK++;
			PlayerPrefs.SetInt("HairBuyOK", s3_7.HairBuyOK);
			s3_7.HairBUY_B = 2;
		}
		if (s3_7_obj.activeInHierarchy)
		{
			s3_7.PetBuyOK = 1;
			PlayerPrefs.SetInt("PetBuyOK", s3_7.PetBuyOK);
			s3_7.HowmanyPETOK++;
			PlayerPrefs.SetInt("HowmanyPETOK", s3_7.HowmanyPETOK);
			s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		}
		if (CarSHOP.activeInHierarchy)
		{
			s3_7.CarBuyOK++;
			PlayerPrefs.SetInt("CarBuyOK", s3_7.CarBuyOK);
		}
	}
}
