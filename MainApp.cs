﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력을 하고 있는지를 보자 업데이트가 됬나?: ");
            ㅎㅀㅁㅀㅁㅀ
            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
            {                                
                Console.WriteLine("음수");
            }
            else if (number > 0)
            {
                Console.WriteLine("양수");
            }
            else
                Console.WriteLine("0");

            if(number % 2 == 0)
            {
                Console.WriteLine("짝수");
            }
            else
            {
                Console.WriteLine("홀수");
            }
        }
    }
}
