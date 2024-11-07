using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIT9EJ5.Models.ENT
{
    public class Persona
    {
        #region atributos
        private string _nombre;
        private string _apellidos;
        private DateTime _fechaNac;
        private string _imgURL;
        private string _direccion;
        private string _telefono;
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

        public string ImgURL { 
            get { return _imgURL; }
            set { _imgURL = value; }
        }

        public string Direccion { 
            get { return _direccion; }
            set { _direccion = value; } 
        }

        public String Telefono { 
            get { return _telefono; }
            set { _telefono = value; }
        }

        public String NombreCompleto {
            get { return $"{_nombre} {_apellidos}";  }
        }

        #endregion

        #region constructores
        public Persona (string nombre, string apellidos, DateTime fechaNac)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._fechaNac = fechaNac;
        }

        public Persona(string nombre, string apellidos, DateTime fechaNac, string imgURL, string direccion, string tlf)
        {
            this._nombre = nombre;
            this._apellidos = apellidos;
            this._fechaNac = fechaNac;
            this._imgURL = imgURL;
            this._direccion = direccion;
            this._telefono = tlf;
        }

        #endregion
    }
}
