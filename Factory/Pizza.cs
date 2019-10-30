using System;
using System.Collections.Generic;
using Arcaim.DesignPatterns.Factory.Ingredients.Cakes;
using Arcaim.DesignPatterns.Factory.Ingredients.Cheeses;
using Arcaim.DesignPatterns.Factory.Ingredients.Meats;
using Arcaim.DesignPatterns.Factory.Ingredients.Sauces;
using Arcaim.DesignPatterns.Factory.Ingredients.Seafood;
using Arcaim.DesignPatterns.Factory.Ingredients.Vegetables;

namespace Arcaim.DesignPatterns.Factory
{
    public abstract class Pizza
    {
        string name;
        public Cake cake;
        public Sauce sauce;
        public Vegetable[] vegetables;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clams;

        public abstract void Preparation();

        public void Baking()
        {
            System.Console.WriteLine("Pieczenie: 25 minut w temperaturze 180 stopni Celsjusza");
        }

        public void Packing()
        {
            System.Console.WriteLine("Pakowanie pizzy w oficjalne pudełko naszej sieci");
        }

        public void Cutting()
        {
            System.Console.WriteLine("Korjenie pizzy na 8 kawałków");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            string description = $"Pizza {name} na {cake}, składniki:\n";

            if (sauce != null)
            {
                description += $"{sauce}\n";
            }
            if (pepperoni != null)
            {
                description += $"{pepperoni}\n";
            }
            if (clams != null)
            {
                description += $"{clams}\n";
            }

            if (vegetables != null)
            {
                var list = new List<Vegetable>(vegetables);

                foreach (var vegetable in list)
                {
                    description += $"{vegetable}\n";
                }
            }

            return description;
        }
    }
}