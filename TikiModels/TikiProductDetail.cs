using Newtonsoft.Json;

namespace ProGCoder_Tiki_Crawl_Tool.TikiModels;

#nullable disable
public class Amplitude
{
    [JsonProperty("is_authentic")]
    public bool IsAuthentic { get; set; }

    [JsonProperty("is_freeship_xtra")]
    public bool IsFreeshipXtra { get; set; }

    [JsonProperty("is_hero")]
    public bool IsHero { get; set; }

    [JsonProperty("is_top_brand")]
    public bool IsTopBrand { get; set; }

    [JsonProperty("return_reason")]
    public string ReturnReason { get; set; }
}

public class Attribute
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}

public class Badge
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }
}

public class BadgesNew
{
    [JsonProperty("placement")]
    public string Placement { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("index")]
    public string Index { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("icon_width")]
    public string IconWidth { get; set; }

    [JsonProperty("icon_height")]
    public string IconHeight { get; set; }

    [JsonProperty("text_color")]
    public object TextColor { get; set; }

    [JsonProperty("background_color")]
    public object BackgroundColor { get; set; }

    [JsonProperty("href")]
    public object Href { get; set; }

    [JsonProperty("text")]
    public object Text { get; set; }
}

public class BadgesV3
{
    [JsonProperty("placement")]
    public string Placement { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("index")]
    public string Index { get; set; }

    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("icon_width")]
    public string IconWidth { get; set; }

    [JsonProperty("icon_height")]
    public string IconHeight { get; set; }

    [JsonProperty("text_color")]
    public object TextColor { get; set; }

    [JsonProperty("background_color")]
    public object BackgroundColor { get; set; }

    [JsonProperty("href")]
    public object Href { get; set; }

    [JsonProperty("text")]
    public object Text { get; set; }
}

public class Benefit
{
    [JsonProperty("icon")]
    public string Icon { get; set; }

    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("sub_text")]
    public List<object> SubText { get; set; }

    [JsonProperty("cta")]
    public Cta Cta { get; set; }
}

public class Body
{
    [JsonProperty("label")]
    public string Label { get; set; }

    [JsonProperty("content")]
    public List<string> Content { get; set; }
}

public class Brand
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("slug")]
    public string Slug { get; set; }
}

public class Breadcrumb
{
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("category_id")]
    public string CategoryId { get; set; }
}

public class Categories
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("is_leaf")]
    public bool IsLeaf { get; set; }
}

public class ConfigurableOption
{
    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("position")]
    public string Position { get; set; }

    [JsonProperty("show_preview_image")]
    public bool ShowPreviewImage { get; set; }

    [JsonProperty("values")]
    public List<Value> Values { get; set; }
}

public class ConfigurableProduct
{
    [JsonProperty("child_id")]
    public string ChildId { get; set; }

    [JsonProperty("discount_rate")]
    public string DiscountRate { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("images")]
    public List<Image> Images { get; set; }

    [JsonProperty("inventory_status")]
    public string InventoryStatus { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("option1")]
    public string Option1 { get; set; }

    [JsonProperty("original_price")]
    public string OriginalPrice { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("selected")]
    public bool Selected { get; set; }

    [JsonProperty("seller")]
    public Seller Seller { get; set; }

    [JsonProperty("sku")]
    public string Sku { get; set; }

    [JsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }
}

public class Cta
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("text_button")]
    public string TextButton { get; set; }
}

public class CurrentSeller
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("sku")]
    public string Sku { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("logo")]
    public string Logo { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("product_id")]
    public string ProductId { get; set; }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }

    [JsonProperty("is_best_store")]
    public bool IsBestStore { get; set; }

    [JsonProperty("is_offline_installment_supported")]
    public object IsOfflineInstallmentSupported { get; set; }
}

public class Image
{
    [JsonProperty("base_url")]
    public string BaseUrl { get; set; }

    [JsonProperty("is_gallery")]
    public bool IsGallery { get; set; }

    [JsonProperty("label")]
    public object Label { get; set; }

    [JsonProperty("large_url")]
    public string LargeUrl { get; set; }

    [JsonProperty("medium_url")]
    public string MediumUrl { get; set; }

    [JsonProperty("position")]
    public object Position { get; set; }

    [JsonProperty("small_url")]
    public string SmallUrl { get; set; }

    [JsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }
}

public class Inventory
{
    [JsonProperty("product_virtual_type")]
    public object ProductVirtualType { get; set; }

    [JsonProperty("fulfillment_type")]
    public string FulfillmentType { get; set; }
}

public class OtherSeller
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("link")]
    public string Link { get; set; }

    [JsonProperty("logo")]
    public string Logo { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("product_id")]
    public string ProductId { get; set; }

    [JsonProperty("store_id")]
    public string StoreId { get; set; }
}

public class PriceComparison
{
    [JsonProperty("sub_title")]
    public string SubTitle { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}

public class QuantitySold
{
    [JsonProperty("text")]
    public string Text { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }
}

public class ReturnPolicy
{
    [JsonProperty("body")]
    public List<Body> Body { get; set; }

