using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using YugiohApp.model;
using static YugiohApp.view.DeckBuilderForm;

namespace YugiohApp.util {
    public static class SqlUtil {
        public static OleDbConnection getConnection() {
            return new OleDbConnection(Properties.Settings.Default.yugiohConnectionString);
        }
        public static async Task<List<Card>> getCardListSearchResult() {
            List<Card> cardListSearchResult = new List<Card>();
            OleDbConnection connection = getConnection();
            OleDbConnection cardSetConnection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT [cardId], [cardName], [cardType], [cardDesc], [cardAtk], [cardDef], " +
                "[cardLevel], [cardRace], [cardAttribute], [cardAttribute], [cardPriceCardMarket], [cardPriceTCGPlayer], " +
                "[cardPriceEbay], [cardPriceAmazon], [cardPriceCoolStuffInc] FROM [card] " +
                "WHERE [cardId] IS NOT NULL"; 
            if (!string.IsNullOrEmpty(nameOrDescSearch)) {
                query += " AND (UCASE([cardName]) LIKE '%' + @search + '%' OR UCASE([cardDesc]) LIKE '%' + @search + '%')";
            }
            if (!string.IsNullOrEmpty(typeSearch)) {
                query += " AND [cardType] = @cardType";
            }
            if (!string.IsNullOrEmpty(raceSearch)) {
                query += " AND [cardRace] = @cardRace";
            }
            if (!string.IsNullOrEmpty(attributeSearch)) {
                query += " AND [cardAttribute] = @cardAttribute";
            }
            if (atkSearchMode == CardSearchMode.LESSER_OR_EQUAL) {
                query += " AND [cardAtk] <= @cardAtk";
            }
            if (atkSearchMode == CardSearchMode.GREATER_OR_EQUAL) {
                query += " AND [cardAtk] >= @cardAtk";
            }
            if (atkSearchMode == CardSearchMode.EQUAL) {
                query += " AND [cardAtk] = @cardAtk";
            }
            if (defSearchMode == CardSearchMode.LESSER_OR_EQUAL) {
                query += " AND [cardDef] <= @cardDef";
            }
            if (defSearchMode == CardSearchMode.GREATER_OR_EQUAL) {
                query += " AND [cardDef] >= @cardDef";
            }
            if (defSearchMode == CardSearchMode.EQUAL) {
                query += " AND [cardDef] = @cardDef";
            }
            if (levelSearchMode == CardSearchMode.LESSER_OR_EQUAL) {
                query += " AND [cardLevel] <= @cardLevel";
            }
            if (levelSearchMode == CardSearchMode.GREATER_OR_EQUAL) {
                query += " AND [cardLevel] >= @cardLevel";
            }
            if (levelSearchMode == CardSearchMode.EQUAL) {
                query += " AND [cardLevel] = @cardLevel";
            }
            OleDbCommand command = new OleDbCommand(query, connection);
            if (!string.IsNullOrEmpty(nameOrDescSearch)) {
                command.Parameters.AddWithValue("@search", nameOrDescSearch.ToUpper());
            }
            if (!string.IsNullOrEmpty(typeSearch)) {
                command.Parameters.AddWithValue("@cardType", typeSearch);
            }
            if (!string.IsNullOrEmpty(raceSearch)) {
                command.Parameters.AddWithValue("@cardRace", raceSearch);
            }
            if (!string.IsNullOrEmpty(attributeSearch)) {
                command.Parameters.AddWithValue("@cardAttribute", attributeSearch);
            }
            if (atkSearchMode != CardSearchMode.ALL) {
                command.Parameters.AddWithValue("@cardAtk", atkSearch);
            }
            if (defSearchMode != CardSearchMode.ALL) {
                command.Parameters.AddWithValue("@cardDef", defSearch);
            }
            if (levelSearchMode != CardSearchMode.ALL) {
                command.Parameters.AddWithValue("@cardLevel", levelSearch);
            }
            DbDataReader resultSet = await command.ExecuteReaderAsync();
            dataTable.Load(resultSet);
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
            string query = "SELECT DISTINCT [cardType] FROM [card] WHERE [cardType] <> '' ORDER BY [cardType]";
            OleDbCommand command = new OleDbCommand(query, connection);
            DbDataReader resultSet = command.ExecuteReader();
            dataTable.Load(resultSet);
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardType.Items.Add(dataRow["cardType"]);
            }
        }
        public static void populateCardRaceComboBox(ComboBox comboBoxCardRace) {
            comboBoxCardRace.Items.Clear();
            comboBoxCardRace.Items.Add("");
            OleDbConnection connection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT DISTINCT [cardRace] FROM [card] WHERE [cardRace] <> '' ORDER BY [cardRace]";
            OleDbCommand command = new OleDbCommand(query, connection);
            DbDataReader resultSet = command.ExecuteReader();
            dataTable.Load(resultSet);
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardRace.Items.Add(dataRow["cardRace"]);
            }
        }
        public static void populateCardAttributeComboBox(ComboBox comboBoxCardAttribute) {
            comboBoxCardAttribute.Items.Clear();
            comboBoxCardAttribute.Items.Add("");
            OleDbConnection connection = getConnection();
            DataTable dataTable = new DataTable();
            connection.Open();
            string query = "SELECT DISTINCT [cardAttribute] FROM [card] WHERE [cardAttribute] <> '' ORDER BY [cardAttribute]";
            OleDbCommand command = new OleDbCommand(query, connection);
            DbDataReader resultSet = command.ExecuteReader();
            dataTable.Load(resultSet);
            connection.Close();
            foreach (DataRow dataRow in dataTable.Rows) {
                comboBoxCardAttribute.Items.Add(dataRow["cardAttribute"]);
            }
        }
    }
}