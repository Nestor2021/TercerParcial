using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TercerParcialAPI.Models.Request
{
    public class AvionRequest
    {

        public string NombreAvion { get; set; }
        public string marca { get; set; }
        public int capacidad { get; set; }
        public string descripcion { get; set; }
       
    }
}