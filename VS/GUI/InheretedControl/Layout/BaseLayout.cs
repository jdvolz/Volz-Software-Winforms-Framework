using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.Logic;

namespace VS.GUI.InheritedControl.Layout {
  public partial class BaseLayout : BaseControl {
    #region Orientation Property Definitions
    protected LayoutOrientation layout;
    protected bool layoutchanged;
    public LayoutOrientation Orientation {
      get {
        return layout;
      }
      set {
        layout = value;
        layoutchanged = true;
        OnLayoutChanged();
      }
    }
    protected void OnLayoutChanged() {
      EventHandler ev = this.LayoutChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler LayoutChanged;
    #endregion
    #region BorderPadding Property Definitions
    protected int borderpadding;
    protected bool borderpaddingchanged;
    public int BorderPadding {
      get {
        return borderpadding;
      }
      set {
        borderpadding = value;
        borderpaddingchanged = true;
        OnBorderPaddingChanged();
      }
    }
    protected void OnBorderPaddingChanged() {
      EventHandler ev = this.BorderPaddingChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler BorderPaddingChanged;
    #endregion
    public BaseLayout() { }
    protected void BaseLayout_Layout(object sender, System.Windows.Forms.LayoutEventArgs e) { this.ArrangeControls(); }    
    protected void ArrangeControls() {
      if (this.VSPanel1.Size.IsEmpty ||
        this.VSPanel1.Controls.Count <= 0)
        return;
      ArrayList points = null;
      if (this.layout == LayoutOrientation.Horizontal)
        points = this.CalculateControlPositions(this.VSPanel1.Size.Width, this.VSPanel1.Controls[0].Width,
          this.VSPanel1.Controls[0].Height, this.VSPanel1.Controls.Count);
      if (this.layout == LayoutOrientation.Vertical)
        points = this.CalculateControlPositions(this.VSPanel1.Size.Height, this.VSPanel1.Controls[0].Height,
          this.VSPanel1.Controls[0].Width, this.VSPanel1.Controls.Count);

      if (points != null &&
        points.Count == this.VSPanel1.Controls.Count) {
        for (int i = 0; i < points.Count; i++) {
          Point pt = (Point)points[i];
          if (this.layout == LayoutOrientation.Horizontal) {
            this.VSPanel1.Controls[i].Location = pt;
          }
          else if (this.layout == LayoutOrientation.Vertical) {
            this.VSPanel1.Controls[i].Location = new Point(pt.Y, pt.X);
          }
        }
      }
    }
    protected ArrayList CalculateControlPositions(int bound, int dimension1, int dimension2, int pointCount) {
      if (dimension1 + this.borderpadding > bound)
        return null;
      int i = 0;
      int dimension2position = 0;
      ArrayList points = new ArrayList();
      while (i < pointCount) {
        dimension2position += this.borderpadding;
        points.AddRange(this.CreateToBound(bound, dimension1, dimension2position, pointCount - points.Count).ToArray());
        dimension2position += dimension2;
        i = points.Count;
      }
      return points;
    }
    protected ArrayList CreateToBound(int bound, int dimension1, int dimension2position, int CountToAdd) {
      int i = 0;
      int countAdded = 0;
      ArrayList points = new ArrayList();
      while (i + dimension1 + this.borderpadding < bound && countAdded < CountToAdd) {
        i += this.borderpadding;
        points.Add(new Point(i, dimension2position));
        i += dimension1;
        countAdded++;
      }
      return points;
    }    
    public void AddControls(Control[] conts) { this.VSPanel1.Controls.AddRange(conts); }
    public void RemoveControl(Control cont) {this.VSPanel1.Controls.Remove(cont); }
    public void AddControl(Control cont) {this.VSPanel1.Controls.Add(cont);}
    public void RemoveAllControls() { this.VSPanel1.Controls.Clear(); }
    public Control[] GetControls() {
      Control[] array = new Control[this.VSPanel1.Controls.Count];
      for (int i = 0; i < array.Length; i++) {
        array[i] = this.VSPanel1.Controls[i];
      }
      return array;
    }
    protected override void BindControlData() { }
    public override void StateChanged(BaseLogic sender, StateChangedEventArgs args) { }
    protected override void InitializeBO() { }
    protected void BaseLayout_Load(object sender, System.EventArgs e) {}
  }
  public enum LayoutOrientation { Horizontal, Vertical };
}
