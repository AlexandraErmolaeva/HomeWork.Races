// Генерирование свойств авто

namespace Races
{
    internal class CarGeneration
    {
        // Метод: Генерация чисел для массива "Временя разгона". Как упростить метод?
        public int[] GetRandomArrayForAcceleration(int arrayLenght)
        {
            int[] accelerationTime = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
                accelerationTime[i] = new Random().Next(0, 100);
            return accelerationTime;
        }

        // Метод: Генерация марки авто
        public string GetRandomMark(string[] marks)
            => marks[new Random().Next(marks.Length)];

        // Метод: Генерация модели авто
        public string GetRandomModel(string[] models)
            => models[new Random().Next(models.Length)];

        // Метод: Генерация мощности авто
        public int GetRandomPower(int[] power)
            => power[new Random().Next(power.Length)];

        // Метод: Генерация времени разгона
        public int GetRandomAccelerationTime(int[] accelerationTime)
            => accelerationTime[new Random().Next(accelerationTime.Length)];

    }
}


