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
    public class UTRWController : ApiController
    {
        TestDBContext db = TestDBContext.GetInstance();
        // GET: api/UTRW
        [HttpGet]
        public IEnumerable<UserTest> Get()
        {
            return db.UserTest;
        }

        // GET: api/UTRW/5
        [HttpGet]
        public UserTest Get(int id)
        {
            UserTest usertest = db.UserTest.Find(id);
            return usertest;
        }

        // POST: api/UTRW
        [HttpPost]
        public void Post([FromBody]UserTest usertest)
        {
            db.UserTest.Add(usertest);
            db.SaveChanges();
        }

        // PUT: api/UTRW/5
        [HttpPut]
        public void Put(int id, [FromBody]UserTest usertest)
        {
            if (id == usertest.ID)
            {
                db.Entry(usertest).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE: api/UTRW/5
        [HttpDelete]
        public void Delete(int id)
        {
            UserTest usertest = db.UserTest.Find(id);
            if (usertest != null)
            {
                db.UserTest.Remove(usertest);
                db.SaveChanges();
            }
        }
    }
}
