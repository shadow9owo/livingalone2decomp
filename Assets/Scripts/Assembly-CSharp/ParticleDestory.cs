using UnityEngine;

public class ParticleDestory : MonoBehaviour
{
	public void Start()
	{
		Invoke("ParticleDestroy", 2.5f);
	}

	public void ParticleDestroy()
	{
		Object.Destroy(base.gameObject);
	}
}
