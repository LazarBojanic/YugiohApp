using YugiohApp.model;

namespace YugiohApp.view {
    public partial class CardUserControl : UserControl {
        public Card card { get; set; }
        private static DeckBuilderForm deckBuilderForm = (DeckBuilderForm)Form.ActiveForm;
        public CardUserControl(Card parCard) {
            InitializeComponent();
            this.card = parCard;
            pictureBoxCard.Image = card.image;
        }
        public CardUserControl() {

        }

        private void pictureBoxCard_MouseClick(object sender, MouseEventArgs e) {
            deckBuilderForm.getPanelCard().Controls.Clear();
            deckBuilderForm.getPanelCard().Controls.Add(new CardDetailsUserControl(card));
            deckBuilderForm.selectedCard = card;
        }

        private void pictureBoxCard_MouseDoubleClick(object sender, MouseEventArgs e) {
            /*CardUserControl cardUserControlToAdd = new CardUserControl(this.card);
            cardUserControlToAdd.Size = new Size(74, 108);
            yugiohForm.getFlowLayoutPanelDeck().Controls.Add(cardUserControlToAdd);*/
        }
    }
}