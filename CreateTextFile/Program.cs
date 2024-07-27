namespace CreateTextFile
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                try
                {
                    TextWriter tw = new StreamWriter("D:\\CreatedText.txt", true);
                    tw.WriteLine("New text file is created");
                    tw.Close();
                    Console.WriteLine("File Created");
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                Console.Read();
            }
        }
    }

