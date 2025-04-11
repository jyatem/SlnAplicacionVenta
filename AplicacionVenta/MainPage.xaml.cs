using AplicacionVenta.DataAccess;
using Microsoft.Maui.Controls.Shapes;

namespace AplicacionVenta
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            #region Información DbContext
            var dbContext = new VentaDbContext();

            //lblCategorias.Text = String.Format("Categorias: {0}", dbContext.Categorias.Count());
            //lblProductos.Text = String.Format("Productos: {0}", dbContext.Productos.Count());
            //lblClientes.Text = String.Format("Clientes: {0}", dbContext.Clientes.Count());

            lblCategorias.Text = dbContext.Categorias.Count().ToString();
            lblProductos.Text = dbContext.Productos.Count().ToString();
            lblClientes.Text = dbContext.Clientes.Count().ToString();
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            //await DisplayAlert("Mensaje en MAUI", "Aplicación MAUI", "Ok", "Cancelar");

            (sender as Rectangle)?.ScaleTo(2);
            (sender as Rectangle)?.TranslateTo(200,200);

            //var displayInfo = DeviceDisplay.MainDisplayInfo;

            //double ancho = displayInfo.Width;
            //double alto = displayInfo.Height;
        }
    }

}
