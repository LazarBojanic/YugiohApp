using Newtonsoft.Json;
using System.Globalization;
using YugiohApp.model;
using YugiohApp.view;

namespace YugiohApp.util {
    public static class Util {
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
        public static string getListString(List<Card> cardList) {
            string listString = "";
            for(int i = 0; i < cardList.Count; i++) {
                listString += cardList[i].name + "\n";
            }
            return listString;
        }
        public static List<List<Card>> chunkList(List<Card> cardListSearchResult, int chunkSize) {
            List<List<Card>> chunks = new List<List<Card>>();
            if(cardListSearchResult.Count <= chunkSize) {
                chunks.Add(cardListSearchResult);
                return chunks;
            }
            else {
                int numberOfChunks = cardListSearchResult.Count / chunkSize;
                int chunkRemainder = cardListSearchResult.Count % chunkSize;
                if(chunkRemainder != 0) {
                    int j = 0;
                    for (int i = 0; i < numberOfChunks; i++) {
                        List<Card> regularChunk = new List<Card>();
                        while(j < chunkSize * (i + 1)) {
                            regularChunk.Add(cardListSearchResult[j]);
                            j++;
                        }
                        chunks.Add(regularChunk);
                    }
                    List<Card> partialChunk = new List<Card>();
                    for (int k = 0; k < chunkRemainder; k++) {
                        partialChunk.Add(cardListSearchResult[k + j]);
                    }
                    chunks.Add(partialChunk);
                }
                else {
                    int j = 0;
                    for (int i = 0; i < numberOfChunks; i++) {
                        List<Card> regularChunk = new List<Card>();
                        while (j < chunkSize * (i + 1)) {
                            regularChunk.Add(cardListSearchResult[j]);
                            j++;
                        }
                        chunks.Add(regularChunk);
                    }
                }
            }
            return chunks;
        }
    }
}