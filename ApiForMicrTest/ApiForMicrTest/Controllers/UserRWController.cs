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
    public class UserRWController : ApiController
    {
        TestDBContext db = TestDBContext.GetInstance();
        // GET: api/UserRW
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users;
        }

        // GET: api/UserRW/5
        [HttpGet]
        public User Get(int id)
        {
            User user = db.Users.Find(id);
            return user;
        }

        // POST: api/UserRW
        [HttpPost]
        public void Post([FromBody]User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
        }

        // PUT: api/UserRW/5
        [HttpPut]
        public void Put(int id, [FromBody]User user)
        {
            if (id == user.Id)
            {
                db.Entry(user).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE: api/UserRW/5
        [HttpDelete]
        public void Delete(int id)
        {
            User user = db.Users.Find(id);
            if (user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
