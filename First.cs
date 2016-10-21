using System.Linq;
public class First {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int first1 = array.First();
    // 1
    int first2 = array.First(i => i % 3 == 0);
    // 3
  }
}