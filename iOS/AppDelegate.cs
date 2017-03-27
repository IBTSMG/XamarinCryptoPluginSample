using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinCryptoPluginSample.Plugins.Crypto.Abstractions;
using XamarinCryptoPluginSample.Plugins.Crypto.iOS;

namespace XamarinCryptoPluginSample.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			DependencyService.Register<ICryptoManager, CryptoManager>();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
