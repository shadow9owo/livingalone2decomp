using UnityEngine;
using UnityEngine.UI;

public class LoverHead : MonoBehaviour
{
	public Sprite[] Hair_Image_M;

	public Sprite[] Hair_Image_W;

	public static int L_Hair_N;

	public void Start()
	{
		L_Hair_N = PlayerPrefs.GetInt("L_Hair_N");
	}

	private void FixedUpdate()
	{
		Image component = GetComponent<Image>();
		if (LoverChar.L_Sex == 0)
		{
			if (L_Hair_N == 0)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[0];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[1];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[2];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[3];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[1];
				}
			}
			if (L_Hair_N == 1)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[4];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[5];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[6];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[7];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[5];
				}
			}
			if (L_Hair_N == 2)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[8];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[9];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[10];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[11];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[9];
				}
			}
			if (L_Hair_N == 3)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[12];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[13];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[14];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[15];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[13];
				}
			}
			if (L_Hair_N == 4)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[16];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[17];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[18];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[19];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[17];
				}
			}
			if (L_Hair_N == 5)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[20];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[21];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[22];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[23];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[21];
				}
			}
			if (L_Hair_N == 6)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[24];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[25];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[26];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[27];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[25];
				}
			}
			if (L_Hair_N == 7)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[28];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[29];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[30];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[31];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[29];
				}
			}
			if (L_Hair_N == 8)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[32];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[33];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[34];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[35];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[33];
				}
			}
			if (L_Hair_N == 9)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[36];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[37];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[38];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[39];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[37];
				}
			}
			if (L_Hair_N == 10)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[40];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[41];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[42];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[43];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[41];
				}
			}
			if (L_Hair_N == 11)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[44];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[45];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[46];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[47];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[45];
				}
			}
			if (L_Hair_N == 12)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[48];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[49];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[50];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[51];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[49];
				}
			}
			if (L_Hair_N == 13)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[52];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[53];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[54];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[55];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[53];
				}
			}
			if (L_Hair_N == 14)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[56];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[57];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[58];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[59];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[57];
				}
			}
			if (L_Hair_N == 15)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[60];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[61];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[62];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[63];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[61];
				}
			}
			if (L_Hair_N == 16)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[64];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[65];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[66];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[67];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[65];
				}
			}
			if (L_Hair_N == 17)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[68];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[69];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[70];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[71];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[69];
				}
			}
			if (L_Hair_N == 18)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[72];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[73];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[74];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[75];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[73];
				}
			}
			if (L_Hair_N == 19)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[76];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[77];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[78];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[79];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[77];
				}
			}
			if (L_Hair_N == 20)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[80];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[81];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[82];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[83];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[81];
				}
			}
			if (L_Hair_N == 21)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[84];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[85];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[86];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[87];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[85];
				}
			}
			if (L_Hair_N == 22)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[88];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[89];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[90];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[91];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[89];
				}
			}
			if (L_Hair_N == 23)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[92];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[93];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[94];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[95];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[93];
				}
			}
			if (L_Hair_N == 24)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[96];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[97];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[98];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[99];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[97];
				}
			}
			if (L_Hair_N == 25)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[100];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[101];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[102];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[103];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[101];
				}
			}
			if (L_Hair_N == 26)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[104];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[105];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[106];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[107];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[105];
				}
			}
			if (L_Hair_N == 27)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[108];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[109];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[110];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[111];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[109];
				}
			}
			if (L_Hair_N == 28)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[112];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[113];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[114];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[115];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[113];
				}
			}
			if (L_Hair_N == 29)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[116];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[117];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[118];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[119];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[117];
				}
			}
			if (L_Hair_N == 30)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[120];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[121];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[122];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[123];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[121];
				}
			}
			if (L_Hair_N == 31)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[124];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[125];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[126];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[127];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[125];
				}
			}
			if (L_Hair_N == 32)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[128];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[129];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[130];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[131];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[129];
				}
			}
			if (L_Hair_N == 33)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[132];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[133];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[134];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[135];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[133];
				}
			}
			if (L_Hair_N == 34)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[136];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[137];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[138];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[139];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[137];
				}
			}
			if (L_Hair_N == 35)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[140];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[141];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[142];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[143];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[141];
				}
			}
			if (L_Hair_N == 36)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[144];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[145];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[146];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[147];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[145];
				}
			}
			if (L_Hair_N == 37)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[148];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[149];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[150];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[151];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[149];
				}
			}
			if (L_Hair_N == 38)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[152];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[153];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[154];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[155];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[153];
				}
			}
			if (L_Hair_N == 39)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[156];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[157];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[158];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[159];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[157];
				}
			}
			if (L_Hair_N == 40)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[160];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[161];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[162];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[163];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[161];
				}
			}
			if (L_Hair_N == 41)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[164];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[165];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[166];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[167];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[165];
				}
			}
			if (L_Hair_N == 42)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[168];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[169];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[170];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[171];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[169];
				}
			}
			if (L_Hair_N == 43)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[172];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[173];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[174];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[175];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[173];
				}
			}
			if (L_Hair_N == 44)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[176];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[177];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[178];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[179];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[177];
				}
			}
			if (L_Hair_N == 45)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[180];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[181];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[182];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[183];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[181];
				}
			}
			if (L_Hair_N == 46)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[184];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[185];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[186];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[187];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[185];
				}
			}
			if (L_Hair_N == 47)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[188];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[189];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[190];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[191];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[189];
				}
			}
			if (L_Hair_N == 48)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[192];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[193];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[194];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[195];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[193];
				}
			}
			if (L_Hair_N == 49)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[196];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[197];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[198];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[199];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[197];
				}
			}
			if (L_Hair_N == 50)
			{
				if (LoverChar._L_CharD == L_CharD.R)
				{
					component.sprite = Hair_Image_M[200];
				}
				if (LoverChar._L_CharD == L_CharD.D)
				{
					component.sprite = Hair_Image_M[201];
				}
				if (LoverChar._L_CharD == L_CharD.L)
				{
					component.sprite = Hair_Image_M[202];
				}
				if (LoverChar._L_CharD == L_CharD.U)
				{
					component.sprite = Hair_Image_M[203];
				}
				if (LoverChar._L_CharD == L_CharD.S)
				{
					component.sprite = Hair_Image_M[201];
				}
			}
		}
		if (LoverChar.L_Sex != 1)
		{
			return;
		}
		if (L_Hair_N == 0)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[0];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[1];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[2];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[3];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[1];
			}
		}
		if (L_Hair_N == 1)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[4];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[5];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[6];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[7];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[5];
			}
		}
		if (L_Hair_N == 2)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[8];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[9];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[10];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[11];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[9];
			}
		}
		if (L_Hair_N == 3)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[12];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[13];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[14];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[15];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[13];
			}
		}
		if (L_Hair_N == 4)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[16];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[17];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[18];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[19];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[17];
			}
		}
		if (L_Hair_N == 5)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[20];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[21];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[22];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[23];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[21];
			}
		}
		if (L_Hair_N == 6)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[24];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[25];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[26];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[27];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[25];
			}
		}
		if (L_Hair_N == 7)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[28];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[29];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[30];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[31];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[29];
			}
		}
		if (L_Hair_N == 8)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[32];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[33];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[34];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[35];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[33];
			}
		}
		if (L_Hair_N == 9)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[36];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[37];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[38];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[39];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[37];
			}
		}
		if (L_Hair_N == 10)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[40];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[41];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[42];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[43];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[41];
			}
		}
		if (L_Hair_N == 11)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[44];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[45];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[46];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[47];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[45];
			}
		}
		if (L_Hair_N == 12)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[48];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[49];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[50];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[51];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[49];
			}
		}
		if (L_Hair_N == 13)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[52];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[53];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[54];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[55];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[53];
			}
		}
		if (L_Hair_N == 14)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[56];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[57];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[58];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[59];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[57];
			}
		}
		if (L_Hair_N == 15)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[60];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[61];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[62];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[63];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[61];
			}
		}
		if (L_Hair_N == 16)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[64];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[65];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[66];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[67];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[65];
			}
		}
		if (L_Hair_N == 17)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[68];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[69];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[70];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[71];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[69];
			}
		}
		if (L_Hair_N == 18)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[72];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[73];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[74];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[75];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[73];
			}
		}
		if (L_Hair_N == 19)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[76];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[77];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[78];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[79];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[77];
			}
		}
		if (L_Hair_N == 20)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[80];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[81];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[82];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[83];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[81];
			}
		}
		if (L_Hair_N == 21)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[84];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[85];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[86];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[87];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[85];
			}
		}
		if (L_Hair_N == 22)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[88];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[89];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[90];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[91];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[89];
			}
		}
		if (L_Hair_N == 23)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[92];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[93];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[94];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[95];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[93];
			}
		}
		if (L_Hair_N == 24)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[96];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[97];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[98];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[99];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[97];
			}
		}
		if (L_Hair_N == 25)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[100];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[101];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[102];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[103];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[101];
			}
		}
		if (L_Hair_N == 26)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[104];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[105];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[106];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[107];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[105];
			}
		}
		if (L_Hair_N == 27)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[108];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[109];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[110];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[111];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[109];
			}
		}
		if (L_Hair_N == 28)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[112];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[113];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[114];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[115];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[113];
			}
		}
		if (L_Hair_N == 29)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[116];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[117];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[118];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[119];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[117];
			}
		}
		if (L_Hair_N == 30)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[120];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[121];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[122];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[123];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[121];
			}
		}
		if (L_Hair_N == 31)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[124];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[125];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[126];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[127];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[125];
			}
		}
		if (L_Hair_N == 32)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[128];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[129];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[130];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[131];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[129];
			}
		}
		if (L_Hair_N == 33)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[132];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[133];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[134];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[135];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[133];
			}
		}
		if (L_Hair_N == 34)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[136];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[137];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[138];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[139];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[137];
			}
		}
		if (L_Hair_N == 35)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[140];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[141];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[142];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[143];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[141];
			}
		}
		if (L_Hair_N == 36)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[144];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[145];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[146];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[147];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[145];
			}
		}
		if (L_Hair_N == 37)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[148];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[149];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[150];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[151];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[149];
			}
		}
		if (L_Hair_N == 38)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[152];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[153];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[154];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[155];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[153];
			}
		}
		if (L_Hair_N == 39)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[156];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[157];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[158];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[159];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[157];
			}
		}
		if (L_Hair_N == 40)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[160];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[161];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[162];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[163];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[161];
			}
		}
		if (L_Hair_N == 41)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[164];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[165];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[166];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[167];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[165];
			}
		}
		if (L_Hair_N == 42)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[168];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[169];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[170];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[171];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[169];
			}
		}
		if (L_Hair_N == 43)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[172];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[173];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[174];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[175];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[173];
			}
		}
		if (L_Hair_N == 44)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[176];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[177];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[178];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[179];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[177];
			}
		}
		if (L_Hair_N == 45)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[180];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[181];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[182];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[183];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[181];
			}
		}
		if (L_Hair_N == 46)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[184];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[185];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[186];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[187];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[185];
			}
		}
		if (L_Hair_N == 47)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[188];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[189];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[190];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[191];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[189];
			}
		}
		if (L_Hair_N == 48)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[192];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[193];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[194];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[195];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[193];
			}
		}
		if (L_Hair_N == 49)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[196];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[197];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[198];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[199];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[197];
			}
		}
		if (L_Hair_N == 50)
		{
			if (LoverChar._L_CharD == L_CharD.R)
			{
				component.sprite = Hair_Image_W[200];
			}
			if (LoverChar._L_CharD == L_CharD.D)
			{
				component.sprite = Hair_Image_W[201];
			}
			if (LoverChar._L_CharD == L_CharD.L)
			{
				component.sprite = Hair_Image_W[202];
			}
			if (LoverChar._L_CharD == L_CharD.U)
			{
				component.sprite = Hair_Image_W[203];
			}
			if (LoverChar._L_CharD == L_CharD.S)
			{
				component.sprite = Hair_Image_W[201];
			}
		}
	}
}
