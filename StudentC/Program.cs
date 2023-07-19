using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace StudentC
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string path = @"C:\Users\omkar\source\repos\ClassLibrary1\bin\Debug\ClassLibrary1.dll";


            //try
            //{
            //    Assembly obj = Assembly.LoadFile(path);
            //    Console.WriteLine(obj.GetName().Name);
            //    Console.WriteLine(obj.GetName().Version);
            //    Console.WriteLine(obj.GlobalAssemblyCache);
            //    foreach (Type type in obj.GetTypes())
            //    {
            //        Console.WriteLine(type.FullName);// it will give all classes available in assembly
            //    }

            //    //Type type = obj.GetType();
            //    //MethodInfo[] m1 = type.GetMethods();
            //    //foreach (MethodInfo m2 in m1)
            //    //{
            //    //    Console.WriteLine(m2.Name);         //it get full method info of assembly
            //    //}

            //}
            //catch (Exception ex) { }

            //Console.ReadKey();
            //===========================================================================================================================================
            //file example
            //string filepath = @"C:\Example\test.txt";
            //File.WriteAllText(filepath, "Hello World Ramkumar");

            //bool fileexist = File.Exists(filepath);
            //Console.WriteLine("File Exist" + fileexist);
            //string filecontent = File.ReadAllText(filepath);
            //Console.WriteLine(filecontent);

            //Console.ReadKey();
            //File.Delete(filepath);
            //Console.ReadKey();

            //====================================================================================================================
           //// //file example
           //// string filepath = @"C:\Example\test.txt";
           //// File.WriteAllText(filepath, "Hello World Ramkumar");

           //// FileInfo fileInfo = new FileInfo(filepath);
           //// Console.WriteLine(fileInfo.FullName);
           //// Console.WriteLine(fileInfo.Exists);
           //// Console.WriteLine(fileInfo.Length);
           //// Console.WriteLine(fileInfo.CreationTime);
           //// Console.WriteLine(fileInfo.LastWriteTime);
           ////// fileInfo.Delete();
           //// //Console.WriteLine(fileInfo.LastWriteTimeUtc);
           //// Console.ReadKey();


            //File,FileInfo
            //Directory/DirectoryInfo
            //FileStream,StreamReader/StreamWriter
            //BinaryForatter/XmlSerializer
            //TextReader/TestWriter
            //GzipStream
            //===================================================================================================================================================================================
            //folder directory exmple

            string folderpath = @"C:\Example\1920";
            Directory.CreateDirectory(folderpath);
            Console.WriteLine(Directory.Exists(folderpath));

            string[] files = Directory.GetFiles(folderpath);
            Console.WriteLine("Files is Directory");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Directory.Exists(folderpath);


            ////DirectoryInfo directoryInfo = new DirectoryInfo(folderpath);

            ////if (directoryInfo.Exists)
            ////{
            ////    FileInfo[] fileInfos = directoryInfo.GetFiles();
            ////    foreach (FileInfo fileInfo in fileInfos)
            ////    {
            ////        Console.WriteLine($"{fileInfo.Name}: {fileInfo.CreationTime} : {fileInfo.Extension}");
            ////    }
            ////}


            //Directory.Delete(folderpath,true);
            Console.ReadKey();










            //=================================================================================================================================================
            //Console.WriteLine(Utils.Add(2,4));
            //Console.WriteLine(Utils.Sub(8, 4));
            //Console.WriteLine(Utils.Mul(4, 4));
            //Console.WriteLine(Utils.Div(2, 4));
            //Console.WriteLine(Utils.ReferenceEquals(4, 4));
            //Console.WriteLine(Utils.Equals(4, 4));
            //Console.ReadKey();

        }
    }
}
    