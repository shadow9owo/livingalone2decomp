using UnityEngine;
using UnityEngine.UI;

public class CarCont : MonoBehaviour
{
	public GameObject CarBtn;

	public Sprite _Car;

	public Sprite _Home;

	public GameObject BtnText;

	public bool BtnCheck;

	public GameObject Room_pet_man;

	public GameObject ParkingArea;

	public GameObject Parkinglot_object;

	public static int car_park_num0;

	public static int car_park_num1;

	public static int car_park_num2;

	public static int car_park_num3;

	public static int car_park_num4;

	public static int car_park_num5;

	public static int car_park_num6;

	public static int car_park_num7;

	public static int car_park_num8;

	public static int car_park_num9;

	public static int car_park_num10;

	public static int car_park_num11;

	public static int car_park_num12;

	public static int car_park_num13;

	public static int car_park_num14;

	public static int car_park_num15;

	public static int car_park_num16;

	public static int car_park_num17;

	public static int car_park_num18;

	public static int car_park_num19;

	public GameObject Char;

	public GameObject report_effect;

	public int car_N = 1;

	public float[] car_effect;

	public static float all_car_effect;

	public static int Careffect;

	private void Start()
	{
		BtnCheck = false;
		Room_pet_man.SetActive(true);
		ParkingArea.SetActive(false);
		BtnText.GetComponent<Text>().text = string.Format("Parking\nlot");
		car_park_num0 = PlayerPrefs.GetInt("car_park_num0");
		car_park_num1 = PlayerPrefs.GetInt("car_park_num1");
		car_park_num2 = PlayerPrefs.GetInt("car_park_num2");
		car_park_num3 = PlayerPrefs.GetInt("car_park_num3");
		car_park_num4 = PlayerPrefs.GetInt("car_park_num4");
		car_park_num5 = PlayerPrefs.GetInt("car_park_num5");
		car_park_num6 = PlayerPrefs.GetInt("car_park_num6");
		car_park_num7 = PlayerPrefs.GetInt("car_park_num7");
		car_park_num8 = PlayerPrefs.GetInt("car_park_num8");
		car_park_num9 = PlayerPrefs.GetInt("car_park_num9");
		car_park_num10 = PlayerPrefs.GetInt("car_park_num10");
		car_park_num11 = PlayerPrefs.GetInt("car_park_num11");
		car_park_num12 = PlayerPrefs.GetInt("car_park_num12");
		car_park_num13 = PlayerPrefs.GetInt("car_park_num13");
		car_park_num14 = PlayerPrefs.GetInt("car_park_num14");
		car_park_num15 = PlayerPrefs.GetInt("car_park_num15");
		car_park_num16 = PlayerPrefs.GetInt("car_park_num16");
		car_park_num17 = PlayerPrefs.GetInt("car_park_num17");
		car_park_num18 = PlayerPrefs.GetInt("car_park_num18");
		car_park_num19 = PlayerPrefs.GetInt("car_park_num19");
		Careffect = PlayerPrefs.GetInt("Careffect");
		Seteffect();
	}

