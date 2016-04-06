using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppForTest.Models;
using ApiForMicrTest.Models;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ApiForMicrTest.Controllers
{
    public class QuestionController : ApiController
    {
        // GET: api/Question

        //public IEnumerable<QuestionModel> Get()
        //{
        //    return db.Questions;
        //}

        // GET: api/Question/5
        public async Task<Question> Get(int id)
        {
            return await Question.Get(id);
        }

        // POST: api/Question
        public async void Post([FromBody]Question question)
        {
            await Question.Post(question);
            
        }

        // PUT: api/Question/5
        public async void Put(int id, [FromBody]Question question)
        {
            await Question.Put(id, question);
        }

        // DELETE: api/Question/5
        public async void Delete(int id)
        {
            await Question.Delete(id);
        }
    }
}
