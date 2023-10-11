using MenuOpt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class TasksMenu
    {
        // Абстрактный класс, чтобы не повторять создание и вывод
        private Menu MenuCreateShowArr(TaskBase task, string message)
        {
            Menu menu = new Menu(new[] {
                new Options("Создание", task.Create),
                new Options("Вывод", task.Show)},
                message);
            return menu;
        }

        public void Task1()
        {
            Task1 task = new Task1();

            var menu = MenuCreateShowArr(task, "Работа с одномерным double массивом");
            menu.AddOption(new Options("Удалить элементы кратные минимальному", task.RemoveElementsMultiplesMinimum));

            menu.ShowMenu();
        }

        public void Task2()
        {
            Task2 task = new Task2();

            var menu = MenuCreateShowArr(task, "Работа со строкой");
            menu.AddOption(new Options("Сдвинуть циклически влево", task.MoveLeft));

            menu.ShowMenu();
        }

    }
}
