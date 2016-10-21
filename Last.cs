using System.Linq;
public class Last {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int last1 = array.Last();
    // 10
    int last2 = array.Last(i => i % 3 == 0);
    // 9
  }
}