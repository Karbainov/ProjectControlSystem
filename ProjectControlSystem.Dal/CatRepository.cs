using ProjectControlSystem.Core;

namespace ProjectControlSystem.Dal
{
    public class CatRepository
    {
        public CatModel GetCat()
        {
            return new CatModel() {Name="Борис", Age=1};
        }
    }
}
