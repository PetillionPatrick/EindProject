using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiKwaliteit.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        public string Naam { get; set; }

        public string Paswoord { get; set; }

        public virtual List<Beuk> Beuken { get; set; }
    }
}