using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenICT3
{
    public class Recipe
    {
        string name;
        int portion;
        List<Ingredient> ingredients;

        public Recipe(string n, int p/*, List<Ingredient> ingr*/) 
        {
            name = n;
            portion = p;
            //ingredients = ingr;
        }

        public override string ToString()
        {
            return name;
        }

    }
}
