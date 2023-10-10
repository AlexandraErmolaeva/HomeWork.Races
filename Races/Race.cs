namespace Races
{
    internal class Race
    {
        // Метод: Определить ничью
        public bool IsDrawnRace(int firstCarAccelerationTime, int secondCarAccelerationTime)
            => firstCarAccelerationTime == secondCarAccelerationTime;

        // Метод: Определить победителя
        public bool IsFirstCarWin(int firstCarAccelerationTime, int secondCarAccelerationTime)
                => firstCarAccelerationTime > secondCarAccelerationTime;

        // Метод: Определить результат гонки
        public string GeneralResult(bool drawnResult, bool resultWin)
        {
            if (drawnResult == true)
                return "Машина #1 и Машина #2 приехали в одно время. Результат гонки: ничья.";
            else if (resultWin == true)
                return "Машина #1 выиграла в гонке.";
            else
                return "Машина #2 выиграла в гонке.";
        }
    }
}
