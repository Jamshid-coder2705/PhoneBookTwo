using PhoneBookTwo.Models;
using PhoneBookTwo.Services;

namespace PhoneBookTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" --- Tel Kitobcha --- ");
            IFileService fileService = new FileService();
            Contact contact = new Contact();

            Console.WriteLine(" 1- Yaratish\n 2- Qidiruv\n 3- O'chirish");
            int selection = int.Parse(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    {
                        Console.Write(" Ism: ");
                        contact.Name = Console.ReadLine();
                        Console.Write(" Tel raqam: ");
                        contact.PhoneNum = Console.ReadLine();
                        fileService.AddContact(contact);
                        break;
                    }
                case 2:
                    {
                        Console.Write(" Ism: ");
                        contact.Name = Console.ReadLine();
                        fileService.SearchContact(contact.Name);
                        break;
                    }
                case 3:
                    {
                        Console.Write(" Ism: ");
                        contact.Name = Console.ReadLine();
                        fileService.DeleteContact(contact.Name);
                        break;
            
                    }
            }
            

            
        }
    }
}
