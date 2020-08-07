
using Bank.Risk;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Trade
{
    public class Trade : ITrade
    {
        protected IRisk _iRisk;
        protected double _value;
        protected string _clientSector;
        double ITrade.Value => _value;
        string ITrade.ClientSector => _clientSector;

        public Trade(double value, string clientSector)
        {
            this._value = value;
            this._clientSector = clientSector;

            this._iRisk = new Risk.Risk(this);

        }

        public string getRisk()
        {
            return _iRisk.GetRisk();
        }


        
    }
}
