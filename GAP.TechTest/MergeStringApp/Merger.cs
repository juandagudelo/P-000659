using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeStringsApp
{
    public class Merger
    {
        #region Properties
        private List<char> _charsStringOneList;

        public List<char> CharsStringOneList
        {
            get { return _charsStringOneList; }
            set { _charsStringOneList = value; }
        }

        private List<char> _charsStringTwoList;

        public List<char> CharsStringTwoList
        {
            get { return _charsStringTwoList; }
            set { _charsStringTwoList = value; }
        }

        #endregion


        #region Methods

        public List<char> SetCharsStringList()
        {
            string input = Console.ReadLine();
            List<char> result = new List<char>();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("String is null or empty.");
            }
            else
            {
                result = input.ToCharArray().ToList();
            }
            return result;
        }


        public int CalculateMaxLengthOfArrays()
        {
            int maxLength = 0;
            if (CharsStringOneList.Count >= CharsStringTwoList.Count)
            {
                maxLength = CharsStringOneList.Count;
            }
            else
            {
                maxLength = CharsStringTwoList.Count;
            }

            return maxLength;

        }


        public void MergedStrings()
        {
            int maxLength = CalculateMaxLengthOfArrays();

            List<char> mergedCharList = new List<char>();

            for (int index = 0; index < maxLength; index++)
            {
                if (CharsStringOneList.Count > index)
                {
                    mergedCharList.Add(CharsStringOneList[index]);
                }

                if (CharsStringTwoList.Count > index)
                {
                    mergedCharList.Add(CharsStringTwoList[index]);
                }

            }

            Console.WriteLine(string.Join(string.Empty, mergedCharList));
        }
        #endregion

    }
}
