using AplicacionVenta.Models;

namespace AplicacionVenta.Views;

public partial class SoportePage : ContentPage
{
	public SoportePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		var dataObject = Resources["data"] as SoporteData;
		dataObject.VisitasPendientes = 15;
    }
}