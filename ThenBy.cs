using System.Linq;
public class ThenBy {
  public static void Main() {
    string[] array = { "C#", "F#", "C++", "Java", "C", "Ruby", "Python", "JavaScript", "PHP", "Perl", "Haskell", "HTML", "CSS", "Visual Basic", "TypeScript" };
    string[] thenBy = array.OrderBy(s => s.Length).ThenBy(s => s).ToArray();
    // OrderBy(s => s.Length) で、文字列の長さの昇順にしている。そして、同じ長さの要素に対してのみ、ThenBy(s => s) で文字列の昇順にしている。
    // { "C", "C#", "F#", "C++", "CSS", "PHP", "HTML", "Java", "Perl", "Ruby", "Python", "Haskell", "JavaScript", "TypeScript", "Visual Basic" }
  }
}
