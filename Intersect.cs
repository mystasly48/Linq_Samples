using System.Linq;
public class Intersect {
  public static void Main() {
    int[] array1 = { 1, 2, 3, 4, 5, 6 };
    int[] array2 = { 4, 5, 6, 7 ,8, 9 };

    int[] intersect = array1.Intersect(array2).ToArray();
    // array1 と array2 の双方に存在する要素を返す、よって結果は
    // { 4, 5, 6 }
  }
}
