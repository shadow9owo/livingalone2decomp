using UnityEngine;
using UnityEngine.UI;

public class s1_4 : MonoBehaviour
{
	public s3_7 s3_7;

	public s3_5 s3_5;

	public s3_4 s3_4;

	public s3_6 s3_6;

	public GameObject[] panel_item;

	public scene_controll scene_controll;

	public GameObject[] lock_clo_m;

	public GameObject[] lock_clo_w;

	public GameObject[] lock_pet;

	public GameObject[] lock_hair;

	public Transform money_window;

	public Transform sale_fee;

	public GameObject[] btn_cont;

	public GameObject scroll_panel;

	private void Awake()
	{
		CashCont.Scene_String = "1-4";
		s3_7.price = 0;
		TutorialCont.Tutorial_Int = PlayerPrefs.GetInt("Tutorial_Int");
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		Char.Sex = PlayerPrefs.GetInt("Sex");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Pet.Pet_N = PlayerPrefs.GetInt("Pet_N");
		scene_controll.pet_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		btn_cont[0].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[2].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[1].GetComponent<Image>().color = Color.white;
		btn_cont[3].GetComponent<Image>().color = Color.white;
		for (int i = 0; i < panel_item.Length; i++)
		{
			panel_item[i].SetActive(false);
			if (Char.Sex == 0)
			{
				panel_item[0].SetActive(true);
			}
			if (Char.Sex == 1)
			{
				panel_item[1].SetActive(true);
			}
		}
		if (Char.Sex == 0)
		{
			panel_item[0].SetActive(true);
			panel_item[1].SetActive(false);
			panel_item[2].SetActive(false);
			panel_item[3].SetActive(false);
			FeeCont.SaleMonthLife_M = PlayerPrefs.GetFloat("SaleMonthLife_M");
			sale_fee.GetComponent<Text>().text = string.Format("-{0:n2}%", FeeCont.SaleMonthLife_M * 100f);
		}
		if (Char.Sex == 1)
		{
			panel_item[0].SetActive(false);
			panel_item[1].SetActive(true);
			panel_item[2].SetActive(false);
			panel_item[3].SetActive(false);
			FeeCont.SaleMonthLife_W = PlayerPrefs.GetFloat("SaleMonthLife_W");
			sale_fee.GetComponent<Text>().text = string.Format("-{0:n2}%", FeeCont.SaleMonthLife_W * 100f);
		}
		hair_load();
		clo_load();
		s3_7.Pet_N[0] = PlayerPrefs.GetInt("pet_0");
		s3_7.Pet_N[1] = PlayerPrefs.GetInt("pet_1");
		s3_7.Pet_N[2] = PlayerPrefs.GetInt("pet_2");
		s3_7.Pet_N[3] = PlayerPrefs.GetInt("pet_3");
		s3_7.Pet_N[4] = PlayerPrefs.GetInt("pet_4");
		s3_7.Pet_N[5] = PlayerPrefs.GetInt("pet_5");
		s3_7.Pet_N[6] = PlayerPrefs.GetInt("pet_6");
		s3_7.Pet_N[7] = PlayerPrefs.GetInt("pet_7");
		s3_7.Pet_N[8] = PlayerPrefs.GetInt("pet_8");
		s3_7.Pet_N[9] = PlayerPrefs.GetInt("pet_9");
		s3_7.Pet_N[10] = PlayerPrefs.GetInt("pet_10");
		s3_7.Pet_N[11] = PlayerPrefs.GetInt("pet_11");
		s3_7.Pet_N[12] = PlayerPrefs.GetInt("pet_12");
		s3_7.Pet_N[13] = PlayerPrefs.GetInt("pet_13");
		s3_7.Pet_N[14] = PlayerPrefs.GetInt("pet_14");
		s3_7.Pet_N[15] = PlayerPrefs.GetInt("pet_15");
		s3_7.Pet_N[16] = PlayerPrefs.GetInt("pet_16");
		s3_7.Pet_N[17] = PlayerPrefs.GetInt("pet_17");
		s3_7.Pet_N[18] = PlayerPrefs.GetInt("pet_18");
		s3_7.Pet_N[19] = PlayerPrefs.GetInt("pet_19");
		s3_7.Pet_N[20] = PlayerPrefs.GetInt("pet_20");
		s3_7.Pet_N[21] = PlayerPrefs.GetInt("pet_21");
		s3_7.Pet_N[22] = PlayerPrefs.GetInt("pet_22");
		s3_7.Pet_N[23] = PlayerPrefs.GetInt("pet_23");
		s3_7.Pet_N[24] = PlayerPrefs.GetInt("pet_24");
		s3_7.Pet_N[25] = PlayerPrefs.GetInt("pet_25");
		s3_7.Pet_N[26] = PlayerPrefs.GetInt("pet_26");
		s3_6.cash_hair_N[0] = PlayerPrefs.GetInt("cash_hair_N[0]");
		s3_6.cash_hair_N[1] = PlayerPrefs.GetInt("cash_hair_N[1]");
		s3_6.cash_hair_N[2] = PlayerPrefs.GetInt("cash_hair_N[2]");
		s3_6.cash_hair_N[3] = PlayerPrefs.GetInt("cash_hair_N[3]");
		s3_6.cash_hair_N[4] = PlayerPrefs.GetInt("cash_hair_N[4]");
		s3_6.cash_hair_N[5] = PlayerPrefs.GetInt("cash_hair_N[5]");
		s3_6.cash_hair_N[6] = PlayerPrefs.GetInt("cash_hair_N[6]");
		s3_6.cash_hair_N[7] = PlayerPrefs.GetInt("cash_hair_N[7]");
		s3_6.cash_hair_N[8] = PlayerPrefs.GetInt("cash_hair_N[8]");
		s3_6.cash_hair_N[9] = PlayerPrefs.GetInt("cash_hair_N[9]");
		s3_6.cash_hair_N[10] = PlayerPrefs.GetInt("cash_hair_N[10]");
		s3_6.cash_hair_N[11] = PlayerPrefs.GetInt("cash_hair_N[11]");
		s3_6.cash_hair_N[12] = PlayerPrefs.GetInt("cash_hair_N[12]");
		s3_6.cash_hair_N[13] = PlayerPrefs.GetInt("cash_hair_N[13]");
		if (s3_7.Pet_N[0] == 1)
		{
			lock_pet[0].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[1] == 1)
		{
			lock_pet[1].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[2] == 1)
		{
			lock_pet[2].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[3] == 1)
		{
			lock_pet[3].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[4] == 1)
		{
			lock_pet[4].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[5] == 1)
		{
			lock_pet[5].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[6] == 1)
		{
			lock_pet[6].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[7] == 1)
		{
			lock_pet[7].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[8] == 1)
		{
			lock_pet[8].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[9] == 1)
		{
			lock_pet[9].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[10] == 1)
		{
			lock_pet[10].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[11] == 1)
		{
			lock_pet[11].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[12] == 1)
		{
			lock_pet[12].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[13] == 1)
		{
			lock_pet[13].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[14] == 1)
		{
			lock_pet[14].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[15] == 1)
		{
			lock_pet[15].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[16] == 1)
		{
			lock_pet[16].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[17] == 1)
		{
			lock_pet[17].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[18] == 1)
		{
			lock_pet[18].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[19] == 1)
		{
			lock_pet[19].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[20] == 1)
		{
			lock_pet[20].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[21] == 1)
		{
			lock_pet[21].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[22] == 1)
		{
			lock_pet[22].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[23] == 1)
		{
			lock_pet[23].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[24] == 1)
		{
			lock_pet[24].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[25] == 1)
		{
			lock_pet[25].GetComponent<Button>().interactable = true;
		}
		if (s3_7.Pet_N[26] == 1)
		{
			lock_pet[26].GetComponent<Button>().interactable = true;
		}
		s3_5.cont_w_clothse[1] = PlayerPrefs.GetInt("cont_w_clothse[1]");
		s3_5.cont_w_clothse[2] = PlayerPrefs.GetInt("cont_w_clothse[2]");
		s3_5.cont_w_clothse[3] = PlayerPrefs.GetInt("cont_w_clothse[3]");
		s3_5.cont_w_clothse[4] = PlayerPrefs.GetInt("cont_w_clothse[4]");
		s3_5.cont_w_clothse[5] = PlayerPrefs.GetInt("cont_w_clothse[5]");
		s3_5.cont_w_clothse[6] = PlayerPrefs.GetInt("cont_w_clothse[6]");
		s3_5.cont_w_clothse[7] = PlayerPrefs.GetInt("cont_w_clothse[7]");
		s3_5.cont_w_clothse[8] = PlayerPrefs.GetInt("cont_w_clothse[8]");
		s3_5.cont_w_clothse[9] = PlayerPrefs.GetInt("cont_w_clothse[9]");
		s3_5.cont_w_clothse[10] = PlayerPrefs.GetInt("cont_w_clothse[10]");
		s3_5.cont_w_clothse[11] = PlayerPrefs.GetInt("cont_w_clothse[11]");
		s3_5.cont_w_clothse[12] = PlayerPrefs.GetInt("cont_w_clothse[12]");
		s3_5.cont_w_clothse[13] = PlayerPrefs.GetInt("cont_w_clothse[13]");
		s3_5.cont_w_clothse[14] = PlayerPrefs.GetInt("cont_w_clothse[14]");
		s3_5.cont_w_clothse[15] = PlayerPrefs.GetInt("cont_w_clothse[15]");
		s3_5.cont_w_clothse[16] = PlayerPrefs.GetInt("cont_w_clothse[16]");
		s3_5.cont_w_clothse[17] = PlayerPrefs.GetInt("cont_w_clothse[17]");
		s3_5.cont_w_clothse[18] = PlayerPrefs.GetInt("cont_w_clothse[18]");
		s3_5.cont_w_clothse[19] = PlayerPrefs.GetInt("cont_w_clothse[19]");
		s3_5.cont_w_clothse[20] = PlayerPrefs.GetInt("cont_w_clothse[20]");
		s3_5.cont_w_clothse[21] = PlayerPrefs.GetInt("cont_w_clothse[21]");
		s3_5.cont_w_clothse[22] = PlayerPrefs.GetInt("cont_w_clothse[22]");
		s3_5.cont_w_clothse[23] = PlayerPrefs.GetInt("cont_w_clothse[23]");
		s3_5.cont_w_clothse[24] = PlayerPrefs.GetInt("cont_w_clothse[24]");
		s3_5.cont_w_clothse[25] = PlayerPrefs.GetInt("cont_w_clothse[25]");
		s3_5.cont_w_clothse[26] = PlayerPrefs.GetInt("cont_w_clothse[26]");
		s3_5.cont_w_clothse[27] = PlayerPrefs.GetInt("cont_w_clothse[27]");
		s3_5.cont_w_clothse[28] = PlayerPrefs.GetInt("cont_w_clothse[28]");
		s3_5.cont_w_clothse[29] = PlayerPrefs.GetInt("cont_w_clothse[29]");
		s3_5.cont_w_clothse[30] = PlayerPrefs.GetInt("cont_w_clothse[30]");
		s3_5.cont_w_clothse[31] = PlayerPrefs.GetInt("cont_w_clothse[31]");
		s3_5.cont_w_clothse[32] = PlayerPrefs.GetInt("cont_w_clothse[32]");
		s3_5.cont_w_clothse[33] = PlayerPrefs.GetInt("cont_w_clothse[33]");
		s3_5.cont_w_clothse[34] = PlayerPrefs.GetInt("cont_w_clothse[34]");
		s3_5.cont_w_clothse[35] = PlayerPrefs.GetInt("cont_w_clothse[35]");
		s3_5.cont_w_clothse[36] = PlayerPrefs.GetInt("cont_w_clothse[36]");
		s3_5.cont_w_clothse[37] = PlayerPrefs.GetInt("cont_w_clothse[37]");
		s3_5.cont_w_clothse[38] = PlayerPrefs.GetInt("cont_w_clothse[38]");
		s3_5.cont_w_clothse[39] = PlayerPrefs.GetInt("cont_w_clothse[39]");
		s3_5.cont_w_clothse[40] = PlayerPrefs.GetInt("cont_w_clothse[40]");
		s3_5.cont_w_clothse[41] = PlayerPrefs.GetInt("cont_w_clothse[41]");
		s3_5.cont_w_clothse[42] = PlayerPrefs.GetInt("cont_w_clothse[42]");
		s3_5.cont_w_clothse[43] = PlayerPrefs.GetInt("cont_w_clothse[43]");
		s3_5.cont_w_clothse[44] = PlayerPrefs.GetInt("cont_w_clothse[44]");
		s3_5.cont_w_clothse[45] = PlayerPrefs.GetInt("cont_w_clothse[45]");
		s3_5.cont_w_clothse[46] = PlayerPrefs.GetInt("cont_w_clothse[46]");
		s3_5.cont_w_clothse[47] = PlayerPrefs.GetInt("cont_w_clothse[47]");
		s3_5.cont_w_clothse[48] = PlayerPrefs.GetInt("cont_w_clothse[48]");
		s3_5.cont_m_clothse[1] = PlayerPrefs.GetInt("cont_m_clothse[1]");
		s3_5.cont_m_clothse[2] = PlayerPrefs.GetInt("cont_m_clothse[2]");
		s3_5.cont_m_clothse[3] = PlayerPrefs.GetInt("cont_m_clothse[3]");
		s3_5.cont_m_clothse[4] = PlayerPrefs.GetInt("cont_m_clothse[4]");
		s3_5.cont_m_clothse[5] = PlayerPrefs.GetInt("cont_m_clothse[5]");
		s3_5.cont_m_clothse[6] = PlayerPrefs.GetInt("cont_m_clothse[6]");
		s3_5.cont_m_clothse[7] = PlayerPrefs.GetInt("cont_m_clothse[7]");
		s3_5.cont_m_clothse[8] = PlayerPrefs.GetInt("cont_m_clothse[8]");
		s3_5.cont_m_clothse[9] = PlayerPrefs.GetInt("cont_m_clothse[9]");
		s3_5.cont_m_clothse[10] = PlayerPrefs.GetInt("cont_m_clothse[10]");
		s3_5.cont_m_clothse[11] = PlayerPrefs.GetInt("cont_m_clothse[11]");
		s3_5.cont_m_clothse[12] = PlayerPrefs.GetInt("cont_m_clothse[12]");
		s3_5.cont_m_clothse[13] = PlayerPrefs.GetInt("cont_m_clothse[13]");
		s3_5.cont_m_clothse[14] = PlayerPrefs.GetInt("cont_m_clothse[14]");
		s3_5.cont_m_clothse[15] = PlayerPrefs.GetInt("cont_m_clothse[15]");
		s3_5.cont_m_clothse[16] = PlayerPrefs.GetInt("cont_m_clothse[16]");
		s3_5.cont_m_clothse[17] = PlayerPrefs.GetInt("cont_m_clothse[17]");
		s3_5.cont_m_clothse[18] = PlayerPrefs.GetInt("cont_m_clothse[18]");
		s3_5.cont_m_clothse[19] = PlayerPrefs.GetInt("cont_m_clothse[19]");
		s3_5.cont_m_clothse[20] = PlayerPrefs.GetInt("cont_m_clothse[20]");
		s3_5.cont_m_clothse[21] = PlayerPrefs.GetInt("cont_m_clothse[21]");
		s3_5.cont_m_clothse[22] = PlayerPrefs.GetInt("cont_m_clothse[22]");
		s3_5.cont_m_clothse[23] = PlayerPrefs.GetInt("cont_m_clothse[23]");
		s3_5.cont_m_clothse[24] = PlayerPrefs.GetInt("cont_m_clothse[24]");
		s3_5.cont_m_clothse[25] = PlayerPrefs.GetInt("cont_m_clothse[25]");
		s3_5.cont_m_clothse[26] = PlayerPrefs.GetInt("cont_m_clothse[26]");
		s3_5.cont_m_clothse[27] = PlayerPrefs.GetInt("cont_m_clothse[27]");
		s3_5.cont_m_clothse[28] = PlayerPrefs.GetInt("cont_m_clothse[28]");
		s3_5.cont_m_clothse[29] = PlayerPrefs.GetInt("cont_m_clothse[29]");
		s3_5.cont_m_clothse[30] = PlayerPrefs.GetInt("cont_m_clothse[30]");
		s3_5.cont_m_clothse[31] = PlayerPrefs.GetInt("cont_m_clothse[31]");
		s3_5.cont_m_clothse[32] = PlayerPrefs.GetInt("cont_m_clothse[32]");
		s3_5.cont_m_clothse[33] = PlayerPrefs.GetInt("cont_m_clothse[33]");
		s3_5.cont_m_clothse[34] = PlayerPrefs.GetInt("cont_m_clothse[34]");
		s3_5.cont_m_clothse[35] = PlayerPrefs.GetInt("cont_m_clothse[35]");
		s3_5.cont_m_clothse[36] = PlayerPrefs.GetInt("cont_m_clothse[36]");
		s3_5.cont_m_clothse[37] = PlayerPrefs.GetInt("cont_m_clothse[37]");
		s3_5.cont_m_clothse[38] = PlayerPrefs.GetInt("cont_m_clothse[38]");
		s3_5.cont_m_clothse[39] = PlayerPrefs.GetInt("cont_m_clothse[39]");
		s3_5.cont_m_clothse[40] = PlayerPrefs.GetInt("cont_m_clothse[40]");
		s3_5.cont_m_clothse[41] = PlayerPrefs.GetInt("cont_m_clothse[41]");
		s3_5.cont_m_clothse[42] = PlayerPrefs.GetInt("cont_m_clothse[42]");
		s3_5.cont_m_clothse[43] = PlayerPrefs.GetInt("cont_m_clothse[43]");
		s3_5.cont_m_clothse[44] = PlayerPrefs.GetInt("cont_m_clothse[44]");
		s3_5.cont_m_clothse[45] = PlayerPrefs.GetInt("cont_m_clothse[45]");
		s3_5.cont_m_clothse[46] = PlayerPrefs.GetInt("cont_m_clothse[46]");
		s3_5.cont_m_clothse[47] = PlayerPrefs.GetInt("cont_m_clothse[47]");
		s3_5.cont_m_clothse[48] = PlayerPrefs.GetInt("cont_m_clothse[48]");
		if (s3_5.cont_w_clothse[1] == 1)
		{
			lock_clo_w[1].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[2] == 1)
		{
			lock_clo_w[2].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[3] == 1)
		{
			lock_clo_w[3].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[4] == 1)
		{
			lock_clo_w[4].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[5] == 1)
		{
			lock_clo_w[5].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[6] == 1)
		{
			lock_clo_w[6].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[7] == 1)
		{
			lock_clo_w[7].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[8] == 1)
		{
			lock_clo_w[8].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[9] == 1)
		{
			lock_clo_w[9].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[10] == 1)
		{
			lock_clo_w[10].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[11] == 1)
		{
			lock_clo_w[11].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[12] == 1)
		{
			lock_clo_w[12].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[13] == 1)
		{
			lock_clo_w[13].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[14] == 1)
		{
			lock_clo_w[14].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[15] == 1)
		{
			lock_clo_w[15].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[16] == 1)
		{
			lock_clo_w[16].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[17] == 1)
		{
			lock_clo_w[17].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[18] == 1)
		{
			lock_clo_w[18].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[19] == 1)
		{
			lock_clo_w[19].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[20] == 1)
		{
			lock_clo_w[20].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[21] == 1)
		{
			lock_clo_w[21].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[22] == 1)
		{
			lock_clo_w[22].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[23] == 1)
		{
			lock_clo_w[23].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[24] == 1)
		{
			lock_clo_w[24].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[25] == 1)
		{
			lock_clo_w[25].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[26] == 1)
		{
			lock_clo_w[26].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[27] == 1)
		{
			lock_clo_w[27].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[28] == 1)
		{
			lock_clo_w[28].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[29] == 1)
		{
			lock_clo_w[29].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[30] == 1)
		{
			lock_clo_w[30].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[31] == 1)
		{
			lock_clo_w[31].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[32] == 1)
		{
			lock_clo_w[32].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[33] == 1)
		{
			lock_clo_w[33].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[34] == 1)
		{
			lock_clo_w[34].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[35] == 1)
		{
			lock_clo_w[35].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[36] == 1)
		{
			lock_clo_w[36].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[37] == 1)
		{
			lock_clo_w[37].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[38] == 1)
		{
			lock_clo_w[38].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[39] == 1)
		{
			lock_clo_w[39].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[40] == 1)
		{
			lock_clo_w[40].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[41] == 1)
		{
			lock_clo_w[41].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[42] == 1)
		{
			lock_clo_w[42].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[43] == 1)
		{
			lock_clo_w[43].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[44] == 1)
		{
			lock_clo_w[44].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[45] == 1)
		{
			lock_clo_w[45].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[46] == 1)
		{
			lock_clo_w[46].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[47] == 1)
		{
			lock_clo_w[47].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_w_clothse[48] == 1)
		{
			lock_clo_w[48].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[1] == 1)
		{
			lock_clo_m[1].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[2] == 1)
		{
			lock_clo_m[2].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[3] == 1)
		{
			lock_clo_m[3].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[4] == 1)
		{
			lock_clo_m[4].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[5] == 1)
		{
			lock_clo_m[5].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[6] == 1)
		{
			lock_clo_m[6].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[7] == 1)
		{
			lock_clo_m[7].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[8] == 1)
		{
			lock_clo_m[8].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[9] == 1)
		{
			lock_clo_m[9].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[10] == 1)
		{
			lock_clo_m[10].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[11] == 1)
		{
			lock_clo_m[11].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[12] == 1)
		{
			lock_clo_m[12].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[13] == 1)
		{
			lock_clo_m[13].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[14] == 1)
		{
			lock_clo_m[14].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[15] == 1)
		{
			lock_clo_m[15].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[16] == 1)
		{
			lock_clo_m[16].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[17] == 1)
		{
			lock_clo_m[17].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[18] == 1)
		{
			lock_clo_m[18].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[19] == 1)
		{
			lock_clo_m[19].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[20] == 1)
		{
			lock_clo_m[20].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[21] == 1)
		{
			lock_clo_m[21].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[22] == 1)
		{
			lock_clo_m[22].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[23] == 1)
		{
			lock_clo_m[23].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[24] == 1)
		{
			lock_clo_m[24].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[25] == 1)
		{
			lock_clo_m[25].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[26] == 1)
		{
			lock_clo_m[26].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[27] == 1)
		{
			lock_clo_m[27].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[28] == 1)
		{
			lock_clo_m[28].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[29] == 1)
		{
			lock_clo_m[29].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[30] == 1)
		{
			lock_clo_m[30].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[31] == 1)
		{
			lock_clo_m[31].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[32] == 1)
		{
			lock_clo_m[32].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[33] == 1)
		{
			lock_clo_m[33].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[34] == 1)
		{
			lock_clo_m[34].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[35] == 1)
		{
			lock_clo_m[35].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[36] == 1)
		{
			lock_clo_m[36].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[37] == 1)
		{
			lock_clo_m[37].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[38] == 1)
		{
			lock_clo_m[38].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[39] == 1)
		{
			lock_clo_m[39].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[40] == 1)
		{
			lock_clo_m[40].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[41] == 1)
		{
			lock_clo_m[41].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[42] == 1)
		{
			lock_clo_m[42].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[43] == 1)
		{
			lock_clo_m[43].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[44] == 1)
		{
			lock_clo_m[44].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[45] == 1)
		{
			lock_clo_m[45].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[46] == 1)
		{
			lock_clo_m[46].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[47] == 1)
		{
			lock_clo_m[47].GetComponent<Button>().interactable = true;
		}
		if (s3_5.cont_m_clothse[48] == 1)
		{
			lock_clo_m[48].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[0] == 1)
		{
			lock_hair[0].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[1] == 1)
		{
			lock_hair[1].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[2] == 1)
		{
			lock_hair[2].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[3] == 1)
		{
			lock_hair[3].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[4] == 1)
		{
			lock_hair[4].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[5] == 1)
		{
			lock_hair[5].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[6] == 1)
		{
			lock_hair[6].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[7] == 1)
		{
			lock_hair[7].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[8] == 1)
		{
			lock_hair[8].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[9] == 1)
		{
			lock_hair[9].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[10] == 1)
		{
			lock_hair[10].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[11] == 1)
		{
			lock_hair[11].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[12] == 1)
		{
			lock_hair[12].GetComponent<Button>().interactable = true;
		}
		if (s3_6.cash_hair_N[13] == 1)
		{
			lock_hair[13].GetComponent<Button>().interactable = true;
		}
	}

