using System.Linq;

namespace lab1_cs
{
    public static class ContentFunc
    {
        public static (string, int) DeleteOneSymbWords(string content)
        {
            string newContent = "";
            char[] delims = new char[] { ',', ' ', '.', '\n' };
            for (int index = 0; index < content.Length; index++)
            {
                bool isLetter = char.IsLetter(content[index]);
                if (isLetter)
                {
                    if (index == 0 && !delims.Contains(content[index + 1]))
                    {
                        newContent += content[index];
                    }
                    else if (index == content.Length - 1 && !delims.Contains(content[index - 1]))
                    {
                        newContent += content[index];
                    }
                    else if (index > 0 && index < content.Length - 1 &&
                             (!delims.Contains(content[index + 1]) || !delims.Contains(content[index - 1])))
                    {
                        newContent += content[index];
                    }
                }
                else
                    newContent += content[index];
            }

            return (newContent, content.Length - newContent.Length);
        }

        public static (string, int) DeleteDuplDelims(string content, char delim)
        {
            int startLen = content.Length;
            foreach (var symb in content)
            {
                string dupl = symb.ToString() + symb.ToString();
                while (symb == delim && content.Contains(dupl))
                {
                    content = content.Replace(dupl, symb.ToString());
                }
            }
            return (content, startLen - content.Length);
        }
    }
}