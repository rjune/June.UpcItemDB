using System;
using System.Collections.Generic;

namespace June.UpcItemDB
{
    public class Item
    {
        // Disabled because this is a translation class for a JSON service.
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// EAN-13, 13-digit European Article Number (aka. GTIN-13). This is the unique number we used to identify each item in our database. If it starts with 0, the rest 12-digit is the UPC (aka. UPC-A, GTIN-12), ex. 0885909456017.
        /// </summary>
        public string ean { get; set; }

        /// <summary>
        /// Item title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// [optional] UPC-A, 12-digit Universal Product Code (aka. GTIN-12). If item’s EAN does not start with 0, there is no corresponding UPC-A code, ex. 6009705662678.
        /// </summary>
        public string upc { get; set; }

        /// <summary>
        /// [optional] GTIN-14, 14-digit number used to identify trade items at various packaging levels. The contained trade item’s EAN or UPC can be derived from it. Ex. GTIN-14 20008236914225 contains 20-Pack of item with UPC 008236914221.
        /// </summary>
        public string gtin { get; set; }

        /// <summary>
        /// [optional] eBay Listing ID, aka. item ID or item number. Item ID is 9 to 12 digits in length. If item is found on eBay.com, you can simply locate the item by http://www.ebay.com/itm/[eLID].
        /// </summary>
        public string elid { get; set; }

        /// <summary>
        /// Item description with length less than 515.
        /// </summary>
        public string description { get; set; }

        /// <summary>
        /// Brand name or manufacture name with length less than 64.
        /// </summary>
        public string brand { get; set; }

        /// <summary>
        /// Item model number with length< 32.
        /// </summary>
        public string model { get; set; }

        /// <summary>
        /// Item color with length less than 32, ex. for clothing, shoes.
        /// </summary>
        public string color { get; set; }

        /// <summary>
        /// Item size with length less than 32, ex. for clothing, shoes.
        /// </summary>
        public string size { get; set; }

        /// <summary>
        /// Item model number with length< 32.
        /// </summary>
        public string dimension { get; set; }

        /// <summary>
        /// Item weight with length< 16.
        /// </summary>
        public string weight { get; set; }

        /// <summary>
        /// currency of the lowest_recorded_price.Can be “USD”, “CAD”, “EUR”, “GBP”, “SEK”. Default “” means “USD”.
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// [optional] Lowest historical price of the item since tracked by our system.Not available for books.
        /// </summary>
        public decimal? lowest_recorded_price { get; set; }

        /// <summary>
        /// [optional] Highest historical price of the item since tracked by our system.Not available for books.
        /// </summary>
        public decimal? highest_recorded_price { get; set; }

        /// <summary>
        /// array of image urls.
        /// </summary>
        public List<string> images { get; set; }


        /// <summary>
        /// offer objects.
        /// </summary>
        public List<Offer> offers { get; set; }

        /// <summary>
        /// [optional] For user to correlate the response with original request.The same value with max length of 32 will be returned with the response if user set it in the request.
        /// </summary>
        public string user_data { get; set; }
#pragma warning restore IDE1006 // Naming Styles

    }
}
