using UnityEngine;

public class BackbtnManager : MonoBehaviour
{
	public GameObject BossManager;

	private GameObject BackBtn_;

	public void Start()
	{
		BackBtn_ = GameObject.Find("BackBtn");
	}

	public void FixedUpdate()
	{
		if (base.isActiveAndEnabled)
		{
			BossManager = GameObject.FindGameObjectWithTag("Boss");
			BossManager.GetComponent<BossBackbtnManager>().Window = base.gameObject;
			if (Application.loadedLevelName == "newone" && base.gameObject != GameObject.Find("MonthlyReport") && base.gameObject != GameObject.Find("gojiseo") && base.gameObject != GameObject.Find("suddenyellopanel") && base.gameObject != GameObject.Find("reportScreen") && base.gameObject != GameObject.Find("Gradumoneywindow") && base.gameObject != GameObject.Find("Suddenmoneywindow") && base.gameObject != GameObject.Find("PopUP") && base.gameObject != GameObject.Find("CouponWindow") && base.gameObject != GameObject.Find("yellopanel (1)") && base.gameObject != GameObject.Find("ReallyQuite"))
			{
				BackBtn_.GetComponent<BackBtn>().BackButton.SetActive(true);
				BackBtn_.GetComponent<BackBtn>().ThisWindow = base.gameObject;
			}
		}
		if (!base.isActiveAndEnabled)
		{
			BossManager = GameObject.FindGameObjectWithTag("Boss");
			BossManager.GetComponent<BossBackbtnManager>().Window = null;
		}
	}
}
