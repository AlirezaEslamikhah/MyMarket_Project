
using System.Collections.Generic;
using P9.Shared;

namespace p9.client.Mydata
{
    public static class cart
    {
        public static List<Clothe> kala = new List<Clothe>();
        public static int total =0;
        public static int calc()
        {
            foreach (var item in kala)
            {
                total = total + item.Price;
            }
            return total;
        }
    }
    
    
}