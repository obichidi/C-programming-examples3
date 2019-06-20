using System;
using System.Collections.Generic;
using System.Linq;
namespace lesson8HandsOn
{
    public interface Mammal: Animal
    {
        void speak();
        void run();
    }

      public class Dog : Mammal 
    {
        string sound;
        int speed;
        string food;

       
        public Dog(string sound, int speed, string food)
        {
         this.sound =sound;
         this.speed = speed;
         this.food = food;
        }

        public void run()
        {
           
           Console.WriteLine("Dogs can run at a top speed of " + this.speed + " mph!");

         
        }

        public void speak()
        {
             Console.WriteLine(this.sound + "!");
            
        }
        public void Eat()
        {
           Console.WriteLine("Dogs eat " + this.food + "."); 
        }
        public interface Animal
        {
            void Eat();
        }

        
    }
   
    public class Cat : Mammal
    {
       string sound;
        int speed;
        string food;
        public Cat( string sound, int speed, string food)
        {
            this.sound =sound;
            this.speed = speed;
            this.food = food;
        }

        public void run()
        {
           Console.WriteLine("Cats can run at a top speed of " + this.speed + " mph!");
        }

        public void speak()
        {
           Console.WriteLine(this.sound + "!");
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat " + this.food + ".");
        }

       
    }
        public class Cow : Mammal
    { 
        string sound;
        int speed;
        string food;

        


        public Cow(string sound, int speed, string food)
        {
            this.sound = sound;
            this.speed = speed;
            this.food = food;
        }

        public void run()
        {
           Console.WriteLine("Cows can run at a top speed of " + this.speed + " mph!");
        }

        public void speak()
        {
           Console.WriteLine(this.sound + "!");
        }

        public void Eat()
        {
            Console.WriteLine("Cows eat " + this.food + ".");
        }
    


    
        static void Main()
        {
            Dog doggie = new Dog("Bark",  45, "bones");
                doggie.speak();
                doggie.run();
                doggie.Eat();

            Cat kitty = new Cat("Meow",30, "mice" );
                kitty.speak();
                kitty.run();
                kitty.Eat();

             Cow cowcow = new Cow("Moo", 25 , "grass"); 
                 cowcow.speak();
                 cowcow.run();  
                 cowcow.Eat();   
        }
}
}

