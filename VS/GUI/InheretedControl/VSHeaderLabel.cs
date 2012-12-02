using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VS.GUI.InheritedControl.Interface;
using VS.Logic;

namespace VS.GUI.InheritedControl {
  public partial class VSHeaderLabel : VSLabel {
    public VSHeaderLabel() {
      this.BackColor = System.Drawing.Color.SteelBlue;
      this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
      this.ForeColor = System.Drawing.Color.Black;
      this.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
    }
  }
}
