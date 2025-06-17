using UnityEngine;
using UnityEngine.UI;

public class Head : MonoBehaviour
{
	public Sprite[] Hair_Image_M;

	public Sprite[] Hair_Image_W;

	public static int Hair_N;

	public void Start()
	{
		Hair_N = PlayerPrefs.GetInt("Hair_N");
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
	}

	private void FixedUpdate()
	{
		Image component = GetComponent<Image>();
		if (Char.Sex == 0)
		{
			if (Hair_N == 0)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[0];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[1];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[2];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[3];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[1];
				}
			}
			if (Hair_N == 1)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[4];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[5];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[6];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[7];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[5];
				}
			}
			if (Hair_N == 2)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[8];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[9];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[10];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[11];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[9];
				}
			}
			if (Hair_N == 3)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[12];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[13];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[14];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[15];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[13];
				}
			}
			if (Hair_N == 4)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[16];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[17];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[18];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[19];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[17];
				}
			}
			if (Hair_N == 5)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[20];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[21];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[22];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[23];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[21];
				}
			}
			if (Hair_N == 6)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[24];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[25];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[26];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[27];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[25];
				}
			}
			if (Hair_N == 7)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[28];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[29];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[30];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[31];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[29];
				}
			}
			if (Hair_N == 8)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[32];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[33];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[34];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[35];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[33];
				}
			}
			if (Hair_N == 9)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[36];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[37];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[38];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[39];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[37];
				}
			}
			if (Hair_N == 10)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[40];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[41];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[42];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[43];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[41];
				}
			}
			if (Hair_N == 11)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[44];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[45];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[46];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[47];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[45];
				}
			}
			if (Hair_N == 12)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[48];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[49];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[50];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[51];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[49];
				}
			}
			if (Hair_N == 13)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[52];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[53];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[54];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[55];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[53];
				}
			}
			if (Hair_N == 14)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[56];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[57];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[58];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[59];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[57];
				}
			}
			if (Hair_N == 15)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[60];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[61];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[62];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[63];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[61];
				}
			}
			if (Hair_N == 16)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[64];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[65];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[66];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[67];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[65];
				}
			}
			if (Hair_N == 17)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[68];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[69];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[70];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[71];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[69];
				}
			}
			if (Hair_N == 18)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[72];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[73];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[74];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[75];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[73];
				}
			}
			if (Hair_N == 19)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[76];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[77];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[78];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[79];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[77];
				}
			}
			if (Hair_N == 20)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[80];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[81];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[82];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[83];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[81];
				}
			}
			if (Hair_N == 21)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[84];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[85];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[86];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[87];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[85];
				}
			}
			if (Hair_N == 22)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[88];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[89];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[90];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[91];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[89];
				}
			}
			if (Hair_N == 23)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[92];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[93];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[94];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[95];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[93];
				}
			}
			if (Hair_N == 24)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[96];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[97];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[98];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[99];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[97];
				}
			}
			if (Hair_N == 25)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[100];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[101];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[102];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[103];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[101];
				}
			}
			if (Hair_N == 26)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[104];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[105];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[106];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[107];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[105];
				}
			}
			if (Hair_N == 27)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[108];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[109];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[110];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[111];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[109];
				}
			}
			if (Hair_N == 28)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[112];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[113];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[114];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[115];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[113];
				}
			}
			if (Hair_N == 29)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[116];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[117];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[118];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[119];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[117];
				}
			}
			if (Hair_N == 30)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[120];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[121];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[122];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[123];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[121];
				}
			}
			if (Hair_N == 31)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[124];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[125];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[126];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[127];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[125];
				}
			}
			if (Hair_N == 32)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[128];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[129];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[130];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[131];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[129];
				}
			}
			if (Hair_N == 33)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[132];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[133];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[134];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[135];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[133];
				}
			}
			if (Hair_N == 34)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[136];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[137];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[138];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[139];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[137];
				}
			}
			if (Hair_N == 35)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[140];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[141];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[142];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[143];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[141];
				}
			}
			if (Hair_N == 36)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[144];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[145];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[146];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[147];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[145];
				}
			}
			if (Hair_N == 37)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[148];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[149];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[150];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[151];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[149];
				}
			}
			if (Hair_N == 38)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[152];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[153];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[154];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[155];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[153];
				}
			}
			if (Hair_N == 39)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[156];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[157];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[158];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[159];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[157];
				}
			}
			if (Hair_N == 40)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[160];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[161];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[162];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[163];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[161];
				}
			}
			if (Hair_N == 41)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[164];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[165];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[166];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[167];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[165];
				}
			}
			if (Hair_N == 42)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[168];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[169];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[170];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[171];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[169];
				}
			}
			if (Hair_N == 43)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[172];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[173];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[174];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[175];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[173];
				}
			}
			if (Hair_N == 44)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[176];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[177];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[178];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[179];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[177];
				}
			}
			if (Hair_N == 45)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[180];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[181];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[182];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[183];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[181];
				}
			}
			if (Hair_N == 46)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[184];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[185];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[186];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[187];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[185];
				}
			}
			if (Hair_N == 47)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[188];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[189];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[190];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[191];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[189];
				}
			}
			if (Hair_N == 48)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[192];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[193];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[194];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[195];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[193];
				}
			}
			if (Hair_N == 49)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[196];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[197];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[198];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[199];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[197];
				}
			}
			if (Hair_N == 50)
			{
				if (Char._CharD == CharD.R)
				{
					component.sprite = Hair_Image_M[200];
				}
				if (Char._CharD == CharD.D)
				{
					component.sprite = Hair_Image_M[201];
				}
				if (Char._CharD == CharD.L)
				{
					component.sprite = Hair_Image_M[202];
				}
				if (Char._CharD == CharD.U)
				{
					component.sprite = Hair_Image_M[203];
				}
				if (Char._CharD == CharD.S)
				{
					component.sprite = Hair_Image_M[201];
				}
			}
		}
		if (Char.Sex != 1)
		{
			return;
		}
		if (Hair_N == 0)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[0];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[1];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[2];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[3];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[1];
			}
		}
		if (Hair_N == 1)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[4];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[5];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[6];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[7];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[5];
			}
		}
		if (Hair_N == 2)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[8];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[9];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[10];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[11];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[9];
			}
		}
		if (Hair_N == 3)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[12];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[13];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[14];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[15];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[13];
			}
		}
		if (Hair_N == 4)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[16];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[17];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[18];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[19];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[17];
			}
		}
		if (Hair_N == 5)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[20];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[21];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[22];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[23];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[21];
			}
		}
		if (Hair_N == 6)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[24];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[25];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[26];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[27];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[25];
			}
		}
		if (Hair_N == 7)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[28];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[29];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[30];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[31];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[29];
			}
		}
		if (Hair_N == 8)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[32];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[33];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[34];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[35];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[33];
			}
		}
		if (Hair_N == 9)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[36];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[37];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[38];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[39];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[37];
			}
		}
		if (Hair_N == 10)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[40];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[41];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[42];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[43];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[41];
			}
		}
		if (Hair_N == 11)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[44];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[45];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[46];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[47];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[45];
			}
		}
		if (Hair_N == 12)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[48];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[49];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[50];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[51];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[49];
			}
		}
		if (Hair_N == 13)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[52];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[53];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[54];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[55];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[53];
			}
		}
		if (Hair_N == 14)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[56];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[57];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[58];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[59];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[57];
			}
		}
		if (Hair_N == 15)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[60];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[61];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[62];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[63];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[61];
			}
		}
		if (Hair_N == 16)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[64];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[65];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[66];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[67];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[65];
			}
		}
		if (Hair_N == 17)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[68];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[69];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[70];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[71];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[69];
			}
		}
		if (Hair_N == 18)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[72];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[73];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[74];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[75];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[73];
			}
		}
		if (Hair_N == 19)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[76];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[77];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[78];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[79];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[77];
			}
		}
		if (Hair_N == 20)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[80];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[81];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[82];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[83];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[81];
			}
		}
		if (Hair_N == 21)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[84];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[85];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[86];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[87];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[85];
			}
		}
		if (Hair_N == 22)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[88];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[89];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[90];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[91];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[89];
			}
		}
		if (Hair_N == 23)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[92];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[93];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[94];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[95];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[93];
			}
		}
		if (Hair_N == 24)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[96];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[97];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[98];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[99];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[97];
			}
		}
		if (Hair_N == 25)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[100];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[101];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[102];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[103];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[101];
			}
		}
		if (Hair_N == 26)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[104];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[105];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[106];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[107];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[105];
			}
		}
		if (Hair_N == 27)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[108];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[109];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[110];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[111];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[109];
			}
		}
		if (Hair_N == 28)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[112];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[113];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[114];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[115];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[113];
			}
		}
		if (Hair_N == 29)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[116];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[117];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[118];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[119];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[117];
			}
		}
		if (Hair_N == 30)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[120];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[121];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[122];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[123];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[121];
			}
		}
		if (Hair_N == 31)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[124];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[125];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[126];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[127];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[125];
			}
		}
		if (Hair_N == 32)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[128];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[129];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[130];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[131];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[129];
			}
		}
		if (Hair_N == 33)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[132];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[133];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[134];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[135];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[133];
			}
		}
		if (Hair_N == 34)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[136];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[137];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[138];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[139];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[137];
			}
		}
		if (Hair_N == 35)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[140];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[141];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[142];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[143];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[141];
			}
		}
		if (Hair_N == 36)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[144];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[145];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[146];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[147];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[145];
			}
		}
		if (Hair_N == 37)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[148];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[149];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[150];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[151];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[149];
			}
		}
		if (Hair_N == 38)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[152];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[153];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[154];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[155];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[153];
			}
		}
		if (Hair_N == 39)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[156];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[157];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[158];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[159];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[157];
			}
		}
		if (Hair_N == 40)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[160];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[161];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[162];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[163];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[161];
			}
		}
		if (Hair_N == 41)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[164];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[165];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[166];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[167];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[165];
			}
		}
		if (Hair_N == 42)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[168];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[169];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[170];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[171];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[169];
			}
		}
		if (Hair_N == 43)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[172];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[173];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[174];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[175];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[173];
			}
		}
		if (Hair_N == 44)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[176];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[177];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[178];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[179];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[177];
			}
		}
		if (Hair_N == 45)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[180];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[181];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[182];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[183];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[181];
			}
		}
		if (Hair_N == 46)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[184];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[185];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[186];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[187];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[185];
			}
		}
		if (Hair_N == 47)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[188];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[189];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[190];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[191];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[189];
			}
		}
		if (Hair_N == 48)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[192];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[193];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[194];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[195];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[193];
			}
		}
		if (Hair_N == 49)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[196];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[197];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[198];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[199];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[197];
			}
		}
		if (Hair_N == 50)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = Hair_Image_W[200];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = Hair_Image_W[201];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = Hair_Image_W[202];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = Hair_Image_W[203];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = Hair_Image_W[201];
			}
		}
	}
}
