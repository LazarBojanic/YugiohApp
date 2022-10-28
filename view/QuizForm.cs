using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YugiohApp.util;

namespace YugiohApp.view {
    public partial class QuizForm : Form {
        private static string usersGuess = "";
        private Random random;
        private Card cardToGuess;
        private string guessA;
        private string guessB;
        private string guessC;
        private string guessD;
        private List<string> guessesList;
        private string allCardsJson;
        private List<Card> allCardsList;
        private static int i = 7;
        private Image cardImage;
        public QuizForm() {
            InitializeComponent();
            panelGuesses.Enabled = false;
            buttonRevealMore.Enabled = false;
            buttonConfirm.Enabled = false;
            allCardsJson = File.ReadAllText($"{Properties.Settings.Default.cardsPath}allCards.json");
            allCardsList = Util.getAllCardsList(allCardsJson);
            random = new Random();
        }
        private void buttonPlay_Click(object sender, EventArgs e) {
            panelGuesses.Enabled = true;
            buttonRevealMore.Enabled = true;
            buttonConfirm.Enabled = true;
            playRound();
        }
        public static List<string> getShuffledList(List<string> guessesList) {
            Random random = new Random();
            List<string> shuffledList = guessesList;
            int n = shuffledList.Count;
            while (n > 1) {
                n--;
                int k = random.Next(n + 1);
                string value = shuffledList[k];
                shuffledList[k] = shuffledList[n];
                shuffledList[n] = value;
            }
            return shuffledList;
        }

        private void radioButtonGuessA_CheckedChanged(object sender, EventArgs e) {
            if(radioButtonGuessA.Checked) {
                usersGuess = radioButtonGuessA.Text;
            }
        }

        private void radioButtonGuessB_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonGuessB.Checked) {
                usersGuess = radioButtonGuessB.Text;
            }
        }

        private void radioButtonGuessC_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonGuessC.Checked) {
                usersGuess = radioButtonGuessC.Text;
            }
        }

        private void radioButtonGuessD_CheckedChanged(object sender, EventArgs e) {
            if (radioButtonGuessD.Checked) {
                usersGuess = radioButtonGuessD.Text;
            }
        }

        private async void buttonConfirm_Click(object sender, EventArgs e) {
            if (usersGuess.Equals(cardToGuess.data[0].name)) {
                panelQuiz.Enabled = false;
                labelResult.Text = "Result: Correct!";
                SoundPlayer soundPlayer = new SoundPlayer($"{Properties.Settings.Default.soundsPath}winSound.wav");
                soundPlayer.Play();
                await Task.Delay(10000);
                soundPlayer.Stop();
                labelResult.Text = "Result:";
                playRound();
            }
            else {
                panelQuiz.Enabled = false;
                labelResult.Text = "Result: Incorrect!";
                await Task.Delay(2000);
                labelResult.Text = "Result:";
                playRound();
            }
        }

        private void buttonRevealMore_Click(object sender, EventArgs e) {
            i--;
            if(i > 0) {
                pictureBoxCard.Image = Util.pixelate((Bitmap)cardImage, i);
            }
        }
        public void playRound() {
            panelQuiz.Enabled = true;
            i = 7;
            guessesList = new List<string>();
            cardToGuess = allCardsList[random.Next(allCardsList.Count)];
            cardImage = Image.FromFile($"{Properties.Settings.Default.cardImagesPath}{cardToGuess.data[0].id}_image.jpg");
            pictureBoxCard.Image = Util.pixelate((Bitmap)cardImage, i);

            guessA = cardToGuess.data[0].name;
            guessB = allCardsList[random.Next(allCardsList.Count)].data[0].name;
            guessC = allCardsList[random.Next(allCardsList.Count)].data[0].name;
            guessD = allCardsList[random.Next(allCardsList.Count)].data[0].name;

            guessesList.Add(guessA);
            guessesList.Add(guessB);
            guessesList.Add(guessC);
            guessesList.Add(guessD);

            guessesList = getShuffledList(guessesList);

            radioButtonGuessA.Text = guessesList[0];
            radioButtonGuessB.Text = guessesList[1];
            radioButtonGuessC.Text = guessesList[2];
            radioButtonGuessD.Text = guessesList[3];
        }
    }
}