using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode_May_Challenge
{
    class Day11_Flood_Fill
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] != newColor)
                Fill(image, image.Length - 1, image[0].Length - 1, image[sr][sc], sr, sc, newColor);

            return image;
        }
        void Fill(int[][] image, int rowMax, int colMax, int oldColor, int row, int col, int newColor)
        {
            if (row < 0 || rowMax < row ||
               col < 0 || colMax < col ||
               image[row][col] != oldColor) return;

            image[row][col] = newColor;

            Fill(image, rowMax, colMax, oldColor, row - 1, col, newColor);
            Fill(image, rowMax, colMax, oldColor, row + 1, col, newColor);
            Fill(image, rowMax, colMax, oldColor, row, col - 1, newColor);
            Fill(image, rowMax, colMax, oldColor, row, col + 1, newColor);
        }
    }
}
