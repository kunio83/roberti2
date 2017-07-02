using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Services
{
    public static class Controller
    {
        public static void SetRequest(int angulo, int distancia)
        {
            string url = String.Format("http://192.168.137.214/anng{0}dst{1}", angulo, distancia);





            HttpWebRequest myReq =
            (HttpWebRequest)WebRequest.Create(url);
            try
            {
                myReq.Timeout = 1;


                myReq.GetResponse();
            }
            catch { }
            //myReq.Abort();
        }

        //public static void SetRequest(int angulo, int distancia)
        //{
        //    string url = String.Format("http://192.168.137.129/anng{0}dst{1}", angulo, distancia);
        //    string datos = String.Format("anng{0}dst{1}", angulo, distancia);

        //    var client = new RestClient(url);
        //    //client.Execute(null);

        //    var client = new RestClient(url);
        //    var request = new RestRequest("", Method.GET);

        //    client.Timeout = 1;
        //    try
        //    {
        //        var queryResult = client.ExecuteAsync(request, null);
        //    }
        //    catch
        //    {

        //    }


        //    //HttpWebRequest myReq =
        //    //(HttpWebRequest)WebRequest.Create(url);
        //    //myReq.GetResponseAsync();
        //}
    }
}
