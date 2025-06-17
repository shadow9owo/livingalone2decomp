using UnityEngine;
using UnityEngine.UI;

public class s3_6 : MonoBehaviour
{
	public scene_controll scene_controll;

	public s3_5 s3_5;

	public Animator hair_load;

	public Transform real_buy_price;

	public GameObject panel_man;

	public GameObject panel_woman;

	public GameObject[] lock_m;

	public GameObject[] lock_w;

	public int[] cash_hair_N;

	private void Awake()
	{
		if (TutorialCont.Tutorial_Int == 0)
		{
			if (Char.Sex == 0)
			{
				for (int i = 0; i < lock_m.Length; i++)
				{
					lock_m[i].GetComponent<Button>().interactable = false;
				}
			}
			if (Char.Sex == 1)
			{
				for (int j = 0; j < lock_w.Length; j++)
				{
					lock_w[j].GetComponent<Button>().interactable = false;
				}
			}
		}
		else
		{
			for (int k = 0; k < lock_m.Length; k++)
			{
				lock_m[k].GetComponent<Button>().interactable = true;
			}
			for (int l = 0; l < lock_w.Length; l++)
			{
				lock_w[l].GetComponent<Button>().interactable = true;
			}
		}
		CashCont.Scene_String = "3-6";
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		scene_controll.head_load.SetActive(true);
		scene_controll.clothse_load.SetActive(true);
		Char.Sex = PlayerPrefs.GetInt("Sex");
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		cash_hair_N[0] = PlayerPrefs.GetInt("cash_hair_N[0]");
		cash_hair_N[1] = PlayerPrefs.GetInt("cash_hair_N[1]");
		cash_hair_N[2] = PlayerPrefs.GetInt("cash_hair_N[2]");
		cash_hair_N[3] = PlayerPrefs.GetInt("cash_hair_N[3]");
		cash_hair_N[4] = PlayerPrefs.GetInt("cash_hair_N[4]");
		cash_hair_N[5] = PlayerPrefs.GetInt("cash_hair_N[5]");
		cash_hair_N[6] = PlayerPrefs.GetInt("cash_hair_N[6]");
		cash_hair_N[7] = PlayerPrefs.GetInt("cash_hair_N[7]");
		cash_hair_N[8] = PlayerPrefs.GetInt("cash_hair_N[8]");
		cash_hair_N[9] = PlayerPrefs.GetInt("cash_hair_N[9]");
		cash_hair_N[10] = PlayerPrefs.GetInt("cash_hair_N[10]");
		cash_hair_N[11] = PlayerPrefs.GetInt("cash_hair_N[11]");
		cash_hair_N[12] = PlayerPrefs.GetInt("cash_hair_N[12]");
		cash_hair_N[13] = PlayerPrefs.GetInt("cash_hair_N[13]");
		if (cash_hair_N[0] == 1)
		{
			lock_m[34].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[1] == 1)
		{
			lock_m[35].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[2] == 1)
		{
			lock_m[36].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[3] == 1)
		{
			lock_w[34].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[4] == 1)
		{
			lock_w[35].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[5] == 1)
		{
			lock_w[36].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[6] == 1)
		{
			lock_m[37].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[7] == 1)
		{
			lock_w[37].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[8] == 1)
		{
			lock_m[38].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[9] == 1)
		{
			lock_w[38].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[10] == 1)
		{
			lock_m[39].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[11] == 1)
		{
			lock_w[39].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[12] == 1)
		{
			lock_m[40].GetComponent<Button>().interactable = false;
		}
		if (cash_hair_N[13] == 1)
		{
			lock_w[40].GetComponent<Button>().interactable = false;
		}
		if (Char.Sex == 0)
		{
			panel_man.SetActive(true);
			panel_woman.SetActive(false);
		}
		if (Char.Sex == 1)
		{
			panel_man.SetActive(false);
			panel_woman.SetActive(true);
		}
		Debug.LogFormat("옷넘버{0}", Clothes.Clothes_N);
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
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
	}

	private void FixedUpdate()
	{
	}

