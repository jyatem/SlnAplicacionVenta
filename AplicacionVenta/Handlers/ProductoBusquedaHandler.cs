using AplicacionVenta.DataAccess;
using AplicacionVenta.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVenta.Handlers
{
    internal class ProductoBusquedaHandler : SearchHandler
    {
        private readonly VentaDbContext _ventaDbContext;

        public ProductoBusquedaHandler()
        {
            _ventaDbContext = new VentaDbContext();
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
                return;
            }

            var resultados = _ventaDbContext.Productos.Where(p => p.Nombre.ToLowerInvariant().Contains(newValue.ToLowerInvariant())).ToList();

            ItemsSource = resultados;
        }

        protected async override void OnItemSelected(object item)
        {
            await Shell.Current.GoToAsync($"{nameof(ProductoDetallePage)}?id={((Producto)item).Id}");
        }
    }
}
