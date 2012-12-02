using System;
using System.Collections.Generic;
using System.Text;
using VS.Connection;
using VS.Container;

namespace VS.Logic {
  public class BaseLogic {
    #region State Property Definitions
    protected eState state;
    
    public eState State {
      get {
        return state;
      }
      set {
        state = value;        
        OnStateChanged();
      }
    }
    protected void OnStateChanged() {
      StateChangedDelegate ev = this.StateChanged;
      if (ev != null) ev(this, new StateChangedEventArgs(this.state));
    }
    public event StateChangedDelegate StateChanged;
    #endregion
    protected List<BaseContainer> containers;
    public List<BaseContainer> Containers {
      get { return this.containers; }
      set { this.containers = value; }
    }
    protected BaseContainer container;
    public BaseContainer Container {
      get { return this.container; }
      set { this.container = value; }
    }

    public BaseLogic() { }
  }

  public interface IStateChangedListener {
    void StateChanged(BaseLogic sender, StateChangedEventArgs args);
  }

  public interface IStateListChangedListener {
    void ListStateChanged(BaseLogic sender, StateChangedEventArgs args);
  }

  public class StateChangedEventArgs : System.EventArgs {
    protected eState state;
    public eState State {
      get { return this.state; }
    }
    public StateChangedEventArgs() { }
    public StateChangedEventArgs(eState state) {
      this.state = state;
    }
  }
  public delegate void StateChangedDelegate(BaseLogic sender, StateChangedEventArgs args);

  public enum eState : int { ADDING, ADDED, CANCELING, CANCELED, DELETING, DELETED, RETRIEVING, RETRIEVED, PRESAVING, SAVING, 
    SAVED, RESYNCHING, RESYNCHED};
}
