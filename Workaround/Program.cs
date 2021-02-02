using System;
using System.Collections.Generic;
using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "MERVE";
            person1.LastName = "AYDIN";
            person1.DateOfBirthYear = 1996;
            person1.NationalityId = 1235;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
    }
}
