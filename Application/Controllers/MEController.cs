using Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Controllers
{
    [Authorize]
    public class MEController : ApiController
    {
        public IHttpActionResult Get()
        {
            Users u = new Users();
            u.FirstName = "Arsalan";
            u.LastName = "Saleem";

            if (u != null)
            {
                return Ok(u);
            }
            return NotFound();
        }
        
    }
}
