using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MenuOpt;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TasksMenu tasks = new TasksMenu();

            Options[] options = new Options[]
            {
                new Options("Первое задание (одномерный double массив); ", tasks.Task1),
                new Options("Второе задание (работа со строками). ", tasks.Task2)

            };
            Menu menu = new Menu(options);
            menu.ShowMenu();
        }
    }
}
