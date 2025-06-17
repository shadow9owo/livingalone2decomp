using UnityEngine;

public class Grauconfetti : MonoBehaviour
{
	private void Start()
	{
		GameObject gameObject = (GameObject)Resources.Load("Confetti");
		GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("Confetti"));
		gameObject2.transform.SetParent(base.transform);
		gameObject2.transform.localPosition = gameObject.transform.position;
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
	}
}
