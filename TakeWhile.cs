public class TakeWhile {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int[] takeWhile1 = array.TakeWhile(i => i < 5).ToArray();
    // { 1, 2, 3, 4 }

    int[] takeWhile2 = array.TakeWhile(i => i != 8).ToArray();
    /// { 1, 2, 3, 4, 5, 6, 7 }
  }
}