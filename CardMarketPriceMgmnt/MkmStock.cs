using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardMarketPriceMgmnt
{
    public static class MkmStock_h
    {
        public static void downloadAllStocks(CardMarkAppToken cmat, EnRootApiUrl rootApiUrl ,string resultFolder, int artNumStart, int artNumMax)
        {

            for (int i=artNumStart; i<artNumMax; i +=100)
            {
                downloadStock(cmat, rootApiUrl, resultFolder, i);
            }

        }


        public static string downloadStock(CardMarkAppToken cmat, EnRootApiUrl rootApiUrl, string resultFolder, int artNumStart)
        {
            MkmUrlAndMethod unm = MkmUrlBuilder.Stock.buildGetStockUrlMethod(rootApiUrl, artNumStart);
            string json = RequestHelper.makeJsonRequest(cmat, unm.HttpMethod, unm.Url);
            string fileName = String.Format("Stock_{0}_{1}.json", artNumStart, artNumStart + 100);
            string fullJsonPath = Path.Combine(resultFolder, fileName);
            CardMarketUtil.saveJsonFile(json, fullJsonPath);
            return fullJsonPath;
        }
    }
}
