using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PersonasController : ApiController
    {
        //Va a regresar un JSON
        [HttpPost]
        public IHttpActionResult Add(Models.ViewModel.PersonaRequest model)
        {
            //Ejemplo para prueba
            using (Models.ApiEntities db = new Models.ApiEntities())
            {
                var oPersona = new Models.persona();
                oPersona.nombre = model.Nombre;
                oPersona.edad = model.Edad;
                db.persona.Add(oPersona);
                db.SaveChanges();
            }

            return Ok("Exito");

        }



    }
}
