namespace Builder
{
    class ApplePieBuilder : IDessertBuilder
    {
        private Dessert _dessert = new Dessert();

        public ApplePieBuilder()
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
            _dessert.Add("1 cake");
            return 1;
        }

        public void PutFilling()
        {
            _dessert.Add("apple jam filling");
        }

        public bool NeedSpices()
        {
            _dessert.Add("cinnamon and gingers spices");
            return false;
        }

        public bool NeedCream()
        {
            _dessert.Add("no cream");
            return false;
        }

        public void SetDecorations()
        {
            _dessert.Add("no decorations");
        }
    }
}
