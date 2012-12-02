using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.Logic;

namespace VS.GUI {
  public partial class BaseControl : UserControl, IStateChangedListener {
    public BaseLogic Logic;
    public BaseControl() { 
      InitializeComponent();
      if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) this.Load += new System.EventHandler(this.ControlLoad);
    }
    public BaseControl(BaseLogic logic) : this() { this.Logic = logic; }
    protected virtual void ControlLoad(object sender, EventArgs args) {
      if (LicenseManager.UsageMode != LicenseUsageMode.Designtime) {
        InitializeBO();
        ListenerRegistry.BindListeners(this);
        BindControlData();
        if (Logic != null) Logic.StateChanged += new StateChangedDelegate(this.StateChanged);
      }
    }
    protected virtual void BindControlData() { }
    public virtual void StateChanged(BaseLogic sender, StateChangedEventArgs args) { }
    protected virtual void InitializeBO() { }
  }
}
