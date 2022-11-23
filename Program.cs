using System;
using System.Xml;
using System.Linq;
using static ZMGLite.JSON;
using static ZMGLite.Types;

namespace ZMGLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1 || args[0].Length < 8) // Minimum characters would be 8? (C:\0.dae) 
            {
                PrintHelp();
            }
            else
            {
                // Get file
                XmlDocument collada = new();
                collada.Load(args[0]); // 0 should be path?

                // Get materials from collada
                List<Material> materials = ColladaReader.LoadMaterialsFromCollada(collada);
                List<string> materialTextures = new();

                for (int i = 0; i < materials.Count; i++)
                {
                    materialTextures.Add(materials[i].textureName);
                }

                // Get textures from collada
                List<string> unlinkedTextures = ColladaReader.LoadTexturesFromCollada(collada);

                // Cut down to textures that aren't linked to materials
                unlinkedTextures = unlinkedTextures.Except(materialTextures).ToList();

                // Store each material and texture name in JSON
                string dir = Path.GetDirectoryName(args[0]);
                Console.WriteLine(dir);
                //string jsonPath = WriteMaterialsToJSON(args[0], materials, unlinkedTextures);

                // Print information
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("JSON path:");
                Console.ResetColor();

                //Console.WriteLine(jsonPath);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nMaterial list:");
                Console.ResetColor();

                foreach(Material material in materials)
                {
                    Console.WriteLine(material.materialName + " - " + material.textureName);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nUnlinked texture list:");
                Console.ResetColor();

                if(unlinkedTextures.Count > 0)
                {
                    foreach (string texture in unlinkedTextures)
                    {
                        Console.WriteLine(texture);
                    }
                }
                else
                {
                    Console.WriteLine("N/A");
                } 
            }
        }

        static void PrintHelp()
        {
            // Figlet
            Console.WriteLine(
                " _____ __  __   ____         _      _  _ \n" +
                "|__  /|  \\/  | / ___|       | |    (_)| |_  ___ \n" +
                "  / / | |\\/| || |  _  _____ | |    | || __|/ _ \\ \n" +
                " / /_ | |  | || |_| ||_____|| |___ | || |_|  __/\n" +
                "/____||_|  |_| \\____|       |_____||_| \\__|\\___| \n" +
                "────────────────────────────────────────────────");

            // Version
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VERSION:");

            Console.ResetColor();
            Console.WriteLine("ZeldaMaterialGenerator-Lite v");

            // Credits
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CREDITS:");

            Console.ResetColor();
            Console.WriteLine(
                "Zen     | ZMG-Lite creator\n" +
                "Gamma   | SuperBMD developer\n" +
                "RenolY2 | SuperBMD developer\n" +
                "hello skilar babcock\n");

            // Description
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("DESCRIPTION:");

            Console.ResetColor();
            Console.WriteLine(
                "This tool was made to be used with Twilight Princess (GC). It may or may not work with other JSystem games.\n" +
                "Pass in a collada (*.dae) model, and this tool will export a YAML file.\n" +
                "Pass the YAML file back into this tool, and it will generate materials based on the supplied parameters.\n");

            // Usage
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("USAGE:");

            Console.ResetColor();
            Console.WriteLine("zmglite C:\\Path\\To\\Model\\model.dae] - zmglite C:\\Path\\To\\Materials\\materials.json");
        }
    }
}