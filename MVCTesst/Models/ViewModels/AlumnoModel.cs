using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTesst.Models.ViewModels
{
    public class AlumnoModel
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }    
        public int idmateria { get; set; }   
    }
}