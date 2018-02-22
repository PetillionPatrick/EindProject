using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiKwaliteit.Models
{
    public class LineInspector : Operator
    {
        public virtual List<Status> StatussenLi { get; set; }
    }
}