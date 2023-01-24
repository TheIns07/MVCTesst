using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using System.Xml.Linq;
using MVCTesst.DataAccessLayer;
using MVCTesst.Controllers;
using MVCTesst.Models;
using MVCTesst.Models.ViewModels;

namespace MVCTesst.Controllers
{
    public class HomeController : Controller
    {
        DataAccessLayer.testvcDataContext db = new testvcDataContext();

        public ActionResult Index()
        {
            List<AlumnoModel> list;
            using (db)
            {
                list = (from d in db.alumnos
                            select new AlumnoModel
                            {
                                id = d.id,
                                nombre = d.nombre,
                                apellido = d.apellido,
                                idmateria = d.idmateria
                            }).ToList();
            }
                return View(list);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string sendStudents(string nombre, string apellido, int materia)
        {
            DataAccessLayer.alumno tabla = new DataAccessLayer.alumno();
            tabla.nombre = nombre;
            tabla.apellido = apellido;
            tabla.idmateria = materia;

            db.alumnos.InsertOnSubmit(tabla);
            db.SubmitChanges();
            return apellido;
        }

        public string sendAsignsments(string nombre, string departamento)
        {
            DataAccessLayer.materia tabla = new DataAccessLayer.materia();
            tabla.nombre = nombre;
            tabla.departamento = departamento;

            db.materias.InsertOnSubmit(tabla);
            db.SubmitChanges();
            return departamento;
        }
        public string updateStudents(string name, string lastName, int materia)
        {
            DataAccessLayer.alumno tabla = new DataAccessLayer.alumno();
            tabla.nombre = name;
            tabla.apellido = lastName;
            tabla.idmateria = materia;

            db.alumnos.InsertOnSubmit(tabla);
            db.SubmitChanges();
            return name;
        }

        public string updateAsignsments(string name, string department)
        {
            DataAccessLayer.materia tabla = new DataAccessLayer.materia();
            tabla.nombre = name;
            tabla.departamento = department;

            db.materias.InsertOnSubmit(tabla);
            db.SubmitChanges();
            return name;
        }

        public string deleteStudent(string nombre, string apellido)
        {
            DataAccessLayer.alumno tabla = new DataAccessLayer.alumno();
            tabla.nombre = nombre;
            tabla.apellido = apellido;

            db.alumnos.DeleteOnSubmit(tabla);
            db.SubmitChanges();
            return nombre;
        }

        public string deleteAsignsment(string name, string department)
        {
            DataAccessLayer.materia tabla = new DataAccessLayer.materia();
            tabla.nombre = name;
            tabla.departamento = department;
            db.materias.DeleteOnSubmit(tabla);
            db.SubmitChanges();
            return name;
        }




    }
}