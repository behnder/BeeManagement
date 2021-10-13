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
     

        public static string StatusReport
        {
            get
            {
                string status;
                if(honey < LOW_LEVEL_WARNING)
                {
                    status = $"Amount of Honey: {honey}\nAmount of Nectar: {nectar}\n LOW HONEY, add a HONEY MANUFACTURER";
                }
                else
                {
                    status = $"Amount of Honey: {honey}\nAmount of Nectar: {nectar}";
                }
                if(nectar < LOW_LEVEL_WARNING)
                {
                    status += $"\n LOW NECTAR, add a NECTAR COLLECTOR";
                }
                return status;

            }
        }

        public static void CollectNectar(float amount)
        {
            if (amount > 0)
            {
                honey += amount;
            }
        }
        public static void ConverterNectarToHoney(float amount)
        {
            if (amount < nectar)
            {
                honey += nectar * NECTAR_CONVERSION;
                return;
            }
            honey += amount * NECTAR_CONVERSION;
            nectar -= amount;
        }

        public static bool ConsumeHoney(float amount)
        {
            if (amount > honey)
            {
                honey -= amount;
                return true;
            }
            return false;
        }
    }
}
