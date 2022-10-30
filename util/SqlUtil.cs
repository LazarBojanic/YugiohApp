﻿using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Metrics;
using System.Globalization;
using YugiohApp.model;
using YugiohApp.view;
using static YugiohApp.util.Util;

namespace YugiohApp.util {
    public static class SqlUtil {
        public static OleDbConnection getConnection() {
            return new OleDbConnection(Properties.Settings.Default.yugiohConnectionString);
        }
        /*public static int fillCardsDatabase(List<Card> allCardsList) {
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
        }*/
        /*public static void fillSearchFlowLayoutPanel(string search, FlowLayoutPanel flowLayoutPanelSearch) {
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
        }*/
        public static List<Card> getCardListSearchResult(string search) {
            List<Card> cardListSearchResult = new List<Card>();
            OleDbConnection connection = getConnection();
            OleDbConnection cardSetConnection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT [cardId], [cardName], [cardType], [cardDesc], [cardAtk], [cardDef], " +
                "[cardLevel], [cardRace], [cardAttribute], [cardAttribute], [cardPriceCardMarket], [cardPriceTCGPlayer], " +
                "[cardPriceEbay], [cardPriceAmazon], [cardPriceCoolStuffInc] FROM [card] WHERE UCASE([cardName]) LIKE '%' + @search + '%' OR UCASE([cardDesc]) LIKE '%' + @search + '%'";
            OleDbCommand command = new OleDbCommand(query, connection);
            command.Parameters.AddWithValue("@search", search);
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
                card.loadImage();
                cardListSearchResult.Add(card);
            }
            cardSetConnection.Close();
            return cardListSearchResult;
        }
        /*public static int fillCardSetForCardTable(List<Card> allCardsList) {
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
        }*/
        /*public static int fillCardSetTable(List<Card_Sets> listOfCardSets) {
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
        }*/
        /*public static int updateCardPrices(List<Card> allCardsList) {
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
        }*/
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
        public static List<CardSet> getCardSetsForCard(OleDbConnection cardSetConnection, int cardId) {
            List<CardSet> cardSetList = new List<CardSet>();
            DataTable dataTable = new DataTable();
            string query = "SELECT cardSet.cardSetCode, [cardSetName], [cardSetRarity], [cardSetRarityCode], [cardSetPrice], [cardSetCardCount], [cardSetReleaseDateTCG] FROM " +
                "[cardSet] INNER JOIN [cardInCardSet] ON cardSet.cardSetCode = cardInCardSet.cardSetCode WHERE [cardId] = @cardId";
            OleDbCommand command = new OleDbCommand(query, cardSetConnection);
            command.Parameters.AddWithValue("@cardId", cardId);
            dataTable.Load(command.ExecuteReader());
            foreach (DataRow dataRow in dataTable.Rows) {
                CardSet cardSet = new CardSet(
                    Convert.ToString(dataRow["cardSetCode"]),
                    Convert.ToString(dataRow["cardSetName"]),
                    Convert.ToString(dataRow["cardSetRarity"]),
                    Convert.ToString(dataRow["cardSetRarityCode"]),
                    Convert.ToDecimal(dataRow["cardSetPrice"]),
                    Convert.ToInt32(dataRow["cardSetCardCount"]),
                    Convert.ToDateTime(dataRow["cardSetReleaseDateTCG"]));
                cardSetList.Add(cardSet);
            }
            return cardSetList;
        }
        public static List<Card> getSimpleCardListSQL() {
            List<Card> simpleCardList = new List<Card>();
            OleDbConnection connection = getConnection();
            OleDbConnection cardSetConnection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT [cardId], [cardName] FROM [card]";
            OleDbCommand command = new OleDbCommand(query, connection);
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            cardSetConnection.Open();
            foreach (DataRow dataRow in dataTable.Rows) {
                Card card = new Card(
                    Convert.ToInt32(dataRow["cardId"]),
                    Convert.ToString(dataRow["cardName"]));
                simpleCardList.Add(card);
            }
            cardSetConnection.Close();
            return simpleCardList;
        }
        public static void populateCardTypeComboBox(ComboBox comboBoxCardType) {
            comboBoxCardType.Items.Clear();
            comboBoxCardType.Items.Add("");
            OleDbConnection connection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT DISTINCT [cardType] FROM [card] ORDER BY [cardType]";
            OleDbCommand command = new OleDbCommand(query, connection);
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardType.Items.Add(dataRow["cardType"]);
            }
        }
        public static void populateCardRaceComboBox(ComboBox comboBoxCardRace) {
            comboBoxCardRace.Items.Clear();
            OleDbConnection connection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT DISTINCT [cardRace] FROM [card] ORDER BY [cardRace]";
            OleDbCommand command = new OleDbCommand(query, connection);
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardRace.Items.Add(dataRow["cardRace"]);
            }
        }
        public static void populateCardAttributeComboBox(ComboBox comboBoxCardAttribute) {
            comboBoxCardAttribute.Items.Clear();
            OleDbConnection connection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT DISTINCT [cardAttribute] FROM [card] ORDER BY [cardAttribute]";
            OleDbCommand command = new OleDbCommand(query, connection);
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardAttribute.Items.Add(dataRow["cardAttribute"]);
            }
        }
    }
}