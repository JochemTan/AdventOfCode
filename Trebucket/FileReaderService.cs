namespace AdventOfCode;

public class FileReaderService
{

    public static List<string> GetCalibrationValuesFromFile()
    {
        List<string> calibrationValues = new List<string>();

        var lines = File.ReadAllLines($"{Directory.GetCurrentDirectory()}/resources/input.txt");
        foreach (var line in lines)
        {
            calibrationValues.Add(line);
        }
        return calibrationValues;
    }
}