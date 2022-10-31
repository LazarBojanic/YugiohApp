using FuzzySharp;
using Newtonsoft.Json;
using System.Data;
using System.Data.OleDb;
using YugiohApp.model;
using YugiohApp.view;
using static YugiohApp.util.Util;
using static YugiohApp.util.SqlUtil;

namespace YugiohApp.util {
    public static class DataHelperMethods {
        /*public static int fillCardSetForCardTable(List<JsonCard> allCardsList) {
            int cardSetsForCardsAdded = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [cardSetForCard] ([cardId], [cardSetCode]) VALUES (@cardId, @cardSetCode)";
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].card_sets != null) {
                    for (int i = 0; i < card.data[0].card_sets.Length; i++) {
                        OleDbCommand command = new OleDbCommand(query, connection);
                        try {
                            command.Parameters.AddWithValue("@cardId", card.data[0].id);
                            command.Parameters.AddWithValue("@cardSetCode", card.data[0].card_sets[i].set_code);
                            cardSetsForCardsAdded += command.ExecuteNonQuery();
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                        command.Dispose();
                    }
                }
                else {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    try {
                        command.Parameters.AddWithValue("@cardId", card.data[0].id);
                        command.Parameters.AddWithValue("@cardSetCode", "");
                        cardSetsForCardsAdded += command.ExecuteNonQuery();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                    command.Dispose();
                }
            }
            connection.Close();
            return cardSetsForCardsAdded;
        }
        public static int fillCardSetTable(List<Card_Sets> listOfCardSets) {
            int cardSetsAdded = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [cardSet] ([cardSetCode], [cardSetName], [cardSetRarity], [cardSetRarityCode], [cardSetPrice]) " +
                "VALUES (@cardSetCode, @cardSetName, @cardSetRarity, @cardSetRarityCode, @cardSetPrice)";
            foreach (Card_Sets cardSet in listOfCardSets) {
                OleDbCommand command = new OleDbCommand(query, connection);
                try {
                    if (cardSet.set_code.Contains("-")) {
                        command.Parameters.AddWithValue("@cardSetCode", cardSet.set_code.Substring(0, cardSet.set_code.IndexOf("-")));
                    }
                    else {
                        command.Parameters.AddWithValue("@cardSetCode", cardSet.set_code);
                    }
                    command.Parameters.AddWithValue("@cardSetName", cardSet.set_name);
                    command.Parameters.AddWithValue("@cardSetRarity", cardSet.set_rarity);
                    command.Parameters.AddWithValue("@cardSetRarityCode", cardSet.set_rarity_code);
                    command.Parameters.AddWithValue("@cardSetPrice", Convert.ToDecimal(cardSet.set_price));
                    cardSetsAdded += command.ExecuteNonQuery();
                }
                catch (OleDbException ex) {
                    MessageBox.Show(ex.Message);
                }
                command.Dispose();
            }
            connection.Close();
            return cardSetsAdded;
        }
        public static int updateCardPrices(List<Card> allCardsList) {
            int cardsUpdated = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "UPDATE [card] SET " +
                "[cardPriceCardMarket] = @cardPriceCardMarket, " +
                "[cardPriceTCGPlayer] = @cardPriceTCGPlayer, " +
                "[cardPriceEBay] = @cardPriceEBay, " +
                "[cardPriceAmazon] = @cardPriceAmazon, " +
                "[cardPriceCoolStuffInc] = @cardPriceCoolStuffInc " +
                "WHERE [cardId] = @cardId";
            foreach (Card card in allCardsList) {
                OleDbCommand command = new OleDbCommand(query, connection);
                try {
                    command.Parameters.AddWithValue("@cardPriceCardMarket", Convert.ToDecimal(card.data[0].card_prices[0].cardmarket_price));
                    command.Parameters.AddWithValue("@cardPriceTCGPlayer", Convert.ToDecimal(card.data[0].card_prices[0].tcgplayer_price));
                    command.Parameters.AddWithValue("@cardPriceEBay", Convert.ToDecimal(card.data[0].card_prices[0].ebay_price));
                    command.Parameters.AddWithValue("@cardPriceAmazon", Convert.ToDecimal(card.data[0].card_prices[0].amazon_price));
                    command.Parameters.AddWithValue("@cardPriceCoolStuffInc", Convert.ToDecimal(card.data[0].card_prices[0].coolstuffinc_price));
                    command.Parameters.AddWithValue("@cardId", Convert.ToInt32(card.data[0].id));
                    cardsUpdated += command.ExecuteNonQuery();
                }
                catch (OleDbException ex) {
                    MessageBox.Show(ex.Message);
                }
                command.Dispose();
            }
            connection.Close();
            return cardsUpdated;
        }
        public static int fillCardsDatabase(List<JsonCard> allCardsList) {
            int cardsInserted = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [card] ([cardId], [cardName], [cardType], [cardDesc], [cardAtk], [cardDef], [cardLevel], [cardRace], [cardAttribute])" +
                "VALUES (@cardId, @cardName, @cardType, @cardDesc, @cardAtk, @cardDef, @cardLevel, @cardRace, @cardAttribute)";
            foreach (JsonCard card in allCardsList) {
                OleDbCommand command = new OleDbCommand(query, connection);
                try {
                    command.Parameters.AddWithValue("@id", card.data[0].id);
                    command.Parameters.AddWithValue("@cardName", card.data[0].name);
                    command.Parameters.AddWithValue("@cardType", card.data[0].type);
                    command.Parameters.AddWithValue("@cardDesc", card.data[0].desc);
                    command.Parameters.AddWithValue("@cardAtk", card.data[0].atk);
                    command.Parameters.AddWithValue("@cardDef", card.data[0].def);
                    command.Parameters.AddWithValue("@cardLevel", card.data[0].level);
                    command.Parameters.AddWithValue("@cardRace", card.data[0].race);
                    if (card.data[0].attribute == null) {
                        command.Parameters.AddWithValue("@cardAttribute", "");
                    }
                    else {
                        command.Parameters.AddWithValue("@cardAttribute", card.data[0].attribute);
                    }
                    cardsInserted += command.ExecuteNonQuery();
                }
                catch (OleDbException ex) {
                    MessageBox.Show(ex.Message);
                }
                command.Dispose();
            }
            connection.Close();
            return cardsInserted;
        }
        public static void fillSearchFlowLayoutPanel(string search, FlowLayoutPanel flowLayoutPanelSearch) {
            flowLayoutPanelSearch.Controls.Clear();
            OleDbConnection connection = getConnection();
            DataTable dt = new DataTable();
            connection.Open();
            string query = "SELECT [cardId] FROM [card] WHERE UCASE([cardName]) LIKE '%' + @search + '%' OR UCASE([cardDesc]) LIKE '%' + @search + '%'";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@search", search.ToUpper());
            try {
                dt.Load(command.ExecuteReader());
                foreach (DataRow row in dt.Rows) {
                    JsonCard card = new JsonCard(Convert.ToInt32(row["cardId"]));
                    CardUserControl cardUserControl = new CardUserControl(card);
                    flowLayoutPanelSearch.Controls.Add(cardUserControl);
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
        public static bool isSimilar(string cardName, string cardNameSearch) {
            string simpleCardNameSearch = getSimpleCardName(cardNameSearch);
            string simpleCardName = getSimpleCardName(cardName);
            bool isSimilar = false;
            if (Fuzz.PartialRatio(simpleCardNameSearch, simpleCardName) > 90 ||
                Fuzz.Ratio(simpleCardNameSearch, simpleCardName) > 90 ||
                simpleCardName.Contains(simpleCardNameSearch, StringComparison.InvariantCultureIgnoreCase)) {
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
        public static JsonCard getCardWithMaxDescLength(List<JsonCard> allCardsList) {
            int max = 0;
            int foundId = 0;
            JsonCard foundCard = new JsonCard();
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].desc.Length > max) {
                    max = card.data[0].desc.Length;
                    foundId = card.data[0].id;
                }
            }
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].id == foundId) {
                    foundCard = card;
                }
            }
            return foundCard;
        }
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
        public static List<Card> getCardsByName(string allCardsJson, string cardNameSearch) {
            List<Card> cardList = new List<Card>();
            Card allCards = JsonConvert.DeserializeObject<Card>(allCardsJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < allCards.data.Length; i++) {
                Card card = new Card(new Datum[] { allCards.data[i] });
                if (isSimilar(card.data[0].name, cardNameSearch)) {
                    cardList.Add(card);
                }
            }
            return cardList;
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
        public static List<Card_Sets> getListOfCardSets(List<JsonCard> allCardsList) {
            List<Card_Sets> listOfCardSets = new List<Card_Sets>();
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].card_sets != null && card.data[0].card_sets.Length > 0) {
                    for (int i = 0; i < card.data[0].card_sets.Length; i++) {
                        if (!codeExists(listOfCardSets, card.data[0].card_sets[i].set_code)) {
                            listOfCardSets.Add(card.data[0].card_sets[i]);
                        }
                    }
                }
            }
            return listOfCardSets;
        }
        public static List<JsonCard> getAllCardsList(string allCardsJson) {
            List<JsonCard> cardList = new List<JsonCard>();
            JsonCard allCards = JsonConvert.DeserializeObject<JsonCard>(allCardsJson, new JsonSerializerSettings { Error = handleDeserializationError });
            for (int i = 0; i < allCards.data.Length; i++) {
                JsonCard card = new JsonCard(new Datum[] { allCards.data[i] });
                cardList.Add(card);
            }
            return cardList;
        }

        public static JsonCard getCardForId(int cardId, List<JsonCard> allCardsListFromJson) {
            foreach (JsonCard card in allCardsListFromJson) {
                if (card.data[0].id == cardId) {
                    return card;
                }
            }
            return new JsonCard();
        }
        public static bool regularCodeExists(List<CardSet> customCardSetList, string cardSetCode) {
            foreach (CardSet customCardSet in customCardSetList) {
                if (customCardSet.code.Equals(cardSetCode)) {
                    return true;
                }
            }
            return false;
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
            foreach (Card_Sets cardSet in listOfCardSets) {
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
        public static void handleDeserializationError(object sender, Newtonsoft.Json.Serialization.ErrorEventArgs errorArgs) {
            string currentError = errorArgs.ErrorContext.Error.Message;
            errorArgs.ErrorContext.Handled = true;
        }
        public static int updateCardSetTable(List<CardSet> customCardSetList) {
            int cardSetsUpdated = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "UPDATE [cardSet] SET [cardSetCardCount] = @cardSetCardCount, [cardSetReleaseDateTCG] = @cardSetReleaseDateTCG WHERE [cardSetCode] = @cardSetCode";
            foreach (CardSet customCardSet in customCardSetList) {
                OleDbCommand command = new OleDbCommand(query, connection);
                try {
                    command.Parameters.AddWithValue("@cardSetCardCount", customCardSet.cardCount);
                    command.Parameters.AddWithValue("@cardSetReleaseDateTCG", customCardSet.releaseDateTCG);
                    command.Parameters.AddWithValue("@cardSetCode", customCardSet.code);
                    cardSetsUpdated += command.ExecuteNonQuery();
                }
                catch (OleDbException ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            connection.Close();
            return cardSetsUpdated;
        }
        public static int fillCardInCardSetTable(List<CardSet> customCardSetList, List<JsonCard> allCardsList) {
            int cardsUpdated = 0;
            string trimmedSetCode = "";
            string trimmedCardCodeInCardSet = "";
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [cardInCardSet] ([cardId], [cardSetCode], [cardCodeInCardSet]) VALUES (@cardId, @cardSetCode, @cardCodeInCardSet)";
            foreach (JsonCard card in allCardsList) {
                if (card.data[0].card_sets != null && card.data[0].card_sets.Length >= 1) {
                    for (int i = 0; i < card.data[0].card_sets.Length; i++) {
                        if (card.data[0].card_sets[i].set_code.Contains("-")) {
                            trimmedSetCode = card.data[0].card_sets[i].set_code.Substring(0, card.data[0].card_sets[i].set_code.IndexOf("-"));
                            trimmedCardCodeInCardSet = card.data[0].card_sets[i].set_code.Substring(card.data[0].card_sets[i].set_code.IndexOf("-") + 1);
                        }
                        else {
                            trimmedSetCode = card.data[0].card_sets[i].set_code;
                            trimmedCardCodeInCardSet = "";
                        }
                        if (setExists(customCardSetList, trimmedSetCode)) {
                            OleDbCommand command = new OleDbCommand(query, connection);
                            try {
                                command.Parameters.AddWithValue("@cardId", card.data[0].id);
                                command.Parameters.AddWithValue("@cardSetCode", trimmedSetCode);
                                command.Parameters.AddWithValue("@cardCodeInCardSet", trimmedCardCodeInCardSet);
                                cardsUpdated += command.ExecuteNonQuery();
                            }
                            catch (OleDbException ex) {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
                else {
                    OleDbCommand command = new OleDbCommand(query, connection);
                    try {
                        command.Parameters.AddWithValue("@cardId", card.data[0].id);
                        command.Parameters.AddWithValue("@cardSetCode", "");
                        command.Parameters.AddWithValue("@cardCodeInCardSet", "");
                        cardsUpdated += command.ExecuteNonQuery();
                    }
                    catch (OleDbException ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            connection.Close();
            return cardsUpdated;
        }
        public static bool setExists(List<CardSet> customCardSetList, string cardSetCode) {
            for (int i = 0; i < customCardSetList.Count; i++) {
                if (customCardSetList[i].code.Equals(cardSetCode)) {
                    return true;
                }
            }
            return false;
        }*/
        public static List<Card> getAllCardsFromSQLList() {
            List<Card> cardList = new List<Card>();
            OleDbConnection connection = getConnection();
            OleDbConnection cardSetConnection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT [cardId], [cardName], [cardType], [cardDesc], [cardAtk], [cardDef], " +
                "[cardLevel], [cardRace], [cardAttribute], [cardAttribute], [cardPriceCardMarket], [cardPriceTCGPlayer], " +
                "[cardPriceEbay], [cardPriceAmazon], [cardPriceCoolStuffInc] FROM [card]";
            OleDbCommand command = new OleDbCommand(query, connection);
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            cardSetConnection.Open();
            foreach (DataRow dataRow in dataTable.Rows) {
                Card card = new Card(
                    Convert.ToInt32(dataRow["cardId"]),
                    Convert.ToString(dataRow["cardName"]),
                    Convert.ToString(dataRow["cardType"]),
                    Convert.ToString(dataRow["cardDesc"]),
                    Convert.ToInt32(dataRow["cardAtk"]),
                    Convert.ToInt32(dataRow["cardDef"]),
                    Convert.ToInt32(dataRow["cardLevel"]),
                    Convert.ToString(dataRow["cardRace"]),
                    Convert.ToString(dataRow["cardAttribute"]),
                    getCardSetsForCard(cardSetConnection, Convert.ToInt32(dataRow["cardId"])),
                    Convert.ToDecimal(dataRow["cardPriceCardMarket"]),
                    Convert.ToDecimal(dataRow["cardPriceTCGPlayer"]),
                    Convert.ToDecimal(dataRow["cardPriceEbay"]),
                    Convert.ToDecimal(dataRow["cardPriceAmazon"]),
                    Convert.ToDecimal(dataRow["cardPriceCoolStuffInc"]));
                cardList.Add(card);
            }
            cardSetConnection.Close();
            return cardList;
        }
    }
}