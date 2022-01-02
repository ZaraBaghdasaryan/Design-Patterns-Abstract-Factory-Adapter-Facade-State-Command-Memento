using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Adapter
{
    internal class StringService : IStringService
    {
        public ReturningStrings returningStrings { get; set; }
        public PrintingInts printingInts { get; set; }

        public StringService()
        {
            returningStrings = new ReturningStrings();
            printingInts = new PrintingInts();
        }

        public PrintingInts Print(int number)
        {
            //var numbers = returningStrings.ReturnString();
            //return numbers...
            throw new NotImplementedException();
        }

    }

}

//Target - PrintingInts 
//Adaptee - Returning Strings
//Adapter - StringService

//Employee - PrintingInts
//RecordSaver - ReturningSTrings
//EmployeeService - StringService 