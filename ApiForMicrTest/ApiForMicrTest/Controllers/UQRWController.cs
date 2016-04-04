using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppForTest.Models;
using System.Data;
using System.Data.Entity;
using ApiForMicrTest.Models;

namespace AppForTest.Controllers
{
    public class UQRWController : ApiController
    {
        TestDBContext db = TestDBContext.GetInstance();
        // GET: api/UQRW

        [HttpGet]
        public IEnumerable<UserQuestion> Get()
        {
            
            return db.UserQuestion;
        }

        // GET: api/UQRW/5
        [HttpGet]
        public UserQuestion Get(int utid,int qid)
        {
            UserQuestion userquestion = db.UserQuestion.Find(utid, qid);
            return userquestion;
        }

        // POST: api/UQRW
        [HttpPost]
        public void Post([FromBody]UserQuestion userquestion)
        {
            db.UserQuestion.Add(userquestion);
            db.SaveChanges();
        }

        // PUT: api/UQRW/5
        [HttpPut]
        public void Put(int utid, int qid, [FromBody]UserQuestion userquestion)
        {
            if ((utid == userquestion.userTestID) && (qid == userquestion.QID))
            {
                db.Entry(userquestion).State = EntityState.Modified;

                db.SaveChanges();
            }
    }

        // DELETE: api/UQRW/5
        [HttpDelete]
        public void Delete(int utid, int qid)
        {
            UserQuestion userquestion = db.UserQuestion.Find(utid, qid);
            if (userquestion != null)
            {
                db.UserQuestion.Remove(userquestion);
                db.SaveChanges();
            }
        }
    }
}
