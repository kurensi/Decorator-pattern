using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    public  class Porsche : Auto
    {
        public Porsche()
        {
            austattung = " Porsche 911 ";
        }

        public override double getPreis()
        {
            return 135000;
        }
    }
}
