using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMKADOR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Имена файлов с данными и файла, в который будет записан результат расчета
            string numpkFile = "numpk.txt";
            string inputFile = "par.opt";
            string outputFile = "fun.opt";

            // Получим количество экспериментов
            string[] numpkLines = System.IO.File.ReadAllLines(numpkFile);
            int expCount = Convert.ToInt32(numpkLines[3]);
            // Считаем построчно все значения оптимизируемых параметров
            string[] inputLines = System.IO.File.ReadAllLines(inputFile);

            // Эта строка будет представлять собой результат расчета и
            // будет записана в выходной файл
            string result = string.Empty;

            // Для каждого из экспериментов
            for (int exp = 0; exp < expCount; exp++)
            {
                // delta
                // B
                // H
                double X1 = Convert.ToDouble(inputLines[exp * 27 + 0]);
                double Y1 = Convert.ToDouble(inputLines[exp * 27 + 1]);
                double X2 = Convert.ToDouble(inputLines[exp * 27 + 2]);
                double Y2 = Convert.ToDouble(inputLines[exp * 27 + 3]);
                double X3 = Convert.ToDouble(inputLines[exp * 27 + 4]);
                double Y3 = Convert.ToDouble(inputLines[exp * 27 + 5]);
                double X4 = Convert.ToDouble(inputLines[exp * 27 + 6]);
                double Y4 = Convert.ToDouble(inputLines[exp * 27 + 7]);
                double X5 = Convert.ToDouble(inputLines[exp * 27 + 8]);
                double Y5 = Convert.ToDouble(inputLines[exp * 27 + 9]);
                double X6 = Convert.ToDouble(inputLines[exp * 27 + 10]);
                double Y6 = Convert.ToDouble(inputLines[exp * 27 + 11]);
                double X7 = Convert.ToDouble(inputLines[exp * 27 + 12]);
                double Y7 = Convert.ToDouble(inputLines[exp * 27 + 13]);
                double X8 = Convert.ToDouble(inputLines[exp * 27 + 14]);
                double Y8 = Convert.ToDouble(inputLines[exp * 27 + 15]);
                double X9 = Convert.ToDouble(inputLines[exp * 27 + 16]);
                double Y9 = Convert.ToDouble(inputLines[exp * 27 + 17]);
                double L1 = Convert.ToDouble(inputLines[exp * 27 + 18]);
                double L2 = Convert.ToDouble(inputLines[exp * 27 + 19]);
                double L3 = Convert.ToDouble(inputLines[exp * 27 + 20]);
                double L4 = Convert.ToDouble(inputLines[exp * 27 + 21]);
                double L5 = Convert.ToDouble(inputLines[exp * 27 + 22]);
                double L6 = Convert.ToDouble(inputLines[exp * 27 + 23]);
                double L7 = Convert.ToDouble(inputLines[exp * 27 + 24]);
                double L8 = Convert.ToDouble(inputLines[exp * 27 + 25]);
                double L9 = Convert.ToDouble(inputLines[exp * 27 + 26]);
      
                // W
                // S
                result += ((delta * H / 6) * (H + 6 * B)).ToString();
                result += "\r\n";
                result += (delta * (B * 2 + (H - 2 * delta))).ToString();
                result += "\r\n";
                // Здесь бы рассчитывались и записывались значения функциональных ограничений

            }

            System.IO.File.WriteAllText(outputFile, result, Encoding.UTF8);

            Console.WriteLine("Нажмите любую клавишу для выхода из программы");
            Console.ReadKey();
        }	

    }
}
