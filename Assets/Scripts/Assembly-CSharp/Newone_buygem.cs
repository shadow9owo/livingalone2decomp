using UnityEngine;

public class Newone_buygem : MonoBehaviour
{
	public void Gem1()
	{
		scene_controll.gem++;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
	}

	public void Gem2()
	{
		scene_controll.gem += 2;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
	}

	public void Gem3()
	{
		scene_controll.gem += 3;
		SPrefs.SetInt("gem2", scene_controll.gem);
		scene_controll.gem = SPrefs.GetInt("gem2");
	}
}
