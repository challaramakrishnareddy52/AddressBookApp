﻿using System;

namespace AddressBookApp
{
    internal class AddressBook
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();
            contact.WelcomeMessage();
        ReEnteringApp:
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to Edit/Modify any existing contact\n" +
                "Press 3 : to view all the contacts in Address Book");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();
                    break;
                case 2:
                    contact.ListPeople();
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;
        }
    }
}