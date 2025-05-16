using AplicacionVenta.DataAccess;
using AplicacionVenta.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVenta.Models
{
    public class SoporteData : BindingUtilObjectcs
    {
        public SoporteData()
        {
            var ventaDbContext = new VentaDbContext();
            Clientes = new ObservableCollection<Cliente>(ventaDbContext.Clientes);
            PropertyChanged += SoporteData_PropertyChanged;
        }

        private async void SoporteData_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(ClienteSeleccionado))
            {
                var uri = $"{nameof(SoporteDetallePage)}?id={ClienteSeleccionado.Id}";
                await Shell.Current.GoToAsync(uri);
            }
        }

        #region Propiedad definida de manera corta
        //public int VisitasPendientes { get; set; } 
        #endregion

        private int _visitasPendientes;

        public int VisitasPendientes
        {
            get { return _visitasPendientes; }
            set
            {
                if (_visitasPendientes != value)
                {
                    _visitasPendientes = value;
                    RaisePropertyChanged();
                }
            }
        }

        private ObservableCollection<Cliente> _clientes;

        public ObservableCollection<Cliente> Clientes
        {
            get { return _clientes; }
            set
            {
                if (_clientes != value)
                { 
                    _clientes = value;
                    RaisePropertyChanged();
                }
            }
        }

        private Cliente _clienteSeleccionado;

        public Cliente ClienteSeleccionado
        {
            get { return _clienteSeleccionado; }
            set 
            { 
                if (_clienteSeleccionado != value)
                { 
                    _clienteSeleccionado = value;
                    RaisePropertyChanged();
                }
            }
        }


    }
}
