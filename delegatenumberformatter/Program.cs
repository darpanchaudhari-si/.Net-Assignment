namespace delegatenumberformatter
{
    public delegate string NumberFormatterDelegate(double number);
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberDisplay numberDisplay = new NumberDisplay();
            List<double> numbers = new List<double> { 10.55, 3.8, 0.45, 7.12 };

            //pass the formatcurrency method as a parameter to displaynumbers
            numberDisplay.DisplayNumber(numbers, numberDisplay.Formatcurrency);

            // pass the formatpercentage method as a parameter to diaplayNumbers
            numberDisplay.DisplayNumber(numbers, numberDisplay.FormatPercentage);
        }

    }
    public class NumberDisplay
    {
        public string Formatcurrency(double number)
        {
            return string.Format("${0:0.00}", number);
        }
        public string FormatPercentage(double number)
        {
            return string.Format("{0:0.00}%", number * 100);
        }
        public void DisplayNumber(List<double> numbers, NumberFormatterDelegate formatter)
        {
            foreach (double number in numbers)
            {
                string formatteNumber = formatter(number);
                Console.WriteLine($"Formatted{ formatteNumber}");
            }
        }
    }
}