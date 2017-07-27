using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    public class Card
    {
        public int Value { get; set; }

        public Card()
        {
            Value = -1;
        }

        public Card(int value) : this()
        {
            this.Value = value;
        }
    }
}
