namespace YugiohApp.view {
    public partial class CardDetailsUserControl : UserControl {
        private Image cardImage;
        private Card card;
        public CardDetailsUserControl(Card parCard) {
            InitializeComponent();
            this.card = parCard;
            cardImage = Image.FromFile($"{Properties.Settings.Default.cardImagesPath}{card.data[0].id}_image.jpg");
            pictureBoxCard.Image = cardImage;
            labelName.Text = card.data[0].name;
            labelDescription.Text = card.data[0].desc;
            labelAtk.Text = "ATK/ " + card.data[0].atk.ToString();
            labelDef.Text = "DEF/ " + card.data[0].def.ToString();
        }
    }
}