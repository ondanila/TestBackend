using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AppForTest.Models;
using System.Data;
using System.Data.Entity;

namespace AppForTest.Controllers
{
    public class TRWController : ApiController
    {
        TopicContext db = new TopicContext();
        // GET: api/TRW
        [HttpGet]
        public IEnumerable<Topic> Get()
        {
            return db.Topic;
        }

        // GET: api/TRW/5
        [HttpGet]
        public Topic Get(int id)
        {
            Topic topic = db.Topic.Find(id);
            return topic;
        }

        // POST: api/TRW
        [HttpPost]
        public void Post([FromBody]Topic topic)
        {
            db.Topic.Add(topic);
            db.SaveChanges();
        }

        // PUT: api/TRW/5
        [HttpPut]
        public void Put(int id, [FromBody]Topic topic)
        {
            if (id == topic.Id)
            {
                db.Entry(topic).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        // DELETE: api/TRW/5
        [HttpDelete]
        public void Delete(int id)
        {
            Topic topic = db.Topic.Find(id);
            if (topic != null)
            {
                db.Topic.Remove(topic);
                db.SaveChanges();
            }
        }
    }
}
