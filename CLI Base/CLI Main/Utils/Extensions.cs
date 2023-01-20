using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLI.Main.Utils
{
    public static class Extensions
    {
        public static T[] SubArray<T>(this T[] array, int index, int lenght)
        {
            T[] auxArray = new T[lenght];

            Array.Copy(array, index, auxArray, 0, lenght);
            return auxArray;
        }
    }
}
