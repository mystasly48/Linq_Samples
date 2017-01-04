using System.Linq;
public class Union {
  public static void Main() {
    int[] array1 = { 1, 2, 3, 4, 5, 6 };
    int[] array2 = { 5, 6, 7, 8, 9, 10 };
    int[] union1 = array1.Union(array2).ToArray();
    // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
  }
}
