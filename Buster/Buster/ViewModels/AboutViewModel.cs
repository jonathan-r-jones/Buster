using Microsoft.AppCenter.Analytics;
using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Buster.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Analytics.TrackEvent("Entering method: " + System.Reflection.MethodBase.GetCurrentMethod().Name.ToString());
            Title = "About";
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tinyurl.com/buster-android")));
                    break;
                case Device.iOS:
                    OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tinyurl.com/buster-ios")));
                    break;
            }
        }
        public ICommand OpenWebCommand { get; }
        public ICommand OpenWebCommandJMD { get; }
    }
}