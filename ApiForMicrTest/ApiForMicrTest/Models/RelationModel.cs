using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiForMicrTest.Models
{
    public class RelationModel
    {
        public int Id { get; set; }
        public int Child { get; set; }
        public int Parent { get; set; }
    }
}