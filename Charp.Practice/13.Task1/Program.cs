using _13.Task1;

Motorycle motorycleOne = new Motorycle(90, "H987", "Minsk", 110, new Engine(1000, 50, new TypeEngine("бензин")));
Motorycle motorycleTwo =new Motorycle(91, "X220", "Хонда", 85, new Engine(600, 66, new TypeEngine("электро")));
Motorycle motorycleThree = new Motorycle(92, "T785", "БМВ", 90, new Engine(500, 50, new TypeEngine("бензин")));

Motorycle[] arrayMotorycles = new Motorycle[] { motorycleOne, motorycleTwo, motorycleThree };

foreach (Motorycle motorycle in arrayMotorycles)
{
    Console.WriteLine(motorycle.ToString());
}