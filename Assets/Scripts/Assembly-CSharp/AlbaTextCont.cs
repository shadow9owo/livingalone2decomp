using UnityEngine;
using UnityEngine.UI;

public class AlbaTextCont : MonoBehaviour
{
	public Text m_Text;

	public string[] AlbaTalk;

	public static int TextPage;

	public void Awake()
	{
	}

	public void Start()
	{
		TimeCont.OneMonth = PlayerPrefs.GetInt("OneMonth");
	}

	public void TextStart()
	{
		AlbaTalk[0] = string.Format("비둘기만 날린다. 한푼도 못벌었다.");
		AlbaTalk[1] = string.Format("탈속에서 쪄 죽는줄 알았지만 돈은 벌었다.");
		AlbaTalk[2] = string.Format("서서 졸았다. 혼만나고 한푼도 못벌었다.");
		AlbaTalk[3] = string.Format("다리가 퉁퉁 부었지만 그래도 돈은 벌었다.");
		AlbaTalk[4] = string.Format("저 대머리 진상. 또 왔다. 한 푼도 못벌었다.");
		AlbaTalk[5] = string.Format("가끔씩 무시하는 손님들이 있지만 괜찮다. 돈은 벌었다.");
		AlbaTalk[6] = string.Format("저 진상. 오늘은 뭘 바꾸러온건지. 한푼도 못벌었다.");
		AlbaTalk[7] = string.Format("테스터제품을 도둑맞은 것 빼곤 괜찮은 하루였다. 돈은 벌었으니까.");
		AlbaTalk[8] = string.Format("텃세가 장난이 아니다. 잘못을 덮어쓰기 당해 한푼도 못벌었다.");
		AlbaTalk[9] = string.Format("따뜻한 아이스 아메리카노를 시킨 손님 빼고는 무난한 하루였다.");
		AlbaTalk[10] = string.Format("난 가만히 있었는데 카트가 넘어졌다. 억울하지만 한푼도 못벌었다.");
		AlbaTalk[11] = string.Format("서빙은 힘들지만 돈을 벌었기 때문에 괜찮은 하루였다.");
		AlbaTalk[12] = string.Format("하차실수로 물건을 파손시켰다. 한푼도 못벌었다.");
		AlbaTalk[13] = string.Format("팔과 어깨가 빠개질것 같지만 괜찮다. 돈을 벌었으니까.");
		AlbaTalk[14] = string.Format("대단한 진상이 나타났다. 결국 오늘 한푼도 벌지 못했다.");
		AlbaTalk[15] = string.Format("귀가 어두운 사람들이 많은 것 같지만 그래도 돈은 벌었으니 됐다.");
		AlbaTalk[16] = string.Format("부품이 폭발했다. 죽진 않았지만 돈은 한푼도 벌지 못했다.");
		AlbaTalk[17] = string.Format("미친듯이 일한 것같다. 기계부품이 된것같다. 하지만 돈을 벌어서 좋다.");
		AlbaTalk[18] = string.Format("학생들이 오지않는다. 오늘 수업은 무산되었다.");
		AlbaTalk[19] = string.Format("학생들이 숙제를 잊은것 빼곤 괜찮았다. 돈은 벌었으니까.");
	}
}
