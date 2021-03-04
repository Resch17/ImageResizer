using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;

namespace ImageResizer
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                ErrorExit("Please follow the run command with an image path and a desired output width.");
            }

            string imagePath = args[0];

            int desiredWidth;
            bool widthTest = int.TryParse(args[1], out desiredWidth);
            if (!widthTest)
            {
                ErrorExit("Invalid width entry");
            }

            try
            {
                Image image = Image.Load(imagePath);
                Size newSize = new Size(desiredWidth, 0);
                
                image.Mutate(x => x.Resize(newSize));

                string[] splitPath = imagePath.Split('.');
                string newFilename = $"{splitPath[0]}_{image.Width}x{image.Height}.{splitPath[1]}";

                image.Save(newFilename);
            }
            catch
            {
                ErrorExit("Invalid file entry");
            }

            void ErrorExit(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
