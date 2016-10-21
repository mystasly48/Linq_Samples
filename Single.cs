using System.Linq;
public class Single {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int single1 = array.Single();
    // System.InvalidOperationException: シーケンスに複数の要素が含まれています
    int single2 = array.Single(i => i >= 10);
    // 10
  }
}