using System.Linq;
public class Take {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] take = array.Take(5).ToArray();
    // { 1, 2, 3, 4, 5 }
  }
}