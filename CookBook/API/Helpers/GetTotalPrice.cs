using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Helpers
{
    public class GetTotalPrice
    {

        public static float getTotal(float kolicina, string unit, float sastojciKolicina, float cijena, string sastojciUnit)
        {

            if (unit == sastojciUnit)
            {
                float x = sastojciKolicina / kolicina;
                float y = cijena / x;
                return (float)Math.Round(y * 100f) / 100f;
            }

            if (unit == "g")
            {
                if (sastojciUnit == "kg")
                {
                    float x = sastojciKolicina * 1000;
                    float z = x / kolicina;
                    float y = cijena / z;
                    return (float)Math.Round(y * 100f) / 100f;

                }
            }

            if (unit == "ml")
            {
                if (sastojciUnit == "l")
                {
                    float x = sastojciKolicina * 1000;
                    float z = x / kolicina;
                    float y = cijena / z;
                    return (float)Math.Round(y * 100f) / 100f;
                }
            }

            if (unit == "kg")
            {
                if (sastojciUnit == "g")
                {
                    float x = kolicina * 1000;
                    float z = x / sastojciKolicina;
                    float y = cijena * z;
                    return (float)Math.Round(y * 100f) / 100f;

                }
            }

            if (unit == "l")
            {
                if (sastojciUnit == "ml")
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
