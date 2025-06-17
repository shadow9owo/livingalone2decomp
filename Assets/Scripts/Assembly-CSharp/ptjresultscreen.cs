using UnityEngine;

public class ptjresultscreen : MonoBehaviour
{
	private GameObject particle;

	private GameObject particle_;

	private GameObject particle_parent;

	private void Start()
	{
		particle = (GameObject)Resources.Load("Confetti");
		particle_ = (GameObject)Object.Instantiate(Resources.Load("Confetti"));
		particle_parent = GameObject.Find("panel_result");
		particle_.transform.SetParent(particle_parent.transform);
		particle_.transform.localPosition = particle.transform.localPosition;
		particle_.transform.localScale = particle.transform.localScale;
	}
}
