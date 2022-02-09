using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLibrary.Game.Boards
{
    public interface IBoard
    {
        int Rows { get; set; }
        int Cols { get; set; }

        void UpdateState(object sender, EventArgs e);
    }
}
