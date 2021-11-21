using System;

namespace BasicOOP_DZ4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту здания: ");
            float myBuldingHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество этажей в доме: ");
            int myBuldingFloors = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество квартир в доме: ");
            int myBuldingFlats = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество подъездов в доме: ");
            int myBuldingEntrance = Convert.ToInt32(Console.ReadLine());

            Building myBuilding = new Building(myBuldingHeight, myBuldingFloors, myBuldingFlats, myBuldingEntrance);
            myBuilding.ApartmentsInEntrance();
            Console.WriteLine($"Высота этажа: {myBuilding.FloorHeight()} м, " +
                              $"количество квартир в подъезде: {myBuilding.ApartmentsInEntrance()}," +
                              $"количество квартир на этаже: {myBuilding.ApartmentsOnFloor()} " +
                              $"и случайный номер дома {myBuilding.RandomBuildingNumber()}");
        }
    }
}
