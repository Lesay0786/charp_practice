using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Task1
{
    public class Engine
    {
        public int Volume
        {
            get
            {
                return Volume;
            }
            set
            {
                if (value <= 125 && value >= 1300)
                {
                    Volume = value;
                }
                else
                {
                    Console.WriteLine("Объем не должен превышать от 125 до 1300 куб. м");
                }
            }
        }
        public int Capacity
        {
            get
            {
                return Capacity;
            }
            set
            {
                if (value <= 50 || value >= 400)
                {
                    Capacity = value;
                }

                else
                {
                    Console.WriteLine("Мощность не должна превышать 50 до 400 лошб сил");
                }
            }

        }

    }
}