using System;
using System.Collections.Generic;

namespace FizFuzProj
{
    public class FizFuz
    {

        public string Execute(int input)
        {
            List<object> result = new List<object>();
            for (int i = 1; i <= input; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    result.Add("FizFuz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Fuz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fiz");
                }
                else
                {
                    result.Add(i);
                }
            }
            return string.Join(",",result.ToArray());
        }
    }
}
