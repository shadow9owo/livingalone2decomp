using UnityEngine;

public class Furnanim_japan : MonoBehaviour
{
	private GameObject actanim_Parent;

	private GameObject Prefabs_anim;

	private GameObject Actanim;

	public void Start()
	{
		Debug.LogFormat("////Room_N={0}////", RoomCont.Room_N);
		Debug.LogFormat("////Bed_N={0}////", FurnCont.Bed_N);
		Debug.LogFormat("////Kitchen_N={0}////", FurnCont.Kitchen_N);
		Debug.LogFormat("////Toilet_N={0}////", FurnCont.Toilet_N);
	}

	public void Setanim()
	{
		Prefabs_anim = Resources.Load<GameObject>("ActingChar");
		Actanim = Object.Instantiate(Prefabs_anim);
		actanim_Parent = GameObject.Find("room_BG");
		Actanim.transform.SetParent(actanim_Parent.transform);
		Actanim.transform.localScale = new Vector3(1f, 1f, 1f);
	}

	public void room1_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 0)
			{
				Actanim.transform.localPosition = new Vector3(-114.8f, 46.5f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-115f, 51f, 1f);
			}
		}
	}

	public void room1_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-75.5f, 39.5f, 1f);
		}
	}

	public void room1_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 0)
			{
				Actanim.transform.localPosition = new Vector3(-33.5f, 29.8f, 1f);
			}
			if (FurnCont.Bed_N == 1)
			{
				Actanim.transform.localPosition = new Vector3(-32.7f, 35.7f, 1f);
			}
			if (FurnCont.Bed_N == 2)
			{
				Actanim.transform.localPosition = new Vector3(-33.9f, 35.4f, 1f);
			}
		}
	}

	public void room1_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 0)
			{
				Actanim.transform.localPosition = new Vector3(-25.34f, -7.66f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-30.69f, -7.16f, 1f);
			}
		}
	}

	public void room1_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			if (FurnCont.Kitchen_N == 2)
			{
				Actanim.transform.localPosition = new Vector3(-78.1f, 25.3f, 1f);
			}
		}
	}

	public void room2_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 5)
			{
				Actanim.transform.localPosition = new Vector3(-124.9f, 13.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-114f, 11.1f, 1f);
			}
		}
	}

	public void room2_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 2)
			{
				Actanim.transform.localPosition = new Vector3(-73.3f, 63.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-89f, 63.4f, 1f);
			}
		}
	}

	public void room2_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 5)
			{
				Actanim.transform.localPosition = new Vector3(-35.4f, 58.31f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-35.4f, 63.8f, 1f);
			}
		}
	}

	public void room2_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 2)
			{
				Actanim.transform.localPosition = new Vector3(-46.41f, -0.73f, 1f);
			}
			if (FurnCont.Bed_N == 3 || FurnCont.Bed_N == 4)
			{
				Actanim.transform.localPosition = new Vector3(-26.65f, -0.73f, 1f);
			}
			if (FurnCont.Bed_N == 5)
			{
				Actanim.transform.localPosition = new Vector3(-26.65f, 3.76f, 1f);
			}
		}
	}

	public void room2_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-69.59f, 50.82f, 1f);
		}
	}

	public void room3_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-106.3f, 83.9f, 1f);
		}
	}

	public void room3_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-56.5f, 74f, 1f);
		}
	}

	public void room3_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 5)
			{
				Actanim.transform.localPosition = new Vector3(38.52f, 70.4f, 1f);
			}
			if (FurnCont.Bed_N == 6 || FurnCont.Bed_N == 7)
			{
				Actanim.transform.localPosition = new Vector3(35.2f, 70.4f, 1f);
			}
			if (FurnCont.Bed_N == 8)
			{
				Actanim.transform.localPosition = new Vector3(34.26f, 70.4f, 1f);
			}
		}
	}

	public void room3_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			Actanim.transform.localPosition = new Vector3(42.87f, 16.39f, 1f);
		}
	}

	public void room3_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-44f, 58.8f, 1f);
		}
	}

	public void room3_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-101.7f, 42.3f, 1f);
		}
	}

	public void room4_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 8)
			{
				Actanim.transform.localPosition = new Vector3(-78f, 88.9f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-84.9f, 88.9f, 1f);
			}
		}
	}

	public void room4_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-85.1f, 30.3f, 1f);
		}
	}

	public void room4_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 8 || FurnCont.Bed_N == 9)
			{
				Actanim.transform.localPosition = new Vector3(-4.4f, 80.5f, 1f);
			}
			if (FurnCont.Bed_N == 10)
			{
				Actanim.transform.localPosition = new Vector3(-3.6f, 80.5f, 1f);
			}
			if (FurnCont.Bed_N == 11)
			{
				Actanim.transform.localPosition = new Vector3(-3f, 80.5f, 1f);
			}
		}
	}

	public void room4_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 11)
			{
				Actanim.transform.localPosition = new Vector3(1.7f, -19.97f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(3.7f, -19.97f, 1f);
			}
		}
	}

	public void room4_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-79f, 9.5f, 1f);
		}
	}

	public void room4_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 8)
			{
				Actanim.transform.localPosition = new Vector3(-104.1f, 64.2f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-59.64f, 66.51f, 1f);
			}
		}
	}

	public void room5_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 11)
			{
				Actanim.transform.localPosition = new Vector3(-78.3f, 88.8f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-105f, 87.5f, 1f);
			}
		}
	}

	public void room5_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-54f, 82.2f, 1f);
		}
	}

	public void room5_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(31.7f, 82.15f, 1f);
		}
	}

	public void room5_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 11)
			{
				Actanim.transform.localPosition = new Vector3(36.1f, -17.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(36.5f, -18.5f, 1f);
			}
		}
	}

	public void room5_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-32.7f, 61f, 1f);
		}
	}

	public void room5_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 11)
			{
				Actanim.transform.localPosition = new Vector3(-77.7f, 30.8f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-96.54f, 33.76f, 1f);
			}
		}
	}

	public void room6_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(27.1f, 109.8f, 1f);
		}
	}

	public void room6_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-10.5f, 39.7f, 1f);
		}
	}

	public void room6_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 14)
			{
				Actanim.transform.localPosition = new Vector3(-122.6f, 100.9f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-121.6f, 100.9f, 1f);
			}
		}
	}

	public void room6_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 14)
			{
				Actanim.transform.localPosition = new Vector3(-96.8f, 38.38f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-110.4f, 38.38f, 1f);
			}
		}
	}

	public void room6_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-5f, 18.2f, 1f);
		}
	}

	public void room6_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 14)
			{
				Actanim.transform.localPosition = new Vector3(-30.8f, 77.9f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-2.3f, 78.3f, 1f);
			}
		}
	}

	public void room7_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(56.6f, 9.5f, 1f);
		}
	}

	public void room7_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 17)
			{
				Actanim.transform.localPosition = new Vector3(26.9f, 83.6f, 1f);
			}
			if (FurnCont.Kitchen_N == 18)
			{
				Actanim.transform.localPosition = new Vector3(20.4f, 83.6f, 1f);
			}
			if (FurnCont.Kitchen_N == 19 || FurnCont.Kitchen_N == 20)
			{
				Actanim.transform.localPosition = new Vector3(17.8f, 83.6f, 1f);
			}
		}
	}

	public void room7_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-72.7f, 81.6f, 1f);
		}
	}

	public void room7_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 20)
			{
				Actanim.transform.localPosition = new Vector3(-109.6f, 50.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-110.7f, 50.4f, 1f);
			}
		}
	}

	public void room7_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(6.79f, 59.37f, 1f);
		}
	}

	public void room7_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 17)
			{
				Actanim.transform.localPosition = new Vector3(29.1f, -41f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(12.5f, -36.9f, 1f);
			}
		}
	}

	public void room8_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(71.4f, -35.4f, 1f);
		}
	}

	public void room8_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(35.92f, 76.31f, 1f);
		}
	}

	public void room8_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-92.2f, 75.8f, 1f);
		}
	}

	public void room8_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 20)
			{
				Actanim.transform.localPosition = new Vector3(-139.45f, 55.29f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-138.3f, 56.4f, 1f);
			}
		}
	}

	public void room8_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(48f, 62.5f, 1f);
		}
	}

	public void room8_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 20 || FurnCont.Toilet_N == 23)
			{
				Actanim.transform.localPosition = new Vector3(6.8f, -58.16f, 1f);
			}
			if (FurnCont.Toilet_N == 21 || FurnCont.Toilet_N == 22)
			{
				Actanim.transform.localPosition = new Vector3(6.8f, -59.2f, 1f);
			}
		}
	}

	public void room8_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 20 || FurnCont.Kitchen_N == 23)
			{
				Actanim.transform.localPosition = new Vector3(-111.74f, -25.81f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-102.51f, -25.81f, 1f);
			}
		}
	}

	public void room9_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-26.2f, 40.1f, 1f);
		}
	}

	public void room9_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-51.8f, 100.9f, 1f);
		}
	}

	public void room9_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 23 || FurnCont.Bed_N == 24)
			{
				Actanim.transform.localPosition = new Vector3(-128.84f, 25.18f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-119.18f, 25.18f, 1f);
			}
		}
	}

	public void room9_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-174.92f, 9.69f, 1f);
		}
	}

	public void room9_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-33.27f, 92.96f, 1f);
		}
	}

	public void room9_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 23)
			{
				Actanim.transform.localPosition = new Vector3(29.6f, -3.8f, 1f);
			}
			if (FurnCont.Toilet_N == 24)
			{
				Actanim.transform.localPosition = new Vector3(35.2f, -5.9f, 1f);
			}
			if (FurnCont.Toilet_N == 25)
			{
				Actanim.transform.localPosition = new Vector3(35.7f, -6.96f, 1f);
			}
			if (FurnCont.Toilet_N == 26)
			{
				Actanim.transform.localPosition = new Vector3(44.9f, -5.9f, 1f);
			}
		}
	}

	public void room9_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-144.4f, 78.5f, 1f);
		}
	}

	public void room10_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-201.3f, 55.3f, 1f);
		}
	}

	public void room10_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 26)
			{
				Actanim.transform.localPosition = new Vector3(-86.9f, 103.9f, 1f);
			}
			if (FurnCont.Kitchen_N == 27)
			{
				Actanim.transform.localPosition = new Vector3(-103f, 103.9f, 1f);
			}
			if (FurnCont.Kitchen_N == 28)
			{
				Actanim.transform.localPosition = new Vector3(-98.6f, 101.9f, 1f);
			}
			if (FurnCont.Kitchen_N == 29)
			{
				Actanim.transform.localPosition = new Vector3(-103.6f, 102.5f, 1f);
			}
		}
	}

	public void room10_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(79.28f, 96.2f, 1f);
		}
	}

	public void room10_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			Actanim.transform.localPosition = new Vector3(23.5f, 32.6f, 1f);
		}
	}

	public void room10_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-56.24f, 89.16f, 1f);
		}
	}

	public void room10_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 26)
			{
				Actanim.transform.localPosition = new Vector3(-123.1f, -37.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-134.6f, -39.1f, 1f);
			}
		}
	}

	public void room10_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-84f, 26.3f, 1f);
		}
	}

	public void room11_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(12.5f, 111.8f, 1f);
		}
	}

	public void room11_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-191.8f, 109.1f, 1f);
		}
	}

	public void room11_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(33.2f, -36.1f, 1f);
		}
	}

	public void room11_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 29)
			{
				Actanim.transform.localPosition = new Vector3(-59.1f, -54.6f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-60.1f, -54.6f, 1f);
			}
		}
	}

	public void room11_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 29)
			{
				Actanim.transform.localPosition = new Vector3(40.93f, 67.53f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(36.3f, 69.3f, 1f);
			}
		}
	}

	public void room11_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 32)
			{
				Actanim.transform.localPosition = new Vector3(-164.4f, 15.84f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-156.14f, 15.84f, 1f);
			}
		}
	}

	public void room12_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 32)
			{
				Actanim.transform.localPosition = new Vector3(76f, 119.5f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(103f, 119.5f, 1f);
			}
		}
	}

	public void room12_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-190.1f, 72.1f, 1f);
		}
	}

	public void room12_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 32)
			{
				Actanim.transform.localPosition = new Vector3(-31.4f, 37f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-16.2f, 37f, 1f);
			}
		}
	}

	public void room12_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 32)
			{
				Actanim.transform.localPosition = new Vector3(86.21f, -5.53f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(76.77f, -3.7f, 1f);
			}
		}
	}

	public void room12_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 32)
			{
				Actanim.transform.localPosition = new Vector3(90.38f, 61.98f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(90.38f, 66.4f, 1f);
			}
		}
	}

	public void room12_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-177.9f, -24.6f, 1f);
		}
	}

	public void room13_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(103.4f, 111.6f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(97f, 110.1f, 1f);
			}
		}
	}

	public void room13_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(-95.8f, 107.3f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-97.1f, 101.4f, 1f);
			}
		}
	}

	public void room13_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(48.7f, -24.5f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(39.37f, -21.8f, 1f);
			}
		}
	}

	public void room13_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(94.6f, -79.3f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(66.7f, -73.3f, 1f);
			}
		}
	}

	public void room13_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(90.6f, 70.4f, 1f);
			}
			if (FurnCont.Toilet_N == 36 || FurnCont.Toilet_N == 37)
			{
				Actanim.transform.localPosition = new Vector3(87.2f, 68.9f, 1f);
			}
			if (FurnCont.Toilet_N == 38)
			{
				Actanim.transform.localPosition = new Vector3(88.4f, 69.9f, 1f);
			}
		}
	}

	public void room13_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 35)
			{
				Actanim.transform.localPosition = new Vector3(-181f, 37f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-172.9f, 46.3f, 1f);
			}
		}
	}

	public void room14_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(100.8f, 3.4f, 1f);
		}
	}

	public void room14_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(-196.9f, 110.1f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-194.7f, 110.1f, 1f);
			}
		}
	}

	public void room14_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 38)
			{
				Actanim.transform.localPosition = new Vector3(28.9f, 114.8f, 1f);
			}
			if (FurnCont.Bed_N == 39)
			{
				Actanim.transform.localPosition = new Vector3(27.6f, 110.2f, 1f);
			}
			if (FurnCont.Bed_N == 40)
			{
				Actanim.transform.localPosition = new Vector3(58.9f, 109.7f, 1f);
			}
			if (FurnCont.Bed_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(56.39f, 108f, 1f);
			}
		}
	}

	public void room14_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 38)
			{
				Actanim.transform.localPosition = new Vector3(63.6f, 56.1f, 1f);
			}
			if (FurnCont.Bed_N == 39 || FurnCont.Bed_N == 40)
			{
				Actanim.transform.localPosition = new Vector3(66.4f, 52.4f, 1f);
			}
			if (FurnCont.Bed_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(66.4f, 51.3f, 1f);
			}
		}
	}

	public void room14_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 38)
			{
				Actanim.transform.localPosition = new Vector3(54.5f, -37.9f, 1f);
			}
			if (FurnCont.Toilet_N == 39)
			{
				Actanim.transform.localPosition = new Vector3(65.1f, -13.5f, 1f);
			}
			if (FurnCont.Toilet_N == 40 || FurnCont.Toilet_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(64f, -15.3f, 1f);
			}
		}
	}

	public void room14_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 38)
			{
				Actanim.transform.localPosition = new Vector3(-125f, -4.66f, 1f);
			}
			if (FurnCont.Kitchen_N == 39)
			{
				Actanim.transform.localPosition = new Vector3(-127.2f, -10.08f, 1f);
			}
			if (FurnCont.Kitchen_N == 40)
			{
				Actanim.transform.localPosition = new Vector3(-131.3f, -10.41f, 1f);
			}
			if (FurnCont.Kitchen_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(-131.3f, -5f, 1f);
			}
		}
	}

	public void room15_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(99.1f, 20.3f, 1f);
		}
	}

	public void room15_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-168.6f, 107f, 1f);
		}
	}

	public void room15_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(61.9f, 107.5f, 1f);
			}
			if (FurnCont.Bed_N == 42)
			{
				Actanim.transform.localPosition = new Vector3(62.49f, 104.6f, 1f);
			}
			if (FurnCont.Bed_N == 43)
			{
				Actanim.transform.localPosition = new Vector3(57.9f, 105.6f, 1f);
			}
			if (FurnCont.Bed_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(58f, 102.7f, 1f);
			}
		}
	}

	public void room15_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(-9.1f, 64.8f, 1f);
			}
			if (FurnCont.Bed_N == 42)
			{
				Actanim.transform.localPosition = new Vector3(-21.1f, 74.8f, 1f);
			}
			if (FurnCont.Bed_N == 43 || FurnCont.Bed_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(-21.1f, 73.9f, 1f);
			}
		}
	}

	public void room15_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(63.5f, 0.6f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(41f, -3.6f, 1f);
			}
		}
	}

	public void room15_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 41)
			{
				Actanim.transform.localPosition = new Vector3(-125.8f, -7.9f, 1f);
			}
			if (FurnCont.Kitchen_N == 42)
			{
				Actanim.transform.localPosition = new Vector3(-125.8f, -10.6f, 1f);
			}
			if (FurnCont.Kitchen_N == 43)
			{
				Actanim.transform.localPosition = new Vector3(-126.5f, -14.8f, 1f);
			}
			if (FurnCont.Kitchen_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(-133.7f, -13.6f, 1f);
			}
		}
	}

	public void room16_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			Actanim.transform.localPosition = new Vector3(101.6f, -1.6f, 1f);
		}
	}

	public void room16_kitchen()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 2;
			Setanim();
			if (FurnCont.Kitchen_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(-182.4f, 88.8f, 1f);
			}
		}
	}

	public void room16_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-139.7f, 91.6f, 1f);
		}
	}

	public void room16_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(64.54f, 95f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(92.6f, 88.7f, 1f);
			}
		}
	}

	public void room16_desk()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			if (FurnCont.Bed_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(6.8f, 24.6f, 1f);
			}
		}
	}

	public void room16_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(42.8f, -53.9f, 1f);
			}
			if (FurnCont.Toilet_N == 45)
			{
				Actanim.transform.localPosition = new Vector3(31f, -86f, 1f);
			}
			if (FurnCont.Toilet_N == 46)
			{
				Actanim.transform.localPosition = new Vector3(31f, -86f, 1f);
			}
			if (FurnCont.Toilet_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(31f, -86.97f, 1f);
			}
		}
	}

	public void room16_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 44)
			{
				Actanim.transform.localPosition = new Vector3(-131.5f, -38f, 1f);
			}
			if (FurnCont.Kitchen_N == 45)
			{
				Actanim.transform.localPosition = new Vector3(-141.3f, -35f, 1f);
			}
			if (FurnCont.Kitchen_N == 46)
			{
				Actanim.transform.localPosition = new Vector3(-139f, -32.8f, 1f);
			}
			if (FurnCont.Kitchen_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(-141f, -35f, 1f);
			}
		}
	}

	public void room17_toilet()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 1;
			Setanim();
			if (FurnCont.Toilet_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(38.5f, 110.5f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(25.8f, 113.8f, 1f);
			}
		}
	}

	public void room17_table()
	{
		if (BarCont.mp < BarCont.mp_Maxpoint)
		{
			Actingchar.Acting_N = 5;
			Setanim();
			if (FurnCont.Kitchen_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(43.1f, 30.4f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(34.61f, 15.64f, 1f);
			}
		}
	}

	public void room17_bed()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			if (FurnCont.Bed_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(-93.9f, 59.9f, 1f);
			}
			else
			{
				Actanim.transform.localPosition = new Vector3(-91.8f, 38.5f, 1f);
			}
		}
	}

	public void room17_bed2()
	{
		if (BarCont.hp < BarCont.hp_Maxpoint)
		{
			Actingchar.Acting_N = 3;
			Setanim();
			Actanim.transform.localPosition = new Vector3(61.1f, -79.7f, 1f);
		}
	}

	public void room17_waterpool()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 4;
			Setanim();
			Actanim.transform.localPosition = new Vector3(-28f, -49.6f, 1f);
		}
	}

	public void room17_bath()
	{
		if (BarCont._int < BarCont.int_Maxpoint)
		{
			Actingchar.Acting_N = 6;
			Setanim();
			if (FurnCont.Toilet_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(-20f, 95f, 1f);
			}
			if (FurnCont.Toilet_N == 48)
			{
				Actanim.transform.localPosition = new Vector3(-34.2f, 93.8f, 1f);
			}
			if (FurnCont.Toilet_N >= 49)
			{
				Actanim.transform.localPosition = new Vector3(-25.8f, 93.8f, 1f);
			}
		}
	}

	public void room17_tv()
	{
		if (BarCont.happy < BarCont.happy_Maxpoint)
		{
			Actingchar.Acting_N = 7;
			Setanim();
			if (FurnCont.Kitchen_N == 47)
			{
				Actanim.transform.localPosition = new Vector3(-128.7f, -31.9f, 1f);
			}
			if (FurnCont.Kitchen_N == 48)
			{
				Actanim.transform.localPosition = new Vector3(-116.9f, -32.6f, 1f);
			}
			if (FurnCont.Kitchen_N == 49)
			{
				Actanim.transform.localPosition = new Vector3(-116.9f, -32.6f, 1f);
			}
			if (FurnCont.Kitchen_N == 50)
			{
				Actanim.transform.localPosition = new Vector3(-122.92f, -33.58f, 1f);
			}
		}
	}
}
