using System;
using System.Linq;
using System.Collections.Generic;


namespace SoftUniCSharpLists
{
    class CardsGame
    {
        static void Main()
        {
            List<int>deckOne = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int>deckTwo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (deckOne.Count > 0 && deckTwo.Count > 0)
            {
                int cardOne = deckOne[0];
                int cardTwo = deckTwo[0];
                deckOne.RemoveAt(0);
                deckTwo.RemoveAt(0);
                if (cardOne > cardTwo)
                {
                    deckOne.Add(cardTwo);
                    deckOne.Add(cardOne);
                }
                else if (cardTwo > cardOne)
                {
                    deckTwo.Add(cardOne);
                    deckTwo.Add(cardTwo);
                }
            }

                if (deckOne.Count() != 0)
                {
                    for (int i = 0; i < deckOne.Count(); i++)
                    {
                        sum += deckOne[i];
                    }
                    Console.WriteLine($"First player wins! Sum: {sum}");
                }
                else
                {
                    for (int i = 0; i < deckTwo.Count(); i++)
                    {
                        sum += deckTwo[i];
                    }
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                }
            
        }
    }
}
