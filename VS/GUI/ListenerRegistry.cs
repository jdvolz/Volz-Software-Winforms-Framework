using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using VS.GUI.Form;
using VS.Logic;

namespace VS.GUI {
  public class ListenerRegistry {
    private static Hashtable Registry = new Hashtable();
    public static void BindListeners(System.Windows.Forms.Control control) {
      if (control is BaseControl) {
        BaseControl bcontrol = (BaseControl)control;
        if (bcontrol.Logic != null &&
            !ListenerRegistry.Registry.Contains(bcontrol)) {
          ListenerRegistry.Registry.Add(bcontrol, "");
          bcontrol.Logic.StateChanged += new StateChangedDelegate(bcontrol.StateChanged);
        }
        foreach (object listener in bcontrol.Controls) {
          if (listener is BaseControl) ListenerRegistry.BindListeners((System.Windows.Forms.Control)listener);
          else ListenerRegistry.BindListeners((System.Windows.Forms.Control)listener, bcontrol.Logic);
        }
      }
      else {
        foreach (System.Windows.Forms.Control passThrough in control.Controls) {
          ListenerRegistry.BindListeners(passThrough);
        }
      }
    }
    public static void BindListeners(System.Windows.Forms.Control control, BaseLogic logic) {
      if (logic != null &&
          !Registry.Contains(control)) {
        Registry.Add(control, "");
        logic.StateChanged += new StateChangedDelegate(((IStateChangedListener)control).StateChanged);
      }
      foreach (object listener in control.Controls) {
        if (listener is BaseControl)
          BindListeners((System.Windows.Forms.Control)listener);
        else
          BindListeners((System.Windows.Forms.Control)listener, logic);
      }
    }
    public static void BindListeners(System.Windows.Forms.Form form) {
      if (!(form is BaseForm)) return;
      BaseForm bform = (BaseForm)form;
      if (bform.Logic != null &&
          !Registry.Contains(bform)) {
        Registry.Add(bform, "");
        bform.Logic.StateChanged += new StateChangedDelegate(bform.StateChanged);
      }
      foreach( object listener in bform.Controls){
        if( listener is BaseControl)
          BindListeners((System.Windows.Forms.Control)listener);
        else
          BindListeners((System.Windows.Forms.Control)listener, bform.Logic);
      }
    }
  }
}
