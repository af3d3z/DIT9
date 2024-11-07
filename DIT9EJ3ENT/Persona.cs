using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIT9EJ3ENT
{
    public class Persona
    {
        #region atributos
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNac;
        #endregion

        #region propiedades
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNac; }
            set { _fechaNac = value; }
        }

        #endregion

        #region constructores
        public Persona() {
            this._nombre = "Manuel";
            this._apellidos = "Morilla";
            this._fechaNac = new DateTime(1992, 9, 3);
        }

        public Persona(string nombre) {
            this._nombre = nombre;
        }

        public Persona (string nombre, string apellidos, DateTime fechaNac)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._fechaNac = fechaNac;
        }

        #endregion
    }
}
