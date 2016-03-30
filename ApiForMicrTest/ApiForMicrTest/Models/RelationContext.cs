using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppForTest.Models
{
    public class RelationContext : DbContext
    {
        public DbSet<Relation> Relation { get; set; }
    }
}