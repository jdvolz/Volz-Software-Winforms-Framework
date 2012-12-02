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
  public partial class VSPanel : System.Windows.Forms.Panel, IStateChangedListener, IDataBindSinglePersist {
    public VSPanel() { InitializeComponent();}
    public event EventHandler BindingOccured;
    private void OnBindingOccured(System.EventArgs e) {
      EventHandler ev = BindingOccured;
      if (ev != null) {
        ev(this, e);
      }
    }
    #region IDataBindSinglePersist Members

    #region Variables for IDataBindSinglePersist impl

    /// <summary>
    /// protected member for storing the datasource 
    /// </summary>
    protected object _DataSource;

    /// <summary>
    /// protected variable for the source property name (string)
    /// </summary>
    protected string _DataSourceProperty;

    /// <summary>
    /// protected variable for the local property that is bound.
    /// </summary>
    protected string _LocalProperty;

    #endregion

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

    /// <summary>
    /// Rebinds the data that is set in the properties.
    /// </summary>
    public void RebindData() {
      try {
        this.DataBindings.Clear();
        this.DataBindings.Add(this._LocalProperty, this._DataSource, this._DataSourceProperty);
        OnBindingOccured(EventArgs.Empty);
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

    #endregion

    #region IStateChangedListener Members

    public void StateChanged(BaseLogic sender, StateChangedEventArgs args) {
      if (args.State == eState.RETRIEVED) {
        this.DataSource = sender.Container;
      }
    }

    #endregion
  }
}
