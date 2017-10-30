using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PeliculasAPI.Models;

namespace Peliculas.Controllers
{
    public class ActoresController : ApiController
    {
        public string Get(string Nombre)
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    "<strong>test</strong>",
                    Encoding.UTF8,
                    "text/html"
                    )
            };
        }
    }
}
