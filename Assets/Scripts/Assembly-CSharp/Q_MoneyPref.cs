using UnityEngine;
using UnityEngine.UI;

public class Q_MoneyPref : MonoBehaviour
{
	public static int Plus_Q_Money;

	public GameObject Text;

	private void Start()
	{
		Text.GetComponent<Text>().text = string.Format("+{0:n0}G", Plus_Q_Money);
	}

	private void Update()
	{
	}
}
