using Bank.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Create the results variables*/
            List<string> tradeCategories = new List<string>();
            List<string> tradeCategoriesOK = new List<string>();

            /*Creates and initialize the porfolio*/
            List<ITrade> portfolio = new List<ITrade>();

            portfolio.Add(new Trade.Trade(2000000, "Private"));
            portfolio.Add(new Trade.Trade(400000, "Public"));
            portfolio.Add(new Trade.Trade(500000, "Public"));
            portfolio.Add(new Trade.Trade(3000000, "Public"));

            /*Fill the current variable to return*/
            foreach (var t in portfolio)
            {
                tradeCategories.Add(t.getRisk());
            }

            /*Fill the correct variable to compare*/
            tradeCategoriesOK.Add("HIGHRISK");
            tradeCategoriesOK.Add("LOWRISK");
            tradeCategoriesOK.Add("LOWRISK");
            tradeCategoriesOK.Add("MEDIUMRISK");

            /*Compare the results*/
            if (Enumerable.SequenceEqual(tradeCategories, tradeCategoriesOK))
            {
                Console.WriteLine("The trades risk results are OK.");
            }

            /*Waits for the user*/
            Console.Read();

        }
    }
}
