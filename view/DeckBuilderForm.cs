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
using System.Diagnostics;
using YugiohApp.model;
using YugiohApp.util;
using static YugiohApp.util.Util;
using static YugiohApp.util.SqlUtil;
using Process = System.Diagnostics.Process;

namespace YugiohApp.view {
    public partial class DeckBuilderForm : Form {
        private string allCardsJson { get; set; }
        private List<Card> cardListSearchResult { get; set; }
        public static List<Card> allCardsList { get; set; }
        public Card selectedCard { get; set; }
        public string allCardSetsJson { get; set; }
        public DeckBuilderForm() {
            InitializeComponent();
            allCardsJson = File.ReadAllText($"{Properties.Settings.Default.cardsPath}allCards.json");
            allCardsList = getAllCardsList(allCardsJson);
            cardListSearchResult = new List<Card>();
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            buttonSearch.Enabled = false;
            flowLayoutPanelCards.SuspendLayout();
            if (!textBoxSearch.Text.Equals("")) {
                fillSearchFlowLayoutPanel(textBoxSearch.Text, flowLayoutPanelCards);
            }
            flowLayoutPanelCards.ResumeLayout();
            buttonSearch.Enabled = true;
        }
        public Panel getPanelCard() {
            return this.panelCard;
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
        private void YugiohForm_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Process process in Process.GetProcessesByName("YugiohApp")) {
                process.Kill();
            }          
        }
    }
}