namespace POE_Part1
{
    internal class Program
    {
       

    static string[] ingredients;
        static string[] steps;

        static void Main()
        {
            Console.WriteLine("Nsovo Recipe App!");

            //Precipitate the IngredientsReq
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

            Console.Write("Enter the number of steps: ");
            int numSteps = int.Parse(Console.ReadLine());
            steps = new string[numSteps];
            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                steps[i] = Console.ReadLine();
            }

            DisplayRecipe();
            // Display recipe details

            // Additional functionality
            // Scaling the recipe
            // Resetting quantities
            // Clearing data
            ClearData();
        }

        static void DisplayRecipe()
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

        static void ClearData()
        {
            Console.Write("Are you sure you want to clear the data? (Y/N): ");
            string response = Console.ReadLine();
            if (response.ToLower() == "y")
            {
                ingredients = null;
                steps = null;
                Console.WriteLine("Data cleared successfully.");
            }
            else
            {
                Console.WriteLine("Data not cleared.");
            }
        }
    }
}


        