using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Risk
{
    public class HighRisk : IRisk
    {
        public string GetRisk()
        {
            return "HIGHRISK";
        }
    }
}
