namespace TestingCode
//working in this section, this family
{
    class Program
    //these things will be related
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World!");

            NewFunction();
            //this function does not return any value

            Console.WriteLine("Currently running in Main()");

            PrintValue( 6 );
            //function that only accepts a value
            //where we passed a value to a function


            string returned;
            //created a variable that's empty 

            returned = GetString();
            //put value into variable by calling a function 

            Console.WriteLine(returned);

            for ( int i = 0; i < 5; i++)
            {
                NewFunction();
                //loop will call this function - will print it out
                //can you a loop to call a function multiple times
            }   
        }

        static string GetString()
        //returns a string but have not accepted anything
        {
            string x = "hello there!";
            return x;
            //the x variable only exists in the this function 
        }
        static void NewFunction()
        {
            Console.WriteLine("Currently running NewFunction()");
        }

        static void PrintValue(int num)
        //accepts an integer
        {
            Console.WriteLine("PrintValue was passed: " + num);
            //prints the string and cantenate the integer     
        }
    }
}
