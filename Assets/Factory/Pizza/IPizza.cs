namespace Factory.Pizza
{
    public interface IPizza
    {
        void Prepare();
        void Bake();
        void Cut();
        void Pack();
    }
}