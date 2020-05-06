using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.Models
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Abreviacion { get; set; }
    }
}
