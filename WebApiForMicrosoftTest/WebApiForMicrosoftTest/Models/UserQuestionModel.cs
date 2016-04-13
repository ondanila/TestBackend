using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApiForMicrosoftTest.Models
{
    class UserQuestionModel
    {
        [Key]
        [Column(Order = 0)]
        public int userTestID { get; set; }
        [Key]
        [Column(Order = 1)]
        public int QID { get; set; }
        public int Result { get; set; }
        static TestDBContext UserQuestionsContext = TestDBContext.GetInstance();

        public static async Task<List<UserQuestionModel>> Get()
        {
            var data = UserQuestionsContext.UserQuestions.ToListAsync();
            return await data;
        }
        public static async Task<UserQuestionModel> Get(int usertest_id, int question_id)
        {
            return await UserQuestionsContext.UserQuestions.FindAsync(usertest_id, question_id);
        }

        public static async Task Post([FromBody]UserQuestionModel userquestion)
        {
            UserQuestionsContext.UserQuestions.Add(userquestion);
            await UserQuestionsContext.SaveChangesAsync();
        }

        public static async Task Put([FromBody]UserQuestionModel userquestion)
        {

            UserQuestionsContext.UserQuestions.AddOrUpdate(userquestion);
            await UserQuestionsContext.SaveChangesAsync();

        }
        public static async Task Delete(int usertest_id, int question_id)
        {
            UserQuestionModel userquestion = await UserQuestionsContext.UserQuestions.FindAsync(usertest_id, question_id);
            if (userquestion != null)
            {
                UserQuestionsContext.UserQuestions.Remove(userquestion);
                await UserQuestionsContext.SaveChangesAsync();
            }
        }
    }
}
