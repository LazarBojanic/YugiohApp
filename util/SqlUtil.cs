using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using YugiohApp.view;

namespace YugiohApp.util {
    public static class SqlUtil {
        public static OleDbConnection getConnection() {
            return new OleDbConnection(Properties.Settings.Default.yugiohConnectionString);
        }
        public static int fillCardsDatabase(List<Card> allCardsList) {
            int cardsInserted = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [card] ([cardId], [cardName], [cardType], [cardDesc], [cardAtk], [cardDef], [cardLevel], [cardRace], [cardAttribute])" +
                "VALUES (@cardId, @cardName, @cardType, @cardDesc, @cardAtk, @cardDef, @cardLevel, @cardRace, @cardAttribute)";
            foreach (Card card in allCardsList) {
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
                    Card card = new Card(Convert.ToInt32(row["cardId"]));
                    CardUserControl cardUserControl = new CardUserControl(card);
                    flowLayoutPanelSearch.Controls.Add(cardUserControl);
                }
            }
            catch (OleDbException ex) {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Done");
        }
        public static int fillCardSetForCardTable(List<Card> allCardsList) {
            int cardSetsForCardsAdded = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "INSERT INTO [cardSetForCard] ([cardId], [cardSetCode]) VALUES (@cardId, @cardSetCode)";
            foreach (Card card in allCardsList) {
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
                    command.Parameters.AddWithValue("@cardSetCode", cardSet.set_code);
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
        public static List<Card_Sets> getListOfCardSets(List<Card> allCardsList) {
            List<Card_Sets> listOfCardSets = new List<Card_Sets>();
            foreach (Card card in allCardsList) {
                if (card.data[0].card_sets != null) {
                    for (int i = 0; i < card.data[0].card_sets.Length; i++) {
                        if (!listOfCardSets.Exists(x => x.set_code == card.data[0].card_sets[i].set_code)) {
                            listOfCardSets.Add(card.data[0].card_sets[i]);
                        }
                    }
                }
            }
            return listOfCardSets;
        }
        public static int updateCardPrices(List<Card> allCardsList) {
            int cardSetsUpdated = 0;
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
                    cardSetsUpdated += command.ExecuteNonQuery();
                }
                catch (OleDbException ex) {
                    MessageBox.Show(ex.Message);
                }
                command.Dispose();
            }
            connection.Close();
            MessageBox.Show("Done");
            return cardSetsUpdated;
        }

        public static int updateCardSets(List<CustomCardSet> allCardSetsList) {
            int cardSetsUpdated = 0;
            OleDbConnection connection = getConnection();
            connection.Open();
            string query = "UPDATE [cardSet] SET " +
                "[cardSetNumOfCards] = @cardSetNumOfCards, " +
                "[cardSetTCGDate] = @cardSetTCGDate " +
                "WHERE [cardSetCode] = @cardSetCode";
            foreach (CustomCardSet customCardSet in allCardSetsList) {
                OleDbCommand command = new OleDbCommand(query, connection);
                try {
                    //command.Parameters.AddWithValue("@cardSetNumOfCards", Convert.ToInt32(customCardSet.customCardSetData[0].num_of_cards));
                    //command.Parameters.AddWithValue("@cardSetTCGDate", DateTime.ParseExact(customCardSet.customCardSetData[0].tcg_date, "yyyyMMdd", CultureInfo.InvariantCulture));
                    //command.Parameters.AddWithValue("@cardSetCode", customCardSet.customCardSetData[0].set_code);
                    cardSetsUpdated += command.ExecuteNonQuery();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                command.Dispose();
            }
            connection.Close();
            MessageBox.Show("Done");
            return cardSetsUpdated;
        }
    }
}