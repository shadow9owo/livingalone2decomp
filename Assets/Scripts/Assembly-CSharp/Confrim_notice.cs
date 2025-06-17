using UnityEngine;
using UnityEngine.UI;

public class Confrim_notice : MonoBehaviour
{
	public Text notice_T;

	public static string notice_S;

	private void Start()
	{
		notice_T.text = string.Format(notice_S);
	}

	public void Btn()
	{
		if (notice_S == string.Format("Do you really want to break up?\nAll lover's information will disappear."))
		{
			GameObject.Find("Lover_window").GetComponent<Lovercont>().Resetlover();
		}
		if (notice_S == string.Format("Do you really change gender of lover?"))
		{
			GameObject.Find("Lover_window").GetComponent<Lovercont>().ChangeloverSex();
		}
		if (notice_S != string.Format("Do you really want to break up?\nAll lover's information will disappear.") && notice_S != string.Format("Do you really change gender of lover?"))
		{
			GameObject.Find("Smartphone(Clone)").GetComponent<Lover_phone>().MakeNewLover();
		}
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
	}

	public void Destroy()
	{
		Object.Destroy(base.gameObject);
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
	}
}
