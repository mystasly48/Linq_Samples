using System.Linq;
using System.Collections.Generic;
public class ToList {
  public static void Main() {
    IEnumerable<int> range = Enumerable.Range(1, 10);
    
    List<int> toList = range.ToList();
  }
}