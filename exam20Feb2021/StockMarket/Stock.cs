using System.Text;

namespace StockMarket
{
    public class Stock
    {
        public Stock(string name, string director, decimal pricePerShare, int totalNumberOfShares)
        {
            Name = name;
            Director = director;
            PricePerShare = pricePerShare;
            TotalNumberOfShares = totalNumberOfShares;
            
        }
     
        public string Name { get; set; }
        public string Director { get; set; }
        public decimal PricePerShare { get; set; }
        public int TotalNumberOfShares { get; set; }
        public decimal MarketCapitalization => TotalNumberOfShares * PricePerShare;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Company: {this.Name}");
            sb.AppendLine($"Director: {this.Director}");
            sb.AppendLine($"Price per share: ${this.PricePerShare}");
            sb.AppendLine($"Market capitalization: ${this.MarketCapitalization}");

            return sb.ToString().Trim();
        }
    }
}
