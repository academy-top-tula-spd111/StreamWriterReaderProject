using System.Text;

namespace StreamWriterReaderProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileFS1 = "file1.txt";
            string fileFS2 = "file1.dat";

            // FileStrteam txt
            //Create file
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            //using(FileStream stream = File.Create(fileFS1))
            //{
            //    byte[] buffer = Encoding.Default.GetBytes(text);
            //    stream.Write(buffer, 0, buffer.Length);
            //}

            // Open for append
            //using (FileStream stream = File.Open(fileFS1, FileMode.Append))
            //{
            //    byte[] buffer = Encoding.Default.GetBytes(text);
            //    stream.Write(buffer, 0, buffer.Length);
            //}

            // Open for read
            //using (FileStream stream = File.Open(fileFS1, FileMode.Open))
            //{
            //    byte[] buffer = new byte[stream.Length];
            //    while(stream.Position < stream.Length)
            //    {
            //        stream.Read(buffer, 0, buffer.Length);
            //        string line = Encoding.Default.GetString(buffer);
            //        Console.WriteLine(line + "\n");
            //    }
            //}

            // Open and insert
            //string strInsert = " hello girls,";
            //using (FileStream stream = File.Open(fileFS1, FileMode.Open))
            //{
            //    byte[] buffer = new byte[stream.Length];
            //    stream.Read(buffer, 0, buffer.Length);
            //    string streamStr = Encoding.Default.GetString(buffer);

            //    int position = streamStr.IndexOf(',');
            //    stream.Position = ++position;

            //    byte[] bufferInsert = Encoding.Default.GetBytes(strInsert);
            //    stream.Write(bufferInsert, 0, bufferInsert.Length);
            //    stream.Write(buffer, position, buffer.Length - position);
            //}

            // StreamWriter
            string fileTS = "file2.txt";

            //using(StreamWriter writer = new StreamWriter(fileTS, false))
            //{
            //    writer.WriteLine(text);
            //}

            //using (StreamWriter writer = new StreamWriter(fileTS, true))
            //{
            //    writer.WriteLine(text);
            //}

            // StreamReader
            //using(StreamReader reader = new(fileTS))
            //{
            //    //Console.WriteLine(reader.ReadToEnd());
            //    //string? line;
            //    //while((line = reader.ReadLine()) is not null)
            //    //    Console.WriteLine(line + "\n");
            //    char[] buffer = new char[100];
            //    while(true)
            //    {
            //        int count = reader.ReadBlock(buffer, 0, buffer.Length);
            //        if (count == 0)
            //            break;
            //        Console.WriteLine(new String(buffer) + "\n");
            //    }
            //}

            // BinaryWriter

            string fileBS = "file3.dat";

            //int a = 100;
            //long b = 8677678566756;
            //float x = 233.23423f;
            //double y = 2131.2132342e3;
            //char c = '$';
            //string s = "Hello world";
            //decimal d = 123456.987m;
            //bool f = true;

            //using (BinaryWriter writer = new BinaryWriter(File.Open(fileBS, FileMode.Create)))
            //{
            //    writer.Write(a);
            //    writer.Write(b);
            //    writer.Write(x);
            //    writer.Write(y);
            //    writer.Write(c);
            //    writer.Write(s);
            //    writer.Write(d);
            //    writer.Write(f);
            //}

            //using (BinaryReader reader = new BinaryReader(File.Open(fileBS, FileMode.Open)))
            //{
            //    char n = reader.ReadChar();
            //    Console.WriteLine(n);
            //}
        }
    }
}