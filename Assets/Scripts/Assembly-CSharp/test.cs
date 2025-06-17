using UnityEngine;
using UnityEngine.UI;

public class test : MonoBehaviour
{
	public string FileName;

	private string[] stringList1;

	private string[] stringList2;

	private string fileFullPath;

	private GameObject CouponNumber_obj;

	private Text CouponNumber_text;

	private void Start()
	{
		CouponNumber_obj = GameObject.Find("CouponNumber");
		CouponNumber_text = CouponNumber_obj.GetComponent<Text>();
	}

	public void check_btn()
	{
	}
}
