using June.Tools.Functional;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace June.UpcItemDB
{
    public class UpcItemDBClient
    {
        /// <summary>
        /// null means we are using it unauthorized
        /// </summary>
        private string _apiKey;
        private Uri _uri;

        public UpcItemDBClient(string apiKey)
        {
            if (string.IsNullOrWhiteSpace(apiKey))
                _apiKey = null;
            else
                _apiKey = apiKey;
            _uri = new Uri("https://api.upcitemdb.com/prod/trial/lookup");

        }

        public Result<Item> LookupBarcode(string barcode)
        {

            var wc = new WebClient();
            if (_apiKey != null)
            {
                wc.Headers.Add("key_type", "3scale");
                wc.Headers.Add("user_key", _apiKey);
            }

            wc.QueryString.Add("upc", barcode);

#if DEBUG
            var json = wc.DownloadString(_uri);
#else
            var json = wc.DownloadString(_uri);
#endif
            var data = JObject.Parse(json);

            var code = data["code"].ToString();
            if (code != "OK")
                return Result.Fail<Item>(data["message"].ToString());

            var mapItem = data["items"][0];
            var rval = mapItem.ToObject<Item>();
            return Result.Ok(rval);
        }
    }
}
