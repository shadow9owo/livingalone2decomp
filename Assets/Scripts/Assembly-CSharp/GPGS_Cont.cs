using UnityEngine;

public class GPGS_Cont : MonoBehaviour
{
	private string leaderboard;

	private bool ACH1;

	private bool ACH2;

	private bool ACH3;

	private bool ACH4;

	private bool ACH5;

	private bool ACH6;

	private bool ACH7;

	private bool ACH8;

	private bool ACH9;

	private bool ACH10;

	private bool ACH11;

	private bool ACH12;

	private bool ACH13;

	private bool ACH14;

	private bool ACH15;

	private bool ACH16;

	private bool ACH17;

	private bool ACH18;

	private bool ACH19;

	private bool ACH20;

	private bool ACH21;

	private bool ACH22;

	private bool ACH23;

	private bool ACH24;

	private bool ACH25;

	private bool ACH26;

	private bool ACH27;

	private bool ACH28;

	private bool ACH29;

	private bool ACH30;

	private void Start()
	{
		s3_7.PetBuyOK = PlayerPrefs.GetInt("PetBuyOK");
		SuddenDeathCont.Death_Count = PlayerPrefs.GetInt("Death_Count");
		s3_7.RoomBuyOK = PlayerPrefs.GetInt("RoomBuyOK");
		s3_7.FurnBuyOK = PlayerPrefs.GetInt("FurnBuyOK");
		s3_7.ClotheBuyOK = PlayerPrefs.GetInt("ClotheBuyOK");
		s3_7.HairBuyOK = PlayerPrefs.GetInt("HairBuyOK");
		s3_7.HowmanyPETOK = PlayerPrefs.GetInt("HowmanyPETOK");
		s3_7.CarBuyOK = PlayerPrefs.GetInt("CarBuyOK");
		if (s3_7.RoomBuyOK >= 1 && !ACH8)
		{
			Social.ReportProgress("CggIucGi6TMQAhAB", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH8 = true;
			if (s3_7.RoomBuyOK >= 1 && ACH8)
			{
				ACH8 = true;
			}
		}
		if (s3_7.RoomBuyOK >= 4 && !ACH2)
		{
			Social.ReportProgress("CggIucGi6TMQAhAC", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH2 = true;
			if (s3_7.RoomBuyOK >= 4 && ACH2)
			{
				ACH2 = true;
			}
		}
		if (s3_7.RoomBuyOK >= 6 && !ACH9)
		{
			Social.ReportProgress("CggIucGi6TMQAhAD", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH9 = true;
			if (s3_7.RoomBuyOK >= 6 && ACH9)
			{
				ACH9 = true;
			}
		}
		if (s3_7.RoomBuyOK >= 11 && !ACH10)
		{
			Social.ReportProgress("CggIucGi6TMQAhAE", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH10 = true;
			if (s3_7.RoomBuyOK >= 11 && ACH10)
			{
				ACH10 = true;
			}
		}
		if (s3_7.RoomBuyOK >= 14 && !ACH10)
		{
			Social.ReportProgress("CggIucGi6TMQAhAF", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH10 = true;
			if (s3_7.RoomBuyOK >= 14 && ACH10)
			{
				ACH10 = true;
			}
		}
		if (s3_7.ClotheBuyOK >= 1 && !ACH11)
		{
			Social.ReportProgress("CggIucGi6TMQAhAG", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH11 = true;
			if (s3_7.ClotheBuyOK >= 1 && ACH11)
			{
				ACH11 = true;
			}
		}
		if (s3_7.ClotheBuyOK >= 10 && !ACH3)
		{
			Social.ReportProgress("CggIucGi6TMQAhAH", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH3 = true;
			if (s3_7.ClotheBuyOK >= 10 && ACH3)
			{
				ACH3 = true;
			}
		}
		if (s3_7.ClotheBuyOK >= 20 && !ACH12)
		{
			Social.ReportProgress("CggIucGi6TMQAhAI", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH12 = true;
			if (s3_7.ClotheBuyOK >= 20 && ACH12)
			{
				ACH12 = true;
			}
		}
		if (s3_7.ClotheBuyOK >= 30 && !ACH4)
		{
			Social.ReportProgress("CggIucGi6TMQAhAJ", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH4 = true;
			if (s3_7.ClotheBuyOK >= 30 && ACH4)
			{
				ACH4 = true;
			}
		}
		if (s3_7.PetBuyOK >= 1 && !ACH1)
		{
			Social.ReportProgress("CggIucGi6TMQAhAP", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH1 = true;
			if (s3_7.PetBuyOK >= 1 && ACH1)
			{
				ACH1 = true;
			}
		}
		if (s3_7.HowmanyPETOK >= 26 && !ACH6)
		{
			Social.ReportProgress("CggIucGi6TMQAhAQ", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH6 = true;
			if (s3_7.HowmanyPETOK >= 17 && ACH6)
			{
				ACH6 = true;
			}
		}
		if (s3_7.HowmanyPETOK < 10 || ACH7)
		{
			return;
		}
		Social.ReportProgress("CggIucGi6TMQAhAR", 100.0, delegate(bool success_1)
		{
			if (!success_1)
			{
			}
		});
		ACH7 = true;
		if (s3_7.HowmanyPETOK >= 10 && ACH7)
		{
			ACH7 = true;
		}
	}

	public void Suddendeathending()
	{
		return; //useless feature, removed for clarity it randomly gameoveres the player bczs fuck you
        if (SuddenDeathCont.Death_Count >= 1 && !ACH5)
		{
			Social.ReportProgress("CggIucGi6TMQAhAK", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH5 = true;
			if (SuddenDeathCont.Death_Count >= 1 && ACH5)
			{
				ACH5 = true;
			}
		}
		if (SuddenDeathCont.Death_Count >= 10 && !ACH13)
		{
			Social.ReportProgress("CggIucGi6TMQAhAL", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH13 = true;
			if (SuddenDeathCont.Death_Count >= 10 && ACH13)
			{
				ACH13 = true;
			}
		}
		if (SuddenDeathCont.Death_Count >= 30 && !ACH14)
		{
			Social.ReportProgress("CggIucGi6TMQAhAN", 100.0, delegate(bool success_1)
			{
				if (!success_1)
				{
				}
			});
			ACH14 = true;
			if (SuddenDeathCont.Death_Count >= 30 && ACH14)
			{
				ACH14 = true;
			}
		}
		if (SuddenDeathCont.Death_Count < 60 || ACH16)
		{
			return;
		}
		Social.ReportProgress("CggIucGi6TMQAhAO", 100.0, delegate(bool success_1)
		{
			if (!success_1)
			{
			}
		});
		ACH16 = true;
		if (SuddenDeathCont.Death_Count >= 60 && ACH16)
		{
			ACH16 = true;
		}
	}

	public void Login()
	{
		Debug.Log("Login");
		Social.localUser.Authenticate(delegate(bool success)
		{
			if (success)
			{
				Debug.Log("You've successfully logged in");
			}
			else
			{
				Debug.Log("Login failed for some reason");
			}
		});
	}

	public void Leaderboard()
	{
		Debug.Log("Leaderboard");
		Login();
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		Debug.Log("scene_controll.money" + scene_controll.money);
		if (!Social.localUser.authenticated)
		{
			return;
		}
		scene_controll.money_Text = SPrefs.GetString("final_money2");
		scene_controll.money = long.Parse(scene_controll.money_Text);
		Debug.Log("scene_controll.money" + scene_controll.money);
		Social.ReportScore(scene_controll.money, "CggIucGi6TMQAhAS", delegate(bool success)
		{
			if (success)
			{

			}
		});
		Social.ReportScore(GraduateCont.EndingCount, "CggIucGi6TMQAhAT", delegate(bool success)
		{
			if (success)
			{

			}
		});
		Social.ReportScore(TimeCont.GPGS_Playhour, "CggIucGi6TMQAhAU", delegate(bool success)
		{
			if (success)
			{

			}
		});
		Social.localUser.Authenticate(delegate(bool success)
		{
			if (success)
			{
				Social.ShowLeaderboardUI();
			}
		});
	}

	public void Achievement()
	{
		Login();
		Social.localUser.Authenticate(delegate(bool success)
		{
			if (success)
			{
				Social.ShowAchievementsUI();
			}
			else
			{
				Login();
			}
		});
	}

	public void IncrementAchievement()
	{
		GraduateCont.EndingCount = PlayerPrefs.GetInt("EndingCount", GraduateCont.EndingCount);
	}
}
