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
        private Image cardImage;
        private Card card;
        public CardUserControl(Card parCard) {
            InitializeComponent();
            this.card = parCard;
            cardImage = Image.FromFile($"C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\{card.data[0].id}_image.jpg");
            pictureBoxCard.Image = cardImage;
            
        }

        private void pictureBoxCard_MouseClick(object sender, MouseEventArgs e) {
            YugiohForm yugiohForm = (YugiohForm)Form.ActiveForm;
            yugiohForm.getPanelCard().Controls.Clear();
            yugiohForm.getPanelCard().Controls.Add(new CardDetailsUserControl(card));
        }
    }
}