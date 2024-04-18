using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    public class Ledersitze : Dekorierer
    {
        Auto auto;
        public Ledersitze(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }
        public override string getAustattung()
        {
            return auto.getAustattung() + " mit Ledersitze ,";
        }
        public override double getPreis()
        {
            return auto.getPreis()+4500.50;
        }
    }
}
