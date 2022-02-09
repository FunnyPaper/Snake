using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.EventHandlers
{
    public class GameEventArgs : EventArgs
    {
        public Boards.IBoard Board;
        public Entities.ISnake Snake;

        public GameEventArgs(Boards.IBoard board, Entities.ISnake snake)
        {
            Board = board;
            Snake = snake;
        }
    }
}
