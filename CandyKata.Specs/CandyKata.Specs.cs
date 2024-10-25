using Machine.Specifications;

namespace CandyKata.Specs
{
    public class When_Determining_How_Much_Candy_For_Each_Kid
    {
        Establish context = () =>
        {
            inputs = new List<int[]>
            {
                new int[] { 1, 0, 2 },
                new int[]{1,3,2,5,4,3},
                new int[]{1,3,1,3,1,3 },
                new int[]{1,2,87,87,87,2,1},
                new int[]{ 1, 3, 4, 5, 2 },

            };
            expectations = new List<int[]>
            {
                new int[] { 2,1,2 },
                new int[]{1,2,1,3,2,1},
                new int[]{1,2,1,2,1,2},
                new int[]{1,2,3,1,3,2,1},
                new int[]{1,2,3,4,1},
            };
            candy = new List<int[]>();
        };

        Because of = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                candy.Add(CandySoulCrusher.GiveCandy(inputs[i]));
            }
        };

        It Should_Give_Each_Kid_At_Least_One_Piece = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                for(var j=0; j<inputs[i].Length; j++)
                {
                    candy[i].Where(c => c > 0).Count().ShouldEqual(inputs[i].Length);
                }
            }
        };
        It Should_Give_More_To_Higher_Ranked_Kids = () =>
        {
            for (var i = 0; i < expectations.Count; i++)
            {
                for(var j=0; j < expectations[i].Length; j++)
                    candy[i][j].ShouldEqual(expectations[i][j]);
            }
        };

        private static List<int[]> inputs;
        private static List<int[]> expectations;
        private static List<int[]> candy;
    }

    public class When_Determining_How_Much_Candy_In_Total
    {
        Establish context = () =>
        {
            inputs = new List<int[]>
            {
                new int[] { 1, 0, 2 },
                new int[]{1,3,2,5,4,3},
                new int[]{1,3,1,3,1,3 },
                new int[]{1,2,87,87,87,2,1},
                new int[]{ 1, 3, 4, 5, 2 },

            };
            expectations = new List<int>
            {
                5,10,9,13,11
            };
            candy = new List<int>();
        };

        Because of = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                candy.Add(CandySoulCrusher.Candy(inputs[i]));
            }
        };

        It Should_Give_Each_Kid_At_Least_One_Piece = () =>
        {
            for (var i = 0; i < inputs.Count; i++)
            {
                candy[i].ShouldEqual(expectations[i]);
            }
        };

        private static List<int[]> inputs;
        private static List<int> expectations;
        private static List<int> candy;
    };
}