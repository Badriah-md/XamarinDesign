
using Xamarin.Forms;

namespace newProject
{
    public partial class GreetPage : ContentPage
    {
       
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            Padding = Device.OnPlatform(                  iOS: new Thickness(0, 20, 0, 0),                 Android: new Thickness(0),                 WinPhone: new Thickness(0));

        }

       


    }
}
