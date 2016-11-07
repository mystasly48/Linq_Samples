using System.Linq;
public class Reverse {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] reverse = array.Reverse().ToArray();
    // 10, 9, 8, 7, 6, 5, 4, 3, 2, 1
  }
}