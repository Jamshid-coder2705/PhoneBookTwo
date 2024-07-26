using PhoneBookTwo.Models;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.VisualBasic;

namespace PhoneBookTwo.Services
{
    internal class FileService : IFileService
    {
        private const string filePath = "../../../PhoneBook.json";
        public FileService()
        {
            EnsureFileExist();
        }
        private static void EnsureFileExist()
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); 
            }
        }
        public void AddContact(Contact contact)
        {
            List<Contact> contacts = new List<Contact>();
            string newContact = JsonConvert.SerializeObject(contact, Formatting.Indented);
            //string newContact = $"{contact.Name}: {contact.PhoneNum} ";
            File.AppendAllText(filePath, newContact );
            Console.WriteLine("Kontakt JSON formatda PhoneBook.json fayliga saqlandi.");

        }

        public void DeleteContact(string name)
        {
            string[] contacts = File.ReadAllLines(filePath);
            string newContactAfterDeleting = "";
            
            foreach (string item in contacts)
            {
                string splitName = item.Split(":")[0];
                if (!name.ToUpper().Equals(splitName.ToUpper()) )
                {
                    newContactAfterDeleting += item + "\n";
                }
            }
            File.Delete(filePath);
            EnsureFileExist();
            File.WriteAllText(filePath, newContactAfterDeleting);
        }



        public void SearchContact(string name)
        {
            string[] contacts = File.ReadAllLines(filePath);
            foreach (string item in contacts)
            {
                string splitName = item.Split(":")[0];
                if (splitName.ToUpper() == name.ToUpper())
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
