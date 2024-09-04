using System;
class Program
{
    static void Main(string[] args)
    {
        // Запрос количества месяцев, прошедших с 1 января 1990 года
        Console.WriteLine("Введите количество месяцев, прошедших с 1 января 1990 года:");
        int monthsPassed = int.Parse(Console.ReadLine());

        // Массив с названиями месяцев
        string[] months = {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };

        // Определение текущего месяца
        int currentMonthIndex = (monthsPassed % 12);
        string currentMonth = months[currentMonthIndex];

        // Вывод названия текущего месяца
        Console.WriteLine($"Текущий месяц: {currentMonth}");
    }
}
