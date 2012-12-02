using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using VS.Container;
using VS;

namespace VS.GUI.Shared {
  public delegate void SelectedContainerChangedEventHandler(object sender, SelectedContainerChangedEventArgs args);
  public class SelectedContainerChangedEventArgs : System.EventArgs {
    public SelectedContainerChangedEventArgs() : base() { }
    public SelectedContainerChangedEventArgs(BaseContainer container, bool selected)
      : this() {
      this.container = container;
      this.selected = selected;
    }
    #region Variables
    #region CONTAINER Property definitions
    protected BaseContainer container;
    protected bool containerchanged;
    public BaseContainer CONTAINER {
      get {
        return container;
      }

      set {
        this.container = value;
        containerchanged = true;
        OnCONTAINERChanged();
      }

    }

    protected void OnCONTAINERChanged() {
      EventHandler ev = this.CONTAINERChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }

    }

    public event EventHandler CONTAINERChanged;
    #endregion
    #region SELECTED Property definitions
    protected bool selected;
    protected bool selectedchanged;
    public bool SELECTED {
      get {
        return selected;
      }

      set {
        this.selected = value;
        selectedchanged = true;
        OnSELECTEDChanged();
      }

    }

    protected void OnSELECTEDChanged() {
      EventHandler ev = this.SELECTEDChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }

    }

    public event EventHandler SELECTEDChanged;
    #endregion

    #endregion
  }
  public class Shared {
    public static void OpenWebsite() {
      string website = Properties.Settings1.Default.Website;
      if (website.Length > 0)
        System.Diagnostics.Process.Start(website);
    }
  }
}
