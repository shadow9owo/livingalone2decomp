using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TalkingText : MonoBehaviour
{
	public SuddenDeathCont _SuddenDeathCont;

	public Text Talkbox;

	public GameObject Arrow;

	public string[] RandomTalk;

	public Transform NickName;

	public static string Name;

	private StringBuilder m_Builder;

	private float ElapsedTime;

	private int m_EndIndex;

	private int m_ListIndex;

	public static int PopUpran;

	public GameObject PopUp;

	public int PopUp_Bool;

	public Transform Google_T;

	public TextUP _TextUP;

	public GameObject GoogleBtn;

	public GameObject Facebookbtn;

	public static int Q_Friendly;

	private int EventDelay;

	private int Room1_randomtalk_N;

	public string[] Room1_Text;

	private int Room2_randomtalk_N;

	public string[] Room2_Text;

	private int Room3_randomtalk_N;

	public string[] Room3_Text;

	private int Room4_randomtalk_N;

	public string[] Room4_Text;

	private int Room5_randomtalk_N;

	public string[] Room5_Text;

	private int Room6_randomtalk_N;

	public string[] Room6_Text;

	private int Room7_randomtalk_N;

	public string[] Room7_Text;

	private int Room8_randomtalk_N;

	public string[] Room8_Text;

	private int Room9_randomtalk_N;

	public string[] Room9_Text;

	private int Room10_randomtalk_N;

	public string[] Room10_Text;

	private int Room11_randomtalk_N;

	public string[] Room11_Text;

	private int Room12_randomtalk_N;

	public string[] Room12_Text;

	private int Room13_randomtalk_N;

	public string[] Room13_Text;

	private int Room14_randomtalk_N;

	public string[] Room14_Text;

	private int Room15_randomtalk_N;

	public string[] Room15_Text;

	private int Room16_randomtalk_N;

	public string[] Room16_Text;

	private int Room17_randomtalk_N;

	public string[] Room17_Text;

	[HideInInspector]
	public int randomtalk_N;

	public GameObject[] OtherScreens;

	private void Awake()
	{
		Name = PlayerPrefs.GetString("Nick");
	}

	private void Start()
	{
		NickName.GetComponent<Text>().text = string.Format("{0}", Name);
		Random_Talking();
		Arrow.SetActive(true);
		base.gameObject.GetComponent<Button>().interactable = true;
		PopUp_Bool = PlayerPrefs.GetInt("PopUp_Bool");
	}

	public void FixedUpdate()
	{
		try
		{
            Talkbox.text = m_Builder.ToString(0, m_EndIndex);
        }
		catch (System.Exception)
		{

		}
		ElapsedTime += Time.fixedDeltaTime * 18f;
		m_EndIndex = (int)ElapsedTime;
		if (m_EndIndex > m_Builder.Length)
		{
			m_EndIndex = m_Builder.Length;
		}
		if (m_EndIndex == m_Builder.Length)
		{
			End();
		}
	}

	public void End()
	{
		m_EndIndex = m_Builder.Length;
	}

	public void GoGoogle()
	{
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.factory608.DMSeng");
		PopUp_Bool = 1;
		PlayerPrefs.SetInt("PopUp_Bool", 1);
		PopUp.SetActive(false);
	}

	public void GoFacebook()
	{
		Application.OpenURL("https://www.facebook.com/608factory/");
		PopUp_Bool = 2;
		PlayerPrefs.SetInt("PopUp_Bool", 2);
		PopUp.SetActive(false);
		EventCont.Plus_MONEY = 500000L;
		scene_controll.money += 500000L;
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		_TextUP.PlusMONEY();
	}

	public void PopUpClose()
	{
		PopUp.SetActive(false);
	}

	public void TalkDirection()
	{
		if (EventDelay < 30)
		{
			EventDelay++;
			if (PopUp_Bool == 0)
			{
				PopUpran++;
				if (PopUpran == 20)
				{
					PopUp.SetActive(true);
					Google_T.GetComponent<Text>().text = string.Format("Do you enjoy this game?\nComment please!");
					GoogleBtn.SetActive(true);
					Facebookbtn.SetActive(false);
				}
			}
			if (PopUp_Bool == 1)
			{
				PopUpran++;
				if (PopUpran == 20)
				{
					PopUp.SetActive(true);
					Google_T.GetComponent<Text>().text = string.Format("Please\n'Like' Living Alone page\nand get money!");
					GoogleBtn.SetActive(false);
					Facebookbtn.SetActive(true);
				}
			}
		}
		Debug.Log("Click");
		if (RoomCont.Room_N == 1)
		{
			if (Char.CharD_N != 4)
			{
				Room1_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 2)
		{
			if (Char.CharD_N != 4)
			{
				Room2_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 3)
		{
			if (Char.CharD_N != 4)
			{
				Room3_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 4)
		{
			if (Char.CharD_N != 4)
			{
				Room4_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 5)
		{
			if (Char.CharD_N != 4)
			{
				Room5_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 6)
		{
			if (Char.CharD_N != 4)
			{
				Room6_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 7)
		{
			if (Char.CharD_N != 4)
			{
				Room7_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 8)
		{
			if (Char.CharD_N != 4)
			{
				Room8_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 9)
		{
			if (Char.CharD_N != 4)
			{
				Room9_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 10)
		{
			if (Char.CharD_N != 4)
			{
				Room10_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 11)
		{
			if (Char.CharD_N != 4)
			{
				Room11_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 12)
		{
			if (Char.CharD_N != 4)
			{
				Room12_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 13)
		{
			if (Char.CharD_N != 4)
			{
				Room13_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 14)
		{
			if (Char.CharD_N != 4)
			{
				Room14_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 15)
		{
			if (Char.CharD_N != 4)
			{
				Room15_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 16)
		{
			if (Char.CharD_N != 4)
			{
				Room16_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
		if (RoomCont.Room_N == 17)
		{
			if (Char.CharD_N != 4)
			{
				Room17_Talk();
			}
			else
			{
				Random_Talking();
			}
		}
	}

	public void Room1_Talk()
	{
		Room1_randomtalk_N = Random.Range(0, Room1_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room1_randomtalk_N;
		m_Builder.Append(Room1_Text[Room1_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room2_Talk()
	{
		Room2_randomtalk_N = Random.Range(0, Room2_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room2_randomtalk_N;
		m_Builder.Append(Room2_Text[Room2_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room3_Talk()
	{
		Room3_randomtalk_N = Random.Range(0, Room3_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room3_randomtalk_N;
		m_Builder.Append(Room3_Text[Room3_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room4_Talk()
	{
		Room4_randomtalk_N = Random.Range(0, Room4_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room4_randomtalk_N;
		m_Builder.Append(Room4_Text[Room4_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room5_Talk()
	{
		Room5_randomtalk_N = Random.Range(0, Room5_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room5_randomtalk_N;
		m_Builder.Append(Room5_Text[Room5_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room6_Talk()
	{
		Room6_randomtalk_N = Random.Range(0, Room6_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room6_randomtalk_N;
		m_Builder.Append(Room6_Text[Room6_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room7_Talk()
	{
		Room7_randomtalk_N = Random.Range(0, Room7_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room7_randomtalk_N;
		m_Builder.Append(Room7_Text[Room7_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room8_Talk()
	{
		Room8_randomtalk_N = Random.Range(0, Room8_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room8_randomtalk_N;
		m_Builder.Append(Room8_Text[Room8_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room9_Talk()
	{
		Room9_randomtalk_N = Random.Range(0, Room9_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room9_randomtalk_N;
		m_Builder.Append(Room9_Text[Room9_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room10_Talk()
	{
		Room10_randomtalk_N = Random.Range(0, Room10_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room10_randomtalk_N;
		m_Builder.Append(Room10_Text[Room10_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room11_Talk()
	{
		Room11_randomtalk_N = Random.Range(0, Room11_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room11_randomtalk_N;
		m_Builder.Append(Room11_Text[Room11_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room12_Talk()
	{
		Room12_randomtalk_N = Random.Range(0, Room12_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room12_randomtalk_N;
		m_Builder.Append(Room12_Text[Room12_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room13_Talk()
	{
		Room13_randomtalk_N = Random.Range(0, Room13_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room13_randomtalk_N;
		m_Builder.Append(Room13_Text[Room13_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room14_Talk()
	{
		Room14_randomtalk_N = Random.Range(0, Room14_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room14_randomtalk_N;
		m_Builder.Append(Room14_Text[Room14_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room15_Talk()
	{
		Room15_randomtalk_N = Random.Range(0, Room15_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room15_randomtalk_N;
		m_Builder.Append(Room15_Text[Room15_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room16_Talk()
	{
		Room16_randomtalk_N = Random.Range(0, Room16_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room16_randomtalk_N;
		m_Builder.Append(Room16_Text[Room16_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Room17_Talk()
	{
		Room17_randomtalk_N = Random.Range(0, Room17_Text.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = Room17_randomtalk_N;
		m_Builder.Append(Room17_Text[Room17_randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
	}

	public void Random_Talking()
	{
		scene_controll.money_Text = scene_controll.money.ToString();
		SPrefs.SetString("final_money2", scene_controll.money_Text);
		randomtalk_N = Random.Range(0, RandomTalk.Length);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = randomtalk_N;
		m_Builder.Append(RandomTalk[randomtalk_N]);
		base.gameObject.GetComponent<Button>().interactable = false;
		Arrow.SetActive(false);
		Invoke("ClickAgain", 1f);
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
	}

	public void ClickAgain()
	{
		base.gameObject.GetComponent<Button>().interactable = true;
		Arrow.SetActive(true);
	}
}
