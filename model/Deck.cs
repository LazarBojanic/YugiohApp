namespace YugiohApp.model {
    public class Deck {
        private static Deck instance = null;
        private static readonly object threadLock = new object();
        public string name { get; set; }
        public List<Card> cardList { get; set; }
        public Deck() {
            this.name = "";
            this.cardList = new List<Card>();
        }
        public Deck(string name, List<Card> cardList) {
            this.name = name;
            this.cardList = cardList;
        }
        public static Deck getInstance() {
            lock (threadLock) {
                if (instance == null) {
                    instance = new Deck();
                }
                return instance;
            }
        }
    }
}