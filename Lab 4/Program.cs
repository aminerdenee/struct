﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        public struct Person
        {
            string name;
            int age;
            string gender;
            string phone;
            public void input()
            {
                name = Console.ReadLine();
                age = Convert.ToInt32(Console.ReadLine());
                gender = Console.ReadLine();
                phone = Console.ReadLine();
            }
            public void print()
            {
                Console.WriteLine("{0,15:C} {1,5:NO} {2,10:C} {3,12:C}", name, age, gender, phone);
            }
        }
        static void Main(string[] args)
        {

            Person[] p = new Person[5];
            for (int i = 0; i < p.Length; i++)
                p[i].input();
            for (int i = 0; i < p.Length; i++)
                p[i].print();
            Console.Read();
        }
    }
}
