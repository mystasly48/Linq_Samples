using System.Linq;
using System.Collections.Generic;
public class ToArray {
  public static void Main() {
    IEnumerable<int> range = Enumerable.Range(1, 10);
    
    int[] toArray = range.ToArray();
  }
}