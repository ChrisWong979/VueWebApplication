using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace VueWebApplication.ApiControllers
{
    public class StudentController : ApiController
    {
        // GET api/<controller>
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse<string[]>(HttpStatusCode.Created, new string[] { "value1", "value2" });
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public HttpResponseMessage Post([FromBody]string value)
        {
            return Request.CreateResponse<string[]>(HttpStatusCode.Created, new string[] { "value1", "value2", "value3" });
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}