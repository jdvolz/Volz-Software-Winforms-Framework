using System;
using System.Collections.Generic;
using System.Text;

namespace VS.Logic {
  public class VersionLogic {
    #region Version Property Definitions
    protected string version;
    protected bool versionchanged;
    public string Ver {
      get {
        return version;
      }
      set {
        version = value;
        versionchanged = true;
        OnVersionChanged();
      }
    }
    protected void OnVersionChanged() {
      EventHandler ev = this.VersionChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler VersionChanged;
    #endregion
    #region ProgramName Property Definitions
    protected string programname;
    protected bool programnamechanged;
    public string ProgramName {
      get {
        return programname;
      }
      set {
        programname = value;
        programnamechanged = true;
        OnProgramNameChanged();
      }
    }
    protected void OnProgramNameChanged() {
      EventHandler ev = this.ProgramNameChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler ProgramNameChanged;
    #endregion
    public VersionLogic() {
      this.version = "";
      this.programname = "";
    }
    public override string ToString() { return this.programname + " v" + this.version;}
  }
}
