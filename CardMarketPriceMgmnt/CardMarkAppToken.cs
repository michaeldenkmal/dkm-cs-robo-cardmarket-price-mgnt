using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardMarketPriceMgmnt
{

    public readonly struct CardMarkAppToken {
        public CardMarkAppToken(string appName, string appType, string appToken, string appSecret,
            string accessToken, string accessTokenSecrets) {

            AppName = appName;
            AppType = appType;
            AppToken = appToken;
            AppSecret = appSecret;
            AccessToken = accessToken;
            AccessTokenSecrets = accessTokenSecrets;
        }
        public string AppName { get;  }
        public string AppType { get;  }
        public string AppToken { get;  }
        public string AppSecret { get; }
        public string AccessToken { get; }
        public string AccessTokenSecrets { get; }

    }
}
