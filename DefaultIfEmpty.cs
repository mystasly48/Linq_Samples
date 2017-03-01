using System.Linq;
using System.Collections.Generic;
public class DefaultIfEmpty {
  public static void Main() {
    List<int> list1 = new List<int>();
    List<int> defaultIfEmpty1 = list1.DefaultIfEmpty().ToList();
    // { 0 }

    List<string> list2 = new List<string>();
    List<string> defaultIfEmpty2 = list2.DefaultIfEmpty().ToList();
    // { null }
  }
}
