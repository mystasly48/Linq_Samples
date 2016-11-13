using System.Linq;
public class SequenceEqual {
  public static void Main() {
    int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] array3 = { 2, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    bool sequenceEqual1 = array1.SequenceEqual(array2);
    // true

    bool sequenceEqual2 = array1.SequenceEqual(array3);
    // false
  }
}