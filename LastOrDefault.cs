using System.Linq;
public class LastOrDefault {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int last1 = array.LastOrDefault();
    // 10
    int last2 = array.LastOrDefault(i => i >= 100);
    // 0
  }
}