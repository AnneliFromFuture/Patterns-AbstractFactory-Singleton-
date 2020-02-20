namespace Builder
{
    class CupcakeBuilder : IDessertBuilder
    {
        private Dessert _dessert = new Dessert();

        public CupcakeBuilder()
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
            _dessert.Add("6 cakes");
            return 1;
        }

        public void PutFilling()
        {
            _dessert.Add("banana jam filling");
        }

        public bool NeedSpices()
        {
            _dessert.Add("no spices");
            return false;
        }

        public bool NeedCream()
        {
            _dessert.Add("vanilla cream");
            return false;
        }

        public void SetDecorations()
        {
            _dessert.Add("sprinkle decorations and oreo");
        }

        public void NeedSugarPowder()
        {
            //throw new System.NotImplementedException();
        }
    }
}
