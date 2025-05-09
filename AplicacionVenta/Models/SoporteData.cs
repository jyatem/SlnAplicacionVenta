using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionVenta.Models
{
    public class SoporteData : INotifyPropertyChanged
    {
        #region Propiedad definida de manera corta
        //public int VisitasPendientes { get; set; } 
        #endregion

        private int _visitasPendientes;

        public int VisitasPendientes
        {
            get { return _visitasPendientes; }
            set 
            {
                _visitasPendientes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("VisitasPendientes"));
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
