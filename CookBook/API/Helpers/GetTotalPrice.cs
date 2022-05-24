using API.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class GetTotalPrice
    {

        public static float getTotal(float kolicina, EnumUnits unit, float sastojciKolicina, float cijena, EnumUnits sastojciUnit)
        {

            if (unit == sastojciUnit)
            {
                float x = sastojciKolicina / kolicina;
                float y = cijena / x;
                return (float)Math.Round(y * 100f) / 100f;
            }

            if (unit == EnumUnits.g)
            {
                if (sastojciUnit == EnumUnits.kg)
                {
                    float x = sastojciKolicina * 1000;
                    float z = x / kolicina;
                    float y = cijena / z;
                    return (float)Math.Round(y * 100f) / 100f;

                }
            }

            if (unit == EnumUnits.ml)
            {
                if (sastojciUnit == EnumUnits.l)
                {
                    float x = sastojciKolicina * 1000;
                    float z = x / kolicina;
                    float y = cijena / z;
                    return (float)Math.Round(y * 100f) / 100f;
                }
            }

            if (unit == EnumUnits.kg)
            {
                if (sastojciUnit == EnumUnits.g)
                {
                    float x = kolicina * 1000;
                    float z = x / sastojciKolicina;
                    float y = cijena * z;
                    return (float)Math.Round(y * 100f) / 100f;

                }
            }

            if (unit == EnumUnits.l)
            {
                if (sastojciUnit == EnumUnits.ml)
                {
                    float x = kolicina * 1000;
                    float z = x / sastojciKolicina;
                    float y = cijena * z;
                    return (float)Math.Round(y * 100f) / 100f;
                }
            }
            return 0f;
        }


    }
}
