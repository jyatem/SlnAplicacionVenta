
using AplicacionVenta.DataAccess;

namespace AplicacionVenta.Views;

public partial class ProductoDetallePage : ContentPage, IQueryAttributable
{
	public ProductoDetallePage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var id = Convert.ToInt32(query["id"].ToString());

        var dbContext = new VentaDbContext();

        var producto = dbContext.Productos.First(producto => producto.Id == id);

        container.Children.Add(new Label { Text = producto.Nombre });
        container.Children.Add(new Label { Text = producto.Descripcion });
        container.Children.Add(new Label { Text = producto.Precio.ToString() });
    }
}