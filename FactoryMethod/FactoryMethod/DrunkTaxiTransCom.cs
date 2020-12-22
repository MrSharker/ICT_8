using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrunkTaxiTransCom : TransportCompany
    {
        public DrunkTaxiTransCom(string name)
        : base(name)
        { }
        public override TransportService Create(string n, int c)
        {
            return new DrunkDriverService(Name, c);
        }
    }
}
