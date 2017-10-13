namespace WorldsGreatestTDD
{
    public class Fraction
    {
        public readonly int Nominator;
        public readonly int Denominator;

        public Fraction(int nominator, int denominator = 1)
        {
            Nominator = nominator;
            Denominator = denominator;
        }

        public Fraction Multiply(Fraction operand)
        {
            return new Fraction(Nominator * operand.Nominator, Denominator * operand.Denominator);
        }
    }
}
