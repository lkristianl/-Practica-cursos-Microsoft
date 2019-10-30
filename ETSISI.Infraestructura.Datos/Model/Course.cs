using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model
{
    class Course : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public ICollection<CourseAssigment> CourseAssigments { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
