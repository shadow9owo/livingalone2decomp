using UnityEngine;
using UnityEngine.UI;

public class s3_5 : MonoBehaviour
{
	public Animator clothse_load;

	public scene_controll scene_controll;

	public s3_7 s3_7;

	public s3_6 s3_6;

	public GameObject[] already_buy_lock_w;

	public GameObject[] already_buy_lock_m;

	public Transform real_buy_price;

	public int[] cont_w_clothse;

	public int[] cont_m_clothse;

	public GameObject clo_man;

	public GameObject clo_woman;

	private void Awake()
	{
		if (TutorialCont.Tutorial_Int == 0)
		{
			if (Char.Sex == 0)
			{
				for (int i = 0; i < already_buy_lock_m.Length; i++)
				{
					already_buy_lock_m[i].GetComponent<Button>().interactable = false;
				}
			}
			if (Char.Sex == 1)
			{
				for (int j = 0; j < already_buy_lock_w.Length; j++)
				{
					already_buy_lock_w[j].GetComponent<Button>().interactable = false;
				}
			}
		}
		else
		{
			for (int k = 0; k < already_buy_lock_m.Length; k++)
			{
				already_buy_lock_m[k].GetComponent<Button>().interactable = true;
			}
			for (int l = 0; l < already_buy_lock_w.Length; l++)
			{
				already_buy_lock_w[l].GetComponent<Button>().interactable = true;
			}
		}
		CashCont.Scene_String = "3-5";
		Char.Sex = PlayerPrefs.GetInt("Sex");
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		scene_controll.head_load.SetActive(true);
		scene_controll.clothse_load.SetActive(true);
		Debug.LogFormat("성별{0}", Char.Sex);
		Debug.LogFormat("옷{0}", Clothes.Clothes_N);
		if (Char.Sex == 0)
		{
			clo_man.SetActive(true);
			clo_woman.SetActive(false);
		}
		if (Char.Sex == 1)
		{
			clo_man.SetActive(false);
			clo_woman.SetActive(true);
		}
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
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
		cont_w_clothse[1] = PlayerPrefs.GetInt("cont_w_clothse[1]");
		cont_w_clothse[2] = PlayerPrefs.GetInt("cont_w_clothse[2]");
		cont_w_clothse[3] = PlayerPrefs.GetInt("cont_w_clothse[3]");
		cont_w_clothse[4] = PlayerPrefs.GetInt("cont_w_clothse[4]");
		cont_w_clothse[5] = PlayerPrefs.GetInt("cont_w_clothse[5]");
		cont_w_clothse[6] = PlayerPrefs.GetInt("cont_w_clothse[6]");
		cont_w_clothse[7] = PlayerPrefs.GetInt("cont_w_clothse[7]");
		cont_w_clothse[8] = PlayerPrefs.GetInt("cont_w_clothse[8]");
		cont_w_clothse[9] = PlayerPrefs.GetInt("cont_w_clothse[9]");
		cont_w_clothse[10] = PlayerPrefs.GetInt("cont_w_clothse[10]");
		cont_w_clothse[11] = PlayerPrefs.GetInt("cont_w_clothse[11]");
		cont_w_clothse[12] = PlayerPrefs.GetInt("cont_w_clothse[12]");
		cont_w_clothse[13] = PlayerPrefs.GetInt("cont_w_clothse[13]");
		cont_w_clothse[14] = PlayerPrefs.GetInt("cont_w_clothse[14]");
		cont_w_clothse[15] = PlayerPrefs.GetInt("cont_w_clothse[15]");
		cont_w_clothse[16] = PlayerPrefs.GetInt("cont_w_clothse[16]");
		cont_w_clothse[17] = PlayerPrefs.GetInt("cont_w_clothse[17]");
		cont_w_clothse[18] = PlayerPrefs.GetInt("cont_w_clothse[18]");
		cont_w_clothse[19] = PlayerPrefs.GetInt("cont_w_clothse[19]");
		cont_w_clothse[20] = PlayerPrefs.GetInt("cont_w_clothse[20]");
		cont_w_clothse[21] = PlayerPrefs.GetInt("cont_w_clothse[21]");
		cont_w_clothse[22] = PlayerPrefs.GetInt("cont_w_clothse[22]");
		cont_w_clothse[23] = PlayerPrefs.GetInt("cont_w_clothse[23]");
		cont_w_clothse[24] = PlayerPrefs.GetInt("cont_w_clothse[24]");
		cont_w_clothse[25] = PlayerPrefs.GetInt("cont_w_clothse[25]");
		cont_w_clothse[26] = PlayerPrefs.GetInt("cont_w_clothse[26]");
		cont_w_clothse[27] = PlayerPrefs.GetInt("cont_w_clothse[27]");
		cont_w_clothse[28] = PlayerPrefs.GetInt("cont_w_clothse[28]");
		cont_w_clothse[29] = PlayerPrefs.GetInt("cont_w_clothse[29]");
		cont_w_clothse[30] = PlayerPrefs.GetInt("cont_w_clothse[30]");
		cont_w_clothse[31] = PlayerPrefs.GetInt("cont_w_clothse[31]");
		cont_w_clothse[32] = PlayerPrefs.GetInt("cont_w_clothse[32]");
		cont_w_clothse[33] = PlayerPrefs.GetInt("cont_w_clothse[33]");
		cont_w_clothse[34] = PlayerPrefs.GetInt("cont_w_clothse[34]");
		cont_w_clothse[35] = PlayerPrefs.GetInt("cont_w_clothse[35]");
		cont_w_clothse[36] = PlayerPrefs.GetInt("cont_w_clothse[36]");
		cont_w_clothse[37] = PlayerPrefs.GetInt("cont_w_clothse[37]");
		cont_w_clothse[38] = PlayerPrefs.GetInt("cont_w_clothse[38]");
		cont_w_clothse[39] = PlayerPrefs.GetInt("cont_w_clothse[39]");
		cont_w_clothse[40] = PlayerPrefs.GetInt("cont_w_clothse[40]");
		cont_w_clothse[41] = PlayerPrefs.GetInt("cont_w_clothse[41]");
		cont_w_clothse[42] = PlayerPrefs.GetInt("cont_w_clothse[42]");
		cont_w_clothse[43] = PlayerPrefs.GetInt("cont_w_clothse[43]");
		cont_w_clothse[44] = PlayerPrefs.GetInt("cont_w_clothse[44]");
		cont_w_clothse[45] = PlayerPrefs.GetInt("cont_w_clothse[45]");
		cont_w_clothse[46] = PlayerPrefs.GetInt("cont_w_clothse[46]");
		cont_w_clothse[47] = PlayerPrefs.GetInt("cont_w_clothse[47]");
		cont_w_clothse[48] = PlayerPrefs.GetInt("cont_w_clothse[48]");
		cont_m_clothse[1] = PlayerPrefs.GetInt("cont_m_clothse[1]");
		cont_m_clothse[2] = PlayerPrefs.GetInt("cont_m_clothse[2]");
		cont_m_clothse[3] = PlayerPrefs.GetInt("cont_m_clothse[3]");
		cont_m_clothse[4] = PlayerPrefs.GetInt("cont_m_clothse[4]");
		cont_m_clothse[5] = PlayerPrefs.GetInt("cont_m_clothse[5]");
		cont_m_clothse[6] = PlayerPrefs.GetInt("cont_m_clothse[6]");
		cont_m_clothse[7] = PlayerPrefs.GetInt("cont_m_clothse[7]");
		cont_m_clothse[8] = PlayerPrefs.GetInt("cont_m_clothse[8]");
		cont_m_clothse[9] = PlayerPrefs.GetInt("cont_m_clothse[9]");
		cont_m_clothse[10] = PlayerPrefs.GetInt("cont_m_clothse[10]");
		cont_m_clothse[11] = PlayerPrefs.GetInt("cont_m_clothse[11]");
		cont_m_clothse[12] = PlayerPrefs.GetInt("cont_m_clothse[12]");
		cont_m_clothse[13] = PlayerPrefs.GetInt("cont_m_clothse[13]");
		cont_m_clothse[14] = PlayerPrefs.GetInt("cont_m_clothse[14]");
		cont_m_clothse[15] = PlayerPrefs.GetInt("cont_m_clothse[15]");
		cont_m_clothse[16] = PlayerPrefs.GetInt("cont_m_clothse[16]");
		cont_m_clothse[17] = PlayerPrefs.GetInt("cont_m_clothse[17]");
		cont_m_clothse[18] = PlayerPrefs.GetInt("cont_m_clothse[18]");
		cont_m_clothse[19] = PlayerPrefs.GetInt("cont_m_clothse[19]");
		cont_m_clothse[20] = PlayerPrefs.GetInt("cont_m_clothse[20]");
		cont_m_clothse[21] = PlayerPrefs.GetInt("cont_m_clothse[21]");
		cont_m_clothse[22] = PlayerPrefs.GetInt("cont_m_clothse[22]");
		cont_m_clothse[23] = PlayerPrefs.GetInt("cont_m_clothse[23]");
		cont_m_clothse[24] = PlayerPrefs.GetInt("cont_m_clothse[24]");
		cont_m_clothse[25] = PlayerPrefs.GetInt("cont_m_clothse[25]");
		cont_m_clothse[26] = PlayerPrefs.GetInt("cont_m_clothse[26]");
		cont_m_clothse[27] = PlayerPrefs.GetInt("cont_m_clothse[27]");
		cont_m_clothse[28] = PlayerPrefs.GetInt("cont_m_clothse[28]");
		cont_m_clothse[29] = PlayerPrefs.GetInt("cont_m_clothse[29]");
		cont_m_clothse[30] = PlayerPrefs.GetInt("cont_m_clothse[30]");
		cont_m_clothse[31] = PlayerPrefs.GetInt("cont_m_clothse[31]");
		cont_m_clothse[32] = PlayerPrefs.GetInt("cont_m_clothse[32]");
		cont_m_clothse[33] = PlayerPrefs.GetInt("cont_m_clothse[33]");
		cont_m_clothse[34] = PlayerPrefs.GetInt("cont_m_clothse[34]");
		cont_m_clothse[35] = PlayerPrefs.GetInt("cont_m_clothse[35]");
		cont_m_clothse[36] = PlayerPrefs.GetInt("cont_m_clothse[36]");
		cont_m_clothse[37] = PlayerPrefs.GetInt("cont_m_clothse[37]");
		cont_m_clothse[38] = PlayerPrefs.GetInt("cont_m_clothse[38]");
		cont_m_clothse[39] = PlayerPrefs.GetInt("cont_m_clothse[39]");
		cont_m_clothse[40] = PlayerPrefs.GetInt("cont_m_clothse[40]");
		cont_m_clothse[41] = PlayerPrefs.GetInt("cont_m_clothse[41]");
		cont_m_clothse[42] = PlayerPrefs.GetInt("cont_m_clothse[42]");
		cont_m_clothse[43] = PlayerPrefs.GetInt("cont_m_clothse[43]");
		cont_m_clothse[44] = PlayerPrefs.GetInt("cont_m_clothse[44]");
		cont_m_clothse[45] = PlayerPrefs.GetInt("cont_m_clothse[45]");
		cont_m_clothse[46] = PlayerPrefs.GetInt("cont_m_clothse[46]");
		cont_m_clothse[47] = PlayerPrefs.GetInt("cont_m_clothse[47]");
		cont_m_clothse[48] = PlayerPrefs.GetInt("cont_m_clothse[48]");
		if (Char.Sex == 1)
		{
			if (cont_w_clothse[1] == 1)
			{
				already_buy_lock_w[0].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[2] == 1)
			{
				already_buy_lock_w[1].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[3] == 1)
			{
				already_buy_lock_w[2].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[4] == 1)
			{
				already_buy_lock_w[3].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[5] == 1)
			{
				already_buy_lock_w[4].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[6] == 1)
			{
				already_buy_lock_w[5].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[7] == 1)
			{
				already_buy_lock_w[6].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[8] == 1)
			{
				already_buy_lock_w[7].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[9] == 1)
			{
				already_buy_lock_w[8].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[10] == 1)
			{
				already_buy_lock_w[9].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[11] == 1)
			{
				already_buy_lock_w[10].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[12] == 1)
			{
				already_buy_lock_w[11].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[13] == 1)
			{
				already_buy_lock_w[12].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[14] == 1)
			{
				already_buy_lock_w[13].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[15] == 1)
			{
				already_buy_lock_w[14].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[16] == 1)
			{
				already_buy_lock_w[15].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[17] == 1)
			{
				already_buy_lock_w[16].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[18] == 1)
			{
				already_buy_lock_w[17].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[19] == 1)
			{
				already_buy_lock_w[18].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[20] == 1)
			{
				already_buy_lock_w[19].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[21] == 1)
			{
				already_buy_lock_w[20].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[22] == 1)
			{
				already_buy_lock_w[21].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[23] == 1)
			{
				already_buy_lock_w[22].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[24] == 1)
			{
				already_buy_lock_w[23].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[25] == 1)
			{
				already_buy_lock_w[24].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[26] == 1)
			{
				already_buy_lock_w[25].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[27] == 1)
			{
				already_buy_lock_w[26].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[28] == 1)
			{
				already_buy_lock_w[27].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[29] == 1)
			{
				already_buy_lock_w[28].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[30] == 1)
			{
				already_buy_lock_w[29].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[31] == 1)
			{
				already_buy_lock_w[30].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[32] == 1)
			{
				already_buy_lock_w[31].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[33] == 1)
			{
				already_buy_lock_w[32].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[34] == 1)
			{
				already_buy_lock_w[33].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[35] == 1)
			{
				already_buy_lock_w[34].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[36] == 1)
			{
				already_buy_lock_w[35].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[37] == 1)
			{
				already_buy_lock_w[36].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[38] == 1)
			{
				already_buy_lock_w[37].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[39] == 1)
			{
				already_buy_lock_w[38].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[40] == 1)
			{
				already_buy_lock_w[39].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[41] == 1)
			{
				already_buy_lock_w[40].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[42] == 1)
			{
				already_buy_lock_w[41].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[43] == 1)
			{
				already_buy_lock_w[42].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[44] == 1)
			{
				already_buy_lock_w[43].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[45] == 1)
			{
				already_buy_lock_w[44].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[46] == 1)
			{
				already_buy_lock_w[45].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[47] == 1)
			{
				already_buy_lock_w[46].GetComponent<Button>().interactable = false;
			}
			if (cont_w_clothse[48] == 1)
			{
				already_buy_lock_w[47].GetComponent<Button>().interactable = false;
			}
		}
		else
		{
			if (cont_m_clothse[1] == 1)
			{
				already_buy_lock_m[0].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[2] == 1)
			{
				already_buy_lock_m[1].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[3] == 1)
			{
				already_buy_lock_m[2].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[4] == 1)
			{
				already_buy_lock_m[3].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[5] == 1)
			{
				already_buy_lock_m[4].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[6] == 1)
			{
				already_buy_lock_m[5].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[7] == 1)
			{
				already_buy_lock_m[6].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[8] == 1)
			{
				already_buy_lock_m[7].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[9] == 1)
			{
				already_buy_lock_m[8].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[10] == 1)
			{
				already_buy_lock_m[9].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[11] == 1)
			{
				already_buy_lock_m[10].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[12] == 1)
			{
				already_buy_lock_m[11].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[13] == 1)
			{
				already_buy_lock_m[12].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[14] == 1)
			{
				already_buy_lock_m[13].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[15] == 1)
			{
				already_buy_lock_m[14].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[16] == 1)
			{
				already_buy_lock_m[15].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[17] == 1)
			{
				already_buy_lock_m[16].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[18] == 1)
			{
				already_buy_lock_m[17].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[19] == 1)
			{
				already_buy_lock_m[18].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[20] == 1)
			{
				already_buy_lock_m[19].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[21] == 1)
			{
				already_buy_lock_m[20].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[22] == 1)
			{
				already_buy_lock_m[21].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[23] == 1)
			{
				already_buy_lock_m[22].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[24] == 1)
			{
				already_buy_lock_m[23].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[25] == 1)
			{
				already_buy_lock_m[24].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[26] == 1)
			{
				already_buy_lock_m[25].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[27] == 1)
			{
				already_buy_lock_m[26].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[28] == 1)
			{
				already_buy_lock_m[27].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[29] == 1)
			{
				already_buy_lock_m[28].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[30] == 1)
			{
				already_buy_lock_m[29].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[31] == 1)
			{
				already_buy_lock_m[30].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[32] == 1)
			{
				already_buy_lock_m[31].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[33] == 1)
			{
				already_buy_lock_m[32].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[34] == 1)
			{
				already_buy_lock_m[33].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[35] == 1)
			{
				already_buy_lock_m[34].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[36] == 1)
			{
				already_buy_lock_m[35].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[37] == 1)
			{
				already_buy_lock_m[36].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[38] == 1)
			{
				already_buy_lock_m[37].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[39] == 1)
			{
				already_buy_lock_m[38].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[40] == 1)
			{
				already_buy_lock_m[39].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[41] == 1)
			{
				already_buy_lock_m[40].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[42] == 1)
			{
				already_buy_lock_m[41].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[43] == 1)
			{
				already_buy_lock_m[42].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[44] == 1)
			{
				already_buy_lock_m[43].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[45] == 1)
			{
				already_buy_lock_m[44].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[46] == 1)
			{
				already_buy_lock_m[45].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[47] == 1)
			{
				already_buy_lock_m[46].GetComponent<Button>().interactable = false;
			}
			if (cont_m_clothse[48] == 1)
			{
				already_buy_lock_m[47].GetComponent<Button>().interactable = false;
			}
		}
	}

