using UnityEngine;

public class CameraCont : MonoBehaviour
{
	public static Camera camera;

	private void Start()
	{
	}

	private void Update()
	{
		camera = GetComponent<Camera>();
	}
}
