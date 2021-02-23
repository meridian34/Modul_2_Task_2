using System;
using Modul_2_Task_2.Helpers;
using Modul_2_Task_2.Entities.Abstract;

namespace Modul_2_Task_2.Entities
{
    public class Gift
    {
        private readonly Confection[] _confections;

        public Gift(Confection[] confections)
        {
            _confections = confections;
            Array.Sort(_confections, new ConfectionComparer());
        }

        public Confection[] GetConfections()
        {
            return _confections;
        }
    }
}
