using UnityEngine;

public class FurnCont : MonoBehaviour
{
	public static int Toilet_N;

	public static int Kitchen_N;

	public static int Bed_N;

	public static int FirstFurn;

	private GameObject Roomparent;

	private GameObject bed_;

	private GameObject bed_Resource;

	private GameObject kitchen_;

	private GameObject kitchen_Resource;

	private GameObject toilet_;

	private GameObject toilet_Resource;

	public void Awake()
	{
		FirstFurn = PlayerPrefs.GetInt("FirstFurn");
		Bed_N = PlayerPrefs.GetInt("Bed_N");
		Toilet_N = PlayerPrefs.GetInt("Toilet_N");
		Kitchen_N = PlayerPrefs.GetInt("Kitchen_N");
		PlayerPrefs.SetInt("Toilet_N", Toilet_N);
		PlayerPrefs.SetInt("Kitchen_N", Kitchen_N);
		PlayerPrefs.SetInt("Bed_N", Bed_N);
		s3_7.Lv1_bed = PlayerPrefs.GetInt("Lv1_bed");
		s3_7.Lv1_toilet = PlayerPrefs.GetInt("Lv1_toilet");
		s3_7.Lv1_living = PlayerPrefs.GetInt("Lv1_living");
	}

	public void Start()
	{
		Roomparent = GameObject.Find("Room");
		SetFirstfurn();
	}

	public void Destoryfurn()
	{
		Object.Destroy(bed_);
		Object.Destroy(kitchen_);
		Object.Destroy(toilet_);
	}

