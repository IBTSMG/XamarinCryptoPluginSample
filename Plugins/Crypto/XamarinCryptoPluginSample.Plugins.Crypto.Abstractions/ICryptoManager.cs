using System;
namespace XamarinCryptoPluginSample.Plugins.Crypto.Abstractions
{
	public interface ICryptoManager
	{
		string SignData(string privateKey, string data);
	}
}
