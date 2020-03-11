using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
  public class BoardSnapShoot
  {
    public ICell[,] Cells { get; }
    public int RowNumber { get; }
    public int ColNumber { get; }

    public BoardSnapShoot(ICell[,] cells)
    {
      Array.Copy(cells, Cells, cells.Length);
      RowNumber = Cells.GetLength(0);
      ColNumber = Cells.GetLength(1);
    }
  }
}
