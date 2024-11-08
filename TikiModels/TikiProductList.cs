using Newtonsoft.Json;

namespace ProGCoder_Tiki_Crawl_Tool.Models;

#nullable disable
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class Amplitude
{
    [JsonProperty("seller_type")]
    public string SellerType { get; set; }

    [JsonProperty("seller_id")]
    public string SellerId { get; set; }

    [JsonProperty("all_time_quantity_sold")]
    public string AllTimeQuantitySold { get; set; }

    [JsonProperty("brand_name")]
    public string BrandName { get; set; }

    [JsonProperty("category_l1_name")]
    public string CategoryL1Name { get; set; }

    [JsonProperty("category_l2_name")]
    public string CategoryL2Name { get; set; }

    [JsonProperty("category_l3_name")]
    public string CategoryL3Name { get; set; }

    [JsonProperty("is_best_offer_available")]
    public bool IsBestOfferAvailable { get; set; }

    [JsonProperty("is_flash_deal")]
    public bool IsFlashDeal { get; set; }

    [JsonProperty("is_gift_available")]
    public bool IsGiftAvailable { get; set; }

    [JsonProperty("master_product_sku")]
    public string MasterProductSku { get; set; }

    [JsonProperty("seller_product_id")]
    public string SellerProductId { get; set; }

    [JsonProperty("seller_product_sku")]
    public string SellerProductSku { get; set; }

    [JsonProperty("number_of_reviews")]
    public string NumberOfReviews { get; set; }

    [JsonProperty("order_route")]
    public string OrderRoute { get; set; }

    [JsonProperty("partner_rewards_amount")]
    public string PartnerRewardsAmount { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("primary_category_name")]
    public string PrimaryCategoryName { get; set; }

    [JsonProperty("product_rating")]
    public string ProductRating { get; set; }

    [JsonProperty("search_rank")]
    public string SearchRank { get; set; }

    [JsonProperty("tiki_verified")]
    public string TikiVerified { get; set; }

    [JsonProperty("is_authentic")]
    public string IsAuthentic { get; set; }

    [JsonProperty("standard_delivery_estimate")]
    public string StandardDeliveryEstimate { get; set; }

    [JsonProperty("earliest_delivery_estimate")]
    public string EarliestDeliveryEstimate { get; set; }

    [JsonProperty("tikipro_delivery_estimate")]
    public string TikiproDeliveryEstimate { get; set; }

    [JsonProperty("tikinow_delivery_estimate")]
    public string TikinowDeliveryEstimate { get; set; }

    [JsonProperty("layout")]
    public string Layout { get; set; }

    [JsonProperty("variant")]
    public bool Variant { get; set; }

    [JsonProperty("is_hero")]
    public bool IsHero { get; set; }

    [JsonProperty("is_imported")]
    public bool IsImported { get; set; }

    [JsonProperty("origin")]
    public string Origin { get; set; }

    [JsonProperty("is_high_price_penalty")]
    public bool IsHighPricePenalty { get; set; }

    [JsonProperty("deboosted_high_price_diff_position")]
    public string DeboostedHighPriceDiffPosition { get; set; }

    [JsonProperty("joined_strategy_rerank")]
    public bool JoinedStrategyRerank { get; set; }

    [JsonProperty("is_freeship_xtra")]
    public bool IsFreeshipXtra { get; set; }

    [JsonProperty("is_top_brand")]
    public bool IsTopBrand { get; set; }

    [JsonProperty("number_of_sponsored_product_ad")]
    public string NumberOfSponsoredProductAd { get; set; }

    [JsonProperty("number_of_display_ad")]
    public string NumberOfDisplayAd { get; set; }

    [JsonProperty("number_of_brand_store_ad")]
    public string NumberOfBrandStoreAd { get; set; }

    [JsonProperty("selected_sort_option")]
    public string SelectedSortOption { get; set; }

    [JsonProperty("search_experiment_variant")]
    public string SearchExperimentVariant { get; set; }

    [JsonProperty("search_request")]
    public string SearchRequest { get; set; }

    [JsonProperty("search_location")]
    public string SearchLocation { get; set; }
}

public class ArrText
{
    [JsonProperty("value")]
    public string Value { get; set; }
}

