using UnityEngine;

public class ResetRoomPrefab : MonoBehaviour
{
	public int[] bed_num;

	public int[] living_num;

	public int[] toilet_num;

	private void Start()
	{
		bed_num[0] = PlayerPrefs.GetInt("bed_num[0]");
		bed_num[1] = PlayerPrefs.GetInt("bed_num[1]");
		bed_num[2] = PlayerPrefs.GetInt("bed_num[2]");
		living_num[0] = PlayerPrefs.GetInt("living_num[0]");
		living_num[1] = PlayerPrefs.GetInt("living_num[1]");
		living_num[2] = PlayerPrefs.GetInt("living_num[2]");
		toilet_num[0] = PlayerPrefs.GetInt("toilet_num[0]");
		toilet_num[1] = PlayerPrefs.GetInt("toilet_num[1]");
		toilet_num[2] = PlayerPrefs.GetInt("toilet_num[2]");
	}

	public void SetRoom_1()
	{
		PlayerPrefs.SetInt("Room_N", 1);
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		PlayerPrefs.SetInt("Toilet_N", 0);
		PlayerPrefs.SetInt("Kitchen_N", 0);
		PlayerPrefs.SetInt("Bed_N", 0);
		FurnCont.Bed_N = PlayerPrefs.GetInt("Bed_N");
		FurnCont.Toilet_N = PlayerPrefs.GetInt("Toilet_N");
		FurnCont.Kitchen_N = PlayerPrefs.GetInt("Kitchen_N");
		PlayerPrefs.SetInt("Lv1_bed", 1);
		PlayerPrefs.SetInt("Lv1_toilet", 1);
		PlayerPrefs.SetInt("Lv1_living", 1);
		s3_7.Lv1_bed = PlayerPrefs.GetInt("Lv1_bed");
		s3_7.Lv1_toilet = PlayerPrefs.GetInt("Lv1_toilet");
		s3_7.Lv1_living = PlayerPrefs.GetInt("Lv1_living");
		GameObject.Find("RoomController/Pet").GetComponent<RoomCont>().Start();
		GameObject.Find("FurnitureController").GetComponent<FurnCont>().Destoryfurn();
		GameObject.Find("FurnitureController").GetComponent<FurnCont>().Start();
		GameObject.Find("SettingWindow").SetActive(false);
		GameObject.Find("BackBtn_Child").SetActive(false);
		bed_num[0] = 0;
		bed_num[1] = 0;
		bed_num[2] = 0;
		living_num[0] = 0;
		living_num[1] = 0;
		living_num[2] = 0;
		toilet_num[0] = 0;
		toilet_num[1] = 0;
		toilet_num[2] = 0;
		PlayerPrefs.SetInt("bed_num[0]", bed_num[0]);
		PlayerPrefs.SetInt("bed_num[1]", bed_num[1]);
		PlayerPrefs.SetInt("bed_num[2]", bed_num[2]);
		PlayerPrefs.SetInt("living_num[0]", living_num[0]);
		PlayerPrefs.SetInt("living_num[1]", living_num[1]);
		PlayerPrefs.SetInt("living_num[2]", living_num[2]);
		PlayerPrefs.SetInt("toilet_num[0]", toilet_num[0]);
		PlayerPrefs.SetInt("toilet_num[1]", toilet_num[1]);
		PlayerPrefs.SetInt("toilet_num[2]", toilet_num[2]);
		GameObject.Find("Char").GetComponent<Char>().Start();
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		if (s3_7.PetBuyOK == 1)
		{
			GameObject.Find("Pet").GetComponent<PetPosition>().SetPosition();
		}
		No();
	}

	public void No()
	{
		Object.Destroy(base.gameObject);
	}
}
