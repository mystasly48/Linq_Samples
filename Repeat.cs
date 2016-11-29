using System.Linq;
public class Repeat {
  public static void Main() {
    string[] repeat1 = Enumerable.Repeat("Repeat", 5).ToArray();
    // { "Repeat", "Repeat", "Repeat", "Repeat", "Repeat" }

    int[] repeat2 = Enumerable.Repeat(5, 10).ToArray();
    // { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }
  }
}