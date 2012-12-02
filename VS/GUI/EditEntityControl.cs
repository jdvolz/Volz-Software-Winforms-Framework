using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VS.GUI {
  public partial class EditEntityControl : BaseControl {
    public EditEntityControl() { InitializeComponent();}
    private void EditEntityControl_Load(object sender, EventArgs e) { base.ControlLoad(sender, e); }
    protected override void BindControlData() { }
    private void btnNew_Click(object sender, EventArgs e) { New();  }
    private void btnSave_Click(object sender, EventArgs e) { Save();  }
    private void btnDelete_Click(object sender, EventArgs e) {Delete(); }
    private void btnSaveAs_Click(object sender, EventArgs e) { SaveAs(); }
    protected virtual void New() { }
    protected virtual void Save() { }
    protected virtual void SaveAs() { }
    protected virtual void Delete() { }
    protected virtual void SelectedEntityChangedHandler(object sender, EventArgs args) { }
  }
}
