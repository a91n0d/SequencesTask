using System;

namespace SequencesTask
{
    public static class Sequences
    {
        /// <summary>
        /// Find all the contiguous substrings of length length in given string of digits in the order that they appear.
        /// </summary>
        /// <param name="numbers">Source string.</param>
        /// <param name="length">Length of substring.</param>
        /// <returns>All the contiguous substrings of length n in that string in the order that they appear.</returns>
        /// <exception cref="ArgumentException">
        /// Throw if length of substring less and equals zero
        /// -or-
        /// more than length of source string
        /// - or-
        /// source string containing a non-digit character
        /// - or
        /// source string is null or empty or white space.
        /// </exception>
        public static string[] GetSubstrings(string numbers, int length)
        {
            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentException("Source string is null or white space", nameof(numbers));
            }

            if (numbers.Length < length)
            {
                throw new ArgumentException("More than length of source string", nameof(length));
            }

            if (length <= 0)
            {
                throw new ArgumentException("Length of substring less and equals zero", nameof(length));
            }

            int lenArray = numbers.Length - length + 1;
            string[] substrings = new string[lenArray];
            for (int i = 0; i < lenArray; i++)
            {
                if (!char.IsDigit(numbers[i]))
                {
                    throw new ArgumentException("Source string containing a non-digit character", nameof(numbers));
                }

                substrings[i] = numbers[i.. (i + length)];
            }

            return substrings;
        }
    }
}