	private void FixedUpdate()
	{
	}

	public void back()
	{
		s3_7.price = 0;
		s3_7.price_gem = 0;
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(false);
		scene_controll.scene_3_5.SetActive(false);
		scene_controll.scene_3_1.SetActive(true);
		Resources.UnloadUnusedAssets();
		if (TutorialCont.Tutorial_Int == 0)
		{
			GameObject gameObject = GameObject.Find("Tuto_2(Clone)");
			gameObject.GetComponent<Tuto_1>().NEXT();
		}
	}

	private void btn_buy()
	{
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
		if (s3_7.price != 0)
		{
			return;
		}
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

	private void reset()
	{
		s3_7.price = 0;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		Debug.LogFormat("옷넘버{0}", Clothes.Clothes_N);
		if (Clothes.Clothes_N == 0)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
		}
		if (Clothes.Clothes_N == 1)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
			}
		}
		if (Clothes.Clothes_N == 2)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
			}
		}
		if (Clothes.Clothes_N == 3)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
			}
		}
		if (Clothes.Clothes_N == 4)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
			}
		}
		if (Clothes.Clothes_N == 5)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
			}
		}
		if (Clothes.Clothes_N == 6)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
			}
		}
		if (Clothes.Clothes_N == 7)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
			}
		}
		if (Clothes.Clothes_N == 8)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
			}
		}
		if (Clothes.Clothes_N == 9)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
			}
		}
		if (Clothes.Clothes_N == 10)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
			}
		}
		if (Clothes.Clothes_N == 11)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
			}
		}
		if (Clothes.Clothes_N == 12)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
			}
		}
		if (Clothes.Clothes_N == 13)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
			}
		}
		if (Clothes.Clothes_N == 14)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
			}
		}
		if (Clothes.Clothes_N == 15)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
			}
		}
		if (Clothes.Clothes_N == 16)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
			}
		}
		if (Clothes.Clothes_N == 17)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
			}
		}
		if (Clothes.Clothes_N == 18)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
			}
		}
		if (Clothes.Clothes_N == 19)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
			}
		}
		if (Clothes.Clothes_N == 20)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
			}
		}
		if (Clothes.Clothes_N == 21)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
			}
		}
		if (Clothes.Clothes_N == 22)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
			}
		}
		if (Clothes.Clothes_N == 23)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
			}
		}
		if (Clothes.Clothes_N == 24)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
			}
		}
		if (Clothes.Clothes_N == 25)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
			}
		}
		if (Clothes.Clothes_N == 26)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
			}
		}
		if (Clothes.Clothes_N == 27)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
			}
		}
		if (Clothes.Clothes_N == 28)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
			}
		}
		if (Clothes.Clothes_N == 29)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
			}
		}
		if (Clothes.Clothes_N == 30)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
			}
		}
		if (Clothes.Clothes_N == 31)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
			}
		}
		if (Clothes.Clothes_N == 32)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
			}
		}
		if (Clothes.Clothes_N == 33)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
			}
		}
		if (Clothes.Clothes_N == 34)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
			}
		}
		if (Clothes.Clothes_N == 35)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
			}
		}
		if (Clothes.Clothes_N == 36)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
			}
		}
		if (Clothes.Clothes_N == 37)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
			}
		}
		if (Clothes.Clothes_N == 38)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
			}
		}
		if (Clothes.Clothes_N == 39)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
			}
		}
		if (Clothes.Clothes_N == 40)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
			}
		}
		if (Clothes.Clothes_N == 41)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
			}
		}
		if (Clothes.Clothes_N == 42)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
			}
		}
		if (Clothes.Clothes_N == 43)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
			}
		}
		if (Clothes.Clothes_N == 44)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
			}
		}
		if (Clothes.Clothes_N == 45)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
			}
		}
		if (Clothes.Clothes_N == 46)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
			}
		}
		if (Clothes.Clothes_N == 47)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
			}
		}
		if (Clothes.Clothes_N == 48)
		{
			if (Char.Sex == 0)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
			}
			if (Char.Sex == 1)
			{
				clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
			}
		}
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

	public void btn_clo_0()
	{
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 41");
		}
	}

	public void btn_clo_1()
	{
		s3_7.price = 30000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 1");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 42");
		}
	}

	public void btn_clo_2()
	{
		s3_7.price = 30000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 2");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 43");
		}
	}

	public void btn_clo_3()
	{
		s3_7.price = 30000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 3");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 44");
		}
	}

	public void btn_clo_4()
	{
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 4");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 45");
		}
	}

	public void btn_clo_5()
	{
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 5");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 46");
		}
	}

	public void btn_clo_6()
	{
		s3_7.price = 50000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 6");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 47");
		}
	}

	public void btn_clo_7()
	{
		s3_7.price = 70000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 7");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 48");
		}
	}

	public void btn_clo_8()
	{
		s3_7.price = 70000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 8");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 49");
		}
	}

	public void btn_clo_9()
	{
		s3_7.price = 70000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 9");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 50");
		}
	}

	public void btn_clo_10()
	{
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 10");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 51");
		}
	}

	public void btn_clo_11()
	{
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 11");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 52");
		}
	}

	public void btn_clo_12()
	{
		s3_7.price = 100000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 12");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 53");
		}
	}

	public void btn_clo_13()
	{
		s3_7.price = 150000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 13");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 54");
		}
	}

	public void btn_clo_14()
	{
		s3_7.price = 150000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 14");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 55");
		}
	}

	public void btn_clo_15()
	{
		s3_7.price = 150000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 15");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 56");
		}
	}

	public void btn_clo_16()
	{
		s3_7.price = 300000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 16");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 57");
		}
	}

	public void btn_clo_17()
	{
		s3_7.price = 300000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 17");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 58");
		}
	}

	public void btn_clo_18()
	{
		s3_7.price = 300000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 18");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 59");
		}
	}

	public void btn_clo_19()
	{
		s3_7.price = 500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 19");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 60");
		}
	}

	public void btn_clo_20()
	{
		s3_7.price = 500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 20");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 61");
		}
	}

	public void btn_clo_21()
	{
		s3_7.price = 500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 21");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 62");
		}
	}

	public void btn_clo_22()
	{
		s3_7.price = 700000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 22");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 63");
		}
	}

	public void btn_clo_23()
	{
		s3_7.price = 700000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 23");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 64");
		}
	}

	public void btn_clo_24()
	{
		s3_7.price = 700000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 24");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 65");
		}
	}

	public void btn_clo_25()
	{
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 25");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 66");
		}
	}

	public void btn_clo_26()
	{
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 26");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 67");
		}
	}

	public void btn_clo_27()
	{
		s3_7.price = 1000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 27");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 68");
		}
	}

	public void btn_clo_28()
	{
		s3_7.price = 1500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 28");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 69");
		}
	}

	public void btn_clo_29()
	{
		s3_7.price = 1500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 29");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 70");
		}
	}

	public void btn_clo_30()
	{
		s3_7.price = 1500000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 30");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 71");
		}
	}

	public void btn_clo_31()
	{
		s3_7.price = 3000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 31");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 72");
		}
	}

	public void btn_clo_32()
	{
		s3_7.price = 3000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 32");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 73");
		}
	}

	public void btn_clo_33()
	{
		s3_7.price = 3000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 33");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 74");
		}
	}

	public void btn_clo_34()
	{
		s3_7.price = 5000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 34");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 75");
		}
	}

	public void btn_clo_35()
	{
		s3_7.price = 5000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 35");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 76");
		}
	}

	public void btn_clo_36()
	{
		s3_7.price = 5000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 36");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 77");
		}
	}

	public void btn_clo_37()
	{
		s3_7.price = 7000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 37");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 78");
		}
	}

	public void btn_clo_38()
	{
		s3_7.price = 7000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 38");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 79");
		}
	}

	public void btn_clo_39()
	{
		s3_7.price = 7000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 39");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 80");
		}
	}

	public void btn_clo_40()
	{
		s3_7.price = 10000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 40");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 81");
		}
	}

	public void btn_clo_41()
	{
		s3_7.price = 10000000;
		s3_7.price_gem = 0;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 82");
		}
	}

	public void btn_clo_42()
	{
		s3_7.price = 0;
		s3_7.price_gem = 60;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack1_1");
		}
	}

	public void btn_clo_43()
	{
		s3_7.price = 0;
		s3_7.price_gem = 120;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack2_1");
		}
	}

	public void btn_clo_44()
	{
		s3_7.price = 0;
		s3_7.price_gem = 180;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack3_1");
		}
	}

	public void btn_clo_45()
	{
		s3_7.price = 0;
		s3_7.price_gem = 120;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo_pack4_1");
		}
	}

	public void btn_clo_46()
	{
		s3_7.price = 0;
		s3_7.price_gem = 120;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 94");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 93");
		}
	}

	public void btn_clo_47()
	{
		s3_7.price = 0;
		s3_7.price_gem = 120;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 95");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 97");
		}
	}

	public void btn_clo_48()
	{
		s3_7.price = 0;
		s3_7.price_gem = 60;
		scene_controll.clothse_load.SetActive(false);
		scene_controll.head_load.SetActive(false);
		scene_controll.clothse_load.SetActive(true);
		scene_controll.head_load.SetActive(true);
		if (Char.Sex == 0)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 96");
		}
		if (Char.Sex == 1)
		{
			clothse_load.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Load_clo 98");
		}
	}

	private void nothing()
	{
		for (int i = 0; i < scene_controll.panel_notice.Length; i++)
		{
			scene_controll.panel_notice[i].SetActive(false);
		}
	}
}
