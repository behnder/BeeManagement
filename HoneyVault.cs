using System;
using System.Collections.Generic;
using System.Text;

namespace BeehiveManagementSystem
{
    static class HoneyVault
    {
        const float NECTAR_CONVERSION = .19F;
        const float LOW_LEVEL_WARNING = 10F;

        private static float honey = 25f;
        private static float nectar = 100f;
        readonly static string StatusReport;

        static void CollectNectar()
        {

        }
        static void ConverterNectarToHoney(float amount)
        {
            if (amount < nectar)
            {
                honey += nectar * NECTAR_CONVERSION;
                return;
            }
            honey += amount * NECTAR_CONVERSION;
            nectar -= amount;
        }

        static bool ConsumeHoney()
        {
            return true;
        }
    }
}
