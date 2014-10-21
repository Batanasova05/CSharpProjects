using System;




class PrintCompanyInformation
{
    static void Main()
    {
        string company = "Software University";
        string address = " 26 V. Kanchev, Sofia";
        string phone = " +359 898 205 463";
        string website = " www.softuni.bg";
        string firstName = " Svetlin";
        string lastName = " Nakov";
        byte number = 26;
        string tele = " +359 898 258693";

        Console.WriteLine("The company's name is : {0}", company );
        Console.WriteLine("THe company's address is : {0}", address);
        Console.WriteLine("Company's phone number is : {0}", phone);
        Console.WriteLine("Company's websiste is : {0}", website);
        Console.WriteLine("Company's manager is : {0}{1}", firstName, lastName);
        Console.WriteLine("Manager's years are : {0}", number);
        Console.WriteLine("Manager's phone number is: {0}", tele);
    }
}

