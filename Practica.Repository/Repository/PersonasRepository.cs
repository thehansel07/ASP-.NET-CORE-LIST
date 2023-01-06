using Practica.Repository.Interface;
using Practica.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Repository.Repository
{
    public class PersonasRepository : IPersonasRepository
    {
        static List<Personas> personaList = new List<Personas>()
        {
            new Personas(){id=1,  Nombre = "Hansel", Apellido="Cabrera", Edad= 21 },
            new Personas(){id=2,  Nombre = "Esteban", Apellido="Dominguez", Edad= 27 },
            new Personas(){id=3,  Nombre = "Maria", Apellido="Zapete", Edad= 28 },
            new Personas(){id=4 , Nombre = "Miguel", Apellido="Hogando", Edad= 32 },

        };
        public void DeletePersonas(int studentID)
        {
            var personaIndex = personaList.FindIndex(x => x.id == studentID);

            try
            {
                if (studentID > 0)
                {
                    personaList.RemoveAt(personaIndex);

                }

            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido un error", ex);
            }

        }

        public IEnumerable<Personas> GetAllPersonas()
        {
            return personaList.ToList();
        }

        public Personas GetPersonasById(int id)
        {
            var persona = personaList.Where(x => x.id == id).Single();
            return persona;
        }

        public void InsertPersonas(Personas personas)
        {
            try
            {
                if (personas != null)
                {
                    int lastId = personaList.OrderByDescending(x => x.id).Select(x=> x.id).FirstOrDefault();
                    lastId += 1;

                    Personas model = new Personas
                    {
                        Nombre = personas.Nombre,
                        Apellido = personas.Apellido,
                        Edad = personas.Edad,
                        id = lastId
                    };
                    personaList.Add(model);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Ha ocurrido un error", ex);
            }

        }

        public void UpdatePersonas(Personas personas)
        {
            var itemIndex = personaList.FindIndex(x => x.id == personas.id);
            personaList.RemoveAt(itemIndex);


            try
            {
                if (personas != null)
                {
                    personaList.Add(personas);
                }


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
