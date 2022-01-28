using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis;
            //''Oled sündinud aastal {yearOfBirth}";

            Console.WriteLine("Palun, sisesta oma vanus:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            //Console.WriteLine("Oled sündinud " + userAge + " aastal.");

            //või teine variant
            //string interpolation

            Console.WriteLine($"Oled sündinud {userAge} aastal.");

        }
    }
}
