using Common;
using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameBoard
{
  public class Arbitrator
  {
    public IBoard Board { get; private set; }    

    public Queue<IPlayer> Players { get; private set; }

    /// <summary>
    /// Create Board and Player
    /// </summary>
    public void InitGame()
    {
      // Init board
      Board = new TicTacToeBoard();

      // Read libs and put in queues
      // TODO: 
      // var lsPlayer = 
    }

    public async void Play()
    {

    }

    public void PrintBoard()
    {
      var board = Board.GetBoardSnapShoot();

      for (int row = 0; row < board.RowNumber; row++)
      {
        for (int col = 0; col < board.ColNumber; col++)
        {

        }
      }
    }
  }
}
