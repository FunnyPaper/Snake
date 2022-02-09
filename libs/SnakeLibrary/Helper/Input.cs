using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeLibrary.Helper
{
    public static class Input
    {
        public static Keys LastKeyPressed = Keys.Right;
        private static (int x, int y) _move;

        public static (int x, int y) GetMovement()
        {
            _move = (0, 0);
            switch(LastKeyPressed)
            {
                case Keys.A:
                case Keys.Left:
                    _move.x--;
                    break;
                case Keys.D:
                case Keys.Right:
                    _move.x++;
                    break;
                case Keys.W:
                case Keys.Up:
                    _move.y++;
                    break;
                case Keys.S:
                case Keys.Down:
                    _move.y--;
                    break;
            }
            return _move;
        }
    }
}
