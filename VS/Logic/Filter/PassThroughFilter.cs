using System;
using System.Collections.Generic;
using System.Text;
using VS.Container;

namespace VS.Logic.Filter {
  public class PassThroughFilter : IListLogicFilter{
    public bool Filter(BaseContainer container) { return true; }
  }
}
