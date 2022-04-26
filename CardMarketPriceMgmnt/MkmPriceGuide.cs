using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{
    public class MkmPriceGuide_h
    {
        public static void downLoadPriceGuide(CardMarkAppToken cmat, EnRootApiUrl rootApiUrl, string resultFolder)
        {
            var urlAndMeth = MkmUrlBuilder.PriceGuide.buildDownloadFileUrlMethod(rootApiUrl);
            var json = RequestHelper.makeJsonRequest(cmat, urlAndMeth.HttpMethod, urlAndMeth.Url);
            var jsonFileName = string.Format("price_guid.json");
            var jsonFullPath = Path.Combine(resultFolder, jsonFileName);
            CardMarketUtil.saveJsonFile(json, jsonFullPath);
        }
    }
}
