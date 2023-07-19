using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
//<summury>
//CMP
//FT -> FullTime
// CT -> Contract 
//DA -> Daily
//WE-> Weekly
//</summary>






    internal class CalSal1
    {


        
      public  decimal CalculateSalary(string empType,int pf=100)
        {
            decimal salary= 0;
            decimal bs = 500;

            switch (empType)
            {
                case "FT":
                    salary = bs+pf;
                    break;
                case "CT":
                case "DA":
                case "WE":
                    salary = bs; 
                    break;

            }
            return salary;
        }










    }
}
