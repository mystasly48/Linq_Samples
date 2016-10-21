using System.Linq;
public class Select {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    string[] select = array.Select(i => i.ToString()).ToArray();
    // { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }
  }
}