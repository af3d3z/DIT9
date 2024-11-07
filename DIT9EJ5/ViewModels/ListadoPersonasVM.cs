using DIT9EJ5.Models.ENT;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIT9EJ5.ViewModels
{
    public class ListadoPersonasVM
    {
        private ObservableCollection<Persona> _personas;

        public ObservableCollection<Persona> Personas { get { return _personas; } }

        public ListadoPersonasVM() {
            _personas = Models.DAL.ListadoPersonas.GetPersonas();
        }
    }
}
