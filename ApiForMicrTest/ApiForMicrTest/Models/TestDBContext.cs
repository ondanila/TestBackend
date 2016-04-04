using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection;
using AppForTest.Models;

namespace ApiForMicrTest.Models
{
    
    class TestDBContext : DbContext
    {
        
        private TestDBContext() : base("TestDBContext") { }
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserQuestion> UserQuestion { get; set; }
        public DbSet<UserTest> UserTest { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Relation> Relation { get; set; }

        private static TestDBContext instance;
        public static TestDBContext GetInstance()
        {
            if (instance == null)
                instance = new TestDBContext();
            return instance;
        }
        
       
        
    }
}
