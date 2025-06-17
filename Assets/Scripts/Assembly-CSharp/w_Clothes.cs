using UnityEngine;

public class w_Clothes : MonoBehaviour
{
	public RuntimeAnimatorController[] w_AnimController;

	private float Height_;

	private Animator Compo_anim;

	private void Start()
	{
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		Compo_anim = GetComponent<Animator>();
		Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_40");
	}

	private void FixedUpdate()
	{
		if (Char._CharD == CharD.U)
		{
			Compo_anim.Play("U");
		}
		else if (Char._CharD == CharD.D)
		{
			Compo_anim.Play("D");
		}
		if (Char._CharD == CharD.L)
		{
			Compo_anim.Play("L");
		}
		else if (Char._CharD == CharD.R)
		{
			Compo_anim.Play("R");
		}
		if (Char._CharD == CharD.S)
		{
			Compo_anim.Play("D");
		}
	}
}