public class BadgesNew
{
    [JsonProperty("placement")]
    public string Placement { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("icon_width")]
    public string IconWidth { get; set; }

    [JsonProperty("icon_height")]
    public string IconHeight { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("text_color")]
    public string TextColor { get; set; }

    [JsonProperty("arr_text")]
    public List<ArrText> ArrText { get; set; }
}

public class BadgesV3
{
    [JsonProperty("placement")]
    public string Placement { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("image")]
    public string Image { get; set; }
}

public class Datum
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("sku")]
    public string Sku { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url_key")]
    public string UrlKey { get; set; }

    [JsonProperty("url_path")]
    public string UrlPath { get; set; }

    [JsonProperty("availability")]
    public string Availability { get; set; }

    [JsonProperty("seller_id")]
    public string SellerId { get; set; }

    [JsonProperty("seller_name")]
    public string SellerName { get; set; }

    [JsonProperty("brand_id")]
    public string BrandId { get; set; }

    [JsonProperty("brand_name")]
    public string BrandName { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("original_price")]
    public string OriginalPrice { get; set; }

    [JsonProperty("badges_new")]
    public List<BadgesNew> BadgesNew { get; set; }

    [JsonProperty("badges_v3")]
    public List<BadgesV3> BadgesV3 { get; set; }

    [JsonProperty("discount")]
    public string Discount { get; set; }

    [JsonProperty("discount_rate")]
    public string DiscountRate { get; set; }

    [JsonProperty("rating_average")]
    public string RatingAverage { get; set; }

    [JsonProperty("review_count")]
    public string ReviewCount { get; set; }

    [JsonProperty("category_ids")]
    public List<string> CategoryIds { get; set; }

    [JsonProperty("primary_category_path")]
    public string PrimaryCategoryPath { get; set; }

    [JsonProperty("primary_category_name")]
    public string PrimaryCategoryName { get; set; }

    [JsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonProperty("thumbnail_width")]
    public string ThumbnailWidth { get; set; }

    [JsonProperty("thumbnail_height")]
    public string ThumbnailHeight { get; set; }

    [JsonProperty("productset_id")]
    public string ProductsetId { get; set; }

    [JsonProperty("seller_product_id")]
    public string SellerProductId { get; set; }

    [JsonProperty("seller_product_sku")]
    public string SellerProductSku { get; set; }

    [JsonProperty("master_product_sku")]
    public string MasterProductSku { get; set; }

    [JsonProperty("quantity_sold")]
    public QuantitySold QuantitySold { get; set; }

    [JsonProperty("shippable")]
    public bool Shippable { get; set; }

    [JsonProperty("isGiftAvailable")]
    public bool IsGiftAvailable { get; set; }

    [JsonProperty("is_normal_delivery")]
    public bool IsNormalDelivery { get; set; }

    [JsonProperty("is_tikinow_delivery")]
    public bool IsTikinowDelivery { get; set; }

    [JsonProperty("is_nextday_delivery")]
    public bool IsNextdayDelivery { get; set; }

    [JsonProperty("is_from_official_store")]
    public bool IsFromOfficialStore { get; set; }

    [JsonProperty("is_authentic")]
    public string IsAuthentic { get; set; }

    [JsonProperty("tiki_verified")]
    public string TikiVerified { get; set; }

    [JsonProperty("tiki_hero")]
    public string TikiHero { get; set; }

    [JsonProperty("origin")]
    public string Origin { get; set; }

    [JsonProperty("freeship_campaign")]
    public string FreeshipCampaign { get; set; }

    [JsonProperty("impression_info")]
    public List<ImpressionInfo> ImpressionInfo { get; set; }

    [JsonProperty("visible_impression_info")]
    public VisibleImpressionInfo VisibleImpressionInfo { get; set; }

    [JsonProperty("layout_type")]
    public string LayoutType { get; set; }

    [JsonProperty("is_high_price_penalty")]
    public bool IsHighPricePenalty { get; set; }

    [JsonProperty("is_top_brand")]
    public bool IsTopBrand { get; set; }

    [JsonProperty("imported")]
    public string Imported { get; set; }
}

