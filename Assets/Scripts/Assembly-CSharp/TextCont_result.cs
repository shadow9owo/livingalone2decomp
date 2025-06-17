using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextCont_result : MonoBehaviour
{
	public Text m_Text;

	public string[] EventResultText;

	private StringBuilder m_Builder;

	private float ElapsedTime;

	private int m_EndIndex;

	private int m_ListIndex;

	public static int Result_N;

	public static int Result_N_percent;

	public void Start()
	{
	}

	public void TextStart()
	{
		Result_N_percent = Random.Range(0, 101);
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		if (EventCont.Event_N == 1)
		{
			if (Result_N_percent < 60)
			{
				Result_N = 0;
			}
			if (Result_N_percent >= 60 && Result_N_percent < 90)
			{
				Result_N = 1;
			}
			if (Result_N_percent >= 90)
			{
				Result_N = 2;
			}
		}
		if (EventCont.Event_N == 2)
		{
			if (Result_N_percent < 60)
			{
				Result_N = 3;
			}
			if (Result_N_percent >= 60 && Result_N_percent < 90)
			{
				Result_N = 4;
			}
			if (Result_N_percent >= 90)
			{
				Result_N = 5;
			}
		}
		m_ListIndex = Result_N;
		m_Builder.Append(EventResultText[m_ListIndex]);
	}

	public void FixedUpdate()
	{
		m_Text.text = m_Builder.ToString(0, m_EndIndex);
		ElapsedTime += Time.fixedDeltaTime * 10f;
		m_EndIndex = (int)ElapsedTime;
		if (m_EndIndex > m_Builder.Length)
		{
			m_EndIndex = m_Builder.Length;
		}
		if (Input.GetMouseButtonDown(0))
		{
			if (m_EndIndex == m_Builder.Length)
			{
				m_ListIndex++;
			}
			else
			{
				ElapsedTime = m_Builder.Length;
				m_EndIndex = m_Builder.Length;
			}
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
}
