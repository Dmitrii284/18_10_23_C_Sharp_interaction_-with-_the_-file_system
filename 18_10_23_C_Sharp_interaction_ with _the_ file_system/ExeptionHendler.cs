using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace _18_10_23_C_Sharp_interaction__with__the__file_system
{
    public class ExeptionHendler
    {
        
        private string filePath = $"{Directory.GetCurrentDirectory()}\\ExeptionHend.txt";
        public string GetFilePath() { return this.filePath; }

        public void Writer()
        {
            if (File.Exists(filePath) != true)
            {
                File.Create(filePath);
            }            

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Дата и время создания файла: {DateTime.Now}");
            }

            using (StreamReader reader = new StreamReader(filePath, true))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }


        }


        public void Print()
        {
            Console.WriteLine(filePath);
        }
    }


}



