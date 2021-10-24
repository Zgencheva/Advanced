using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarket
{
    public class Investor
    {
        public Investor(string fullName, string emailAddress, decimal moneyToInvest, string brokerName)
        {
            FullName = fullName;
            EmailAddress = emailAddress;
            MoneyToInvest = moneyToInvest;
            BrokerName = brokerName;
            this.Portfolio = new List<Stock>();
        }

        public List<Stock> Portfolio { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public decimal MoneyToInvest { get; set; }
        public string BrokerName { get; set; }

        public int Count => this.Portfolio.Count;
        public void BuyStock(Stock stock)
        {
            if (Portfolio.Any(x=> x.Name == stock.Name))
            {
                return;
            }
            if (stock.MarketCapitalization <= 10000)
            {
                return;
            }
            if (stock.PricePerShare > MoneyToInvest)
            {
                return;
            }
            Portfolio.Add(stock);
            MoneyToInvest -= stock.PricePerShare;
        }

        public string SellStock(string companyName, decimal sellPrice)
        {
            if (Portfolio.Any(x=> x.Name == companyName))
            {
                Stock currentStock = Portfolio.Where(x=> x.Name == companyName).FirstOrDefault();
                if (sellPrice < currentStock.PricePerShare )
                {
                    return $"Cannot sell {companyName}.";
                }
                else
                {
                    Portfolio.Remove(currentStock);
                    MoneyToInvest += sellPrice;
                    return $"{companyName} was sold.";
                }
            }
            else
            {
                return $"{companyName} does not exist.";
            }
        }

        public Stock FindStock(string companyName)
        {
            return Portfolio.FirstOrDefault(x=> x.Name == companyName);
        }

        public Stock FindBiggestCompany()
        {
            if (Portfolio.Count == 0)
            {
                return null;
            }
            else
            {
                return Portfolio.OrderByDescending(x => x.MarketCapitalization).First();
            }
        }
        public string InvestorInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The investor {this.FullName} with a broker {this.BrokerName} has stocks:");
            if (Portfolio.Count != 0)
            {
                foreach (Stock stock in Portfolio)
                {
                    sb.AppendLine(stock.ToString());
                }
            }

            return sb.ToString().Trim();
        }

    }
}
