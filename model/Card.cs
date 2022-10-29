namespace YugiohApp.model {
    public class Card {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string desc { get; set; }
        public int atk { get; set; }
        public int def { get; set; }
        public int level { get; set; }
        public string race { get; set; }
        public string attribute { get; set; }
        public List<CardSet> cardSets { get; set; }
        public decimal priceCardMarket { get; set; }
        public decimal priceTCGPlayer { get; set; }
        public decimal priceEbay { get; set; }
        public decimal priceAmazon { get; set; }
        public decimal priceCoolStuffInc { get; set; }
        public Image image { get; set; }
        public Image smallImage { get; set; }
        public Card(int id, string name, string type, string desc, int atk, int def, int level, string race, string attribute, List<CardSet> cardSets, decimal priceCardMarket, decimal priceTCGPlayer, decimal priceEbay, decimal priceAmazon, decimal priceCoolStuffInc) {
            this.id = id;
            this.name = name;
            this.type = type;
            this.desc = desc;
            this.atk = atk;
            this.def = def;
            this.level = level;
            this.race = race;
            this.attribute = attribute;
            this.cardSets = cardSets;
            this.priceCardMarket = priceCardMarket;
            this.priceTCGPlayer = priceTCGPlayer;
            this.priceEbay = priceEbay;
            this.priceAmazon = priceAmazon;
            this.priceCoolStuffInc = priceCoolStuffInc;
        }
        public Card() {

        }
        public void loadImage() {
            image = Image.FromFile($"{Properties.Settings.Default.cardImagesPath}{id}_image.jpg");

        }
        public void loadSmallImage() {
            smallImage = Image.FromFile($"{Properties.Settings.Default.smallCardImagesPath}{id}_smallImage.png");
        }
    }
}