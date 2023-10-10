// Есть 2 сущности:
//      Машины двух марок
// Сущности имеют: 
//      Марку, модель, мощность, время разгона (от 0 до 100)
// Сущности могут: 
//      Выиграть | проиграть | иметь одинаковые результаты
using Races;

public class Program
{
    public static void Main()
    {
        string[] marks = { "BMW", "Audi", "Mercedes", "Reno" };
        string[] models = { "M111", "M222", "M333", "M101" };
        int[] power = { 5, 4, 3, 7 };

        var carGeneration = new CarGeneration();

        int[] accelerationTime = carGeneration.GetRandomArrayForAcceleration(5);

        // Можно ли делать такой перенос строк?
        var firstCar = new Car(carGeneration.GetRandomMark(marks), carGeneration.GetRandomModel(models),
            carGeneration.GetRandomPower(power), carGeneration.GetRandomAccelerationTime(accelerationTime));

        var secondCar = new Car(carGeneration.GetRandomMark(marks), carGeneration.GetRandomModel(models),
            carGeneration.GetRandomPower(power), carGeneration.GetRandomAccelerationTime(accelerationTime));

        // Вывод машины #1
        Console.WriteLine($"Машина #1:\n" +
            $"{firstCar.PrintCar(firstCar.Mark, firstCar.Model, firstCar.Power, firstCar.AccelerationTime)}");

        var sign = new string('*', 15);
        Console.WriteLine(sign);
        Thread.Sleep(450);

        // Вывод машины #2
        Console.WriteLine($"Машина #2:\n" +
            $"{firstCar.PrintCar(secondCar.Mark, secondCar.Model, secondCar.Power, secondCar.AccelerationTime)}");

        Console.WriteLine(sign);
        Thread.Sleep(450);

        var race = new Race();

        // Забираем значение ничьи
        var drawnResult = race.IsDrawnRace(firstCar.AccelerationTime, secondCar.AccelerationTime);

        // Забираем значение победителя
        var resultWin = race.IsFirstCarWin(firstCar.AccelerationTime, secondCar.AccelerationTime);

        // Определяем и выводим: ничью | победителя
        Console.WriteLine(race.GeneralResult(drawnResult, resultWin));

        Console.ReadKey();
    }
}

