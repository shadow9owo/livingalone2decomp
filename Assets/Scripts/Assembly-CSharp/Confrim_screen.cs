using UnityEngine;
using UnityEngine.UI;

public class Confrim_screen : MonoBehaviour
{
	private GameObject dms_obj;

	private GameObject s2_4_SC;

	public Sprite albaposion_sprite;

	public Sprite timebuff_sprite;

	public GameObject Icon_Img;

	public GameObject Title_text;

	public GameObject Info_text;

	private void Start()
	{
		dms_obj = GameObject.Find("dms");
		if (Application.loadedLevelName == "ptj")
		{
			Icon_Img.GetComponent<Image>().sprite = albaposion_sprite;
			Title_text.GetComponent<Text>().text = string.Format("Forbidden Portion");
			Info_text.GetComponent<Text>().text = string.Format("Your part-time pay increases\nby 20 % permanently.");
		}
		if (Application.loadedLevelName == "newone")
		{
			Icon_Img.GetComponent<Image>().sprite = timebuff_sprite;
			Title_text.GetComponent<Text>().text = string.Format("PermanentTime buff");
			Info_text.GetComponent<Text>().text = string.Format("You can use Time buff permanently.");
		}
	}

	public void Deletethis()
	{
		Object.Destroy(base.gameObject);
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
	}

	public void BuyAlbaPosion()
	{
		if (Application.loadedLevelName == "ptj")
		{
			dms_obj.GetComponent<S2_4>().Paybufftest();
		}
		if (Application.loadedLevelName == "newone")
		{
			GameObject.Find("BUFF").GetComponent<TimeBuff>().Inappbuff();
		}
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
	}
}
