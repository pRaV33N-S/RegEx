using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>() { "Aman", "Amit", "Vijay", "Mohan", "Anan", "Manoj" };
            //string pattern = @"\b[M]\w+";
            
            string mobPattern = @"\\+\\^\d{10}$";
            Regex regex = new Regex(mobPattern); 
            string[] mobiles = new string[] { "+91-848487282","9876540981", "8678473738" , "+91-93837383" ,"+958595959"};
            foreach(string mobile in mobiles)
            {
                if (regex.IsMatch(mobile))
                {
                    Console.WriteLine("{0} is a valid mobile number",mobile);
                }
                else
                {
                    Console.WriteLine("{0} is not a valid mobile  number",mobile);
                }
            }
        }
    }
}
