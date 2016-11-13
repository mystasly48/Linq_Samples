using System.Linq;
public class Any {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    bool any1 = array.Any(i => i == 5);
    // true

    bool any2 = array.Any(i => i > 10);
    // false

    bool any3 = array.Any();
    // true
  }
}