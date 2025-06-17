using UnityEngine;
using UnityEngine.UI;

public class w_Head : MonoBehaviour
{
	public Sprite[] w_Hair_Image;

	public void Awake()
	{
	}

	public void Start()
	{
		Head.Hair_N = PlayerPrefs.GetInt("Hair_N");
		Clothes.Clothes_N = PlayerPrefs.GetInt("Clothes_N");
		PlayerPrefs.SetInt("Hair_N", Head.Hair_N);
	}

	private void FixedUpdate()
	{
		Image component = GetComponent<Image>();
		if (Char.Sex != 1)
		{
			return;
		}
		if (Head.Hair_N == 0)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[0];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[1];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[2];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[3];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[1];
			}
		}
		if (Head.Hair_N == 1)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[4];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[5];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[6];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[7];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[5];
			}
		}
		if (Head.Hair_N == 2)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[8];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[9];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[10];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[11];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[9];
			}
		}
		if (Head.Hair_N == 3)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[12];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[13];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[14];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[15];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[13];
			}
		}
		if (Head.Hair_N == 4)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[16];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[17];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[18];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[19];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[17];
			}
		}
		if (Head.Hair_N == 5)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[20];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[21];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[22];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[23];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[21];
			}
		}
		if (Head.Hair_N == 6)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[24];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[25];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[26];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[27];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[25];
			}
		}
		if (Head.Hair_N == 7)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[28];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[29];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[30];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[31];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[29];
			}
		}
		if (Head.Hair_N == 8)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[32];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[33];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[34];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[35];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[33];
			}
		}
		if (Head.Hair_N == 9)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[36];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[37];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[38];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[39];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[37];
			}
		}
		if (Head.Hair_N == 10)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[40];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[41];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[42];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[43];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[41];
			}
		}
		if (Head.Hair_N == 11)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[44];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[45];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[46];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[47];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[45];
			}
		}
		if (Head.Hair_N == 12)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[48];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[49];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[50];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[51];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[49];
			}
		}
		if (Head.Hair_N == 13)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[52];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[53];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[54];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[55];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[53];
			}
		}
		if (Head.Hair_N == 14)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[56];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[57];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[58];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[59];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[57];
			}
		}
		if (Head.Hair_N == 15)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[60];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[61];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[62];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[63];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[61];
			}
		}
		if (Head.Hair_N == 16)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[64];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[65];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[66];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[67];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[65];
			}
		}
		if (Head.Hair_N == 17)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[68];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[69];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[70];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[71];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[69];
			}
		}
		if (Head.Hair_N == 18)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[72];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[73];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[74];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[75];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[73];
			}
		}
		if (Head.Hair_N == 19)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[76];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[77];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[78];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[79];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[77];
			}
		}
		if (Head.Hair_N == 20)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[80];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[81];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[82];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[83];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[81];
			}
		}
		if (Head.Hair_N == 21)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[84];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[85];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[86];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[87];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[85];
			}
		}
		if (Head.Hair_N == 22)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[88];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[89];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[90];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[91];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[89];
			}
		}
		if (Head.Hair_N == 23)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[92];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[93];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[94];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[95];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[93];
			}
		}
		if (Head.Hair_N == 24)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[96];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[97];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[98];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[99];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[97];
			}
		}
		if (Head.Hair_N == 25)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[100];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[101];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[102];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[103];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[101];
			}
		}
		if (Head.Hair_N == 26)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[104];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[105];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[106];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[107];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[105];
			}
		}
		if (Head.Hair_N == 27)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[108];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[109];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[110];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[111];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[109];
			}
		}
		if (Head.Hair_N == 28)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[112];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[113];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[114];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[115];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[113];
			}
		}
		if (Head.Hair_N == 29)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[116];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[117];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[118];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[119];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[117];
			}
		}
		if (Head.Hair_N == 30)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[120];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[121];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[122];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[123];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[121];
			}
		}
		if (Head.Hair_N == 31)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[124];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[125];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[126];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[127];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[125];
			}
		}
		if (Head.Hair_N == 32)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[128];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[129];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[130];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[131];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[129];
			}
		}
		if (Head.Hair_N == 33)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[132];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[133];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[134];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[135];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[133];
			}
		}
		if (Head.Hair_N == 34)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[136];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[137];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[138];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[139];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[137];
			}
		}
		if (Head.Hair_N == 35)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[140];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[141];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[142];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[143];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[141];
			}
		}
		if (Head.Hair_N == 36)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[144];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[145];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[146];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[147];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[145];
			}
		}
		if (Head.Hair_N == 37)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[148];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[149];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[150];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[151];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[149];
			}
		}
		if (Head.Hair_N == 38)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[152];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[153];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[154];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[155];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[153];
			}
		}
		if (Head.Hair_N == 39)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[156];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[157];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[158];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[159];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[157];
			}
		}
		if (Head.Hair_N == 40)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[160];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[161];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[162];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[163];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[161];
			}
		}
		if (Head.Hair_N == 41)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[164];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[165];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[166];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[167];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[165];
			}
		}
		if (Head.Hair_N == 42)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[168];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[169];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[170];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[171];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[169];
			}
		}
		if (Head.Hair_N == 43)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[172];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[173];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[174];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[175];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[173];
			}
		}
		if (Head.Hair_N == 44)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[176];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[177];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[178];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[179];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[177];
			}
		}
		if (Head.Hair_N == 45)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[180];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[181];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[182];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[183];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[181];
			}
		}
		if (Head.Hair_N == 46)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[184];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[185];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[186];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[187];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[185];
			}
		}
		if (Head.Hair_N == 47)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[188];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[189];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[190];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[191];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[189];
			}
		}
		if (Head.Hair_N == 48)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[192];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[193];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[194];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[195];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[193];
			}
		}
		if (Head.Hair_N == 49)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[196];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[197];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[198];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[199];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[197];
			}
		}
		if (Head.Hair_N == 50)
		{
			if (Char._CharD == CharD.R)
			{
				component.sprite = w_Hair_Image[200];
			}
			if (Char._CharD == CharD.D)
			{
				component.sprite = w_Hair_Image[201];
			}
			if (Char._CharD == CharD.L)
			{
				component.sprite = w_Hair_Image[202];
			}
			if (Char._CharD == CharD.U)
			{
				component.sprite = w_Hair_Image[203];
			}
			if (Char._CharD == CharD.S)
			{
				component.sprite = w_Hair_Image[201];
			}
		}
	}
}
