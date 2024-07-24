using PhoneBookTwo.Models;

namespace PhoneBookTwo.Services
{
    internal interface IFileService
    {
        void AddContact(Contact contact);
        void SearchContact(string name);
        void DeleteContact(string name);
    }
}