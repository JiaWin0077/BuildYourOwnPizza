using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildYourOwnPizza
{
    internal class CrustFactory
    {
        CrustIF cif;
        public CrustIF getCrustType(string str, double price)
        {
            if (str == "CrustThin")
            {
                return cif = CrustThin.createInstance(price);
            }
            else if (str == "CrustPan")
            {
                return cif = CrustPan.createInstance(price);
            }
            else if (str == "CrustStuffed")
            {
                return cif = CrustStuffed.createInstance(price);
            }
            else if (str == "CrustFlat")
            {
                return cif = CrustFlat.createInstance(price);
            }
            else
            {
                return cif;
            }
            
        }
    }
}
