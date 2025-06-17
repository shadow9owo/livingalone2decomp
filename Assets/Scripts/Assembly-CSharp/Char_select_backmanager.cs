using UnityEngine;

public class Char_select_backmanager : MonoBehaviour
{
	public GameObject BossManager;

	private void Start()
	{
	}

	private void FixedUpdate()
	{
		if (base.isActiveAndEnabled)
		{
			BossManager = GameObject.FindGameObjectWithTag("Boss");
			BossManager.GetComponent<s1_1>().Window = base.gameObject;
		}
	}
}
