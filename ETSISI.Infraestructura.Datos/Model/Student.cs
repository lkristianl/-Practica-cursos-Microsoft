using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model
{
    class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
