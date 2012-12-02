namespace VS.GUI.InheretedControl.EntityListControl {
  partial class EntityListControl {
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
      this.vsTextBox1 = new VS.GUI.InheritedControl.VSTextBox();
      this.vsListBox1 = new VS.GUI.InheritedControl.VSListBox();
      this.vsLabel1 = new VS.GUI.InheritedControl.VSLabel();
      this.vsLabel2 = new VS.GUI.InheritedControl.VSLabel();
      this.SuspendLayout();
      // 
      // vsTextBox1
      // 
      this.vsTextBox1.BackColor = System.Drawing.Color.White;
      this.vsTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.vsTextBox1.DataSource = null;
      this.vsTextBox1.DataSourceProperty = null;
      this.vsTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsTextBox1.ForeColor = System.Drawing.Color.Black;
      this.vsTextBox1.LocalProperty = null;
      this.vsTextBox1.Location = new System.Drawing.Point(3, 3);
      this.vsTextBox1.Name = "vsTextBox1";
      this.vsTextBox1.Size = new System.Drawing.Size(237, 23);
      this.vsTextBox1.TabIndex = 0;
      this.vsTextBox1.TextChanged += new System.EventHandler(this.vsTextBox1_TextChanged);
      // 
      // vsListBox1
      // 
      this.vsListBox1.BackColor = System.Drawing.Color.White;
      this.vsListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.vsListBox1.DataSourceList = null;
      this.vsListBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsListBox1.FormattingEnabled = true;
      this.vsListBox1.ItemHeight = 16;
      this.vsListBox1.Location = new System.Drawing.Point(3, 32);
      this.vsListBox1.Name = "vsListBox1";
      this.vsListBox1.Size = new System.Drawing.Size(237, 434);
      this.vsListBox1.TabIndex = 1;
      this.vsListBox1.SelectedIndexChanged += new System.EventHandler(this.vsListBox_SelectedIndexChanged);
      // 
      // vsLabel1
      // 
      this.vsLabel1.AutoSize = true;
      this.vsLabel1.DataSource = null;
      this.vsLabel1.DataSourceProperty = null;
      this.vsLabel1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel1.LocalProperty = null;
      this.vsLabel1.Location = new System.Drawing.Point(3, 469);
      this.vsLabel1.Name = "vsLabel1";
      this.vsLabel1.Size = new System.Drawing.Size(46, 16);
      this.vsLabel1.TabIndex = 2;
      this.vsLabel1.Text = "Count:";
      // 
      // vsLabel2
      // 
      this.vsLabel2.AutoSize = true;
      this.vsLabel2.DataSource = null;
      this.vsLabel2.DataSourceProperty = null;
      this.vsLabel2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vsLabel2.LocalProperty = null;
      this.vsLabel2.Location = new System.Drawing.Point(69, 469);
      this.vsLabel2.Name = "vsLabel2";
      this.vsLabel2.Size = new System.Drawing.Size(124, 16);
      this.vsLabel2.TabIndex = 3;
      this.vsLabel2.Text = "                             ";
      // 
      // EntityListControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.vsLabel2);
      this.Controls.Add(this.vsLabel1);
      this.Controls.Add(this.vsListBox1);
      this.Controls.Add(this.vsTextBox1);
      this.Name = "EntityListControl";
      this.Size = new System.Drawing.Size(243, 497);
      this.Load += new System.EventHandler(this.EntityListControl_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private VS.GUI.InheritedControl.VSTextBox vsTextBox1;
    private VS.GUI.InheritedControl.VSListBox vsListBox1;
    private VS.GUI.InheritedControl.VSLabel vsLabel1;
    private VS.GUI.InheritedControl.VSLabel vsLabel2;
  }
}
