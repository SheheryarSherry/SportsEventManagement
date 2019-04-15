using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using SportsEventManagement.DbModels;
using SportsEventManagement.DbModels.EF;

namespace SportsEventManagement.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        
        [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        // GET api/values
        public IEnumerable<string> Get()
        {
            // return OK
            return new string[] { "value1", "value2" };
        }

        //public string Get()
        //{


        //    // return OK
        // //   Ok();
        //    return  "{'test':'test' }";
        //}
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }
      //  [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
        public void Post([FromBody]Match value)
        {
            DbModels.SportsEventContext ctx = new SportsEventContext();
            ctx.Matches.Add(value);
            ctx.SaveChanges();
            
        }
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
        
    }
}
