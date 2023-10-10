namespace Races
{
    internal class Car
    {
        public string Mark { get; set; }
        public string Model { get; set; }
        public int Power { get; set; }
        public int AccelerationTime { get; set; }

        public Car(string mark, string model, int power, int accelerationTime)
        {
            Mark = mark;
            Model = model;
            Power = power;
            AccelerationTime = accelerationTime;
        }
        public string PrintCar(string mark, string model, int power, int accelerationTime)
            => $"Марка: {mark}\nМодель: {model}\nМощность: {power}\nРазгон: {accelerationTime}";


    }
}
