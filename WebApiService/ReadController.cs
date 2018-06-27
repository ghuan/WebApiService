using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class ReadController : ApiController
    {

        [DllImport("PjDll.dll")]
        private extern static int KTSendRcv(string sendbuf, long sendlen, string recvbuf, long recvlen);



        // GET api/values/5 
        [HttpGet]
        public void Read()
        {
            KTSendRcv("",1,"",1);

        }
       
    }
}