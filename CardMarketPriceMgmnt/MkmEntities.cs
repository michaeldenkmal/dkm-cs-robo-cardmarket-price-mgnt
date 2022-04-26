using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{
    public static class MkmEntities
    {
        public class Stock
        {
            public string stock { get; set; }          // The base64 encoded string
            public string mime { get; set; }           // The MIME type of the file
        }
    }
}
