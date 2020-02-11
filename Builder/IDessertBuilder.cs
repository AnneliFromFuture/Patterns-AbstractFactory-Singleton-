namespace Builder
{
    public interface IDessertBuilder
    {
        int SetCakes();

        void PutFilling();

        bool NeedSpices();

        bool NeedCream();
        
        void SetDecorations();
    }
}
