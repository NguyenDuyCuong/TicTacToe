using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Interfaces
{
  public interface ICell
  {
    CellState State { get; set; }

    IPlayer OccupiedBy { get; set; }
  }
}
