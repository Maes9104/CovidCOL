using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.Models
{
    public class Ciudad
    {
        public int Id { get; set; }
        public string NombreCiudad { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
