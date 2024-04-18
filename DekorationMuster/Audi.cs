using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    class Audi : Auto
    {
        public Audi()
        {
            austattung = " Audi R8 ";
        }

        public override double getPreis()
        {
            return 190000;
        }
    }
}
