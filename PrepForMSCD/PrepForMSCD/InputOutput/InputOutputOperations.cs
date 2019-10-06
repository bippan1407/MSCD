using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace PrepForMSCD.InputOutput
{
    public class InputOutputOperations
    {
        string currentDirectory = Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\WorkingOn").FullName;

        public void Appendtext()
        {
            string dummyLines = "\nThis is first line." + "\n" +
                    "This is second line." + Environment.NewLine +
                    "This is third line.";

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

        public void DriveInformation()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if(drive.IsReady == true)
                {
                    Console.WriteLine(drive.Name);
                    Console.WriteLine(drive.TotalSize/(1024*1024*1024));
                    Console.WriteLine(drive.TotalFreeSpace);
                    Console.WriteLine(drive.AvailableFreeSpace);
                    Console.WriteLine(drive.DriveFormat);
                    Console.WriteLine(drive.DriveType);
                }
            }
        }

        public void CompressionAndDecompression()
        {
            string folder = currentDirectory;
            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");
            byte[] dataToCompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();
            using (FileStream uncompressedFileStream = File.Create(uncompressedFilePath))
            {
                uncompressedFileStream.Write(dataToCompress, 0, dataToCompress.Length);
            }
            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(
             compressedFileStream, CompressionMode.Compress))
                {
                    compressionStream.Write(dataToCompress, 0, dataToCompress.Length);
                }
            }
        }
    }
}

