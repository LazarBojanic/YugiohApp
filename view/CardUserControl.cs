﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YugiohApp.view {
    public partial class CardUserControl : UserControl {
        public Image cardImage { get; set; }
        public Card card { get; set; }
        private static YugiohForm yugiohForm = (YugiohForm)Form.ActiveForm;
        public CardUserControl(Card parCard) {
            InitializeComponent();
            this.card = parCard;
            cardImage = Image.FromFile($"C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\{card.data[0].id}_image.jpg");
            pictureBoxCard.Image = cardImage;
            
        }

        private void pictureBoxCard_MouseClick(object sender, MouseEventArgs e) {
            yugiohForm.getPanelCard().Controls.Clear();
            yugiohForm.getPanelCard().Controls.Add(new CardDetailsUserControl(card));
            yugiohForm.getLabelId().Text = card.data[0].id.ToString();
            yugiohForm.selectedCard = card;
        }

        private void pictureBoxCard_MouseDoubleClick(object sender, MouseEventArgs e) {
            /*CardUserControl cardUserControlToAdd = new CardUserControl(this.card);
            cardUserControlToAdd.Size = new Size(74, 108);
            yugiohForm.getFlowLayoutPanelDeck().Controls.Add(cardUserControlToAdd);*/
        }
    }
}