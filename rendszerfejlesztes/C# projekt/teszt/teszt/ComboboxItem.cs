using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszt
{
    internal class ComboboxItem
    {
        public string text { get; set; }
        public int value { get; set; }

        public override string ToString()
        {
            return text;
        }
    }
}
