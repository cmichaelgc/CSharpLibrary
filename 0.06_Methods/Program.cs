﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer theJSWizard = new Customer();
            theJSWizard.AppearsWealthy = false;
            theJSWizard.FirstName = "James";
            theJSWizard.LastName = "Handshoe";
            theJSWizard.Email = "JSwizzard@aol.com";


            theJSWizard.PrintCustomerName();


            Customer theSheriff = new Customer();
            theSheriff.FirstName = "Sheriff";
            theSheriff.LastName = "Holler";
            theSheriff.PrintCustomerName();


            Customer johnnyCash = new Customer();
            johnnyCash.FirstName = "John";
            johnnyCash.LastName = "Cash";
            johnnyCash.PrintCustomerName();


            Console.ReadLine();
        }
    }
}