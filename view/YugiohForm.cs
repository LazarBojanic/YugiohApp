using FuzzySharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YugiohApp.model;
using static YugiohApp.util.YugiohUtil;

namespace YugiohApp.view {
    public partial class YugiohForm : Form {
        private static string allCardsJson = "";
        private List<Card> cardListSearchResult;
        public Card selectedCard { get; set; }
        public YugiohForm() {
            InitializeComponent();
            allCardsJson = File.ReadAllText("cards\\allCards.json");
            cardListSearchResult = new List<Card>();
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            if (textBoxSearch.Text != "") {
                cardListSearchResult = getCardsByName(allCardsJson, textBoxSearch.Text);
            }
            populateFlowLayoutPanel(flowLayoutPanelCards, cardListSearchResult);
        }
        public Panel getPanelCard() {
            return this.panelCard;
        }
        public Label getLabelId() {
            return this.labelId;
        }
        public FlowLayoutPanel getFlowLayoutPanelDeck() {
            return this.flowLayoutPanelDeck;
        }

        private void YugiohForm_Load(object sender, EventArgs e) {
            //MessageBox.Show(flowLayoutPanelDeck.Size.ToString());
        }

        private void buttonAddCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Add(selectedCard);
            CardUserControl cardUserControlToAdd = new CardUserControl(selectedCard);
            cardUserControlToAdd.Size = new Size(74, 108);
            flowLayoutPanelDeck.Controls.Add(cardUserControlToAdd);
        }

        private void buttonRemoveCard_Click(object sender, EventArgs e) {
            Deck.getInstance().cardList.Remove(selectedCard);
            foreach(CardUserControl cardUserControl in flowLayoutPanelDeck.Controls) {
                if (cardUserControl.card.data[0].id == selectedCard.data[0].id) {
                    flowLayoutPanelDeck.Controls.Remove(cardUserControl);
                    return;
                }
            }
        }
    }
}