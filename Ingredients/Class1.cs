﻿namespace Ingredients
{
    

        public class Ingredient
        {

            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }

            public Ingredient(string name, double quantity, string unit)
            {
                Name = name;
                Quantity = quantity;
                Unit = unit;
            }

            public override string ToString()
            {
                return $"{Quantity} {Unit} of {Name}";
            }
        }   
    }

