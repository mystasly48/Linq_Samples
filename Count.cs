using System.Linq;
public class Count {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int count1 = array.Count();
    // 10
    int count2 = array.Where(i => i % 3 == 0).Count();
    // 3
    int count3 = array.Count(i => i % 3 == 0);
    // 3
  }
}