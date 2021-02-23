using Modul_2_Task_2.Entities.Abstract;
using Modul_2_Task_2.Entities;

namespace Modul_2_Task_2.Helpers
{
    public static class ExtensionGift
    {
        public static Confection FindConfections(this Gift gift, string confectionName)
        {
            foreach (var item in gift.GetConfections())
            {
                if (item.Name == confectionName)
                {
                    return item;
                }
            }

            return null;
        }

        public static Confection FindConfections(this Gift gift, string confectionName, string manufacturerName)
        {
            foreach (var item in gift.GetConfections())
            {
                if (item.Name == confectionName && item.Manufacturer == manufacturerName)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