	public void reset()
	{
		s3_7.price = 0;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Head.Hair_N == 0)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char.Sex == 0)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			}
			if (Char.Sex == 1)
			{
				hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			}
		}
	}

	private void back()
	{
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.scene_3_6.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 0;
		Resources.UnloadUnusedAssets();
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = GameObject.Find("Tuto_2(Clone)");
			gameObject.GetComponent<Tuto_1>().NEXT();
		}
		Debug.Log("s3_6");
	}

	private void btn_buy()
	{
		Debug.LogFormat("계산할돈{0}", s3_7.price);
		scene_controll.panel_notice[7].SetActive(true);
		real_buy_price.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price);
		for (int i = 0; i < scene_controll.money_gem.Length; i++)
		{
			scene_controll.money_gem[i].SetActive(false);
		}
		scene_controll.money_gem[0].SetActive(true);
		if (scene_controll.money < s3_7.price)
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[1].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (s3_7.price == 0)
		{
			if (s3_7.price == 0 && s3_7.price_gem > 0)
			{
				scene_controll.panel_notice[7].SetActive(true);
				scene_controll.price_gem_text.GetComponent<Text>().text = string.Format("{0:n0}", s3_7.price_gem);
				for (int j = 0; j < scene_controll.money_gem.Length; j++)
				{
					scene_controll.money_gem[j].SetActive(false);
				}
				scene_controll.money_gem[1].SetActive(true);
				if (scene_controll.gem < s3_7.price_gem)
				{
					scene_controll.panel_notice[7].SetActive(false);
					scene_controll.panel_notice[0].SetActive(true);
					scene_controll.panel_notice[9].SetActive(true);
					Invoke("nothing", 1f);
				}
			}
			else
			{
				scene_controll.panel_notice[7].SetActive(false);
				scene_controll.panel_notice[0].SetActive(true);
				scene_controll.panel_notice[2].SetActive(true);
				Invoke("nothing", 1f);
			}
		}
		if (Head.Hair_N == 0 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 33"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 1 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 1")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 34"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 2 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 2")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 35"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 3 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 3")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 36"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 4 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 4")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 37"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 5 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 5")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 38"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 6 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 6")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 39"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 7 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 7")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 40"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 8 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 8")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 41"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 9 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 9")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 42"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 10 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 10")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 43"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 11 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 11")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 44"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 12 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 12")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 45"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 13 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 13")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 46"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 14 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 14")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 47"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 15 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 15")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 48"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 16 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 16")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 49"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 17 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 17")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 50"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 18 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 18")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 51"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 19 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 19")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 52"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 20 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 20")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 53"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 21 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 21")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 54"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 22 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 22")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 55"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 23 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 23")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 56"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 24 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 24")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 57"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 25 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 25")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 58"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 26 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 26")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 59"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 27 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 27")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 60"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 28 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 28")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 61"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 29 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 29")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 62"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 30 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 30")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 63"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 31 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 31")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 64"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 32 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 32")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 65"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 33 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 66")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 66"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 34 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 72")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 75"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 35 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 73")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 76"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 36 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 74")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 77"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 37 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 78")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 79"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 38 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 81")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 80"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 39 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 82")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 83"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
		if (Head.Hair_N == 40 && ((hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 84")) | (hair_load.runtimeAnimatorController == Resources.Load<RuntimeAnimatorController>("Load_hair 85"))))
		{
			scene_controll.panel_notice[7].SetActive(false);
			scene_controll.panel_notice[0].SetActive(true);
			scene_controll.panel_notice[2].SetActive(true);
			Invoke("nothing", 1f);
		}
	}

	public void btn_hair_0()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 33");
		}
	}

	public void btn_hair_1()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 1");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 34");
		}
	}

	public void btn_hair_2()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 2");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 35");
		}
	}

	public void btn_hair_3()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 3");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 36");
		}
	}

	public void btn_hair_4()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 4");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 37");
		}
	}

	public void btn_hair_5()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 5");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 38");
		}
	}

	public void btn_hair_6()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 6");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 39");
		}
	}

	public void btn_hair_7()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 7");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 40");
		}
	}

	public void btn_hair_8()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 8");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 41");
		}
	}

	public void btn_hair_9()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 9");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 42");
		}
	}

	public void btn_hair_10()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 10");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 43");
		}
	}

	public void btn_hair_11()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 11");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 44");
		}
	}

	public void btn_hair_12()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 12");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 45");
		}
	}

	public void btn_hair_13()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 13");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 46");
		}
	}

	public void btn_hair_14()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 14");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 47");
		}
	}

	public void btn_hair_15()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 15");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 48");
		}
	}

	public void btn_hair_16()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 16");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 49");
		}
	}

	public void btn_hair_17()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 17");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 50");
		}
	}

	public void btn_hair_18()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 18");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 51");
		}
	}

	public void btn_hair_19()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 19");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 52");
		}
	}

	public void btn_hair_20()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 20");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 53");
		}
	}

	public void btn_hair_21()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 21");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 54");
		}
	}

	public void btn_hair_22()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 22");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 55");
		}
	}

	public void btn_hair_23()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1200000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 23");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 56");
		}
	}

	public void btn_hair_24()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 24");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 57");
		}
	}

	public void btn_hair_25()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 25");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 58");
		}
	}

	public void btn_hair_26()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1400000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 26");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 59");
		}
	}

	public void btn_hair_27()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 27");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 60");
		}
	}

	public void btn_hair_28()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 28");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 61");
		}
	}

	public void btn_hair_29()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1600000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 29");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 62");
		}
	}

	public void btn_hair_30()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 30");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 63");
		}
	}

	public void btn_hair_31()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 31");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 64");
		}
	}

	public void btn_hair_32()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 1800000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 32");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 65");
		}
	}

	public void btn_hair_33()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 2000000;
		s3_7.price_gem = 0;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 66");
		}
	}

	public void btn_hair_34()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 40;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 72");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 75");
			s3_7.price = 0;
		}
	}

	public void btn_hair_35()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 80;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 73");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 76");
			s3_7.price = 0;
		}
	}

	public void btn_hair_36()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 120;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 74");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 77");
			s3_7.price = 0;
		}
	}

	public void btn_hair_37()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 120;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 78");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 79");
			s3_7.price = 0;
		}
	}

	public void btn_hair_38()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 120;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 81");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 80");
			s3_7.price = 0;
		}
	}

	public void btn_hair_39()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 120;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 82");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 83");
			s3_7.price = 0;
		}
	}

	public void btn_hair_40()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		s3_7.price = 0;
		s3_7.price_gem = 120;
		if (Char.Sex == 0)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 84");
			s3_7.price = 0;
		}
		if (Char.Sex == 1)
		{
			hair_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_hair 85");
			s3_7.price = 0;
		}
	}

	public void m_hairPrice()
	{
		s3_7.price = 50000;
	}

	public void w_hairPrice()
	{
		s3_7.price = 100000;
		Debug.Log("s3_7.price" + s3_7.price);
	}

	private void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}

	private void OnDestroy()
	{
	}
}
