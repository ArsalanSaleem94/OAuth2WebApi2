using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Application.Models
{
    public class Users
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public String LastName { get; set; }
    }
}