using System.Diagnostics;

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
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            foreach (Process process in Process.GetProcessesByName("YugiohApp")) {
                process.Kill();
            }
        }
    }
}