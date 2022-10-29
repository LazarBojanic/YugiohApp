using Newtonsoft.Json;
using System.Globalization;
using YugiohApp.model;
using YugiohApp.view;

namespace YugiohApp.util {
    public static class Util {
        /*public static async Task<string> getCustomQueryResult(HttpClient client, string query) {
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
        }*/

        /*public static async Task downloadAllCardImages(HttpClient client, string cardJson, string directoryPath) {
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
        }*/
        /*public static async Task downloadAllCards(string cardJson) {
            Card cards = JsonConvert.DeserializeObject<Card>(cardJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < cards.data.Length; i++) {
                Card currentCard = new Card(new Datum[] { cards.data[i] });
                string currentCardJson = JsonConvert.SerializeObject(currentCard);
                await File.WriteAllTextAsync("C:\\Users\\bojan\\Desktop\\C#\\Programming\\cards\\" + currentCard.data[0].id + ".json", currentCardJson);
            }
        }*/
        public static void handleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs) {
            string currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
        /*public static void checkAllCards(string[] allCardFiles, string[] allCardImageFiles) {
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
        }*/
        /*public static List<Card> getCardsByName(string allCardsJson, string cardNameSearch) {
            List<Card> cardList = new List<Card>();
            Card allCards = JsonConvert.DeserializeObject<Card>(allCardsJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < allCards.data.Length; i++) {
                Card card = new Card(new Datum[] { allCards.data[i] });
                if (isSimilar(card.data[0].name, cardNameSearch)) {
                    cardList.Add(card);
                }
            }
            return cardList;
        }*/
        public static List<JsonCard> getAllCardsList(string allCardsJson) {
            List<JsonCard> cardList = new List<JsonCard>();
            JsonCard allCards = JsonConvert.DeserializeObject<JsonCard>(allCardsJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < allCards.data.Length; i++) {
                JsonCard card = new JsonCard(new Datum[] { allCards.data[i] });
                cardList.Add(card);
            }
            return cardList;
        }
        /*public static List<CustomCardSet> getAllCardSets(string allCardSetsJson) {
            List<CustomCardSet> allCardSetsList = new List<CustomCardSet>();
            CustomCardSet allCardSets = JsonConvert.DeserializeObject<CustomCardSet>(allCardSetsJson, new JsonSerializerSettings { Error = handleDeserializationError });
            //CustomCardSet allCardSets = System.Text.Json.JsonSerializer.Deserialize<CustomCardSet>(allCardSetsJson);
            for (int i = 0; i < allCardSets.customCardSetData.Length; i++) {
                CustomCardSet cardSet = new CustomCardSet(new CustomCardSetData[] { allCardSets.customCardSetData[i] });
                allCardSetsList.Add(cardSet);
            }
            return allCardSetsList;
        }*/
        /*public static List<CustomCardSet> getAllCardSetsXml(Stream xmlReader) {
            List<CustomCardSet> allCardSetsList = new List<CustomCardSet>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CustomCardSet));
            CustomCardSet customCardSet = (CustomCardSet)xmlSerializer.Deserialize(xmlReader);
            for (int i = 0; i < customCardSet.row.Length; i++) {
                CustomCardSet cardSet = new CustomCardSet();
                cardSet.row.SetValue(customCardSet.row[i], 0);
                allCardSetsList.Add(cardSet);
            }
            return allCardSetsList;
        }*/

        /*public static bool isSimilar(string cardName, string cardNameSearch) {
            string simpleCardNameSearch = getSimpleCardName(cardNameSearch);
            string simpleCardName = getSimpleCardName(cardName);
            bool isSimilar = false;
            if(Fuzz.PartialRatio(simpleCardNameSearch, simpleCardName) > 90 ||
                Fuzz.Ratio(simpleCardNameSearch, simpleCardName) > 90 ||
                simpleCardName.Contains(simpleCardNameSearch, StringComparison.InvariantCultureIgnoreCase)) {
                isSimilar = true;
            }
            return isSimilar;
        }*/
        /*public static string getSimpleCardName(string cardName) {
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
        }*/
        /*public static void populateFlowLayoutPanel(FlowLayoutPanel flowLayoutPanel, List<Card> cardList) {
            flowLayoutPanel.Controls.Clear();
            foreach (Card card in cardList) {
                flowLayoutPanel.Controls.Add(new CardUserControl(card));
            }
        }*/
        /*public static void populatePanel(Panel panel, List<Card> cardList) {
            foreach (Card card in cardList) {
                panel.Controls.Add(new CardUserControl(card));
            }
        }*/
        /*public static Card getCardWithMaxDescLength(List<Card> allCardsList) {
            int max = 0;
            int foundId = 0;
            Card foundCard = new Card();
            foreach (Card card in allCardsList) {
                if (card.data[0].desc.Length > max) {
                    max = card.data[0].desc.Length;
                    foundId = card.data[0].id;
                }
            }
            foreach (Card card in allCardsList) {
                if (card.data[0].id == foundId) {
                    foundCard = card;
                }
            }
            return foundCard;
        }*/
        public static JsonCard getCardForId(int cardId) {
            foreach(JsonCard card in DeckBuilderForm.allCardsListFromJson) {
                if (card.data[0].id == cardId) {
                    return card;
                }
            }
            return new JsonCard();
        }
        /*public static Image getResizedImage(Image imgPhoto, int Width, int Height) {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW) {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width - (sourceWidth * nPercent)) / 2);
            }
            else {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height - (sourceHeight * nPercent)) / 2);
            }
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Red);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.DrawImage(imgPhoto, new Rectangle(destX, destY, destWidth, destHeight), new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight), GraphicsUnit.Pixel);
            grPhoto.Dispose();
            return bmPhoto;
        }*/
        public static Bitmap pixelate(Bitmap image, int pixelateSize) {
            Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
            Bitmap pixelated = new Bitmap(image.Width, image.Height);

            // make an exact copy of the bitmap provided
            using (Graphics graphics = Graphics.FromImage(pixelated))
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height),
                    new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);

