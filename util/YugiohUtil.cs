using FuzzySharp;
using Newtonsoft.Json;
using YugiohApp.view;
using static System.Net.Mime.MediaTypeNames;

namespace YugiohApp.util {
    public static class YugiohUtil {
        public static async Task<string> getCustomQueryResult(HttpClient client, string query) {
            string responseBody = "";
            try {
                using HttpResponseMessage response = await client.GetAsync(query);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e) {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            return responseBody;
        }

        public static async Task downloadAllCardImages(HttpClient client, string cardJson, string directoryPath) {
            Card cards = JsonConvert.DeserializeObject<Card>(cardJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < cards.data.Length; i++) {
                Card currentCard = new Card(new Datum[] { cards.data[i] });
                byte[] imageBytes = new byte[] { 0 };
                try {
                    imageBytes = await client.GetByteArrayAsync(currentCard.data[0].card_images[0].image_url);
                }
                catch (Exception) {
                    continue;
                }
                string path = Path.Combine(directoryPath, $"{currentCard.data[0].id}_image.jpg");
                Directory.CreateDirectory(directoryPath);
                await File.WriteAllBytesAsync(path, imageBytes);
                Thread.Sleep(3000);
            }
        }
        public static async Task downloadAllCards(string cardJson) {
            Card cards = JsonConvert.DeserializeObject<Card>(cardJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < cards.data.Length; i++) {
                Card currentCard = new Card(new Datum[] { cards.data[i] });
                string currentCardJson = JsonConvert.SerializeObject(currentCard);
                await File.WriteAllTextAsync("C:\\Users\\bojan\\Desktop\\C#\\Programming\\cards\\" + currentCard.data[0].id + ".json", currentCardJson);
            }
        }
        public static void handleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs) {
            string currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
        public static void checkAllCards(string[] allCardFiles, string[] allCardImageFiles) {
            bool found = false;
            foreach (string cardFile in allCardFiles) {
                foreach (string cardImageFile in allCardImageFiles) {
                    if (Path.GetFileNameWithoutExtension(cardImageFile).Substring(0, Path.GetFileNameWithoutExtension(cardImageFile).IndexOf('_')).Equals(Path.GetFileNameWithoutExtension(cardFile))) {
                        found = true;
                    }
                }
                if (found) {
                    //Console.WriteLine(Path.GetFileNameWithoutExtension(cardFile));
                }
                else {
                    Console.WriteLine($"Not found {Path.GetFileNameWithoutExtension(cardFile)}");
                }
            }
        }
        public static List<Card> getCardsByName(string cardJson, string cardNameSearch, Label labelFuzzRatio) {
            List<Card> cardList = new List<Card>();
            Card cards = JsonConvert.DeserializeObject<Card>(cardJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < cards.data.Length; i++) {
                Card currentCard = new Card(new Datum[] { cards.data[i] });
                if (isSimilar(currentCard.data[0].name, cardNameSearch)) {
                    cardList.Add(currentCard);
                    labelFuzzRatio.Text += currentCard.data[0].name + " : " + Fuzz.PartialRatio(currentCard.data[0].name, cardNameSearch).ToString() + "\n";
                }
            }
            return cardList;
        }
        public static void populateListView(DataGridView dataGridView, List<Card> cardList) {
            dataGridView.Rows.Clear();
            foreach (Card card in cardList) {
                dataGridView.Rows.Add(card.data[0].name);
            }
        }
        public static bool isSimilar(string currentCardName, string cardNameSearch) {
            string simpleCardNameSearch = getSimpleCardName(cardNameSearch);
            string simpleCurrentCardName = getSimpleCardName(currentCardName);
            bool isSimilar = false;
            if(Fuzz.PartialRatio(simpleCardNameSearch, simpleCurrentCardName) > 90 ||
                Fuzz.Ratio(simpleCardNameSearch, simpleCurrentCardName) > 90 ||
                simpleCurrentCardName.Contains(simpleCardNameSearch, StringComparison.InvariantCultureIgnoreCase)) {
                isSimilar = true;
            }
            return isSimilar;
        }
        public static string getSimpleCardName(string cardName) {
            string simpleCardName = cardName;
            if (simpleCardName.Contains("_")) {
                simpleCardName = simpleCardName.Replace("_", "");
            }
            if (simpleCardName.Contains("-")) {
                simpleCardName = simpleCardName.Replace("-", "");
            }
            if (simpleCardName.Contains("+")) {
                simpleCardName = simpleCardName.Replace("+", "");
            }
            if (simpleCardName.Contains("=")) {
                simpleCardName = simpleCardName.Replace("=", "");
            }
            if (simpleCardName.Contains("/")) {
                simpleCardName = simpleCardName.Replace("/", "");
            }
            if (simpleCardName.Contains(" ")) {
                simpleCardName = simpleCardName.Replace(" ", "");
            }
            return simpleCardName.ToLower();
        }
        public static void populateFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, List<Card> cardList) {
            flowLayoutPanel.Controls.Clear();
            foreach (Card card in cardList) {
                flowLayoutPanel.Controls.Add(new CardUserControl(card));
            }
        }
        public static void populatePanel(Panel panel, List<Card> cardList) {
            foreach (Card card in cardList) {
                panel.Controls.Add(new CardUserControl(card));
            }
        }
    }
}