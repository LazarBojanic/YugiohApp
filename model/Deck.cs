namespace YugiohApp.model {
    public class Deck {
        public string name { get; set; }
        public List<Card> cardList { get; set; }
        public Deck() {
            this.name = "";
            this.cardList = new List<Card>();
        }
        public Deck(string name) {
            this.name = name;
            this.cardList = new List<Card>();
        }
        public Deck(string name, List<Card> cardList) {
            this.name = name;
            this.cardList = cardList;
        }
        public Deck sortDeck() {
            cardList.Sort((x, y) => x.type.CompareTo(y.type));
            return this;
        }
    }
}