using System.Linq;
public class Distinct {
  public static void Main() {
    int[] array = { 1, 1, 3, 4, 4, 6, 7, 7, 9, 10 };

    int[] distinct = array.Distinct();
    // { 1, 3, 4, 6, 7, 9, 10 }
  }
}