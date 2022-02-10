using Laboratorio_1.Helpers;
using Laboratorio_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Controllers
{
    public class ClientesController : Controller
    {
        // GET: ClientesController
        public ActionResult Index()
        {
            return View(ClientesHelper.Instancia.Lista);
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            var model = ClientesHelper.Instancia.Lista.Find(model => model.Telefono == id);
            return View(model);
        }

        public ActionResult NombreAscendente()
        {
            ClientesModel.NombreAscendente();
            return View(ClientesHelper.Instancia.Lista);
        }

        public ActionResult ApellidoAscendente()
        {
            ClientesModel.ApellidoAscendente();
            return View(ClientesHelper.Instancia.Lista);
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View(new ClientesModel());
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                ClientesModel.Guardar(new ClientesModel
                {
                    Nombre = collection["Nombre"],
                    Apellido = collection["Apellido"],
                    Telefono = int.Parse(collection["Telefono"]),
                    Descripcion = collection["Descripcion"]
                }
                    );
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
