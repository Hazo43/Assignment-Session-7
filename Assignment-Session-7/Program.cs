namespace Assignment_Session_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Maths

            var result01 = Maths.Add(10, 15);
            Console.WriteLine(result01);

         // ----------------------------------------------------------

            var result02 = Maths.Subtract(35, 15);
            Console.WriteLine(result02);

         // --------------------------------------------------------------
 
            var result03 = Maths.Multiply(12, 12);
            Console.WriteLine(result03);

            // ------------------------------------------------------------------

            var result04 = Maths.Divide(12, 3);
            Console.WriteLine(result04);
            // --------------------------------------------------------------------

            var result05 = Maths.Power(2, 3);
            Console.WriteLine(result05);

            // --------------------------------------------------------------------

            var result06 = Maths.Average([15,12,33,5,45]);
            Console.WriteLine(result06);


            Maths.ShowOperationCount();

            #endregion
        }
    }
}
