using UnityEngine;
using UnityEngine.UI;

public class s1_4_pet : MonoBehaviour
{
	public GameObject[] Pet_Lv_T;

	public GameObject[] Pet_Exp_bar;

	public GameObject[] pet_money_T;

	private void Start()
	{
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		PetPosition.Pet_0_level = PlayerPrefs.GetInt("Pet_0_level");
		PetPosition.Pet_0_exp = PlayerPrefs.GetFloat("Pet_0_exp");
		PetPosition.Pet_0_Max = PlayerPrefs.GetFloat("Pet_0_Max");
		PetPosition.Pet_1_level = PlayerPrefs.GetInt("Pet_1_level");
		PetPosition.Pet_1_exp = PlayerPrefs.GetFloat("Pet_1_exp");
		PetPosition.Pet_1_Max = PlayerPrefs.GetFloat("Pet_1_Max");
		PetPosition.Pet_2_level = PlayerPrefs.GetInt("Pet_2_level");
		PetPosition.Pet_2_exp = PlayerPrefs.GetFloat("Pet_2_exp");
		PetPosition.Pet_2_Max = PlayerPrefs.GetFloat("Pet_2_Max");
		PetPosition.Pet_3_level = PlayerPrefs.GetInt("Pet_3_level");
		PetPosition.Pet_3_exp = PlayerPrefs.GetFloat("Pet_3_exp");
		PetPosition.Pet_3_Max = PlayerPrefs.GetFloat("Pet_3_Max");
		PetPosition.Pet_4_level = PlayerPrefs.GetInt("Pet_4_level");
		PetPosition.Pet_4_exp = PlayerPrefs.GetFloat("Pet_4_exp");
		PetPosition.Pet_4_Max = PlayerPrefs.GetFloat("Pet_4_Max");
		PetPosition.Pet_5_level = PlayerPrefs.GetInt("Pet_5_level");
		PetPosition.Pet_5_exp = PlayerPrefs.GetFloat("Pet_5_exp");
		PetPosition.Pet_5_Max = PlayerPrefs.GetFloat("Pet_5_Max");
		PetPosition.Pet_6_level = PlayerPrefs.GetInt("Pet_6_level");
		PetPosition.Pet_6_exp = PlayerPrefs.GetFloat("Pet_6_exp");
		PetPosition.Pet_6_Max = PlayerPrefs.GetFloat("Pet_6_Max");
		PetPosition.Pet_7_level = PlayerPrefs.GetInt("Pet_7_level");
		PetPosition.Pet_7_exp = PlayerPrefs.GetFloat("Pet_7_exp");
		PetPosition.Pet_7_Max = PlayerPrefs.GetFloat("Pet_7_Max");
		PetPosition.Pet_8_level = PlayerPrefs.GetInt("Pet_8_level");
		PetPosition.Pet_8_exp = PlayerPrefs.GetFloat("Pet_8_exp");
		PetPosition.Pet_8_Max = PlayerPrefs.GetFloat("Pet_8_Max");
		PetPosition.Pet_9_level = PlayerPrefs.GetInt("Pet_9_level");
		PetPosition.Pet_9_exp = PlayerPrefs.GetFloat("Pet_9_exp");
		PetPosition.Pet_9_Max = PlayerPrefs.GetFloat("Pet_9_Max");
		PetPosition.Pet_10_level = PlayerPrefs.GetInt("Pet_10_level");
		PetPosition.Pet_10_exp = PlayerPrefs.GetFloat("Pet_10_exp");
		PetPosition.Pet_10_Max = PlayerPrefs.GetFloat("Pet_10_Max");
		PetPosition.Pet_11_level = PlayerPrefs.GetInt("Pet_11_level");
		PetPosition.Pet_11_exp = PlayerPrefs.GetFloat("Pet_11_exp");
		PetPosition.Pet_11_Max = PlayerPrefs.GetFloat("Pet_11_Max");
		PetPosition.Pet_12_level = PlayerPrefs.GetInt("Pet_12_level");
		PetPosition.Pet_12_exp = PlayerPrefs.GetFloat("Pet_12_exp");
		PetPosition.Pet_12_Max = PlayerPrefs.GetFloat("Pet_12_Max");
		PetPosition.Pet_13_level = PlayerPrefs.GetInt("Pet_13_level");
		PetPosition.Pet_13_exp = PlayerPrefs.GetFloat("Pet_13_exp");
		PetPosition.Pet_13_Max = PlayerPrefs.GetFloat("Pet_13_Max");
		PetPosition.Pet_14_level = PlayerPrefs.GetInt("Pet_14_level");
		PetPosition.Pet_14_exp = PlayerPrefs.GetFloat("Pet_14_exp");
		PetPosition.Pet_14_Max = PlayerPrefs.GetFloat("Pet_14_Max");
		PetPosition.Pet_15_level = PlayerPrefs.GetInt("Pet_15_level");
		PetPosition.Pet_15_exp = PlayerPrefs.GetFloat("Pet_15_exp");
		PetPosition.Pet_15_Max = PlayerPrefs.GetFloat("Pet_15_Max");
		PetPosition.Pet_16_level = PlayerPrefs.GetInt("Pet_16_level");
		PetPosition.Pet_16_exp = PlayerPrefs.GetFloat("Pet_16_exp");
		PetPosition.Pet_16_Max = PlayerPrefs.GetFloat("Pet_16_Max");
		PetPosition.Pet_17_level = PlayerPrefs.GetInt("Pet_17_level");
		PetPosition.Pet_17_exp = PlayerPrefs.GetFloat("Pet_17_exp");
		PetPosition.Pet_17_Max = PlayerPrefs.GetFloat("Pet_17_Max");
		PetPosition.Pet_18_level = PlayerPrefs.GetInt("Pet_18_level");
		PetPosition.Pet_18_exp = PlayerPrefs.GetFloat("Pet_18_exp");
		PetPosition.Pet_18_Max = PlayerPrefs.GetFloat("Pet_18_Max");
		PetPosition.Pet_19_level = PlayerPrefs.GetInt("Pet_19_level");
		PetPosition.Pet_19_exp = PlayerPrefs.GetFloat("Pet_19_exp");
		PetPosition.Pet_19_Max = PlayerPrefs.GetFloat("Pet_19_Max");
		PetPosition.Pet_20_level = PlayerPrefs.GetInt("Pet_20_level");
		PetPosition.Pet_20_exp = PlayerPrefs.GetFloat("Pet_20_exp");
		PetPosition.Pet_20_Max = PlayerPrefs.GetFloat("Pet_20_Max");
		PetPosition.Pet_21_level = PlayerPrefs.GetInt("Pet_21_level");
		PetPosition.Pet_21_exp = PlayerPrefs.GetFloat("Pet_21_exp");
		PetPosition.Pet_21_Max = PlayerPrefs.GetFloat("Pet_21_Max");
		PetPosition.Pet_22_level = PlayerPrefs.GetInt("Pet_22_level");
		PetPosition.Pet_22_exp = PlayerPrefs.GetFloat("Pet_22_exp");
		PetPosition.Pet_22_Max = PlayerPrefs.GetFloat("Pet_22_Max");
		PetPosition.Pet_23_level = PlayerPrefs.GetInt("Pet_23_level");
		PetPosition.Pet_23_exp = PlayerPrefs.GetFloat("Pet_23_exp");
		PetPosition.Pet_23_Max = PlayerPrefs.GetFloat("Pet_23_Max");
		PetPosition.Pet_24_level = PlayerPrefs.GetInt("Pet_24_level");
		PetPosition.Pet_24_exp = PlayerPrefs.GetFloat("Pet_24_exp");
		PetPosition.Pet_24_Max = PlayerPrefs.GetFloat("Pet_24_Max");
		PetPosition.Pet_25_level = PlayerPrefs.GetInt("Pet_25_level");
		PetPosition.Pet_25_exp = PlayerPrefs.GetFloat("Pet_25_exp");
		PetPosition.Pet_25_Max = PlayerPrefs.GetFloat("Pet_25_Max");
		PetPosition.Pet_26_level = PlayerPrefs.GetInt("Pet_26_level");
		PetPosition.Pet_26_exp = PlayerPrefs.GetFloat("Pet_26_exp");
		PetPosition.Pet_26_Max = PlayerPrefs.GetFloat("Pet_26_Max");
		LV_Setting();
		Exp_Setting();
		Set_Pet_money_T();
	}

