using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ApparentMagnitudeCalculatorTests
{
    [TestMethod]
    public void CalculateApparentMagnitude_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        double distance = 10; // in parsecs
        double intrinsicBrightness = 5; // in watts

        // Act
        double result = ApparentMagnitudeCalculator.CalculateApparentMagnitude(distance, intrinsicBrightness);

        // Assert
        // The expected result can be calculated manually using the formula m = M + 5 * log10(d/10)
        // For the given inputs, the expected result is approximately 8.685.
        Assert.AreEqual(8.685, result, 0.001); // Using delta to account for potential floating-point errors
    }
}
