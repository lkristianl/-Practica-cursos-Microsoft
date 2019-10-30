using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model
{
    class CourseAssigment
    {

        public int CourseID { get; set; }
        public int ProfessorID { get; set; }

        public Course Course { get; set; }
        public Professor Professor { get; set; }

    }
}
