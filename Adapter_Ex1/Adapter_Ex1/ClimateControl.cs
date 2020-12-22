using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Ex1
{
    class ClimateControl
    {
        public string Name { get; set; }
        public ClimateControl(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name;
        }
        public int ChangeTemp(IClimate ts)
        {
            //Климат контроллер изменяет температуру полученную от датчика до 23 градусов Цельсия (комфортные человеку)
            return 23 - ts.GetTemperature();
        }
    }
}
