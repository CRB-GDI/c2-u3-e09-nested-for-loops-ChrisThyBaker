namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks for input of the number of "*" per row in int
            Console.WriteLine("enter the number of asterisks you want in a row as an int ");
            int NumberOfAsterisks1 = int.Parse(Console.ReadLine());

            //asks for input of the number of rows to print in int
            Console.WriteLine("enter the number of rows of asterisks you want as an int ");
            int NumberOfRowsWanted1 = int.Parse(Console.ReadLine());
          

            //printing the number of "*" per row and rows wanted
            for (NumberOfRowsWanted1 = NumberOfRowsWanted1 ; NumberOfRowsWanted1 > 0 ; NumberOfRowsWanted1-- )
            {
                int AsterisksPrinted = NumberOfAsterisks1;
                for (AsterisksPrinted = AsterisksPrinted; AsterisksPrinted > 0 ; AsterisksPrinted--)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();
            }

            //asking for imput as in int for rows of asterisks, adding 1 to the asterisk in each row,
            Console.WriteLine("enter the amount of rows you want as an int");
            int Rows = int.Parse(Console.ReadLine());
            
            //printing the amount of rows the user wanted + starting at one asterisk adding one asterisk every row printed
            for (int i = 0; i <= Rows ; i++)
            {
                for (int j = 0; j <= i ; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            

        }
    }
}