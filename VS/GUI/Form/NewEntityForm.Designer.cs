namespace VS.GUI.Form {
  partial class NewEntityForm {
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
      this.txtName = new VS.GUI.InheritedControl.VSTextBox();
      this.vsLabel1 = new VS.GUI.InheritedControl.VSLabel();
      this.btnCancel = new VS.GUI.InheritedControl.VSButton();
      this.SuspendLayout();
      // 
      // btnOk
      // 
      this.btnOk.BackColor = System.Drawing.Color.White;
      this.btnOk.DataSource = null;
      this.btnOk.DataSourceProperty = null;
      this.btnOk.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnOk.LocalProperty = null;
      this.btnOk.Location = new System.Drawing.Point(145, 38);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(90, 23);
      this.btnOk.TabIndex = 1;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = false;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // txtName
      // 
      this.txtName.BackColor = System.Drawing.Color.White;
      this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtName.DataSource = null;
      this.txtName.DataSourceProperty = null;
      this.txtName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.ForeColor = System.Drawing.Color.Black;
      this.txtName.LocalProperty = null;
      this.txtName.Location = new System.Drawing.Point(68, 9);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(265, 23);
      this.txtName.TabIndex = 0;
      // 
      // vsLabel1
      // 
      this.vsLabel1.AutoSize = true;
      this.vsLabel1.DataSource = null;
      this.vsLabel1.DataSourceProperty = null;
      this.vsLabel1.LocalProperty = null;
      this.vsLabel1.Location = new System.Drawing.Point(12, 14);
      this.vsLabel1.Name = "vsLabel1";
      this.vsLabel1.Size = new System.Drawing.Size(35, 13);
      this.vsLabel1.TabIndex = 2;
      this.vsLabel1.Text = "Name";
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.White;
      this.btnCancel.DataSource = null;
      this.btnCancel.DataSourceProperty = null;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.LocalProperty = null;
      this.btnCancel.Location = new System.Drawing.Point(241, 38);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(92, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // NewEntityForm
      // 
      this.AcceptButton = this.btnOk;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(357, 77);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.vsLabel1);
      this.Controls.Add(this.txtName);
      this.Controls.Add(this.btnOk);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewEntityForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewEntityForm_FormClosed);
      this.Load += new System.EventHandler(this.NewEntityForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private VS.GUI.InheritedControl.VSButton btnOk;
    private VS.GUI.InheritedControl.VSTextBox txtName;
    private VS.GUI.InheritedControl.VSLabel vsLabel1;
    private VS.GUI.InheritedControl.VSButton btnCancel;
  }
}