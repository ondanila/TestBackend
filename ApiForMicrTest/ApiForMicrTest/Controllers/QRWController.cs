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

namespace AppForTest.Controllers
{
    public class QRWController : ApiController
    {
        TestDBContext db = TestDBContext.GetInstance();
        // GET: api/QRW
        [HttpGet]
        public IEnumerable<Question> Get()
        {
            return db.Questions;
        }

        // GET: api/QRW/5
        [HttpGet]
        public Question Get(int id)
        {
            Question question = db.Questions.Find(id);
            return question;
        }

        // POST: api/QRW
        [HttpPost]
        public void Post([FromBody]Question question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
        }

        // PUT: api/QRW/5
        [HttpPut]
        public void Put(int id, [FromBody]Question question)
        {
            if (id == question.Id)
            {
                db.Entry(question).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE: api/QRW/5
        [HttpDelete]
        public void Delete(int id)
        {
            Question question = db.Questions.Find(id);
            if (question != null)
            {
                db.Questions.Remove(question);
                db.SaveChanges();
            }
        }
    }
}
