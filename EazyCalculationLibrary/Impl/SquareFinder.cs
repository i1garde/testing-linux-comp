using EazyCalculationLibrary.Abstract;

namespace EazyCalculationLibrary.Impl
{
    public class SquareFinder : ISquareFinder
    {
        public float FindSquare(float a)
        {
            return a * a;
        }
    }
}