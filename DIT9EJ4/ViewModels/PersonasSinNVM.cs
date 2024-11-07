using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DIT9EJ4.ViewModels
{
    public class PersonasSinNVM: INotifyPropertyChanged
    {
        private string _nombre;
        private string _apellido;

        public string Nombre {
            set {
                if (value.Contains('n') || value.Contains('N')) {
                    _apellido = "";
                }
                _nombre = value;
                INotifyPropertyChanged("Apellido");
            }
            get {
                return _nombre;
            }
        }

        public string Apellido { 
            set
            {
                if (value.Contains('n') || value.Contains('N'))
                {
                    _nombre = "";
                }
                _apellido = value;
                INotifyPropertyChanged("Nombre");
            }
            get {
                return _apellido;
            }
        }

        private void INotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
