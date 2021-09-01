using System;
using System.IO;
using System.Text;

namespace StringReaderWriterDemo
{
    public class StringReaderWriterOperation
    {
        StringBuilder SB = new StringBuilder();
        public void WriteString()
        {
            
            File.Create(@"D:\wizzie\DOT NET\StringReadWrite.txt");
            FileInfo f1 = new FileInfo(@"D:\wizzie\DOT NET\StringReadWrite.txt");
            Console.WriteLine(f1.Exists);
            Console.WriteLine(f1.Extension);



            StringWriter SW = new StringWriter();
            Console.WriteLine("Welcome to String Writer Program");
            SW.Write("Name: ");
            String name = Console.ReadLine();

            SW.WriteLine("NAME: " + name);
            SW.Write("Contry: ");
            String contry = Console.ReadLine();

            SW.WriteLine("Contry: " + contry);
            SW.Write("Age: ");
            string age = Console.ReadLine();

            SW.WriteLine("Age: " + age);
            SW.WriteLine("Thank you!!!");
            SW.WriteLine("Information Saved!");

            SW.Flush();
            SW.Close();
        }
        public void ReadString()
        {
            StringReader SR = new StringReader(SB.ToString());
            Console.WriteLine("Reading Profiel");
            while (SR.Peek() > -1)
            {
                Console.WriteLine(SR.ReadLine());
            }
            Console.WriteLine("DATA READ COMPLETED!!!!");
            SR.Close();
        }
    }
    class StringReaderWriterEX
    {
        
        
        static void Main(string[] args)
        {
            StringReaderWriterOperation SD = new StringReaderWriterOperation();
            SD.WriteString();
            SD.ReadString();
        }        
    }
}
