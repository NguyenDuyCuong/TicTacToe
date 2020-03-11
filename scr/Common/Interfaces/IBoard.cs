using System;

namespace Common.Interfaces
{
  /// <summary>
  /// Define Board Game
  /// </summary>
  public interface IBoard
  {
    /// <summary>
    /// Get Cells 
    /// </summary>
    ICell[,] Cells { get; }

    BoardSnapShoot GetBoardSnapShoot();

    
  }
}
