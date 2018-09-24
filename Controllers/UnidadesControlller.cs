using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using WeatherDashboardApi.Models;


namespace WeatherDashboardApi.Controllers
{
    [Route("api/unidades")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {
        List<Unidades> unidades = new List<Unidades>();
        private List<Unidades> datosUnidades() 
        {
            unidades.Add(new Unidades { id = "M", nombre = "Celcius" });
            unidades.Add(new Unidades { id = "I", nombre = "Fahrenheit" });
            return unidades;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Unidades>> Get()
        {
            return datosUnidades();
        }
    }
}
