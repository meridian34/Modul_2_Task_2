using System.Collections.Generic;
using Modul_2_Task_2.Entities.Abstract;

namespace Modul_2_Task_2.Helpers
{
    public class ConfectionComparer : IComparer<Confection>
    {
        private readonly int _theEqualityValueInTheSortOrde = 0;

        public int Compare(Confection x, Confection y)
        {
            var returnCode = string.Compare(x.Manufacturer, y.Manufacturer);

            if (returnCode == _theEqualityValueInTheSortOrde)
            {
                return string.Compare(x.Name, y.Name);
            }

            return returnCode;
        }
    }
}
