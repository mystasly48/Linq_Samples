using System.Linq;
public class Where {
  public static void Main() {
    int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    
    int[] where = array.Where(i => i % 3 == 0).ToArray();
    // { 3, 6, 9 }
  }
}