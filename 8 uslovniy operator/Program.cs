﻿using System;

namespace _8_uslovniy_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretPassword = "123";
            int numberOfAttempts = 3;
            string userInput;
            string secretmassege = "секретное сообщение";

            for (int i = 1; i <= numberOfAttempts; i++)
            {
                Console.WriteLine($"Попытка {i}/{numberOfAttempts}");
                Console.Write("Введите пароль: ");
                userInput = Console.ReadLine();

                if (userInput == secretPassword)
                {
                    Console.WriteLine(secretmassege);
                    break;
                }
                else
                {
                    Console.WriteLine("Пароль не верен");
                }
            }
        }
    }
}
