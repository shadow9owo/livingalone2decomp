using UnityEngine;

public class Pet : MonoBehaviour
{
	public static PetD _PetD;

	public static int Pet_N;

	public static int PetD_N;

	public GameObject Petobject;

	public RuntimeAnimatorController[] AnimController;

	private int phinix_ok;

	public void Awake()
	{
		Pet_N = PlayerPrefs.GetInt("Pet_N");
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
	}

	public void Start()
	{
		phinix_ok = PlayerPrefs.GetInt("pet_20");
		ChangeStart();
		if (s3_7.PetBuyOK == 0)
		{
			Pet_N = 99;
		}
		else
		{
			Pet_N = PlayerPrefs.GetInt("Pet_N");
		}
	}

	private void FixedUpdate()
	{
		if (PetD_N == 1)
		{
			_PetD = PetD.U;
		}
		if (PetD_N == 2)
		{
			_PetD = PetD.D;
		}
		if (PetD_N == 3)
		{
			_PetD = PetD.L;
		}
		if (PetD_N == 4)
		{
			_PetD = PetD.R;
		}
		if (PetD_N == 5)
		{
			_PetD = PetD.S;
		}
		if (s3_7.PetBuyOK != 1)
		{
			return;
		}
		Petobject.GetComponent<Animator>().runtimeAnimatorController = AnimController[Pet_N];
		base.gameObject.GetComponent<BoxCollider>().enabled = true;
		Vector3 zero = Vector3.zero;
		bool flag = false;
		if (_PetD == PetD.U)
		{
			flag = true;
			zero += Vector3.up * Time.deltaTime * 40f;
			Petobject.GetComponent<Animator>().Play("P_U");
		}
		else if (_PetD == PetD.D)
		{
			flag = true;
			zero += Vector3.down * Time.deltaTime * 40f;
			Petobject.GetComponent<Animator>().Play("P_D");
		}
		if (_PetD == PetD.L)
		{
			if (!flag)
			{
				zero += Vector3.left * Time.deltaTime * 40f;
			}
			Petobject.GetComponent<Animator>().Play("P_L");
		}
		else if (_PetD == PetD.R)
		{
			if (!flag)
			{
				zero += Vector3.right * Time.deltaTime * 40f;
			}
			Petobject.GetComponent<Animator>().Play("P_R");
		}
		if (_PetD == PetD.S)
		{
			if (!flag)
			{
				zero += Vector3.zero;
			}
			Petobject.GetComponent<Animator>().Play("P_D");
		}
		base.transform.position += zero * Time.deltaTime * 0.4f;
	}

	public void ChangeStart()
	{
		PetD_N = Random.Range(1, 5);
		Invoke("ChangeDes", Random.Range(40f, 40f));
	}

	public void ChangeDes()
	{
		Invoke("ChangeStart", Random.Range(40f, 40f));
	}

	public void Stop()
	{
		PetD_N = 5;
		Invoke("ChangeStart", 40f);
	}

