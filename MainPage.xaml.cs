using System;

namespace jculcayT1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    private void btnCalcula_Clicked(object sender, EventArgs e)
    {
		string nombre=txtNombre.Text;
		string apellido= txtApellido.Text;
		int edad = Convert.ToInt32( txtEdad.Text);
		double salario = Convert.ToDouble( txtSalario.Text);
		double calcular_aporte= salario * 0.0945;


		DisplayAlert("Datos de la Persona", "Bienvenido " + nombre + " " + apellido+"\nTienes "+edad+" años\nTu aporte mensual al IESS es de: "+calcular_aporte.ToString("0.00"), "Cerrar");


    }
}

