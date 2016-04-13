using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace WebApiForMicrosoftTest.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public string AText { get; set; }
        public int Topic { get; set; }
        static TestDBContext QuestionsContext = TestDBContext.GetInstance();

        public static async Task<List<QuestionModel>> Get()
        {
            var data = QuestionsContext.Questions.ToListAsync();
            return await data;
        }
        public static async Task<QuestionModel> Get(int id)
        {
            return await QuestionsContext.Questions.FindAsync(id);
        }

        public static async Task Post([FromBody]QuestionModel question)
        {
            QuestionsContext.Questions.Add(question);
            await QuestionsContext.SaveChangesAsync();
        }

        public static async Task Put( [FromBody]QuestionModel question)
        {

            QuestionsContext.Questions.AddOrUpdate(question);
            await QuestionsContext.SaveChangesAsync();
            
        }
        public static async Task Delete(int id)
        {
            QuestionModel question = await QuestionsContext.Questions.FindAsync(id);
            if (question != null)
            {
                QuestionsContext.Questions.Remove(question);
                await QuestionsContext.SaveChangesAsync();
            }
        }

    }
}
