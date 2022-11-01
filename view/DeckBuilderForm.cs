using YugiohApp.model;
using static YugiohApp.util.Util;
using static YugiohApp.util.SqlUtil;
using System.Diagnostics;

namespace YugiohApp.view {
    public partial class DeckBuilderForm : Form {
        public Deck deck { get; set; }
        public static List<Card> cardListSearchResult;
        public List<List<Card>> chunkedList;
        public int numberOfSearchChunks;
        public Card selectedCard { get; set; }
        public static string nameOrDescSearch = "";
        public static string typeSearch = "";
        public static string raceSearch = "";
        public static string attributeSearch = "";
        public static int atkSearch = 0;
        public static int defSearch = 0;
        public static int levelSearch = 0;
        public static CardSearchMode atkSearchMode = CardSearchMode.ALL;
        public static CardSearchMode defSearchMode = CardSearchMode.ALL;
        public static CardSearchMode levelSearchMode = CardSearchMode.ALL;
        public int cardsInSearchResult;
        public int currentPage;
        public int totalPages;
        public DeckBuilderForm() {
            InitializeComponent();
            cardListSearchResult = new List<Card>();
        }
        public Panel getPanelCard() {
            return this.panelCard;
        }
        public FlowLayoutPanel getFlowLayoutPanelCards() {
            return this.flowLayoutPanelCards;
        }
        private async void buttonSearch_Click(object sender, EventArgs e) {
            cardListSearchResult.Clear();
            nameOrDescSearch = textBoxSearch.Text;
            typeSearch = comboBoxType.Text;
            raceSearch = comboBoxRace.Text;
            attributeSearch = comboBoxAttribute.Text;
            atkSearch = Convert.ToInt32(textBoxAtk.Text);
            defSearch = Convert.ToInt32(textBoxDef.Text);
            levelSearch = Convert.ToInt32(textBoxLevel.Text);
            //cardListSearchResult = await Task.Run(() => getCardListSearchResult());
            cardListSearchResult = await Task.Run(() => getSimpleCardListSearchResult());
            Task.WaitAll();
            cardsInSearchResult = cardListSearchResult.Count;
            chunkedList = chunkList(cardListSearchResult, 25);
            currentPage = 1;
            totalPages = chunkedList.Count;
            updateSearchResultPanel();
        }
        
        private void YugiohForm_Load(object sender, EventArgs e) {
            populateCardTypeComboBox(comboBoxType);
            populateCardRaceComboBox(comboBoxRace);
            populateCardAttributeComboBox(comboBoxAttribute);
            deck = loadDeck("testDeck");
            if (deck == null) {
                flowLayoutPanelDeck.Controls.Clear();
            }
            else {
                populateFlowLayoutPanelDeckWithDeckCards(deck, flowLayoutPanelDeck);
            }
        }
        private void buttonAddCard_Click(object sender, EventArgs e) {
            deck.cardList.Add(selectedCard);
            CardUserControl cardUserControlToAdd = new CardUserControl(selectedCard, false);
            cardUserControlToAdd.Size = new Size(74, 108);
            flowLayoutPanelDeck.Controls.Add(cardUserControlToAdd);
        }
        private void buttonRemoveCard_Click(object sender, EventArgs e) {
            deck.cardList.Remove(selectedCard);
            foreach (CardUserControl cardUserControl in flowLayoutPanelDeck.Controls) {
                if (cardUserControl.card.id == selectedCard.id) {
                    flowLayoutPanelDeck.Controls.Remove(cardUserControl);
                    return;
                }
            }
        }
        

        private void buttonPrevious_Click(object sender, EventArgs e) {
            if (currentPage - 1 > 0) {
                currentPage--;
                updateSearchResultPanel();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e) {
            if (currentPage + 1 <= totalPages) {
                currentPage++;
                updateSearchResultPanel();
            }
        }
        public void updateSearchResultPanel() {
            flowLayoutPanelCards.Controls.Clear();
            if (cardListSearchResult.Count != 0) {
                foreach (Card card in chunkedList[currentPage - 1]) {
                    flowLayoutPanelCards.Controls.Add(new CardUserControl(card, true));
                }
                labelCardsInSearchResult.Text = cardsInSearchResult.ToString();
                labelCurrentPage.Text = currentPage.ToString();
                labelTotalPages.Text = totalPages.ToString();
            }
        }

        private void radioButtonAtkAll_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonAtkLesserOrEqual.Checked) {
                atkSearchMode = CardSearchMode.ALL;
            }
        }

        private void radioButtonAtkLesserOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonAtkLesserOrEqual.Checked) {
                atkSearchMode = CardSearchMode.LESSER_OR_EQUAL;
            }
        }

        private void radioButtonAtkGreaterOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonAtkGreaterOrEqual.Checked) {
                atkSearchMode = CardSearchMode.GREATER_OR_EQUAL;
            }
        }

        private void radioButtonAtkEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonAtkEqual.Checked) {
                atkSearchMode = CardSearchMode.EQUAL;
            }
        }

        private void radioButtonDefAll_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonDefLesserOrEqual.Checked) {
                defSearchMode = CardSearchMode.ALL;
            }
        }

        private void radioButtonDefLesserOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonDefLesserOrEqual.Checked) {
                defSearchMode = CardSearchMode.LESSER_OR_EQUAL;
            }
        }

        private void radioButtonDefGreaterOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonDefGreaterOrEqual.Checked) {
                defSearchMode = CardSearchMode.GREATER_OR_EQUAL;
            }
        }

        private void radioButtonDefEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonDefEqual.Checked) {
                defSearchMode = CardSearchMode.EQUAL;
            }
        }

        private void radioButtonLevelAll_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelLesserOrEqual.Checked) {
                levelSearchMode = CardSearchMode.ALL;
            }
        }

        private void radioButtonLevelLesserOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelLesserOrEqual.Checked) {
                levelSearchMode = CardSearchMode.LESSER_OR_EQUAL;
            }
        }

        private void radioButtonLevelGreaterOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelGreaterOrEqual.Checked) {
                levelSearchMode = CardSearchMode.GREATER_OR_EQUAL;
            }
        }

        private void radioButtonLevelEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelEqual.Checked) {
                levelSearchMode = CardSearchMode.EQUAL;
            }
        }
    }
}