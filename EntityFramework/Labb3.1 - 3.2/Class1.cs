using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3._1___3._2
{
    public class Class1
    {
        Console

    }

    static class Helper
    {
        static float ConvertToFloat(string str)
        {
            float result = 0;
            float.TryParse(str, out result);
            return result;
        }
    }
}
