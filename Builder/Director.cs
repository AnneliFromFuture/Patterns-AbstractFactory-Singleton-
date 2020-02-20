namespace Builder
{
    class Director
    {
        private IDessertBuilder _builder;

        public IDessertBuilder Builder
        {
            set => _builder = value;
        }

        public void MakeCupcakes()
        {
            _builder.SetCakes();
            _builder.PutFilling();
            _builder.NeedCream();
            _builder.SetDecorations();
        }

        public void MakeApplePie()
        {
            _builder.SetCakes();
            _builder.PutFilling();
            _builder.NeedSpices();
            _builder.NeedCream();
            _builder.NeedSugarPowder();
        }

        public void MakeWeddingCake()
        {
            _builder.SetCakes();
            _builder.PutFilling();
            _builder.NeedSpices();
            _builder.NeedCream();
            _builder.SetDecorations();
        }
    }
}
