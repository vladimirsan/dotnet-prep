namespace dotnet_prep
{
    using System;
    using System.IO;

    class Program
    {
        private static void Main(string[] args)
        {
            string path = "../../../test-file.txt";

            //CreateFile(path);
            //string[] lines = ReadFile(path);

            // Show this as a for loop as well
            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //DeleteAFile(path);
            //AppendToFile(path);

            PracticeUsingSplit();
        }

        static void CreateFile(string path)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path))
                {
                    streamWriter.WriteLine("Gregor is the very best");
                }
                
                // Include a nested Try

                //try
                //{
                //    // Create and Use Stream
                //}
                //catch (Exception)
                //{
                //    // Handle Exception
                //    throw;
                //}
                //finally
                //{
                //    // Dispose Stream
                //}
            }
            catch (NotSupportedException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static string[] ReadFile(string path)
        {
            try
            {
                String[] myWords = File.ReadAllLines(path);
                return myWords;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void AppendToFile(string path)
        {
            try
            {
                using (StreamWriter streamWriter = File.AppendText(path))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        streamWriter.WriteLine(i);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        static void DeleteAFile(string path)
        {
            File.Delete(path);
        }

        static void PracticeUsingSplit()
        {
            char[] delimiterCharacters = {' ', ',', '.', ':', '\t' };
            string text = "one\ttwo three:four,five six seven";
            string[] words = text.Split(delimiterCharacters);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
