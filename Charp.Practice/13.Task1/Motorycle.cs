using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Task1
{
    internal class Motorycle
    {
        public int Id
        {
            get
            {
                return Id;
            }
            private set
            {
                Id = value;
            }
        }
        public string? Model { get; set; }
        public string? Manufacturer { get; set; }
       
        public DateTime YearOfIssue
        {
            get
            {
                return YearOfIssue;
            } 
            set
            {
                YearOfIssue = DateTime.Now;
            }
        }
        public int Mileage
        {
            get
            {
                return Mileage;
            }
            set
            {
                if (Mileage <= 100)
                {
                    Mileage = value;
                }
                else
                {
                    Console.WriteLine("Пробег не должен превышать 100");
                }
            }
        }

        public Motorycle(string model, string mo)
        {

        }
        protected void Reset()
        {
            Mileage = default;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
