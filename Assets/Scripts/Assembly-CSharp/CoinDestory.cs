using UnityEngine;

public class CoinDestory : MonoBehaviour
{
	private void Start()
	{
		Invoke("ParticleDestroy", 2f);
	}

	public void ParticleDestroy()
	{
		Object.Destroy(base.gameObject);
	}
}
