public class SkipWhile {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] skipWhile1 = array.SkipWhile(i => i < 5).ToArray();
    // { 5, 6, 7, 8, 9, 10 }

    int[] skipWhile2 = array.SkipWhile(i => i != 3).ToArray();
    // { 3, 4, 5, 6, 7, 8, 9, 10 }
  }
}