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

            cardList = new List<Card>();
        }
        private void buttonSearch_Click(object sender, EventArgs e) {
            if(textBoxSearch.Text != "") {
                cardList = getCardsByName(allCardsJson, textBoxSearch.Text);
            }
            //populateListView(dataGridViewCards, cardList);
            populateFlowLayoutPanel(flowLayoutPanelCards, cardList);
        }
        public Panel getPanelCard() {
            return this.panelCard;
        }
    }
}