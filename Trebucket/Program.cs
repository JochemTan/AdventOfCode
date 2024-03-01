// See https://aka.ms/new-console-template for more information

using AdventOfCode;

Console.WriteLine("Hello world" );

var calibrationValues = FileReaderService.GetCalibrationValuesFromFile();

var calibrationSum = 0;

// foreach (var calibrationValue in calibrationValues)
// {
//     var convertedCalibrationValueToNumbers = ConversionService.WordToNumber(calibrationValue);
//
//     var firstAndLastDigitFromCalibrationValue = ConversionService.GetDigitsFromCalibrationValue(convertedCalibrationValueToNumbers);
//
//     var combinedValue = ConversionService.CombineDigitsInCalibrationValue(
//         firstAndLastDigitFromCalibrationValue.First(),
//         firstAndLastDigitFromCalibrationValue.Last()
//     );
//
//     calibrationSum += combinedValue;
//
// }

var convertedCalibrationValueToNumbers = ConversionService.WordToNumber("eightwothree");

Console.WriteLine(calibrationSum);




