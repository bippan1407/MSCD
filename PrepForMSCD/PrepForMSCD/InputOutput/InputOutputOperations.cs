using System;
using System.IO;

namespace PrepForMSCD.InputOutput
{
    public class InputOutputOperations
    {
        public void Appendtext()
        {
            string dummyLines = "\nThis is first line." + "\n" +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

            string currentDirectory = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\WorkingOn").FullName;
            string fileName = "editingFile.txt";
            string fullPath = currentDirectory + "\\" + fileName;
            string copyFullPath = currentDirectory + "\\abc.txt";

            using (FileStream file = File.Open(fullPath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                try
                {
                    StreamWriter sw = new StreamWriter(file);
                    sw.WriteLine(dummyLines);
                    sw.Flush();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.StackTrace);
                }
                try
                {
                    StreamReader sr = new StreamReader(file);
                    file.Position = 0;
                    Console.WriteLine(sr.ReadToEnd());
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.StackTrace);
                }
            }
            if (File.Exists(copyFullPath))
            {
                File.Delete(copyFullPath);
                Console.WriteLine("Deleting file");
            }
                File.Copy(fullPath,copyFullPath);
        }
    }
}

