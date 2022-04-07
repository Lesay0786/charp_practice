using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Task1
{
    public class Motorycle
    {
        private int _id;
        private string _model;
        private string _manufacturer;
        private int _mileage;
        private DateOnly _yearOfIssue;

        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                if (value.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Model is empty");
                }
                else
                {
                    _model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                if (value.Equals(string.Empty, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Manufacturer is empty");
                }
                else
                {
                    _manufacturer = value;
                }
            }
        }

        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (_mileage <= 100)
                {
                    _mileage = value;
                }
                else
                {
                    Console.WriteLine("Пробег не должен превышать 100");
                }
            }
        }

        public Engine Engine { get; set; }

        public Motorycle(int id, string model, string manufacturer, int mileage, Engine engine)
        {
            Id = id;
            Model = model;
            Manufacturer = manufacturer;
            Mileage = mileage;
            _yearOfIssue = DateOnly.FromDateTime(DateTime.Now);
            Engine = engine;
        }

        protected void Reset()
        {
            Mileage = default;
        }

        public override string ToString()
        {
            int number = default;
            return $"{++number}.Мотоцикл(Производитель): {Manufacturer}, Модель: {Model}, Идентификатор: {Id}, Год: {_yearOfIssue.Year}\n" +
                $" {number}.{number}.Двигатель(Тип): {Engine.TypeEngine.Type}, Объем: {Engine.Volume} см3, Мощность: {Engine.EnginePower} л.с.";
        }
    }
}