using System.Linq;
public class Range {
  public static void Main() {
    int[] range1 = Enumerable.Range(1, 10).ToArray();
    // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

    int[] range2 = Enumerable.Range(5, 3).ToArray();
    // { 5, 6, 7 }
  }
}
