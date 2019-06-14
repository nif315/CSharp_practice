using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weight_for_weight
{
    class Program
    {
        public static string orderWeight(string strng)
        {
            int i = 0;
            int sum = 0;
            var temp = 0;
            List<string> weights = strng.Split(' ').ToList();
            List<int> sums = new List<int>();
            while (i < weights.Count)
            {
                sum = weights[i].Select(x => int.Parse(x.ToString())).Sum();
                sums.Add(sum);
                sum = 0;
                i++;
            }
            var result = sums.OrderBy(x => x).ToList();
            for (int j = 0; j < weights.Count; j++)
            {
                for (int k = 0; k < result.Count; k++)
                {
                    int compare = weights[j].CompareTo(weights[k]);
                    if (weights[j].Select(x => int.Parse(x.ToString())).Sum() == result[k])
                    {
                        temp = int.Parse(weights[j]);
                        weights[j] = weights[k];
                        weights[k] = temp.ToString();

                    }
                    if (weights[j].Select(x => int.Parse(x.ToString())).Sum() == weights[k].Select(x => int.Parse(x.ToString())).Sum())
                    {
                        if (compare < 0)//if weights[j] is before weights[k]
                        {
                            temp = int.Parse(weights[j]);
                            weights[j] = weights[k];
                            weights[k] = temp.ToString();
                        }
                    }
                }
            }
            return string.Join(",", weights);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input weights");
            string strng = Console.ReadLine();
            Console.WriteLine(orderWeight(strng));
            Console.ReadKey();
        }
    }
}

//Console.WriteLine(string.Join(" ", strng.Split(' ').OrderBy(s => s.Sum(c => c - '0')).ThenBy(s => s)));

/*StringBuilder bulder = new StringBuilder();
for (int j = 0; j < result.Count; j++)
{
    bulder.Append(result[j] + " ");
}
return bulder.ToString().Trim();*/
//sum = weights[i].Sum(x => Convert.ToInt32(x));