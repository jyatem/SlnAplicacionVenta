using AplicacionVenta.DataAccess;

namespace AplicacionVenta.Views;

public partial class ProductosPage : ContentPage
{
	public ProductosPage()
	{
		InitializeComponent();

		var dbContext = new VentaDbContext();

		foreach (var producto in dbContext.Productos)
		{
			//container.Children.Add(new Label { Text = producto.Nombre });

			var boton = new Button { Text = producto.Nombre };

			boton.Clicked += async (s, e) =>
			{
				var uri = $"{nameof(ProductoDetallePage)}?id={producto.Id}";
				await Shell.Current.GoToAsync(uri);
			};

			container.Children.Add(boton);
		}
	}
}