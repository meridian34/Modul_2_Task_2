using System;
using Modul_2_Task_2.Entities;
using Modul_2_Task_2.Entities.Candies;
using Modul_2_Task_2.Entities.Cookies;
using Modul_2_Task_2.Entities.Abstract;

namespace Modul_2_Task_2.Services
{
    public class GiftGenerator
    {
        private readonly Random _random;
        private readonly int _minRandValue;
        private readonly int _maxRandValue;

        public GiftGenerator()
        {
            _minRandValue = 0;
            _maxRandValue = 12;
            _random = new Random();
        }

        public Gift GenerateGift(int maxWeightInGramm)
        {
            var confections = new Confection[1];
            var currentSize = 0;
            var pointer = 0;

            while (currentSize <= maxWeightInGramm)
            {
                switch (_random.Next(_minRandValue, _maxRandValue))
                {
                    case 0:
                        confections[pointer] = new GelatinCandy();
                        break;
                    case 1:
                        confections[pointer] = new Lollipop();
                        break;
                    case 2:
                        confections[pointer] = new MarmeladeCandy();
                        break;
                    case 3:
                        confections[pointer] = new MonMilk();
                        break;
                    case 4:
                        confections[pointer] = new Toffees();
                        break;
                    case 5:
                        confections[pointer] = new VobroCheriCandy();
                        break;
                    case 6:
                        confections[pointer] = new AnniversaryCookies();
                        break;
                    case 7:
                        confections[pointer] = new CheckerboardCookie();
                        break;
                    case 8:
                        confections[pointer] = new Childhood();
                        break;
                    case 9:
                        confections[pointer] = new ClassicCracker();
                        break;
                    case 10:
                        confections[pointer] = new Maria();
                        break;
                    case 11:
                        confections[pointer] = new SaltyCracker();
                        break;
                }

                currentSize += confections[pointer].ConfectionWeight;

                if (currentSize >= maxWeightInGramm)
                {
                    break;
                }

                Array.Resize(ref confections, confections.Length + 1);
                pointer++;
            }

            return new Gift(confections);
        }
    }
}
