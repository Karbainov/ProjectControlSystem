using ProjectControlSystem.Core;
using ProjectControlSystem.Dal;

namespace ProjectControlSystem.Bll
{
    public class CatService
    {
        public CatModel GetCat()
        {
            var a = new CatRepository();

            CatModel res= a.GetCat();
            res.Age *= 12;
            res.Name=res.Name.ToUpper();

            return res;
        }
    }
}
