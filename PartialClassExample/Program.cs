using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Finance finance = new Finance(23, "demo");
            Console.WriteLine(finance.Income);
            Console.WriteLine(finance.CmpName);    
            finance.SHowGST();
            Console.ReadKey();
        }
    }


    public partial class Finance
    {
        public decimal Income { get; set; }

        public string CmpName { get; set; }
    }
    public partial class Finance
    {
        public Finance(decimal income, string CmpName)
        {
            this.Income = income;
            this.CmpName = CmpName;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Income + "" + CmpName);
        }
        //public partial void PrintTestData();

    }













}
