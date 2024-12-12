using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeueProjektarbeit
{
    internal class Technik
    {
        private string technikList;

        public Technik(string technikList)
        {
            TechnikList = technikList;
        }
        public string TechnikList { get => technikList; set => technikList = value; }

        public override string ToString()
        {
            return TechnikList;
        }
    }
}
