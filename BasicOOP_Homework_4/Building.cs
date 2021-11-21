using System;

namespace BasicOOP_DZ4
{
    public class Building
    {
        private static int number { get; set; } 
        private float height { get; set; }  
        private int floors { get; set; }  
        private int apartments { get; set; } 
        private int entrance { get; set; } 


        public Building(float height, int floors, int apartments, int entrance)
        {
            this.height = height;
            this.floors = floors;
            this.apartments = apartments;
            this.entrance = entrance;
        }

        public float FloorHeight()
        {
            return height / floors;
        }

        public int ApartmentsInEntrance()
        {
            return apartments / entrance;
        }

        public int ApartmentsOnFloor()
        {
            return ApartmentsInEntrance() / floors;
        }

        public int RandomBuildingNumber()
        {
            Random rndNumber = new Random();
            int rndValue = rndNumber.Next(0, 30);
            number = rndValue;
            return number;
        }
    }
}
