using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UC13ReadWrite
{

    public class FileOperation
    {

        public static void ReadFromStreamReader()
        {
            String path = "C:\\Users\\venky\\source\\repos\\Address Book System\\UC13ReadWrite\\AddressBook.txt";//"E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\AddreddBook.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamReader sr = File.OpenText(path))
                    {
                        String s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                        }
                    }
                }
                else
                {
                    throw new AddressBookException(AddressBookException.ExceptionType.FILE_NOT_EXIST, "File Not Exists");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static void WriteUsingStreamWriter()
        {
            String path = "C:\\Users\\venky\\source\\repos\\Address Book System\\UC13ReadWrite\\AddressBook.txt";// "E:\\AddressBook\\AddressBookSystem\\AddressBookSystem\\AddressBookSystem\\AddreddBook.txt";
            try
            {
                if (File.Exists(path))
                {
                    using (StreamWriter sr = File.AppendText(path))
                    {
                        Console.WriteLine("Book Name");
                        sr.Write("Book Name  : ");
                        string bookName = Console.ReadLine();
                        sr.WriteLine(bookName);
                        Console.WriteLine("Enter First Name");
                        sr.Write("First Name  : ");
                        string name = Console.ReadLine();
                        sr.WriteLine(name);
                        Console.WriteLine("Enter Last Name");
                        sr.Write("Last Name  : ");
                        string lname = Console.ReadLine();
                        sr.WriteLine(lname);
                        Console.WriteLine("Enter Address");
                        sr.Write("Address :");
                        string address = Console.ReadLine();
                        sr.WriteLine(address);
                        Console.WriteLine("Enter City Name:");
                        sr.Write("City :");
                        string city = Console.ReadLine();
                        sr.WriteLine(city);
                        Console.WriteLine("Enter State Name:");
                        sr.Write("State :");
                        string state = Console.ReadLine();
                        sr.WriteLine(state);
                        Console.WriteLine("Enter pin Number:");
                        sr.Write("Pin :");
                        string zip = Console.ReadLine();
                        sr.WriteLine(zip);
                        Console.WriteLine("Enter Phone Number:");
                        sr.Write("Phon num :");
                        string phone_number = Console.ReadLine();
                        sr.WriteLine(phone_number);
                        Console.WriteLine("Enter Email:");
                        sr.Write("Email :");
                        string email = Console.ReadLine();
                        sr.WriteLine(email);

                        sr.Close();
                        Console.WriteLine(File.ReadAllText(path));
                    }
                }

                else
                {
                    throw new AddressBookException(AddressBookException.ExceptionType.FILE_NOT_EXIST, "File Not Exists");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
