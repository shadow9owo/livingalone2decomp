using UnityEngine;
using UnityEngine.UI;

public class AlbaLv : MonoBehaviour
{
	public GameObject[] Alba_Lv_T;

	public GameObject[] Alba_exp_bar;

	public GameObject[] Alba_money_T;

	public float[] Alba_exp;

	public float[] Alba_Lv;

	public float[] Alba_Maxexp;

	public void Awake()
	{
		Alba_Lv[0] = PlayerPrefs.GetFloat("Alba_Lv[0]");
		Alba_Lv[1] = PlayerPrefs.GetFloat("Alba_Lv[1]");
		Alba_Lv[2] = PlayerPrefs.GetFloat("Alba_Lv[2]");
		Alba_Lv[3] = PlayerPrefs.GetFloat("Alba_Lv[3]");
		Alba_Lv[4] = PlayerPrefs.GetFloat("Alba_Lv[4]");
		Alba_Lv[5] = PlayerPrefs.GetFloat("Alba_Lv[5]");
		Alba_Lv[6] = PlayerPrefs.GetFloat("Alba_Lv[6]");
		Alba_Lv[7] = PlayerPrefs.GetFloat("Alba_Lv[7]");
		Alba_Lv[8] = PlayerPrefs.GetFloat("Alba_Lv[8]");
		Alba_Lv[9] = PlayerPrefs.GetFloat("Alba_Lv[9]");
		Alba_exp[0] = PlayerPrefs.GetFloat("Alba_exp[0]");
		Alba_exp[1] = PlayerPrefs.GetFloat("Alba_exp[1]");
		Alba_exp[2] = PlayerPrefs.GetFloat("Alba_exp[2]");
		Alba_exp[3] = PlayerPrefs.GetFloat("Alba_exp[3]");
		Alba_exp[4] = PlayerPrefs.GetFloat("Alba_exp[4]");
		Alba_exp[5] = PlayerPrefs.GetFloat("Alba_exp[5]");
		Alba_exp[6] = PlayerPrefs.GetFloat("Alba_exp[6]");
		Alba_exp[7] = PlayerPrefs.GetFloat("Alba_exp[7]");
		Alba_exp[8] = PlayerPrefs.GetFloat("Alba_exp[8]");
		Alba_exp[9] = PlayerPrefs.GetFloat("Alba_exp[9]");
		Alba_Maxexp[0] = Alba_Lv[0] * 5f;
		Alba_Maxexp[1] = Alba_Lv[1] * 5f;
		Alba_Maxexp[2] = Alba_Lv[2] * 5f;
		Alba_Maxexp[3] = Alba_Lv[3] * 5f;
		Alba_Maxexp[4] = Alba_Lv[4] * 5f;
		Alba_Maxexp[5] = Alba_Lv[5] * 5f;
		Alba_Maxexp[6] = Alba_Lv[6] * 5f;
		Alba_Maxexp[7] = Alba_Lv[7] * 5f;
		Alba_Maxexp[8] = Alba_Lv[8] * 5f;
		Alba_Maxexp[9] = Alba_Lv[9] * 5f;
		Debug.Log("Alba_Lv[0]" + Alba_Lv[9] + " Alba_exp[0]" + Alba_exp[9] + "  Alba_Maxexp[0]" + Alba_Maxexp[9]);
	}

	private void Start()
	{
		LevelUP();
		Setbar();
		SetLvText();
		SaveLvExp();
		GetComponent<S2_4>().SetLv();
		GetComponent<S2_4>().SetAlbaPayMoney();
	}

