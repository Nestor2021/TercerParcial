using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TercerParcialAPI.Controllers
{
    public class AvionController : ApiController
    {

        [System.Web.Http.HttpPost]
        public IHttpActionResult Add(Models.Request.AvionRequest model)
        {
            using (Models.AeropuertoEntities db = new Models.AeropuertoEntities())

            {
                var oAvion = new Models.avion();
                oAvion.NombreAvion = model.NombreAvion;
                oAvion.marca = model.marca;
                oAvion.capacidad = model.capacidad;
                oAvion.descripcion = model.descripcion;            
                db.avion.Add(oAvion);
                db.SaveChanges();

            }
            return Ok("Hecho");
        }

    }
}
