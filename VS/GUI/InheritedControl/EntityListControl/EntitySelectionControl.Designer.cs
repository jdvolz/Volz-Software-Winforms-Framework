namespace VS.GUI.InheritedControl.EntityListControl {
  partial class EntitySelectionControl {
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
      this.vsComboBox1 = new VS.GUI.InheritedControl.VSComboBoxSelector();
      this.SuspendLayout();
      // 
      // vsComboBox1
      // 
      this.vsComboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.vsComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
      this.vsComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.vsComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.vsComboBox1.DataSourceList = null;
      this.vsComboBox1.FormattingEnabled = true;
      this.vsComboBox1.Location = new System.Drawing.Point(0, 0);
      this.vsComboBox1.Name = "vsComboBox1";
      this.vsComboBox1.ShowNotAssigned = true;
      this.vsComboBox1.Size = new System.Drawing.Size(258, 21);
      this.vsComboBox1.TabIndex = 0;
      this.vsComboBox1.SelectedIndexChanged += new System.EventHandler(this.vsComboBox1_SelectedIndexChanged);
      // 
      // EntitySelectionControl
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.vsComboBox1);
      this.Name = "EntitySelectionControl";
      this.Size = new System.Drawing.Size(275, 31);
      this.ResumeLayout(false);

    }

    #endregion

    protected VSComboBoxSelector vsComboBox1;

  }
}
