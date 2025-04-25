using AplicacionVenta.DataAccess;

namespace AplicacionVenta.Views;

public partial class ClientesPage : ContentPage
{
	public ClientesPage()
	{
		InitializeComponent();

        var dbContext = new VentaDbContext();

        foreach (var cliente in dbContext.Clientes)
        {
            container.Children.Add(new Label { Text = cliente.Nombre });
        }
    }
}