	public void SetFirstfurn()
	{
		if (RoomCont.Room_N == 1)
		{
			if (s3_7.Lv1_bed == 1 && Bed_N == 0)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room1/Bed_1_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Bed_1_1"));
			}
			if (Bed_N == 1)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room1/Bed_1_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Bed_1_2"));
			}
			if (Bed_N == 2)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room1/Bed_1_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Bed_1_3"));
			}
			if (s3_7.Lv1_living == 1 && Kitchen_N == 0)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room1/Kitchen_1_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Kitchen_1_1"));
			}
			if (Kitchen_N == 1)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room1/Kitchen_1_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Kitchen_1_2"));
			}
			if (Kitchen_N == 2)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room1/Kitchen_1_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Kitchen_1_3"));
			}
			if (s3_7.Lv1_toilet == 1 && Toilet_N == 0)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room1/Toilet_1_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Toilet_1_1"));
			}
			if (Toilet_N == 1)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room1/Toilet_1_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Toilet_1_2"));
			}
			if (Toilet_N == 2)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room1/Toilet_1_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room1/Toilet_1_3"));
			}
		}
		if (RoomCont.Room_N == 2)
		{
			if (Bed_N == 2)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room2/Bed_2_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Bed_2_1"));
			}
			if (Bed_N == 3)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room2/Bed_2_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Bed_2_2"));
			}
			if (Bed_N == 4)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room2/Bed_2_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Bed_2_3"));
			}
			if (Bed_N == 5)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room2/Bed_2_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Bed_2_4"));
			}
			if (Kitchen_N == 2)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room2/Kitchen_2_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Kitchen_2_1"));
			}
			if (Kitchen_N == 3)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room2/Kitchen_2_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Kitchen_2_2"));
			}
			if (Kitchen_N == 4)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room2/Kitchen_2_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Kitchen_2_3"));
			}
			if (Kitchen_N == 5)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room2/Kitchen_2_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Kitchen_2_4"));
			}
			if (Toilet_N == 2)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room2/Toilet_2_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Toilet_2_1"));
			}
			if (Toilet_N == 3)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room2/Toilet_2_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Toilet_2_2"));
			}
			if (Toilet_N == 4)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room2/Toilet_2_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Toilet_2_3"));
			}
			if (Toilet_N == 5)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room2/Toilet_2_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room2/Toilet_2_4"));
			}
		}
		if (RoomCont.Room_N == 3)
		{
			if (Bed_N == 5)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room3/Bed_3_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Bed_3_1"));
			}
			if (Bed_N == 6)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room3/Bed_3_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Bed_3_2"));
			}
			if (Bed_N == 7)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room3/Bed_3_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Bed_3_3"));
			}
			if (Bed_N == 8)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room3/Bed_3_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Bed_3_4"));
			}
			if (Kitchen_N == 5)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room3/Kitchen_3_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Kitchen_3_1"));
			}
			if (Kitchen_N == 6)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room3/Kitchen_3_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Kitchen_3_2"));
			}
			if (Kitchen_N == 7)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room3/Kitchen_3_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Kitchen_3_3"));
			}
			if (Kitchen_N == 8)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room3/Kitchen_3_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Kitchen_3_4"));
			}
			if (Toilet_N == 5)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room3/Toilet_3_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Toilet_3_1"));
			}
			if (Toilet_N == 6)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room3/Toilet_3_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Toilet_3_2"));
			}
			if (Toilet_N == 7)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room3/Toilet_3_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Toilet_3_3"));
			}
			if (Toilet_N == 8)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room3/Toilet_3_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room3/Toilet_3_4"));
			}
		}
		if (RoomCont.Room_N == 4)
		{
			if (Bed_N == 8)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room4/Bed_4_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Bed_4_1"));
			}
			if (Bed_N == 9)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room4/Bed_4_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Bed_4_2"));
			}
			if (Bed_N == 10)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room4/Bed_4_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Bed_4_3"));
			}
			if (Bed_N == 11)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room4/Bed_4_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Bed_4_4"));
			}
			if (Kitchen_N == 8)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room4/Kitchen_4_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Kitchen_4_1"));
			}
			if (Kitchen_N == 9)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room4/Kitchen_4_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Kitchen_4_2"));
			}
			if (Kitchen_N == 10)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room4/Kitchen_4_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Kitchen_4_3"));
			}
			if (Kitchen_N == 11)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room4/Kitchen_4_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Kitchen_4_4"));
			}
			if (Toilet_N == 8)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room4/Toilet_4_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Toilet_4_1"));
			}
			if (Toilet_N == 9)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room4/Toilet_4_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Toilet_4_2"));
			}
			if (Toilet_N == 10)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room4/Toilet_4_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Toilet_4_3"));
			}
			if (Toilet_N == 11)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room4/Toilet_4_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room4/Toilet_4_4"));
			}
		}
		if (RoomCont.Room_N == 5)
		{
			if (Bed_N == 11)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room5/Bed_5_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Bed_5_1"));
			}
			if (Bed_N == 12)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room5/Bed_5_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Bed_5_2"));
			}
			if (Bed_N == 13)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room5/Bed_5_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Bed_5_3"));
			}
			if (Bed_N == 14)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room5/Bed_5_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Bed_5_4"));
			}
			if (Kitchen_N == 11)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room5/Kitchen_5_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Kitchen_5_1"));
			}
			if (Kitchen_N == 12)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room5/Kitchen_5_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Kitchen_5_2"));
			}
			if (Kitchen_N == 13)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room5/Kitchen_5_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Kitchen_5_3"));
			}
			if (Kitchen_N == 14)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room5/Kitchen_5_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Kitchen_5_4"));
			}
			if (Toilet_N == 11)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room5/Toilet_5_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Toilet_5_1"));
			}
			if (Toilet_N == 12)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room5/Toilet_5_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Toilet_5_2"));
			}
			if (Toilet_N == 13)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room5/Toilet_5_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Toilet_5_3"));
			}
			if (Toilet_N == 14)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room5/Toilet_5_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room5/Toilet_5_4"));
			}
		}
		if (RoomCont.Room_N == 6)
		{
			if (Bed_N == 14)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room6/Bed_6_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Bed_6_1"));
			}
			if (Bed_N == 15)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room6/Bed_6_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Bed_6_2"));
			}
			if (Bed_N == 16)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room6/Bed_6_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Bed_6_3"));
			}
			if (Bed_N == 17)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room6/Bed_6_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Bed_6_4"));
			}
			if (Kitchen_N == 14)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room6/Kitchen_6_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Kitchen_6_1"));
			}
			if (Kitchen_N == 15)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room6/Kitchen_6_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Kitchen_6_2"));
			}
			if (Kitchen_N == 16)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room6/Kitchen_6_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Kitchen_6_3"));
			}
			if (Kitchen_N == 17)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room6/Kitchen_6_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Kitchen_6_4"));
			}
			if (Toilet_N == 14)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room6/Toilet_6_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Toilet_6_1"));
			}
			if (Toilet_N == 15)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room6/Toilet_6_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Toilet_6_2"));
			}
			if (Toilet_N == 16)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room6/Toilet_6_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Toilet_6_3"));
			}
			if (Toilet_N == 17)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room6/Toilet_6_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room6/Toilet_6_4"));
			}
		}
		if (RoomCont.Room_N == 7)
		{
			if (Bed_N == 17)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room7/Bed_7_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Bed_7_1"));
			}
			if (Bed_N == 18)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room7/Bed_7_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Bed_7_2"));
			}
			if (Bed_N == 19)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room7/Bed_7_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Bed_7_3"));
			}
			if (Bed_N == 20)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room7/Bed_7_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Bed_7_4"));
			}
			if (Kitchen_N == 17)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room7/Kitchen_7_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Kitchen_7_1"));
			}
			if (Kitchen_N == 18)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room7/Kitchen_7_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Kitchen_7_2"));
			}
			if (Kitchen_N == 19)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room7/Kitchen_7_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Kitchen_7_3"));
			}
			if (Kitchen_N == 20)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room7/Kitchen_7_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Kitchen_7_4"));
			}
			if (Toilet_N == 17)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room7/Toilet_7_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Toilet_7_1"));
			}
			if (Toilet_N == 18)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room7/Toilet_7_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Toilet_7_2"));
			}
			if (Toilet_N == 19)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room7/Toilet_7_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Toilet_7_3"));
			}
			if (Toilet_N == 20)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room7/Toilet_7_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room7/Toilet_7_4"));
			}
		}
		if (RoomCont.Room_N == 8)
		{
			if (Bed_N == 20)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room8/Bed_8_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Bed_8_1"));
			}
			if (Bed_N == 21)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room8/Bed_8_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Bed_8_2"));
			}
			if (Bed_N == 22)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room8/Bed_8_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Bed_8_3"));
			}
			if (Bed_N == 23)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room8/Bed_8_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Bed_8_4"));
			}
			if (Kitchen_N == 20)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room8/Kitchen_8_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Kitchen_8_1"));
			}
			if (Kitchen_N == 21)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room8/Kitchen_8_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Kitchen_8_2"));
			}
			if (Kitchen_N == 22)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room8/Kitchen_8_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Kitchen_8_3"));
			}
			if (Kitchen_N == 23)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room8/Kitchen_8_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Kitchen_8_4"));
			}
			if (Toilet_N == 20)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room8/Toilet_8_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Toilet_8_1"));
			}
			if (Toilet_N == 21)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room8/Toilet_8_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Toilet_8_2"));
			}
			if (Toilet_N == 22)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room8/Toilet_8_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Toilet_8_3"));
			}
			if (Toilet_N == 23)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room8/Toilet_8_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room8/Toilet_8_4"));
			}
		}
		if (RoomCont.Room_N == 9)
		{
			if (Bed_N == 23)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room9/Bed_9_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Bed_9_1"));
			}
			if (Bed_N == 24)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room9/Bed_9_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Bed_9_2"));
			}
			if (Bed_N == 25)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room9/Bed_9_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Bed_9_3"));
			}
			if (Bed_N == 26)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room9/Bed_9_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Bed_9_4"));
			}
			if (Kitchen_N == 23)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room9/Kitchen_9_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Kitchen_9_1"));
			}
			if (Kitchen_N == 24)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room9/Kitchen_9_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Kitchen_9_2"));
			}
			if (Kitchen_N == 25)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room9/Kitchen_9_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Kitchen_9_3"));
			}
			if (Kitchen_N == 26)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room9/Kitchen_9_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Kitchen_9_4"));
			}
			if (Toilet_N == 23)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room9/Toilet_9_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Toilet_9_1"));
			}
			if (Toilet_N == 24)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room9/Toilet_9_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Toilet_9_2"));
			}
			if (Toilet_N == 25)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room9/Toilet_9_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Toilet_9_3"));
			}
			if (Toilet_N == 26)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room9/Toilet_9_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room9/Toilet_9_4"));
			}
		}
		if (RoomCont.Room_N == 10)
		{
			if (Bed_N == 26)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room10/Bed_10_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Bed_10_1"));
			}
			if (Bed_N == 27)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room10/Bed_10_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Bed_10_2"));
			}
			if (Bed_N == 28)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room10/Bed_10_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Bed_10_3"));
			}
			if (Bed_N == 29)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room10/Bed_10_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Bed_10_4"));
			}
			if (Kitchen_N == 26)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room10/Kitchen_10_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Kitchen_10_1"));
			}
			if (Kitchen_N == 27)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room10/Kitchen_10_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Kitchen_10_2"));
			}
			if (Kitchen_N == 28)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room10/Kitchen_10_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Kitchen_10_3"));
			}
			if (Kitchen_N == 29)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room10/Kitchen_10_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Kitchen_10_4"));
			}
			if (Toilet_N == 26)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room10/Toilet_10_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Toilet_10_1"));
			}
			if (Toilet_N == 27)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room10/Toilet_10_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Toilet_10_2"));
			}
			if (Toilet_N == 28)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room10/Toilet_10_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Toilet_10_3"));
			}
			if (Toilet_N == 29)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room10/Toilet_10_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room10/Toilet_10_4"));
			}
		}
		if (RoomCont.Room_N == 11)
		{
			if (Bed_N == 29)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room11/Bed_11_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Bed_11_1"));
			}
			if (Bed_N == 30)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room11/Bed_11_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Bed_11_2"));
			}
			if (Bed_N == 31)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room11/Bed_11_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Bed_11_3"));
			}
			if (Bed_N == 32)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room11/Bed_11_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Bed_11_4"));
			}
			if (Kitchen_N == 29)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room11/Kitchen_11_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Kitchen_11_1"));
			}
			if (Kitchen_N == 30)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room11/Kitchen_11_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Kitchen_11_2"));
			}
			if (Kitchen_N == 31)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room11/Kitchen_11_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Kitchen_11_3"));
			}
			if (Kitchen_N == 32)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room11/Kitchen_11_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Kitchen_11_4"));
			}
			if (Toilet_N == 29)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room11/Toilet_11_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Toilet_11_1"));
			}
			if (Toilet_N == 30)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room11/Toilet_11_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Toilet_11_2"));
			}
			if (Toilet_N == 31)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room11/Toilet_11_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Toilet_11_3"));
			}
			if (Toilet_N == 32)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room11/Toilet_11_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room11/Toilet_11_4"));
			}
		}
		if (RoomCont.Room_N == 12)
		{
			if (Bed_N == 32)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room12/Bed_12_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Bed_12_1"));
			}
			if (Bed_N == 33)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room12/Bed_12_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Bed_12_2"));
			}
			if (Bed_N == 34)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room12/Bed_12_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Bed_12_3"));
			}
			if (Bed_N == 35)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room12/Bed_12_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Bed_12_4"));
			}
			if (Kitchen_N == 32)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room12/Kitchen_12_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Kitchen_12_1"));
			}
			if (Kitchen_N == 33)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room12/Kitchen_12_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Kitchen_12_2"));
			}
			if (Kitchen_N == 34)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room12/Kitchen_12_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Kitchen_12_3"));
			}
			if (Kitchen_N == 35)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room12/Kitchen_12_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Kitchen_12_4"));
			}
			if (Toilet_N == 32)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room12/Toilet_12_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Toilet_12_1"));
			}
			if (Toilet_N == 33)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room12/Toilet_12_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Toilet_12_2"));
			}
			if (Toilet_N == 34)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room12/Toilet_12_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Toilet_12_3"));
			}
			if (Toilet_N == 35)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room12/Toilet_12_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room12/Toilet_12_4"));
			}
		}
		if (RoomCont.Room_N == 13)
		{
			if (Bed_N == 35)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room13/Bed_13_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Bed_13_1"));
			}
			if (Bed_N == 36)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room13/Bed_13_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Bed_13_2"));
			}
			if (Bed_N == 37)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room13/Bed_13_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Bed_13_3"));
			}
			if (Bed_N == 38)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room13/Bed_13_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Bed_13_4"));
			}
			if (Kitchen_N == 35)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room13/Kitchen_13_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Kitchen_13_1"));
			}
			if (Kitchen_N == 36)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room13/Kitchen_13_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Kitchen_13_2"));
			}
			if (Kitchen_N == 37)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room13/Kitchen_13_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Kitchen_13_3"));
			}
			if (Kitchen_N == 38)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room13/Kitchen_13_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Kitchen_13_4"));
			}
			if (Toilet_N == 35)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room13/Toilet_13_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Toilet_13_1"));
			}
			if (Toilet_N == 36)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room13/Toilet_13_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Toilet_13_2"));
			}
			if (Toilet_N == 37)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room13/Toilet_13_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Toilet_13_3"));
			}
			if (Toilet_N == 38)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room13/Toilet_13_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room13/Toilet_13_4"));
			}
		}
		if (RoomCont.Room_N == 14)
		{
			if (Bed_N == 38)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room14/Bed_14_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Bed_14_1"));
			}
			if (Bed_N == 39)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room14/Bed_14_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Bed_14_2"));
			}
			if (Bed_N == 40)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room14/Bed_14_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Bed_14_3"));
			}
			if (Bed_N == 41)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room14/Bed_14_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Bed_14_4"));
			}
			if (Kitchen_N == 38)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room14/Kitchen_14_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Kitchen_14_1"));
			}
			if (Kitchen_N == 39)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room14/Kitchen_14_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Kitchen_14_2"));
			}
			if (Kitchen_N == 40)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room14/Kitchen_14_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Kitchen_14_3"));
			}
			if (Kitchen_N == 41)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room14/Kitchen_14_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Kitchen_14_4"));
			}
			if (Toilet_N == 38)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room14/Toilet_14_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Toilet_14_1"));
			}
			if (Toilet_N == 39)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room14/Toilet_14_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Toilet_14_2"));
			}
			if (Toilet_N == 40)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room14/Toilet_14_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Toilet_14_3"));
			}
			if (Toilet_N == 41)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room14/Toilet_14_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room14/Toilet_14_4"));
			}
		}
		if (RoomCont.Room_N == 15)
		{
			if (Bed_N == 41)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room15/Bed_15_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Bed_15_1"));
			}
			if (Bed_N == 42)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room15/Bed_15_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Bed_15_2"));
			}
			if (Bed_N == 43)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room15/Bed_15_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Bed_15_3"));
			}
			if (Bed_N == 44)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room15/Bed_15_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Bed_15_4"));
			}
			if (Kitchen_N == 41)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room15/Kitchen_15_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Kitchen_15_1"));
			}
			if (Kitchen_N == 42)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room15/Kitchen_15_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Kitchen_15_2"));
			}
			if (Kitchen_N == 43)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room15/Kitchen_15_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Kitchen_15_3"));
			}
			if (Kitchen_N == 44)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room15/Kitchen_15_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Kitchen_15_4"));
			}
			if (Toilet_N == 41)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room15/Toilet_15_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Toilet_15_1"));
			}
			if (Toilet_N == 42)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room15/Toilet_15_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Toilet_15_2"));
			}
			if (Toilet_N == 43)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room15/Toilet_15_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Toilet_15_3"));
			}
			if (Toilet_N == 44)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room15/Toilet_15_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room15/Toilet_15_4"));
			}
		}
		if (RoomCont.Room_N == 16)
		{
			if (Bed_N == 44)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room16/Bed_16_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Bed_16_1"));
			}
			if (Bed_N == 45)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room16/Bed_16_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Bed_16_2"));
			}
			if (Bed_N == 46)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room16/Bed_16_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Bed_16_3"));
			}
			if (Bed_N == 47)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room16/Bed_16_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Bed_16_4"));
			}
			if (Kitchen_N == 44)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room16/Kitchen_16_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Kitchen_16_1"));
			}
			if (Kitchen_N == 45)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room16/Kitchen_16_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Kitchen_16_2"));
			}
			if (Kitchen_N == 46)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room16/Kitchen_16_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Kitchen_16_3"));
			}
			if (Kitchen_N == 47)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room16/Kitchen_16_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Kitchen_16_4"));
			}
			if (Toilet_N == 44)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room16/Toilet_16_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Toilet_16_1"));
			}
			if (Toilet_N == 45)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room16/Toilet_16_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Toilet_16_2"));
			}
			if (Toilet_N == 46)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room16/Toilet_16_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Toilet_16_3"));
			}
			if (Toilet_N == 47)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room16/Toilet_16_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room16/Toilet_16_4"));
			}
		}
		if (RoomCont.Room_N == 17)
		{
			if (Bed_N == 47)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room17/Bed_17_1");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Bed_17_1"));
			}
			if (Bed_N == 48)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room17/Bed_17_2");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Bed_17_2"));
			}
			if (Bed_N == 49)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room17/Bed_17_3");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Bed_17_3"));
			}
			if (Bed_N == 50)
			{
				bed_Resource = (GameObject)Resources.Load("furniture/Room17/Bed_17_4");
				bed_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Bed_17_4"));
			}
			if (Kitchen_N == 47)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room17/Kitchen_17_1");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Kitchen_17_1"));
			}
			if (Kitchen_N == 48)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room17/Kitchen_17_2");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Kitchen_17_2"));
			}
			if (Kitchen_N == 49)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room17/Kitchen_17_3");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Kitchen_17_3"));
			}
			if (Kitchen_N == 50)
			{
				kitchen_Resource = (GameObject)Resources.Load("furniture/Room17/Kitchen_17_4");
				kitchen_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Kitchen_17_4"));
			}
			if (Toilet_N == 47)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room17/Toilet_17_1");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Toilet_17_1"));
			}
			if (Toilet_N == 48)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room17/Toilet_17_2");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Toilet_17_2"));
			}
			if (Toilet_N == 49)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room17/Toilet_17_3");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Toilet_17_3"));
			}
			if (Toilet_N == 50)
			{
				toilet_Resource = (GameObject)Resources.Load("furniture/Room17/Toilet_17_4");
				toilet_ = (GameObject)Object.Instantiate(Resources.Load("furniture/Room17/Toilet_17_4"));
			}
		}
		if (s3_7.Lv1_bed > 0)
		{
			bed_.transform.SetParent(Roomparent.transform);
			bed_.transform.localPosition = bed_Resource.transform.localPosition;
			bed_.transform.localScale = bed_Resource.transform.localScale;
		}
		if (s3_7.Lv1_living > 0)
		{
			kitchen_.transform.SetParent(Roomparent.transform);
			kitchen_.transform.localPosition = kitchen_Resource.transform.localPosition;
			kitchen_.transform.localScale = kitchen_Resource.transform.localScale;
		}
		if (s3_7.Lv1_toilet > 0)
		{
			toilet_.transform.SetParent(Roomparent.transform);
			toilet_.transform.localPosition = toilet_Resource.transform.localPosition;
			toilet_.transform.localScale = toilet_Resource.transform.localScale;
		}
	}
}
