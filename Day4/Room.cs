using System.Collections.Generic;
using System.Linq;

namespace Day4
{
    public static class Room
    {
        public static int Decode(string name)
        {
            var parts = name.Split('-');
            var lastPart = parts[parts.Length - 1];
            var value = int.Parse(lastPart.Substring(0, lastPart.IndexOf('[')));
            var chksm = lastPart.Substring(lastPart.IndexOf('[') + 1, lastPart.Length - 2 - lastPart.IndexOf('['));

            var d = new Dictionary<char, int>();

            for (var i = 0; i < parts.Length - 1; i++)
            {
                foreach (var c in parts[i])
                {
                    if (d.ContainsKey(c))
                    {
                        d[c]++;
                    }
                    else
                    {
                        d.Add(c, 1);
                    }
                }
            }

            var sortedKvpList = d.OrderByDescending(kvp => kvp.Value).ToList();
            var checkAgainst = new List<char>();
            var tmp = new List<char>();

            for (var j = 0; j < sortedKvpList.Count; j++)
            {
                if (j == sortedKvpList.Count - 1 || sortedKvpList[j].Value > sortedKvpList[j + 1].Value)
                {
                    if (tmp.Count > 0)
                    {
                        tmp.Add(sortedKvpList[j].Key);
                        checkAgainst.AddRange(tmp.OrderBy(c => c).ToList());
                        tmp.Clear();
                    }
                    else
                    {
                        checkAgainst.Add(sortedKvpList[j].Key);
                    }                    
                }
                else
                {
                    tmp.Add(sortedKvpList[j].Key);
                }
            }

            for (var j = 0; j < 5; j++)
            {
                if (checkAgainst[j] != chksm[j])
                {
                    return 0;
                }
            }

            return value;
        }        
    }
}
