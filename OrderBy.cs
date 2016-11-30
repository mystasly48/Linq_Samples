using System.Linq;
public class OrderBy {
  public static void Main() {
    int[] array1 = { 10, 3, 8, 9, 4, 6, 7, 2, 5, 1 };
    int[] orderBy1 = array1.OrderBy(i => i).ToArray();
    // { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }

    string[] array2 = { "C#", "F#", "C++", "Java", "C", "Ruby", "Python", "JavaScript", "PHP", "Perl", "Haskell", "HTML", "CSS", "Visual Basic", "TypeScript" };
    string[] orderBy2 = array2.OrderBy(s => s).ToArray();
    // { "C", "C#", "C++", "CSS", "F#", "Haskell", "HTML", "Java", "JavaScript", "Perl", "PHP", "Python", "Ruby", "TypeScript", "Visual Basic" }
  }
}