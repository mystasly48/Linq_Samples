using System.Linq;
public class SingleOrDefault {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int single1 = array.SingleOrDefault();
    // 0
    int single2 = array.SingleOrDefault(i => i >= 10);
    // 10
  }
}