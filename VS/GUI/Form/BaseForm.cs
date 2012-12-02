using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VS.Logic;

namespace VS.GUI.Form {
  public partial class BaseForm : System.Windows.Forms.Form, IStateChangedListener {
    public BaseLogic Logic;
    public BaseForm() { InitializeComponent();}
    public virtual void StateChanged(BaseLogic sender, StateChangedEventArgs args) {}
    public virtual void BaseForm_Load(object sender, EventArgs args) {
      InitializeBO();
      //ListenerRegistry.BindListeners(this);
      BindControlData();
      if (Logic != null) Logic.StateChanged += new StateChangedDelegate(this.StateChanged);
    }
    protected virtual void BindControlData() { }
    protected virtual void InitializeBO() { }
  }
}