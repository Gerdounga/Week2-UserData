using System;

namespace DrivingLicense
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //programm arvutab kasutaja vanust;
            //kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada";
            //kui kasutaja on vanem, kui 18, siis programm kuvab konsoolis
            //"Oled piisavalt vana, et juhilube saada'';
            //kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taotleda";
            //Ehk enne 2004. aastat sündinud saavad teha lube ja kui hiljem kui 2004.aasta ei saa

            Console.WriteLine("Palun, sisesta oma sünniaasta:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2022 - yearOfBirth;

            Console.WriteLine("Oled " + userAge + " aastat vana.");

            if (yearOfBirth < 2004)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotleda.");
            }
            else if (yearOfBirth > 2004)
            {
                Console.WriteLine("Oled liiga noor, et juhilube taotleda.");
            }
            else
            {
                Console.WriteLine("Palju õnne, oled 18! Nüüd saad sa juhilube taotleda.");
            }






        }
    }
}
