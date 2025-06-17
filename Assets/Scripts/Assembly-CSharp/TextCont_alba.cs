using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TextCont_alba : MonoBehaviour
{
	public Text m_Text;

	public string[] ptj_event;

	private StringBuilder m_Builder;

	private float ElapsedTime;

	private int m_EndIndex;

	private int m_ListIndex;

	public void Start()
	{
		TextCont.TextPage++;
		m_Builder = new StringBuilder();
		m_Builder.Remove(0, m_Builder.Length);
		ElapsedTime = 1f;
		m_EndIndex = 1;
		m_ListIndex = TextCont.TextPage;
	}

	public void TextStart()
	{
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
	}

	public void GotoNextText()
	{
	}
}
