using System;

namespace logical
{   
    class Logic
    {
        public static void SomeLogic()
        {
            int startingValue = 1;
            int endingValue = 21;
            int value = 0;

            for (int i = startingValue; i < endingValue; i++)
            {
                value = value + i;
            }

            Console.WriteLine("The answer is: " + value.ToString());
        }
    }
}
