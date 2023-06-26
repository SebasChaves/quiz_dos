using FrontEnd.Helpers;
using FrontEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FrontEnd.Controllers
{
    public class EmpleadoController : Controller
    {
        EmpleadoHelper empleadoHelper = new EmpleadoHelper();


        // GET: EmpleadoController
        public ActionResult Index()
        {
            List<EmpleadoViewModel> lista = empleadoHelper.GetAll();
            return View(lista); ;
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {
            EmpleadoViewModel factura = empleadoHelper.Get(id);

            return View(factura);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmpleadoViewModel empleado)
        {
            try
            {
                empleado = empleadoHelper.Create(empleado);
                return RedirectToAction("Details", new { id = empleado.EmpleadoId });
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            EmpleadoViewModel factura = empleadoHelper.Get(id);

            return View(factura);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EmpleadoViewModel factura)
        {
            try
            {
                factura = empleadoHelper.Edit(factura);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            EmpleadoViewModel factura = empleadoHelper.Get(id);

            return View(factura);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(EmpleadoViewModel factura)
        {
            try
            {
                empleadoHelper.Delete(factura.EmpleadoId);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();

            }
        }
    }
}
