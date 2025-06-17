using System;
using System.Security.Cryptography;
using System.Text;

public class Cryptor
{
	private const string ENCRYPTION_KEY = "471f58d72fd273ds47c49f9e481cabe3";

	public static string Hash(string value)
	{
		return GetSha1Hash(value);
	}

	public static string Encrypt(string value)
	{
		if (value == null || value.Length < 1)
		{
			return string.Empty;
		}
		return GetEncryptedString(value);
	}

	public static string Decrypt(string value)
	{
		if (value == null || value.Length < 1)
		{
			return string.Empty;
		}
		return GetDecryptedString(value);
	}

	private static string GetSha1Hash(string strToEncrypt)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		byte[] bytes = uTF8Encoding.GetBytes(strToEncrypt);
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(bytes);
		string text = string.Empty;
		for (int i = 0; i < array.Length; i++)
		{
			text += Convert.ToString(array[i], 16).PadLeft(2, '0');
		}
		return text.PadLeft(32, '0');
	}

	private static string GetEncryptedString(string toEncrypt)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("471f58d72fd273ds47c49f9e481cabe3");
		byte[] bytes2 = Encoding.UTF8.GetBytes(toEncrypt);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = bytes;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
		byte[] array = cryptoTransform.TransformFinalBlock(bytes2, 0, bytes2.Length);
		return Convert.ToBase64String(array, 0, array.Length);
	}

	private static string GetDecryptedString(string toDecrypt)
	{
		byte[] bytes = Encoding.UTF8.GetBytes("471f58d72fd273ds47c49f9e481cabe3");
		byte[] array = Convert.FromBase64String(toDecrypt);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = bytes;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] bytes2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes2);
	}
}