    [JsonProperty("cta")]
    public Cta Cta { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }
}

public class TikiProductDetail
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("master_id")]
    public string MasterId { get; set; }

    [JsonProperty("sku")]
    public string Sku { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("url_key")]
    public string UrlKey { get; set; }

    [JsonProperty("url_path")]
    public string UrlPath { get; set; }

    [JsonProperty("short_url")]
    public string ShortUrl { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("book_cover")]
    public object BookCover { get; set; }

    [JsonProperty("short_description")]
    public string ShortDescription { get; set; }

    [JsonProperty("price")]
    public string Price { get; set; }

    [JsonProperty("list_price")]
    public string ListPrice { get; set; }

    [JsonProperty("original_price")]
    public string OriginalPrice { get; set; }

    [JsonProperty("badges")]
    public List<Badge> Badges { get; set; }

    [JsonProperty("badges_new")]
    public List<BadgesNew> BadgesNew { get; set; }

    [JsonProperty("badges_v3")]
    public List<BadgesV3> BadgesV3 { get; set; }

    [JsonProperty("tracking_info")]
    public TrackingInfo TrackingInfo { get; set; }

    [JsonProperty("discount")]
    public string Discount { get; set; }

    [JsonProperty("discount_rate")]
    public string DiscountRate { get; set; }

    [JsonProperty("rating_average")]
    public string RatingAverage { get; set; }

    [JsonProperty("review_count")]
    public string ReviewCount { get; set; }

    [JsonProperty("review_text")]
    public string ReviewText { get; set; }

    [JsonProperty("favourite_count")]
    public string FavouriteCount { get; set; }

    [JsonProperty("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonProperty("has_ebook")]
    public bool HasEbook { get; set; }

    [JsonProperty("inventory_status")]
    public string InventoryStatus { get; set; }

    [JsonProperty("inventory_type")]
    public string InventoryType { get; set; }

    [JsonProperty("productset_group_name")]
    public string ProductsetGroupName { get; set; }

    [JsonProperty("is_fresh")]
    public bool IsFresh { get; set; }

    [JsonProperty("seller")]
    public object Seller { get; set; }

    [JsonProperty("is_flower")]
    public bool IsFlower { get; set; }

    [JsonProperty("has_buynow")]
    public bool HasBuynow { get; set; }

    [JsonProperty("is_gift_card")]
    public bool IsGiftCard { get; set; }

    [JsonProperty("salable_type")]
    public object SalableType { get; set; }

    [JsonProperty("data_version")]
    public string DataVersion { get; set; }

    [JsonProperty("day_ago_created")]
    public string DayAgoCreated { get; set; }

    [JsonProperty("all_time_quantity_sold")]
    public string AllTimeQuantitySold { get; set; }

    [JsonProperty("meta_title")]
    public string MetaTitle { get; set; }

    [JsonProperty("meta_description")]
    public string MetaDescription { get; set; }

    [JsonProperty("meta_keywords")]
    public string MetaKeywords { get; set; }

    [JsonProperty("is_baby_milk")]
    public bool IsBabyMilk { get; set; }

    [JsonProperty("is_acoholic_drink")]
    public bool IsAcoholicDrink { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("images")]
    public List<Image> Images { get; set; }

    [JsonProperty("warranty_policy")]
    public object WarrantyPolicy { get; set; }

    [JsonProperty("brand")]
    public Brand Brand { get; set; }

    [JsonProperty("current_seller")]
    public CurrentSeller CurrentSeller { get; set; }

    [JsonProperty("other_sellers")]
    public List<OtherSeller> OtherSellers { get; set; }

    [JsonProperty("specifications")]
    public List<Specification> Specifications { get; set; }

    [JsonProperty("price_comparison")]
    public PriceComparison PriceComparison { get; set; }

    [JsonProperty("product_links")]
    public List<object> ProductLinks { get; set; }

    [JsonProperty("gift_item_title")]
    public string GiftItemTitle { get; set; }

    [JsonProperty("configurable_options")]
    public List<ConfigurableOption> ConfigurableOptions { get; set; }

    [JsonProperty("configurable_products")]
    public List<ConfigurableProduct> ConfigurableProducts { get; set; }

    [JsonProperty("services_and_promotions")]
    public List<object> ServicesAndPromotions { get; set; }

    [JsonProperty("promitions")]
    public List<object> Promitions { get; set; }

    [JsonProperty("stock_item")]
    public StockItem StockItem { get; set; }

    [JsonProperty("quantity_sold")]
    public QuantitySold QuantitySold { get; set; }

    [JsonProperty("categories")]
    public Categories Categories { get; set; }

    [JsonProperty("breadcrumbs")]
    public List<Breadcrumb> Breadcrumbs { get; set; }

    [JsonProperty("installment_info_v2")]
    public object InstallmentInfoV2 { get; set; }

    [JsonProperty("is_seller_in_chat_whitelist")]
    public bool IsSellerInChatWhitelist { get; set; }

    [JsonProperty("inventory")]
    public Inventory Inventory { get; set; }

    [JsonProperty("warranty_info")]
    public List<WarrantyInfo> WarrantyInfo { get; set; }

    [JsonProperty("return_and_exchange_policy")]
    public string ReturnAndExchangePolicy { get; set; }

    [JsonProperty("is_tier_pricing_available")]
    public bool IsTierPricingAvailable { get; set; }

    [JsonProperty("is_tier_pricing_eligible")]
    public bool IsTierPricingEligible { get; set; }

    [JsonProperty("benefits")]
    public List<Benefit> Benefits { get; set; }

    [JsonProperty("return_policy")]
    public ReturnPolicy ReturnPolicy { get; set; }

    public string CategoryId { get; set; }
}

public class Seller
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
}

public class Specification
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("attributes")]
    public List<Attribute> Attributes { get; set; }
}

public class StockItem
{
    [JsonProperty("max_sale_qty")]
    public string MaxSaleQty { get; set; }

    [JsonProperty("min_sale_qty")]
    public string MinSaleQty { get; set; }

    [JsonProperty("preorder_date")]
    public object PreorderDate { get; set; }

    [JsonProperty("qty")]
    public string Qty { get; set; }
}

public class TrackingInfo
{
    [JsonProperty("amplitude")]
    public Amplitude Amplitude { get; set; }
}

public class Value
{
    [JsonProperty("label")]
    public string Label { get; set; }
}

public class WarrantyInfo
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("value")]
    public string Value { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }
}

