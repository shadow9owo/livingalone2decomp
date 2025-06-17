using UnityEngine;
using UnityEngine.UI;

public class TimeBuff : MonoBehaviour
{
	public static float BuffTime = 0.5f;

	public static int Buffer_N;

	public static int Buff_weekCount;

	public GameObject Buff_T;

	public GameObject _btn;

	public GameObject Window;

	private GameObject _backbtn;

	private GameObject _furnbtn;

	public static int BUff_Purchase;

	public GameObject timebuffthing;

	public static int Q_BuffN;
	GameObject st_bar;

    public void Awake()
	{
		Buffer_N = PlayerPrefs.GetInt("Buffer_N");
	}

	public void Start()
	{
		_furnbtn = GameObject.Find("ButtonController(study)/furnBtn");
		_backbtn = GameObject.Find("BackBtn");
		Buff_weekCount = PlayerPrefs.GetInt("Buff_weekCount");
	}

	public void Buffpurchase()
	{
		Buffer_N = 1;
		PlayerPrefs.SetInt("Buffer_N", Buffer_N);
		Buffer_N = PlayerPrefs.GetInt("Buffer_N");
		timebuffthing.SetActive(false);
		
		GameObject.Find("ButtonController(study)/furnBtn").GetComponent<FurnBtn>().Setbuff();
	}

	public void Inappbuff()
	{
		if (scene_controll.gem >= 200)
		{
			PlayerPrefs.SetInt("BUff_Purchase", 1);
			BUff_Purchase = PlayerPrefs.GetInt("BUff_Purchase");
			BuffWindowclose();
			Start();
			scene_controll.gem -= 200;
			SPrefs.SetInt("gem2", scene_controll.gem);
			scene_controll.gem = SPrefs.GetInt("gem2");
			GameObject.Find("dms").GetComponent<scene_controll_2>().Change();
			timebuffthing.SetActive(false);
		}
		else
		{
			GameObject gameObject = (GameObject)Resources.Load("No_gem_notice");
			GameObject gameObject2 = (GameObject)Object.Instantiate(Resources.Load("No_gem_notice"));
			GameObject gameObject3 = GameObject.Find("1_2");
			gameObject2.transform.SetParent(gameObject3.transform);
			gameObject2.transform.localPosition = new Vector3(0f, 3f, 0f);
			gameObject2.transform.localScale = gameObject.transform.localScale;
			Invoke("Destory_notice_gem", 2f);
		}
	}

	public void Destory_notice_gem()
	{
		Object.Destroy(GameObject.Find("No_gem_notice(Clone)"));
	}

	public void BuffWindowOpen()
	{
		BarCont.st = 100;
        GameObject.FindGameObjectWithTag("lwdakdiopkaw").GetComponent<Image>().fillAmount = PlayerPrefs.GetFloat("st", 100) / 100f;
    }

	public void BuffWindowclose()
	{
		_backbtn.GetComponent<BackBtn>().backbtnclick();
		Window.SetActive(false);
	}

	public void BuffBtn()
	{
		Buffer_N = 1;
		PlayerPrefs.SetInt("Buffer_N", Buffer_N);
		Buffer_N = PlayerPrefs.GetInt("Buffer_N");
		_furnbtn.GetComponent<FurnBtn>().Setbuff();
		_btn.GetComponent<Button>().interactable = false;
		PlayerPrefs.SetInt("Buff_weekCount", 5);
		Buff_weekCount = PlayerPrefs.GetInt("Buff_weekCount");
		SetText();
		Buff_T.SetActive(true);
		Q_BuffN++;
		PlayerPrefs.SetInt("Q_BuffN", Q_BuffN);
	}

	public void SetText()
	{
		Buff_T.GetComponent<Text>().text = string.Format("{0}", Buff_weekCount);
	}

	public void BuffEnd()
	{
		if (Buff_weekCount <= 0)
		{
			PlayerPrefs.SetInt("Buff_weekCount", 0);
			Buff_weekCount = PlayerPrefs.GetInt("Buff_weekCount");
			Buff_T.GetComponent<Text>().text = string.Format("{0}", 5);
			Buff_T.SetActive(false);
			Buffer_N = 0;
			PlayerPrefs.SetInt("Buffer_N", Buffer_N);
			Buffer_N = PlayerPrefs.GetInt("Buffer_N");
			_btn.GetComponent<Button>().interactable = true;
		}
	}
}
