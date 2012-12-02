using System;
using System.Collections.Generic;
using System.Text;
using VS.Container;

namespace VS.Logic.Filter {
  public interface IListLogicFilter {
    bool Filter(BaseContainer container);
  }
}
