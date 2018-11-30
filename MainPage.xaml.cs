using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Arvestustöö_Lauri_Joosing
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int counter = 1;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kasutaja = "user";
            string pass = "SecretPassword";

            if (counter <= 3)
            {   
                    if (user.Text == kasutaja && pw.Password == pass)
                    {
                         this.Frame{};

                    else
                	{
                        result.Text = "Logimine ebaõnnestus.";
                        counter++;
                    }
                     }

                else
                {
                    result.Text = "Sisselogimine ebaõnnestud, rohkem katseid ei ole.";
                    login.IsEnabled = false;
                }

            }
          
        }
    }
}

