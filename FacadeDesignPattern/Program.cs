using System;

namespace FacadeDesignPattern
{
    class Authorize
    {
        public void CheckUser()
        {
            Console.WriteLine("Check user");
        }
    }

    class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cache");
        }
    }

    class Logging
    {
        public void Log()
        {
            Console.WriteLine("Log");
        }
    }

    class CrossCuttingConcerns
    {
        public Authorize Authorize { get; set; }
        public Caching Caching { get; set; }
        public Logging Logging { get; set; }
        public Validation Validation { get; set; }

        public CrossCuttingConcerns(Authorize authorize, Caching caching, Logging logging, Validation validation)
        {
            Authorize = authorize;
            Caching = caching;
            Logging = logging;
            Validation = validation;
        }

        public void UseAll()
        {
            Authorize.CheckUser();
            Caching.Cache();
            Logging.Log();
            Validation.Validate();
        }

        public void DoSomething()
        {
            Console.WriteLine("Do something");
        }
    }

    //Extra 
    class Validation
    {
        public void Validate()
        {
            Console.WriteLine("Validate");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Authorize authorize = new Authorize();
            Caching caching = new Caching();
            Logging logging = new Logging();
            Validation validate = new Validation();

            CrossCuttingConcerns concerns = new CrossCuttingConcerns(authorize, caching, logging, validate);
            concerns.UseAll();
        }
    }
}