	public void LevelUP()
	{
		if (Alba_exp[0] >= Alba_Maxexp[0])
		{
			if (Alba_Lv[0] < 20f)
			{
				Alba_Lv[0] += 1f;
			}
			Alba_exp[0] = 0f;
		}
		if (Alba_exp[1] >= Alba_Maxexp[1])
		{
			if (Alba_Lv[1] < 20f)
			{
				Alba_Lv[1] += 1f;
			}
			Alba_exp[1] = 0f;
		}
		if (Alba_exp[2] >= Alba_Maxexp[2])
		{
			if (Alba_Lv[2] < 20f)
			{
				Alba_Lv[2] += 1f;
			}
			Alba_exp[2] = 0f;
		}
		if (Alba_exp[3] >= Alba_Maxexp[3])
		{
			if (Alba_Lv[3] < 20f)
			{
				Alba_Lv[3] += 1f;
			}
			Alba_exp[3] = 0f;
		}
		if (Alba_exp[4] >= Alba_Maxexp[4])
		{
			if (Alba_Lv[4] < 20f)
			{
				Alba_Lv[4] += 1f;
			}
			Alba_exp[4] = 0f;
		}
		if (Alba_exp[5] >= Alba_Maxexp[5])
		{
			if (Alba_Lv[5] < 20f)
			{
				Alba_Lv[5] += 1f;
			}
			Alba_exp[5] = 0f;
		}
		if (Alba_exp[6] >= Alba_Maxexp[6])
		{
			if (Alba_Lv[6] < 20f)
			{
				Alba_Lv[6] += 1f;
			}
			Alba_exp[6] = 0f;
		}
		if (Alba_exp[7] >= Alba_Maxexp[7])
		{
			if (Alba_Lv[7] < 20f)
			{
				Alba_Lv[7] += 1f;
			}
			Alba_exp[7] = 0f;
		}
		if (Alba_exp[8] >= Alba_Maxexp[8])
		{
			if (Alba_Lv[8] < 20f)
			{
				Alba_Lv[8] += 1f;
			}
			Alba_exp[8] = 0f;
		}
		if (Alba_exp[9] >= Alba_Maxexp[9])
		{
			Alba_Lv[9] += 1f;
			Alba_exp[9] = 0f;
		}
		Alba_Maxexp[0] = Alba_Lv[0] * 5f;
		Alba_Maxexp[1] = Alba_Lv[1] * 5f;
		Alba_Maxexp[2] = Alba_Lv[2] * 5f;
		Alba_Maxexp[3] = Alba_Lv[3] * 5f;
		Alba_Maxexp[4] = Alba_Lv[4] * 5f;
		Alba_Maxexp[5] = Alba_Lv[5] * 5f;
		Alba_Maxexp[6] = Alba_Lv[6] * 5f;
		Alba_Maxexp[7] = Alba_Lv[7] * 5f;
		Alba_Maxexp[8] = Alba_Lv[8] * 5f;
		Alba_Maxexp[9] = Alba_Lv[9] * 5f;
	}

	public void Setbar()
	{
		Alba_exp_bar[0].GetComponent<Image>().fillAmount = Alba_exp[0] / Alba_Maxexp[0];
		Alba_exp_bar[1].GetComponent<Image>().fillAmount = Alba_exp[1] / Alba_Maxexp[1];
		Alba_exp_bar[2].GetComponent<Image>().fillAmount = Alba_exp[2] / Alba_Maxexp[2];
		Alba_exp_bar[3].GetComponent<Image>().fillAmount = Alba_exp[3] / Alba_Maxexp[3];
		Alba_exp_bar[4].GetComponent<Image>().fillAmount = Alba_exp[4] / Alba_Maxexp[4];
		Alba_exp_bar[5].GetComponent<Image>().fillAmount = Alba_exp[5] / Alba_Maxexp[5];
		Alba_exp_bar[6].GetComponent<Image>().fillAmount = Alba_exp[6] / Alba_Maxexp[6];
		Alba_exp_bar[7].GetComponent<Image>().fillAmount = Alba_exp[7] / Alba_Maxexp[7];
		Alba_exp_bar[8].GetComponent<Image>().fillAmount = Alba_exp[8] / Alba_Maxexp[8];
		Alba_exp_bar[9].GetComponent<Image>().fillAmount = Alba_exp[9] / Alba_Maxexp[9];
	}

