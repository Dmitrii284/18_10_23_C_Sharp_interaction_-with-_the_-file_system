
/*interaction with the file system
 * 
 * Работа с файловой системой
 * 
 * 
 * В C# тип файла создается с помощью создания класса и заданием его свойств и методов. Вот пример создания типа файла в C#:

public class File
{
    public string Name { get; set; }
    public string Extension { get; set; }
    public long Size { get; set; }

    public void Open()
    {
        // Add code to open the file
    }

    public void Save()
    {
        // Add code to save the file
    }
}

В этом примере класс "File" имеет три свойства: Name (название файла), Extension (расширение файла) и Size (размер файла). 
Класс также имеет два метода: Open() и Save(), которые могут быть заполнены соответствующим кодом для открытия и сохранения файла.

Вы можете использовать этот тип файла в своей программе следующим образом:

File myFile = new File();
myFile.Name = "example";
myFile.Extension = ".txt";
myFile.Size = 1024;

myFile.Open();
myFile.Save();

В этом примере мы создаем экземпляр класса "File" с именем "myFile" и задаем значения свойств.
Затем мы вызываем методы Open() и Save() для этого экземпляра класса.
 
..\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
FileStream

\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\

FileStream является классом в C#, который позволяет работать с файлами на более низком уровне, таким как чтение и запись байтов. 

Вы можете создать экземпляр класса FileStream с помощью конструктора и передать ему имя файла, режим доступа и необязательные флаги.
Вот пример создания FileStream:

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        
        // Создание FileStream для чтения файла
        FileStream fileStreamRead = new FileStream(filePath, FileMode.Open, FileAccess.Read);

        // Создание FileStream для записи в файл
        FileStream fileStreamWrite = new FileStream(filePath, FileMode.Create, FileAccess.Write);

        // Создание FileStream для чтения и записи в файл
        FileStream fileStreamReadWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        
        // Ваш код для работы с FileStream
        
        // Закрытие FileStream после использования
        fileStreamRead.Close();
        fileStreamWrite.Close();
        fileStreamReadWrite.Close();
    }
}

В этом примере мы создаем три экземпляра класса FileStream с использованием разных режимов доступа: чтение, запись и чтение/запись.
Затем вы можете использовать созданные объекты FileStream для чтения и записи в файл. 
Не забудьте закрыть FileStream после использования с помощью метода Close(),
чтобы освободить ресурсы.


 */
using System.IO;
using System.Reflection;
using System.Data.Common;

namespace _18_10_23_C_Sharp_interaction__with__the__file_system
{


    public class Logger
    {
        public Logger() { }

    }
    internal class Program
    {        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //StreamReader

            //FileInfo file = new FileInfo("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt");
            //file.Create("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt");
            //file.CopyTo("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple1.txt ");
            //file.Delete();
            //file.Encrypt();
            //FileStream(string filename, FileMode.Open, FileAccess.Read, FileShare.Read);


            //string filePath = "C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt";
            //if (File.Exists(filePath))
            //{
            //    Console.WriteLine();          

            //    using (StreamWriter writer = new StreamWriter("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt", true))
            //    {
            //        writer.WriteLine("Hello, World!");
            //    }

            //    using (StreamReader reader = new StreamReader("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt", true))
            //    {
            //        string line = reader.ReadLine();
            //        Console.WriteLine(line);
            //    }

            //    using(FileStream fstream = new FileStream(" ", FileMode.Create))
            //    {
            //        //Console.WriteLine(fstream.ToString());

            //    }
            //}
            //else
            //{
            //    File.Create("C:\\Users\\Студент\\source\\repos\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\18_10_23_C_Sharp_interaction_ with _the_ file_system\\exemple.txt");
            //}


            // Задача создать файл Дата время и он должен выводить все методв которые есть в исключени ExeptionHendler


            ExeptionHendler exeptionHendler = new ExeptionHendler();

            exeptionHendler.Writer();
            exeptionHendler.Print();






            
        }
    }
    
}