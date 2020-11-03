using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predator_prey_model_WindowsFormsApp
{
    public class HandlerClass
    {
        public static double[,] ArrayVP(double sourceV, double sourceP, int t, double h)
        {
            double a = 0.1;
            double b = 0.001;
            double c = 0.05;
            double d = 0.00005;

            double k1_V, k2_V, k3_V, k4_V, k1_P, k2_P, k3_P, k4_P;

            double[,] arrayReturn = new double[2,t];

            for (int i = 0; i < t; i++)
            {
                k1_V = h * (a - b * sourceP) * sourceV;
                k2_V = h * (a - b * sourceP) * (sourceV + k1_V / 2);
                k3_V = h * (a - b * sourceP) * (sourceV + k2_V / 2);
                k4_V = h * (a - b * sourceP) * (sourceV + k3_V / 2);

                k1_P = h * (-c + d * sourceV) * sourceP;
                k2_P = h * (-c + d * sourceV) * (sourceP + k1_P / 2);
                k3_P = h * (-c + d * sourceV) * (sourceP + k2_P / 2);
                k4_P = h * (-c + d * sourceV) * (sourceP + k3_P / 2);

                sourceV = Math.Round(sourceV + (k1_V + 2 * k2_V + 2 * k3_V + k4_V)/6);
                sourceP = Math.Round(sourceP + (k1_P + 2 * k2_P + 2 * k3_P + k4_P)/6);

                arrayReturn[0, i] = sourceV;
                arrayReturn[1, i] = sourceP;
            }

            return arrayReturn;
        }
    }
}
