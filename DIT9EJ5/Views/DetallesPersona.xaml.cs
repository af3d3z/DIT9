using DIT9EJ5.Models.ENT;

namespace DIT9EJ5.Views;

public partial class DetallesPersona : ContentPage
{
	public DetallesPersona(Persona personaSeleccionada)
	{
		InitializeComponent();
		BindingContext = personaSeleccionada;
	}
}