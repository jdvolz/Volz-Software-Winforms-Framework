using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace VS.Connection {
  public class BaseConnection {
    protected SqlCommand myCommand;
    protected SqlDataAdapter myAdapter;
    protected SqlConnection myConnection;
    public static string dataSource = "";
    protected string connectionString;
    public BaseConnection() {
      SetConnectionString();
      this.myConnection = BaseConnection.GetConnection(this.connectionString);
      myCommand = new SqlCommand(null, this.myConnection);
      myAdapter = new SqlDataAdapter(null, this.myConnection);
    }
    protected DateTime GetDate() {return DateTime.Now;}
    protected string GetDate(string mask) {return DateTime.Now.ToString(mask);}
    protected bool Insert(string InsertText) { return this.NonQuery(InsertText); }
    protected bool Update(string UpdateText) { return this.NonQuery(UpdateText); }
    protected bool Delete(string DeleteText) { return this.NonQuery(DeleteText); }
    protected bool Delete(string tableName, string idName, int id) {
      string delete = "update " + tableName + " set isdeleted = " + Format(true) + "where " + idName + " = " + id;
      return this.NonQuery(delete);
    }
    protected bool Select(string select, DataSet mySet, string tableName) { return this.Query(select, mySet, tableName); }
    protected string Format(string text) {
      if (text != null) text = text.Replace("'", "''");
      return "'" + text + "'";
    }
    protected string Format(int text) { return text.ToString(); }
    protected string Format(bool text) {     
      if (text) return "1";
      return "0";
    }
    protected string Format(DateTime text) {
      if (text == null || text.CompareTo(new DateTime(1900,1,1)) <= 0) return "NULL";
      return "'" + text.ToString() + "'"; 
    }
    protected string Format(double text) { return text.ToString(); }
    protected bool Query(string select, DataSet mySet, string tableName) {
      try {
        lock (this) {
          this.myAdapter.SelectCommand = new SqlCommand(select, this.myConnection);
          this.myAdapter.Fill(mySet, tableName);
        }
        return true;
      }
      catch (Exception exception) {
        System.Windows.Forms.MessageBox.Show(select + "\n\n" + exception.ToString());
        return false;
      }
      finally { 
        if( this.myConnection != null) this.myConnection.Close();
      }
    }
    protected bool NonQuery(string sqlText) {
      try {
        this.myCommand.CommandText = sqlText;
        lock (this) {
          this.myConnection.Open();
          this.myCommand.ExecuteNonQuery();
          this.myConnection.Close();
        }
        return true;
      }
      catch (Exception exception){
        System.Windows.Forms.MessageBox.Show(sqlText + "\n\n" + exception.ToString());
        return false;
      }
      finally {
        if (this.myConnection != null) this.myConnection.Close();
      }
    }
    protected DataTable RunStoredProcedure(string storedProcedure, Dictionary<string, object> args) {
      myCommand = new SqlCommand("", myConnection);      
      myCommand.CommandType = CommandType.StoredProcedure;
      myCommand.CommandText = storedProcedure;
      foreach (string key in args.Keys) { myCommand.Parameters.Add(new SqlParameter(key, args[key])); }
      myAdapter = new SqlDataAdapter(myCommand);
      DataTable data = new DataTable();
      try {
        myAdapter.Fill(data);
        return data;
      }
      catch { return null; }
      finally { if (myCommand.Connection.State == ConnectionState.Open) myCommand.Connection.Close(); }
    }
    public static SqlConnection GetConnection(string connectionString) {
      if (dbconn == null) dbconn = new SqlConnection(connectionString);
      return dbconn;
    }
    public static SqlConnection dbconn;
    protected void SetConnectionString() { this.connectionString = BaseConnection.dataSource; }
  }
}
