using System.Text;

public class Solution
{
    public string RestoreString(string s, int[] indices)
    {
        // To construct a new string based on the original string
        StringBuilder sb = new StringBuilder(new string(' ', s.Length));
        if (s.Length == indices.Length)
        {
            for (int i = 0; i < indices.Length; i++)
            {
                var index = indices[i];
                if (index <= sb.Length)
                {
                    sb.Remove(indices[i], 1);
                    sb.Insert(indices[i], s[i]);
                }
            }
            Console.WriteLine("updates s string: ", sb.ToString());
        }
        return sb.ToString();
    }
}