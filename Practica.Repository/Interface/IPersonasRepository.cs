using Practica.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Repository.Interface
{
    public interface IPersonasRepository
    {
        IEnumerable<Personas> GetAllPersonas();
        Personas GetPersonasById(int id);
        void InsertPersonas(Personas personas);
        void UpdatePersonas(Personas personas);
        void DeletePersonas(int studentID);


    }
}
