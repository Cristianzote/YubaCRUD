using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YubaCRUD.Models;

namespace YubaCRUD.Controllers
{
    public class EstudianteController : Controller
    {
        private readonly EstudianteDBContext db = new EstudianteDBContext();

        //Mostrar vista principal
        public ActionResult Index()
        {
            return View();
        }

        //Traer todos los empleados de la base de datos en un array
        public JsonResult GetEstudiantes()
        {
            List<Estudiante> estudiantes = db.Estudiantes.ToList();
            return Json(estudiantes, JsonRequestBehavior.AllowGet);
        }
        //Guardar un empleado nuevo
        [HttpPost]
        public JsonResult AddEstudiante(Estudiante estudiante)
        {
            db.Estudiantes.Add(estudiante);
            db.SaveChanges();
            return Json(estudiante);
        }

        //Actualizar un empleado
        [HttpPost]
        public JsonResult UpdateEstudiante(Estudiante estudiante)
        {
            db.Entry(estudiante).State = EntityState.Modified;
            db.SaveChanges();
            return Json(estudiante);
        }
        //Eliminar un empleado
        [HttpPost]
        public JsonResult DeleteEstudiante(int id)
        {
            var estudiante = db.Estudiantes.Find(id);
            if (estudiante != null)
            {
                db.Estudiantes.Remove(estudiante);
                db.SaveChanges();
            }
            return Json(estudiante);
        }
    }
}