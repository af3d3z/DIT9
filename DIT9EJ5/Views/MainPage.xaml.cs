using DIT9EJ5.Models.ENT;

namespace DIT9EJ5.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Pulsacion(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null) { 
                Persona personaSeleccionada = e.Item as Persona;
                await Navigation.PushAsync(new DetallesPersona(personaSeleccionada));
            }
        }
    }

}
