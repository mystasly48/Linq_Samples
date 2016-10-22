using System.Linq;
using System.Collections;
public class ToList {
  public static void Main() {
    RangeIterator range = Enumerable.Range(1, 10);
    
    List<int> toList = range.ToList();
  }
}