using UnityEngine;

public class RoomCont : MonoBehaviour
{
	public Char _Char;

	public static int Room_N;

	private GameObject room_parent;

	private GameObject ROOM_pet_man_parent;

	private Transform Prefabs_BG;

	private Transform Prefabs_ect;

	private Transform BackImage;

	private Transform BackImage2;

	public GameObject PET;

	public void Awake()
	{
		Room_N = PlayerPrefs.GetInt("Room_N");
	}

	public void Start()
	{
		if (Room_N == 0)
		{
			Room_N = 1;
		}
		RoomCheck();
		PetOnOFF();
		SetBGImage();
	}

	public void SetBGImage()
	{
		if (Room_N == 1)
		{
			Prefabs_BG = Resources.Load<Transform>("Room1_BG");
		}
		if (Room_N == 2)
		{
			Prefabs_BG = Resources.Load<Transform>("Room2_BG");
		}
		if (Room_N == 3)
		{
			Prefabs_BG = Resources.Load<Transform>("Room3_BG");
		}
		if (Room_N == 4)
		{
			Prefabs_BG = Resources.Load<Transform>("Room4_BG");
		}
		if (Room_N == 5)
		{
			Prefabs_BG = Resources.Load<Transform>("Room5_BG");
		}
		if (Room_N == 6)
		{
			Prefabs_BG = Resources.Load<Transform>("Room6_BG");
		}
		if (Room_N == 7)
		{
			Prefabs_BG = Resources.Load<Transform>("Room7_BG");
		}
		if (Room_N == 8)
		{
			Prefabs_BG = Resources.Load<Transform>("Room8_BG");
		}
		if (Room_N == 9)
		{
			Prefabs_BG = Resources.Load<Transform>("Room9_BG");
		}
		if (Room_N == 10)
		{
			Prefabs_BG = Resources.Load<Transform>("Room10_BG");
		}
		if (Room_N == 11)
		{
			Prefabs_BG = Resources.Load<Transform>("Room11_BG");
		}
		if (Room_N == 12)
		{
			Prefabs_BG = Resources.Load<Transform>("Room12_BG");
		}
		if (Room_N == 13)
		{
			Prefabs_BG = Resources.Load<Transform>("Room13_BG");
		}
		if (Room_N == 14)
		{
			Prefabs_BG = Resources.Load<Transform>("Room14_BG");
		}
		if (Room_N == 15)
		{
			Prefabs_BG = Resources.Load<Transform>("Room15_BG");
		}
		if (Room_N == 16)
		{
			Prefabs_BG = Resources.Load<Transform>("Room16_BG");
		}
		if (Room_N == 17)
		{
			Prefabs_BG = Resources.Load<Transform>("Room17_BG");
		}
		BackImage = Object.Instantiate(Prefabs_BG);
		room_parent = GameObject.Find("room_parent");
		room_parent.transform.localPosition = new Vector3(0f, 0f, 0f);
		BackImage.transform.SetParent(room_parent.transform);
		BackImage.transform.localPosition = Prefabs_BG.transform.localPosition;
		BackImage.transform.localScale = new Vector3(1f, 1f, 1f);
		if (Room_N == 17)
		{
			Prefabs_ect = Resources.Load<Transform>("tree_room17");
			BackImage2 = Object.Instantiate(Prefabs_ect);
			ROOM_pet_man_parent = GameObject.Find("room17_ect_p");
			ROOM_pet_man_parent.transform.localPosition = new Vector3(0f, 0f, 0f);
			BackImage2.transform.SetParent(ROOM_pet_man_parent.transform);
			BackImage2.transform.localPosition = Prefabs_ect.transform.localPosition;
			BackImage2.transform.localScale = new Vector3(4.2f, 4.2f, 1f);
		}
	}

	public void RoomCheck()
	{
		_Char.SetPosition();
		PlayerPrefs.SetInt("Room_N", Room_N);
	}

	public void PetOnOFF()
	{
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		if (s3_7.PetBuyOK == 0)
		{
			PET.SetActive(false);
			Pet.Pet_N = 100;
			PlayerPrefs.SetInt("Pet_N", Pet.Pet_N);
			PlayerPrefs.SetInt("PetBuyOK", s3_7.PetBuyOK);
		}
		else
		{
			PET.SetActive(true);
		}
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
	}

	public void RoomnubSetting13()
	{
		PlayerPrefs.SetInt("Room_N", 13);
		Room_N = PlayerPrefs.GetInt("Room_N");
	}

	public void RoomnubSetting14()
	{
		PlayerPrefs.SetInt("Room_N", 14);
		Room_N = PlayerPrefs.GetInt("Room_N");
	}

	public void RoomnubSetting15()
	{
		PlayerPrefs.SetInt("Room_N", 15);
		Room_N = PlayerPrefs.GetInt("Room_N");
	}
}
