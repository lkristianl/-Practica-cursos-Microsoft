using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model

{
    public class Professor : Person
    {

        public ICollection<CourseAssigment> CourseAssigments { get; set; }

        public ICollection<TeachesAssigment> TeachesAssigments { get; set; }

    }
}