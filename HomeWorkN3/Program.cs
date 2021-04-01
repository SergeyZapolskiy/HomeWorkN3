using System;
using System.Collections.Generic;
using System.Globalization;

namespace HomeWorkN3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbersCollection();
            SortNumbersCollection();
            Console.WriteLine($"{NeedNumber()}");
            Console.ReadLine();
        }

        static List<int> numberCollection = new List<int>();

        static List<int> sortCollection = SortNumbersCollection();
        static string NeedNumber()
        {

            string aReturn = "";
            if (sortCollection.Count > 1)
            {
                aReturn = Convert.ToString(sortCollection[sortCollection.Count - 2]);

            }
            else
            {
                Console.WriteLine("V vashei kollekcii ne dostatochno cifr!");
            }
            return aReturn;
        
        }
        
        static List<int> GetNumbersCollection()
        {
            int x = 0;
            bool y = true;
            while (y)
            {
                Console.WriteLine("Vvedite chislo:\n");
                try
                {
                    x = Convert.ToInt32(Console.ReadLine(), CultureInfo.CurrentCulture);
                    numberCollection.Add(x);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Vi vveli kakuyu-to chush! Poprobuite snova");
                }
                
                Console.WriteLine("Esli gelaete dobavit' chislo vvedite 1\nEsli chisel v kollekcii dostatochno vvedite lyubuyu cifru ili bukvu");
                string resolution = Console.ReadLine();

                if (resolution == "1")
                {
                    y = true;
                }
                else
                {
                    y = false;
                }
                    
            }
            return numberCollection;
        
        }
        
        static List<int> SortNumbersCollection ()
        {
            List<int> NumbersCollection = numberCollection;
            NumbersCollection.Sort();
            return NumbersCollection;
        }
       
    }
}
