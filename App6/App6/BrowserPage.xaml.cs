using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BrowserPage : ContentPage
    {
        public BrowserPage()
        {
            InitializeComponent();

            StringBuilder text = new StringBuilder();
            for (int i = 0; i < 100000; ++i)
            {
                text.Append("hello ");
            }

            WebView1.Source = new HtmlWebViewSource() { Html = text.ToString() };
        }
    }
}