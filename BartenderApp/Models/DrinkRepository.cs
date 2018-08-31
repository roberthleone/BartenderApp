using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderApp.Models
{
    public class DrinkRepository
    {
        private static DrinkRepository sharedRepository = new DrinkRepository();
    
        private Dictionary<string, Drink> drinks = new Dictionary<string, Drink>();

        public static DrinkRepository SharedRepository => sharedRepository;

        public DrinkRepository()
        {
            var initialItems = new[]
            {
                new Drink
                {
                    Name = "Man-garita",
                    Price = 11.99M,
                    Description = "The delicious margarita you know, dressed for business.",
                    Ingredients = "lime juice sweetened with agave nectar, 1800 tequila (anejo), and grand marnier"
                },
                new Drink
                {
                    Name = "Wo-Man-hattan",
                    Price = 12.95M,
                    Description = "Classy sassy, and flashy. Get on this metro alcoholic island.",
                    Ingredients = "bourbon, sweet vermouth, aromatic bitters, cherry garnish"
                },
                new Drink
                {
                    Name = "Van Gough Man-go Sour",
                    Price = 9.50M,
                    Description = "Sweet treats and good times.",
                    Ingredients = "mango nectar, vodka, lemon juice, fine granulated sugar, fresh mango spear garnish"
                },
                new Drink
                {
                    Name = "Man-ta Ray",
                    Price = 14.95M,
                    Description = "A great gin cocktail named after the Manta Ray.",
                    Ingredients = "tanqueray London dry gin, bitters, sweet vermouth, ice, orange twist"
                },
                new Drink
                {
                    Name = "Martini",
                    Price = 8.99M,
                    Description = "Just be you. Straight or not. Dirty or not. Perfect or not. Like you.",
                    Ingredients = "aviation american gin, dry vermouth, whatever wets your whistle"
                }
            };

            foreach (var d in initialItems)
            {
                AddDrink(d);
            }
        }

        public DrinkRepository(Drink aDrink)
        {
            var vOrderQueue = new[]
            {
                new Drink
                {
                    Name = aDrink.Name,
                    Price = aDrink.Price,
                    Description = aDrink.Description,
                    Ingredients = aDrink.Ingredients
                }
            };

            foreach (var orderedDrink in vOrderQueue)
            { 
                AddDrink(orderedDrink);
            }
        }

        public IEnumerable<Drink> Drinks => drinks.Values;

        public void AddDrink(Drink d) => drinks.Add(d.Name, d);
    }
}
