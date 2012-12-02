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
  public partial class VSLaunchLabel : System.Windows.Forms.Label, IStateChangedListener, IDataBindSinglePersist {
    public VSLaunchLabel() {
      InitializeComponent();
    }
    protected object _DataSource;
    protected string _DataSourceProperty;
    protected string _LocalProperty;
    public object DataSource {
      get { return this._DataSource; }
      set {
        this._DataSource = value;
        this.RebindData();
      }
    }
    public string DataSourceProperty {
      get {
        return this._DataSourceProperty;
      }
      set {
        this._DataSourceProperty = value;
        this.RebindData();
      }
    }
    public string LocalProperty {
      get {
        return this._LocalProperty;
      }
      set {
        this._LocalProperty = value;
        this.RebindData();
      }
    }
    public void RebindData() {
      try {
        this.DataBindings.Clear();
        this.DataBindings.Add(this._LocalProperty, this._DataSource, this._DataSourceProperty);
      }
      catch (Exception) { }
    }
    public void RebindData(object DataSource) {
      try {
        this.DataBindings.Clear();
        RebindData();
      }
      catch (Exception) { }
    }
    public void BindData(string LocalProperty, object DataSource, string DataSourceProperty) {
      this._DataSource = DataSource;
      this._DataSourceProperty = DataSourceProperty;
      this._LocalProperty = LocalProperty;
      this.RebindData();
    }
    public void StateChanged(BaseLogic sender, StateChangedEventArgs args) {
      if (args.State == eState.RETRIEVED) {
        this.DataSource = sender.Container;
      }
    }
  }
}
