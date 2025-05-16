using AplicacionVenta.DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVenta.Models
{
    public class SoporteDataDetalle : BindingUtilObjectcs
    {
        public SoporteDataDetalle()
        {
            var ventaDbContext = new VentaDbContext();
            Productos = new ObservableCollection<Producto>(ventaDbContext.Productos);
        }

        private ObservableCollection<Producto> _productos;

        public ObservableCollection<Producto> Productos
        {
            get { return _productos; }
            set
            {
                if (_productos != value)
                {
                    _productos = value;
                    RaisePropertyChanged();
                }
            }
        }

        private Producto _productoSeleccionado;

        public Producto ProductoSeleccionado
        {
            get { return _productoSeleccionado; }
            set
            {
                if (_productoSeleccionado != value)
                {
                    _productoSeleccionado = value;
                    RaisePropertyChanged();
                }
            }
        }

        private int _cantidad;

        public int Cantidad
        {
            get { return _cantidad; }
            set
            {
                if (_cantidad != value)
                {
                    _cantidad = value;
                    RaisePropertyChanged();
                }
            }
        }

    }
}
