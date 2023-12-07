namespace Homework4
{
    internal class Cylinder
    {
        public static double getArea(float radius, float height)
        {
            return (2 * Math.PI * radius * (radius + height));

        }
        public static double getPerimeter(float radius, float height)
        {
            return 2 * Math.PI * radius * height;

        }
    }
}
