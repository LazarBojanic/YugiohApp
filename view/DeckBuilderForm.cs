using YugiohApp.model;
using static YugiohApp.util.Util;
using static YugiohApp.util.SqlUtil;
using System.Diagnostics;

namespace YugiohApp.view {
    public partial class DeckBuilderForm : Form {
        private string allCardsJson;
        //private static List<JsonCard> cardListSearchResult = new List<JsonCard>();
        public static List<JsonCard> allCardsListFromJson;
        public static List<Card> allCardsListFromSQL;
        public static List<Card> cardListSearchResult = new List<Card>();
        public Card selectedCard { get; set; }
        private static Stopwatch stopwatchJson = new Stopwatch();
        private static Stopwatch stopwatchSQL = new Stopwatch();
        public DeckBuilderForm() {
            InitializeComponent();
            /*stopwatchJson.Start();
            allCardsJson = File.ReadAllText($"{Properties.Settings.Default.cardsPath}allCards.json");
            allCardsListFromJson = getAllCardsList(allCardsJson);
            stopwatchJson.Stop();
            stopwatchSQL.Start();
            allCardsListFromSQL = getAllCardsFromSQLList();
            stopwatchSQL.Stop();*/
        }
        public Panel getPanelCard() {
            return this.panelCard;
        }
        public FlowLayoutPanel getFlowLayoutPanelCards() {
            return this.flowLayoutPanelCards;
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            /*buttonSearch.Enabled = false;
            flowLayoutPanelCards.SuspendLayout();
            if (!textBoxSearch.Text.Equals("")) {
                fillSearchFlowLayoutPanel(textBoxSearch.Text, flowLayoutPanelCards);
            }
            flowLayoutPanelCards.ResumeLayout();
            buttonSearch.Enabled = true;*/
            cardListSearchResult = getCardListSearchResult(textBoxSearch.Text, flowLayoutPanelCards);
            MessageBox.Show(getListString(cardListSearchResult));
        }
        private void YugiohForm_Load(object sender, EventArgs e) {
        }

        /*private void buttonAddCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Add(selectedCard);
            CardUserControl cardUserControlToAdd = new CardUserControl(selectedCard);
            cardUserControlToAdd.Size = new Size(74, 108);
            flowLayoutPanelDeck.Controls.Add(cardUserControlToAdd);
        }*/

        /*private void buttonRemoveCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Remove(selectedCard);
            foreach(CardUserControl cardUserControl in flowLayoutPanelDeck.Controls) {
                if (cardUserControl.card.data[0].id == selectedCard.data[0].id) {
                    flowLayoutPanelDeck.Controls.Remove(cardUserControl);
                    return;
                }
            }
        }*/

        private void buttonSQL_Click(object sender, EventArgs e) {
            /*labelJsonTime.Text = stopwatchJson.ElapsedMilliseconds.ToString();
            labelSQLTime.Text = stopwatchSQL.ElapsedMilliseconds.ToString();*/

        }
        private void buttonAddCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Add(selectedCard);
            CardUserControl cardUserControlToAdd = new CardUserControl(selectedCard);
            cardUserControlToAdd.Size = new Size(74, 108);
            flowLayoutPanelDeck.Controls.Add(cardUserControlToAdd);
        }
        private void buttonRemoveCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Remove(selectedCard);
            foreach (CardUserControl cardUserControl in flowLayoutPanelDeck.Controls) {
                if (cardUserControl.card.id == selectedCard.id) {
                    flowLayoutPanelDeck.Controls.Remove(cardUserControl);
                    return;
                }
            }
        }
    }
}