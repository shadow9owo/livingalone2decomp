using UnityEngine;
using UnityEngine.UI;

public class Actingchar : MonoBehaviour
{
	public static int Acting_N;

	public GameObject hair;

	public GameObject kitchenlook;

	public GameObject arm;

	public GameObject sleeping;

	public GameObject bath;

	public GameObject toilet;

	public GameObject food;

	public GameObject sleeping2;

	public GameObject waterpool;

	public RuntimeAnimatorController[] food_anim;

	public RuntimeAnimatorController[] Kitchenangle;

	public Sprite[] W_Fronthairimage;

	public Sprite[] W_Backhairimage;

	public Sprite[] W_Lefthairimage;

	public Sprite[] M_Fronthairimage;

	public Sprite[] M_Backhairimage;

	public Sprite[] M_Lefthairimage;

	private int sethairnumber;

	public void Start()
	{
		hair.SetActive(false);
		kitchenlook.SetActive(false);
		arm.SetActive(false);
		sleeping.SetActive(false);
		bath.SetActive(false);
		toilet.SetActive(false);
		food.SetActive(false);
		sethairnumber = PlayerPrefs.GetInt("Hair_N");
		SetAnim();
	}

	public void SetAnim()
	{
		if (!base.isActiveAndEnabled)
		{
			return;
		}
		if (Acting_N == 1)
		{
			if (FurnCont.Toilet_N == 0)
			{
				SetbackHead();
				hair.SetActive(true);
				toilet.SetActive(true);
			}
			else
			{
				SetfrontHead();
				hair.SetActive(true);
				toilet.SetActive(true);
			}
		}
		if (Acting_N == 2)
		{
			if (FurnCont.Kitchen_N <= 35)
			{
				SetbackHead();
				kitchenlook.GetComponent<Animator>().runtimeAnimatorController = Kitchenangle[0];
			}
			else
			{
				SetleftHead();
				kitchenlook.GetComponent<Animator>().runtimeAnimatorController = Kitchenangle[1];
			}
			hair.SetActive(true);
			kitchenlook.SetActive(true);
		}
		if (Acting_N == 3)
		{
			if (FurnCont.Bed_N <= 44)
			{
				SetfrontHead();
				hair.SetActive(true);
				sleeping.SetActive(true);
			}
			else
			{
				SetleftHead();
				hair.SetActive(true);
				sleeping2.SetActive(true);
				hair.transform.localRotation = Quaternion.Euler(new Vector3(0f, 0f, -90f));
			}
		}
		if (Acting_N == 4)
		{
			if (RoomCont.Room_N == 17)
			{
				waterpool.SetActive(true);
				hair.GetComponent<Animator>().enabled = true;
				arm.GetComponent<Animator>().enabled = true;
			}
			SetfrontHead();
			hair.SetActive(true);
			arm.SetActive(true);
		}
		if (Acting_N == 5)
		{
			if (RoomCont.Room_N == 1)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[0];
			}
			if (RoomCont.Room_N > 1 && RoomCont.Room_N <= 3)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[1];
			}
			if (RoomCont.Room_N > 3 && RoomCont.Room_N <= 5)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[2];
			}
			if (RoomCont.Room_N > 5 && RoomCont.Room_N <= 7)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[3];
			}
			if (RoomCont.Room_N > 7 && RoomCont.Room_N <= 9)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[4];
			}
			if (RoomCont.Room_N == 10)
			{
				food.GetComponent<Animator>().runtimeAnimatorController = food_anim[4];
			}
			SetfrontHead();
			hair.SetActive(true);
			arm.SetActive(true);
			food.SetActive(true);
		}
		if (Acting_N == 6)
		{
			SetfrontHead();
			hair.SetActive(true);
			arm.SetActive(true);
			bath.SetActive(true);
		}
		if (Acting_N == 7)
		{
			SetbackHead();
			hair.SetActive(true);
		}
	}

	public void SetfrontHead()
	{
		if (Char.Sex == 0)
		{
			hair.GetComponent<Image>().sprite = M_Fronthairimage[sethairnumber];
		}
		if (Char.Sex == 1)
		{
			hair.GetComponent<Image>().sprite = W_Fronthairimage[sethairnumber];
		}
	}

	public void SetbackHead()
	{
		if (Char.Sex == 0)
		{
			hair.GetComponent<Image>().sprite = M_Backhairimage[sethairnumber];
		}
		if (Char.Sex == 1)
		{
			hair.GetComponent<Image>().sprite = W_Backhairimage[sethairnumber];
		}
	}

	public void SetleftHead()
	{
		if (Char.Sex == 0)
		{
			hair.GetComponent<Image>().sprite = M_Lefthairimage[sethairnumber];
		}
		if (Char.Sex == 1)
		{
			hair.GetComponent<Image>().sprite = W_Lefthairimage[sethairnumber];
		}
		Debug.Log("!!");
	}
}
