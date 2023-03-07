using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaEttTal
{
    public class LowScore
    {
        public string _Namn;
        public DateTime _Date;
        public int _Rundor;

        public LowScore(string namn, DateTime date, int rundor)
        {
            _Date = date;
            _Rundor = rundor;
            _Namn = namn;
        }
    }
}
