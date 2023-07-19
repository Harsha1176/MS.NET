﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBILoanApplication_Abstraction
{
    public abstract class CommonDBTask
    {
        public string Id;
        public string IUserId;
        public string UUserId;
        public DateTime IDate;
        public DateTime UDate;
        public string IPAddress;

        public abstract void InsertData();
    }

    public class StudentDBTask : CommonDBTask
    {
        public string Name;
        public string Course;
        public override void InsertData()
        {
            Console.WriteLine("Hello" + Name);
        }
    }
}