using System.Linq;
public class ThenByDescending {
  public static void Main() {
    string[] array = { "C#", "F#", "C++", "Java", "C", "Ruby", "Python", "JavaScript", "PHP", "Perl", "Haskell", "HTML", "CSS", "Visual Basic", "TypeScript" };
    string[] thenByDescending = array.OrderBy(s => s.Length).ThenByDescending(s => s).ToArray();
    // OrderBy(s => s.Length) で、文字列の長さの昇順にしている。そして、同じ長さの要素に対してのみ、ThenByDescending(s => s) で文字列の降順にしている。
    // { "C", "F#", "C#", "PHP", "CSS", "C++", "Ruby", "Perl", "Java", "HTML", "Python", "Haskell", "TypeScript", "JavaScript", "Visual Basic" }
  }
}
