using System;

namespace classtest
{
    enum PenColor //The value corresponds to a ConsoleColor value so it can be translated onto that Enum
    {
        Red = 12,
        Black = 0,
        Green = 10,
        Yellow = 14,
        Blue = 9,
        Magenta = 13,
        White = 15,
        Gray = 7
    }

    class Pen
    {
        public string Name { get; set; }
        public PenColor Color { get; set; }

        public Pen(string name, PenColor color)
        {
            this.Name = name;
            this.Color = color;
        }

        public override string ToString()
        {
            return string.Format("I am a {0} pen called {1}.",this.Color, this.Name);
        }

        public void printInfo()
        {
            Console.Write("I am a ");
            Console.ForegroundColor = (System.ConsoleColor)Color;
            Console.Write(Color);
            Console.ResetColor();
            Console.Write(string.Format(" pen called {0}.\n",this.Name));
        }

        public void changeColor(PenColor color)
        {
            this.Color = color;
        }
    }

    class Engine
    {
        public int torque;
        public int rpm;
        public int maxRpm;
        public int fuel;
        public bool on;
        public void start()
        {
            this.on = true;
        }
        public void stop()
        {
            this.on = false;
        }
        public void displayStats()
        {
            Console.WriteLine("RPM: {0}/{1} FUEL: {2} TORQUE: {3} ENGINE ON: {4}",this.rpm,this.maxRpm,this.fuel,this.torque, this.on);
        }
    }

    class V6 : Engine
    {
        public V6(int mrpm, int f, int t)
        {
            this.maxRpm = mrpm;
            this.fuel = f;
            this.torque = t;
        }

    }

    struct Book
    {
        public string title;
        public string author;
        public string subject;
        public string book_id;
    }

    struct Person
    {
        private string name;
        private int age;
        public void setValues(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
        public void printBio()
        {
            Console.WriteLine("Name: {0} Age: {1}", this.name, this.age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pen pen1 = new Pen("Pen One", PenColor.Magenta);
            Pen pen2 = new Pen("Pen Two", PenColor.Yellow);
            Pen pen3 = new Pen("Pen Three", PenColor.Red);
           
            Book BookA;
            Book BookB;
            Person Branson = new Person();
            Branson.setValues("Branson",19);
            Branson.printBio();
            Person Jason = Branson;
            Jason.setValues("Jason", 22);
            Branson.printBio();
            Jason.printBio();

            BookA.title = "Bilbo Saggins";
            BookA.subject = "Hobbit feet";
            BookA.author = "Some boi";

            BookB.title = "How to die efficiently";
            BookB.subject = "Death";
            BookB.author = "geege";
            pen1.printInfo();
            pen2.printInfo();
            pen3.printInfo();
            
            pen1.changeColor(PenColor.Green);
      
            pen1.printInfo();

            Console.WriteLine("I bought {0} by {1} today!", BookA.title, BookA.author);
            Console.WriteLine("I bought {0} by {1} today!", BookB.title, BookB.author);

            V6 Engine = new V6(280,5000,180);
            Engine.start();
            Engine.displayStats();
            Engine.stop();
            Engine.displayStats();

        }
    }

}
