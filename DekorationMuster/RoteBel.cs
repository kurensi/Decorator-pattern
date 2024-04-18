using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    class RoteBel :Dekorierer
    {
        Auto auto;
        public RoteBel(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }
        public override string getAustattung()
        {
            return auto.getAustattung() + " mit Rotes Licht im auto ,";
        }
        public override double getPreis()
        {
            return auto.getPreis() + 1000.50;
        }
    }
}
