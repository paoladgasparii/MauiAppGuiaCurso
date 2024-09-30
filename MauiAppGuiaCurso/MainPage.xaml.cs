using MauiAppGuiaCurso.Módulos;

namespace MauiAppGuiaCurso
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnPrimeiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Primeiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        private void BtnSegundo_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Segundo());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
        private void BtnTerceiro_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Terceiro());

            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}