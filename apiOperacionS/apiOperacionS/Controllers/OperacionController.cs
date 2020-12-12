using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace apiOperacionS.Controllers
{
    public class OperacionController : ApiController
    {
        public string Get (int id)
        {
            if(id<0)
            {
                return "Numero" + id.ToString() + ", Mensaje: Error"; 
                
            }
            if(id ==0)
            {
                return "Numero" + id.ToString() + ", Mensaje: Realizado por Adriana Salmon Sahonero";

            }
            return "Numero" + id.ToString() + ", Mensaje:"+ "  https://image.freepik.com/vector-gratis/numeros-cartel-imagen_1639-6453.jpg ";
        }
    }
}
