using UnityEngine;
using UnityEngine.UI;

public class s2_3 : MonoBehaviour
{
	public GameObject btn_back;

	public GameObject go_s2_3;

	public Transform[] Title_T;

	public Image[] img_2_2;

	public Image[] Window;

	public string[] Title;

	public static int Gradu_N0;

	public static int Gradu_N1;

	public static int Gradu_N2;

	public static int Gradu_N3;

	public static int Gradu_N4;

	public static int Gradu_N5;

	public static int Gradu_N6;

	public static int Gradu_N7;

	public static int Gradu_N8;

	public static int Gradu_N9;

	public static int Gradu_N10;

	public static int Gradu_N11;

	public static int Gradu_N12;

	public static int Gradu_N13;

	public static int Gradu_N14;

	public static int Gradu_N15;

	public static int Gradu_N16;

	public static int Gradu_N17;

	public static int Gradu_N18;

	public static int Gradu_N19;

	public static int Gradu_N20;

	public static int Gradu_N21;

	public static int Gradu_N22;

	public static int Gradu_N23;

	public static int Gradu_N24;

	public static int Gradu_N25;

	public static int Gradu_N26;

	public static int Gradu_N27;

	public static int Gradu_N28;

	public static int Gradu_N29;

	public static int Gradu_N30;

	public static int Gradu_N31;

	public static int Gradu_N32;

	public static int Gradu_N33;

	public static int Gradu_N34;

	public static int Gradu_N35;

	public static int Gradu_N36;

	public static int Gradu_N37;

	public static int Gradu_N38;

	public static int Gradu_N39;

	public static int Gradu_N40;

	public static int Gradu_N41;

	public Transform EndingCount;

