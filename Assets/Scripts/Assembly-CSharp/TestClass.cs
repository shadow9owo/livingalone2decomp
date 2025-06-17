using UnityEngine;
using UnityEngine.UI;

public class TestClass : MonoBehaviour
{
	private const string someKey = "KEY";

	private const string someString = "testString";

	private const int someInt = 152;

	private const float someFloat = -0.001f;

	private const string someCrazyKey = "KEYÖäÜ$!?@";

	private const string someCrazyString = "ÖÄÜ$!@";

	private const int someCrazyInt = int.MinValue;

	private const float someCrazyFloat = 1E-20f;

	private const string emptyString = "";

	private const int zeroInt = 0;

	private const float zeroFloat = 0f;

	public Text output1;

	public Text output2;

	public Text output3;

	public Text output4;

	public Text output5;

	public Text output6;

	private int errorCount;

	private void Start()
	{
		GeneralTest();
		TestKeySystem();
		TestIntStoring();
		TestSPrefsDeleteKey();
		TestDefaultValues();
		TestExtremeValues();
		if (errorCount < 1)
		{
			Debug.Log("All tests succeeded");
			output6.text = "All tests succeeded";
		}
		else
		{
			Debug.Log("Some tests failed. Error count: " + errorCount);
			output6.text = "Some tests failed. Error count: " + errorCount;
		}
	}

	private void GeneralTest()
	{
		string empty = string.Empty;
		SPrefs.SetString("KEY", "testString");
		if (SPrefs.GetString("KEY").Equals("testString"))
		{
			output1.text = "SPrefs working!";
		}
		else
		{
			output1.text = "Encryption is probably not possible on this platform";
			AddError("SPrefs SetString or GetString not working");
		}
		empty = Cryptor.Encrypt("testString");
		output2.text = "Original: testString";
		output3.text = "Encrypted: " + empty;
		empty = Cryptor.Decrypt(empty);
		output4.text = "Decrypted: " + empty;
		output5.text = "Cryptor working: " + empty.Equals("testString");
		if (!empty.Equals("testString"))
		{
			AddError("Crypting not working");
		}
		SPrefs.DeleteAll();
	}

	private void TestKeySystem()
	{
		SPrefs.SetInt("KEY", 152);
		if (SPrefs.GetString("KEY").Length > 0)
		{
			AddError("key system not ok");
		}
		SPrefs.DeleteAll();
	}

	private void TestIntStoring()
	{
		SPrefs.SetInt("KEY", 152);
		if (SPrefs.GetInt("KEY") != 152)
		{
			AddError("int was not stored");
		}
		SPrefs.DeleteAll();
	}

	private void TestSPrefsDeleteKey()
	{
		if (SPrefs.HasKey("KEY"))
		{
			AddError("HasKey detected wrong key!");
		}
		SPrefs.SetFloat("KEY", -0.001f);
		if (!Mathf.Approximately(SPrefs.GetFloat("KEY"), -0.001f))
		{
			AddError("float was not stored");
		}
		if (!SPrefs.HasKey("KEY"))
		{
			AddError("HasKey didn't detect key!");
		}
		SPrefs.SetFloat("example", 1f);
		SPrefs.DeleteKey("KEY");
		if (SPrefs.HasKey("KEY"))
		{
			AddError("Key was not deleted!");
		}
		if (!Mathf.Approximately(SPrefs.GetFloat("example"), 1f))
		{
			AddError("Key deletion affects wrong key!");
		}
		SPrefs.DeleteAll();
	}

	private void TestDefaultValues()
	{
		if (!SPrefs.GetString("KEY", "abcd").Equals("abcd"))
		{
			AddError("Default string not returned!");
		}
		if (SPrefs.GetInt("KEY", 3) != 3)
		{
			AddError("Default int not returned!");
		}
		if (!Mathf.Approximately(SPrefs.GetFloat("KEY", 2f), 2f))
		{
			AddError("Default float not returned!");
		}
		SPrefs.SetFloat("KEY", -0.001f);
		if (!Mathf.Approximately(SPrefs.GetFloat("KEY", 2f), -0.001f))
		{
			AddError("Default float overwrite!");
		}
		if (SPrefs.GetInt("KEY", 3) != 3)
		{
			AddError("Default int not returned after float set!");
		}
		if (SPrefs.GetBool("KEY"))
		{
			AddError("Default bool is not 'false'");
		}
		SPrefs.SetBool("KEY", true);
		if (!SPrefs.GetBool("KEY", false))
		{
			AddError("Default bool overwrite!");
		}
		SPrefs.DeleteAll();
	}

	private void TestExtremeValues()
	{
		SPrefs.SetString("KEYÖäÜ$!?@", "ÖÄÜ$!@");
		if (!"ÖÄÜ$!@".Equals(SPrefs.GetString("KEYÖäÜ$!?@")))
		{
			AddError("String Umlauts problem");
		}
		SPrefs.SetInt("KEYÖäÜ$!?@", int.MinValue);
		if (SPrefs.GetInt("KEYÖäÜ$!?@") != int.MinValue)
		{
			AddError("Negative int max value not ok");
		}
		SPrefs.SetFloat("KEYÖäÜ$!?@", 1E-20f);
		if (!Mathf.Approximately(1E-20f, SPrefs.GetFloat("KEYÖäÜ$!?@")))
		{
			AddError("Problem with very small float numbers");
		}
		SPrefs.DeleteKey("KEYÖäÜ$!?@");
		SPrefs.SetString("KEYÖäÜ$!?@", string.Empty);
		if (!string.Empty.Equals(SPrefs.GetString("KEYÖäÜ$!?@")))
		{
			AddError("Empty string problem");
		}
		SPrefs.SetInt("KEYÖäÜ$!?@", 0);
		if (SPrefs.GetInt("KEYÖäÜ$!?@") != 0)
		{
			AddError("Int zero problem");
		}
		SPrefs.SetFloat("KEYÖäÜ$!?@", 0f);
		if (!Mathf.Approximately(0f, SPrefs.GetFloat("KEYÖäÜ$!?@")))
		{
			AddError("Float zero problem");
		}
		SPrefs.DeleteKey("KEYÖäÜ$!?@");
		SPrefs.SetString(null, null);
		SPrefs.GetString(null);
		SPrefs.SetInt(null, 0);
		SPrefs.GetInt(null);
		SPrefs.SetFloat(null, 0f);
		SPrefs.GetFloat(null);
		SPrefs.GetBool(null, true);
		SPrefs.GetBool(null);
		SPrefs.DeleteAll();
	}

	private void AddError(string msg)
	{
		Debug.Log(msg);
		errorCount++;
	}
}
