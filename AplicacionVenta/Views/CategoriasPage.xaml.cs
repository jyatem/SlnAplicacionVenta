using AplicacionVenta.DataAccess;

namespace AplicacionVenta.Views;

public partial class CategoriasPage : ContentPage
{
	public CategoriasPage()
	{
		InitializeComponent();

        var dbContext = new VentaDbContext();

        foreach (var categoria in dbContext.Categorias)
        {
            container.Children.Add(new Label { Text = categoria.Nombre });
        }
    }
}