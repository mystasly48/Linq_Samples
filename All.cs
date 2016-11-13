using System.Linq;
public class All {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    bool all1 = array.All(i => i >= 0);
    // true

    bool all2 = array.All(i => i == 5);
    // false
  }
}