namespace Homework4

{
    class Program
    {

        static int DEBUG = 2;
        static void Main()
        {
            if (DEBUG == 1)
            {

                Class1 test = new Class1();
                test.input();
                test.output();

            }
            else if (DEBUG == 2)
            {
                Retangle test = new Retangle();

            }
            else if (DEBUG == 3)
            {
                Cylinder test = new Cylinder();

            }
            else if (DEBUG == 4)
            {
                Emp test = new Emp();

            }
            else if (DEBUG == 5)
            {
                BankAccount test = new BankAccount("Test", 20000);


            }



        }
    }


}


