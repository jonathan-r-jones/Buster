using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace Buster.Views {
    public partial class Page1 : ContentPage {
        public Page1() {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tinyurl.com/Buster-Android")));
                    break;
                case Device.iOS:
                    OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://tinyurl.com/Buster-iOS")));
                    break;
            }

        }
        public ICommand OpenWebCommand { get; }
    }
}
