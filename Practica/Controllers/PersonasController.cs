using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica.Repository.Interface;
using Practica.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica.Controllers
{
    public class PersonasController : Controller
    {
        public readonly IPersonasRepository _personasRepository;
        public PersonasController(IPersonasRepository personasRepository)
        {
            _personasRepository = personasRepository;


        }

        public ActionResult Index()
        {
            var listAll = _personasRepository.GetAllPersonas();
            ViewBag.ListAll = listAll;

            return View();
        }

        // GET: PersonasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personas personas)
        {
            try
            {
                if (personas != null)
                {
                    _personasRepository.InsertPersonas(personas);

                }
            }
            catch
            {
                return View();
            }
            return RedirectToAction("index");
        }

        // GET: PersonasController/Edit/5
        public ActionResult Edit(int id)
        {
            var obtenerPersona = _personasRepository.GetPersonasById(id);
            Personas personas = new Personas
            {
                Nombre = obtenerPersona.Nombre,
                Apellido = obtenerPersona.Apellido,
                Edad = obtenerPersona.Edad,
                id= obtenerPersona.id


            };
            return View(personas);
        }

        // POST: PersonasController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Personas persona)
        {
            try
            {
                _personasRepository.UpdatePersonas(persona);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: PersonasController/Delete/5
        public ActionResult Delete(int id)
        {
            _personasRepository.DeletePersonas(id);
            return RedirectToAction("Index");
        }

        // POST: PersonasController/Delete/5

    }
}
