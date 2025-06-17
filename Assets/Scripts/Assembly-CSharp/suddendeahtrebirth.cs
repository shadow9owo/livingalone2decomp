using UnityEngine;
using UnityEngine.UI;

public class suddendeahtrebirth : MonoBehaviour
{
	public GameObject Takecare_T;

	private void Start()
	{
		if (SuddenDeathCont.ReasonDeath_N == 2)
		{
			Takecare_T.GetComponent<Text>().text = string.Format("우리 공부 열심히 하자! 응?");
		}
		if (SuddenDeathCont.ReasonDeath_N == 3)
		{
			Takecare_T.GetComponent<Text>().text = string.Format("욕구관리를 잘하자..건강이 최고야!");
		}
		if (SuddenDeathCont.ReasonDeath_N == 6)
		{
			Takecare_T.GetComponent<Text>().text = string.Format("돈관리를 잘 하자! 돈없으면 말짱도루묵ㅎ");
		}
	}
}
