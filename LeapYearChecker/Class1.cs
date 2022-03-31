namespace LeapYearKata
{
    public static class LeapYearChecker
    {
        public static bool IsLeapYear(int inputYear)
        {
            return IsDivisibleBy400Or4ButNotBy100(inputYear);
        }

        private static bool IsDivisibleBy400Or4ButNotBy100(int inputYear)
        {
            return inputYear % 400 == 0 || (inputYear % 4 == 0 && inputYear % 100 != 0);
        }
    }
}
