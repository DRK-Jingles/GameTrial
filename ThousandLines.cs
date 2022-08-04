using System;
using System.IO;
using System.Text;

public class Example
{
    public static void ThousandLines()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Random rnd = new Random();
        StringBuilder sb = new StringBuilder();
        StreamWriter sw = new StreamWriter(@".\StringFile.txt", false, Encoding.Unicode);

        for (int ctr = 0; ctr <= 1000; ctr++)
        {
            sb.Append((char)rnd.Next(1, 0x0530));
            if (sb.Length % 60 == 0)
                sb.AppendLine();
        }
        Console.Write(sb.ToString());
        sw.Close();
    }
}