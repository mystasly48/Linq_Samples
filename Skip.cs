using System.Linq;
public class Skip {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] skip = array.Skip(5).ToArray();
    // { 6, 7, 8, 9, 10 }
  }
}