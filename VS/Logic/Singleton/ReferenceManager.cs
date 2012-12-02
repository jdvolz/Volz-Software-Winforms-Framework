using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace VS.Logic.Singleton {
  public class ReferenceManager {
    private ReferenceManager() { }
    private static Hashtable References = new Hashtable();
    public static object GetSingleton(Type type) {
      lock (ReferenceManager.References.SyncRoot) {
        object single = ReferenceManager.References[type];
        if (single == null) {
          single = Activator.CreateInstance(type);
          References.Add(type, single);
        }
        return single;
      }
    }
    public static object GetSingleton(Type type, string name) {
      lock (ReferenceManager.References.SyncRoot) {
        object single = References[name];
        if (single == null) {
          single = Activator.CreateInstance(type);
          References.Add(name, single);
        }
        return single;
      }    
    }
    public static void SetSingleton(object singleton) {
      if (!References.Contains(singleton.GetType())) References.Add(singleton.GetType(), singleton);
    }
    public static bool Contains(Type type) { return References.Contains(type); }
    public static bool Container(string name) { return References.Contains(name); }
  }
}
