using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinCryptoPluginSample.Plugins.Crypto.Abstractions;

namespace XamarinCryptoPluginSample
{
	public partial class HomePage : ContentPage
	{
		public HomePage()
		{
			InitializeComponent();
		}

		private static readonly string privateKey = "[YOUR_CERTIFICATE_PRIVATE_KEY]";

		void SignPlainText(object sender, EventArgs e)
		{
			var cryptoManager = DependencyService.Get<ICryptoManager>();
			var signedData = cryptoManager.SignData(privateKey, PlainTextEntry.Text);
			SignedDataLabel.Text = signedData;
		}
	}
}
