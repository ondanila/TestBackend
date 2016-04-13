using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace WebApiForMicrosoftTest.Models
{
    class RelationModel
    {
        public int Id { get; set; }
        public int Child { get; set; }
        public int Parent { get; set; }
        static TestDBContext RelationContext = TestDBContext.GetInstance();

        public static async Task<List<RelationModel>> Get()
        {
            var data = RelationContext.Relations.ToListAsync();
            return await data;
        }
        public static async Task<RelationModel> Get(int id)
        {
            return await RelationContext.Relations.FindAsync(id);
        }

        public static async Task Post([FromBody]RelationModel relation)
        {
            RelationContext.Relations.Add(relation);
            await RelationContext.SaveChangesAsync();
        }

        public static async Task Put([FromBody]RelationModel relation)
        {

            RelationContext.Relations.AddOrUpdate(relation);
            await RelationContext.SaveChangesAsync();

        }
        public static async Task Delete(int id)
        {
            RelationModel relation = await RelationContext.Relations.FindAsync(id);
            if (relation != null)
            {
                RelationContext.Relations.Remove(relation);
                await RelationContext.SaveChangesAsync();
            }
        }
    }
}
