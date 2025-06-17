using UnityEngine;
using UnityEngine.UI;

public class Alert : MonoBehaviour
{
	public GameObject Alerttext;

	private void Start()
	{
		if (QuestControll.GetPet == 1)
		{
			Alerttext.GetComponent<Text>().text = string.Format("You got a Baby harp seal!");
			QuestControll.GetPet = 0;
		}
		else if (QuestControll.GetPet == 2)
		{
			Alerttext.GetComponent<Text>().text = string.Format("You got a W-Dragon!");
			QuestControll.GetPet = 0;
		}
		else if (QuestControll.GetPet == 3)
		{
			Alerttext.GetComponent<Text>().text = string.Format("You got a Blue gem wolf!");
			QuestControll.GetPet = 0;
		}
		else if (QuestControll.GetPet == 0)
		{
			SetText();
		}
	}

	public void SetText()
	{
		if (scene_controll_2.Ptj_N == 1 || scene_controll_2.Ptj_N == 4)
		{
			Alerttext.GetComponent<Text>().text = string.Format("Insufficient Desire!\nFulfill all desire meters to be over 20!");
		}
		if (scene_controll_2.Ptj_N == 2)
		{
			if (scene_controll.money <= 10000 * RoomCont.Room_N)
			{
				Alerttext.GetComponent<Text>().text = string.Format("Your living expenses are not enough!");
			}
			else if (BarCont.hp <= 20f || BarCont.mp <= 20f || BarCont.happy <= 20f || BarCont._int <= 20f)
			{
				Alerttext.GetComponent<Text>().text = string.Format("Insufficient Desire!\nFulfill all desire meters to be over 20!");
			}
		}
	}

	public void Yes()
	{
		Application.LoadLevel("ptj");
		OnDestory();
	}

	public void No()
	{
		GameObject.Find("BackBtn_Child").SetActive(false);
		Object.Destroy(base.gameObject);
	}

	private void OnDestory()
	{
		Resources.UnloadUnusedAssets();
	}
}
