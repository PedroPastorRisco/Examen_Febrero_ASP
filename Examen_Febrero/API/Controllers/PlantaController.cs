using BL.Listados;
using Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        // GET: api/<PlantaController>
        [HttpGet]
        public ObservableCollection<clsPlanta> Get()
        {
            ObservableCollection<clsPlanta> plantas = null;
            try
            {
                plantas = clsListadoPlantaBL.generarListadoPlantasBL();
            }
            catch (Exception)
            {
                throw;
            }
            return plantas;
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
