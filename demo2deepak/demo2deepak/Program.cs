﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo2deepak
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // code willl come here todo by SOHAN
            // We are changing on Branch1 code by Deepak
            // changing this line again by Deepak 
             // Changing again by sohan...
            // Changing again (2) by Sohan Singh
            // changing here on MASTER by deepak

            // Branch code that needs to merge on master...on sohan's acccount
            // Macknig some changes on Branch
            testmethod();
            testmethod2();
            // Branch code that needs to merge on master...

            test();
        }

        // This method is added on Branch
        private static void testmethod() { }
        //This method implemented on MASTER
        private static void test()
        { }

        // This method is added on Branch
        private static void testmethod2()
        { }
    }
    
    }
