using System;
using System.IO;
using System.Text;

namespace StringReaderWriterDemo
{
    class StringReaderWriterEX
    {
        StringBuilder SB = new StringBuilder();
        public StringReaderWriterEX()
        {
            Writer();

            Reader();
        }
        static void Main(string[] args)
        {
            
            //File.Create(@"D:\wizzie\DOT NET\StringReadWrite.txt");
            //FileInfo f1 = new FileInfo(@"D:\wizzie\DOT NET\StringReadWrite.txt");
            //Console.WriteLine(f1.Exists);
            //Console.WriteLine(f1.Extension);
            


            
        }
        public void Writer()
        {
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
        public void Reader()
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
}
