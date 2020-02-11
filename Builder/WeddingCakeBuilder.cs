namespace Builder
{
    class WeddingCakeBuilder : IDessertBuilder
    {
        private Dessert _dessert = new Dessert();

        public WeddingCakeBuilder()
        {
            Reset();
        }

        public Dessert GetDessert()
        {
            var result = _dessert;
            Reset();
            return result;
        }

        public void Reset()
        {
            _dessert = new Dessert();
        }

        public int SetCakes()
        {
            _dessert.Add("4 cakes");
            return 4;
        }

        public void PutFilling()
        {
            _dessert.Add("wild berries jam filling");
        }

        public bool NeedSpices()
        {
            _dessert.Add("no spices");
            return false;
        }

        public bool NeedCream()
        {
            _dessert.Add("praline cream and vanilla cream");
            return false;
        }

        public void SetDecorations()
        {
            _dessert.Add("flower decorations");
        }
    }
}
