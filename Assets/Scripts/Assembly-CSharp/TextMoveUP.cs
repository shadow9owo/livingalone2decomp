using UnityEngine;

public class TextMoveUP : MonoBehaviour
{
	private void Start()
	{
		DeletText();
	}

	private void FixedUpdate()
	{
		base.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 0.1f);
	}

	public void DeletText()
	{
		Object.Destroy(base.gameObject, 1f);
	}
}
