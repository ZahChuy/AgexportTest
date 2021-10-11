using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiAgexport.Data;
using WebApiAgexport.Models;

namespace WebApiAgexport.Controllers
{
    public class EmpleadoController : ApiController
    {

        public List<Empleado> Get()
        {

            return EmpleadoData.Lista();
        }

        // GET api/<controller>/5
        public Empleado Get(int id)
        {
            return EmpleadoData.obtener(id);
        }

        // POST api/<controller>
        public bool Post([FromBody]Empleado oEmpleado)
        {
            return EmpleadoData.Grabar(oEmpleado);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody]Empleado oEmpleado)
        {
            return EmpleadoData.Modificar(oEmpleado);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return EmpleadoData.Eliminar(id);
        }
    }
}