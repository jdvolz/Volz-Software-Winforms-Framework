using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VS.GUI.Form {
  public partial class BaseMessageForm : BaseForm {
    public BaseMessageForm() {
      InitializeComponent();
    }
    public BaseMessageForm(string message, string header) : this() {
      this.Text = header;
      this.richTextBox1.Text = message;
      this.SetImage(MessagePicture.Error);      
    }
    public BaseMessageForm(string message, string header, MessagePicture pic) : this() {
      this.Text = header;
      this.richTextBox1.Text = message;
      this.SetImage(pic);
    }
    private void btnOk_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    private void btnCancel_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
    private void SetImage(MessagePicture pic) {
      this.pictureBox1.SuspendLayout();
      this.pictureBox1.Image = imageList1.Images[(int)pic];
      this.pictureBox1.ResumeLayout();
    }
  }
  public enum MessagePicture { Error = 0, Alert = 1, Inform = 2 };
}
