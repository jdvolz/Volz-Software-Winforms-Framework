namespace VS.GUI.Form {
  partial class ExceptionForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionForm));
      this.vsLabel1 = new VS.GUI.InheritedControl.VSLabel();
      this.rtxtDebuggingInfo = new System.Windows.Forms.RichTextBox();
      this.rtxtUserAction = new System.Windows.Forms.RichTextBox();
      this.vsLabel2 = new VS.GUI.InheritedControl.VSLabel();
      this.btnSend = new VS.GUI.InheritedControl.VSButton();
      this.btnDoNotSend = new VS.GUI.InheritedControl.VSButton();
      this.vsLabel3 = new VS.GUI.InheritedControl.VSLabel();
      this.richTextBox3 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // vsLabel1
      // 
      this.vsLabel1.AutoSize = true;
      this.vsLabel1.DataSource = null;
      this.vsLabel1.DataSourceProperty = null;
      this.vsLabel1.LocalProperty = null;
      this.vsLabel1.Location = new System.Drawing.Point(12, 134);
      this.vsLabel1.Name = "vsLabel1";
      this.vsLabel1.Size = new System.Drawing.Size(483, 16);
      this.vsLabel1.TabIndex = 0;
      this.vsLabel1.Text = "Below is the information that will be sent to Volz Software for debugging purpose" +
          "s.";
      // 
      // rtxtDebuggingInfo
      // 
      this.rtxtDebuggingInfo.Location = new System.Drawing.Point(12, 153);
      this.rtxtDebuggingInfo.Name = "rtxtDebuggingInfo";
      this.rtxtDebuggingInfo.Size = new System.Drawing.Size(541, 96);
      this.rtxtDebuggingInfo.TabIndex = 1;
      this.rtxtDebuggingInfo.Text = "";
      // 
      // rtxtUserAction
      // 
      this.rtxtUserAction.Location = new System.Drawing.Point(12, 306);
      this.rtxtUserAction.Name = "rtxtUserAction";
      this.rtxtUserAction.Size = new System.Drawing.Size(541, 96);
      this.rtxtUserAction.TabIndex = 3;
      this.rtxtUserAction.Text = "";
      // 
      // vsLabel2
      // 
      this.vsLabel2.AutoSize = true;
      this.vsLabel2.DataSource = null;
      this.vsLabel2.DataSourceProperty = null;
      this.vsLabel2.LocalProperty = null;
      this.vsLabel2.Location = new System.Drawing.Point(12, 264);
      this.vsLabel2.Name = "vsLabel2";
      this.vsLabel2.Size = new System.Drawing.Size(517, 16);
      this.vsLabel2.TabIndex = 2;
      this.vsLabel2.Text = "Please enter a description of what you were doing when the program failed.  This " +
          "is very";
      // 
      // btnSend
      // 
      this.btnSend.DataSource = null;
      this.btnSend.DataSourceProperty = null;
      this.btnSend.LocalProperty = null;
      this.btnSend.Location = new System.Drawing.Point(301, 425);
      this.btnSend.Name = "btnSend";
      this.btnSend.Size = new System.Drawing.Size(104, 23);
      this.btnSend.TabIndex = 4;
      this.btnSend.Text = "Send Report";
      this.btnSend.UseVisualStyleBackColor = true;
      this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
      // 
      // btnDoNotSend
      // 
      this.btnDoNotSend.DataSource = null;
      this.btnDoNotSend.DataSourceProperty = null;
      this.btnDoNotSend.LocalProperty = null;
      this.btnDoNotSend.Location = new System.Drawing.Point(411, 425);
      this.btnDoNotSend.Name = "btnDoNotSend";
      this.btnDoNotSend.Size = new System.Drawing.Size(142, 23);
      this.btnDoNotSend.TabIndex = 5;
      this.btnDoNotSend.Text = "Do Not Send Report";
      this.btnDoNotSend.UseVisualStyleBackColor = true;
      this.btnDoNotSend.Click += new System.EventHandler(this.btnDoNotSend_Click);
      // 
      // vsLabel3
      // 
      this.vsLabel3.AutoSize = true;
      this.vsLabel3.DataSource = null;
      this.vsLabel3.DataSourceProperty = null;
      this.vsLabel3.LocalProperty = null;
      this.vsLabel3.Location = new System.Drawing.Point(12, 287);
      this.vsLabel3.Name = "vsLabel3";
      this.vsLabel3.Size = new System.Drawing.Size(395, 16);
      this.vsLabel3.TabIndex = 6;
      this.vsLabel3.Text = "helpful in determining and fixing the problem that caused this error.";
      // 
      // richTextBox3
      // 
      this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox3.Location = new System.Drawing.Point(12, 3);
      this.richTextBox3.Name = "richTextBox3";
      this.richTextBox3.Size = new System.Drawing.Size(541, 120);
      this.richTextBox3.TabIndex = 7;
      this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
      // 
      // ExceptionForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(565, 462);
      this.Controls.Add(this.richTextBox3);
      this.Controls.Add(this.vsLabel3);
      this.Controls.Add(this.btnDoNotSend);
      this.Controls.Add(this.btnSend);
      this.Controls.Add(this.rtxtUserAction);
      this.Controls.Add(this.vsLabel2);
      this.Controls.Add(this.rtxtDebuggingInfo);
      this.Controls.Add(this.vsLabel1);
      this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.Color.Black;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "ExceptionForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Record Error Information";
      this.Load += new System.EventHandler(this.ExceptionForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private VS.GUI.InheritedControl.VSLabel vsLabel1;
    private System.Windows.Forms.RichTextBox rtxtDebuggingInfo;
    private System.Windows.Forms.RichTextBox rtxtUserAction;
    private VS.GUI.InheritedControl.VSLabel vsLabel2;
    private VS.GUI.InheritedControl.VSButton btnSend;
    private VS.GUI.InheritedControl.VSButton btnDoNotSend;
    private VS.GUI.InheritedControl.VSLabel vsLabel3;
    private System.Windows.Forms.RichTextBox richTextBox3;
  }
}