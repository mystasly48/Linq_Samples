using System.Linq;
public class Program {
  public static void Main() {
    int[] array1 = { 1, 2, 3 };
    int[] array2 = { 7, 8, 9 };
    int[] concat1 = array1.Concat(array2).ToArray();
    // { 1, 2, 3, 7, 8, 9 }

    string[] array3 = { "hello", "world" };
    string[] array4 = { "konitiha", "sekai" };
    string[] concat2 = array3.Concat(array4).ToArray();
    // { "hello", "world", "konitiha", "sekai" }
  }
}