using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{
    public struct MkmUrlAndMethod
    {
        public MkmUrlAndMethod(string url, EnHttpMethod httpMethod)
        {
            Url = url;
            HttpMethod = httpMethod;
        }

        public string Url { get; }
        public EnHttpMethod HttpMethod { get; }

    }
}
