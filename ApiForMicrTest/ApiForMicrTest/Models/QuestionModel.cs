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

namespace ApiForMicrTest.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }
        public string QText { get; set; }
        public string AText { get; set; }
        public int Topic { get; set; }
        static TestDBContext QuestionsContext = TestDBContext.GetInstance();
        
        public async Task<IEnumerable<QuestionModel>> Get()
        {
            //return await QuestionsContext.Questions.ForEachAsync();
            return QuestionsContext.Questions;
        }
        public static async Task<QuestionModel> Get(int id)
        {           
            return await QuestionsContext.Questions.FindAsync(id);
        }
       
        public void Post([FromBody]QuestionModel question)
        {
            QuestionsContext.Questions.Add(question);
            QuestionsContext.SaveChanges();
        }
        
        public void Put(int id, [FromBody]QuestionModel question)
        {
            if (id == question.Id)
            {
                QuestionsContext.Entry(question).State = EntityState.Modified;

                QuestionsContext.SaveChanges();
            }
        }
    }
}