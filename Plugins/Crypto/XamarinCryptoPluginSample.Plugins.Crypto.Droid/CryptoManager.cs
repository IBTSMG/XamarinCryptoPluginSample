using System;
using System.Security.Cryptography;
using System.Text;
using XamarinCryptoPluginSample.Plugins.Crypto.Abstractions;

namespace XamarinCryptoPluginSample.Plugins.Crypto.Droid
{
	public class CryptoManager : ICryptoManager
	{
		public string SignData(string privateKey, string data)
		{
			string signedData = null;
			try
			{
				using (var rp = new RSACryptoServiceProvider())
				{
					var xmlString = Encoding.UTF8.GetString(Convert.FromBase64String(privateKey));
					rp.FromXmlString(xmlString);

					var encoding = new ASCIIEncoding();
					byte[] orginalData = encoding.GetBytes(data);


					var signedBinaryData = rp.SignData(orginalData, new SHA1CryptoServiceProvider());
					signedData = Convert.ToBase64String(signedBinaryData);
				}
			}
			catch (Exception exception)
			{
				// some error logging code here...
				throw;
			}

			return signedData;
		}
	}
}
