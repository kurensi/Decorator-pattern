using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    public class Radio : Dekorierer
    {
        Auto auto;
        public Radio(Auto my_AutoModel)
        {
            auto = my_AutoModel;
        }
        public override string getAustattung()
        {
            return auto.getAustattung() + " ein Super Radio ";
        }
        public override double getPreis()
        {
            return auto.getPreis() + 1520.50;
        }
    }
}
