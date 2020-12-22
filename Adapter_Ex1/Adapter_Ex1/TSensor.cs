using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Ex1
{
    class TSensor : IClimate
    {
        Random r;

        public TSensor()
        {
            r = new Random();
        }
        public int GetTemperature()
        {
            //Случаное число от -40 до 104 градусов Фаренгейта (от -40 до 40 Цельсия).
            int res = r.Next(105) - 40;
            return res;
        }

    }
}
