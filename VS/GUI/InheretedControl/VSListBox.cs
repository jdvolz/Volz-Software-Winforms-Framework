using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.Container;
using VS.GUI.InheritedControl.Interface;
using VS.Logic;

namespace VS.GUI.InheritedControl {
  public partial class VSListBox : System.Windows.Forms.ListBox, IStateChangedListener, IDataBindListPersist {
    private List<BaseContainer> _DataSourceList;
    public List<BaseContainer> DataSourceList {
      get {
        return this._DataSourceList;
      }
      set {
        this._DataSourceList = value;
        this.RebindData();
      }
    }
    protected bool JustAdded = false;
    protected bool JustDeleted = false;    
    public VSListBox() {
      this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, 
        System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.BackColor = System.Drawing.Color.White;
    }
    public void AddItems(List<BaseContainer> List) {
      this.Items.Clear();
      this.Items.AddRange(List.ToArray());
      
    }
    protected int GetIndex(int id) {
      if (this.Items == null)
        return -1;

      for (int i = 0; i < this.Items.Count; i++) {
        if (((BaseContainer)this.Items[i]).ID == id)
          return i;
      }
      return -1;
    }
    protected int GetMaxIndex() {
      if (this.Items == null)
        return -1;

      int maxID = -1;
      int index = 0;
      for (int i = 0; i < this.Items.Count; i++) {
        if (((BaseContainer)this.Items[i]).ID > maxID) {
          maxID = ((BaseContainer)this.Items[i]).ID;
          index = i;
        }
      }
      return index;
    }
    protected int GetPreviousIndex(int PreviousID) {
      if (this.Items != null &&
        this.Items.Count > 0) {
        if (PreviousID <= 0) { return 0; }
        else {          
          int i = 0;
          foreach (BaseContainer container in this.Items) {
            if (container.ID == PreviousID) {
              if (i == 0) return 0;
              else return i - 1;
            }
            i++;
          }
          return 0;
        }
      }
      return -1;
    }
    protected bool EnableSelectedIndexChanged;
    protected override void OnSelectedIndexChanged(EventArgs e) {
      if (this.EnableSelectedIndexChanged)
        base.OnSelectedIndexChanged(e);
    }
    public void BindData(List<BaseContainer> DataSourceList) {
      this._DataSourceList = DataSourceList;
      //this.RebindData();
    }
    public void RebindData() {
      try {
        //this.DataBindings.Clear();
        //this.DataBindings.Add(this._LocalProperty, this._DataSource, this._DataSourceProperty);
        //this.DataSource = this._DataSource;
        //this.ValueMember = "ID";
        //this.DisplayMember = "NAME";
        //BaseListContainer blc = (BaseListContainer)this.DataSource;
        this.EnableSelectedIndexChanged = false;
        this.AddItems(this._DataSourceList);
        this.EnableSelectedIndexChanged = true;
        this.OnItemsChanged(EventArgs.Empty);
      }
      catch (Exception) {
        //System.Windows.Forms.MessageBox.Show( ex.ToString() );
      }
    }
    public void StateChanged(BaseLogic sender, StateChangedEventArgs args) {
      if (args.State == eState.DELETING) {
        this.JustDeleted = true;

      }

      if (args.State == eState.ADDED) {
        JustAdded = true;

      }

      if (args.State == eState.RETRIEVED) {
        int NextID = -1;
        if (this.SelectedItem != null)
          NextID = ((BaseContainer)this.SelectedItem).ID;
        if (this.JustDeleted)
          NextID = this.GetPreviousIndex(NextID);

        this.EnableSelectedIndexChanged = false;
        this._DataSourceList = sender.Containers;
        this.RebindData();
        this.EnableSelectedIndexChanged = true;

        if (this.JustAdded) {
          this.SelectedIndex = this.GetMaxIndex();
          this.JustAdded = false;
          return;
        }
        if (this.JustDeleted) {
          this.SelectedIndex = NextID;
          this.JustDeleted = false;
          return;
        }

        if (this.Items != null &&
          this.Items.Count > 0) {

          if (NextID < 0) {
            this.SelectedIndex = 0;
          }
          else {
            int index = this.GetIndex(NextID);
            if (index < 0)
              this.SelectedIndex = 0;
            else
              this.SelectedIndex = index;
          }
        }
      }
    }
    public event EventHandler ItemsChanged;
    protected void OnItemsChanged(EventArgs args) {
      EventHandler ev = this.ItemsChanged;
      if (ev != null) {
        ev(this, args);
      }
    }
  }
}
