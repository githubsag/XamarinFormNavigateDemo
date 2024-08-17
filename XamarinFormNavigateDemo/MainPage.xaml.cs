using Xamarin.Forms;

namespace XamarinFormNavigateDemo
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void NavigateButton_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new Page1());
        }

        void Button_onClicked(System.Object sender, System.EventArgs e)
        {
            string text = MainEntry.Text;
            MainLabel.Text = "Hello " + text;
        }
    }
}
