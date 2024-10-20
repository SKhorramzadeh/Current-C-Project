namespace Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Get the name of user.
            Console.WriteLine("Enter your name ...");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");

            //Get the age of user
            string Age;
            int iAge;
            Console.WriteLine("Enter your age ...");
            Age = Console.ReadLine();
            iAge = int.Parse(Age);
            //Check if the age is between 18 and 120 or not?
            for (; ; )
            {
                if (iAge > 18 && iAge < 120)
                {
                    Console.WriteLine("Your age is passed");
                    break;
                }
                else
                {
                    Console.WriteLine("Your age must be between 15 and 120. Try again ...");
                    Age = Console.ReadLine();
                    iAge = int.Parse(Age);
                }
            }

            //Get the Pone number of user.
            string P;
            long iP;
            Console.WriteLine("Enter phone number!");
            P = Console.ReadLine();
            
            //Check if the entered number is 11 digit or not?
            for (; ; )
            {
                if (P.Length != 11)
                {
                    Console.WriteLine("Enter phone number with 11 digit! Try again ...");
                    P = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            //Check if the entered number started with 0 or not?
            for (; ; )
            {             
                if (!P.StartsWith("0"))
                {
                    Console.WriteLine("Yuor phone number must start with 0! Try again ...");
                    P = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            //Chek if all entered characters are number or not?
            for (; ; )
            {
                try
                {
                    iP = long.Parse(P);
                    Console.WriteLine("The Entered number is correct.");
                    break;
                }
                catch
                {
                    Console.WriteLine("You are allowed just to enter digits. Try again ...");
                    P = Console.ReadLine();
                }


            }















        }
    }
}
