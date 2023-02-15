using DotNetCore_Project.Interfaces;

namespace DotNetCore_Project.Implementation
{
    public class RectangleService : IRectangleService
    {
        public int AreaOfRectangle(int length, int breadth)
        {
            if (length <= 0 || breadth <= 0) throw new Exception();

            var res = length * breadth;

            return res;
        }
    }
}