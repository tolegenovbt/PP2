using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Food : GameObject
    {
        private Random random;
        //public int score;
        public Food(char character, ConsoleColor consoleColor) : base(character, consoleColor)
        {
            random = new Random();
            Generate();
        }
        public void Generate()
        {
            Point point = new Point() { X = random.Next(0, 50), Y = random.Next(0, 26) };
            body = new List<Point>() { point };
        }
        //public int GetScore()
        //{
        //    return score;
        //}
        public Point GetFood()
        {
            return body[0];
        }
        // check for collision
        public bool HasCollided(Point point)
        {
            // && is logical AND
            return body[0].X == point.X && body[0].Y == point.Y;
        }
    }
}