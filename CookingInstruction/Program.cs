namespace CookingInstruction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FoodRecipeController foodRecipeController = new FoodRecipeController(new FoodRecipeRepository(), new UserConsoleInteraction());
            foodRecipeController.Execute();


        }
    }
}
