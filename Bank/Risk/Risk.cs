using Bank.Trade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Risk
{
    public class Risk : IRisk
    {

        private IRisk _risk;

        public Risk(ITrade trade)
        {
            if (trade.Value < 1000000)
            {
                if (trade.ClientSector == "Public") this._risk = new LowRisk();
            }
            else if (trade.Value > 1000000)
            {
                if (trade.ClientSector == "Public") this._risk = new MediumRisk();
                else this._risk = new HighRisk();
            }

            if (this._risk == null) this._risk = new NoFoundRisk();
        }

        public string GetRisk()
        {
            return _risk.GetRisk();
        }
    }
}
