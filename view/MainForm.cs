using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YugiohApp.view {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {

        }

        private void buttonDeckBuilder_Click(object sender, EventArgs e) {
            DeckBuilderForm deckBuilderForm = new DeckBuilderForm();
            deckBuilderForm.ShowDialog();
        }

        private void buttonQuiz_Click(object sender, EventArgs e) {
            QuizForm quizForm = new QuizForm();
            quizForm.ShowDialog();
        }
    }
}