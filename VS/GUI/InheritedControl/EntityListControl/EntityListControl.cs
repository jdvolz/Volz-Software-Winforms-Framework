using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.Container;
using VS.GUI;
using VS.Logic;

namespace VS.GUI.InheritedControl.EntityListControl {
  public partial class EntityListControl : VS.GUI.BaseControl {
    public BaseContainer SelectedEntity {
      get {
        if (this.vsListBox1.SelectedItem != null) return (BaseContainer)this.vsListBox1.SelectedItem;
        return null;
      }
    }
    public EntityListControl() : base() {
      InitializeComponent();
      this.vsListBox1.ItemsChanged += new EventHandler(this.ItemsChanged_Handler);
    }
    private void EntityListControl_Load(object sender, EventArgs e) {
      vsListBox1.SelectedIndexChanged += new EventHandler(vsListBox_SelectedIndexChanged);
    }
    protected override void BindControlData() { }
    protected override void InitializeBO() { }
    public override void StateChanged(BaseLogic sender, StateChangedEventArgs args) { }
    private void vsTextBox1_TextChanged(object sender, System.EventArgs e) {
      int index = this.vsListBox1.FindString(this.vsTextBox1.Text);
      if (index >= 0 &&
        this.vsListBox1.Items != null &&
        index < this.vsListBox1.Items.Count)
        this.vsListBox1.SelectedIndex = index;
    }
    public event EventHandler SelectedEntityChanged;
    protected void OnSelectedEntityChanged(System.EventArgs args) {
      EventHandler ev = this.SelectedEntityChanged;
      if (ev != null)
        ev(this, args);
    }
    protected void vsListBox_SelectedIndexChanged(object sender, EventArgs args) {
      this.OnSelectedEntityChanged(args);
    }
    protected void ItemsChanged_Handler(object sender, EventArgs args) {
      if (this.vsListBox1 != null &&
        this.vsLabel2 != null &&
        this.vsListBox1.Items != null)
        this.vsLabel2.Text = this.vsListBox1.Items.Count.ToString();
    }
  }
}
