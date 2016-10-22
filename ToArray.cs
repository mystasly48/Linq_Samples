using System.Linq;
public class ToArray {
  public static void Main() {
    RangeIterator range = Enumerable.Range(1, 10);
    
    int[] toArray = range.ToArray();
  }
}