using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.Container;
using VS.GUI.InheritedControl.Interface;
using VS.Logic;

namespace VS.GUI.InheritedControl.EntityListControl {
  public partial class EntitySelectionControl : VS.GUI.BaseControl, IDataBindSinglePersist, IStateChangedListener, 
    IStateListChangedListener {
    protected string listLogicName;
    public string ListLogicName {
      get { return this.listLogicName; }
      set { this.listLogicName = value; }
    }
    protected BaseLogic listLogic;
    public BaseLogic ListLogic {
      get { return this.listLogic; }
      set { this.listLogic = value; }
    }
    public BaseContainer SelectedEntity {
      get { 
        if (vsComboBox1.SelectedItem != null) return (BaseContainer)vsComboBox1.SelectedItem;
        return null;
      }      
    }
    public int SelectedID {
      get {
        
        if (vsComboBox1.SelectedItem != null) {
          //System.Windows.Forms.MessageBox.Show("Get SelectedID : " + ((BaseContainer)vsComboBox1.SelectedItem).ID.ToString());
          return ((BaseContainer)vsComboBox1.SelectedItem).ID;
        }
        else {
          //System.Windows.Forms.MessageBox.Show("Get SelectedID : 0");
          return 0;
        }
      }
      set {
        //System.Windows.Forms.MessageBox.Show("Set SelectedID : " + value.ToString());
        for (int i = 0; i < vsComboBox1.Items.Count; i++) {
          if (((BaseContainer)vsComboBox1.Items[i]).ID == value) {
            vsComboBox1.SelectedItem = vsComboBox1.Items[i];
            //System.Windows.Forms.MessageBox.Show("SelectedID actually set: " + value.ToString());
            OnSelectedIDChanged(EventArgs.Empty);
            break;
          }
        }
      }
    }
    public event EventHandler SelectedIDChanged;
    protected void OnSelectedIDChanged(EventArgs args) {
      EventHandler ev = SelectedIDChanged;
      if (ev != null) ev(this, args);
    }
    public event EventHandler BindingOccured;
    private void OnBindingOccured(System.EventArgs e) {
      EventHandler ev = BindingOccured;
      if (ev != null) {
        ev(this, e);
      }
    }
    public EntitySelectionControl() { 
      InitializeComponent();
      vsComboBox1.ItemsChanged += new EventHandler(vsComboBox1_ItemsChanged);
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
    public void BindData(string target, object dataObj, string property) {
      
      _DataSource = dataObj;
      _DataSourceProperty = property;
      _LocalProperty = target;
      RebindData();
    }
    public void RebindData() {
      if (_DataSource != null) {
        this.DataBindings.Clear();
        this.DataBindings.Add(new Binding(_LocalProperty, _DataSource, _DataSourceProperty));
        OnBindingOccured(EventArgs.Empty);
      }
    }
    public void RebindData(object DataSource) {
      this.DataSource = DataSource;
    }
    protected override void BindControlData() { }
    protected override void InitializeBO() { }
    public override void StateChanged(BaseLogic sender, StateChangedEventArgs args) {
      //MessageBox.Show(sender.ToString() + " State Changed");
      if (args.State == eState.RETRIEVED) {
        //MessageBox.Show("NonList - Retrieved");
        DataSource = sender.Container;
      }
    }
    public void ListStateChanged(BaseLogic sender, StateChangedEventArgs args) {
      //MessageBox.Show(sender.ToString() + " List State Changed");
      if( args.State == eState.RETRIEVED) vsComboBox1.RebindData();
    }
    void vsComboBox1_ItemsChanged(object sender, EventArgs e) { }
    private void vsComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
      int ix = vsComboBox1.SelectedIndex;
      BaseContainer container = (BaseContainer)vsComboBox1.Items[ix];
      this.SelectedID = container.ID;
    }
  }
}
