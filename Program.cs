
namespace DelegateTests
{
    class Program
    {
        public delegate void FirstDelegate ();  //объявляем делегат который ничего не принимает и не отдает

        public delegate string StringDelegate(string name1, string name2);

        static void Main()
        {
            FirstDelegate frsDeleg = new(ShowResults); //присваиваем в делегат метод

            StringDelegate strDeleg = new(WriteCurString); //присваиваем в делегат метод

            frsDeleg(); // вызываем делегат

            Console.WriteLine(strDeleg("shit", "говно")); //выводим в консоль вызов делегата

        }

        private static void ShowResults()  //тот самый пустой метод, на который мы будем ссылаться в делегате
        {
            Console.WriteLine("Someeeeee_shit here");
        }

        private static string WriteCurString(string name1 , string name2) //метод вставляет передваваемые значения
        {
            string _value = ($"Hello ,{name1}. I like {name2}");
            return _value;
        }

    }

}