	public void SetLvText()
	{
		if (Alba_Lv[0] >= 20f)
		{
			Alba_Lv_T[0].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[0].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[0].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[0]);
			Alba_Lv_T[0].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[1] >= 20f)
		{
			Alba_Lv_T[1].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[1].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[1].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[1]);
			Alba_Lv_T[1].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[2] >= 20f)
		{
			Alba_Lv_T[2].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[2].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[2].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[2]);
			Alba_Lv_T[2].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[3] >= 20f)
		{
			Alba_Lv_T[3].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[3].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[3].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[3]);
			Alba_Lv_T[3].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[4] >= 20f)
		{
			Alba_Lv_T[4].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[4].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[4].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[4]);
			Alba_Lv_T[4].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[5] >= 20f)
		{
			Alba_Lv_T[5].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[5].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[5].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[5]);
			Alba_Lv_T[5].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[6] >= 20f)
		{
			Alba_Lv_T[6].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[6].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[6].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[6]);
			Alba_Lv_T[6].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[7] >= 20f)
		{
			Alba_Lv_T[7].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[7].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[7].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[7]);
			Alba_Lv_T[7].GetComponent<Text>().color = Color.black;
		}
		if (Alba_Lv[8] >= 20f)
		{
			Alba_Lv_T[8].GetComponent<Text>().text = string.Format("LV.MAX");
			Alba_Lv_T[8].GetComponent<Text>().color = Color.red;
		}
		else
		{
			Alba_Lv_T[8].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[8]);
			Alba_Lv_T[8].GetComponent<Text>().color = Color.black;
		}
		Alba_Lv_T[9].GetComponent<Text>().text = string.Format("LV.{0}", Alba_Lv[9]);
	}

	public void SetLvMoney()
	{
		if (S2_4.Albapaybuff == 0)
		{
			Alba_money_T[0].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_1 + (float)S2_4.albamon_1 * S2_4.Buff_pluspay));
			Alba_money_T[1].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_2 + (float)S2_4.albamon_2 * S2_4.Buff_pluspay));
			Alba_money_T[2].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_3 + (float)S2_4.albamon_3 * S2_4.Buff_pluspay));
			Alba_money_T[3].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_4 + (float)S2_4.albamon_4 * S2_4.Buff_pluspay));
			Alba_money_T[4].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_5 + (float)S2_4.albamon_5 * S2_4.Buff_pluspay));
			Alba_money_T[5].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_6 + (float)S2_4.albamon_6 * S2_4.Buff_pluspay));
			Alba_money_T[6].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_7 + (float)S2_4.albamon_7 * S2_4.Buff_pluspay));
			Alba_money_T[7].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_8 + (float)S2_4.albamon_8 * S2_4.Buff_pluspay));
			Alba_money_T[8].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_9 + (float)S2_4.albamon_9 * S2_4.Buff_pluspay));
			Alba_money_T[9].GetComponent<Text>().text = string.Format("{0:n0}", (long)((float)S2_4.albamon_10 + (float)S2_4.albamon_10 * S2_4.Buff_pluspay));
		}
		if (S2_4.Albapaybuff == 1)
		{
			Alba_money_T[0].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_1 + (float)S2_4.albamon_1 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[1].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_2 + (float)S2_4.albamon_2 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[2].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_3 + (float)S2_4.albamon_3 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[3].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_4 + (float)S2_4.albamon_4 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[4].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_5 + (float)S2_4.albamon_5 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[5].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_6 + (float)S2_4.albamon_6 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[6].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_7 + (float)S2_4.albamon_7 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[7].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_8 + (float)S2_4.albamon_8 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[8].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_9 + (float)S2_4.albamon_9 * S2_4.Buff_pluspay) * 1.2f);
			Alba_money_T[9].GetComponent<Text>().text = string.Format("{0:n0}", (float)(long)((float)S2_4.albamon_10 + (float)S2_4.albamon_10 * S2_4.Buff_pluspay) * 1.2f);
		}
	}

	public void SaveLvExp()
	{
		PlayerPrefs.SetFloat("Alba_Lv[0]", Alba_Lv[0]);
		PlayerPrefs.SetFloat("Alba_Lv[1]", Alba_Lv[1]);
		PlayerPrefs.SetFloat("Alba_Lv[2]", Alba_Lv[2]);
		PlayerPrefs.SetFloat("Alba_Lv[3]", Alba_Lv[3]);
		PlayerPrefs.SetFloat("Alba_Lv[4]", Alba_Lv[4]);
		PlayerPrefs.SetFloat("Alba_Lv[5]", Alba_Lv[5]);
		PlayerPrefs.SetFloat("Alba_Lv[6]", Alba_Lv[6]);
		PlayerPrefs.SetFloat("Alba_Lv[7]", Alba_Lv[7]);
		PlayerPrefs.SetFloat("Alba_Lv[8]", Alba_Lv[8]);
		PlayerPrefs.SetFloat("Alba_Lv[9]", Alba_Lv[9]);
		PlayerPrefs.SetFloat("Alba_exp[0]", Alba_exp[0]);
		PlayerPrefs.SetFloat("Alba_exp[1]", Alba_exp[1]);
		PlayerPrefs.SetFloat("Alba_exp[2]", Alba_exp[2]);
		PlayerPrefs.SetFloat("Alba_exp[3]", Alba_exp[3]);
		PlayerPrefs.SetFloat("Alba_exp[4]", Alba_exp[4]);
		PlayerPrefs.SetFloat("Alba_exp[5]", Alba_exp[5]);
		PlayerPrefs.SetFloat("Alba_exp[6]", Alba_exp[6]);
		PlayerPrefs.SetFloat("Alba_exp[7]", Alba_exp[7]);
		PlayerPrefs.SetFloat("Alba_exp[8]", Alba_exp[8]);
		PlayerPrefs.SetFloat("Alba_exp[9]", Alba_exp[9]);
	}
}
