﻿using YugiohApp.model;

namespace YugiohApp.view {
    public partial class CardUserControl : UserControl {
        public Card card { get; set; }
        private static DeckBuilderForm deckBuilderForm = (DeckBuilderForm)Form.ActiveForm;
        public CardUserControl(Card parCard, bool smallImage, int width, int height) {
            InitializeComponent();
            this.card = parCard;
            this.Size = new Size(width, height);
            if (smallImage) {
                pictureBoxCard.Image = card.smallImage;
            }
            else {
                pictureBoxCard.Image = card.image;
            }
        }
        public CardUserControl(Card parCard, bool smallImage) {
            InitializeComponent();
            this.card = parCard;
            if (smallImage) {
                pictureBoxCard.Image = card.smallImage;
            }
            else {
                pictureBoxCard.Image = card.image;
            }
        }

        private void pictureBoxCard_MouseClick(object sender, MouseEventArgs e) {
            card.loadImage();
            card.loadSmallImage();
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