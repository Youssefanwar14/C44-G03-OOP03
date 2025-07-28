using OOP_03.Inheritance;

namespace OOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PhoneBook phoneBook = new PhoneBook(3);
            //phoneBook.AddPerson("Ahmed", 01015412157, 0);
            //phoneBook.AddPerson("alaa", 01015412152, 1);
            //phoneBook.AddPerson("amr", 001015412154, 2);

            ////Console.WriteLine(phoneBook.GetNumber("amr"));
            ////Console.WriteLine(phoneBook["alaa"]);
            //phoneBook["alaa"] = 123456;
            //Console.WriteLine(phoneBook[0]);

            //Console.WriteLine(phoneBook["alaa"]);

            //Car car = new Car(10,"Kia",120);


            Child child = new Child(10,20,30);
            Console.WriteLine(child.product());
        }
    }
}
