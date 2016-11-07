using System.Linq;
public class ElementAtOrDefault {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int elementAtOrDefault1 = array.ElementAtOrDefault(5);
    // 6
    int elementAtOrDefault2 = array.ElementAtOrDefault(15);
    // 0
  }
}