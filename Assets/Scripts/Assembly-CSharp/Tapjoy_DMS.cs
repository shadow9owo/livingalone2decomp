using TapjoyUnity;
using UnityEngine;

public class Tapjoy_DMS : MonoBehaviour
{
	public TJPlacement offerwallPlacement;

	public static int tapjoy_plusmoney;

	public static int Tapjoybnt_click;

	public void Start()
	{
		if (!Tapjoy.IsConnected)
		{
			Tapjoy.OnConnectSuccess += HandleConnectSuccess;
			Tapjoy.OnConnectFailure += HandleConnectFailure;
			TJPlacement.OnRequestSuccess += HandlePlacementRequestSuccess;
			TJPlacement.OnRequestFailure += HandlePlacementRequestFailure;
			Tapjoy.Connect();
			if (offerwallPlacement == null)
			{
				offerwallPlacement = TJPlacement.CreatePlacement("offerwall");
			}
			Debug.Log("탭조이 커넥트요청");
		}
		else
		{
			Tapjoy.GetCurrencyBalance();
			if (offerwallPlacement == null)
			{
				offerwallPlacement = TJPlacement.CreatePlacement("offerwall");
			}
			Debug.Log("플레이스먼트요청");
		}
	}

	public void Opentapjoyplacement()
	{
		Tapjoy.GetCurrencyBalance();
		if (offerwallPlacement == null)
		{
			offerwallPlacement = TJPlacement.CreatePlacement("offerwall");
		}
		if (Tapjoy.IsConnected)
		{
			offerwallPlacement.RequestContent();
		}
		else
		{
			Tapjoy.Connect();
		}
		Debug.LogWarning("Tapjoy SDK must be connected before you can request content.");
	}

	public void OnEnable()
	{
		Tapjoy.OnConnectSuccess += HandleConnectSuccess;
		Tapjoy.OnConnectFailure += HandleConnectFailure;
		TJPlacement.OnRequestSuccess += HandlePlacementRequestSuccess;
		TJPlacement.OnRequestFailure += HandlePlacementRequestFailure;
		Tapjoy.OnEarnedCurrency += HandleEarnedCurrency;
		Tapjoy.OnGetCurrencyBalanceResponse += HandleGetCurrencyBalanceResponse;
		Tapjoy.OnGetCurrencyBalanceResponseFailure += HandleGetCurrencyBalanceResponseFailure;
		Tapjoy.OnAwardCurrencyResponse += HandleAwardCurrencyResponse;
		Tapjoy.OnAwardCurrencyResponseFailure += HandleAwardCurrencyResponseFailure;
	}

	private void OnDisable()
	{
		Debug.Log("C#: Disabling and removing Tapjoy Delegates");
		Tapjoy.OnConnectSuccess -= HandleConnectSuccess;
		Tapjoy.OnConnectFailure -= HandleConnectFailure;
		TJPlacement.OnRequestSuccess -= HandlePlacementRequestSuccess;
		TJPlacement.OnRequestFailure -= HandlePlacementRequestFailure;
		Tapjoy.OnEarnedCurrency -= HandleEarnedCurrency;
		Tapjoy.OnGetCurrencyBalanceResponse -= HandleGetCurrencyBalanceResponse;
		Tapjoy.OnGetCurrencyBalanceResponseFailure -= HandleGetCurrencyBalanceResponseFailure;
		Tapjoy.OnAwardCurrencyResponse -= HandleAwardCurrencyResponse;
		Tapjoy.OnAwardCurrencyResponseFailure -= HandleAwardCurrencyResponseFailure;
	}

	public void HandleGetCurrencyBalanceResponse(string currencyName, int balance)
	{
		Debug.Log("C#: HandleGetCurrencyBalanceResponse: currencyName: " + currencyName + ", balance: " + balance);
		tapjoy_plusmoney = balance;
		Tapjoy.GetCurrencyBalance();
		PlayerPrefs.SetInt("Tapjoybnt_click", 1);
	}

	public void HandleGetCurrencyBalanceResponseFailure(string error)
	{
		Debug.Log("C#: HandleGetCurrencyBalanceResponseFailure: " + error);
	}

	public void HandleEarnedCurrency(string currencyName, int amount)
	{
		Debug.Log("C#: HandleEarnedCurrency: currencyName: " + currencyName + ", amount: " + amount);
	}

	public void HandleAwardCurrencyResponse(string currencyName, int balance)
	{
		Debug.Log("C#: HandleAwardCurrencySucceeded: currencyName: " + currencyName + ", balance: " + balance);
	}

	public void HandleAwardCurrencyResponseFailure(string error)
	{
		Debug.Log("C#: HandleAwardCurrencyResponseFailure: " + error);
	}

	public void HandleConnectSuccess()
	{
		offerwallPlacement = TJPlacement.CreatePlacement("offerwall");
	}

	public void HandleConnectFailure()
	{
		Debug.Log("C#: Handle Connect Failure");
	}

	public void HandlePlacementRequestSuccess(TJPlacement placement)
	{
		if (offerwallPlacement.IsContentReady())
		{
			offerwallPlacement.ShowContent();
			Debug.Log("ShowContent");
		}
		else
		{
			Debug.Log("tapjoy is content not ready");
		}
	}

	public void HandlePlacementRequestFailure(TJPlacement placement, string error)
	{
		Debug.Log("placement request failed");
	}
}
