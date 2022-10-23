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
using static YugiohApp.util.YugiohUtil;

namespace YugiohApp.view {
    public partial class YugiohForm : Form {
        private static string allCardsJson = File.ReadAllText("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cards\\allCards.json");
        private List<Card> cardList;
        public YugiohForm() {
            InitializeComponent();
            pictureBoxCard1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCard2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCard3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCard4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCard5.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxCard1.Image = Image.FromFile("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\1475311_image.jpg");
            pictureBoxCard2.Image = Image.FromFile("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\1482001_image.jpg");
            pictureBoxCard3.Image = Image.FromFile("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\1487805_image.jpg");
            pictureBoxCard4.Image = Image.FromFile("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\1498130_image.jpg");
            pictureBoxCard5.Image = Image.FromFile("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\cardImages\\1508649_image.jpg");

            cardList = new List<Card>();
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            if(textBoxSearch.Text != "") {
                cardList = getCardsByName(allCardsJson, textBoxSearch.Text, labelFuzzRatio);
            }
            //populateListView(dataGridViewCards, cardList);
            populateFlowLayoutPanel(flowLayoutPanelCards, cardList);
        }
    }
}