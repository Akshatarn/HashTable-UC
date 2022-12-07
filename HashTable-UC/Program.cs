﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_UC
{
    internal class Program
    {
        public static void CountNumbOfOccurence(string paragraph)
        {
            MyNode<string, int> hashTabe = new MyNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Please find below words with its frequency of occurrence's :- ");
            hashTabe.Display();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Demo Program on HashTables in DSA .\n");
            Console.WriteLine("Please sslect any one from below given options :\n" +
                "1 : Checking frequency of occurence of words in a single line statement (UC1).\n" +
                "2 : Checking frequency of occurence of words in a paragraph (UC2).\n");
            int option = Convert.ToInt32((string)Console.ReadLine());
            switch (option)
            {
                case 1:
                    string paragraph = "To be or not to be";//UC1 frequency of occurrence of words in a sentence .
                    CountNumbOfOccurence(paragraph);
                    Console.WriteLine();
                    break;
                case 2:                     //UC2
                    string paragraph1 = "Paranoids are not paranoid " +
                        "because they are paranoid but " +
                        "because they keep putting themselves " +
                        "deliberately into paranoid avoidable " +
                        "situations";
                    CountNumbOfOccurence(paragraph1);
                    break;
                default:
                    Console.WriteLine("Invalid option selected ! Please try again .");
                    break;
            }
        }
    }
}

