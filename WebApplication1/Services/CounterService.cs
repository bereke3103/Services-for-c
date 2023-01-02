namespace WebApplication1.Services
{

    //Данный класс просто устанавливает объект ICounter, передаваемый через конструктор
    public class CounterService
    {
        protected internal ICounter Counter { get; }

        public CounterService(ICounter counter)
        {
            Counter = counter;
        }
    }
}
