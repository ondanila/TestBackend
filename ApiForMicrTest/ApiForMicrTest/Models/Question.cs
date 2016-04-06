using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using ApiForMicrTest.Models;

namespace AppForTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public string AText { get; set; }
        public int Topic { get; set; }
        static TestDBContext QuestionsContext = TestDBContext.GetInstance();

        //public async Task<IEnumerable<QuestionModel>> Get()
        //{
        //    //return await QuestionsContext.Questions.ForEachAsync();
        //    return QuestionsContext.Questions;
        //}
        public static async Task<Question> Get(int id)
        {
            return await QuestionsContext.Questions.FindAsync(id);
        }

        public static async Task Post([FromBody]Question question)
        {
            QuestionsContext.Questions.Add(question);
            await QuestionsContext.SaveChangesAsync();
        }

        public static async Task Put(int id, [FromBody]Question question)
        {
            if (id == question.Id)
            {
                QuestionsContext.Entry(question).State = EntityState.Modified;

                await QuestionsContext.SaveChangesAsync();
            }
        }
        public static async Task Delete(int id)
        {
            Question question = await QuestionsContext.Questions.FindAsync(id);
            if (question != null)
            {
                QuestionsContext.Questions.Remove(question);
                await QuestionsContext.SaveChangesAsync();
            }
        }
    }
}