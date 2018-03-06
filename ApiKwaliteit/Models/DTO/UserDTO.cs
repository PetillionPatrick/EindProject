using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKwaliteit.Models.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        public string Naam { get; set; }

        public string Paswoord { get; set; }
    }
}