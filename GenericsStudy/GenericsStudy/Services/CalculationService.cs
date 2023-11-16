using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsStudy.Services
{
    internal class CalculationService

    {


      
        public T MaxPrice<T>(List<T> list) where T : IComparable
        {

            if (list.Count == 0)
            {
                throw new ArgumentException("The list can not be empty");


            }

            T max = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }

            return max;



        }






    }
}
