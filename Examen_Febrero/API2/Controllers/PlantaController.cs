using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.ObjectModel;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        // GET: api/<PlantaController>
        [HttpGet]
        public ObjectResult Get()
        {
            ObservableCollection<clsPlanta> plantas = null;
            ObjectResult result = new ObjectResult(new { Value = plantas });

            try
            {
                result.Value = DAL.Listados.clsListadoPlantaDAL.generarListadoPlantasDAL();
                result.StatusCode = (int)HttpStatusCode.NotFound;
                if ((result.Value as ObservableCollection<clsPlanta>) == null || (result.Value as ObservableCollection<clsPlanta>).Count == 0)
                {
                    result.StatusCode = (int)HttpStatusCode.NotFound;
                }
            }
            catch (Exception)
            {
                result.StatusCode = (int)HttpStatusCode.InternalServerError;
            }
            return result;
        }

        // GET api/<PlantaController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlantaController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlantaController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlantaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
