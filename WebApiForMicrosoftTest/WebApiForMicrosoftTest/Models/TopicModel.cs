using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace WebApiForMicrosoftTest.Models
{
    class TopicModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        static TestDBContext TopicContext = TestDBContext.GetInstance();

        public static async Task<List<TopicModel>> Get()
        {
            var data = TopicContext.Topics.ToListAsync();
            return await data;
        }
        public static async Task<TopicModel> Get(int id)
        {
            return await TopicContext.Topics.FindAsync(id);
        }

        public static async Task Post([FromBody]TopicModel topic)
        {
            TopicContext.Topics.Add(topic);
            await TopicContext.SaveChangesAsync();
        }

        public static async Task Put([FromBody]TopicModel topic)
        {

            TopicContext.Topics.AddOrUpdate(topic);
            await TopicContext.SaveChangesAsync();

        }
        public static async Task Delete(int id)
        {
            TopicModel topic = await TopicContext.Topics.FindAsync(id);
            if (topic != null)
            {
                TopicContext.Topics.Remove(topic);
                await TopicContext.SaveChangesAsync();
            }
        }
    }
}
