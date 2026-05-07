public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> anagramMap = new Dictionary<string,List<string>>();

        foreach(string s in strs)
        {
            char [] charArr = s.ToCharArray();
            Array.Sort(charArr);
            string mapKeyArr = new string(charArr);
            if(!anagramMap.ContainsKey(mapKeyArr))
            {
                 anagramMap[mapKeyArr] = new List<string>();
            }
            anagramMap[mapKeyArr].Add(s);
        }

        return anagramMap.Values.ToList();
    }
}
