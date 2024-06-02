namespace _06_05_01_Account
{
    internal class Account
    {
        // сумма на счётк
        public int Sum { get; private set; }
        // в конструктуре устанавливаем начальную сумму на счёте
        public Account(int sum) => Sum = sum;
        // добавление средств на счёт
        public void Put(int sum) => Sum += sum;    
        // списание средств со счёта
        public void Take(int sum)
        {
            if ( Sum >= sum)
            {
                Sum -= sum;
            }
        }
    }
}
