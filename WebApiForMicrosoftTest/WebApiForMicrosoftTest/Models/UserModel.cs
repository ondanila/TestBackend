using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace WebApiForMicrosoftTest.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        static TestDBContext UsersContext = TestDBContext.GetInstance();

        public static async Task<List<UserModel>> Get()
        {
            var data = UsersContext.Users.ToListAsync();
            return await data;
        }
        public static async Task<UserModel> Get(int id)
        {
            return await UsersContext.Users.FindAsync(id);
        }

        public static async Task Post([FromBody]UserModel user)
        {
            UsersContext.Users.Add(user);
            await UsersContext.SaveChangesAsync();
        }

        public static async Task Put([FromBody]UserModel user)
        {

            UsersContext.Users.AddOrUpdate(user);
            await UsersContext.SaveChangesAsync();

        }
        public static async Task Delete(int id)
        {
            UserModel user = await UsersContext.Users.FindAsync(id);
            if (user != null)
            {
                UsersContext.Users.Remove(user);
                await UsersContext.SaveChangesAsync();
            }
        }
    }
}