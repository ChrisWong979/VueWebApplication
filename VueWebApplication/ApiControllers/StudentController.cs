using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;

namespace VueWebApplication.ApiControllers
{
    public class StudentController : ApiController
    {
        /// <summary>
        /// Validate the token
        /// </summary>
        /// <param name="request"></param>
        public static void ValidateRequestHeader(HttpRequestMessage request)
        {
            string cookieToken = "";
            string formToken = "";

            if (request.Headers.TryGetValues("RequestVerificationToken", out IEnumerable<string> tokenHeaders))
            {
                cookieToken = request.Headers.GetCookies("__RequestVerificationToken")[0].ToString().Replace("__RequestVerificationToken=", "");
                formToken = tokenHeaders.First();
            }
            AntiForgery.Validate(cookieToken, formToken);
        }

        // POST api/<controller>
        public IEnumerable<string> Post(HttpRequestMessage request)
        {
            ValidateRequestHeader(request);
            return new string[] { "student1", "student2", "student3" };
        }
    }
}