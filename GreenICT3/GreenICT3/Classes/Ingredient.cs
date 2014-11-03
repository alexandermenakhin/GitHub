using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenICT3
{
    public class Ingredient
    {
        string name;
        int stockAmount, limit, usage, price, id;

        public Ingredient(string n, int sa, int l, int u, int p, int i)
        {
            name = n;
            stockAmount = sa;
            limit = l;
            usage = u;
            price = p;
            id = i;
        }
    }
}
