using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{
    public static class MkmUrlBuilder
    {
        // https://sandbox.mkmapi.eu/ws/v2.0/output.json/games
        public static string ROOT_API_URL_SAND_BOX = "https://sandbox.mkmapi.eu/ws/v2.0/output.json";
        public static string ROOT_API_URL_PROD = "https://api.cardmarket.com/ws/v2.0/output.json";


        public static string getRootUrl(EnRootApiUrl rootApiUrl)
        {
            if (rootApiUrl == EnRootApiUrl.sandbox)
            {
                return ROOT_API_URL_SAND_BOX;
            }
            return ROOT_API_URL_PROD;
        }
        public static class Stock
        {
            public static MkmUrlAndMethod buildDownloadFileUrlMethod(EnRootApiUrl rootApiUrl)
            {
                string url = string.Format("{0}/stock/file", MkmUrlBuilder.getRootUrl(rootApiUrl));
                return new MkmUrlAndMethod(url, EnHttpMethod.GET);
            }

            public static MkmUrlAndMethod buildGetStockUrlMethod(EnRootApiUrl rootApiUrl, int start)
            {
                string url = string.Format("{0}/stock/{1}", MkmUrlBuilder.getRootUrl(rootApiUrl), start);
                return new MkmUrlAndMethod(url, EnHttpMethod.GET);
            }
        }

        public static class PriceGuide
        {
            public static MkmUrlAndMethod buildDownloadFileUrlMethod(EnRootApiUrl rootApiUrl)
            {
                // GET https://api.cardmarket.com/ws/v2.0/priceguide
                string url = string.Format("{0}/priceguide", MkmUrlBuilder.getRootUrl(rootApiUrl));
                return new MkmUrlAndMethod(url, EnHttpMethod.GET);
            }
        }
    }
}
