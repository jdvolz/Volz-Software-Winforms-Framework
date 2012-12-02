namespace VS.GUI {
  partial class EditEntityControl {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.vsPanel1 = new VS.GUI.InheritedControl.VSPanel();
      this.btnSaveAs = new VS.GUI.InheritedControl.VSButton();
      this.btnDelete = new VS.GUI.InheritedControl.VSButton();
      this.btnSave = new VS.GUI.InheritedControl.VSButton();
      this.btnNew = new VS.GUI.InheritedControl.VSButton();
      this.vsPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // vsPanel1
      // 
      this.vsPanel1.Controls.Add(this.btnSaveAs);
      this.vsPanel1.Controls.Add(this.btnDelete);
      this.vsPanel1.Controls.Add(this.btnSave);
      this.vsPanel1.Controls.Add(this.btnNew);
      this.vsPanel1.DataSource = null;
      this.vsPanel1.DataSourceProperty = null;
      this.vsPanel1.LocalProperty = null;
      this.vsPanel1.Location = new System.Drawing.Point(3, 3);
      this.vsPanel1.Name = "vsPanel1";
      this.vsPanel1.Size = new System.Drawing.Size(192, 70);
      this.vsPanel1.TabIndex = 0;
      // 
      // btnSaveAs
      // 
      this.btnSaveAs.BackColor = System.Drawing.Color.White;
      this.btnSaveAs.DataSource = null;
      this.btnSaveAs.DataSourceProperty = null;
      this.btnSaveAs.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSaveAs.LocalProperty = null;
      this.btnSaveAs.Location = new System.Drawing.Point(101, 36);
      this.btnSaveAs.Name = "btnSaveAs";
      this.btnSaveAs.Size = new System.Drawing.Size(85, 27);
      this.btnSaveAs.TabIndex = 3;
      this.btnSaveAs.Text = "Save As";
      this.btnSaveAs.UseVisualStyleBackColor = false;
      this.btnSaveAs.Click += new System.EventHandler(this.btnSaveAs_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.White;
      this.btnDelete.DataSource = null;
      this.btnDelete.DataSourceProperty = null;
      this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.LocalProperty = null;
      this.btnDelete.Location = new System.Drawing.Point(10, 36);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(85, 27);
      this.btnDelete.TabIndex = 2;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnSave
      // 
      this.btnSave.BackColor = System.Drawing.Color.White;
      this.btnSave.DataSource = null;
      this.btnSave.DataSourceProperty = null;
      this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSave.LocalProperty = null;
      this.btnSave.Location = new System.Drawing.Point(101, 3);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(85, 27);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = false;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnNew
      // 
      this.btnNew.BackColor = System.Drawing.Color.White;
      this.btnNew.DataSource = null;
      this.btnNew.DataSourceProperty = null;
      this.btnNew.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnNew.LocalProperty = null;
      this.btnNew.Location = new System.Drawing.Point(10, 3);
      this.btnNew.Name = "btnNew";
      this.btnNew.Size = new System.Drawing.Size(85, 27);
      this.btnNew.TabIndex = 0;
      this.btnNew.Text = "New";
      this.btnNew.UseVisualStyleBackColor = false;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // EditEntityControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.vsPanel1);
      this.Name = "EditEntityControl";
      this.Size = new System.Drawing.Size(866, 527);
      this.Load += new System.EventHandler(this.EditEntityControl_Load);
      this.vsPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private VS.GUI.InheritedControl.VSPanel vsPanel1;
    protected VS.GUI.InheritedControl.VSButton btnSaveAs;
    protected VS.GUI.InheritedControl.VSButton btnDelete;
    protected VS.GUI.InheritedControl.VSButton btnSave;
    protected VS.GUI.InheritedControl.VSButton btnNew;
  }
}
