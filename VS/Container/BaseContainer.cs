using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace VS.Container {
  public abstract class BaseContainer {
    #region ID Property Definitions
    protected int id;
    protected bool idchanged;
    public int ID {
      get {
        return id;
      }
      set {
        id = value;
        idchanged = true;
        OnIDChanged();
      }
    }
    protected void OnIDChanged() {
      EventHandler ev = this.IDChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler IDChanged;
    #endregion
    #region Name Property Definitions
    protected string name;
    protected bool namechanged;
    public string Name {
      get {
        return name;
      }
      set {
        name = value;
        namechanged = true;
        OnNameChanged();
      }
    }
    protected void OnNameChanged() {
      EventHandler ev = this.NameChanged;
      if (ev != null) {
        ev(this, EventArgs.Empty);
      }
    }
    public event EventHandler NameChanged;
    #endregion
    public BaseContainer() { }
    public BaseContainer(DataRow myRow) {
      ParseDataRow(myRow);
    }
    public BaseContainer(int id, string name) {
      this.id = id;
      this.name = name;
    }
    protected abstract void ParseDataSet(DataSet mySet);
    protected abstract void ParseDataRow(DataRow myRow);
    protected object GetValue(DataSet mySet, string TableName, int row, int column) {
      return mySet.Tables[TableName].Rows[row][column];
    }
    protected object GetValue(DataSet mySet, int TableNum, int row, int column) {
      return mySet.Tables[TableNum].Rows[row][column];
    }
    protected object GetValue(DataSet mySet, int row, int column) {
      return GetValue(mySet, 0, row, column);
    }
    protected object GetValue(DataRow myRow, int column) {
      return myRow[column];
    }
    public override string ToString() {
      return this.name;
    }
    protected int ReadInt(object obj) {
      if (obj != null &&
          !(obj is DBNull)) {
        return Convert.ToInt32(obj);
      }
      else {
        return -1;
      }
    }
    protected string ReadString(object obj) {
      if (obj != null &&
          !(obj is DBNull)) {
        return obj.ToString();
      }
      else {
        return "";
      }
    }
    protected bool ReadBool(object obj) {
      if (obj != null &&
          !(obj is DBNull)) {
        return Convert.ToBoolean(obj);
      }
      else {
        return false;
      }
    }
    protected DateTime ReadDateTime(object obj) {
      if (obj != null &&
          !(obj is DBNull)) {
        return Convert.ToDateTime(obj);
      }
      else {
        return new DateTime(1900, 1, 1, 0, 0, 0);
      }
    }
    protected double ReadDouble(object obj) {
      if (obj != null &&
          !(obj is DBNull))
        return Convert.ToDouble(obj);
      else
        return 0.0;
    }
  }
}
