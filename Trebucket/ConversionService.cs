using System.Text.RegularExpressions;

namespace AdventOfCode;

public class ConversionService
{
    /// <summary>
    /// Get the first and last digit in the string and combine them
    /// </summary>
    public static int CombineDigitsInCalibrationValue(int firstCalibrationValue, int secondCalibrationValue)
    {
        var combinedDigit = string.Concat(firstCalibrationValue.ToString(), secondCalibrationValue.ToString());
        return int.Parse(combinedDigit);
    }

    public static List<int> GetDigitsFromCalibrationValue(string calibrationValue)
    {
        List<int> CalibrationDigits = new List<int>();
        string pattern = @"\d";
        var matches = Regex.Matches(calibrationValue, pattern);
        int count = 0;
        foreach (Match match in matches)
        {
            if (count == 0 || count == matches.Count - 1)
                CalibrationDigits.Add(Int32.Parse(match.Value));
            count++;
        }

        return CalibrationDigits;
    }

    public static string WordToNumber(string calibrationValue)
    {
        Dictionary<string, int> conversionTable = new Dictionary<string, int>()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };
        // find word from dictionary in the list


        calibrationValue = calibrationValue.ToLower();
        foreach (var kvp in conversionTable)
        {
            var countAppearsInString = Regex.Matches(calibrationValue, kvp.Key).Count;

            if(calibrationValue.Contains(kvp.Key))
            {
                for (int i = 0; i < countAppearsInString; i++)
                {
                    calibrationValue = ConvertCalibrationValueWordsToNumber(calibrationValue, kvp);
                }
            }
        }
        // try to convert Word to Number
        return calibrationValue;
    }

    private static string ConvertCalibrationValueWordsToNumber(string calibrationValue, KeyValuePair<string, int> kvp)
    {
        var firstIndex = calibrationValue.IndexOf(kvp.Key, StringComparison.Ordinal);
        var replaceWordWithNumber =
            calibrationValue.Remove(firstIndex, kvp.Key.Length)
                .Insert(firstIndex, kvp.Value.ToString());
        calibrationValue = replaceWordWithNumber;
        return calibrationValue;
    }
}