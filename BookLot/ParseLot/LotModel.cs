using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseLot
{
    public class LotModel
    {
        public string Flight { get; set; }
        public string Day { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
        public Type Type { get; set; }
        public string Price { get; set; }
    }

    public enum Type
    {
        Economy,
        PremiumEconomy,
        Business
    }
}
