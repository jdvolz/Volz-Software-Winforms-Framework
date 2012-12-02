using System;
using System.Collections.Generic;
using System.Text;
using VS.Container;

namespace VS.GUI.InheritedControl.Interface {
  
  public interface IDataBindSinglePersist {
    object DataSource { get; set; }
    string DataSourceProperty { get; set; }
    string LocalProperty { get; set; }
    void RebindData();
    void RebindData(object container);
    void BindData(string LocalProperty, object DataSource, string DataSourceProperty);
    event EventHandler BindingOccured;
  }
  public interface IDataBindListPersist {
    List<BaseContainer> AlternativeDataSourceList { get; set; }
    List<BaseContainer> DataSourceList { get; set; }
    void RebindData();
    void BindData(List<BaseContainer> DataSourceList);
  }
}