	private void FixedUpdate()
	{
	}

	public void btn_select()
	{
		if (panel_item[6].activeSelf | panel_item[7].activeSelf)
		{
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 72")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 75")))
			{
				Head.Hair_N = 34;
				s3_7.minushairpoint_W = 0.13f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 73")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 76")))
			{
				Head.Hair_N = 35;
				s3_7.minushairpoint_W = 0.14f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 74")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 77")))
			{
				Head.Hair_N = 36;
				s3_7.minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 78")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 79")))
			{
				Head.Hair_N = 37;
				s3_7.minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 81")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 80")))
			{
				Head.Hair_N = 38;
				s3_7.minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 82")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 83")))
			{
				Head.Hair_N = 39;
				s3_7.minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			if ((s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 84")) | (s3_6.hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 85")))
			{
				Head.Hair_N = 40;
				s3_7.minushairpoint_W = 0.15f;
				PlayerPrefs.SetFloat("minushairpoint_W", s3_7.minushairpoint_W);
			}
			PlayerPrefs.SetInt("Hair_N", Head.Hair_N);
		}
		if (panel_item[0].activeSelf | panel_item[1].activeSelf | panel_item[3].activeSelf | panel_item[4].activeSelf)
		{
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 41")))
			{
				Clothes.Clothes_N = 0;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 1")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 42")))
			{
				Clothes.Clothes_N = 1;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 2")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 43")))
			{
				Clothes.Clothes_N = 2;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 3")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 44")))
			{
				Clothes.Clothes_N = 3;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 4")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 45")))
			{
				Clothes.Clothes_N = 4;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 5")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 46")))
			{
				Clothes.Clothes_N = 5;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 6")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 47")))
			{
				Clothes.Clothes_N = 6;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 7")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 48")))
			{
				Clothes.Clothes_N = 7;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 8")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 49")))
			{
				Clothes.Clothes_N = 8;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 9")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 50")))
			{
				Clothes.Clothes_N = 9;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 10")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 51")))
			{
				Clothes.Clothes_N = 10;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 11")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 52")))
			{
				Clothes.Clothes_N = 11;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 12")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 53")))
			{
				Clothes.Clothes_N = 12;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 13")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 54")))
			{
				Clothes.Clothes_N = 13;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 14")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 55")))
			{
				Clothes.Clothes_N = 14;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 15")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 56")))
			{
				Clothes.Clothes_N = 15;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 16")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 57")))
			{
				Clothes.Clothes_N = 16;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 17")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 58")))
			{
				Clothes.Clothes_N = 17;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 18")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 59")))
			{
				Clothes.Clothes_N = 18;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 19")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 60")))
			{
				Clothes.Clothes_N = 19;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 20")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 61")))
			{
				Clothes.Clothes_N = 20;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 21")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 62")))
			{
				Clothes.Clothes_N = 21;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 22")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 63")))
			{
				Clothes.Clothes_N = 22;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 23")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 64")))
			{
				Clothes.Clothes_N = 23;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 24")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 65")))
			{
				Clothes.Clothes_N = 24;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 25")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 66")))
			{
				Clothes.Clothes_N = 25;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 26")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 67")))
			{
				Clothes.Clothes_N = 26;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 27")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 68")))
			{
				Clothes.Clothes_N = 27;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 28")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 69")))
			{
				Clothes.Clothes_N = 28;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 29")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 70")))
			{
				Clothes.Clothes_N = 29;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 30")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 71")))
			{
				Clothes.Clothes_N = 30;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 31")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 72")))
			{
				Clothes.Clothes_N = 31;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 32")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 73")))
			{
				Clothes.Clothes_N = 32;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 33")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 74")))
			{
				Clothes.Clothes_N = 33;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 34")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 75")))
			{
				Clothes.Clothes_N = 34;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 35")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 76")))
			{
				Clothes.Clothes_N = 35;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 36")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 77")))
			{
				Clothes.Clothes_N = 36;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 37")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 78")))
			{
				Clothes.Clothes_N = 37;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 38")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 79")))
			{
				Clothes.Clothes_N = 38;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 39")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 80")))
			{
				Clothes.Clothes_N = 39;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 40")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 81")))
			{
				Clothes.Clothes_N = 40;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 82")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 82")))
			{
				Clothes.Clothes_N = 41;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack1")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1")))
			{
				Clothes.Clothes_N = 42;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack2")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1")))
			{
				Clothes.Clothes_N = 43;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack3")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1")))
			{
				Clothes.Clothes_N = 44;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack4")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1")))
			{
				Clothes.Clothes_N = 45;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 94")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 93")))
			{
				Clothes.Clothes_N = 46;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 95")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 97")))
			{
				Clothes.Clothes_N = 47;
			}
			if ((s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 96")) | (s3_5.clothse_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_clo 98")))
			{
				Clothes.Clothes_N = 48;
			}
			PlayerPrefs.SetInt("Clothes_N", Clothes.Clothes_N);
		}
		if (panel_item[2].activeSelf)
		{
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_cat"))
			{
				Pet.Pet_N = 0;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_dog"))
			{
				Pet.Pet_N = 1;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pig"))
			{
				Pet.Pet_N = 2;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_rabbit"))
			{
				Pet.Pet_N = 3;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_d_fox"))
			{
				Pet.Pet_N = 4;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_rocoon"))
			{
				Pet.Pet_N = 5;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_fox"))
			{
				Pet.Pet_N = 6;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_alphadog"))
			{
				Pet.Pet_N = 7;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pangguin"))
			{
				Pet.Pet_N = 8;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_chick"))
			{
				Pet.Pet_N = 9;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_alpaca"))
			{
				Pet.Pet_N = 10;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_turtle"))
			{
				Pet.Pet_N = 11;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_ele"))
			{
				Pet.Pet_N = 12;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_snake"))
			{
				Pet.Pet_N = 13;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_panda"))
			{
				Pet.Pet_N = 14;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_parret"))
			{
				Pet.Pet_N = 15;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_dragon"))
			{
				Pet.Pet_N = 16;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("tiger"))
			{
				Pet.Pet_N = 17;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("elepant"))
			{
				Pet.Pet_N = 18;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("kang"))
			{
				Pet.Pet_N = 19;
			}
			PlayerPrefs.SetInt("Pet_N", Pet.Pet_N);
		}
		if (panel_item[5].activeSelf)
		{
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pinix"))
			{
				Pet.Pet_N = 20;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("pet_pega"))
			{
				Pet.Pet_N = 21;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Pet_babychick"))
			{
				Pet.Pet_N = 22;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_pet"))
			{
				Pet.Pet_N = 23;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_pet 1"))
			{
				Pet.Pet_N = 24;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_pet 2"))
			{
				Pet.Pet_N = 25;
			}
			if (s3_7.pet_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_pet 3"))
			{
				Pet.Pet_N = 26;
			}
			PlayerPrefs.SetInt("Pet_N", Pet.Pet_N);
		}
		scene_controll.panel_notice[0].SetActive(true);
		scene_controll.panel_notice[4].SetActive(true);
		Invoke("nothing", 1f);
	}

	public void btn_clo()
	{
		Invoke("stop_false", 1f);
		scene_controll.pet_load.SetActive(false);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		btn_cont[0].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[2].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[1].GetComponent<Image>().color = Color.white;
		btn_cont[2].GetComponent<Button>().interactable = true;
		btn_cont[3].GetComponent<Image>().color = Color.white;
		btn_cont[4].GetComponent<Image>().color = Color.white;
		for (int i = 0; i < panel_item.Length; i++)
		{
			panel_item[i].SetActive(false);
		}
		if (Char.Sex == 0)
		{
			panel_item[0].SetActive(true);
		}
		else
		{
			panel_item[1].SetActive(true);
		}
		hair_load();
		clo_load();
		scene_controll.pet_load.SetActive(false);
	}

	public void btn_pet()
	{
		scene_controll.pet_load.SetActive(true);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		btn_cont[2].GetComponent<Button>().interactable = true;
		btn_cont[1].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[2].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[0].GetComponent<Image>().color = Color.white;
		btn_cont[3].GetComponent<Image>().color = Color.white;
		btn_cont[4].GetComponent<Image>().color = Color.white;
		for (int i = 0; i < panel_item.Length; i++)
		{
			panel_item[i].SetActive(false);
		}
		panel_item[2].SetActive(true);
		if (Pet.Pet_N == 0)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
		}
		if (Pet.Pet_N == 1)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
		}
		if (Pet.Pet_N == 2)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
		}
		if (Pet.Pet_N == 3)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
		}
		if (Pet.Pet_N == 4)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
		}
		if (Pet.Pet_N == 5)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
		}
		if (Pet.Pet_N == 6)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
		}
		if (Pet.Pet_N == 7)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphadog");
		}
		if (Pet.Pet_N == 8)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
		}
		if (Pet.Pet_N == 9)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
		}
		if (Pet.Pet_N == 10)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
		}
		if (Pet.Pet_N == 11)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
		}
		if (Pet.Pet_N == 12)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
		}
		if (Pet.Pet_N == 13)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
		}
		if (Pet.Pet_N == 14)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
		}
		if (Pet.Pet_N == 15)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
		}
		if (Pet.Pet_N == 16)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
		}
		if (Pet.Pet_N == 17)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
		}
		if (Pet.Pet_N == 18)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
		}
		if (Pet.Pet_N == 19)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
		}
		if (Pet.Pet_N == 20)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
		}
		if (Pet.Pet_N == 21)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
		}
		if (Pet.Pet_N == 22)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
		}
		if (Pet.Pet_N == 23)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
		}
		if (Pet.Pet_N == 24)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
		}
		if (Pet.Pet_N == 25)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
		}
		if (Pet.Pet_N == 26)
		{
			s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 3");
		}
		if (Pet.Pet_N == 99)
		{
			scene_controll.pet_load.SetActive(false);
		}
	}

	public void btn_hair()
	{
		scene_controll.pet_load.SetActive(false);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		btn_cont[0].GetComponent<Image>().color = Color.white;
		btn_cont[2].GetComponent<Button>().interactable = false;
		btn_cont[2].GetComponent<Image>().color = Color.white;
		btn_cont[1].GetComponent<Image>().color = Color.white;
		btn_cont[3].GetComponent<Image>().color = new Color(0.20784314f, 0.9137255f, 1f);
		btn_cont[4].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		for (int i = 0; i < panel_item.Length; i++)
		{
			panel_item[i].SetActive(false);
		}
		if (Char.Sex == 0)
		{
			panel_item[6].SetActive(true);
		}
		else
		{
			panel_item[7].SetActive(true);
		}
		hair_load();
		clo_load();
		scene_controll.pet_load.SetActive(false);
	}

	public void btn_reset_()
	{
		if (panel_item[0].activeSelf | panel_item[1].activeSelf | panel_item[3].activeSelf | panel_item[4].activeSelf)
		{
			scene_controll.clothse_load.SetActive(false);
			scene_controll.head_load.SetActive(false);
			scene_controll.clothse_load.SetActive(true);
			scene_controll.head_load.SetActive(true);
			hair_load();
			clo_load();
		}
		if (panel_item[6].activeSelf | panel_item[7].activeSelf)
		{
			scene_controll.clothse_load.SetActive(false);
			scene_controll.head_load.SetActive(false);
			scene_controll.clothse_load.SetActive(true);
			scene_controll.head_load.SetActive(true);
			hair_load();
			clo_load();
		}
		if (panel_item[2].activeSelf)
		{
			if (Pet.Pet_N == 0)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_cat");
			}
			if (Pet.Pet_N == 1)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dog");
			}
			if (Pet.Pet_N == 2)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pig");
			}
			if (Pet.Pet_N == 3)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rabbit");
			}
			if (Pet.Pet_N == 4)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_d_fox");
			}
			if (Pet.Pet_N == 5)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_rocoon");
			}
			if (Pet.Pet_N == 6)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_fox");
			}
			if (Pet.Pet_N == 7)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alphadog");
			}
			if (Pet.Pet_N == 8)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pangguin");
			}
			if (Pet.Pet_N == 9)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_chick");
			}
			if (Pet.Pet_N == 10)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_alpaca");
			}
			if (Pet.Pet_N == 11)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_turtle");
			}
			if (Pet.Pet_N == 12)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_ele");
			}
			if (Pet.Pet_N == 13)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_snake");
			}
			if (Pet.Pet_N == 14)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_panda");
			}
			if (Pet.Pet_N == 15)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_parret");
			}
			if (Pet.Pet_N == 16)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_dragon");
			}
			if (Pet.Pet_N == 17)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("tiger");
			}
			if (Pet.Pet_N == 18)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("elepant");
			}
			if (Pet.Pet_N == 19)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("kang");
			}
			if (Pet.Pet_N == 20)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pinix");
			}
			if (Pet.Pet_N == 21)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("pet_pega");
			}
			if (Pet.Pet_N == 22)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Pet_babychick");
			}
			if (Pet.Pet_N == 23)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet");
			}
			if (Pet.Pet_N == 24)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 1");
			}
			if (Pet.Pet_N == 25)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 2");
			}
			if (Pet.Pet_N == 26)
			{
				s3_7.pet_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_pet 3");
			}
			if (Pet.Pet_N == 99)
			{
				scene_controll.pet_load.SetActive(false);
			}
		}
	}

	public void btn_cash()
	{
		btn_cont[3].GetComponent<Image>().color = new Color(0.20784314f, 0.9137255f, 1f);
		btn_cont[2].GetComponent<Image>().color = Color.white;
		if (panel_item[0].activeSelf | panel_item[1].activeSelf)
		{
			if (Char.Sex == 0)
			{
				panel_item[3].SetActive(true);
			}
			if (Char.Sex == 1)
			{
				panel_item[4].SetActive(true);
			}
			panel_item[0].SetActive(false);
			panel_item[1].SetActive(false);
		}
		if (panel_item[2].activeSelf)
		{
			panel_item[5].SetActive(true);
			panel_item[2].SetActive(false);
		}
	}

	private void scroll_controll()
	{
	}

	public void btn_nomal()
	{
		Invoke("stop_false", 1f);
		btn_cont[2].GetComponent<Image>().color = new Color(1f, 0.7372549f, 1f / 51f);
		btn_cont[3].GetComponent<Image>().color = Color.white;
		if (panel_item[3].activeSelf | panel_item[4].activeSelf)
		{
			if (Char.Sex == 0)
			{
				panel_item[0].SetActive(true);
			}
			if (Char.Sex == 1)
			{
				panel_item[1].SetActive(true);
			}
			panel_item[3].SetActive(false);
			panel_item[4].SetActive(false);
		}
		if (panel_item[5].activeSelf)
		{
			panel_item[2].SetActive(true);
			panel_item[5].SetActive(false);
		}
	}

	public void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}

	public void hair_load()
	{
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				s3_6.hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
	}

	public void clo_load()
	{
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				s3_5.clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
	}

	public void stop_false()
	{
	}

	public void verti_false()
	{
	}
}
