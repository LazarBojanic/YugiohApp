namespace YugiohApp.model {
    public class CardSet {
        public string code { get; set; }
        public string name { get; set; }
        public string rarity { get; set; }
        public string rarityCode { get; set; }
        public decimal price { get; set; }
        public int cardCount { get; set; }
        public DateTime releaseDateTCG { get; set; }
        public CardSet(string code, string name, string rarity, string rarityCode, decimal price, int cardCount, DateTime releaseDateTCG) {
            this.code = code;
            this.name = name;
            this.rarity = rarity;
            this.rarityCode = rarityCode;
            this.price = price;
            this.cardCount = cardCount;
            this.releaseDateTCG = releaseDateTCG;
        }
        public CardSet() {

        }
    }
}