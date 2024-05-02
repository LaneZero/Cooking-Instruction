
namespace CookingInstruction
{

    public class FoodRecipeRepository : IFoodRecipeRepository
    {
        public object GetAll(string filepath)
        {
            throw new NotImplementedException();
        }

        public void Save(object recipes)
        {
            throw new NotImplementedException();
        }
    }

    public interface IFoodRecipeRepository
    {
        object GetAll(string filepath);
        void Save(object recipes);
    }
}

