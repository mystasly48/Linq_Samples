using System.Linq;
public class FirstOrDefault {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int firstOrDefault1 = array.FirstOrDefault();
    // 1
    int firstOrDefault2 = array.FirstOrDefault(i => i >= 100);
    // 0
  }
}