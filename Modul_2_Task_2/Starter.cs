using System;

using Modul_2_Task_2.Services;
using Modul_2_Task_2.Entities;
using Modul_2_Task_2.Entities.Abstract;
using Modul_2_Task_2.Entities.Cookies;
using Modul_2_Task_2.Helpers;

namespace Modul_2_Task_2
{
    public class Starter
    {
        private readonly string _firstNameItem = "Maria";
        private readonly string _secondNameItem = "VobroCheri";
        private readonly string _thirdNameItem = "Barbarian";
        private readonly string _fourthNameItem = "Crack";

        public void Run()
        {
            var giftGenerator = new GiftGenerator();
            var gift = giftGenerator.GenerateGift(200);
            if (gift != null)
            {
                foreach (var item in gift.GetConfections())
                {
                    Console.WriteLine($"Name:{item.Name}  Manufacturer:{item.Manufacturer}  ConfectionWeight:{item.ConfectionWeight}");
                }

                var arrayOfFoundConfectionery = new Confection[4];
                arrayOfFoundConfectionery[0] = gift.FindConfections(_firstNameItem);
                arrayOfFoundConfectionery[1] = gift.FindConfections(_secondNameItem);
                arrayOfFoundConfectionery[2] = gift.FindConfections(_thirdNameItem);
                arrayOfFoundConfectionery[3] = gift.FindConfections(_fourthNameItem);
                Console.WriteLine();

                foreach (var foundItem in arrayOfFoundConfectionery)
                {
                    if (foundItem != null)
                    {
                        Console.WriteLine($"Item was found in gift: {foundItem.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"Item was not found in gift");
                    }
                }
            }
        }
    }
}
