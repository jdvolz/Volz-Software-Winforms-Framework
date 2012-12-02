using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace VS.GUI.Form {
  public partial class ExceptionForm : BaseForm {
    private Exception exception;
    public ExceptionForm() {InitializeComponent();}
    public ExceptionForm(Exception ex) : this() {this.exception = ex;}
    private void btnSend_Click(object sender, EventArgs e) {
      SaveLog();
      RecordError();
      this.Close();
    }
    private void btnDoNotSend_Click(object sender, EventArgs e) {
      SaveLog();
      this.Close();
    }
    private void ExceptionForm_Load(object sender, EventArgs e) {
      if (exception != null) this.rtxtDebuggingInfo.Text = exception.ToString();
      rtxtUserAction.Focus();
    }
    private void SaveLog() { }
    private void RecordError() {      
      if (Post()) {
        BaseMessageForm form = new BaseMessageForm("Your error information has been successfully sent to VolZ Software", 
          "Success", MessagePicture.Inform);
        form.ShowDialog();
      }
      else {
        BaseMessageForm form = new BaseMessageForm("Your error information submission failed.  " + 
          "The error information will be recorded on your hard drive for future retrieval.", 
          "Failed", MessagePicture.Inform);
        form.ShowDialog();
      }
    }
    private bool Post() {
      Stream os = null;      
      try {
        WebRequest req = WebRequest.Create(GetPath());
        req.ContentType = "application/x-www-form=urlencoded";
        req.Method = "POST";
        byte[] bytes = System.Text.Encoding.ASCII.GetBytes(GetParameters());
        req.ContentLength = bytes.Length;
        os = req.GetRequestStream();
        os.Write(bytes, 0, bytes.Length);
        WebResponse resp = req.GetResponse();
        if (resp == null) return false;
        else return true;
      }
      catch { return false; }
      finally { if (os != null) os.Close(); }
    }
    protected virtual string GetPath() {
      return "http://volzsoftware.com/Exception/RecordException.php";
    }
    protected virtual string GetParameters() {
      StringBuilder sb = new StringBuilder();
      sb.Append("?");
      sb.Append("Exception=" + rtxtDebuggingInfo.Text);
      sb.Append("&");
      sb.Append("Key=");
      return sb.ToString();
    }
  }
}