namespace ReservasDeCitas.Paginas;


public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void ReservarCita_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ReservarCitaspage());
    }

    private async void ConsultarCita_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConsultarCitaPage());
    }

    private async void CerrarSesion_Clicked(object sender, EventArgs e) => await Navigation.PopToRootAsync();
}
    
       
    
