using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CovidColData.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidColData.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidDataController : ControllerBase
    {
        private readonly IQueryApiRepository _queryApiRepository;

        public CovidDataController(IQueryApiRepository queryApiRepository)
        {
            _queryApiRepository = queryApiRepository;
        }
        // GET: api/CovidData/GetAllCases
        [HttpGet]
        [Route("casos")]
        public IActionResult Get()
        {
            var allData = _queryApiRepository.GetCasos();
            return new OkObjectResult(allData);
        }

        // GET: api/CovidData/ciudad/chía
        [HttpGet]
        [Route("ciudad/{ciudad:minlength(3)}")]
        public IActionResult Get(string ciudad)
        {
            var dataByCity = _queryApiRepository.GetCasosPorCiudad(ciudad);
            return new OkObjectResult(dataByCity);
        }


    }
}
