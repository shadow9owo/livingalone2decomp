using UnityEngine;

public class NewLover : MonoBehaviour
{
	private void Start()
	{
	}

	public void Yes()
	{
		PlayerPrefs.SetInt("Phone", 0);
		Lovercont.Phone = PlayerPrefs.GetInt("Phone");
		PlayerPrefs.SetInt("Newlover", 0);
		Lover_phone.Newlover = PlayerPrefs.GetInt("Newlover");
		GameObject.Find("Lover_window").GetComponent<Lovercont>().NewLoverSet();
		GameObject.Find("TimeController").GetComponent<TimeCont>().SetLover();
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		LoverClothes.L_Clothes_N = Random.Range(0, 42);
		LoverHead.L_Hair_N = Random.Range(0, 34);
		PlayerPrefs.SetInt("L_Clothes_N", LoverClothes.L_Clothes_N);
		PlayerPrefs.SetInt("L_Hair_N", LoverHead.L_Hair_N);
		LoverClothes.L_Clothes_N = PlayerPrefs.GetInt("L_Clothes_N");
		LoverHead.L_Hair_N = PlayerPrefs.GetInt("L_Hair_N");
		No();
	}

	public void No()
	{
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		GameObject.Find("BackBtn").GetComponent<BackBtn>().backbtnclick();
		Object.Destroy(base.gameObject);
	}
}
