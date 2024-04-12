namespace Recipe
{
    public class Class1
    {
        private string[] ingredients;
        private string[] steps;

        public Recipe()
        {
            Console.WriteLine("Nsovo Recipe App!");
            EnterIngredients();
            EnterSteps();
            DisplayRecipe();
        }

        private void EnterIngredients()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());
            ingredients = new string[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.Write($"Enter the name of ingredient {i + 1}: ");
                string ingredientName = Console.ReadLine();

                Console.Write($"Enter the quantity of {ingredientName}: ");
                string quantity = Console.ReadLine();

                Console.Write($"Enter the unit of measurement for {ingredientName}: ");
                string unit = Console.ReadLine();

                ingredients[i] = $"{quantity} {unit} of {ingredientName}";
            }
        }

        private void EnterSteps()
        {
            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }

        private void DisplayRecipe()
        {
            Console.WriteLine("\nRecipe Details:");
            Console.WriteLine("Ingredients:");
            foreach (string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }
    }
}
    }
}
