using System.Linq;
public class OrderByDescending {
  public static void Main() {
    int[] array1 = { 10, 3, 8, 9, 4, 6, 7, 2, 5, 1 };
    int[] orderByDescending1 = array1.OrderByDescending(i => i).ToArray();
    // { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }

    string[] array2 = { "C#", "F#", "C++", "Java", "C", "Ruby", "Python", "JavaScript", "PHP", "Perl", "Haskell", "HTML", "CSS", "Visual Basic", "TypeScript" };
    string[] orderByDescending2 = array2.OrderByDescending(s => s).ToArray();
    // { "VisualBasic", "TypeScript", "Ruby", "Python", "PHP", "Perl", "JavaScript", "Java", "HTML", "Haskell", "F#", "CSS", "C++", "C#", "C" }
  }
}
