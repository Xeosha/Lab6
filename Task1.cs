using MenuOpt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreateShowArray;

namespace Lab6
{
    internal class Task1 : TaskBase
    {
        double[] array;
        public override void Create()
        {
            Menu menu = new Menu(new[] {
                new Options("Создание с клавиатуры", this.CreateKeyboard),
                new Options("Создание из рандомных чисел", this.CreateRandom)
            }, "Создание одномерного массива");

            menu.ShowMenu();
        }

        public void CreateKeyboard() => CreateAndDisplay<double>.Create(ref array);
        public void CreateRandom() => CreateAndDisplay<double>.CreateRandom(ref array);
        public override void Show() => CreateAndDisplay<double>.Display(array);

        public void RemoveElementsMultiplesMinimum()
        {
            if(array == null || array.Length == 0)
            {
                Console.WriteLine("Массив не создан"); return;
            }
            double min = array.Min();
            array = min != 0 ? array.Where(x => x % min != 0).ToArray() : array;
        }
    }
}
