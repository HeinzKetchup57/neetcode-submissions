public class Solution {
    public bool IsAnagram(string s, string t) {
        char[] s_arr = s.ToCharArray();
        Array.Sort(s_arr);
        char[] t_arr = t.ToCharArray();
        Array.Sort(t_arr);

        //Console.WriteLine(s_arr);
        //Console.WriteLine(t_arr);

        return new string(s_arr) == new string(t_arr);
    }
}
