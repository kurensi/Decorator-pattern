using System;
using System.Collections.Generic;
using System.Text;

namespace DekorationMuster
{
    public abstract class Auto
    {
        public string austattung;

        public virtual string getAustattung()
        {
            return austattung;
        }

        public abstract double getPreis();
    }
}