	private void Start()
	{
		GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount");
		Gradu_N0 = PlayerPrefs.GetInt("Gradu_N0");
		Gradu_N1 = PlayerPrefs.GetInt("Gradu_N1");
		Gradu_N2 = PlayerPrefs.GetInt("Gradu_N2");
		Gradu_N4 = PlayerPrefs.GetInt("Gradu_N4");
		Gradu_N5 = PlayerPrefs.GetInt("Gradu_N5");
		Gradu_N6 = PlayerPrefs.GetInt("Gradu_N6");
		Gradu_N7 = PlayerPrefs.GetInt("Gradu_N7");
		Gradu_N8 = PlayerPrefs.GetInt("Gradu_N8");
		Gradu_N9 = PlayerPrefs.GetInt("Gradu_N9");
		Gradu_N10 = PlayerPrefs.GetInt("Gradu_N10");
		Gradu_N11 = PlayerPrefs.GetInt("Gradu_N11");
		Gradu_N12 = PlayerPrefs.GetInt("Gradu_N12");
		Gradu_N13 = PlayerPrefs.GetInt("Gradu_N13");
		Gradu_N14 = PlayerPrefs.GetInt("Gradu_N14");
		Gradu_N15 = PlayerPrefs.GetInt("Gradu_N15");
		Gradu_N16 = PlayerPrefs.GetInt("Gradu_N16");
		Gradu_N17 = PlayerPrefs.GetInt("Gradu_N17");
		Gradu_N18 = PlayerPrefs.GetInt("Gradu_N18");
		Gradu_N19 = PlayerPrefs.GetInt("Gradu_N19");
		Gradu_N20 = PlayerPrefs.GetInt("Gradu_N20");
		Gradu_N21 = PlayerPrefs.GetInt("Gradu_N21");
		Gradu_N22 = PlayerPrefs.GetInt("Gradu_N22");
		Gradu_N23 = PlayerPrefs.GetInt("Gradu_N23");
		Gradu_N24 = PlayerPrefs.GetInt("Gradu_N24");
		Gradu_N25 = PlayerPrefs.GetInt("Gradu_N25");
		Gradu_N26 = PlayerPrefs.GetInt("Gradu_N26");
		Gradu_N27 = PlayerPrefs.GetInt("Gradu_N27");
		Gradu_N28 = PlayerPrefs.GetInt("Gradu_N28");
		Gradu_N29 = PlayerPrefs.GetInt("Gradu_N29");
		Gradu_N30 = PlayerPrefs.GetInt("Gradu_N30");
		Gradu_N31 = PlayerPrefs.GetInt("Gradu_N31");
		Gradu_N32 = PlayerPrefs.GetInt("Gradu_N32");
		Gradu_N33 = PlayerPrefs.GetInt("Gradu_N33");
		Gradu_N34 = PlayerPrefs.GetInt("Gradu_N34");
		Gradu_N35 = PlayerPrefs.GetInt("Gradu_N35");
		Gradu_N36 = PlayerPrefs.GetInt("Gradu_N36");
		Gradu_N37 = PlayerPrefs.GetInt("Gradu_N37");
		Gradu_N38 = PlayerPrefs.GetInt("Gradu_N38");
		Gradu_N39 = PlayerPrefs.GetInt("Gradu_N39");
		Gradu_N40 = PlayerPrefs.GetInt("Gradu_N40");
		Gradu_N41 = PlayerPrefs.GetInt("Gradu_N41");
		for (int i = 0; i < img_2_2.Length; i++)
		{
			img_2_2[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("frame4");
			Title_T[i].GetComponent<Text>().text = Title[0];
		}
		for (int j = 0; j < Window.Length; j++)
		{
			Window[j].color = Color.grey;
		}
		EndingCount.GetComponent<Text>().text = string.Format("{0}/42", GraduateCont.EndingCount);
		setImage();
		SetTitle();
	}

	private void Update()
	{
		if (go_s2_3.activeSelf)
		{
			btn_back.SetActive(true);
		}
	}

	public void back()
	{
	}

	public void setImage()
	{
		if (Gradu_N0 == 1)
		{
			img_2_2[0].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_1");
			Window[0].color = Color.white;
		}
		if (Gradu_N1 == 1)
		{
			img_2_2[1].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_2");
			Window[1].color = Color.white;
		}
		if (Gradu_N2 == 1)
		{
			img_2_2[2].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_3");
			Window[2].color = Color.white;
		}
		if (Gradu_N4 == 1)
		{
			img_2_2[3].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_4");
			Window[3].color = Color.white;
		}
		if (Gradu_N5 == 1)
		{
			img_2_2[4].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_5");
			Window[4].color = Color.white;
		}
		if (Gradu_N6 == 1)
		{
			img_2_2[5].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_6");
			Window[5].color = Color.white;
		}
		if (Gradu_N7 == 1)
		{
			img_2_2[6].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_7");
			Window[6].color = Color.white;
		}
		if (Gradu_N8 == 1)
		{
			img_2_2[7].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_8");
			Window[7].color = Color.white;
		}
		if (Gradu_N9 == 1)
		{
			img_2_2[8].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_9");
			Window[8].color = Color.white;
		}
		if (Gradu_N10 == 1)
		{
			img_2_2[9].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_10");
			Window[9].color = Color.white;
		}
		if (Gradu_N11 == 1)
		{
			img_2_2[10].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_11");
			Window[10].color = Color.white;
		}
		if (Gradu_N12 == 1)
		{
			img_2_2[11].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_12");
			Window[11].color = Color.white;
		}
		if (Gradu_N13 == 1)
		{
			img_2_2[12].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_13");
			Window[12].color = Color.white;
		}
		if (Gradu_N14 == 1)
		{
			img_2_2[13].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_14");
			Window[13].color = Color.white;
		}
		if (Gradu_N15 == 1)
		{
			img_2_2[14].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_15");
			Window[14].color = Color.white;
		}
		if (Gradu_N16 == 1)
		{
			img_2_2[15].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_16");
			Window[15].color = Color.white;
		}
		if (Gradu_N17 == 1)
		{
			img_2_2[16].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_17");
			Window[16].color = Color.white;
		}
		if (Gradu_N18 == 1)
		{
			img_2_2[17].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_18");
			Window[17].color = Color.white;
		}
		if (Gradu_N19 == 1)
		{
			img_2_2[18].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_19");
			Window[18].color = Color.white;
		}
		if (Gradu_N20 == 1)
		{
			img_2_2[19].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_20");
			Window[19].color = Color.white;
		}
		if (Gradu_N21 == 1)
		{
			img_2_2[20].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_21");
			Window[20].color = Color.white;
		}
		if (Gradu_N22 == 1)
		{
			img_2_2[21].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_22");
			Window[21].color = Color.white;
		}
		if (Gradu_N23 == 1)
		{
			img_2_2[22].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_23");
			Window[22].color = Color.white;
		}
		if (Gradu_N24 == 1)
		{
			img_2_2[23].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_24");
			Window[23].color = Color.white;
		}
		if (Gradu_N25 == 1)
		{
			img_2_2[24].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_25");
			Window[24].color = Color.white;
		}
		if (Gradu_N26 == 1)
		{
			img_2_2[25].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_26");
			Window[25].color = Color.white;
		}
		if (Gradu_N28 == 1)
		{
			img_2_2[26].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_27");
			Window[26].color = Color.white;
		}
		if (Gradu_N29 == 1)
		{
			img_2_2[27].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_28");
			Window[27].color = Color.white;
		}
		if (Gradu_N30 == 1)
		{
			img_2_2[28].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_29");
			Window[28].color = Color.white;
		}
		if (Gradu_N32 == 1)
		{
			img_2_2[29].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_30");
			Window[29].color = Color.white;
		}
		if (Gradu_N33 == 1)
		{
			img_2_2[30].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_31");
			Window[30].color = Color.white;
		}
		if (Gradu_N34 == 1)
		{
			img_2_2[31].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_32");
			Window[31].color = Color.white;
		}
		if (Gradu_N35 == 1)
		{
			img_2_2[32].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_33");
			Window[32].color = Color.white;
		}
		if (Gradu_N36 == 1)
		{
			img_2_2[33].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_34");
			Window[33].color = Color.white;
		}
		if (Gradu_N37 == 1)
		{
			img_2_2[34].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_35");
			Window[34].color = Color.white;
		}
		if (Gradu_N38 == 1)
		{
			img_2_2[35].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_36");
			Window[35].color = Color.white;
		}
		if (Gradu_N39 == 1)
		{
			img_2_2[36].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_37");
			Window[36].color = Color.white;
		}
		if (Gradu_N40 == 1)
		{
			img_2_2[37].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_38");
			Window[37].color = Color.white;
		}
		if (Gradu_N41 == 1)
		{
			img_2_2[38].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_39");
			Window[38].color = Color.white;
		}
		if (Gradu_N31 == 1)
		{
			img_2_2[39].GetComponent<Image>().sprite = Resources.Load<Sprite>("RealEnding/_40");
			Window[39].color = Color.white;
		}
	}

	public void SetTitle()
	{
		if (Gradu_N0 == 1)
		{
			Title_T[0].GetComponent<Text>().text = string.Format("{0}", Title[1]);
		}
		if (Gradu_N1 == 1)
		{
			Title_T[1].GetComponent<Text>().text = string.Format("{0}", Title[2]);
		}
		if (Gradu_N2 == 1)
		{
			Title_T[2].GetComponent<Text>().text = string.Format("{0}", Title[3]);
		}
		if (Gradu_N4 == 1)
		{
			Title_T[3].GetComponent<Text>().text = string.Format("{0}", Title[4]);
		}
		if (Gradu_N5 == 1)
		{
			Title_T[4].GetComponent<Text>().text = string.Format("{0}", Title[5]);
		}
		if (Gradu_N6 == 1)
		{
			Title_T[5].GetComponent<Text>().text = string.Format("{0}", Title[6]);
		}
		if (Gradu_N7 == 1)
		{
			Title_T[6].GetComponent<Text>().text = string.Format("{0}", Title[7]);
		}
		if (Gradu_N8 == 1)
		{
			Title_T[7].GetComponent<Text>().text = string.Format("{0}", Title[8]);
		}
		if (Gradu_N9 == 1)
		{
			Title_T[8].GetComponent<Text>().text = string.Format("{0}", Title[9]);
		}
		if (Gradu_N10 == 1)
		{
			Title_T[9].GetComponent<Text>().text = string.Format("{0}", Title[10]);
		}
		if (Gradu_N11 == 1)
		{
			Title_T[10].GetComponent<Text>().text = string.Format("{0}", Title[11]);
		}
		if (Gradu_N12 == 1)
		{
			Title_T[11].GetComponent<Text>().text = string.Format("{0}", Title[12]);
		}
		if (Gradu_N13 == 1)
		{
			Title_T[12].GetComponent<Text>().text = string.Format("{0}", Title[13]);
		}
		if (Gradu_N14 == 1)
		{
			Title_T[13].GetComponent<Text>().text = string.Format("{0}", Title[14]);
		}
		if (Gradu_N15 == 1)
		{
			Title_T[14].GetComponent<Text>().text = string.Format("{0}", Title[15]);
		}
		if (Gradu_N16 == 1)
		{
			Title_T[15].GetComponent<Text>().text = string.Format("{0}", Title[16]);
		}
		if (Gradu_N17 == 1)
		{
			Title_T[16].GetComponent<Text>().text = string.Format("{0}", Title[17]);
		}
		if (Gradu_N18 == 1)
		{
			Title_T[17].GetComponent<Text>().text = string.Format("{0}", Title[18]);
		}
		if (Gradu_N19 == 1)
		{
			Title_T[18].GetComponent<Text>().text = string.Format("{0}", Title[19]);
		}
		if (Gradu_N20 == 1)
		{
			Title_T[19].GetComponent<Text>().text = string.Format("{0}", Title[20]);
		}
		if (Gradu_N21 == 1)
		{
			Title_T[20].GetComponent<Text>().text = string.Format("{0}", Title[21]);
		}
		if (Gradu_N22 == 1)
		{
			Title_T[21].GetComponent<Text>().text = string.Format("{0}", Title[22]);
		}
		if (Gradu_N23 == 1)
		{
			Title_T[22].GetComponent<Text>().text = string.Format("{0}", Title[23]);
		}
		if (Gradu_N24 == 1)
		{
			Title_T[23].GetComponent<Text>().text = string.Format("{0}", Title[24]);
		}
		if (Gradu_N25 == 1)
		{
			Title_T[24].GetComponent<Text>().text = string.Format("{0}", Title[25]);
		}
		if (Gradu_N26 == 1)
		{
			Title_T[25].GetComponent<Text>().text = string.Format("{0}", Title[26]);
		}
		if (Gradu_N28 == 1)
		{
			Title_T[26].GetComponent<Text>().text = string.Format("{0}", Title[27]);
		}
		if (Gradu_N29 == 1)
		{
			Title_T[27].GetComponent<Text>().text = string.Format("{0}", Title[28]);
		}
		if (Gradu_N30 == 1)
		{
			Title_T[28].GetComponent<Text>().text = string.Format("{0}", Title[29]);
		}
		if (Gradu_N32 == 1)
		{
			Title_T[29].GetComponent<Text>().text = string.Format("{0}", Title[30]);
		}
		if (Gradu_N33 == 1)
		{
			Title_T[30].GetComponent<Text>().text = string.Format("{0}", Title[31]);
		}
		if (Gradu_N34 == 1)
		{
			Title_T[31].GetComponent<Text>().text = string.Format("{0}", Title[32]);
		}
		if (Gradu_N35 == 1)
		{
			Title_T[32].GetComponent<Text>().text = string.Format("{0}", Title[33]);
		}
		if (Gradu_N36 == 1)
		{
			Title_T[33].GetComponent<Text>().text = string.Format("{0}", Title[34]);
		}
		if (Gradu_N37 == 1)
		{
			Title_T[34].GetComponent<Text>().text = string.Format("{0}", Title[35]);
		}
		if (Gradu_N38 == 1)
		{
			Title_T[35].GetComponent<Text>().text = string.Format("{0}", Title[36]);
		}
		if (Gradu_N39 == 1)
		{
			Title_T[36].GetComponent<Text>().text = string.Format("{0}", Title[37]);
		}
		if (Gradu_N40 == 1)
		{
			Title_T[37].GetComponent<Text>().text = string.Format("{0}", Title[38]);
		}
		if (Gradu_N41 == 1)
		{
			Title_T[38].GetComponent<Text>().text = string.Format("{0}", Title[39]);
		}
		if (Gradu_N31 == 1)
		{
			Title_T[39].GetComponent<Text>().text = string.Format("{0}", Title[40]);
		}
	}
}
