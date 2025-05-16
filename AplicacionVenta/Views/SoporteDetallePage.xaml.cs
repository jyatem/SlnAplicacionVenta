
namespace AplicacionVenta.Views;

public partial class SoporteDetallePage : ContentPage, IQueryAttributable
{
	public SoporteDetallePage()
	{
		InitializeComponent();
	}

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        Title = $"Cliente: {query["id"]}";
    }
}