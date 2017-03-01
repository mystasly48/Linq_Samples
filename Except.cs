using System.Linq;
public class Except {
  public static void Main() {
    int[] array1 = { 1, 2, 3, 4, 5, 6 };
    int[] array2 = { 4, 5, 6, 7, 8, 9 };

    int[] except = array1.Except(array2).ToArray();
    // array1 から array2 を引いた要素を返す、よって結果は
    // { 1, 2, 3 }
  }
}
