using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VS.GUI.Transport;

namespace VS.GUI.Form {
  public partial class NewEntityForm : BaseForm{
    #region Transport Property Definitions
    protected BaseContainerTransport transport;
    protected bool transportchanged;
    public BaseContainerTransport Transport {
      get {
        return transport;
      }
      set {
        transport = value;
        transportchanged = true;
        OnTransportChanged();
      }
    }
    protected void OnTransportChanged() {
      EventHandler ev = this.TransportChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler TransportChanged;
    #endregion
    public NewEntityForm() {
      InitializeComponent();
    }
    public NewEntityForm(BaseContainerTransport transport) : this() {
      this.transport = transport;
    }
    private void btnOk_Click(object sender, EventArgs e) {
      this.transport.CreationSucceeded = true;
      this.Close();
    }
    private void btnCancel_Click(object sender, EventArgs e) {
      this.transport.CreationSucceeded = false;
      this.Close();
    }
    private void NewEntityForm_FormClosed(object sender, FormClosedEventArgs e) {}

    private void NewEntityForm_Load(object sender, EventArgs e) {
      if (this.transport != null &&
          this.transport.Container != null) this.txtName.BindData("TEXT", this.transport.Container, "NAME");
      txtName.Focus();
    }
  }
}