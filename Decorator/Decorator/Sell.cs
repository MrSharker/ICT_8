using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Sell : DecoratorOptions
    {
        public Sell(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". " + "Последнее предложение";
            Description = p.Description + ". " + this.Title + " Может стать твоим, катайся с удовольствием.";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
