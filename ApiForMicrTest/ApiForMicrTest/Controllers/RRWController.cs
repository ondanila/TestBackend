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
    public class RRWController : ApiController
    {
        TestDBContext db = TestDBContext.GetInstance();
        // GET: api/RRW
        [HttpGet]
        public IEnumerable<Relation> Get()
        {
            return db.Relation;
        }

        // GET: api/RRW/5
        [HttpGet]
        public Relation Get(int id)
        {
            Relation relation = db.Relation.Find(id);
            return relation;
        }

        // POST: api/RRW
        [HttpPost]
        public void Post([FromBody]Relation relation)
        {
            db.Relation.Add(relation);
            db.SaveChanges();
        }

        // PUT: api/RRW/5
        [HttpPut]
        public void Put(int id, [FromBody]Relation relation)
        {
            if (id == relation.Id)
            {
                db.Entry(relation).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE: api/RRW/5
        [HttpDelete]
        public void Delete(int id)
        {
            Relation relation = db.Relation.Find(id);
            if (relation != null)
            {
                db.Relation.Remove(relation);
                db.SaveChanges();
            }
        }
    }
}
