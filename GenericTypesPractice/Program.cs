using System;
using System.Collections.Generic;

namespace GenericTypesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var restaurants = new List<Restaurant>();

            var result = new PaginatedResult<Restaurant>();

            result.Results = restaurants;

            var users = new List<User>();

            //result.Results = users; // compile error

            /////////////////////////////////////////////

            //var stringRepository = new Repository<string>();
            //stringRepository.AddElement("some value");

            //string firstElement = stringRepository.GetElements(0);

            //var intRepository = new Repository<int>();

            /////////////////////////////////////////////

            var userRepository = new Repository<string, User>();
            userRepository.AddElement("Bill", new User() { Name = "Bill"});

            User bill = userRepository.GetElements("Bill");

            //Generics constraints (ograniczenia) line 27
        }
    }
}
