using System.Text;

namespace KleverensSoft
{
    public class Task1
    {
        public static string CompressString(string inputStr)
        {
            var compressed = new StringBuilder();
            int count = 1;

            for (int i = 1; i < inputStr.Length; i++)
            {
                if (inputStr[i] == inputStr[i - 1])
                {
                    count++;
                    continue;
                }


                compressed.Append(inputStr[i - 1]);

                if (count > 1)
                    compressed.Append(count);
                count = 1;
            }

            compressed.Append(inputStr[inputStr.Length - 1]);

            if (count > 1)
                compressed.Append(count);

            return compressed.ToString();
        }

        public static string DecompressString(string compressedStr)
        {
            var decompressed = new StringBuilder();

            int i = 0;

            while (i < compressedStr.Length)
            {
                char currentChar = compressedStr[i++];

                int count = 0;

                if (i < compressedStr.Length && char.IsDigit(compressedStr[i]))
                    count = Convert.ToInt32(compressedStr[i++].ToString());
                
                decompressed.Append(new string(currentChar, Math.Max(1, count)));
            }

            return decompressed.ToString();
        }
    }
}
