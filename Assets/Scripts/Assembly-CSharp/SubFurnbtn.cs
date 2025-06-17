using UnityEngine;

public class SubFurnbtn : MonoBehaviour
{
	private GameObject furnbtn;

	private GameObject anim_japan;

	private GameObject suddendeath;

	private void Start()
	{
		furnbtn = GameObject.Find("ButtonController(study)/furnBtn");
		anim_japan = GameObject.Find("ROOM_pet_man");
		suddendeath = GameObject.Find("SuddenDeathCont");
	}

	public void HP()
	{
		furnbtn.GetComponent<FurnBtn>().Energy_HP_Button();
	}

	public void MP()
	{
		furnbtn.GetComponent<FurnBtn>().Hungry_Mp_Button();
	}

	public void MP_Table()
	{
		furnbtn.GetComponent<FurnBtn>().Hungry_MP_Table_Button();
	}

	public void INT()
	{
		furnbtn.GetComponent<FurnBtn>().Toilet_Int_Button();
	}

	public void INT_Bath()
	{
		furnbtn.GetComponent<FurnBtn>().Toilet_Int_bath_Button();
	}

	public void HAPPY()
	{
		furnbtn.GetComponent<FurnBtn>().Fun_Happy_Button();
	}

	public void HAPPY_TV()
	{
		furnbtn.GetComponent<FurnBtn>().Fun_Happy_TV_Button();
	}

	public void Bed()
	{
		HP();
		if (RoomCont.Room_N == 1)
		{
			anim_japan.GetComponent<Furnanim_japan>().room1_bed();
		}
		if (RoomCont.Room_N == 2)
		{
			anim_japan.GetComponent<Furnanim_japan>().room2_bed();
		}
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_bed();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_bed();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_bed();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_bed();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_bed();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_bed();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_bed();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_bed();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_bed();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_bed();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_bed();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_bed();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_bed();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_bed();
		}
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_bed();
		}
	}

	public void Bed2()
	{
		HP();
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_bed2();
		}
	}

	public void Kitchen()
	{
		MP();
		if (RoomCont.Room_N == 1)
		{
			anim_japan.GetComponent<Furnanim_japan>().room1_kitchen();
		}
		if (RoomCont.Room_N == 2)
		{
			anim_japan.GetComponent<Furnanim_japan>().room2_kitchen();
		}
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_kitchen();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_kitchen();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_kitchen();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_kitchen();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_kitchen();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_kitchen();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_kitchen();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_kitchen();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_kitchen();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_kitchen();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_kitchen();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_kitchen();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_kitchen();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_kitchen();
		}
	}

	public void Table()
	{
		MP_Table();
		if (RoomCont.Room_N == 1)
		{
			anim_japan.GetComponent<Furnanim_japan>().room1_table();
		}
		if (RoomCont.Room_N == 2)
		{
			anim_japan.GetComponent<Furnanim_japan>().room2_table();
		}
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_table();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_table();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_table();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_table();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_table();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_table();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_table();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_table();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_table();
		}
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_table();
		}
	}

	public void Toilet()
	{
		INT();
		if (RoomCont.Room_N == 1)
		{
			anim_japan.GetComponent<Furnanim_japan>().room1_toilet();
		}
		if (RoomCont.Room_N == 2)
		{
			anim_japan.GetComponent<Furnanim_japan>().room2_toilet();
		}
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_toilet();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_toilet();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_toilet();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_toilet();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_toilet();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_toilet();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_toilet();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_toilet();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_toilet();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_toilet();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_toilet();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_toilet();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_toilet();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_toilet();
		}
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_toilet();
		}
	}

	public void Bath()
	{
		INT_Bath();
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_bath();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_bath();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_bath();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_bath();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_bath();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_bath();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_bath();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_bath();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_bath();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_bath();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_bath();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_bath();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_bath();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_bath();
		}
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_bath();
		}
	}

	public void Desk()
	{
		HAPPY();
		if (RoomCont.Room_N == 1)
		{
			anim_japan.GetComponent<Furnanim_japan>().room1_desk();
		}
		if (RoomCont.Room_N == 2)
		{
			anim_japan.GetComponent<Furnanim_japan>().room2_desk();
		}
		if (RoomCont.Room_N == 3)
		{
			anim_japan.GetComponent<Furnanim_japan>().room3_desk();
		}
		if (RoomCont.Room_N == 4)
		{
			anim_japan.GetComponent<Furnanim_japan>().room4_desk();
		}
		if (RoomCont.Room_N == 5)
		{
			anim_japan.GetComponent<Furnanim_japan>().room5_desk();
		}
		if (RoomCont.Room_N == 6)
		{
			anim_japan.GetComponent<Furnanim_japan>().room6_desk();
		}
		if (RoomCont.Room_N == 7)
		{
			anim_japan.GetComponent<Furnanim_japan>().room7_desk();
		}
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_desk();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_desk();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_desk();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_desk();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_desk();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_desk();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_desk();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_desk();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_desk();
		}
	}

	public void Water_pool()
	{
		HAPPY();
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_waterpool();
		}
	}

	public void TV()
	{
		HAPPY_TV();
		if (RoomCont.Room_N == 8)
		{
			anim_japan.GetComponent<Furnanim_japan>().room8_tv();
		}
		if (RoomCont.Room_N == 9)
		{
			anim_japan.GetComponent<Furnanim_japan>().room9_tv();
		}
		if (RoomCont.Room_N == 10)
		{
			anim_japan.GetComponent<Furnanim_japan>().room10_tv();
		}
		if (RoomCont.Room_N == 11)
		{
			anim_japan.GetComponent<Furnanim_japan>().room11_tv();
		}
		if (RoomCont.Room_N == 12)
		{
			anim_japan.GetComponent<Furnanim_japan>().room12_tv();
		}
		if (RoomCont.Room_N == 13)
		{
			anim_japan.GetComponent<Furnanim_japan>().room13_tv();
		}
		if (RoomCont.Room_N == 14)
		{
			anim_japan.GetComponent<Furnanim_japan>().room14_tv();
		}
		if (RoomCont.Room_N == 15)
		{
			anim_japan.GetComponent<Furnanim_japan>().room15_tv();
		}
		if (RoomCont.Room_N == 16)
		{
			anim_japan.GetComponent<Furnanim_japan>().room16_tv();
		}
		if (RoomCont.Room_N == 17)
		{
			anim_japan.GetComponent<Furnanim_japan>().room17_tv();
		}
	}
}
