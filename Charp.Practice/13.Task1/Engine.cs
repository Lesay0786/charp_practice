using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Task1
{
    public class Engine 
    {
        private int _volume;
        private int _enginePower;

        public int Volume
        {
            get
            {
                return _volume;
            }
            set
            {
                if (value >= 125 && value <= 1300)
                {
                    _volume = value;
                }
                else
                {
                    Console.WriteLine("Объем не должен превышать от 125 до 1300 см3.");
                }
            }
        }

        public int EnginePower
        {
            get
            {
                return _enginePower;
            }
            set
            {
                if (value >= 50 && value <= 400)
                {
                    _enginePower = value;
                }
                else
                {
                    Console.WriteLine("Мощность не должна превышать от 50 до 400 л.с.");
                }
            }
        }

        public TypeEngine TypeEngine;

        public Engine(int volume, int enginePower, TypeEngine typeEngine)
        {
            Volume = volume;
            EnginePower = enginePower;
            TypeEngine = typeEngine;
        }
    }
}