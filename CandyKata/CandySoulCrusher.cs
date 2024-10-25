using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyKata
{
    public class CandySoulCrusher
    {
        public static int Candy(int[] ratings)
        {
            var candies = ratings.Select(r => 1).ToArray();
            for (var i = 1; i < ratings.Length; i++)
            {
                if (ratings[i - 1] < ratings[i])
                {
                    candies[i] = candies[i - 1] + 1;
                }
                else candies[i] = 1;
            }
            for (var i = ratings.Length - 1; i > 0; i--)
            {
                if (ratings[i] < ratings[i - 1])
                {
                    candies[i - 1] = Math.Max(candies[i] + 1, candies[i - 1]);
                }
            }
            return candies.Sum();
        }

        public static int[] GiveCandy(int[] ratings)
        {
            var candies = ratings.Select(r => 1).ToArray();
            for(var i=1; i<ratings.Length; i++)
            {
                if (ratings[i - 1] < ratings[i])
                {
                    candies[i] = candies[i - 1] + 1;
                }
                else candies[i] = 1;
            }
            for(var i=ratings.Length-1; i>0 ; i--)
            {
                if (ratings[i] < ratings[i-1])
                {
                    candies[i-1] = Math.Max(candies[i] + 1, candies[i-1]);
                }
            }
            return candies;
        }
    }
}
