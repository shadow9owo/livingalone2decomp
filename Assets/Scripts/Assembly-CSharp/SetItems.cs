using UnityEngine;

public class SetItems : MonoBehaviour
{
	public GameObject[] Items;

	public GameObject Parent;

	public static int Setitemrandom;

	private void Start()
	{
		Setitemrandom = Random.Range(0, Items.Length);
		GameObject gameObject = Object.Instantiate(Items[Setitemrandom]);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = base.transform.position;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
	}
}
