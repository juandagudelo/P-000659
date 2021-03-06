﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeStringsApp
{
    class Program
    {
        public const string YES_ANSWER = "y";
        public const string TITLE_APP = "Merge Strings App";
        public const string EXIT_APP_QUESTION = "Do you want to exit? Y/N";
        public const string STRING_ONE_MESSAGE = "String 1: ";
        public const string STRING_TWO_MESSAGE = "String 2: ";

        public static bool CloseApp { get; set; }

        static void Main(string[] args)
        {
            CloseApp = false;
            Console.WriteLine(TITLE_APP);

            while (!CloseApp)
            {
                StringService stringService = new StringService();

                Console.WriteLine(STRING_ONE_MESSAGE);
                stringService.SaveStringAsCharList(Console.ReadLine());

                Console.WriteLine(STRING_TWO_MESSAGE);
                stringService.SaveStringAsCharList(Console.ReadLine());

                stringService.MergeStrings();
                Console.WriteLine(EXIT_APP_QUESTION);
                CloseApp = Console.ReadLine().ToLower() == YES_ANSWER;

            }
        }

    }
}
