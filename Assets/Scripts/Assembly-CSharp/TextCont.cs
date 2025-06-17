using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextCont : MonoBehaviour
{
	public Text m_Text;

	public string[] Toeic;

	public string[] Contest;

	private StringBuilder m_Builder;

	private float ElapsedTime;

	private int m_EndIndex;

	private int m_ListIndex;

	public GameObject ResultBtn;

	public static int TextPage;

	public GameObject NextButton;

	public void Awake()
	{
	}

	public void Start()
	{
	}

	public void TextStart()
	{
		TextPage++;
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = TextPage;
		if (EventCont.Event_N == 1)
		{
			m_Builder.Append(Toeic[m_ListIndex]);
		}
		if (EventCont.Event_N == 2)
		{
			m_Builder.Append(Contest[m_ListIndex]);
		}
	}

	public void FixedUpdate()
	{
		m_Text.text = m_Builder.ToString(0, m_EndIndex);
		ElapsedTime += Time.fixedDeltaTime * 12f;
		m_EndIndex = (int)ElapsedTime;
		if (m_EndIndex > m_Builder.Length)
		{
			m_EndIndex = m_Builder.Length;
		}
		if (m_EndIndex == m_Builder.Length)
		{
			m_ListIndex++;
		}
		if (m_EndIndex == m_Builder.Length)
		{
			End();
		}
	}

	public void End()
	{
		GotoNextText();
		m_EndIndex = m_Builder.Length;
		if (TextPage < 2)
		{
			NextButton.SetActive(true);
		}
	}

	public void GotoNextText()
	{
		if (TextPage >= 2)
		{
			NextButton.SetActive(false);
		}
		if (TextPage == 2)
		{
			NextButton.SetActive(false);
			resultBtn();
		}
	}

	public void NextBtn()
	{
		TextStart();
		NextButton.SetActive(false);
	}

	public void resultBtn()
	{
		NextButton.SetActive(false);
		ResultBtn.SetActive(true);
	}

	public void NextButtonFalse()
	{
		NextButton.SetActive(false);
	}
}
