using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    class GameState
    {
        Food food;
        Serpent serpent;
        Wall wall;
        string name;
        int score = 0, checkscore = 0;
        public int level = 1;

        private bool run;

        public GameState()
        {
            food = new Food('$', ConsoleColor.Green);
            serpent = new Serpent('O', ConsoleColor.Red);
            wall = new Wall('#', ConsoleColor.Blue);

            Console.SetWindowSize(50, 30);
            Console.SetBufferSize(50, 30);
            Console.CursorVisible = false;
        }
        public void Gamer()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(0, 25);
            for (int i = 0; i < 50; i++)
                Console.Write("-");
            Console.SetCursorPosition(9, 26);
            Console.Write("SNAKE GAME  by  Tolegenov Bekzat");
            Console.SetCursorPosition(9, 27);
            Console.Write("Gamer: " + name);
            Console.SetCursorPosition(27, 27);
            Console.Write("Score: ");
        }
        public void Score()
        {
            Console.SetCursorPosition(34, 27);
            Console.Write("   ");
            Console.SetCursorPosition(34, 27);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(score);
        }
        public void Level()
        {
            wall.LoadLevel(score/3+1);
            wall.Draw();
        }
        private bool FoodAndWallOrSerpent()
        {
            foreach(Point i in wall.GetWall())
            {
                if (food.HasCollided(i))
                    return false;
            }
            foreach (Point i in serpent.GetSerpent())
            {
                if (food.HasCollided(i))
                    return false;
            }
            return true;
        }
        private bool SerpentCatchItself()
        {
            for (int i = 2; i < serpent.GetSerpent().Count; i++)
                if (serpent.HasCollided(serpent.GetSerpent()[i]))
                    return false;
            return true;
        }
        private void CheckFoodCatch()
        {
            //if (FoodAndWallOrSerpent())
            //{

                if (serpent.HasCollided(food.GetFood()))
                {
                    serpent.Eat(food.GetFood());
                    score++;
                    Score();
                    food.Generate();
                }
            //}
            //else
            //{
            //    food.Generate();
            //    CheckFoodCatch();
            //}
        }
        private bool CatchWall()
        {
            foreach(Point i in wall.GetWall())
            {
                if (serpent.HasCollided(i))
                    return false;
            }
            //for (int i = 2; i < serpent.GetSerpent().Count; i++)
            //    if (serpent.HasCollided(serpent.GetSerpent()[i]))
            //        return false;
            return true;
        }
        private void FoodDraw()
        {
            if (FoodAndWallOrSerpent())
            { 
                food.Draw();
            }
            else
            {
                food.Generate();
                FoodDraw();
            }
        }
        private void DrawAndMoveGameObjects()
        {
            while (CatchWall() && SerpentCatchItself())
            {
                // move and other logic
                serpent.Clear();
                serpent.Move();
                CheckFoodCatch();

                // draw
                serpent.Draw();
                FoodDraw();


                // This parameter defines speed of movement
                Thread.Sleep(200);
            }
        }

        public void StartGame()
        {
            Console.Write("Give your name: ");
            name = Console.ReadLine();
            Console.Clear();
            run = true;
            Level();
            Gamer();
            Score();
            ThreadStart threadStart = new ThreadStart(DrawAndMoveGameObjects);
            Thread moveDrawThread = new Thread(threadStart);
            // run the thread
            moveDrawThread.Start();
            while (run)
            {
                checkscore = score/3+1;
                //serpent.Draw();
                //food.Draw();
                //FoodDraw();
                
                //CheckFoodCatch();
                
                ConsoleKeyInfo pressedKey = Console.ReadKey();
                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (serpent.GetDirection() != Direction.Down)
                            serpent.ChangeDirection(Direction.Up);
                        run = CatchWall() && SerpentCatchItself();
                        break;
                    case ConsoleKey.DownArrow:
                        if (serpent.GetDirection() != Direction.Up)
                            serpent.ChangeDirection(Direction.Down);
                        run = CatchWall() && SerpentCatchItself();
                        break;
                    case ConsoleKey.LeftArrow:
                        if (serpent.GetDirection() != Direction.Right)
                            serpent.ChangeDirection(Direction.Left);
                        run = CatchWall() && SerpentCatchItself();
                        break;
                    case ConsoleKey.RightArrow:
                        if(serpent.GetDirection()!=Direction.Left)
                        serpent.ChangeDirection(Direction.Right);
                        run = CatchWall() && SerpentCatchItself();
                        break;
                    case ConsoleKey.Escape:
                        run = false;
                        break;
                    default:
                        break;
                }
                if (checkscore < score/3+1)
                {
                    Console.Clear();
                    //run = true;
                    Level();
                    Gamer();
                    Score();
                    serpent.SerpentOrigin();
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 14);
            Console.Write("GAME OVER");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(10, 16);
            Console.Write("Your useless achievement: " + score+ "  scores");
        }
    }
}