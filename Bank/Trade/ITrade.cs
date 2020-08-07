using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Trade
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }

        string getRisk();
    }
}
