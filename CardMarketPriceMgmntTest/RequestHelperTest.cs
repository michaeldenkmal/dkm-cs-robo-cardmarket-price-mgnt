using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardMarketPriceMgmnt;
using System;
using System.IO;

namespace CardMarketPriceMgmntTest
{
    [TestClass]
    public class RequestHelperTest
    {
        [TestMethod]
        public void test_makeJsonRequest()
        {
            MkmUrlAndMethod unm = MkmUrlBuilder.Stock.buildGetStockUrlMethod(EnRootApiUrl.production,1);
            Console.WriteLine(string.Format("url={0}", unm.Url));
            string resultFile = @"D:\projekte\csharp\dkm-cs-robo-cardmarket-price-mgnt\CardMarketPriceMgmntTest\files\stockFile.json";
            //string url = "https://api.cardmarket.com/ws/v2.0/output.json/account";
            string url = "https://api.cardmarket.com/ws/v2.0/stock/1";
            string json=RequestHelper.makeJsonRequest(RoboAppKeyConst.cardMarkAppToken, unm.HttpMethod, url);
            File.WriteAllText(resultFile, json, System.Text.Encoding.UTF8);
        }
    }
}
