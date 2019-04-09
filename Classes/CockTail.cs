using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Classes
{
    class Program
    {
        public static void Main()
        {

            var bartender = new Bartender();
            //var martini = new Cocktail(
            //    new Ingredient { Name = "Gin", Type = IngredientType.Wet },
            //    new Ingredient { Name = "Vermouth", Type = IngredientType.Wet },
            //    new Ingredient { Name = "Olives", Type = IngredientType.Garnish }
            //);
            //martini.Mix();
            //bartender.Pour(martini);

            var martini = Cocktail.ingredients;
            Cocktail.Mix();
            bartender.Pour(Cocktail.mixture);

        }

        // Make this class static
        public static class Cocktail
        {
            //private readonly Ingredient[] ingredients;
            //private Mixture mixture;
            //public bool Mixed { get; private set; }

            //public Cocktail(params Ingredient[] ingredients)
            //{
            //    this.ingredients = ingredients;
            //}

            //static fields
            public static Ingredient[] ingredients;
            public static Mixture mixture;

            public static bool Mixed { get; private set; }

            //static constructor
            static Cocktail()
            {
                ingredients = new[]
                {
                    new Ingredient {Name = "Gin", Type = IngredientType.Wet},
                    new Ingredient {Name = "Vermouth", Type = IngredientType.Wet},
                    new Ingredient {Name = "Olives", Type = IngredientType.Garnish}
                };
            }

            public static void Mix()
            {
                mixture = new Mixture(ingredients.Where(i => i.Type != IngredientType.Garnish).ToArray());
                Mixed = true;
            }
        }

        public class Ingredient
        {
            public string Name { get; set; }
            public IngredientType Type { get; set; }
        }

        public enum IngredientType
        {
            Garnish,
            Dry,
            Wet
        }

        public class Mixture
        {
            private readonly Ingredient[] _ingredients;

            public Mixture(Ingredient[] ingredients)
            {
                _ingredients = ingredients;
            }
        }

        class Glass
        {
            //private Cocktail cocktail;
            private Mixture mixture;

            public void Fill(Mixture mixture)
            {
                this.mixture = mixture;
            }
        }

        class Bartender
        {
            //public Glass Pour(Cocktail cocktail)
            //{
            //    if (!cocktail.Mixed)
            //    {
            //        throw new Exception("Cocktail is not mixed");
            //    }
            //}

            public Glass Pour(Mixture mixture)
            {
                if (!Cocktail.Mixed)
                {
                    throw new Exception("Cocktail is not hybrid flow");
                }

                var glass = new Glass();
                glass.Fill(mixture);//glass.Fill(cocktail);
                return glass;

            }
        }

    }
}