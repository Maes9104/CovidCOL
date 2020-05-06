using CovidColData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidColData.Repository
{
    public interface IQueryApiRepository
    {
        IEnumerable<Caso> GetCasos();
        IEnumerable<Caso> GetCasosPorFecha(DateTime fechaInicio, DateTime fechaFin);
        IEnumerable<Caso> GetCasosPorCiudad(string ciudad);
    }
}
