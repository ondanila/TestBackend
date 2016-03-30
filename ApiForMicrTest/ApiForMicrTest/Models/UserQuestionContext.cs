using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppForTest.Models
{
    public class UserQuestionContext : DbContext
    {
        public DbSet<UserQuestion> UserQuestion { get; set; }
        
    }
}