	public void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "furniture")
		{
			CancelInvoke();
			Stop();
		}
		if (coll.gameObject.tag == "char")
		{
			CancelInvoke();
			ChangeStart();
		}
		if (coll.gameObject.tag == "lover")
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
			component.localPosition = new Vector3(144.3f, 24.9f, 0f);
		}
		if (text == "Room3_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(22f, 21f, 0f);
		}
		if (text == "Room6_living_Potal_In")
		{
			component.localPosition = new Vector3(-42.4f, -229f, 0f);
		}
		if (text == "Room6_living_Potal_Out")
		{
			component.localPosition = new Vector3(-157f, -229f, 0f);
		}
		if (text == "Room6_bed_Potal_In")
		{
			component.localPosition = new Vector3(-194.3f, -2.1f, 0f);
		}
		if (text == "Room6_bed_Potal_Out")
		{
			component.localPosition = new Vector3(-231.3f, -172f, 0f);
		}
		if (text == "Room7_enter_Potal_In")
		{
			component.localPosition = new Vector3(-629f, -203f, 0f);
		}
		if (text == "Room7_enter_Potal_Out")
		{
			component.localPosition = new Vector3(-497f, -203f, 0f);
		}
		if (text == "Room7_bed_Potal_In")
		{
			component.localPosition = new Vector3(-185f, 44f, 0f);
		}
		if (text == "Room7_bed_Potal_Out")
		{
			component.localPosition = new Vector3(-171.4f, -118.8f, 0f);
		}
		if (text == "Room7_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-56f, 50.5f, 0f);
		}
		if (text == "Room7_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-56f, -118.8f, 0f);
		}
		if (text == "Room8_enter_Potal_In")
		{
			component.localPosition = new Vector3(70f, -101f, 0f);
		}
		if (text == "Room8_enter_Potal_Out")
		{
			component.localPosition = new Vector3(-49f, -101f, 0f);
		}
		if (text == "Room8_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(81f, 84f, 0f);
		}
		if (text == "Room8_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(81f, -79f, 0f);
		}
		if (text == "Room8_bath_Potal_In")
		{
			component.localPosition = new Vector3(143.8f, -270f, 0f);
		}
		if (text == "Room8_bath_Potal_Out")
		{
			component.localPosition = new Vector3(77.9f, -131.7f, 0f);
		}
		if (text == "Room8_toilet_Potal_In")
		{
			component.localPosition = new Vector3(-127.6f, 76.6f, 0f);
		}
		if (text == "Room8_toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-127.6f, -83.9f, 0f);
		}
		if (text == "Room9_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-213f, 18f, 0f);
		}
		if (text == "Room9_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-213f, 179f, 0f);
		}
		if (text == "Room9_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(106.9f, 25.8f, 0f);
		}
		if (text == "Room9_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(117.6f, 175.2f, 0f);
		}
		if (text == "Room9_launary_Potal_In")
		{
			component.localPosition = new Vector3(-11.6f, -24.9f, 0f);
		}
		if (text == "Room9_launary_Potal_Out")
		{
			component.localPosition = new Vector3(101f, -6f, 0f);
		}
		if (text == "Room10_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(-531.2f, -165.8f, 0f);
		}
		if (text == "Room10_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-467f, -23.5f, 0f);
		}
		if (text == "Room10_Bed_Potal_In")
		{
			component.localPosition = new Vector3(131f, 162f, 0f);
		}
		if (text == "Room10_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(18f, 162f, 0f);
		}
		if (text == "Room10_Balcony_Potal_In")
		{
			component.localPosition = new Vector3(33.2f, -184.1f, 0f);
		}
		if (text == "Room10_Balcony_Potal_Out")
		{
			component.localPosition = new Vector3(18f, -20f, 0f);
		}
		if (text == "Room11_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(44f, 154f, 0f);
		}
		if (text == "Room11_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(44f, -1f, 0f);
		}
		if (text == "Room11_Bed_Potal_In")
		{
			component.localPosition = new Vector3(51f, -219f, 0f);
		}
		if (text == "Room11_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(51f, -61f, 0f);
		}
		if (text == "Room11_Balcony_Potal_In")
		{
			component.localPosition = new Vector3(-428.6f, -260.1f, 0f);
		}
		if (text == "Room11_Balcony_Potal_Out")
		{
			component.localPosition = new Vector3(-428.6f, -113f, 0f);
		}
		if (text == "Room12_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(176f, 141.1f, 0f);
		}
		if (text == "Room12_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(176f, -22f, 0f);
		}
		if (text == "Room12_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-297f, -90.7f, 0f);
		}
		if (text == "Room12_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-297f, -247.9f, 0f);
		}
		if (text == "Room12_Book_Potal_In")
		{
			component.localPosition = new Vector3(316f, -246f, 0f);
		}
		if (text == "Room12_Book_Potal_Out")
		{
			component.localPosition = new Vector3(196.8f, -246f, 0f);
		}
		if (text == "Room13_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(225f, 150f, 0f);
		}
		if (text == "Room13_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(225f, -13f, 0f);
		}
		if (text == "Room13_Bed_Potal_In")
		{
			component.localPosition = new Vector3(54f, -192f, 0f);
		}
		if (text == "Room13_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(54f, -24f, 0f);
		}
		if (text == "Room13_TV_Potal_In")
		{
			component.localPosition = new Vector3(-451.7f, -18f, 0f);
		}
		if (text == "Room13_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-322.2f, -18f, 0f);
		}
		if (text == "Room14_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(131f, -173f, 0f);
		}
		if (text == "Room14_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(97.6f, 52.4f, 0f);
		}
		if (text == "Room14_Bed_Potal_In")
		{
			component.localPosition = new Vector3(90f, 240f, 0f);
		}
		if (text == "Room14_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-285f, 240f, 0f);
		}
		if (text == "Room14_TV_Potal_In")
		{
			component.localPosition = new Vector3(-650f, 24f, 0f);
		}
		if (text == "Room14_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-518f, 184f, 0f);
		}
		if (text == "Room15_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(89.7f, -154.3f, 0f);
		}
		if (text == "Room15_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-37.6f, -154.3f, 0f);
		}
		if (text == "Room15_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-42.3f, 299f, 0f);
		}
		if (text == "Room15_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-151f, 299f, 0f);
		}
		if (text == "Room15_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-268.4f, 170.2f, 0f);
		}
		if (text == "Room15_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-144f, 170.2f, 0f);
		}
		if (text == "Room15_TV_Potal_In")
		{
			component.localPosition = new Vector3(-578.5f, 19f, 0f);
		}
		if (text == "Room15_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-473.9f, 170.2f, 0f);
		}
		if (text == "Room16_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(81f, -292.9f, 0f);
		}
		if (text == "Room16_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(-62f, -292.9f, 0f);
		}
		if (text == "Room16_Bed_Potal_In")
		{
			component.localPosition = new Vector3(96f, 118f, 0f);
		}
		if (text == "Room16_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-62f, 118f, 0f);
		}
		if (text == "Room16_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(-240f, 109.2f, 0f);
		}
		if (text == "Room16_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-128.4f, 178.8f, 0f);
		}
		if (text == "Room16_TV_Potal_In")
		{
			component.localPosition = new Vector3(-376f, -116.5f, 0f);
		}
		if (text == "Room16_TV_Potal_Out")
		{
			component.localPosition = new Vector3(-110.4f, -116.5f, 0f);
		}
		if (text == "Room17_Toilet_Potal_In")
		{
			component.localPosition = new Vector3(-68f, 206f, 0f);
		}
		if (text == "Room17_Toilet_Potal_Out")
		{
			component.localPosition = new Vector3(7.8f, 1.5f, 0f);
		}
		if (text == "Room17_Bed_Potal_In")
		{
			component.localPosition = new Vector3(-664f, 34f, 0f);
		}
		if (text == "Room17_Bed_Potal_Out")
		{
			component.localPosition = new Vector3(-664f, -145f, 0f);
		}
		if (text == "Room17_kitchen_Potal_In")
		{
			component.localPosition = new Vector3(22f, -430f, 0f);
		}
		if (text == "Room17_kitchen_Potal_Out")
		{
			component.localPosition = new Vector3(-624f, -260f, 0f);
		}
	}
}
