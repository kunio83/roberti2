using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class Program
    {
        static void Main(string[] args)
        {
            SetRequest();
        }
        public static void SetRequest()
        {
            HttpWebRequest myReq =
            (HttpWebRequest)WebRequest.Create("http://192.168.137.129/anng180dst20");
            myReq.GetResponse();
        }
    }

    
}
//192.168.137.154"
