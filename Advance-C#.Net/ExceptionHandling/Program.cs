using System;
using System.IO;

namespace ExceptionHandling
{
    public class ArithmeticException : Exception
    {
        public ArithmeticException(string message, Exception ex)
            : base(message, ex)
        {
        }
    }
    public class Calculator
    {
        public int Divide(int numerator, int divider)
        {
            if (divider == 0)
            {
                throw new ArithmeticException("Divide 0", new Exception("Cannot Devide to zero in Divide function"));
            }
            return numerator / divider;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                //streamReader = new StreamReader(@"D:\C#_.Net_projects\README.md");
                //var content = streamReader.ReadToEnd();
                //Console.WriteLine(content);
                
                ///// Equivalent to

                // This will automatically create finally
                using (var streamFile = new StreamReader(@"D:\C#_.Net_projects\README.md"))
                {
                    var content = streamFile.ReadToEnd();
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                streamReader?.Dispose();
            }

            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
                Console.WriteLine(result);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
