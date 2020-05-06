using CovidColData.Models;
using SODA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CovidColData.Repository
{
    public class QueryApiRepository : IQueryApiRepository
    {
        private readonly SodaClient _client = new SodaClient("https://www.datos.gov.co", "3Cha2GBC096gJQQ3luTLwoRqe");

        public IEnumerable<Caso> GetCasos()
        {
            var dataset = _client.GetResource<Caso>("gt2j-8ykr");
            var rows = dataset.GetRows();
            return rows;
        }

        public IEnumerable<Caso> GetCasosPorCiudad(string ciudad)
        {
            var dataset = _client.GetResource<Caso>("gt2j-8ykr");
            var rows = dataset.GetRows()
                                .Where(d => d.Ciudad_de_ubicaci_n.ToUpper() == ciudad.ToUpper()).ToList();
            return rows;
        }

        public IEnumerable<Caso> GetCasosPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            throw new NotImplementedException();
        }
    }
}
