using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System;

namespace WebApiForMicrosoftTest.Models
{
    class UserTestModel
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Result { get; set; }
        public DateTime Date { get; set; }

        static TestDBContext UserTestsContext = TestDBContext.GetInstance();

        public static async Task<List<UserTestModel>> Get()
        {
            var data = UserTestsContext.UserTests.ToListAsync();
            return await data;
        }
        public static async Task<UserTestModel> Get(int id)
        {
            return await UserTestsContext.UserTests.FindAsync(id);
        }

        public static async Task Post([FromBody]UserTestModel usertest)
        {
            UserTestsContext.UserTests.Add(usertest);
            await UserTestsContext.SaveChangesAsync();
        }

        public static async Task Put([FromBody]UserTestModel usertest)
        {

            UserTestsContext.UserTests.AddOrUpdate(usertest);
            await UserTestsContext.SaveChangesAsync();

        }
        public static async Task Delete(int id)
        {
            UserTestModel usertest = await UserTestsContext.UserTests.FindAsync(id);
            if (usertest != null)
            {
                UserTestsContext.UserTests.Remove(usertest);
                await UserTestsContext.SaveChangesAsync();
            }
        }
    }
}
