
namespace CookingInstruction
{
    public class FoodRecipeController
    {
        // برای کار با فایل ها
        private readonly IFoodRecipeRepository ـfoodRecipeRepository;
        // برای تعامل با کاربر
        private readonly IUserInteraction ـuserInteraction;
        //فال ذخیره
        private readonly string filepath="Recipe.txt";
    
        // این کلاس چون وابستگی دارد و ساخت کلاس هایی که بهش وابسته است را به عهده دارد
        //برای همین کلاس هایی که میسازه رو به عنوان پارامتر ووردی کانستراکتور قرار دادیم.
        //هرکسی از این کلاس قرار هست استفاده کند مسئول این هست این وابستگی را پس بدهد
        public FoodRecipeController (IFoodRecipeRepository foodRecipeController , IUserInteraction userInteraction )
        {
            ـfoodRecipeRepository = foodRecipeController;
            ـuserInteraction = userInteraction;
        }
        internal void Execute()
        {
            // خواندن دستور عمل های غذا به همراه مسیر فایل
            var recipes = ـfoodRecipeRepository.GetAll(filepath);
            //نمایش دستور پخت ها در صفحه
            ـuserInteraction.PrintRecipes(recipes);

            // دریافت دستور پخت های جدید
            var recipe = ـuserInteraction.GetRecipe();

            if (recipe == null)
            {
                ـuserInteraction.PrintMessage("Recipe is null");
            }
            else
            {
                ـuserInteraction.PrintMessage("Recipe Recieved");
                //اضافه کردن به لیست دستور پخت ها
                recipes.Add(recipe);
                ـfoodRecipeRepository.Save(recipes);
            }
            ـuserInteraction.PrintMessage("Finish");
        }
    }
}