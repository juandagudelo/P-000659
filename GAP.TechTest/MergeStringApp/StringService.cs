using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeStringsApp
{
    public class StringService
    {
        #region Properties
        public List<List<char>> StringCharList { get; set; }
        #endregion

        public StringService()
        {
            StringCharList = new List<List<char>>();
        }

        #region Methods
        public void SaveStringAsCharList(string input)
        {
            StringCharList.Add(input.ToCharArray().ToList());
        }

        public void MergeStrings()
        {
            int maxLengthOfString = CalculateMaxLengthOfString();
            List<char> mergedCharList = new List<char>();

            for (int index = 0; index < maxLengthOfString; index++)
            {
                for (int indexString = 0; indexString < StringCharList.Count; indexString++)
                {
                    AddCharToResultList(mergedCharList, index, StringCharList[indexString]);
                }
            }

            Console.WriteLine(string.Join(string.Empty, mergedCharList));
        }

        private void AddCharToResultList(List<char> mergedCharList, int index, List<char> charList)
        {
            if (charList.Count > index)
            {
                mergedCharList.Add(charList[index]);
            }
        }

        private int CalculateMaxLengthOfString()
        {
            int result = StringCharList.First().Count;
            StringCharList.ForEach((items) => {
                if (items.Count > result)
                {
                    result = items.Count;
                }
            });
            return result;
        }
        #endregion

    }
}
