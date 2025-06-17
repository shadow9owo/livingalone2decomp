using System;
using UnityEngine;

public class SPrefs
{
	public const string STRING_SALT = "7Snc1Lso";

	public const string INT_SALT = "t5HqItbY";

	public const string FLOAT_SALT = "ZieZO5cM";

	public const string BOOL_SALT = "E9LvW12n";

	public static void SetString(string key, string value)
	{
		SecureSetString("7Snc1Lso" + key, value);
	}

	public static string GetString(string key)
	{
		return GetString(key, string.Empty);
	}

	public static string GetString(string key, string defaultValue)
	{
		if (!SecureHasKey("7Snc1Lso" + key))
		{
			return defaultValue;
		}
		try
		{
			return SecureGetString("7Snc1Lso" + key);
		}
		catch (Exception)
		{
			return defaultValue;
		}
	}

	public static void SetInt(string key, int value)
	{
		SecureSetString("t5HqItbY" + key, value.ToString());
	}

	public static int GetInt(string key)
	{
		return GetInt(key, 0);
	}

	public static int GetInt(string key, int defaultValue)
	{
		return GetIntCustomSalt("t5HqItbY", key, defaultValue);
	}

	private static int GetIntCustomSalt(string salt, string key, int defaultValue)
	{
		if (!SecureHasKey(salt + key))
		{
			return defaultValue;
		}
		string empty = string.Empty;
		try
		{
			empty = SecureGetString(salt + key);
			if (empty.Length < 1)
			{
				return defaultValue;
			}
			return int.Parse(empty);
		}
		catch (Exception)
		{
			return defaultValue;
		}
	}

	public static void SetFloat(string key, float value)
	{
		SecureSetString("ZieZO5cM" + key, value.ToString());
	}

	public static float GetFloat(string key)
	{
		return GetFloat(key, 0f);
	}

	public static float GetFloat(string key, float defaultValue)
	{
		if (!SecureHasKey("ZieZO5cM" + key))
		{
			return defaultValue;
		}
		string empty = string.Empty;
		try
		{
			empty = SecureGetString("ZieZO5cM" + key);
			if (empty.Length < 1)
			{
				return defaultValue;
			}
			return float.Parse(empty);
		}
		catch (Exception)
		{
			return defaultValue;
		}
	}

	public static bool GetBool(string key)
	{
		return GetBool(key, false);
	}

	public static bool GetBool(string key, bool defaultValue)
	{
		return Convert.ToBoolean(GetIntCustomSalt("E9LvW12n", key, Convert.ToInt32(defaultValue)));
	}

	public static void SetBool(string key, bool value)
	{
		SecureSetString("E9LvW12n" + key, Convert.ToInt32(value).ToString());
	}

	public static void DeleteAll()
	{
		PlayerPrefs.DeleteAll();
	}

	public static void DeleteKey(string key)
	{
		SecureDeleteKey("7Snc1Lso" + key);
		SecureDeleteKey("t5HqItbY" + key);
		SecureDeleteKey("ZieZO5cM" + key);
		SecureDeleteKey("E9LvW12n" + key);
	}

	public static void Save()
	{
		PlayerPrefs.Save();
	}

	public static bool HasKey(string key)
	{
		return SecureHasKey("7Snc1Lso" + key) || SecureHasKey("t5HqItbY" + key) || SecureHasKey("ZieZO5cM" + key) || SecureHasKey("E9LvW12n" + key);
	}

	private static void SecureSetString(string key, string value)
	{
		PlayerPrefs.SetString(Cryptor.Hash(key), Cryptor.Encrypt(value));
	}

	private static string SecureGetString(string key)
	{
		return Cryptor.Decrypt(PlayerPrefs.GetString(Cryptor.Hash(key)));
	}

	private static bool SecureHasKey(string key)
	{
		return PlayerPrefs.HasKey(Cryptor.Hash(key));
	}

	private static void SecureDeleteKey(string key)
	{
		PlayerPrefs.DeleteKey(Cryptor.Hash(key));
	}
}
