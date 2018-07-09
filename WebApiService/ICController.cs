using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace OwinSelfhostSample
{
    public class ICController : ApiController
    {

        [DllImport("ICCInter_HZ.dll")]
        private extern static int ICC_Transaction(int TransNum, string DataIn, [Out]char[] DataOut);
        
      

        // GET api/values/5 
        [HttpGet]
        public HttpResponseMessage ReadCard(int TransNum,string DataIn)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage();
            try {
                char[] dataOut = new char[20000];
                int a = ICC_Transaction(TransNum, DataIn, dataOut);
                string b = new string(dataOut);
                string c = b.Replace("\0", "");

                if (a == 0)
                {
                    responseMessage.Content = new StringContent(c, Encoding.GetEncoding("UTF-8"), "text/plain");
                }
                else
                {
                    responseMessage.Content = new StringContent(a + "|" + c, Encoding.GetEncoding("UTF-8"), "text/plain");
                }
               
            } catch (Exception ex)
            {
                FileStream fs = new FileStream("d:\\ak.txt", FileMode.Create);
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes(ex.Message);
                //开始写入
                fs.Write(data, 0, data.Length);
                //清空缓冲区、关闭流
                fs.Flush();
                fs.Close();
            }

            return responseMessage;
        }
       
    }
}