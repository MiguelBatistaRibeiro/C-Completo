using System;
using System.Collections.Generic;

namespace GenericsRestrictions.Services
{
    class CalculationService
    {   
        // Apenas método T. 
        public T Max<T>(List<T> list) where T : IComparable // Para CompareTo 
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("A lista não pode ficar vazia");
            }
            // Usar de IComparable - Comparar
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