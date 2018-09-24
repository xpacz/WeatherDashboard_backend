using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using WeatherDashboardApi.Models;

namespace WeatherDashboardApi.Controllers
{
    [Route("api/ciudades")]
    [EnableCors("CorsPolicy")]
    [ApiController]
    public class CiudadesController : ControllerBase
    {
        List<Ciudades> ciudades = new List<Ciudades>();
        private List<Ciudades> datosCiudades() 
        {
            ciudades.Add(new Ciudades { id = 1, nombre = "Cd. Obregon", lon = -109.94083, lat = 27.48642 });
            ciudades.Add(new Ciudades { id = 2, nombre = "Navojoa", lon = -109.44372, lat = 27.07028 });
            ciudades.Add(new Ciudades { id = 3, nombre = "Hermosillo", lon = -110.97732, lat = 29.1026 });
            ciudades.Add(new Ciudades { id = 4, nombre = "Guaymas", lon = -110.89755, lat = 27.91928 });
            ciudades.Add(new Ciudades { id = 5, nombre = "Nogales", lon = -97.16311, lat = 18.82776 });
            return ciudades;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Ciudades>> Get()
        {
            return datosCiudades();
        }
        // GET api/ciudades/5
        [HttpGet("{id}")]
        public ActionResult<Ciudades> Get(int id)
        {
            List<Ciudades> c = datosCiudades();
            List<Ciudades> d = c.Where(q => q.id == id).ToList();
            return Ok(d);
        }
    }
}
