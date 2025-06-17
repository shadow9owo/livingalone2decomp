using UnityEngine;
using UnityEngine.UI;

public class s2_2 : MonoBehaviour
{
	public scene_controll scene_controll;

	public Image[] img;

	public Image[] Window;

	public GameObject go_s2_2;

	public Transform sadending_text_ch;

	public Transform sadending_img_ch;

	public Transform _DeathCount;

	public GameObject[] Suddendeathmoney_T;

	private int Endingplusmoney;

	private void Start()
	{
		SuddenDeathCont.Death_Count = PlayerPrefs.GetInt("Death_Count");
		_DeathCount.GetComponent<Text>().text = string.Format("{0}/89", SuddenDeathCont.Death_Count);
		SuddenDeathCont.Death_1F = PlayerPrefs.GetInt("Death_1");
		SuddenDeathCont.Death_2F = PlayerPrefs.GetInt("Death_2");
		SuddenDeathCont.Death_3F = PlayerPrefs.GetInt("Death_3");
		SuddenDeathCont.Death_4F = PlayerPrefs.GetInt("Death_4");
		SuddenDeathCont.Death_5F = PlayerPrefs.GetInt("Death_5");
		SuddenDeathCont.Death_6F = PlayerPrefs.GetInt("Death_6");
		SuddenDeathCont.Death_7F = PlayerPrefs.GetInt("Death_7");
		SuddenDeathCont.Death_8F = PlayerPrefs.GetInt("Death_8");
		SuddenDeathCont.Death_9F = PlayerPrefs.GetInt("Death_9");
		SuddenDeathCont.Death_10F = PlayerPrefs.GetInt("Death_10");
		SuddenDeathCont.Death_11F = PlayerPrefs.GetInt("Death_11");
		SuddenDeathCont.Death_12F = PlayerPrefs.GetInt("Death_12");
		SuddenDeathCont.Death_13F = PlayerPrefs.GetInt("Death_13");
		SuddenDeathCont.Death_14F = PlayerPrefs.GetInt("Death_14");
		SuddenDeathCont.Death_15F = PlayerPrefs.GetInt("Death_15");
		SuddenDeathCont.Death_16F = PlayerPrefs.GetInt("Death_16");
		SuddenDeathCont.Death_17F = PlayerPrefs.GetInt("Death_17");
		SuddenDeathCont.Death_18F = PlayerPrefs.GetInt("Death_18");
		SuddenDeathCont.Death_19F = PlayerPrefs.GetInt("Death_19");
		SuddenDeathCont.Death_20F = PlayerPrefs.GetInt("Death_20");
		SuddenDeathCont.Death_21F = PlayerPrefs.GetInt("Death_21");
		SuddenDeathCont.Death_22F = PlayerPrefs.GetInt("Death_22");
		SuddenDeathCont.Death_23F = PlayerPrefs.GetInt("Death_23");
		SuddenDeathCont.Death_24F = PlayerPrefs.GetInt("Death_24");
		SuddenDeathCont.Death_25F = PlayerPrefs.GetInt("Death_25");
		SuddenDeathCont.Death_26F = PlayerPrefs.GetInt("Death_26");
		SuddenDeathCont.Death_27F = PlayerPrefs.GetInt("Death_27");
		SuddenDeathCont.Death_28F = PlayerPrefs.GetInt("Death_28");
		SuddenDeathCont.Death_29F = PlayerPrefs.GetInt("Death_29");
		SuddenDeathCont.Death_30F = PlayerPrefs.GetInt("Death_30");
		SuddenDeathCont.Death_31F = PlayerPrefs.GetInt("Death_31");
		SuddenDeathCont.Death_32F = PlayerPrefs.GetInt("Death_32");
		SuddenDeathCont.Death_33F = PlayerPrefs.GetInt("Death_33");
		SuddenDeathCont.Death_34F = PlayerPrefs.GetInt("Death_34");
		SuddenDeathCont.Death_35F = PlayerPrefs.GetInt("Death_35");
		SuddenDeathCont.Death_36F = PlayerPrefs.GetInt("Death_36");
		SuddenDeathCont.Death_37F = PlayerPrefs.GetInt("Death_37");
		SuddenDeathCont.Death_38F = PlayerPrefs.GetInt("Death_38");
		SuddenDeathCont.Death_39F = PlayerPrefs.GetInt("Death_39");
		SuddenDeathCont.Death_40F = PlayerPrefs.GetInt("Death_40");
		SuddenDeathCont.Death_41F = PlayerPrefs.GetInt("Death_41");
		SuddenDeathCont.Death_42F = PlayerPrefs.GetInt("Death_42");
		SuddenDeathCont.Death_43F = PlayerPrefs.GetInt("Death_43");
		SuddenDeathCont.Death_44F = PlayerPrefs.GetInt("Death_44");
		SuddenDeathCont.Death_45F = PlayerPrefs.GetInt("Death_45");
		SuddenDeathCont.Death_46F = PlayerPrefs.GetInt("Death_46");
		SuddenDeathCont.Death_47F = PlayerPrefs.GetInt("Death_47");
		SuddenDeathCont.Death_48F = PlayerPrefs.GetInt("Death_48");
		SuddenDeathCont.Death_49F = PlayerPrefs.GetInt("Death_49");
		SuddenDeathCont.Death_50F = PlayerPrefs.GetInt("Death_50");
		SuddenDeathCont.Death_51F = PlayerPrefs.GetInt("Death_51");
		SuddenDeathCont.Death_52F = PlayerPrefs.GetInt("Death_52");
		SuddenDeathCont.Death_53F = PlayerPrefs.GetInt("Death_53");
		SuddenDeathCont.Death_54F = PlayerPrefs.GetInt("Death_54");
		SuddenDeathCont.Death_55F = PlayerPrefs.GetInt("Death_55");
		SuddenDeathCont.Death_56F = PlayerPrefs.GetInt("Death_56");
		SuddenDeathCont.Death_57F = PlayerPrefs.GetInt("Death_57");
		SuddenDeathCont.Death_58F = PlayerPrefs.GetInt("Death_58");
		SuddenDeathCont.Death_59F = PlayerPrefs.GetInt("Death_59");
		SuddenDeathCont.AlbaDeath_1F = PlayerPrefs.GetInt("AlbaDeath_1");
		SuddenDeathCont.AlbaDeath_2F = PlayerPrefs.GetInt("AlbaDeath_2");
		SuddenDeathCont.AlbaDeath_3F = PlayerPrefs.GetInt("AlbaDeath_3");
		SuddenDeathCont.AlbaDeath_4F = PlayerPrefs.GetInt("AlbaDeath_4");
		SuddenDeathCont.AlbaDeath_5F = PlayerPrefs.GetInt("AlbaDeath_5");
		SuddenDeathCont.AlbaDeath_6F = PlayerPrefs.GetInt("AlbaDeath_6");
		SuddenDeathCont.AlbaDeath_7F = PlayerPrefs.GetInt("AlbaDeath_7");
		SuddenDeathCont.AlbaDeath_8F = PlayerPrefs.GetInt("AlbaDeath_8");
		SuddenDeathCont.AlbaDeath_9F = PlayerPrefs.GetInt("AlbaDeath_9");
		SuddenDeathCont.AlbaDeath_10F = PlayerPrefs.GetInt("AlbaDeath_10");
		SuddenDeathCont.AlbaDeath_11F = PlayerPrefs.GetInt("AlbaDeath_11");
		SuddenDeathCont.AlbaDeath_12F = PlayerPrefs.GetInt("AlbaDeath_12");
		SuddenDeathCont.AlbaDeath_13F = PlayerPrefs.GetInt("AlbaDeath_13");
		SuddenDeathCont.AlbaDeath_14F = PlayerPrefs.GetInt("AlbaDeath_14");
		SuddenDeathCont.AlbaDeath_15F = PlayerPrefs.GetInt("AlbaDeath_15");
		SuddenDeathCont.AlbaDeath_16F = PlayerPrefs.GetInt("AlbaDeath_16");
		SuddenDeathCont.AlbaDeath_17F = PlayerPrefs.GetInt("AlbaDeath_17");
		SuddenDeathCont.AlbaDeath_18F = PlayerPrefs.GetInt("AlbaDeath_18");
		SuddenDeathCont.AlbaDeath_19F = PlayerPrefs.GetInt("AlbaDeath_19");
		SuddenDeathCont.AlbaDeath_20F = PlayerPrefs.GetInt("AlbaDeath_20");
		SuddenDeathCont.AlbaDeath_21F = PlayerPrefs.GetInt("AlbaDeath_21");
		SuddenDeathCont.AlbaDeath_22F = PlayerPrefs.GetInt("AlbaDeath_22");
		SuddenDeathCont.AlbaDeath_23F = PlayerPrefs.GetInt("AlbaDeath_23");
		SuddenDeathCont.AlbaDeath_24F = PlayerPrefs.GetInt("AlbaDeath_24");
		SuddenDeathCont.AlbaDeath_25F = PlayerPrefs.GetInt("AlbaDeath_25");
		SuddenDeathCont.AlbaDeath_26F = PlayerPrefs.GetInt("AlbaDeath_26");
		SuddenDeathCont.AlbaDeath_27F = PlayerPrefs.GetInt("AlbaDeath_27");
		SuddenDeathCont.AlbaDeath_28F = PlayerPrefs.GetInt("AlbaDeath_28");
		SuddenDeathCont.AlbaDeath_29F = PlayerPrefs.GetInt("AlbaDeath_29");
		SuddenDeathCont.AlbaDeath_30F = PlayerPrefs.GetInt("AlbaDeath_30");
		SuddenDeathCont.AlbaDeath_31F = PlayerPrefs.GetInt("AlbaDeath_31");
		for (int i = 0; i < img.Length; i++)
		{
			img[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("frame4");
		}
		for (int j = 0; j < Window.Length; j++)
		{
			Window[j].color = Color.grey;
		}
		Endingplusmoney_sum();
		for (int k = 0; k < Suddendeathmoney_T.Length; k++)
		{
			Suddendeathmoney_T[k].GetComponent<Text>().text = string.Format("{0:n0}", Endingplusmoney);
		}
		SetImage();
	}

	public void Endingplusmoney_sum()
	{
		RoomCont.Room_N = PlayerPrefs.GetInt("Room_N");
		if (RoomCont.Room_N == 1)
		{
			Endingplusmoney = 10000;
		}
		if (RoomCont.Room_N == 2)
		{
			Endingplusmoney = 17500;
		}
		if (RoomCont.Room_N == 3)
		{
			Endingplusmoney = 20000;
		}
		if (RoomCont.Room_N == 4)
		{
			Endingplusmoney = 25000;
		}
		if (RoomCont.Room_N == 5)
		{
			Endingplusmoney = 27500;
		}
		if (RoomCont.Room_N == 6)
		{
			Endingplusmoney = 30000;
		}
		if (RoomCont.Room_N == 7)
		{
			Endingplusmoney = 35000;
		}
		if (RoomCont.Room_N == 8)
		{
			Endingplusmoney = 50000;
		}
		if (RoomCont.Room_N == 9)
		{
			Endingplusmoney = 100000;
		}
		if (RoomCont.Room_N == 10)
		{
			Endingplusmoney = 150000;
		}
		if (RoomCont.Room_N == 11)
		{
			Endingplusmoney = 250000;
		}
		if (RoomCont.Room_N == 12)
		{
			Endingplusmoney = 400000;
		}
		if (RoomCont.Room_N == 13)
		{
			Endingplusmoney = 750000;
		}
		if (RoomCont.Room_N == 14)
		{
			Endingplusmoney = 1250000;
		}
		if (RoomCont.Room_N == 15)
		{
			Endingplusmoney = 2500000;
		}
		if (RoomCont.Room_N == 16)
		{
			Endingplusmoney = 5000000;
		}
		if (RoomCont.Room_N == 17)
		{
			Endingplusmoney = 10000000;
		}
	}

	public void back()
	{
	}

	public void SetImage()
	{
		Debug.LogFormat("SuddenDeathCont.Death_6F{0}", SuddenDeathCont.Death_6F);
		Debug.LogFormat("SuddenDeathCont.Death_7F{0}", SuddenDeathCont.Death_7F);
		if (SuddenDeathCont.Death_14F == 1)
		{
			img[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_1");
			Window[1].color = Color.white;
		}
		if (SuddenDeathCont.Death_23F == 1)
		{
			img[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_2");
			Window[2].color = Color.white;
		}
		if (SuddenDeathCont.Death_16F == 1)
		{
			img[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_3");
			Window[3].color = Color.white;
		}
		if (SuddenDeathCont.Death_1F == 1)
		{
			img[4].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_4");
			Window[4].color = Color.white;
		}
		if (SuddenDeathCont.Death_2F == 1)
		{
			img[5].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_5");
			Window[5].color = Color.white;
		}
		if (SuddenDeathCont.Death_7F == 1)
		{
			img[6].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_6");
			Window[6].color = Color.white;
		}
		if (SuddenDeathCont.Death_38F == 1)
		{
			img[7].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_7");
			Window[7].color = Color.white;
		}
		if (SuddenDeathCont.Death_19F == 1)
		{
			img[8].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_8");
			Window[8].color = Color.white;
		}
		if (SuddenDeathCont.Death_4F == 1)
		{
			img[13].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_13");
			Window[13].color = Color.white;
		}
		if (SuddenDeathCont.Death_33F == 1)
		{
			img[14].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_14");
			Window[14].color = Color.white;
		}
		if (SuddenDeathCont.Death_10F == 1)
		{
			img[15].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_15");
			Window[15].color = Color.white;
		}
		if (SuddenDeathCont.Death_39F == 1)
		{
			img[16].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_16");
			Window[16].color = Color.white;
		}
		if (SuddenDeathCont.Death_26F == 1)
		{
			img[20].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_20");
			Window[20].color = Color.white;
		}
		if (SuddenDeathCont.Death_31F == 1)
		{
			img[21].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_21");
			Window[21].color = Color.white;
		}
		if (SuddenDeathCont.Death_9F == 1)
		{
			img[22].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_22");
			Window[22].color = Color.white;
		}
		if (SuddenDeathCont.Death_18F == 1)
		{
			img[23].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_23");
			Window[23].color = Color.white;
		}
		if (SuddenDeathCont.Death_20F == 1)
		{
			img[24].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_24");
			Window[24].color = Color.white;
		}
		if (SuddenDeathCont.Death_13F == 1)
		{
			img[28].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_28");
			Window[28].color = Color.white;
		}
		if (SuddenDeathCont.Death_22F == 1)
		{
			img[29].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_29");
			Window[29].color = Color.white;
		}
		if (SuddenDeathCont.Death_5F == 1)
		{
			img[30].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_30");
			Window[30].color = Color.white;
		}
		if (SuddenDeathCont.Death_24F == 1)
		{
			img[31].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_31");
			Window[31].color = Color.white;
		}
		if (SuddenDeathCont.Death_41F == 1)
		{
			img[32].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_32");
			Window[32].color = Color.white;
		}
		if (SuddenDeathCont.Death_47F == 1)
		{
			img[33].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_33");
			Window[33].color = Color.white;
		}
		if (SuddenDeathCont.Death_35F == 1)
		{
			img[37].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_37");
			Window[37].color = Color.white;
		}
		if (SuddenDeathCont.Death_3F == 1)
		{
			img[38].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_38");
			Window[38].color = Color.white;
		}
		if (SuddenDeathCont.Death_27F == 1)
		{
			img[39].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_39");
			Window[39].color = Color.white;
		}
		if (SuddenDeathCont.Death_6F == 1)
		{
			img[40].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_40");
			Window[40].color = Color.white;
		}
		if (SuddenDeathCont.Death_12F == 1)
		{
			img[41].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_41");
			Window[41].color = Color.white;
		}
		if (SuddenDeathCont.Death_17F == 1)
		{
			img[45].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_45");
			Window[45].color = Color.white;
		}
		if (SuddenDeathCont.Death_29F == 1)
		{
			img[46].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_46");
			Window[46].color = Color.white;
		}
		if (SuddenDeathCont.Death_36F == 1)
		{
			img[47].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_47");
			Window[47].color = Color.white;
		}
		if (SuddenDeathCont.Death_28F == 1)
		{
			img[48].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_48");
			Window[48].color = Color.white;
		}
		if (SuddenDeathCont.Death_44F == 1)
		{
			img[49].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_49");
			Window[49].color = Color.white;
		}
		if (SuddenDeathCont.Death_25F == 1)
		{
			img[50].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_50");
			Window[50].color = Color.white;
		}
		if (SuddenDeathCont.Death_52F == 1)
		{
			img[54].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_54");
			Window[54].color = Color.white;
		}
		if (SuddenDeathCont.Death_58F == 1)
		{
			img[55].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_55");
			Window[55].color = Color.white;
		}
		if (SuddenDeathCont.Death_51F == 1)
		{
			img[56].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_56");
			Window[56].color = Color.white;
		}
		if (SuddenDeathCont.Death_54F == 1)
		{
			img[57].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_57");
			Window[57].color = Color.white;
		}
		if (SuddenDeathCont.Death_11F == 1)
		{
			img[58].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_58");
			Window[58].color = Color.white;
		}
		if (SuddenDeathCont.Death_15F == 1)
		{
			img[59].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_59");
			Window[59].color = Color.white;
		}
		if (SuddenDeathCont.Death_48F == 1)
		{
			img[60].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_60");
			Window[60].color = Color.white;
		}
		if (SuddenDeathCont.Death_30F == 1)
		{
			img[64].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_64");
			Window[64].color = Color.white;
		}
		if (SuddenDeathCont.Death_32F == 1)
		{
			img[65].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_65");
			Window[65].color = Color.white;
		}
		if (SuddenDeathCont.Death_55F == 1)
		{
			img[66].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_66");
			Window[66].color = Color.white;
		}
		if (SuddenDeathCont.Death_34F == 1)
		{
			img[67].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_67");
			Window[67].color = Color.white;
		}
		if (SuddenDeathCont.Death_21F == 1)
		{
			img[68].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_68");
			Window[68].color = Color.white;
		}
		if (SuddenDeathCont.Death_45F == 1)
		{
			img[69].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_69");
			Window[69].color = Color.white;
		}
		if (SuddenDeathCont.Death_37F == 1)
		{
			img[73].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_73");
			Window[73].color = Color.white;
		}
		if (SuddenDeathCont.Death_50F == 1)
		{
			img[74].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_74");
			Window[74].color = Color.white;
		}
		if (SuddenDeathCont.Death_56F == 1)
		{
			img[75].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_75");
			Window[75].color = Color.white;
		}
		if (SuddenDeathCont.Death_46F == 1)
		{
			img[76].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_76");
			Window[76].color = Color.white;
		}
		if (SuddenDeathCont.Death_43F == 1)
		{
			img[77].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_77");
			Window[77].color = Color.white;
		}
		if (SuddenDeathCont.Death_42F == 1)
		{
			img[78].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_78");
			Window[78].color = Color.white;
		}
		if (SuddenDeathCont.Death_59F == 1)
		{
			img[82].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_82");
			Window[82].color = Color.white;
		}
		if (SuddenDeathCont.Death_57F == 1)
		{
			img[83].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_83");
			Window[83].color = Color.white;
		}
		if (SuddenDeathCont.Death_53F == 1)
		{
			img[84].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_84");
			Window[84].color = Color.white;
		}
		if (SuddenDeathCont.Death_49F == 1)
		{
			img[88].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_88");
			Window[88].color = Color.white;
		}
		if (SuddenDeathCont.Death_40F == 1)
		{
			img[89].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_89");
			Window[89].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_19F == 1)
		{
			img[9].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_9");
			Window[9].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_18F == 1)
		{
			img[10].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_10");
			Window[10].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_13F == 1)
		{
			img[11].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_11");
			Window[11].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_29F == 1)
		{
			img[12].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_12");
			Window[12].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_1F == 1)
		{
			img[17].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_17");
			Window[17].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_21F == 1)
		{
			img[18].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_18");
			Window[18].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_3F == 1)
		{
			img[19].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_19");
			Window[19].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_31F == 1)
		{
			img[25].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_25");
			Window[25].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_28F == 1)
		{
			img[26].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_26");
			Window[26].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_26F == 1)
		{
			img[27].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_27");
			Window[27].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_6F == 1)
		{
			img[34].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_34");
			Window[34].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_2F == 1)
		{
			img[35].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_35");
			Window[35].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_20F == 1)
		{
			img[36].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_36");
			Window[36].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_10F == 1)
		{
			img[42].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_42");
			Window[42].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_16F == 1)
		{
			img[43].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_43");
			Window[43].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_23F == 1)
		{
			img[44].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_44");
			Window[44].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_17F == 1)
		{
			img[51].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_51");
			Window[51].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_14F == 1)
		{
			img[52].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_52");
			Window[52].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_30F == 1)
		{
			img[53].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_53");
			Window[53].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_25F == 1)
		{
			img[61].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_61");
			Window[61].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_8F == 1)
		{
			img[62].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_62");
			Window[62].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_9F == 1)
		{
			img[63].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_63");
			Window[63].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_4F == 1)
		{
			img[70].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_70");
			Window[70].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_24F == 1)
		{
			img[71].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_71");
			Window[71].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_5F == 1)
		{
			img[72].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_72");
			Window[72].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_7F == 1)
		{
			img[79].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_79");
			Window[79].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_15F == 1)
		{
			img[80].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_80");
			Window[80].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_22F == 1)
		{
			img[81].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_81");
			Window[81].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_12F == 1)
		{
			img[86].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_86");
			Window[86].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_27F == 1)
		{
			img[87].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_87");
			Window[87].color = Color.white;
		}
		if (SuddenDeathCont.AlbaDeath_11F == 1)
		{
			img[85].GetComponent<Image>().sprite = Resources.Load<Sprite>("SadEnding/_85");
			Window[85].color = Color.white;
		}
	}
}
