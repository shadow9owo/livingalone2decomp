using UnityEngine;

public class Deleteself : MonoBehaviour
{
	public void DeleteSelf()
	{
		Object.Destroy(base.gameObject);
	}

	public void Sound()
	{
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		GameObject.Find("CouponWindow").SetActive(false);
		DeleteSelf();
	}

	public void Momshelp_OK()
	{
		GameObject.Find("FeeCont").GetComponent<FeeCont>().FeeDeath();
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		DeleteSelf();
	}

	public void PackageNoticeDelete()
	{
		GameObject.Find("ButtonAud").GetComponent<SoundEffect_newone>().ButtonSound_1();
		DeleteSelf();
	}
}
