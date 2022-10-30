using YugiohApp.model;
using static YugiohApp.util.Util;
using static YugiohApp.util.SqlUtil;
using System.Diagnostics;

namespace YugiohApp.view {
    public partial class DeckBuilderForm : Form {
        public static List<Card> cardListSearchResult = new List<Card>();
        public List<List<Card>> chunkedList;
        public int numberOfSearchChunks;
        public Card selectedCard { get; set; }
        public static CardSearchMode atkSearchMode = CardSearchMode.ALL;
        public static CardSearchMode defSearchMode = CardSearchMode.ALL;
        public static CardSearchMode levelSearchMode = CardSearchMode.ALL;
        public int cardsInSearchResult;
        public int currentPage;
        public int totalPages;
        public DeckBuilderForm() {
            InitializeComponent();
        }
        public Panel getPanelCard() {
            return this.panelCard;
        }
        public FlowLayoutPanel getFlowLayoutPanelCards() {
            return this.flowLayoutPanelCards;
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            if (textBoxSearch.Text != "") {
                cardListSearchResult = getCardListSearchResult(textBoxSearch.Text);
                cardsInSearchResult = cardListSearchResult.Count;
                /*IEnumerable<Card[]> chuncked = cardListSearchResult.Chunk(25);
                numberOfSearchChunks = chuncked.Count();
                foreach (Card[] chunk in chuncked) {
                    foreach (Card card in chunk) {
                        flowLayoutPanelCards.Controls.Add(new CardUserControl(card));
                    }
                    break;
                }*/
                chunkedList = chunkList(cardListSearchResult, 25);
                currentPage = 1;
                totalPages = chunkedList.Count;
                updateSearchResultPanel();
            }
        }
        private void YugiohForm_Load(object sender, EventArgs e) {
            populateCardTypeComboBox(comboBoxType);
            populateCardRaceComboBox(comboBoxRace);
            populateCardAttributeComboBox(comboBoxAttribute);
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
        private void radioButtonGreaterOrEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelGreaterOrEqual.Checked) {
                levelSearchMode = CardSearchMode.GREATER_OR_EQUAL;
            }
        }
        private void radioButtonEqual_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonLevelEqual.Checked) {
                levelSearchMode = CardSearchMode.EQUAL;
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
                    flowLayoutPanelCards.Controls.Add(new CardUserControl(card));
                }
                labelCardsInSearchResult.Text = cardsInSearchResult.ToString();
                labelCurrentPage.Text = currentPage.ToString();
                labelTotalPages.Text = totalPages.ToString();
            }
        }
    }
}