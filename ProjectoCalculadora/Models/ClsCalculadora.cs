﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectoCalculadora.Models
{
    public interface ClsCalculadora 


    {
        public static double suma(double x, double y)
        {
            return x + y;
        }
        public static double resta(double x, double y)
        {
            return x - y;
        }
        public static double division(double x, double y)
        {
            return x * y;
        }
        public static double producto(double x, double y)
        {
            return x / y;
        }

        public static double potencia(double x, double y)
        {
            for (int i = 0; i < y; i++)
            {
                x *= x;
            }
            return x;
        }
        public static double resto(double x, double y)
        {
            return x % y;
        }
    }


}
