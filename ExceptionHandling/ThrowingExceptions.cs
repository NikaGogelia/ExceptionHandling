﻿using System;

namespace ExceptionHandling
{
    public static class ThrowingExceptions
    {
        public static void CheckParameterAndThrowException(object obj)
        {
            // TODO #6. Replace the method code to throw an "ArgumentNullException" exception if the "obj" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj), "Parameter cannot be null.");
            }
        }

        public static void CheckBothParametersAndThrowException(object obj1, object obj2)
        {
            // TODO #7. Replace the method code to throw an "ArgumentNullException" exception if the "obj1" or "obj2" parameter is null; otherwise return from the method with no actions. Use "nameof" expression to get a parameter name for an exception constructor.
            if (obj1 == null)
            {
                throw new ArgumentNullException(nameof(obj1), "Parameter cannot be null.");
            }

            if (obj2 == null)
            {
                throw new ArgumentNullException(nameof(obj2), "Parameter cannot be null.");
            }
        }

        public static string CheckStringAndThrowException(string str)
        {
            // TODO #8. Replace the method code to throw an "ArgumentNullException" exception if the "str" parameter is null or equals to ""; otherwise return "str" value. Use string.IsNullOrEmpty method. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentNullException(nameof(str), "String cannot be null or empty.");
            }

            return str;
        }

        public static string CheckBothStringsAndThrowException(string str1, string str2)
        {
            // TODO #9. Replace the method code to throw an "ArgumentNullException" exception if the "str1" or "str2" parameter is null or equals to ""; otherwise return a concatenation of "str1" and "str2" strings. Use string.Concat method to concatenate "str1" and "str2" strings. Use "nameof" expression to get a parameter name for an exception constructor.
            if (string.IsNullOrEmpty(str1))
            {
                throw new ArgumentNullException(nameof(str1), "String cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(str2))
            {
                throw new ArgumentNullException(nameof(str2), "String cannot be null or empty.");
            }

            return string.Concat(str1, str2);
        }

        public static int CheckEvenNumberAndThrowException(int evenNumber)
        {
            // TODO #10. Replace the method code to throw an "ArgumentException" exception if a value of the "evenNumber" parameter is not even; otherwise return a "evenNumber" value. Use "nameof" expression to get a parameter name for an exception constructor.
            if (evenNumber % 2 != 0)
            {
                throw new ArgumentException("Parameter must be an even number.", nameof(evenNumber));
            }

            return evenNumber;
        }

        public static int CheckCandidateAgeAndThrowException(int candidateAge, bool isCandidateWoman)
        {
            // TODO #11. Replace the method code to throw an "ArgumentOutOfRange" exception if a value of the "candidateAge" parameter is less than 16 or greater then 63 (for a male candidate) or 58 (for a female candidate); otherwise return "candidateAge" value. Use "nameof" expression to get a parameter name for an exception constructor.
            if (candidateAge < 16 || (isCandidateWoman && candidateAge > 58) || (!isCandidateWoman && candidateAge > 63))
            {
                throw new ArgumentOutOfRangeException(nameof(candidateAge), "Candidate age must be between 16 and 63 (58 for women).");
            }

            return candidateAge;
        }

        public static string GenerateUserCode(int day, int month, string username)
        {
            // TODO #12. Add new code to the method to validate method parameters and throw exceptions in case of validation errors:
            // * Throw "ArgumentOutOfRangeException" exception if "day" parameter is less then 1 or greater then 31.
            // * Throw "ArgumentOutOfRangeException" exception if "month" parameter is less then 1 or greater then 12.
            // * Throw "ArgumentNullException" exception if "username" parameter is null or equals to "".
            // Use "nameof" expression to get a parameter name for an exception constructor.
            if (day < 1 || day > 31)
            {
                throw new ArgumentOutOfRangeException(nameof(day), "Day must be between 1 and 31.");
            }

            if (month < 1 || month > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(month), "Month must be between 1 and 12.");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException(nameof(username), "Username cannot be null or empty.");
            }

            return $"{username}-{day}{month}";
        }
    }
}
