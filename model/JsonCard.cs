using static YugiohApp.util.Util;
public class JsonCard {
    public Datum[] data { get; set; }
    public JsonCard(Datum[] data) {
        this.data = data;
    }
    public JsonCard() {

    }
}
public class Datum {
    public int id { get; set; }
    public string name { get; set; }
    public string type { get; set; }
    public string desc { get; set; }
    public int atk { get; set; }
    public int def { get; set; }
    public int level { get; set; }
    public string race { get; set; }
    public string attribute { get; set; }
    public Card_Sets[] card_sets { get; set; }
    public Card_Images[] card_images { get; set; }
    public Card_Prices[] card_prices { get; set; }
}
public class Card_Sets {
    public string set_name { get; set; }
    public string set_code { get; set; }
    public string set_rarity { get; set; }
    public string set_rarity_code { get; set; }
    public string set_price { get; set; }
}
public class Card_Images {
    public int id { get; set; }
    public string image_url { get; set; }
    public string image_url_small { get; set; }
}
public class Card_Prices {
    public string cardmarket_price { get; set; }
    public string tcgplayer_price { get; set; }
    public string ebay_price { get; set; }
    public string amazon_price { get; set; }
    public string coolstuffinc_price { get; set; }
}