	public void LV_Setting()
	{
		Pet_Lv_T[0].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_0_level);
		Pet_Lv_T[1].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_1_level);
		Pet_Lv_T[2].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_2_level);
		Pet_Lv_T[3].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_3_level);
		Pet_Lv_T[4].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_4_level);
		Pet_Lv_T[5].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_5_level);
		Pet_Lv_T[6].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_6_level);
		Pet_Lv_T[7].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_7_level);
		Pet_Lv_T[8].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_8_level);
		Pet_Lv_T[9].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_9_level);
		Pet_Lv_T[10].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_10_level);
		Pet_Lv_T[11].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_11_level);
		Pet_Lv_T[12].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_12_level);
		Pet_Lv_T[13].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_13_level);
		Pet_Lv_T[14].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_14_level);
		Pet_Lv_T[15].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_15_level);
		Pet_Lv_T[16].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_16_level);
		Pet_Lv_T[17].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_17_level);
		Pet_Lv_T[18].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_18_level);
		Pet_Lv_T[19].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_19_level);
		Pet_Lv_T[20].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_20_level);
		Pet_Lv_T[21].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_21_level);
		Pet_Lv_T[22].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_22_level);
		Pet_Lv_T[23].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_23_level);
		Pet_Lv_T[24].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_24_level);
		Pet_Lv_T[25].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_25_level);
		Pet_Lv_T[26].GetComponent<Text>().text = string.Format("Level. {0:n0}", PetPosition.Pet_26_level);
	}

	public void Exp_Setting()
	{
		Pet_Exp_bar[0].GetComponent<Image>().fillAmount = PetPosition.Pet_0_exp / PetPosition.Pet_0_Max;
		Pet_Exp_bar[1].GetComponent<Image>().fillAmount = PetPosition.Pet_1_exp / PetPosition.Pet_1_Max;
		Pet_Exp_bar[2].GetComponent<Image>().fillAmount = PetPosition.Pet_2_exp / PetPosition.Pet_2_Max;
		Pet_Exp_bar[3].GetComponent<Image>().fillAmount = PetPosition.Pet_3_exp / PetPosition.Pet_3_Max;
		Pet_Exp_bar[4].GetComponent<Image>().fillAmount = PetPosition.Pet_4_exp / PetPosition.Pet_4_Max;
		Pet_Exp_bar[5].GetComponent<Image>().fillAmount = PetPosition.Pet_5_exp / PetPosition.Pet_5_Max;
		Pet_Exp_bar[6].GetComponent<Image>().fillAmount = PetPosition.Pet_6_exp / PetPosition.Pet_6_Max;
		Pet_Exp_bar[7].GetComponent<Image>().fillAmount = PetPosition.Pet_7_exp / PetPosition.Pet_7_Max;
		Pet_Exp_bar[8].GetComponent<Image>().fillAmount = PetPosition.Pet_8_exp / PetPosition.Pet_8_Max;
		Pet_Exp_bar[9].GetComponent<Image>().fillAmount = PetPosition.Pet_9_exp / PetPosition.Pet_9_Max;
		Pet_Exp_bar[10].GetComponent<Image>().fillAmount = PetPosition.Pet_10_exp / PetPosition.Pet_10_Max;
		Pet_Exp_bar[11].GetComponent<Image>().fillAmount = PetPosition.Pet_11_exp / PetPosition.Pet_11_Max;
		Pet_Exp_bar[12].GetComponent<Image>().fillAmount = PetPosition.Pet_12_exp / PetPosition.Pet_12_Max;
		Pet_Exp_bar[13].GetComponent<Image>().fillAmount = PetPosition.Pet_13_exp / PetPosition.Pet_13_Max;
		Pet_Exp_bar[14].GetComponent<Image>().fillAmount = PetPosition.Pet_14_exp / PetPosition.Pet_14_Max;
		Pet_Exp_bar[15].GetComponent<Image>().fillAmount = PetPosition.Pet_15_exp / PetPosition.Pet_15_Max;
		Pet_Exp_bar[16].GetComponent<Image>().fillAmount = PetPosition.Pet_16_exp / PetPosition.Pet_16_Max;
		Pet_Exp_bar[17].GetComponent<Image>().fillAmount = PetPosition.Pet_17_exp / PetPosition.Pet_17_Max;
		Pet_Exp_bar[18].GetComponent<Image>().fillAmount = PetPosition.Pet_18_exp / PetPosition.Pet_18_Max;
		Pet_Exp_bar[19].GetComponent<Image>().fillAmount = PetPosition.Pet_19_exp / PetPosition.Pet_19_Max;
		Pet_Exp_bar[20].GetComponent<Image>().fillAmount = PetPosition.Pet_20_exp / PetPosition.Pet_20_Max;
		Pet_Exp_bar[21].GetComponent<Image>().fillAmount = PetPosition.Pet_21_exp / PetPosition.Pet_21_Max;
		Pet_Exp_bar[22].GetComponent<Image>().fillAmount = PetPosition.Pet_22_exp / PetPosition.Pet_22_Max;
		Pet_Exp_bar[23].GetComponent<Image>().fillAmount = PetPosition.Pet_23_exp / PetPosition.Pet_23_Max;
		Pet_Exp_bar[24].GetComponent<Image>().fillAmount = PetPosition.Pet_24_exp / PetPosition.Pet_24_Max;
		Pet_Exp_bar[25].GetComponent<Image>().fillAmount = PetPosition.Pet_25_exp / PetPosition.Pet_25_Max;
		Pet_Exp_bar[26].GetComponent<Image>().fillAmount = PetPosition.Pet_26_exp / PetPosition.Pet_26_Max;
	}

	public void Set_Pet_money_T()
	{
		pet_money_T[0].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_0);
		pet_money_T[1].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_1);
		pet_money_T[2].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_2);
		pet_money_T[3].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_3);
		pet_money_T[4].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_4);
		pet_money_T[5].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_5);
		pet_money_T[6].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_6);
		pet_money_T[7].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_7);
		pet_money_T[8].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_8);
		pet_money_T[9].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_9);
		pet_money_T[10].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_10);
		pet_money_T[11].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_11);
		pet_money_T[12].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_12);
		pet_money_T[13].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_13);
		pet_money_T[14].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_14);
		pet_money_T[15].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_15);
		pet_money_T[16].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_16);
		pet_money_T[17].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_17);
		pet_money_T[18].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_18);
		pet_money_T[19].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_19);
		pet_money_T[20].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_20);
		pet_money_T[21].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_21);
		pet_money_T[22].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_22);
		pet_money_T[23].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_23);
		pet_money_T[24].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_24);
		pet_money_T[25].GetComponent<Text>().text = string.Format("{0:n0}G", PetPosition.Pet_money_25);
		pet_money_T[26].GetComponent<Text>().text = string.Format("per{0:n0}min {1}sec", Mathf.Floor(PetPosition.Wolftime / 60f), PetPosition.Wolftime % 60f);
		Debug.Log("PetPosition.Pet_money_21=" + PetPosition.Pet_money_21);
	}
}
