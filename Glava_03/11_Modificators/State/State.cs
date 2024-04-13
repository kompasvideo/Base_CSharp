namespace State
{
    class State
    {
        // все равно, что private string defaultVaar
        string defaultVaar = "default";
        // поле досткпно только из текущего класса
        private string privateVar = "privaate";
        // доступно из текущего класса и производных классов, которые определены в этом же проекте
        protected private string protectedPrivateVar = "protected private";
        // достпно из текущего класса и производных классов
        protected string protectedVar = "protected";
        // доступон в любом месте текущего проекта
        internal string internalVar = "internal";
        // доступно в любом месте текущнго класса и из классов-наследников в других проектах
        protected internal string protectedInternalVat = "protected internal";
        // доступно в любом месте программы, а также для других программ и сборок
        public string publicVar = "public";

        // по умолчанию имеет модификатор private
        void Print() => Console.WriteLine(defaultVaar);

        // метод доступен только из текущего класса
        private void PrintPrivate() => Console.WriteLine(privateVar);

        // доступен из текщего класса и производных классов, которые определены в этом же проекте
        protected private void PrintProtectedPrivate() => Console.WriteLine(protectedPrivateVar);

        // доступен из текущего класса и производных классов
        protected void PrintProtected() => Console.WriteLine(protectedVar);

        // доступен в любом месте текущего проекта
        internal void PrintInternalVat() => Console.WriteLine(internalVar);

        // доступен в любом месте текущего проекта и из классов-наследников в других классах
        protected internal void PrintProtectedInternal() => Console.WriteLine(protectedInternalVat);

        // доступен в любом месте программы, а также для других программ и сборок
        public void PrintPublic() => Console.WriteLine(publicVar);
    }
}
