using System;

namespace LangBasics
{
    class StringReversor
    {
        private char[] chars;
        public StringReversor(string str)
        {
            this.chars = str.ToCharArray();
        }

        // Reverse the order of items in this objects char array - between start and end positions, in place.
        private void ReverseCharsInRange(int startIdx, int endIdx)
        {
            while (startIdx < endIdx)
            {
                char tmp = chars[startIdx];
                chars[startIdx] = chars[endIdx];
                chars[endIdx] = tmp;
                startIdx++;
                endIdx--;
            }
        }

        // -------------------------------------------------------------------------------------------------------------
        // ----------------------------------------------------------------------------------------------- class exports
        /// <summary> Compute and return the reverse of the sentence with which this object was initialized.
        /// <example>
        /// <br/> "yellow is green plus red"
        /// <br/> becomes
        /// <br/> "red plus green is yellow"
        /// </example>
        /// </summary>
        public string getReverse()
        {
 
            ReverseCharsInRange(startIdx: 0, endIdx: chars.Length-1);

// last_delim_idx = 0

// for i in range(len(a)):
//     if ' ' == a[i]:
//         # found 2nd delim
//         # swap token
//         # save last delim
//         reverse_items(a, last_delim_idx, i-1)
//         last_delim_idx = i+1

// # deal w last token
// reverse_items(a, last_delim_idx, len(a)-1)


            return new string(chars);
        }


    }
}