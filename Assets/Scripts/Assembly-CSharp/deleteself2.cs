using UnityEngine;

public class deleteself2 : MonoBehaviour
{
	private void Start()
	{
	}

	public void deleteself()
	{
		Object.Destroy(base.gameObject);
	}
}
