using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VS.Logic;
using VS.Logic.Singleton;

namespace VS.GUI.Form {
  public partial class AboutForm : BaseForm {
    public AboutForm() { InitializeComponent(); }
    private void btnOk_Click(object sender, EventArgs e) { this.Close(); }
    private void vsLabel3_Click(object sender, EventArgs e) { Shared.Shared.OpenWebsite(); }
    private void AboutForm_Load(object sender, EventArgs e) {
      VersionLogic ver = (VersionLogic)ReferenceManager.GetSingleton(typeof(VersionLogic));
      this.vsLabel1.Text = ver.ToString();
    }
    private void vsLabel3_MouseEnter(object sender, EventArgs e) {
      Cursor.Current = Cursors.Hand;
    }
    private void vsLabel3_MouseLeave(object sender, EventArgs e) {
      Cursor.Current = Cursors.Default;
    }
  }
}