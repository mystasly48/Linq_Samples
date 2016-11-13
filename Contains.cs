using System.Linq;
public class Contains {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    bool contains1 = array.Contains(5);
    // true

    bool contains2 = array.Contains(15);
    // false
  }
}