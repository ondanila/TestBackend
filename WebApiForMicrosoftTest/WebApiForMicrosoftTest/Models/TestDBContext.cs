using System.Data.Entity;
namespace WebApiForMicrosoftTest.Models
{
    class TestDBContext : DbContext
    {
        private TestDBContext() : base("TestDBContext")
        {
        }
        public DbSet<QuestionModel> Questions { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<UserQuestionModel> UserQuestions { get; set; }
        public DbSet<UserTestModel> UserTests { get; set; }
        public DbSet<TopicModel> Topics { get; set; }
        public DbSet<RelationModel> Relations { get; set; }

        private static TestDBContext instance;
        public static TestDBContext GetInstance()
        {
            if (instance == null)
                instance = new TestDBContext();
            return instance;
        }
    }
}
