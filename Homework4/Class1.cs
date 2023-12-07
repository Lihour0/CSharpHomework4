namespace Homework4
{
    internal class Class1
    {

        float miles = 0f;
        public void input()
        {
            Console.WriteLine("Input Miles to convert to Kilometer");
            miles = float.Parse(Console.ReadLine());
        }
        public void output()
        {

            Console.WriteLine("{0} miles to kilometer is {1}.", miles, miles * 1.609344);
        }


    }
}
