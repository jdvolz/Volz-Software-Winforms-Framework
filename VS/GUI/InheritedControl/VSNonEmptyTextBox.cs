using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.GUI.InheritedControl.Interface;
using VS.Logic;

namespace VS.GUI.InheritedControl {
  public partial class VSNonEmptyTextBox : VSTextBox {
    #region EmptyTextErrorMessage Property Definitions
    protected string emptytexterrormessage;
    protected bool emptytexterrormessagechanged;
    public string EmptyTextErrorMessage {
      get {
        return emptytexterrormessage;
      }
      set {
        emptytexterrormessage = value;
        emptytexterrormessagechanged = true;
        OnEmptyTextErrorMessageChanged();
      }
    }
    protected void OnEmptyTextErrorMessageChanged() {
      EventHandler ev = this.EmptyTextErrorMessageChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler EmptyTextErrorMessageChanged;
    #endregion
    public VSNonEmptyTextBox() : base() {InitializeValdiate();}
    protected void InitializeValdiate() {
      this.Validating += new System.ComponentModel.CancelEventHandler(this.SMNonEmptyTextBox_Validating);
    }
    private void SMNonEmptyTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
      if (this.Text == "") e.Cancel = true;
    }
  }
}
