using DIT9EJ3ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIT9EJ3.ViewModels
{
    public class PersonaVM : INotifyPropertyChanged
    {
        //private Persona _persona;
        private string _nombre;

        public string Nombre {
            get { return _nombre; }
            set { 
                _nombre = value;
                INotifyPropertyChanged("Persona");
            }
        }

        public Persona Persona {
            get { return new Persona(_nombre); }
        }

        #region Notify
        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        #endregion
    }
}
