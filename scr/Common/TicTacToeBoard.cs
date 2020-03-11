using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
  /// <summary>
  /// Implement Tic Tac Toe Board
  /// </summary>
  public class TicTacToeBoard : IBoard
  {
    public ICell[,] Cells { get; private set; }

    public TicTacToeBoard()
    {
      Cells = new Cell[3,3];
    }

    /// <summary>
    /// Return Intance of current Board
    /// </summary>
    /// <returns></returns>
    public BoardSnapShoot GetBoardSnapShoot()
    {
      return new BoardSnapShoot(Cells);
    }
  }
}
