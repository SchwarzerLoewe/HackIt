﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDraw
{
    public static class WindowManager
    {
        public static void DrawColorBlock(ConsoleColor Color, int startX, int startY, int endX, int endY)
        {
            Console.BackgroundColor = Color;

            for (var i = startX; i < endX-1; i++)
            {
                Console.CursorLeft = startY;
                Console.CursorTop = i;

                Console.WriteLine("".PadLeft(endY - startY));
            }
        }

        public static void WriteText(String text, int startX, int startY, ConsoleColor textColor, ConsoleColor BackgroundColor)
        {
            Console.CursorLeft = startY;
            Console.CursorTop = startX;

            Console.BackgroundColor = BackgroundColor;
            Console.ForegroundColor = textColor;

            Console.Write(text);

        }


        private static int startingX;
        private static int startingY;
        private static ConsoleColor startingForegroundColor;
        private static ConsoleColor startingBackgroundColor;
        private static int startingBufferHeight;
        private static int startingBufferWidth;

        public static void SetupWindow()
        {
            startingBufferHeight = Console.BufferHeight;

            var whereToMove = Console.CursorTop + 1; //Move one line below visible
            if (whereToMove < Console.WindowHeight) //If cursor is not on bottom line of visible
                whereToMove = Console.WindowHeight + 1;

            if (Console.BufferHeight < whereToMove + Console.WindowHeight) //Buffer is too small
                Console.BufferHeight = whereToMove + Console.WindowHeight;

            Console.MoveBufferArea(0, 0, Console.WindowWidth, Console.WindowHeight, 0, whereToMove);

            Console.CursorVisible = false;
            startingX = Console.CursorTop;
            startingY = Console.CursorLeft;
            startingForegroundColor = Console.ForegroundColor;
            startingBackgroundColor = Console.BackgroundColor;

            Console.CursorTop = 0;
            Console.CursorLeft = 0;
        }

        public static void EndWindow()
        {
            Console.ForegroundColor = startingForegroundColor;
            Console.BackgroundColor = startingBackgroundColor;

            var whereToGet = startingX + 1; //Move one line below visible
            if (whereToGet < Console.WindowHeight) //If cursor is not on bottom line of visible
                whereToGet = Console.WindowHeight + 1;
            Console.MoveBufferArea(0, whereToGet, Console.WindowWidth, Console.WindowHeight, 0, 0);

            Console.CursorTop = startingX;
            Console.CursorLeft = startingY;

            Console.CursorVisible = true;
            Console.BufferHeight = startingBufferHeight;
            //Console.WriteLine();

        }

        public static void UpdateWindow(int width, int height)
        {
            Console.CursorVisible = false;

            if (width > Console.BufferWidth) //new Width is bigger then buffer
            {
                Console.BufferWidth = width;
                Console.WindowWidth = width;
            }
            else
            {
                Console.WindowWidth = width;
                Console.BufferWidth = width;
            }

            if (height > Console.BufferWidth) //new Height is bigger then buffer
            {
                Console.BufferHeight = height;
                Console.WindowHeight = height;
            }
            else
            {
                Console.WindowHeight = height;
                Console.BufferHeight = height;
            }

            Console.BackgroundColor = ConsoleColor.Gray;
            WindowManager.DrawColorBlock(Console.BackgroundColor, 0, 0, Console.WindowHeight, Console.WindowWidth); //Flush Buffer
        }

        public static void SetWindowTitle(String title)
        {
            Console.Title = title;
        }
    }
}