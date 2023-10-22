using System;

class ApparentMagnitudeCalculator
{
    static void Main()
    {
        Console.WriteLine("Apparent Magnitude Calculator for Celestial Objects");
        Console.WriteLine("-----------------------------------------------");

        // Get user input for distance and intrinsic brightness
        double distance = GetInput("Enter the distance to the celestial object (in parsecs): ");
        double intrinsicBrightness = GetInput("Enter the intrinsic brightness of the celestial object (in watts): ");

        // Calculate apparent magnitude
        double apparentMagnitude = CalculateApparentMagnitude(distance, intrinsicBrightness);

        // Display the result
        Console.WriteLine($"Apparent Magnitude: {apparentMagnitude:F2}");
    }

    static double GetInput(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        if (double.TryParse(input, out double result))
        {
            return result;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return GetInput(prompt);
        }
    }

    static double CalculateApparentMagnitude(double distance, double intrinsicBrightness)
    {
        // The formula for apparent magnitude is: m = M + 5 * log10(d/10)
        // where m is apparent magnitude, M is intrinsic brightness, and d is distance in parsecs

        const double logBase = 10.0;

        // Convert distance to parsecs
        double distanceInParsecs = distance;

        // Calculate apparent magnitude
        double apparentMagnitude = intrinsicBrightness + 5 * Math.Log10(distanceInParsecs / 10);

        return apparentMagnitude;
    }
}