	public void Seteffect()
	{
		if (car_park_num0 == 1)
		{
			car_effect[0] = 0.01f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num1 == 1)
		{
			car_effect[1] = 0.015f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num2 == 1)
		{
			car_effect[2] = 0.02f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num3 == 1)
		{
			car_effect[3] = 0.025f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num4 == 1)
		{
			car_effect[4] = 0.03f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num5 == 1)
		{
			car_effect[5] = 0.035f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num6 == 1)
		{
			car_effect[6] = 0.04f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num7 == 1)
		{
			car_effect[7] = 0.045f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num8 == 1)
		{
			car_effect[8] = 0.05f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num9 == 1)
		{
			car_effect[9] = 0.055f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num10 == 1)
		{
			car_effect[10] = 0.06f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num11 == 1)
		{
			car_effect[11] = 0.065f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num12 == 1)
		{
			car_effect[12] = 0.03f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num13 == 1)
		{
			car_effect[13] = 0.02f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num14 == 1)
		{
			car_effect[14] = 0.05f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num15 == 1)
		{
			car_effect[15] = 0.085f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num16 == 1)
		{
			car_effect[16] = 0.04f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num17 == 1)
		{
			car_effect[17] = 0.07f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num18 == 1)
		{
			car_effect[18] = 0.08f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (car_park_num19 == 1)
		{
			car_effect[19] = 0.09f;
			PlayerPrefs.SetInt("CarEnding", 1);
		}
		if (Careffect == 0)
		{
			all_car_effect = car_effect[0] + car_effect[1] + car_effect[2] + car_effect[3] + car_effect[4] + car_effect[5] + car_effect[6] + car_effect[7] + car_effect[8] + car_effect[9] + car_effect[10] + car_effect[11] + car_effect[12] + car_effect[13] + car_effect[14] + car_effect[15] + car_effect[16] + car_effect[17] + car_effect[18] + car_effect[19];
			report_effect.GetComponent<Text>().text = string.Format("{0}%", all_car_effect * 100f);
		}
		if (Careffect == 1)
		{
			all_car_effect = 0f;
			report_effect.GetComponent<Text>().text = string.Format("No effect");
		}
	}

	public void SetSprite()
	{
		if (RoomCont.Room_N > 0 && RoomCont.Room_N <= 3)
		{
			Parkinglot_object.GetComponent<Image>().sprite = Resources.Load<Sprite>("parkinglot1");
		}
		if (RoomCont.Room_N > 3 && RoomCont.Room_N <= 9)
		{
			Parkinglot_object.GetComponent<Image>().sprite = Resources.Load<Sprite>("parkinglot2");
		}
		if (RoomCont.Room_N > 9 && RoomCont.Room_N <= 17)
		{
			Parkinglot_object.GetComponent<Image>().sprite = Resources.Load<Sprite>("parkinglot3");
		}
	}

	public void CarButton()
	{
		if (!BtnCheck)
		{
			SetBtnImage_Home();
			Char.SetActive(false);
			Room_pet_man.SetActive(false);
			ParkingArea.SetActive(true);
			BtnText.GetComponent<Text>().text = string.Format("My\nRoom");
			SetCars();
			SetSprite();
		}
		else
		{
			DeleteCars();
			Char.GetComponent<Char>().SetPosition();
			Char.SetActive(true);
			SetBtnImge_Car();
			Room_pet_man.SetActive(true);
			ParkingArea.SetActive(false);
			BtnText.GetComponent<Text>().text = string.Format("Parking\nlot");
		}
	}

	public void SetCars()
	{
		if (car_park_num0 == 1)
		{
			GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Car/0"));
			gameObject.transform.SetParent(ParkingArea.transform);
			gameObject.transform.localPosition = gameObject.transform.position;
			gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num1 == 1)
		{
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Car/1"));
			gameObject2.transform.SetParent(ParkingArea.transform);
			gameObject2.transform.localPosition = gameObject2.transform.position;
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num2 == 1)
		{
			GameObject gameObject3 = (GameObject)Object.Instantiate(Resources.Load("Car/2"));
			gameObject3.transform.SetParent(ParkingArea.transform);
			gameObject3.transform.localPosition = gameObject3.transform.position;
			gameObject3.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num3 == 1)
		{
			GameObject gameObject4 = (GameObject)Object.Instantiate(Resources.Load("Car/3"));
			gameObject4.transform.SetParent(ParkingArea.transform);
			gameObject4.transform.localPosition = gameObject4.transform.position;
			gameObject4.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num4 == 1)
		{
			GameObject gameObject5 = (GameObject)Object.Instantiate(Resources.Load("Car/4"));
			gameObject5.transform.SetParent(ParkingArea.transform);
			gameObject5.transform.localPosition = gameObject5.transform.position;
			gameObject5.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num5 == 1)
		{
			GameObject gameObject6 = (GameObject)Object.Instantiate(Resources.Load("Car/5"));
			gameObject6.transform.SetParent(ParkingArea.transform);
			gameObject6.transform.localPosition = gameObject6.transform.position;
			gameObject6.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num6 == 1)
		{
			GameObject gameObject7 = (GameObject)Object.Instantiate(Resources.Load("Car/6"));
			gameObject7.transform.SetParent(ParkingArea.transform);
			gameObject7.transform.localPosition = gameObject7.transform.position;
			gameObject7.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num7 == 1)
		{
			GameObject gameObject8 = (GameObject)Object.Instantiate(Resources.Load("Car/7"));
			gameObject8.transform.SetParent(ParkingArea.transform);
			gameObject8.transform.localPosition = gameObject8.transform.position;
			gameObject8.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num8 == 1)
		{
			GameObject gameObject9 = (GameObject)Object.Instantiate(Resources.Load("Car/8"));
			gameObject9.transform.SetParent(ParkingArea.transform);
			gameObject9.transform.localPosition = gameObject9.transform.position;
			gameObject9.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num9 == 1)
		{
			GameObject gameObject10 = (GameObject)Object.Instantiate(Resources.Load("Car/9"));
			gameObject10.transform.SetParent(ParkingArea.transform);
			gameObject10.transform.localPosition = gameObject10.transform.position;
			gameObject10.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num10 == 1)
		{
			GameObject gameObject11 = (GameObject)Object.Instantiate(Resources.Load("Car/10"));
			gameObject11.transform.SetParent(ParkingArea.transform);
			gameObject11.transform.localPosition = gameObject11.transform.position;
			gameObject11.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num11 == 1)
		{
			GameObject gameObject12 = (GameObject)Object.Instantiate(Resources.Load("Car/11"));
			gameObject12.transform.SetParent(ParkingArea.transform);
			gameObject12.transform.localPosition = gameObject12.transform.position;
			gameObject12.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num12 == 1)
		{
			GameObject gameObject13 = (GameObject)Object.Instantiate(Resources.Load("Car/12"));
			gameObject13.transform.SetParent(ParkingArea.transform);
			gameObject13.transform.localPosition = gameObject13.transform.position;
			gameObject13.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num13 == 1)
		{
			GameObject gameObject14 = (GameObject)Object.Instantiate(Resources.Load("Car/13"));
			gameObject14.transform.SetParent(ParkingArea.transform);
			gameObject14.transform.localPosition = gameObject14.transform.position;
			gameObject14.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num14 == 1)
		{
			GameObject gameObject15 = (GameObject)Object.Instantiate(Resources.Load("Car/14"));
			gameObject15.transform.SetParent(ParkingArea.transform);
			gameObject15.transform.localPosition = gameObject15.transform.position;
			gameObject15.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num15 == 1)
		{
			GameObject gameObject16 = (GameObject)Object.Instantiate(Resources.Load("Car/15"));
			gameObject16.transform.SetParent(ParkingArea.transform);
			gameObject16.transform.localPosition = gameObject16.transform.position;
			gameObject16.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num16 == 1)
		{
			GameObject gameObject17 = (GameObject)Object.Instantiate(Resources.Load("Car/16"));
			gameObject17.transform.SetParent(ParkingArea.transform);
			gameObject17.transform.localPosition = gameObject17.transform.position;
			gameObject17.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num17 == 1)
		{
			GameObject gameObject18 = (GameObject)Object.Instantiate(Resources.Load("Car/17"));
			gameObject18.transform.SetParent(ParkingArea.transform);
			gameObject18.transform.localPosition = gameObject18.transform.position;
			gameObject18.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num18 == 1)
		{
			GameObject gameObject19 = (GameObject)Object.Instantiate(Resources.Load("Car/18"));
			gameObject19.transform.SetParent(ParkingArea.transform);
			gameObject19.transform.localPosition = gameObject19.transform.position;
			gameObject19.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		if (car_park_num19 == 1)
		{
			GameObject gameObject20 = (GameObject)Object.Instantiate(Resources.Load("Car/19"));
			gameObject20.transform.SetParent(ParkingArea.transform);
			gameObject20.transform.localPosition = gameObject20.transform.position;
			gameObject20.transform.localScale = new Vector3(1f, 1f, 1f);
		}
	}

	public void DeleteCars()
	{
		if (car_park_num0 == 1)
		{
			Object.Destroy(GameObject.Find("0(Clone)"));
		}
		if (car_park_num1 == 1)
		{
			Object.Destroy(GameObject.Find("1(Clone)"));
		}
		if (car_park_num2 == 1)
		{
			Object.Destroy(GameObject.Find("2(Clone)"));
		}
		if (car_park_num3 == 1)
		{
			Object.Destroy(GameObject.Find("3(Clone)"));
		}
		if (car_park_num4 == 1)
		{
			Object.Destroy(GameObject.Find("4(Clone)"));
		}
		if (car_park_num5 == 1)
		{
			Object.Destroy(GameObject.Find("5(Clone)"));
		}
		if (car_park_num6 == 1)
		{
			Object.Destroy(GameObject.Find("6(Clone)"));
		}
		if (car_park_num7 == 1)
		{
			Object.Destroy(GameObject.Find("7(Clone)"));
		}
		if (car_park_num8 == 1)
		{
			Object.Destroy(GameObject.Find("8(Clone)"));
		}
		if (car_park_num9 == 1)
		{
			Object.Destroy(GameObject.Find("9(Clone)"));
		}
		if (car_park_num10 == 1)
		{
			Object.Destroy(GameObject.Find("10(Clone)"));
		}
		if (car_park_num11 == 1)
		{
			Object.Destroy(GameObject.Find("11(Clone)"));
		}
		if (car_park_num12 == 1)
		{
			Object.Destroy(GameObject.Find("12(Clone)"));
		}
		if (car_park_num13 == 1)
		{
			Object.Destroy(GameObject.Find("13(Clone)"));
		}
		if (car_park_num14 == 1)
		{
			Object.Destroy(GameObject.Find("14(Clone)"));
		}
		if (car_park_num15 == 1)
		{
			Object.Destroy(GameObject.Find("15(Clone)"));
		}
		if (car_park_num16 == 1)
		{
			Object.Destroy(GameObject.Find("16(Clone)"));
		}
		if (car_park_num17 == 1)
		{
			Object.Destroy(GameObject.Find("17(Clone)"));
		}
		if (car_park_num18 == 1)
		{
			Object.Destroy(GameObject.Find("18(Clone)"));
		}
		if (car_park_num19 == 1)
		{
			Object.Destroy(GameObject.Find("19(Clone)"));
		}
	}

	public void SetBtnImage_Home()
	{
		BtnCheck = true;
		CarBtn.GetComponent<Image>().sprite = _Home;
	}

	public void SetBtnImge_Car()
	{
		BtnCheck = false;
		CarBtn.GetComponent<Image>().sprite = _Car;
	}
}
