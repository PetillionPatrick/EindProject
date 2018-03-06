using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKwaliteit.Models.DTO
{
    public class BeukDTO
    {
        public Guid Id { get; set; }

        public string Naam { get; set; }

        public Guid OwnerId { get; set; }
    }
}