using UnityEngine;

public class Char : MonoBehaviour
{
	public static CharD _CharD;

	public static int CharD_N;

	public static int Sex;

	public void Awake()
	{
		Sex = PlayerPrefs.GetInt("Sex");
	}

	public void Start()
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = 60;
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		PlayerPrefs.SetInt("Clothes_N", Clothes.Clothes_N);
		SetPosition();
		ChangeStart();
	}

	public void SetPosition()
	{
		if (RoomCont.Room_N == 0)
		{
			base.transform.localPosition = new Vector3(-170f, -78f, 0f);
		}
		if (RoomCont.Room_N == 1)
		{
			base.transform.localPosition = new Vector3(-170f, -78f, 0f);
		}
		if (RoomCont.Room_N == 2)
		{
			base.transform.localPosition = new Vector3(-129f, -17f, 0f);
		}
		if (RoomCont.Room_N == 3)
		{
			base.transform.localPosition = new Vector3(-26.4f, -35.3f, 0f);
		}
		if (RoomCont.Room_N == 4)
		{
			base.transform.localPosition = new Vector3(32f, -39f, 0f);
		}
		if (RoomCont.Room_N == 5)
		{
			base.transform.localPosition = new Vector3(32f, -39f, 0f);
		}
		if (RoomCont.Room_N == 6)
		{
			base.transform.localPosition = new Vector3(-24f, -44f, 0f);
		}
		if (RoomCont.Room_N == 7)
		{
			base.transform.localPosition = new Vector3(-51f, -227f, 0f);
		}
		if (RoomCont.Room_N == 8)
		{
			base.transform.localPosition = new Vector3(-51f, -227f, 0f);
		}
		if (RoomCont.Room_N == 9)
		{
			base.transform.localPosition = new Vector3(-221f, 47f, 0f);
		}
		if (RoomCont.Room_N == 10)
		{
			base.transform.localPosition = new Vector3(0f, 33f, 0f);
		}
		if (RoomCont.Room_N == 11)
		{
			base.transform.localPosition = new Vector3(-199f, 119f, 0f);
		}
		if (RoomCont.Room_N == 12)
		{
			base.transform.localPosition = new Vector3(0f, -269f, 0f);
		}
		if (RoomCont.Room_N == 13)
		{
			base.transform.localPosition = new Vector3(-82f, 88f, 0f);
		}
		if (RoomCont.Room_N == 14)
		{
			base.transform.localPosition = new Vector3(114f, 177f, 0f);
		}
		if (RoomCont.Room_N == 15)
		{
			base.transform.localPosition = new Vector3(8f, 284f, 0f);
		}
		if (RoomCont.Room_N == 16)
		{
			base.transform.localPosition = new Vector3(-87f, 42f, 0f);
		}
		if (RoomCont.Room_N == 17)
		{
			base.transform.localPosition = new Vector3(31f, -38f, 0f);
		}
	}

	private void FixedUpdate()
	{
		Vector3 zero = Vector3.zero;
		bool flag = false;
		if (CharD_N == 1)
		{
			_CharD = CharD.U;
		}
		if (CharD_N == 2)
		{
			_CharD = CharD.D;
		}
		if (CharD_N == 3)
		{
			_CharD = CharD.L;
		}
		if (CharD_N == 4)
		{
			_CharD = CharD.R;
		}
		if (CharD_N == 5)
		{
			_CharD = CharD.S;
		}
		if (_CharD == CharD.U)
		{
			flag = true;
			zero += Vector3.up;
		}
		else if (_CharD == CharD.D)
		{
			flag = true;
			zero += Vector3.down;
		}
		if (_CharD == CharD.L)
		{
			if (!flag)
			{
				zero += Vector3.left;
			}
		}
		else if (_CharD == CharD.R && !flag)
		{
			zero += Vector3.right;
		}
		if (_CharD == CharD.S && !flag)
		{
			zero += Vector3.zero;
		}
		base.transform.position += zero * Time.deltaTime * 0.4f;
	}

	public void ChangeStart()
	{
		CharD_N = Random.Range(1, 5);
		Invoke("ChangeDes", Random.Range(3f, 5f));
	}

	public void ChangeDes()
	{
		Invoke("ChangeStart", Random.Range(3f, 5f));
	}

	public void Stop()
	{
		CharD_N = 5;
		Invoke("ChangeStart", 5f);
	}

	public void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "furniture")
		{
			CancelInvoke();
			Stop();
		}
		if (col.gameObject.tag == "lover")
		{
			CancelInvoke();
			Stop();
		}
		if (col.gameObject.tag == "pet")
		{
			CancelInvoke();
			ChangeStart();
		}
	}

	public void OnTriggerEnter(Collider col)
	{
		string text = col.name;
		Transform component = GetComponent<Transform>();
		if (text == "Room3_Bed_Potal_In")
		{
			component.localPosition = new Vector3(135f, 20f, 0f);
		}
		if (text == "Room3_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(12f, 6f, 0f);
		}
		if (text == "Room6_living_Potal_In")
		{
			component.localPosition = new Vector3(-49.3f, -181.8f, 0f);
		}
		if (text == "Room6_living_Potal_Out")
		{
			component.localPosition = new Vector3(-163.4f, -221.7f, 0f);
		}
		if (text == "Room6_bed_Potal_In")
		{
			component.localPosition = new Vector3(-173f, 40f, 0f);
		}
		if (text == "Room6_bed_Potal_Out")
		{
			component.localPosition = new Vector3(-227f, -127f, 0f);
		}
		if (text == "Room7_enter_Potal_In")
		{
			component.localPosition = new Vector3(-635f, -166f, 0f);
		}
		if (text == "Room7_enter_Potal_Out")
		{
			component.localPosition = new Vector3(-495f, -166f, 0f);
		}
		if (text == "Room7_bed_Potal_In")
		{
			component.localPosition = new Vector3(-171f, 90f, 0f);
		}
		if (text == "Room7_bed_Potal_Out")
		{
			component.localPosition = new Vector3(-171f, -100f, 0f);
		}
		if (text == "Room7_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-56f, 92f, 0f);
		}
		if (text == "Room7_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-56f, -92f, 0f);
		}
		if (text == "Room8_enter_Potal_In")
		{
			component.localPosition = new Vector3(78f, -59f, 0f);
		}
		if (text == "Room8_enter_Potal_Out")
		{
			component.localPosition = new Vector3(-42f, -59f, 0f);
		}
		if (text == "Room8_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(77f, 116f, 0f);
		}
		if (text == "Room8_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(77f, -39f, 0f);
		}
		if (text == "Room8_bath_Potal_In")
		{
			component.localPosition = new Vector3(83.9f, -239.3f, 0f);
		}
		if (text == "Room8_bath_Potal_Out")
		{
			component.localPosition = new Vector3(88.4f, -92f, 0f);
		}
		if (text == "Room8_toilet_Potal_In")
		{
			component.localPosition = new Vector3(-129.5f, 106f, 0f);
		}
		if (text == "Room8_toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-125f, -43f, 0f);
		}
		if (text == "Room9_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-205f, 55f, 0f);
		}
		if (text == "Room9_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-205f, 216f, 0f);
		}
		if (text == "Room9_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(105.4f, 63f, 0f);
		}
		if (text == "Room9_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(116.6f, 213f, 0f);
		}
		if (text == "Room9_launary_Potal_In")
		{
			component.localPosition = new Vector3(-9.3f, 30.6f, 0f);
		}
		if (text == "Room9_launary_Potal_Out")
		{
			component.localPosition = new Vector3(97.2f, 30.6f, 0f);
		}
		if (text == "Room10_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(-460.3f, -134f, 0f);
		}
		if (text == "Room10_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-460.3f, 11.3f, 0f);
		}
		if (text == "Room10_Bed_Potal_In")
		{
			component.localPosition = new Vector3(131.9f, 188f, 0f);
		}
		if (text == "Room10_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(15.5f, 188f, 0f);
		}
		if (text == "Room10_Balcony_Potal_In")
		{
			component.localPosition = new Vector3(15.5f, -145f, 0f);
		}
		if (text == "Room10_Balcony_Potal_Out")
		{
			component.localPosition = new Vector3(12f, 10f, 0f);
		}
		if (text == "Room11_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(40.8f, 195f, 0f);
		}
		if (text == "Room11_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(40.8f, 30.7f, 0f);
		}
		if (text == "Room11_Bed_Potal_In")
		{
			component.localPosition = new Vector3(52f, -194f, 0f);
		}
		if (text == "Room11_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(52f, -30f, 0f);
		}
		if (text == "Room11_Balcony_Potal_In")
		{
			component.localPosition = new Vector3(-461f, -229f, 0f);
		}
		if (text == "Room11_Balcony_Potal_Out")
		{
			component.localPosition = new Vector3(-461f, -73f, 0f);
		}
		if (text == "Room12_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(180f, 169f, 0f);
		}
		if (text == "Room12_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(180f, 9f, 0f);
		}
		if (text == "Room12_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-299f, -54.3f, 0f);
		}
		if (text == "Room12_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-299f, -215f, 0f);
		}
		if (text == "Room12_Book_Potal_In")
		{
			component.localPosition = new Vector3(323f, -204f, 0f);
		}
		if (text == "Room12_Book_Potal_Out")
		{
			component.localPosition = new Vector3(196f, -204f, 0f);
		}
		if (text == "Room13_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(231.8f, 180f, 0f);
		}
		if (text == "Room13_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(231.8f, 25f, 0f);
		}
		if (text == "Room13_Bed_Potal_In")
		{
			component.localPosition = new Vector3(46.3f, -154f, 0f);
		}
		if (text == "Room13_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(46.3f, 10f, 0f);
		}
		if (text == "Room13_TV_Potal_In")
		{
			component.localPosition = new Vector3(-468f, 13f, 0f);
		}
		if (text == "Room13_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-319.7f, 32.5f, 0f);
		}
		if (text == "Room14_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(141f, -141f, 0f);
		}
		if (text == "Room14_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(119.3f, 113.2f, 0f);
		}
		if (text == "Room14_Bed_Potal_In")
		{
			component.localPosition = new Vector3(91f, 283f, 0f);
		}
		if (text == "Room14_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-290f, 283f, 0f);
		}
		if (text == "Room14_TV_Potal_In")
		{
			component.localPosition = new Vector3(-646.2f, 59f, 0f);
		}
		if (text == "Room14_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-571.5f, 228f, 0f);
		}
		if (text == "Room15_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(96f, -118.3f, 0f);
		}
		if (text == "Room15_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-47f, -118.3f, 0f);
		}
		if (text == "Room15_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-32f, 345f, 0f);
		}
		if (text == "Room15_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-151f, 345f, 0f);
		}
		if (text == "Room15_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-269.3f, 208.7f, 0f);
		}
		if (text == "Room15_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-151f, 208.7f, 0f);
		}
		if (text == "Room15_TV_Potal_In")
		{
			component.localPosition = new Vector3(-578.6f, 46.9f, 0f);
		}
		if (text == "Room15_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-561.8f, 207f, 0f);
		}
		if (text == "Room16_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(111f, -270.9f, 0f);
		}
		if (text == "Room16_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-49.5f, -270.9f, 0f);
		}
		if (text == "Room16_Bed_Potal_In")
		{
			component.localPosition = new Vector3(101.4f, 156f, 0f);
		}
		if (text == "Room16_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-49.5f, 156f, 0f);
		}
		if (text == "Room16_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-244.2f, 125.1f, 0f);
		}
		if (text == "Room16_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-115.5f, 179.8f, 0f);
		}
		if (text == "Room16_TV_Potal_In")
		{
			component.localPosition = new Vector3(-268f, -92.5f, 0f);
		}
		if (text == "Room16_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-129f, -99f, 0f);
		}
		if (text == "Room17_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(120f, 217f, 0f);
		}
		if (text == "Room17_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(30f, 6f, 0f);
		}
		if (text == "Room17_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-660f, 55f, 0f);
		}
		if (text == "Room17_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-660f, -103f, 0f);
		}
		if (text == "Room17_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(21f, -408f, 0f);
		}
		if (text == "Room17_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-622f, -213f, 0f);
		}
	}
}
