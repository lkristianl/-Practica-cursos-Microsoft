using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model
{
    public class Enrollment
    {
        public int CourseID { get; set; }
        public int StudentID { get; set; }

        public Grade? Grade { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }



    }

    public enum Grade
    {
        A, B, C, D, F
    }
}
