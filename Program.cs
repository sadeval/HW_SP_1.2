using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {

        Process process = new Process();

        process.StartInfo.FileName = "notepad.exe";

        process.Start();
        Console.WriteLine("Процесс 'Блокнот' запущен.");

        Console.WriteLine("Выберите действие:");
        Console.WriteLine("1. Дождаться завершения процесса.");
        Console.WriteLine("2. Принудительно завершить процесс.");
        Console.Write("Ваш выбор: ");
        string? choice = Console.ReadLine();

        if (choice == "1")
        {
            process.WaitForExit();

            int exitCode = process.ExitCode;
            Console.WriteLine($"Процесс завершен с кодом: {exitCode}");
        }
        else if (choice == "2")
        {
            process.Kill();
            Console.WriteLine("Процесс был принудительно завершен.");
        }
        else
        {
            Console.WriteLine("Неверный выбор.");
        }

        Console.WriteLine("Программа завершена.");
    }
}
