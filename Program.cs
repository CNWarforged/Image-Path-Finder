class ImagePathFinder
{
    public static int Main()
    {
        string tempPath = "Temp_Num.txt";
        string imgPath = "Image_Path.txt";
        string path = @"C:\Users\shini\Documents\CS 361\Cyber-Tarot-Core\images\Cards\";
        if (File.Exists(tempPath) == false)
        {
            Console.WriteLine("File not found.");
            
            return 1;
        }

        ReadFile(path, imgPath, tempPath);
       
        return 0;
    }

    public static void ReadFile(string cardPath, string imgPath, string tempPath)
    {
        string words = "";
        
        try
        {
            using (StreamReader readIn = new StreamReader(tempPath))
            {
                string newReading = readIn.ReadToEnd();
                if (newReading != null)
                {
                    words = newReading;
                }
                else
                {
                    Console.Write("Null file.");
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error reading the file. Error is:");
            Console.WriteLine(e.Message);
        }

        WriteFile(cardPath + words + ".png", imgPath);
    }

    public static void WriteFile(string text, string cardPath)
    {
        try
        {
            using (StreamWriter writeOut = new StreamWriter(cardPath))
            {
                writeOut.Write(text);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error writing to the file. Error is:");
            Console.WriteLine(e.Message);
        }
    }
}