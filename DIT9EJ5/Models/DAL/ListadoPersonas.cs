using DIT9EJ5.Models.ENT;
using System.Collections.ObjectModel;


namespace DIT9EJ5.Models.DAL
{
    public class ListadoPersonas
    {

        /// <summary>
        /// Devuelve una colección de personas (Lista)
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<Persona> GetPersonas()
        {
            ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
            personas.Add(new Persona("Manuel", "Morilla Moreno", new DateTime(1996, 6, 1), "https://thispersondoesnotexist.com", "Calle Mª del Carmen 32", "655485489"));
            personas.Add(new Persona("Laura", "García Pérez", new DateTime(1988, 3, 15), "https://thispersondoesnotexist.com", "Avenida de la Constitución 15", "629874561"));
            personas.Add(new Persona("Juan", "López Sánchez", new DateTime(1990, 11, 7), "https://thispersondoesnotexist.com", "Calle Real 22", "633192874"));
            personas.Add(new Persona("Ana", "Rodríguez Díaz", new DateTime(1985, 5, 20), "https://thispersondoesnotexist.com", "Calle de la Luna 45", "692873456"));
            personas.Add(new Persona("Carlos", "Martínez Gómez", new DateTime(1992, 2, 2), "https://thispersondoesnotexist.com", "Paseo de la Castellana 18", "690183456"));
            personas.Add(new Persona("Beatriz", "Fernández Ruiz", new DateTime(1980, 10, 30), "https://thispersondoesnotexist.com", "Calle del Sol 78", "624501932"));
            personas.Add(new Persona("José", "González Hernández", new DateTime(1995, 7, 25), "https://thispersondoesnotexist.com", "Calle de la Princesa 33", "645738920"));
            personas.Add(new Persona("María", "Pérez Jiménez", new DateTime(1989, 4, 12), "https://thispersondoesnotexist.com", "Calle Mayor 12", "658923748"));
            personas.Add(new Persona("Fernando", "Sánchez Romero", new DateTime(1993, 8, 19), "https://thispersondoesnotexist.com", "Calle de la Paz 56", "671203984"));
            

            return personas;
        }
    }
}
