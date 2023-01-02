namespace WebApplication1.Services
{
    public class RandomCounter : ICounter
    {
        static Random rnd = new Random();

        private int _value;

        public RandomCounter()
        {
            _value = rnd.Next(0, 1000000);
        }


        //ЗДЕСЬ МЫ РЕАЛИЗОВАЛИ ИНТЕРФЕЙС

        public int Value
        {
            get { return _value; }
        }
    }
}