public class ExperimentVariants
{
    [JsonProperty("impression_id")]
    public string ImpressionId { get; set; }
}

public class Flags
{
    [JsonProperty("impression_id")]
    public string ImpressionId { get; set; }
}

public class ImpressionInfo
{
    [JsonProperty("impression_id")]
    public string ImpressionId { get; set; }

    [JsonProperty("metadata")]
    public Metadata Metadata { get; set; }
}

public class Metadata
{
    [JsonProperty("request_id")]
    public string RequestId { get; set; }

    [JsonProperty("params")]
    public Params Params { get; set; }

    [JsonProperty("delivery_zone")]
    public string DeliveryZone { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }

    [JsonProperty("mpid")]
    public string Mpid { get; set; }

    [JsonProperty("spid")]
    public string Spid { get; set; }

    [JsonProperty("quantity_sold")]
    public string QuantitySold { get; set; }

    [JsonProperty("astra_reward")]
    public string AstraReward { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("discount_rate")]
    public string DiscountRate { get; set; }

    [JsonProperty("rating")]
    public string Rating { get; set; }

    [JsonProperty("is_ad")]
    public string IsAd { get; set; }

    [JsonProperty("is_official_store")]
    public string IsOfficialStore { get; set; }

    [JsonProperty("is_trusted_store")]
    public string IsTrustedStore { get; set; }

    [JsonProperty("is_tikinow")]
    public string IsTikinow { get; set; }

    [JsonProperty("is_tikipro")]
    public string IsTikipro { get; set; }

    [JsonProperty("is_astra_plus")]
    public string IsAstraPlus { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }

    [JsonProperty("tiki_verified")]
    public string TikiVerified { get; set; }

    [JsonProperty("flags")]
    public Flags Flags { get; set; }
}

public class Paging
{
    [JsonProperty("total")]
    public string Total { get; set; }

    [JsonProperty("total_text")]
    public string TotalText { get; set; }

    [JsonProperty("per_page")]
    public string PerPage { get; set; }

    [JsonProperty("current_page")]
    public string CurrentPage { get; set; }

    [JsonProperty("last_page")]
    public string LastPage { get; set; }

    [JsonProperty("from")]
    public string From { get; set; }

    [JsonProperty("to")]
    public string To { get; set; }
}

public class Params
{
    [JsonProperty("limit")]
    public string Limit { get; set; }

    [JsonProperty("sort")]
    public string Sort { get; set; }

    [JsonProperty("page")]
    public string Page { get; set; }

    [JsonProperty("category")]
    public string Category { get; set; }
}

public class QuantitySold
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}

public class QueryInfo
{
    [JsonProperty("delivery_zone")]
    public string DeliveryZone { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("ip")]
    public string Ip { get; set; }

    [JsonProperty("user_agent")]
    public string UserAgent { get; set; }

    [JsonProperty("params")]
    public Params Params { get; set; }
}

public class TikiProductList
{
    [JsonProperty("data")]
    public List<Datum> Data { get; set; }

    [JsonProperty("paging")]
    public Paging Paging { get; set; }

    [JsonProperty("widgets")]
    public List<object> Widgets { get; set; }

    [JsonProperty("sort_options")]
    public List<SortOption> SortOptions { get; set; }

    [JsonProperty("experiment_variants")]
    public ExperimentVariants ExperimentVariants { get; set; }

    [JsonProperty("amplitude")]
    public Amplitude Amplitude { get; set; }

    [JsonProperty("trace_id")]
    public string TraceId { get; set; }

    [JsonProperty("open_telemetry_trace_id")]
    public string OpenTelemetryTraceId { get; set; }

    [JsonProperty("query_info")]
    public QueryInfo QueryInfo { get; set; }

    [JsonProperty("layout_type")]
    public string LayoutType { get; set; }
}

public class SortOption
{
    [JsonProperty("display_value")]
    public string DisplayValue { get; set; }

    [JsonProperty("query_value")]
    public string QueryValue { get; set; }

    [JsonProperty("selected")]
    public bool Selected { get; set; }
}

public class VisibleImpressionInfo
{
    [JsonProperty("amplitude")]
    public Amplitude Amplitude { get; set; }
}

