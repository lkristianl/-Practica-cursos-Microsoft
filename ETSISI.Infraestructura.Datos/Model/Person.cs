using System;
using System.Collections.Generic;
using System.Text;

namespace ETSISI.Infraestructura.Datos.Model
{
    public abstract class Person : IEntity
    {
        public int Id { get; set; }



        [Required]
        [String length(50)]
        public string LastName { get; set; }

        public string FirstName { get; set; }

    }
}
