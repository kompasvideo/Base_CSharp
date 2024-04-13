namespace State
{
    class StateConsumer
    {
        public void PrintState()
        {
            State state = new State();

            // обратиться к перемеенной defaultVar у нас не получиться,
            // так как она имеет модификатор private и класс StateConsumer её не видит
            Console.WriteLine(state.defaultVaar); // Ошибка, получить доступ нельзя

        }
    }
}
