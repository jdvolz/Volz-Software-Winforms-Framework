using System;
using System.Collections.Generic;
using System.Text;
using VS.Container;

namespace VS.GUI.Transport {
  public class BaseContainerTransport {
    #region CreationSucceeded Property Definitions
    protected bool creationsucceeded;
    protected bool creationsucceededchanged;
    public bool CreationSucceeded {
      get {
        return creationsucceeded;
      }
      set {
        creationsucceeded = value;
        creationsucceededchanged = true;
        OnCreationSucceededChanged();
      }
    }
    protected void OnCreationSucceededChanged() {
      EventHandler ev = this.CreationSucceededChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler CreationSucceededChanged;
    #endregion
    #region Container Property Definitions
    protected BaseContainer container;
    protected bool containerchanged;
    public BaseContainer Container {
      get {
        return container;
      }
      set {
        container = value;
        containerchanged = true;
        OnContainerChanged();
      }
    }
    protected void OnContainerChanged() {
      EventHandler ev = this.ContainerChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler ContainerChanged;
    #endregion
    public BaseContainerTransport() { this.creationsucceeded = false; }
    public BaseContainerTransport(BaseContainer container) : this() { this.container = container; }
  }
}
