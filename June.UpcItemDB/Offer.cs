namespace June.UpcItemDB
{
    public class Offer
    {
        // Disabled because this is a translation class for a JSON service.
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// Online store name.
        /// </summary>
        public string merchant { get; set; }


        /// <summary>
        /// Online store domain.
        /// </summary>
        public string domain { get; set; }

        /// <summary>
        /// Item name marketed by the merchant.
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// currency of the list_price & price.Can be “USD”, “CAD”, “EUR”, “GBP”, “SEK”. Default “” means “USD”.
        /// </summary>
        public string currency { get; set; }

        /// <summary>
        /// Original price from the store.
        /// </summary>
        public decimal? list_price { get; set; }

        /// <summary>
        /// Sale price.
        /// </summary>
        public decimal? price { get; set; }

        /// <summary>
        /// “Free Shipping” or other shipping information if not free.
        /// </summary>
        public string shipping { get; set; }

        /// <summary>
        /// “New” or “Used”
        /// </summary>
        public string condition { get; set; }

        /// <summary>
        /// Default “” means available or “Out of Stock”
        /// </summary>
        public string availability { get; set; }

        /// <summary>
        /// Shop link of the item.
        /// </summary>
        public string link { get; set; }

        /// <summary>
        /// unix timestamp of the offer was last updated.
        /// </summary>
        public long? updated_t { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
