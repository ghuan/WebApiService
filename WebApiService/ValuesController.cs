using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class ValuesController : ApiController
    {

        [DllImport("ICCInter_HZ.dll")]
        private extern static int ICC_Transaction(int TransNum, string DataIn, [Out]char[] DataOut);
        
        // GET api/values 
        public IEnumerable<string> Get()
        {   
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5 
        public string Get(int id)
        {
            char[] dataOut = new char[20000];
            int a = ICC_Transaction(1111, "123456", dataOut);
            string b = new string(dataOut);
            string c = b.Replace("\0", "");
            if (a == 0)
            {
                return c;
            }
            else {
                return a+"|" + c;
            }
            
        }

        // POST api/values 
        public void Post([FromBody]string value)
        {
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