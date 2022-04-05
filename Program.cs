
namespace DelegateTests
{
    class Program
    {
        public delegate void FirstDelegate ();  //объявляем делегат который ничего не принимает и не отдает

        public delegate string StringDelegate(string name1, string name2);

        static void Main()
        {
            FirstDelegate frsDeleg = new(ShowResults); //присваиваем в делегат метод

            StringDelegate strDeleg = new(WriteCurString);

            frsDeleg(); // вызываем делегат

            strDeleg("first", "second");

            // Console.Write(_value);

        }

        private static void ShowResults()  //тот самый пустой метод, на который мы будем ссылаться в делегате
        {
            Console.WriteLine("Someeeeee_shit here");
        }

        private static string WriteCurString(string name1 , string name2)
        {
            Console.Write($"Hello ,{name1}. I like {name2}");
            return null;
        }

    }

}

