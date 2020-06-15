using System;

namespace zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.Write("Введите количество элементов массива: "); //по условию задачи у нас 100 элементов, я делаю в общем виде (для любого количества элементов)
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" "); //здесь и далее я использую этот прием исключительно для красоты вывода
            int[] s = new int[a]; //ввожу массив
            for (int i=0; i<s.Length; i++)
            {
                Console.Write("Введите {0} элемент массива: ", i + 1);
                s[i]=int.Parse(Console.ReadLine()); //при помощи parse перевожу строку в число для дальнейшей работы
            }
            Console.WriteLine(" ");
            Console.WriteLine("Введенный массив: ");//вывожу исходный массив одной строкой
            for (int i=0; i<s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine(" ");
            for (b = 0; b< a; b++); //здесь начинается сортировка (методом "пузырька") в порядке возрастания
            {
                for (int i=0; i<s.Length-1; i++)
                {
                    if (s[i]>s[i+1])
                    {
                        c = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = c;
                    }
                }
            }
            Console.WriteLine(" ");
            Console.WriteLine("Отсортированный в порядке возрастания массив: "); //вывод массива, отсортированного в порядке возрастания
            for (int i=0; i<s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Отсортированный в порядке убывания массив: ");
            for (b=0; b<a; b++) //здесь сортировка в порядке убывания
            { 
                for (int i=0; i<s.Length-1; i++)
                {
                    if (s[i]<s[i+1])
                    {
                        c = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = c;

                    }
                }
            }
            for (int i=0; i<s.Length; i++)//этот цикл для вывода массива, отсортированного уже в порядке убывания
            {
                Console.Write(s[i] + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}
