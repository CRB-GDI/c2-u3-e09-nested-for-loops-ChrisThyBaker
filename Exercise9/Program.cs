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

            int Rows = 4;
            
            for (int i = 1; i <= Rows ; i++)
            {
                for (int j = 1; j <= Rows ; j++)
                {
                    
                    Console.Write("{0," Rows}, );
                   
               

                }
                Console.WriteLine();
            }
            
            

        }
    }
}