            // look at every pixel in the rectangle while making sure we're within the image bounds
            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width && xx < image.Width; xx += pixelateSize) {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height && yy < image.Height; yy += pixelateSize) {
                    int offsetX = pixelateSize / 2;
                    int offsetY = pixelateSize / 2;

                    // make sure that the offset is within the boundry of the image
                    while (xx + offsetX >= image.Width) offsetX--;
                    while (yy + offsetY >= image.Height) offsetY--;

                    // get the pixel color in the center of the soon to be pixelated area
                    Color pixel = pixelated.GetPixel(xx + offsetX, yy + offsetY);

                    // for each pixel in the pixelate size, set it to the center color
                    for (int x = xx; x < xx + pixelateSize && x < image.Width; x++)
                        for (int y = yy; y < yy + pixelateSize && y < image.Height; y++)
                            pixelated.SetPixel(x, y, pixel);
                }
            }

            return pixelated;
        }
        public static List<Card_Sets> getListOfCardSets(List<JsonCard> allCardsList) {
            List<Card_Sets> listOfCardSets = new List<Card_Sets>();
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].card_sets != null && card.data[0].card_sets.Length > 0) {
                    for (int i = 0; i < card.data[0].card_sets.Length; i++) {
                        /*if (!listOfCardSets.Exists(x => x.set_code == card.data[0].card_sets[i].set_code)) {
                            listOfCardSets.Add(card.data[0].card_sets[i]);
                        }*/
                        if (!codeExists(listOfCardSets, card.data[0].card_sets[i].set_code)) {
                            listOfCardSets.Add(card.data[0].card_sets[i]);
                        }
                    }
                }
            }
            return listOfCardSets;
        }
        public static bool codeExists(List<Card_Sets> listOfCardSets, string cardSetCode) {
            string trimedExistingCardSetCode = "";
            string trimedCurrentCardSetCode = "";
            if (cardSetCode.Contains("-")) {
                trimedCurrentCardSetCode = cardSetCode.Substring(0, cardSetCode.IndexOf("-"));
            }
            else {
                trimedCurrentCardSetCode = cardSetCode;
            }
            foreach (Card_Sets cardSet in listOfCardSets){
                if (cardSet.set_code.Contains("-")) {
                    trimedExistingCardSetCode = cardSet.set_code.Substring(0, cardSet.set_code.IndexOf("-"));
                }
                else {
                    trimedExistingCardSetCode = cardSet.set_code;
                }   
                if (trimedExistingCardSetCode.Equals(trimedCurrentCardSetCode)) {
                    return true;
                }
            }
            return false;
        }
        public static List<CardSet> getCardSetList() {
            List<CardSet> customCardSetList = new List<CardSet>();
            foreach (string line in File.ReadLines("C:\\Users\\bojan\\Desktop\\C#\\YugiohApp\\allCardSets.txt")) {
                CardSet customCardSet = new CardSet();
                string[] splitLine = line.Split(",");
                customCardSet.code = splitLine[0];
                customCardSet.cardCount = Convert.ToInt32(splitLine[1]);
                customCardSet.releaseDateTCG = DateTime.ParseExact(splitLine[2], "yyyy-MM-dd", CultureInfo.InvariantCulture);
                if(!regularCodeExists(customCardSetList, customCardSet.code)) {
                    customCardSetList.Add(customCardSet);
                }
            }
            return customCardSetList;
        }
        public static string customCardSetListToString(List<CardSet> customCardSetList) {
            string customCardSetListString = "";
            foreach(CardSet customCardSet in customCardSetList) {
                customCardSetListString += customCardSet.code + " | " + customCardSet.cardCount + " | " + customCardSet.releaseDateTCG + "\n";
            }
            return customCardSetListString;
        }
        public static bool regularCodeExists(List<CardSet> customCardSetList, string cardSetCode) {
            foreach (CardSet customCardSet in customCardSetList) {
                if (customCardSet.code.Equals(cardSetCode)) {
                    return true;
                }
            }
            return false;
        }
        public static bool setExists(List<CardSet> customCardSetList, string cardSetCode) {
            for (int i = 0; i < customCardSetList.Count; i++) {
                if (customCardSetList[i].code.Equals(cardSetCode)) {
                    return true;
                }
            }
            return false;
        }
        public static string getListString(List<Card> cardList) {
            string listString = "";
            for(int i = 0; i < cardList.Count; i++) {
                listString += cardList[i].name + "\n";
            }
            return listString;
        }
    }
}