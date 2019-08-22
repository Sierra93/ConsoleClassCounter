using System;

namespace ConsoleClassCounter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Введите номер пункта: \n" +
                "1 - Увеличить счетчик\n" +
                "2 - Уменьшить счетчик\n" +
                "3 - Получить текущее состояние счетчика");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check) {
                case 1:
                    Counter.PozitiveCounter();
                    break;
                case 2:
                    Counter.NegativeCounter();
                    break;
                case 3:
                    Counter.InfoValue();
                    break;
            }
            Console.ReadKey();
        }
    }
    class Counter {
        internal static int startDiapazon = 1; 
        internal static int endDiapazon = 10;
        internal static int infoValue {
            get {
                return startDiapazon;
            }
        }
        // Метод увеличения счетчика
        internal static void PozitiveCounter() {
            Console.WriteLine($"Начальное значение счетчика: {startDiapazon}");
            Console.WriteLine("Введите значение в диапазоне от 1 до 10: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if ((value >= startDiapazon) && (value <= endDiapazon)) {
                value++;
            }
            Console.WriteLine($"Увеличенное значение: {value}");
        }
        // Метод уменьшения счетчика
        internal static void NegativeCounter() {
            Console.WriteLine("Введите значение в диапазоне от 1 до 10: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if ((value >= startDiapazon) && (value <= endDiapazon)) {
                value--;
            }
            Console.WriteLine($"Увеличенное значение: {value}");
        }
        // Метод получения текущего состояния счетчика
        internal static void InfoValue() {
            Console.WriteLine($"Текущее состояние счетчика: {infoValue}");
        }
    }
}
