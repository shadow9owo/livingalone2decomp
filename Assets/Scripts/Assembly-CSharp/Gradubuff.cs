using UnityEngine;
using UnityEngine.UI;

public class Gradubuff : MonoBehaviour
{
	public GameObject[] Bonus_T;

	public GameObject[] parent;

	public GameObject DograduPrefab;

	private void Start()
	{
		PetPosition.bonuspercent = PlayerPrefs.GetFloat("bonuspercent");
		FeeCont.bonussale = PlayerPrefs.GetFloat("bonussale");
		RbirthItem.bonusmoney = PlayerPrefs.GetInt("bonusmoney");
		S2_4.Buff_pluspay = PlayerPrefs.GetFloat("Buff_pluspay");
		FurnBtn.Buff_minustime = PlayerPrefs.GetFloat("Buff_minustime");
		RbirthItem.Item_N_1 = PlayerPrefs.GetInt("Item_N_1");
		RbirthItem.Item_N_2 = PlayerPrefs.GetInt("Item_N_2");
		RbirthItem.Item_N_3 = PlayerPrefs.GetInt("Item_N_3");
		RbirthItem.Item_N_4 = PlayerPrefs.GetInt("Item_N_4");
		RbirthItem.Item_N_5 = PlayerPrefs.GetInt("Item_N_5");
		if (RbirthItem.Item_N_1 == 1)
		{
			Bonus_T[0].GetComponent<Text>().text = string.Format("+{0}%", PetPosition.bonuspercent * 100f);
		}
		else
		{
			Bonus_T[0].SetActive(false);
			GameObject gameObject = Object.Instantiate(DograduPrefab);
			gameObject.transform.SetParent(parent[0].transform);
			gameObject.transform.localPosition = new Vector3(DograduPrefab.transform.localPosition.x, 5f, 0f);
			gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		}
		if (RbirthItem.Item_N_2 == 1)
		{
			Bonus_T[1].GetComponent<Text>().text = string.Format("+{0}%", S2_4.Buff_pluspay * 100f);
		}
		else
		{
			Bonus_T[1].SetActive(false);
			GameObject gameObject2 = Object.Instantiate(DograduPrefab);
			gameObject2.transform.SetParent(parent[1].transform);
			gameObject2.transform.localPosition = new Vector3(DograduPrefab.transform.localPosition.x, 5f, 0f);
			gameObject2.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		}
		if (RbirthItem.Item_N_3 == 1)
		{
			Bonus_T[2].GetComponent<Text>().text = string.Format("-{0}%", FeeCont.bonussale * 100f);
		}
		else
		{
			Bonus_T[2].SetActive(false);
			GameObject gameObject3 = Object.Instantiate(DograduPrefab);
			gameObject3.transform.SetParent(parent[2].transform);
			gameObject3.transform.localPosition = new Vector3(DograduPrefab.transform.localPosition.x, 5f, 0f);
			gameObject3.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		}
		if (RbirthItem.Item_N_4 == 1)
		{
			Bonus_T[3].GetComponent<Text>().text = string.Format("-{0}%", FurnBtn.Buff_minustime * 100f);
		}
		else
		{
			Bonus_T[3].SetActive(false);
			GameObject gameObject4 = Object.Instantiate(DograduPrefab);
			gameObject4.transform.SetParent(parent[3].transform);
			gameObject4.transform.localPosition = new Vector3(DograduPrefab.transform.localPosition.x, 5f, 0f);
			gameObject4.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		}
		if (RbirthItem.Item_N_5 == 1)
		{
			Bonus_T[4].GetComponent<Text>().text = string.Format("{0:n0}원", RbirthItem.bonusmoney);
			return;
		}
		Bonus_T[4].SetActive(false);
		GameObject gameObject5 = Object.Instantiate(DograduPrefab);
		gameObject5.transform.SetParent(parent[4].transform);
		gameObject5.transform.localPosition = new Vector3(DograduPrefab.transform.localPosition.x, 5f, 0f);
		gameObject5.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
	}
}
