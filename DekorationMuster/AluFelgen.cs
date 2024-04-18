using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    internal class AluFelgen : Dekorierer
    {
        Auto auto;
        public AluFelgen(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }
        public override string getAustattung()
        {
            return auto.getAustattung() + " mit Alufelgen ,";
        }
        public override double getPreis()
        {
            return auto.getPreis() + 7500.50;
        }
    }
}
