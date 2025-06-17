using UnityEngine;

public class PetTextup : MonoBehaviour
{
	private void Start()
	{
		DeletText();
	}

	private void FixedUpdate()
	{
		base.gameObject.transform.Translate(Vector3.up * Time.deltaTime * 0.3f);
	}

	public void DeletText()
	{
		Object.Destroy(base.gameObject, 1f);
	}
}
