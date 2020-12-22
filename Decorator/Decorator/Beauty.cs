using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Beauty : DecoratorOptions
    {
        public Beauty(AutoBase p, string t) : base(p, t)
        {
            AutoProperty = p;
            Name = p.Name + ". Оснащен неоновой подсветкой";
            Description = p.Description + ". " + this.Title + ". Подсветка днища, " +
                "Неоновые фары";
        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 20.99;
        }
    }
}
