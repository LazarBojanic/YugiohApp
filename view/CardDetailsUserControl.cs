using YugiohApp.model;

namespace YugiohApp.view {
    public partial class CardDetailsUserControl : UserControl {
        public Card card { get; set; }
        public CardDetailsUserControl(Card parCard) {
            InitializeComponent();
            this.card = parCard;
            pictureBoxCard.Image = card.image;
            labelName.Text = card.name;
            labelDescription.Text = card.desc;
            labelAtk.Text = "ATK/ " + card.atk.ToString();
            labelDef.Text = "DEF/ " + card.def.ToString();
        }
    }
}