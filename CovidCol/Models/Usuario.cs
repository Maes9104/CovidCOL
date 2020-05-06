using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidCol.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int TipoDocumentoId { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public long NumeroDocumento { get; set; }
        public bool EnEstudio { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public int CiudadId { get; set; }
        public Ciudad Ciudad { get; set; }
    }
}
