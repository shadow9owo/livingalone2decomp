using UnityEngine;

public class PetCollider : MonoBehaviour
{
	public Pet _Pet;

	public void OnCollisionEnter(Collision col)
	{
		string text = col.collider.name;
		switch (text)
		{
		case "BackGround":
		case "Kitchen":
		case "Toilet":
		case "Bath":
		case "Closet":
		case "Bed":
		case "Desk":
		case "Shoecase":
		case "TV":
		case "Table":
		case "Laundary":
			CancelInvoke();
			_Pet.Stop();
			break;
		}
		if (text == "Char")
		{
			CancelInvoke();
			_Pet.ChangeStart();
		}
	}
}
