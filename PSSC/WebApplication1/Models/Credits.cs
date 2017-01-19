using Models.Generics.Exceptions;
namespace Models.Generics
{
    public class Credits
    {
        private const int _maxCredits = 60;
        public static int MAX { get { return _maxCredits; } }

        private int _credits;
        public int Count { get { return _credits; } set { _credits = value; } }

        public Credits()
        {
        }

        public Credits(int credits)
        {

            if(_credits < 0 || _credits > _maxCredits)
                throw new InvalidCreditsValue("Illegal");
            _credits = credits;
        }
        public override bool Equals(object obj)
        {
            return this._credits.Equals((obj as Credits).Count);
        }
        public override string ToString()
        {
            return "Numarul de credite este: " + _credits;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
