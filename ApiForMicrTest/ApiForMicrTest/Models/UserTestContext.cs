using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppForTest.Models
{
    public class UserTestContext : DbContext
    {
        public DbSet<UserTest> UserTest { get; set; }
    }
}