namespace web
{
     class Program
    {
        public static void Main()
        {
            Foo();
        }
        void Foo(string a)
        {
            Console.WriteLine("Object");
        }
        static void Foo(params object[] args)
        {
            Console.WriteLine("parms Objeckt");
        }

    }
}
