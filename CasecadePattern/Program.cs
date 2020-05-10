using System;

//This is taken from Venkat Subramaniam blog
//  http://blog.agiledeveloper.com/2012/01/collections-of-presentation-videos.html
namespace CasecadePattern
{
    class Program
    {
        private static void Main(string[] args)
        {
            Mailer.Send((mailer) =>
                mailer.To("test-in@flsmidth.com")
                    .From("brb-in@flsmidth.com")
                    .Subject("Subject")
                    .Body("body")
                );

            // This is much better.

            Console.Read();
        }
    }

    class Mailer
    {
        public Mailer To(string address)
        {
            Console.WriteLine("To :{0}", address);
            return this;
        }

        public Mailer From(string address)
        {
            Console.WriteLine("From :{0}", address);
            return this;
        }

        public Mailer Subject(string message)
        {
            Console.WriteLine("Subject :{0}", message);
            return this;
        }

        public Mailer Body(string message)
        {
            Console.WriteLine("Body :{0}", message);
            return this;
        }

        /// <summary>
        /// Sends the specified action.
        /// </summary>
        /// <param name="action">The action.</param>
        public static void Send(Action<Mailer> action)
        {
            Mailer mailer = new Mailer();
            action(mailer);
            Console.WriteLine("Sending.... Completed");
        }
    }

    /* using System;

namespace CasecadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mailer mailer = new Mailer();
            mailer.To("test-in@flsmidth.com");
            mailer.From("brb-in@flsmidth.com");
            mailer.Subject("Subject");
            mailer.Body("body");
            mailer.Send(); 
            // This is not good you hav eto write these may steps using the same objects.


            Console.Read();
        }
    }

    class Mailer
    {
        public void To(string address)
        {
            Console.WriteLine("To :{0}", address);
        }

        public void From(string address)
        {
            Console.WriteLine("From :{0}", address);
        }

        public void Subject(string message)
        {
            Console.WriteLine("Subject :{0}", message);
        }

        public void Body(string message)
        {
            Console.WriteLine("Body :{0}", message);
        }

        public void Send()
        {
            Console.WriteLine("Sending.... Completed");
        }
    }


Here I am optimizing my code.

using System;

namespace CasecadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            new Mailer()
                .To("test-in@flsmidth.com")
                .From("brb-in@flsmidth.com")
                .Subject("Subject")
                .Body("body")
                .Send(); 
            // This is better.


            Console.Read();
        }
    }

    class Mailer
    {
        public Mailer To(string address)
        {
            Console.WriteLine("To :{0}", address);
            return this;
        }

        public Mailer From(string address)
        {
            Console.WriteLine("From :{0}", address);
            return this;
        }

        public Mailer Subject(string message)
        {
            Console.WriteLine("Subject :{0}", message);
            return this;
        }

        public Mailer Body(string message)
        {
            Console.WriteLine("Body :{0}", message);
            return this;
        }

        public void Send()
        {
            Console.WriteLine("Sending.... Completed");
        }
    }
}
*/
}
