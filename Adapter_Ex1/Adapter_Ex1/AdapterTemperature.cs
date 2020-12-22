using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Ex1
{
    class AdapterTemperature : IClimate
    {
        TSensor ts;

        public AdapterTemperature(TSensor ts)
        {
            this.ts = ts;
        }
        public int GetTemperature()
        {
            //Преобразование Фаренгейтов в Цельсии
            return (ts.GetTemperature() - 32) * 5 / 9;
        }
    }
}
