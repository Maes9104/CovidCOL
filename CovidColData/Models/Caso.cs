using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidColData.Models
{
    public class Caso
    {
        public string Id_de_caso { get; set; }
        public string Fecha_de_notificaci_n { get; set; }
        public string Ciudad_de_ubicaci_n { get; set; }
        public string Departamento { get; set; }
        public string Atenci_n { get; set; }
        public int Edad { get; set; }
        public string Sexo { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }
        public string Pa_s_de_procedencia { get; set; }
        //Fecha de inicio de sintomas
        public string Fis { get; set; }
        public string Fecha_de_muerte { get; set; }
        public string Fecha_diagnostico { get; set; }
        public string Fecha_recuperado { get; set; }

    }
}
