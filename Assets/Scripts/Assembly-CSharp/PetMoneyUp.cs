using UnityEngine;
using UnityEngine.UI;

public class PetMoneyUp : MonoBehaviour
{
	public GameObject PetMoneyText;

	public GameObject PetGemText;

	public GameObject petmoneyUp;

	public GameObject petStUp;

	public GameObject petgemUp;

	public GameObject Parent;

	private void Start()
	{
	}

	public void PlusPetMONEY()
	{
		PetMoneyText.GetComponent<Text>().color = Color.red;
		if (EventCont.Plus_PetMoney >= 0f)
		{
			PetMoneyText.GetComponent<Text>().text = string.Format("+{0:n0}G", EventCont.Plus_PetMoney);
		}
		GameObject gameObject = Object.Instantiate(petmoneyUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = petmoneyUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		Invoke("PetMoneySetzero", 1f);
	}

	public void PlusPetGEM()
	{
		if (EventCont.Plus_PetMoney >= 0f)
		{
			PetGemText.GetComponent<Text>().text = string.Format("+{0:n0}", EventCont.Plus_PetMoney);
		}
		GameObject gameObject = Object.Instantiate(petgemUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = petgemUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		Invoke("PetMoneySetzero", 1f);
	}

	public void PetPlusSt()
	{
		petStUp.GetComponent<Text>().text = string.Format("{0}", EventCont.pet_PlusSt);
		GameObject gameObject = Object.Instantiate(petStUp);
		gameObject.transform.SetParent(Parent.transform);
		gameObject.transform.localPosition = petStUp.transform.localPosition;
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		Invoke("PetStSetzero", 1f);
	}

	public void PetStSetzero()
	{
		EventCont.pet_PlusSt = 0f;
	}

	public void PetMoneySetzero()
	{
		EventCont.Plus_PetMoney = 0f;
	}
}
