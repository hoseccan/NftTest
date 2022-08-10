using System;
using System.Collections.Generic;

public class OpenSea
{
    public int id;
    public int num_sales;
    public object background_color;
    public string image_url;
    public string image_preview_url;
    public string image_thumbnail_url;
    public string image_original_url;
    public object animation_url;
    public object animation_original_url;
    public string name;
    public string description;
    public object external_link;
    public AssetContract asset_contract;
    public string permalink;
    public Collection collection;
    public int decimals;
    public string token_metadata;
    public bool is_nsfw;
    public Owner owner;
    public object seaport_sell_orders;
    public Creator creator;
    public List<Trait> traits;
    public LastSale last_sale;
    public object top_bid;
    public object listing_date;
    public bool is_presale;
    public object transfer_fee_payment_token;
    public object transfer_fee;
    public List<object> related_assets;
    public object orders;
    public List<object> auctions;
    public bool supports_wyvern;
    public List<TopOwnership> top_ownerships;
    public object ownership;
    public object highest_buyer_commitment;
    public string token_id;
}

public class Asset
{
    public int decimals;
    public string token_id;
}

public class AssetContract
{
    public string address;
    public string asset_contract_type;
    public DateTime created_date;
    public string name;
    public string nft_version;
    public object opensea_version;
    public int owner;
    public string schema_name;
    public string symbol;
    public string total_supply;
    public string description;
    public string external_link;
    public string image_url;
    public bool default_to_fiat;
    public int dev_buyer_fee_basis_points;
    public int dev_seller_fee_basis_points;
    public bool only_proxied_transfers;
    public int opensea_buyer_fee_basis_points;
    public int opensea_seller_fee_basis_points;
    public int buyer_fee_basis_points;
    public int seller_fee_basis_points;
    public string payout_address;
}

public class Collection
{
    public List<PaymentToken> payment_tokens;
    public List<PrimaryAssetContract> primary_asset_contracts;
    public Trait traits;   //Traits
    public Stats stats;
    public string banner_image_url;
    public object chat_url;
    public DateTime created_date;
    public bool default_to_fiat;
    public string description;
    public string dev_buyer_fee_basis_points;
    public string dev_seller_fee_basis_points;
    public string discord_url;
    public DisplayData display_data;
    public string external_url;
    public bool featured;
    public string featured_image_url;
    public bool hidden;
    public string safelist_request_status;
    public string image_url;
    public bool is_subject_to_whitelist;
    public string large_image_url;
    public object medium_username;
    public string name;
    public bool only_proxied_transfers;
    public string opensea_buyer_fee_basis_points;
    public string opensea_seller_fee_basis_points;
    public string payout_address;
    public bool require_email;
    public object short_description;
    public string slug;
    public object telegram_url;
    public string twitter_username;
    public string instagram_username;
    public object wiki_url;
    public bool is_nsfw;
}

public class Creator
{
    public User user;
    public string profile_img_url;
    public string address;
    public string config;
}

public class DisplayData
{
    public string card_display_style;
}

public class LastSale
{
    public Asset asset;
    public object asset_bundle;
    public string event_type;
    public DateTime event_timestamp;
    public object auction_type;
    public string total_price;
    public PaymentToken payment_token;
    public object transaction;
    public DateTime created_date;
    public string quantity;
}

public class Owner
{
    public User user;
    public string profile_img_url;
    public string address;
    public string config;
}

public class PaymentToken
{
    public int id;
    public string symbol;
    public string address;
    public string image_url;
    public string name;
    public int decimals;
    public double eth_price;
    public double usd_price;
}

public class PaymentToken2
{
    public string symbol;
    public string address;
    public string image_url;
    public string name;
    public int decimals;
    public string eth_price;
    public string usd_price;
}

public class PrimaryAssetContract
{
    public string address;
    public string asset_contract_type;
    public DateTime created_date;
    public string name;
    public string nft_version;
    public object opensea_version;
    public int owner;
    public string schema_name;
    public string symbol;
    public string total_supply;
    public string description;
    public string external_link;
    public string image_url;
    public bool default_to_fiat;
    public int dev_buyer_fee_basis_points;
    public int dev_seller_fee_basis_points;
    public bool only_proxied_transfers;
    public int opensea_buyer_fee_basis_points;
    public int opensea_seller_fee_basis_points;
    public int buyer_fee_basis_points;
    public int seller_fee_basis_points;
    public string payout_address;
}

public class Stats
{
    public double one_day_volume;
    public double one_day_change;
    public double one_day_sales;
    public double one_day_average_price;
    public double seven_day_volume;
    public double seven_day_change;
    public double seven_day_sales;
    public double seven_day_average_price;
    public double thirty_day_volume;
    public double thirty_day_change;
    public double thirty_day_sales;
    public double thirty_day_average_price;
    public double total_volume;
    public double total_sales;
    public double total_supply;
    public double count;
    public int num_owners;
    public double average_price;
    public int num_reports;
    public double market_cap;
    public int floor_price;
}

public class TopOwnership
{
    public Owner owner;
    public string quantity;
    public DateTime created_date;
}

public class Trait
{
    public string trait_type;
    public string value;
    public object display_type;
    public object max_value;
    public int trait_count;
    public object order;
}

public class User
{
    public object username;
}

