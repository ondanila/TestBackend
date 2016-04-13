using System.Web.Http;
using WebApiForMicrosoftTest.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Web.Http.Cors;

namespace WebApiForMicrosoftTest.Controllers
{
    [EnableCors("*", "*", "*")]
    public class QuestionController : ApiController
    {
        // GET: api/Question

        public async Task<List<QuestionModel>> Get()
        {
            return await QuestionModel.Get();
        }

        // GET: api/Question/5
        public async Task<QuestionModel> Get(int id)
        {
            return await QuestionModel.Get(id);
        }

        // POST: api/Question
        public async void Post([FromBody]QuestionModel question)
        {
            await QuestionModel.Post(question);

        }

        // PUT: api/Question/5
        public async void Put([FromBody]QuestionModel question)
        {
            await QuestionModel.Put( question);
        }

        // DELETE: api/Question/5
        public async void Delete(int id)
        {
            await QuestionModel.Delete(id);
        }
    }
}
