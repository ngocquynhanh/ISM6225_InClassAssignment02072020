using System;

namespace ISM6225_InClassAssignment02072020
{
    class Car
    {
        public string model;
        public string color;
        public int maxSpeed;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Car ford = new Car();
                ford.model = "Mustang";
                ford.color = "red";
                ford.maxSpeed = 200;
                ford.year = 2019;

                Car gmc = new Car();
                gmc.model = "Chevy Equinox";
                gmc.color = "black";
                gmc.maxSpeed = 160;
                gmc.year = 2015;

                Console.WriteLine(ford.model);
                Console.WriteLine(gmc.model);

                ford.fullThrottle();
            }
        }
    }