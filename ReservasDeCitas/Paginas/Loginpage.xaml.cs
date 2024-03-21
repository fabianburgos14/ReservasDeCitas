namespace ReservasDeCitas.Paginas;


public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void IniciarSesion_Clicked(object sender, EventArgs e)
    {

        await Navigation.PushAsync(new MainPage());

    }





}

