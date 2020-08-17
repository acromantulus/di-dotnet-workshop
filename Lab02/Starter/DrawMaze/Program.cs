﻿using MazeGeneration;
using System;
using System.Diagnostics;

namespace DrawMaze
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new MazeGenerator();
            CreateAndShowMaze(generator);
            Console.ReadLine();
        }

        private static void CreateAndShowMaze(MazeGenerator generator)
        {
            generator.GenerateMaze();

            var textMaze = generator.GetTextMaze(true);
            Console.WriteLine(textMaze);

            var graphicMaze = generator.GetGraphicalMaze(true);
            graphicMaze.Save("maze.png");
            
            // This code is Windows-only
            // Comment out the following if building on macOS or Linux
            // The "maze.png" file can be located in the output
            // folder: [solutionlocation]/DrawMaze/bin/Debug/netcore3.1/
            Process p = new Process();
            p.StartInfo.UseShellExecute = true;
            p.StartInfo.FileName = "maze.png";
            p.Start();
        }
    }
}
