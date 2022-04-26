using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{
    public enum EnHttpMethod
    {
        GET, POST, PUT, DELETE
    }

    public static class HttpMethod_h
    {
        public static string enHttpMethodToStr(EnHttpMethod enm)
        {
            switch(enm)
            {
                case EnHttpMethod.GET: return "GET";
                case EnHttpMethod.POST: return "POST";
                case EnHttpMethod.PUT: return "PUT";
                case EnHttpMethod.DELETE: return "DELETE";
                default:
                    throw new Exception(string.Format("bei switch fehlt der Zweig für: {0}", enm));
            }
        }
    }
}
