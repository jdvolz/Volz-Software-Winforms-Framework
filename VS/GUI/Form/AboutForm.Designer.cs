namespace VS.GUI.Form {
  partial class AboutForm {
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
      this.btnOk = new VS.GUI.InheritedControl.VSButton();
      this.vsLabel1 = new VS.GUI.InheritedControl.VSLabel();
      this.vsLabel2 = new VS.GUI.InheritedControl.VSLabel();
      this.vsLabel3 = new VS.GUI.InheritedControl.VSLabel();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.DataSource = null;
      this.btnOk.DataSourceProperty = null;
      this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOk.LocalProperty = null;
      this.btnOk.Location = new System.Drawing.Point(12, 182);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 28);
      this.btnOk.TabIndex = 0;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // vsLabel1
      // 
      this.vsLabel1.DataSource = null;
      this.vsLabel1.DataSourceProperty = null;
      this.vsLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel1.LocalProperty = null;
      this.vsLabel1.Location = new System.Drawing.Point(114, 31);
      this.vsLabel1.Name = "vsLabel1";
      this.vsLabel1.Size = new System.Drawing.Size(283, 26);
      this.vsLabel1.TabIndex = 1;
      this.vsLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // vsLabel2
      // 
      this.vsLabel2.AutoSize = true;
      this.vsLabel2.DataSource = null;
      this.vsLabel2.DataSourceProperty = null;
      this.vsLabel2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel2.LocalProperty = null;
      this.vsLabel2.Location = new System.Drawing.Point(240, 71);
      this.vsLabel2.Name = "vsLabel2";
      this.vsLabel2.Size = new System.Drawing.Size(30, 23);
      this.vsLabel2.TabIndex = 2;
      this.vsLabel2.Text = "By";
      // 
      // vsLabel3
      // 
      this.vsLabel3.AutoSize = true;
      this.vsLabel3.DataSource = null;
      this.vsLabel3.DataSourceProperty = null;
      this.vsLabel3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel3.LocalProperty = null;
      this.vsLabel3.Location = new System.Drawing.Point(194, 123);
      this.vsLabel3.Name = "vsLabel3";
      this.vsLabel3.Size = new System.Drawing.Size(123, 23);
      this.vsLabel3.TabIndex = 3;
      this.vsLabel3.Text = "Volz Software";
      this.vsLabel3.MouseLeave += new System.EventHandler(this.vsLabel3_MouseLeave);
      this.vsLabel3.Click += new System.EventHandler(this.vsLabel3_Click);
      this.vsLabel3.MouseEnter += new System.EventHandler(this.vsLabel3_MouseEnter);
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(507, 222);
      this.Controls.Add(this.vsLabel3);
      this.Controls.Add(this.vsLabel2);
      this.Controls.Add(this.vsLabel1);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "AboutForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.Load += new System.EventHandler(this.AboutForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private VS.GUI.InheritedControl.VSButton btnOk;
    private VS.GUI.InheritedControl.VSLabel vsLabel1;
    private VS.GUI.InheritedControl.VSLabel vsLabel2;
    private VS.GUI.InheritedControl.VSLabel vsLabel3;
  }
}