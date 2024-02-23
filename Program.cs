namespace DesignPatternPrototypeHomeWork
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Демонстрация функции клонирования

            // Создаем и клонируем объекты каждого класса
            var waterBody = new WaterBody(50, 200, false);
            var clonedWaterBody1 = (WaterBody)waterBody.Clone();
            var clonedWaterBody2 = waterBody.MyClone();

            var rsrvoir = new Reservoir(20, 70, 47);
            var clonedRsrvoir1 = (Reservoir)rsrvoir.Clone();
            var clonedRsrvoir2 = rsrvoir.MyClone();

            var lake = new Lake(23620, 31722, 1642, "Baikal");
            var clonedLake1 = (Lake)lake.Clone();
            var clonedLake2 = lake.MyClone();

            var saltLake = new SaltLake(318, 106, 3, "Baskunchak", 300, SaltLakeChemicalType.Chloride);
            var clonedSaltLake1 = (SaltLake)saltLake.Clone();
            var clonedSaltLake2 = saltLake.MyClone();

            // Вывод информации о каждом клонированном объекте

            Console.WriteLine($"Cloned with Clone() WaterBody: {clonedWaterBody1}");
            Console.WriteLine($"Cloned with MyClone() WaterBody: {clonedWaterBody2}");
            Console.WriteLine($"Cloned with Clone() Reservoir: {clonedRsrvoir1}");
            Console.WriteLine($"Cloned with MyClone() Reservoir: {clonedRsrvoir2}");
            Console.WriteLine($"Cloned with Clone() Lake: {clonedLake1}");
            Console.WriteLine($"Cloned with MyClone() Lake: {clonedLake2}");
            Console.WriteLine($"Cloned with Clone() SaltLake: {clonedSaltLake1}");
            Console.WriteLine($"Cloned with MyClone() SaltLake: {clonedSaltLake2}");
            Console.Write("Press ENTER to exit... ");
            Console.ReadLine();
        }
    }
}
