using UnityEngine;

public class LoverClothes : MonoBehaviour
{
	private Animator Compo_anim;

	public static int L_Clothes_N;

	public void Start()
	{
		Compo_anim = GetComponent<Animator>();
		L_Clothes_N = PlayerPrefs.GetInt("L_Clothes_N");
		if (LoverChar.L_Sex == 0)
		{
			SetClothes_M();
		}
		if (LoverChar.L_Sex == 1)
		{
			SetClothes_W();
		}
	}

	public void SetClothes_M()
	{
		if (L_Clothes_N == 0)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (1)/m_Clothes_1");
		}
		if (L_Clothes_N == 1)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (2)/m_Clothes_2");
		}
		if (L_Clothes_N == 2)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (3)/m_Clothes_3");
		}
		if (L_Clothes_N == 3)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (4)/m_Clothes_4");
		}
		if (L_Clothes_N == 4)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (5)/m_Clothes_5");
		}
		if (L_Clothes_N == 5)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (6)/m_Clothes_6");
		}
		if (L_Clothes_N == 6)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (7)/m_Clothes_7");
		}
		if (L_Clothes_N == 7)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (8)/m_Clothes_8");
		}
		if (L_Clothes_N == 8)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (9)/m_Clothes_9");
		}
		if (L_Clothes_N == 9)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (10)/m_Clothes_10");
		}
		if (L_Clothes_N == 10)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (11)/m_Clothes_11");
		}
		if (L_Clothes_N == 11)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (12)/m_Clothes_12");
		}
		if (L_Clothes_N == 12)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (13)/m_Clothes_13");
		}
		if (L_Clothes_N == 13)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (14)/m_Clothes_14");
		}
		if (L_Clothes_N == 14)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (15)/m_Clothes_15");
		}
		if (L_Clothes_N == 15)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (16)/m_Clothes_16");
		}
		if (L_Clothes_N == 16)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (17)/m_Clothes_17");
		}
		if (L_Clothes_N == 17)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (18)/m_Clothes_18");
		}
		if (L_Clothes_N == 18)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (19)/m_Clothes_19");
		}
		if (L_Clothes_N == 19)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (20)/m_Clothes_20");
		}
		if (L_Clothes_N == 20)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (21)/m_Clothes_21");
		}
		if (L_Clothes_N == 21)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (22)/m_Clothes_22");
		}
		if (L_Clothes_N == 22)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (23)/m_Clothes_23");
		}
		if (L_Clothes_N == 23)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (24)/m_Clothes_24");
		}
		if (L_Clothes_N == 24)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (25)/m_Clothes_25");
		}
		if (L_Clothes_N == 25)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (26)/m_Clothes_26");
		}
		if (L_Clothes_N == 26)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (27)/m_Clothes_27");
		}
		if (L_Clothes_N == 27)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (28)/m_Clothes_28");
		}
		if (L_Clothes_N == 28)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (29)/m_Clothes_29");
		}
		if (L_Clothes_N == 29)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (30)/m_Clothes_30");
		}
		if (L_Clothes_N == 30)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (31)/m_Clothes_31");
		}
		if (L_Clothes_N == 31)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (32)/m_Clothes_32");
		}
		if (L_Clothes_N == 32)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (33)/m_Clothes_33");
		}
		if (L_Clothes_N == 33)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (34)/m_Clothes_34");
		}
		if (L_Clothes_N == 34)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (35)/m_Clothes_35");
		}
		if (L_Clothes_N == 35)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (36)/m_Clothes_36");
		}
		if (L_Clothes_N == 36)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (37)/m_Clothes_37");
		}
		if (L_Clothes_N == 37)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (38)/m_Clothes_38");
		}
		if (L_Clothes_N == 38)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (39)/m_Clothes_39");
		}
		if (L_Clothes_N == 39)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (40)/m_Clothes_40");
		}
		if (L_Clothes_N == 40)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (41)/m_Clothes_41");
		}
		if (L_Clothes_N == 41)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Unisex_Clothes/Uni_Clothes/Uni_Clothes_1");
		}
		if (L_Clothes_N == 42)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (42)/m_Clothes_42");
		}
		if (L_Clothes_N == 43)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (43)/m_Clothes_43");
		}
		if (L_Clothes_N == 44)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (44)/m_Clothes_44");
		}
		if (L_Clothes_N == 45)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (45)/m_Clothes_45");
		}
		if (L_Clothes_N == 46)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (46)/m_Clothes_46");
		}
		if (L_Clothes_N == 47)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (47)/m_Clothes_47");
		}
		if (L_Clothes_N == 48)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("m_Clothes_Anim/C (48)/m_Clothes_48");
		}
	}

	public void SetClothes_W()
	{
		if (L_Clothes_N == 0)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (1)/w_Clothes_1");
		}
		if (L_Clothes_N == 1)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (2)/w_Clothes_2");
		}
		if (L_Clothes_N == 2)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (3)/w_Clothes_3");
		}
		if (L_Clothes_N == 3)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (4)/w_Clothes_4");
		}
		if (L_Clothes_N == 4)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (5)/w_Clothes_5");
		}
		if (L_Clothes_N == 5)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (6)/w_Clothes_6");
		}
		if (L_Clothes_N == 6)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (7)/w_Clothes_7");
		}
		if (L_Clothes_N == 7)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (8)/w_Clothes_8");
		}
		if (L_Clothes_N == 8)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (9)/w_Clothes_9");
		}
		if (L_Clothes_N == 9)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (10)/w_Clothes_10");
		}
		if (L_Clothes_N == 10)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (11)/w_Clothes_11");
		}
		if (L_Clothes_N == 11)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (12)/w_Clothes_12");
		}
		if (L_Clothes_N == 12)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (13)/w_Clothes_13");
		}
		if (L_Clothes_N == 13)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (14)/w_Clothes_14");
		}
		if (L_Clothes_N == 14)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (15)/w_Clothes_15");
		}
		if (L_Clothes_N == 15)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (16)/w_Clothes_16");
		}
		if (L_Clothes_N == 16)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (17)/w_Clothes_17");
		}
		if (L_Clothes_N == 17)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (18)/w_Clothes_18");
		}
		if (L_Clothes_N == 18)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (19)/w_Clothes_19");
		}
		if (L_Clothes_N == 19)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (20)/w_Clothes_20");
		}
		if (L_Clothes_N == 20)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (21)/w_Clothes_21");
		}
		if (L_Clothes_N == 21)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (22)/w_Clothes_22");
		}
		if (L_Clothes_N == 22)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (23)/w_Clothes_23");
		}
		if (L_Clothes_N == 23)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (24)/w_Clothes_24");
		}
		if (L_Clothes_N == 24)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (25)/w_Clothes_25");
		}
		if (L_Clothes_N == 25)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (26)/w_Clothes_26");
		}
		if (L_Clothes_N == 26)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (27)/w_Clothes_27");
		}
		if (L_Clothes_N == 27)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (28)/w_Clothes_28");
		}
		if (L_Clothes_N == 28)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (29)/w_Clothes_29");
		}
		if (L_Clothes_N == 29)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (30)/w_Clothes_30");
		}
		if (L_Clothes_N == 30)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (31)/w_Clothes_31");
		}
		if (L_Clothes_N == 31)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (32)/w_Clothes_32");
		}
		if (L_Clothes_N == 32)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (33)/w_Clothes_33");
		}
		if (L_Clothes_N == 33)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (34)/w_Clothes_34");
		}
		if (L_Clothes_N == 34)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (35)/w_Clothes_35");
		}
		if (L_Clothes_N == 35)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (36)/w_Clothes_36");
		}
		if (L_Clothes_N == 36)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (37)/w_Clothes_37");
		}
		if (L_Clothes_N == 37)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (38)/w_Clothes_38");
		}
		if (L_Clothes_N == 38)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (39)/w_Clothes_39");
		}
		if (L_Clothes_N == 39)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (40)/w_Clothes_40");
		}
		if (L_Clothes_N == 40)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (41)/w_Clothes_41");
		}
		if (L_Clothes_N == 41)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("Unisex_Clothes/Uni_Clothes/Uni_Clothes_1");
		}
		if (L_Clothes_N == 42)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (42)/w_Clothes_42");
		}
		if (L_Clothes_N == 43)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (43)/w_Clothes_43");
		}
		if (L_Clothes_N == 44)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (44)/w_Clothes_44");
		}
		if (L_Clothes_N == 45)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (45)/w_Clothes_45");
		}
		if (L_Clothes_N == 46)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (46)/w_Clothes_46");
		}
		if (L_Clothes_N == 47)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (47)/w_Clothes_47");
		}
		if (L_Clothes_N == 48)
		{
			Compo_anim.runtimeAnimatorController = Resources.Load<RuntimeAnimatorController>("w_Clothes_Anim/C (48)/w_Clothes_48");
		}
	}

	public void FixedUpdate()
	{
		if (LoverChar._L_CharD == L_CharD.U)
		{
			Compo_anim.Play("U");
		}
		else if (LoverChar._L_CharD == L_CharD.D)
		{
			Compo_anim.Play("D");
		}
		if (LoverChar._L_CharD == L_CharD.L)
		{
			Compo_anim.Play("L");
		}
		else if (LoverChar._L_CharD == L_CharD.R)
		{
			Compo_anim.Play("R");
		}
		if (LoverChar._L_CharD == L_CharD.S)
		{
			Compo_anim.Play("D");
		}
	}
}
