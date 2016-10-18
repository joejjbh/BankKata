﻿using System.Collections.Generic;
using System.Linq;

namespace BankKata.Library
{
    public class Digit
    {
        

        private static readonly Dictionary<string, int> digitValue = new Dictionary<string, int>()
        {
            {"     |  |   ", 1},
            {" _  _||_    ", 2},
            {" _  _| _|   ", 3},
            {"   |_|  |   ", 4},
            {" _ |_  _|   ", 5},
            {" _ |_ | |   ", 6},
            {" _   |  |   ", 7},
            {" _ |_||_|   ", 8},
            {" _ |_| _|   ", 9},
            {" _ | | _    ", 0},

          };

        public int GetDigitValue(string digitAsString)
        {
            return digitValue[digitAsString];
        }

        public int DigitValue { get; internal set; }

        private readonly List<string> _individualDigits = new List<string>();

        public List<string> SeparateIntoSubstrings(string firstLineDigits)
        {
            var stringDigits = Split(firstLineDigits, 3);
            foreach (var individualDigitAsString in stringDigits)
            {
                _individualDigits.Add(individualDigitAsString);
            }
            return _individualDigits;
        }

        static IEnumerable<string> Split(string str, int chunkSize)
        {
            return Enumerable.Range(0, str.Length / chunkSize)
                .Select(i => str.Substring(i * chunkSize, chunkSize));
        }
    }
}
