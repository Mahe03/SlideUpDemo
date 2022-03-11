using Xamarin.Forms;

namespace SlidingDemo
{
    public partial class MainPage : ContentPage
    {
        private bool slideUp;
        private double initialBodyPosition;
        async void Handele_Tapped(object sender, System.EventArgs e)
        {
            if(slideUp)
            {
                await body.TranslateTo(0, initialBodyPosition, 500, Easing.SinIn);

                slideUp = false;
            }
            else
            {
                var initialPosition = TopLayout.Height;
                var currentPosition = body.Height;

                await body.TranslateTo(0, (initialPosition - currentPosition) * -1, 500, Easing.SinIn);

                slideUp = true;
            }
            
        }
        public MainPage()
        {
            InitializeComponent();

            initialBodyPosition = TopLayout.Height + 700;
            body.TranslationY = initialBodyPosition; //App.Current.MainPage.Height - 100;
        }
    }
}
