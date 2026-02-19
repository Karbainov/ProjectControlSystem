using ProjectControlSystem.Core;
using ProjectControlSystem.Dal;

namespace ForDebug
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = new CatRepository();

            var i= a.GetCat();
        }
    }
}
